namespace WhiskyTasting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Price : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Whiskies", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Whiskies", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
