using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoveBirds.Models
{
    public class Header
    {
        public int HeaderId { get; set; }
        public string Image { get; set; }
        public string Heading_Title { get; set; }
        public string Subtitle { get; set; }
        public string Title_1 { get; set; }
        public string Title_2 { get; set; }
        public string Title_1_Subtitle { get; set; }
        public string Title_2_Subtitle { get; set; }
        public Boolean isActive_Social { get; set; }
        public Boolean isActive_H1_Title { get; set; }
        public Boolean isActive_subtitle { get; set; }
        public Boolean showMoreInfoBtn { get; set; }
        public Boolean isActive_Title_1 { get; set; }
        public Boolean isActive_Title_2 { get; set; }
        public Boolean isActive_Title1_Subtitle { get; set; }
        public Boolean isActive_Title2_Subtitle { get; set; }
        public Boolean isActive { get; set; }
    }
}