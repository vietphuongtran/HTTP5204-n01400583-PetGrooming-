namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owners : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.Int(nullable: false, identity: true),
                        OwnerFname = c.String(),
                        OwnerLname = c.String(),
                        OwnerAddr = c.String(),
                        OwnerWPhone = c.String(),
                        OwnerHPhone = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
            DropTable("dbo.GroomServices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GroomServices",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceDuration = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            DropTable("dbo.Owners");
        }
    }
}
