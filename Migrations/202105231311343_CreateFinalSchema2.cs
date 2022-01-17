namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFinalSchema2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Customers", new[] { "Movie_Id" });
            CreateTable(
                "dbo.MovieCustomers",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Customer_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Customer_Id);
            
            DropColumn("dbo.Customers", "Movie_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Movie_Id", c => c.Int());
            DropForeignKey("dbo.MovieCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.MovieCustomers", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.MovieCustomers", new[] { "Movie_Id" });
            DropTable("dbo.MovieCustomers");
            CreateIndex("dbo.Customers", "Movie_Id");
            AddForeignKey("dbo.Customers", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
