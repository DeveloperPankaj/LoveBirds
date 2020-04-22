namespace LoveBirds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesHeaderSocialMedia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Headers",
                c => new
                    {
                        HeaderId = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Heading_Title = c.String(),
                        Subtitle = c.String(),
                        Title_1 = c.String(),
                        Title_2 = c.String(),
                        Title_1_Subtitle = c.String(),
                        Title_2_Subtitle = c.String(),
                        isActive_Social = c.Boolean(nullable: false),
                        isActive_H1_Title = c.Boolean(nullable: false),
                        isActive_subtitle = c.Boolean(nullable: false),
                        showMoreInfoBtn = c.Boolean(nullable: false),
                        isActive_Title_1 = c.Boolean(nullable: false),
                        isActive_Title_2 = c.Boolean(nullable: false),
                        isActive_Title1_Subtitle = c.Boolean(nullable: false),
                        isActive_Title2_Subtitle = c.Boolean(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HeaderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Headers");
        }
    }
}
