namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groombookingnew : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GroomBookings", "Groomer_GroomerID", "dbo.Groomers");
            DropIndex("dbo.GroomBookings", new[] { "Groomer_GroomerID" });
            DropColumn("dbo.GroomBookings", "Groomer_GroomerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GroomBookings", "Groomer_GroomerID", c => c.Int());
            CreateIndex("dbo.GroomBookings", "Groomer_GroomerID");
            AddForeignKey("dbo.GroomBookings", "Groomer_GroomerID", "dbo.Groomers", "GroomerID");
        }
    }
}
