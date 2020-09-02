using Caliburn.Micro;
using mtsToolCaliburn.Commons;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace mtsToolCaliburn.ViewModels.Templates
{
    public class PurpleGenericTemplateViewModel: Screen
    {
        private string _navPageTitle;
        public string NavPageTitle
        {
            get
            {
                return _navPageTitle;
            }
            set
            {
                _navPageTitle = value;
                NotifyOfPropertyChange(() => NavPageTitle);
            }
        }
        
        private string _navTabGroupName;
        public string NavTabGroupName
        {
            get
            {
                return _navTabGroupName;
            }
            set
            {
                _navTabGroupName = value;
                NotifyOfPropertyChange(() => NavTabGroupName);
            }
        }

        private string _navPageUrlPage;
        public string NavPageUrlPage
        {
            get
            {
                return _navPageUrlPage;
            }
            set
            {
                _navPageUrlPage = value;
                NotifyOfPropertyChange(() => NavPageUrlPage);
                InitializePurpleGenericTemplate();
            }
        }
        public Screen _navTabPage;
        public Screen NavTabPage
        {
            get
            {
                return _navTabPage;
            }
            set
            {
                _navTabPage = value;
                NotifyOfPropertyChange(() => NavTabPage);
            }
        }

        public PurpleGenericTemplateViewModel()
        {

        }

        public void InitializePurpleGenericTemplate()
        {
            Type type = Type.GetType(GlobalSolutionCenter.GetScreenFullPageUrlClass(NavPageUrlPage));
            Screen screen = System.Activator.CreateInstance(type) as Screen;
            NavTabPage = screen;
            return;
        }
    }

    public class CornerRadiusRoundedConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int originSizeEntry = System.Convert.ToInt32(Math.Round(float.Parse(value.ToString(), CultureInfo.InvariantCulture.NumberFormat)));
            return originSizeEntry/2;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
