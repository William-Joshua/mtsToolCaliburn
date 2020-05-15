using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using mtsToolCaliburn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mtsToolCaliburn.ViewModels.Components
{
    public class NavigateBarItemViewModel : PropertyChangedBase
    {
        public string NavItemNameTitle { get; set; }
        public Visibility SubItemArrowVisibility { get; set; }
        public PackIconMaterialKind NavItemIconKind { get; set; }
        public string NavItemUrlPage { get; set; } = string.Empty; // 转换为Pages
        public Boolean NavPageEnableMasterTemplate { get; set; }
        public List<NavigateSubItemMenu> NavigateSubMenuItems { get; set; }
        public PackIconMaterialKind _subItemArrowKind = PackIconMaterialKind.ChevronLeft;
        public PackIconMaterialKind SubItemArrowKind
        {
            get
            {
                return _subItemArrowKind;
            }
            set
            {
                _subItemArrowKind = value;
                NotifyOfPropertyChange(() => SubItemArrowKind);
            }
        }

        public Visibility _subItemVisibility = Visibility.Collapsed;
        public Visibility SubItemVisibility
        {
            get
            {
                return _subItemVisibility;
            }
            set
            {
                _subItemVisibility = value;
                NotifyOfPropertyChange(() => SubItemVisibility);
            }
        }
        
        public int _subItemArrowKindSize = 6;
        public int SubItemArrowKindSize
        {
            get
            {
                return _subItemArrowKindSize;
            }
            set
            {
                _subItemArrowKindSize = value;
                NotifyOfPropertyChange(() => SubItemArrowKindSize);
            }
        }

        public NavigateBarItemViewModel(NavigateMenuItem navigateMenuItem)
        {
            NavItemNameTitle = navigateMenuItem.title;
            SubItemArrowVisibility = navigateMenuItem.subArrow == true ? Visibility.Visible : Visibility.Collapsed;
            NavItemIconKind = navigateMenuItem.iconType;
            NavItemUrlPage = navigateMenuItem.url;
            NavPageEnableMasterTemplate = navigateMenuItem.master;

            if (navigateMenuItem.subArrow == true)
            {
                NavigateSubMenuItems = new List<NavigateSubItemMenu>();
                foreach (NavigateSubMenuItem navigateSubMenuItem in navigateMenuItem.submenus.submenu)
                {
                    NavigateSubMenuItems.Add(new NavigateSubItemMenu(navigateMenuItem, navigateSubMenuItem));
                }
            }
        }

        public void VisibleSubMenuItems( )
        {
            if (SubItemArrowKind == PackIconMaterialKind.ChevronLeft)
            {
                SubItemArrowKind = PackIconMaterialKind.ChevronDown;
                SubItemArrowKindSize = 10;
                SubItemVisibility = Visibility.Visible;
            }
            else
            {
                SubItemArrowKind = PackIconMaterialKind.ChevronLeft;
                SubItemArrowKindSize = 6;
                SubItemVisibility = Visibility.Collapsed;
            }
        }
    }

    public class NavigateSubItemMenu
    {
        public string NavSubItemNameTitle { get; set; }
        public string NavParentGroupName { get; set; }
        public string NavSubItemUrlPage { get; set; } = string.Empty; // 转换为Pages
        public Boolean NavPageEnableMasterTemplate { get; set; }

        public NavigateSubItemMenu(NavigateMenuItem navigateMenuItem,NavigateSubMenuItem navigateSubMenuItem)
        {
            
            NavSubItemNameTitle = navigateSubMenuItem.title;
            NavParentGroupName = navigateMenuItem.title;
            NavSubItemUrlPage = navigateSubMenuItem.url;
            NavPageEnableMasterTemplate = navigateSubMenuItem.master;
        }
    }
}
