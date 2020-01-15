using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.ViewModels.Components
{
    public class NavigateBarViewModel: PropertyChangedBase
    {
        public UserBusinessCardViewModel UserBussinessCard { get; }
        public NavigateBarViewModel()
        {
            UserBussinessCard = new UserBusinessCardViewModel();
        }
    }
}
