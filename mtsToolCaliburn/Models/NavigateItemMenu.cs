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

        public NavigateItemMenu(NavigateMenuItem navigateMenuItem)
        {
            NavItemNameTitle = navigateMenuItem.title;
            SubItemArrowVisibility = navigateMenuItem.subArrow == true ? Visibility.Visible : Visibility.Hidden;
            NavItemIconKind = navigateMenuItem.iconType;
        }
    }
}
