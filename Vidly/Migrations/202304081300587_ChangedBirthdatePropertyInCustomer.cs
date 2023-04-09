namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBirthdatePropertyInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "DOB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
