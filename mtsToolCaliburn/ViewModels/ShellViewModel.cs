using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using mtsToolCaliburn.ViewModels.Pages;

namespace mtsToolCaliburn {
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<Screen>, IShell
    {
        public ShellViewModel()
        {
            InitializeHomePage();
        }
        public void InitializeHomePage()
        {
            ActivateItem(new HomePageViewModel());
        }

        public void PowerOff()
        {
            Application.Current.Shutdown();
        }

        public void WindowFullScreen()
        {
            if(_fullScreenState == false)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                _fullScreenState = true;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                _fullScreenState = false;
            }

        }

        private bool _fullScreenState = false;
        public bool FullScreenState
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

    }
}