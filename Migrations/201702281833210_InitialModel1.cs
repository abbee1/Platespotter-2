namespace PlateSpotter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoundByUserId = c.String(),
                        PlateNr = c.Int(nullable: false),
                        PlateLetter = c.String(),
                        Date = c.String(),
                        GeoGoogle = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plates");
        }
    }
}
