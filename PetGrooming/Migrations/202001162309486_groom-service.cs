namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groomservice : DbMigration
    {
        public override void Up()
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
            
            AlterColumn("dbo.GroomBookings", "BookingPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GroomBookings", "BookingPrice", c => c.Double(nullable: false));
            DropTable("dbo.GroomServices");
        }
    }
}
