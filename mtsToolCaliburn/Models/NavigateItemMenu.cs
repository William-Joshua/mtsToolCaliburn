using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mtsToolCaliburn.Models
{
    public class NavigateItemMenu
    {
        public string NavItemNameTitle { get; set; }
        public Visibility SubItemArrowVisibility { get; set; }
        public PackIconMaterialKind NavItemIconKind { get; set; }
        public PackIconMaterialKind SubItemArrowKind { get; set; } 
        public Visibility SubItemVisibility { get; set; } 
        public string NavItemUrlPage { get; set; } = string.Empty; // 转换为Pages

        public List<NavigateSubItemMenu> NavigateSubMenuItems { get; set; }

        public NavigateItemMenu(NavigateMenuItem navigateMenuItem)
        {
            NavItemNameTitle = navigateMenuItem.title;
            SubItemArrowKind = PackIconMaterialKind.ChevronLeft;
            SubItemArrowVisibility = navigateMenuItem.subArrow == true ? Visibility.Visible : Visibility.Collapsed;
            NavItemIconKind = navigateMenuItem.iconType;
            SubItemVisibility = Visibility.Collapsed;
            NavItemUrlPage = navigateMenuItem.url;

            if(navigateMenuItem.subArrow == true)
            {
                NavigateSubMenuItems = new List<NavigateSubItemMenu>();
                foreach (NavigateSubMenuItem navigateSubMenuItem in navigateMenuItem.submenus.submenu)
                {
                    NavigateSubMenuItems.Add(new  NavigateSubItemMenu(navigateSubMenuItem));
                }
            }
        }
    }

    public class NavigateSubItemMenu
    {
        public string NavSubItemNameTitle { get; set; }
        public string NavSubItemUrlPage { get; set; } = string.Empty; // 转换为Pages

        public NavigateSubItemMenu(NavigateSubMenuItem navigateSubMenuItem)
        {
            NavSubItemNameTitle = navigateSubMenuItem.title;
            NavSubItemUrlPage = navigateSubMenuItem.url;
        }
    }
}
