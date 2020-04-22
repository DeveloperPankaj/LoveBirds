using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoveBirds.Models
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string MediaName { get; set; }
        public string MediaIcon { get; set; }
        public string MediaURL { get; set; }
        public Boolean isActive { get; set; }
    }
}