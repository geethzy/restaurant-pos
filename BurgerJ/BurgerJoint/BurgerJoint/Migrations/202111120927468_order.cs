namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        Item_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .Index(t => t.Item_ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Item_ItemId", "dbo.Items");
            DropIndex("dbo.Orders", new[] { "Item_ItemId" });
            DropTable("dbo.Orders");
        }
    }
}
