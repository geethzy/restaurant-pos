namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class payment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        PayDate = c.DateTime(nullable: false),
                        PayTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Orders", t => t.PaymentId)
                .Index(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "PaymentId", "dbo.Orders");
            DropIndex("dbo.Payments", new[] { "PaymentId" });
            DropTable("dbo.Payments");
        }
    }
}
