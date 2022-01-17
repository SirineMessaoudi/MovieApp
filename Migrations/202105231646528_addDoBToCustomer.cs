namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDoBToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DoB", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DoB");
        }
    }
}
