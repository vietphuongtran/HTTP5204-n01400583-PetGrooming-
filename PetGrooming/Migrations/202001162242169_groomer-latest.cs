namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class groomerlatest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerID = c.Int(nullable: false, identity: true),
                        GroomerFName = c.String(),
                        GroomerLname = c.String(),
                        GroomerDOB = c.DateTime(nullable: false),
                        GroomerPhone = c.String(),
                        GroomerRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GroomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
