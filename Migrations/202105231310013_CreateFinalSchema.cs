namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFinalSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membershiptypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Int(nullable: false),
                        DurationMonth = c.Int(nullable: false),
                        DiscountRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "membershiptype_Id", c => c.Int());
            AddColumn("dbo.Customers", "Movie_Id", c => c.Int());
            AddColumn("dbo.Movies", "genre_Id", c => c.Int());
            CreateIndex("dbo.Customers", "membershiptype_Id");
            CreateIndex("dbo.Customers", "Movie_Id");
            CreateIndex("dbo.Movies", "genre_Id");
            AddForeignKey("dbo.Customers", "membershiptype_Id", "dbo.Membershiptypes", "Id");
            AddForeignKey("dbo.Customers", "Movie_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Movies", "genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Customers", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Customers", "membershiptype_Id", "dbo.Membershiptypes");
            DropIndex("dbo.Movies", new[] { "genre_Id" });
            DropIndex("dbo.Customers", new[] { "Movie_Id" });
            DropIndex("dbo.Customers", new[] { "membershiptype_Id" });
            DropColumn("dbo.Movies", "genre_Id");
            DropColumn("dbo.Customers", "Movie_Id");
            DropColumn("dbo.Customers", "membershiptype_Id");
            DropTable("dbo.Genres");
            DropTable("dbo.Membershiptypes");
        }
    }
}
