namespace BurgerJoint.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class save : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.vm1");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.vm1",
                c => new
                    {
                        vm1Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Category = c.String(),
                        ItemPhoto = c.Binary(),
                    })
                .PrimaryKey(t => t.vm1Id);
            
        }
    }
}
