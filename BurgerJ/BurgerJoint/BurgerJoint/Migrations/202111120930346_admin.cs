namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        AdminPwd = c.String(),
                        Item_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.AdminId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .Index(t => t.Item_ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "Item_ItemId", "dbo.Items");
            DropIndex("dbo.Admins", new[] { "Item_ItemId" });
            DropTable("dbo.Admins");
        }
    }
}
