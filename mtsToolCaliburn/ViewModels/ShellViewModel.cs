using System.ComponentModel.Composition;
using Caliburn.Micro;
using mtsToolCaliburn.ViewModels.Pages;

namespace mtsToolCaliburn {
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<Screen>, IShell
    {
        public ShellViewModel(HomePageViewModel homePageModel)
        {
            HomePageModel = homePageModel;
        }
        public HomePageViewModel HomePageModel { get; private set; }
    }
}