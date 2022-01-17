namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Offres", "ServiceTouristique_Id", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.ServiceTouristiques", "localisation_Id", "dbo.Localisations");
            DropForeignKey("dbo.ServiceTouristiques", "busId", "dbo.Buses");
            DropForeignKey("dbo.ServiceTouristiques", "bus_Id", "dbo.Buses");
            DropIndex("dbo.ServiceTouristiques", new[] { "busId" });
            DropIndex("dbo.ServiceTouristiques", new[] { "localisation_Id" });
            DropIndex("dbo.Offres", new[] { "ServiceTouristique_Id" });
            DropColumn("dbo.ServiceTouristiques", "bus_Id");
            RenameColumn(table: "dbo.ServiceTouristiques", name: "localisation_Id", newName: "LocalisationId");
            RenameColumn(table: "dbo.ServiceTouristiques", name: "busId", newName: "bus_Id");
            CreateTable(
                "dbo.ServiceTouristiqueOffres",
                c => new
                    {
                        ServiceTouristique_Id = c.Int(nullable: false),
                        Offre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceTouristique_Id, t.Offre_Id })
                .ForeignKey("dbo.ServiceTouristiques", t => t.ServiceTouristique_Id, cascadeDelete: true)
                .ForeignKey("dbo.Offres", t => t.Offre_Id, cascadeDelete: true)
                .Index(t => t.ServiceTouristique_Id)
                .Index(t => t.Offre_Id);
            
            AddColumn("dbo.ServiceTouristiques", "bus_Id1", c => c.Int());
            AddColumn("dbo.ServiceTouristiques", "restaurant_Id", c => c.Int());
            AddColumn("dbo.ServiceTouristiques", "restaurant_Id1", c => c.Int());
            AlterColumn("dbo.ServiceTouristiques", "LocalisationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Internautes", "Note", c => c.Int());
            CreateIndex("dbo.ServiceTouristiques", "LocalisationId");
            CreateIndex("dbo.ServiceTouristiques", "bus_Id1");
            CreateIndex("dbo.ServiceTouristiques", "restaurant_Id");
            CreateIndex("dbo.ServiceTouristiques", "restaurant_Id1");
            AddForeignKey("dbo.ServiceTouristiques", "restaurant_Id", "dbo.ServiceTouristiques", "Id");
            AddForeignKey("dbo.ServiceTouristiques", "restaurant_Id1", "dbo.ServiceTouristiques", "Id");
            AddForeignKey("dbo.ServiceTouristiques", "LocalisationId", "dbo.Localisations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ServiceTouristiques", "bus_Id", "dbo.Buses", "Id");
            AddForeignKey("dbo.ServiceTouristiques", "bus_Id1", "dbo.Buses", "Id");
            DropColumn("dbo.Offres", "ServiceTouristique_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offres", "ServiceTouristique_Id", c => c.Int());
            DropForeignKey("dbo.ServiceTouristiques", "bus_Id1", "dbo.Buses");
            DropForeignKey("dbo.ServiceTouristiques", "bus_Id", "dbo.Buses");
            DropForeignKey("dbo.ServiceTouristiques", "LocalisationId", "dbo.Localisations");
            DropForeignKey("dbo.ServiceTouristiques", "restaurant_Id1", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.ServiceTouristiques", "restaurant_Id", "dbo.ServiceTouristiques");
            DropForeignKey("dbo.ServiceTouristiqueOffres", "Offre_Id", "dbo.Offres");
            DropForeignKey("dbo.ServiceTouristiqueOffres", "ServiceTouristique_Id", "dbo.ServiceTouristiques");
            DropIndex("dbo.ServiceTouristiqueOffres", new[] { "Offre_Id" });
            DropIndex("dbo.ServiceTouristiqueOffres", new[] { "ServiceTouristique_Id" });
            DropIndex("dbo.ServiceTouristiques", new[] { "restaurant_Id1" });
            DropIndex("dbo.ServiceTouristiques", new[] { "restaurant_Id" });
            DropIndex("dbo.ServiceTouristiques", new[] { "bus_Id1" });
            DropIndex("dbo.ServiceTouristiques", new[] { "LocalisationId" });
            AlterColumn("dbo.Internautes", "Note", c => c.Int(nullable: false));
            AlterColumn("dbo.ServiceTouristiques", "LocalisationId", c => c.Int());
            DropColumn("dbo.ServiceTouristiques", "restaurant_Id1");
            DropColumn("dbo.ServiceTouristiques", "restaurant_Id");
            DropColumn("dbo.ServiceTouristiques", "bus_Id1");
            DropTable("dbo.ServiceTouristiqueOffres");
            RenameColumn(table: "dbo.ServiceTouristiques", name: "bus_Id", newName: "busId");
            RenameColumn(table: "dbo.ServiceTouristiques", name: "LocalisationId", newName: "localisation_Id");
            AddColumn("dbo.ServiceTouristiques", "bus_Id", c => c.Int());
            CreateIndex("dbo.Offres", "ServiceTouristique_Id");
            CreateIndex("dbo.ServiceTouristiques", "localisation_Id");
            CreateIndex("dbo.ServiceTouristiques", "busId");
            AddForeignKey("dbo.ServiceTouristiques", "bus_Id", "dbo.Buses", "Id");
            AddForeignKey("dbo.ServiceTouristiques", "busId", "dbo.Buses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ServiceTouristiques", "localisation_Id", "dbo.Localisations", "Id");
            AddForeignKey("dbo.Offres", "ServiceTouristique_Id", "dbo.ServiceTouristiques", "Id");
        }
    }
}
