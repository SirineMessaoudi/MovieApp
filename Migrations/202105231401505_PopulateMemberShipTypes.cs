namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypes : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Membershiptypes(SignUpFee,DurationMonth,DiscountRate) Values (10,3,10) ");
            Sql("INSERT INTO Membershiptypes(SignUpFee,DurationMonth,DiscountRate) Values (20,3,10) ");
            Sql("INSERT INTO Membershiptypes(SignUpFee,DurationMonth,DiscountRate) Values (10,4,10) ");
        }
        
        public override void Down()
        {
        }
    }
}
