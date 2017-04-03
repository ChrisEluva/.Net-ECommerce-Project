namespace SampleECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "CustomerID");
            DropColumn("dbo.Customers", "CustomersID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomersID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Customers");
            DropColumn("dbo.Customers", "CustomerID");
            AddPrimaryKey("dbo.Customers", "CustomersID");
        }
    }
}
