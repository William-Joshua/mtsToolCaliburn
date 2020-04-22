using System;
using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using mtsToolCaliburn.ViewModels.Components;
using mtsToolCaliburn.ViewModels.Pages;

namespace mtsToolCaliburn {
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<Screen>, IShell
    {
        public NavigateBarViewModel NavBarItem { get; set; }
        public LoginUserCardViewModel LoginUserCardInfo { get; set; }

        public Screen _mainScreen;
        public Screen MainWindow
        {
            get
            {
                return _mainScreen;
            }
            set
            {
                _mainScreen = value;
                NotifyOfPropertyChange(() => MainWindow);
            }
        }

        public ShellViewModel()
        {
            InitializeHomePage();
        }
        public void InitializeHomePage()
        {
            NavBarItem = new NavigateBarViewModel();
            LoginUserCardInfo = new LoginUserCardViewModel();
            MainWindow = new DashboardPageViewModel();
        }

        public void Navigate2Screen(object sender)
        {
            NavigateBarItemViewModel navigateBarItemViewModel = sender as NavigateBarItemViewModel;
            if(navigateBarItemViewModel != null)
            {
                if (navigateBarItemViewModel.NavItemUrlPage == string.Empty)
                    return;
                Type  type = Type.GetType(GetScreenFullPageUrlClass(navigateBarItemViewModel.NavItemUrlPage));
                Screen screen = System.Activator.CreateInstance(type) as Screen;
                MainWindow = screen;
                return;
            }
            NavigateSubItemMenu navigateSubItemMenu = sender as NavigateSubItemMenu;
            if (navigateSubItemMenu != null)
            {
                if (navigateSubItemMenu.NavSubItemUrlPage == string.Empty)
                    return;
                Type type = Type.GetType(GetScreenFullPageUrlClass(navigateSubItemMenu.NavSubItemUrlPage));

                Screen screen = System.Activator.CreateInstance(type) as Screen;
                MainWindow = screen;
                return;
            }
        }


        public string GetScreenFullPageUrlClass(string viewModelPageUrl)
        {
            return string.Format("mtsToolCaliburn.ViewModels.{0}", viewModelPageUrl);
        }

        public void PowerOff()
        {
            Application.Current.Shutdown();
        }
        
        #region Ö÷´°ÌåËõ·Å
        public void WindowFullScreen()
        {
            if (_fullScreenState != ScreenState.Max)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                _fullScreenState = ScreenState.Max;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                _fullScreenState = ScreenState.Normal;
            }
        }
        public void WindowMinimizeScreen()
        {
            if (_fullScreenState != ScreenState.Mini)
            {
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
                _fullScreenState = ScreenState.Mini;
            }
        }
        private ScreenState _fullScreenState = ScreenState.Normal;
        public ScreenState FullScreenState
        {
            get
            {
                return _fullScreenState;
            }
            set
            {
                _fullScreenState = value;
            }
        }
        public enum ScreenState
        {
            Max,
            Normal,
            Mini
        }
        #endregion

    }
}