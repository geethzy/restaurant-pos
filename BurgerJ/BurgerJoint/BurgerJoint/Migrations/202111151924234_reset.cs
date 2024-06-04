namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reset : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Category_ItemId", "dbo.Items");
            DropIndex("dbo.Orders", new[] { "Category_ItemId" });
            DropColumn("dbo.Orders", "Category_ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Category_ItemId", c => c.Int());
            CreateIndex("dbo.Orders", "Category_ItemId");
            AddForeignKey("dbo.Orders", "Category_ItemId", "dbo.Items", "ItemId");
        }
    }
}
