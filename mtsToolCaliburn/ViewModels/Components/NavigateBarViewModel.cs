using Caliburn.Micro;
using mtsToolCaliburn.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.ViewModels.Components
{
    public class NavigateBarViewModel : PropertyChangedBase
    {
        private string navMenuItemsAddr = string.Format("{0}/Resources/navMenuItems.json", Environment.CurrentDirectory);

        public UserBusinessCardViewModel UserBussinessCard { get; }

        public List<NavigateItemViewModel> NavBarItems { get; } = new List<NavigateItemViewModel>();
        public NavigateBarViewModel()
        {
            NavigateMenusRootObject NavigateMenus = new NavigateMenusRootObject();
            
            using (StreamReader reader = new StreamReader(navMenuItemsAddr))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                NavigateMenus =(NavigateMenusRootObject) jsonSerializer.Deserialize(reader,typeof(NavigateMenusRootObject));
            }
            UserBussinessCard = new UserBusinessCardViewModel();
            foreach(var NavigateMenu in NavigateMenus.menus.menu)
            {
                NavigateItemViewModel navigateItemViewModel = new NavigateItemViewModel(NavigateMenu);
                NavBarItems.Add(navigateItemViewModel);
            }
        }
    }
}
