namespace SampleECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUserName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "LastName");
            DropColumn("dbo.Customers", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "LastName", c => c.String());
            AddColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
