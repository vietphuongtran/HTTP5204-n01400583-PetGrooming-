namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groombooking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroomBookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        BookingDateTime = c.DateTime(nullable: false),
                        BookingPrice = c.Double(nullable: false),
                        Groomer_GroomerID = c.Int(),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Groomers", t => t.Groomer_GroomerID)
                .Index(t => t.Groomer_GroomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroomBookings", "Groomer_GroomerID", "dbo.Groomers");
            DropIndex("dbo.GroomBookings", new[] { "Groomer_GroomerID" });
            DropTable("dbo.GroomBookings");
        }
    }
}
