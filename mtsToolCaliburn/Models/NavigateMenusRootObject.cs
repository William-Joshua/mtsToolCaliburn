using MahApps.Metro.IconPacks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.Models
{
    public class NavigateMenusRootObject
    {
        public NavigateMenusModel menus { get; set; }
    }
    public class NavigateMenusModel
    {
        public List<NavigateMenuItem> menu { get; set; }
    }

    [JsonObject("menu")]
    public class NavigateMenuItem
    {
        public string name { get; set; }
        public string title { get; set; }
        public PackIconMaterialKind iconType { get; set; }
        public string url { get; set; }
        public bool master { get; set; }
        public Boolean subArrow { get; set; }

        public NavigateSubMenuModel submenus { get; set; }
    }


    public class NavigateSubMenuModel
    {
        public List<NavigateSubMenuItem> submenu{ get; set; }
    }

    public class NavigateSubMenuItem
    {
        public string name { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public bool master { get; set; }
    }
}
