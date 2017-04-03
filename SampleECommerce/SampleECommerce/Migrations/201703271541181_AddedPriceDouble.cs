namespace SampleECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPriceDouble : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
        }
    }
}
