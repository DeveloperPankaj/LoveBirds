namespace LoveBirds.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoveBirds.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoveBirds.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Menus.AddOrUpdate(
                    new Models.Menu() { MenuID = 1, MenuName = "Home" },
                    new Models.Menu() { MenuID = 2, MenuName = "Gallery" },
                    new Models.Menu() { MenuID = 3, MenuName = "Dropdown" },
                    new Models.Menu() { MenuID = 4, MenuName = "ContactUs" },
                    new Models.Menu() { MenuID = 5, MenuName = "+0987654321" }
                    );

            context.SubMenus.AddOrUpdate(
                    new Models.SubMenu() { SubMenuID = 1, SubMenuName = "Services", MenuId = 3 },
                    new Models.SubMenu() { SubMenuID = 1, SubMenuName = "About Us", MenuId = 3 },
                    new Models.SubMenu() { SubMenuID = 1, SubMenuName = "Beautiful Birds", MenuId = 3 },
                    new Models.SubMenu() { SubMenuID = 1, SubMenuName = "Why Choose Us?", MenuId = 3 },
                    new Models.SubMenu() { SubMenuID = 1, SubMenuName = "Testimonials", MenuId = 3 }
                    );

            context.SocialMedias.AddOrUpdate(
                    new Models.SocialMedia() { SocialMediaId = 1, MediaName = "Facebook", MediaURL = "https://www.facebook.com/pankaj.saxena.5661", isActive = true, MediaIcon = "" },
                    new Models.SocialMedia() { SocialMediaId = 2, MediaName = "Twitter", MediaURL = "https://www.facebook.com/pankaj.saxena.5661", isActive = true, MediaIcon = "" },
                    new Models.SocialMedia() { SocialMediaId = 3, MediaName = "Dribbble", MediaURL = "https://www.facebook.com/pankaj.saxena.5661", isActive = true, MediaIcon = "" },
                    new Models.SocialMedia() { SocialMediaId = 4, MediaName = "instagram", MediaURL = "https://www.facebook.com/pankaj.saxena.5661", isActive = true, MediaIcon = "" }
                );

            context.Headers.AddOrUpdate(
                    new Models.Header()
                    {
                        HeaderId = 1,
                        Image = "",
                        Heading_Title = "WELCOME TO LOVE BIRDS",
                        Subtitle = "Sed ut perspiciatis unde omnis iste natus error sit acntium doemque laudantium, totam rem aperiam eaque ipsa quae ab illo.",
                        Title_1 = "01. Title Here",
                        Title_2 = "02. Title Here",
                        Title_1_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        Title_2_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        isActive_Social = true,
                        isActive_H1_Title = true,
                        isActive_subtitle = true,
                        showMoreInfoBtn = true,
                        isActive_Title_1 = true,
                        isActive_Title_2 = true,
                        isActive_Title1_Subtitle = true,
                        isActive_Title2_Subtitle = true,
                        isActive = true
                    },
                    new Models.Header()
                    {
                        HeaderId = 2,
                        Image = "",
                        Heading_Title = "WELCOME TO LOVE BIRDS",
                        Subtitle = "Sed ut perspiciatis unde omnis iste natus error sit acntium doemque laudantium, totam rem aperiam eaque ipsa quae ab illo.",
                        Title_1 = "01. Title Here",
                        Title_2 = "02. Title Here",
                        Title_1_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        Title_2_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        isActive_Social = true,
                        isActive_H1_Title = true,
                        isActive_subtitle = true,
                        showMoreInfoBtn = true,
                        isActive_Title_1 = true,
                        isActive_Title_2 = true,
                        isActive_Title1_Subtitle = true,
                        isActive_Title2_Subtitle = true,
                        isActive = true
                    },
                    new Models.Header()
                    {
                        HeaderId = 3,
                        Image = "",
                        Heading_Title = "WELCOME TO LOVE BIRDS",
                        Subtitle = "Sed ut perspiciatis unde omnis iste natus error sit acntium doemque laudantium, totam rem aperiam eaque ipsa quae ab illo.",
                        Title_1 = "01. Title Here",
                        Title_2 = "02. Title Here",
                        Title_1_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        Title_2_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        isActive_Social = true,
                        isActive_H1_Title = true,
                        isActive_subtitle = true,
                        showMoreInfoBtn = true,
                        isActive_Title_1 = true,
                        isActive_Title_2 = true,
                        isActive_Title1_Subtitle = true,
                        isActive_Title2_Subtitle = true,
                        isActive = true
                    },
                    new Models.Header()
                    {
                        HeaderId = 4,
                        Image = "",
                        Heading_Title = "WELCOME TO LOVE BIRDS",
                        Subtitle = "Sed ut perspiciatis unde omnis iste natus error sit acntium doemque laudantium, totam rem aperiam eaque ipsa quae ab illo.",
                        Title_1 = "01. Title Here",
                        Title_2 = "02. Title Here",
                        Title_1_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        Title_2_Subtitle = "Lorem ipsum dolor sit amet adipi scing elit.",
                        isActive_Social = true,
                        isActive_H1_Title = true,
                        isActive_subtitle = true,
                        showMoreInfoBtn = true,
                        isActive_Title_1 = true,
                        isActive_Title_2 = true,
                        isActive_Title1_Subtitle = true,
                        isActive_Title2_Subtitle = true,
                        isActive = true
                    }
                );
        }
    }
}
