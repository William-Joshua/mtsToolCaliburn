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
        public ShellViewModel()
        {
            InitializeHomePage();
        }
        public void InitializeHomePage()
        {
            NavBarItem = new NavigateBarViewModel();
            LoginUserCardInfo = new LoginUserCardViewModel();
            ActivateItem(new HomePageViewModel());
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