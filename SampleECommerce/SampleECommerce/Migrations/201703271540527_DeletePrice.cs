namespace SampleECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Price", c => c.Single(nullable: false));
        }
    }
}
