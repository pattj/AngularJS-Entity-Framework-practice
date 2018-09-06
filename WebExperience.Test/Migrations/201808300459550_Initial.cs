namespace WebExperience.Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        Asset_Id = c.String(nullable: false, maxLength: 128),
                        File_Name = c.String(),
                        Mime_Type = c.String(),
                    })
                .PrimaryKey(t => t.Asset_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Assets");
        }
    }
}
