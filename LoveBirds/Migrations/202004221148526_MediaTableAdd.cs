namespace LoveBirds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MediaTableAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        MediaName = c.String(),
                        MediaIcon = c.String(),
                        MediaURL = c.String(),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
