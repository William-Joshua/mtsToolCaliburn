using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mtsToolCaliburn.ViewModels.Components
{
    public class NavigateItemViewModel: PropertyChangedBase
    {
        public string NavItemNameTitle { get; set; }
        public Visibility SubItemArrowVisibility { get; set; }
        public PackIconMaterialKind NavItemIconKind { get; set; }
        public NavigateItemViewModel()
        {
            NavItemNameTitle = "DashBoard";
            SubItemArrowVisibility = Visibility.Hidden;
            NavItemIconKind = PackIconMaterialKind.Home;
        }
        public class NavigateItemUI
        {
            public string NavItemTitle;
            public PackIconMaterialKind NavItemKind;
            public Visibility SubItemVisibility;
        }
    }
}
