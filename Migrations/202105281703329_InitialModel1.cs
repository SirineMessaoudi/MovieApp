namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Genre = c.String(),
                        Prix = c.Single(nullable: false),
                        site_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTouristiques", t => t.site_Id)
                .Index(t => t.site_Id);
            
            CreateTable(
                "dbo.ServiceTouristiques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Description = c.String(),
                        Anciennete = c.String(),
                        busId = c.Int(),
                        Adresse = c.String(),
                        NombreEtoile = c.Int(),
                        Qualite = c.String(),
                        Telephone = c.Int(),
                        typeCuisine = c.String(),
                        FraicheurDePlats = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        bus_Id = c.Int(),
                        localisation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId, cascadeDelete: true)
                .ForeignKey("dbo.Buses", t => t.bus_Id)
                .ForeignKey("dbo.Localisations", t => t.localisation_Id)
                .Index(t => t.busId)
                .Index(t => t.bus_Id)
                .Index(t => t.localisation_Id);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroLigne = c.Int(nullable: false),
                        Horaire = c.DateTime(),
                        Transport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTouristiques", t => t.Transport_Id)
                .Index(t => t.Transport_Id);
            
            CreateTable(
                "dbo.Localisations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adresse = c.String(),
                        Ville = c.String(),
                        Pays = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Offres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NbrePersonne = c.Int(nullable: false),
                        Prix = c.Single(nullable: false),
                        Descriptif = c.String(),
                        ServiceTouristique_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTouristiques", t => t.ServiceTouristique_Id)
                .Index(t => t.ServiceTouristique_Id);
            
            CreateTable(
                "dbo.Chambres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Type = c.String(),
                        Prix = c.Single(nullable: false),
                        hotel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTouristiques", t => t.hotel_Id)
                .Index(t => t.hotel_Id);
            
            CreateTable(
                "dbo.Internautes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.Int(nullable: false),
                        Commentaire = c.String(),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceTouristiques", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Internautes", "ServiceId", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.Buses", "Transport_Id", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.Offres", "ServiceTouristique_Id", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.ServiceTouristiques", "localisation_Id", "dbo.Localisations");
            DropForeignKey("dbo.Chambres", "hotel_Id", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.ServiceTouristiques", "bus_Id", "dbo.Buses");
            DropForeignKey("dbo.ServiceTouristiques", "busId", "dbo.Buses");
            DropForeignKey("dbo.Activites", "site_Id", "dbo.ServiceTouristiques");
            DropIndex("dbo.Internautes", new[] { "ServiceId" });
            DropIndex("dbo.Chambres", new[] { "hotel_Id" });
            DropIndex("dbo.Offres", new[] { "ServiceTouristique_Id" });
            DropIndex("dbo.Buses", new[] { "Transport_Id" });
            DropIndex("dbo.ServiceTouristiques", new[] { "localisation_Id" });
            DropIndex("dbo.ServiceTouristiques", new[] { "bus_Id" });
            DropIndex("dbo.ServiceTouristiques", new[] { "busId" });
            DropIndex("dbo.Activites", new[] { "site_Id" });
            DropTable("dbo.Internautes");
            DropTable("dbo.Chambres");
            DropTable("dbo.Offres");
            DropTable("dbo.Localisations");
            DropTable("dbo.Buses");
            DropTable("dbo.ServiceTouristiques");
            DropTable("dbo.Activites");
        }
    }
}
