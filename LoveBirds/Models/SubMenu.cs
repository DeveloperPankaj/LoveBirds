using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoveBirds.Models
{
    public class SubMenu
    {
        public int SubMenuID { get; set; }
        public string SubMenuName { get; set; }

        public Menu Menus { get; set; }
        public int MenuId { get; set; }
    }
}