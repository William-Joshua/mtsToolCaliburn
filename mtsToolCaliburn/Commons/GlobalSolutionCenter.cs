using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.Commons
{
    public class GlobalSolutionCenter
    {
        public static string GetScreenFullPageUrlClass(string viewModelPageUrl)
        {
            return string.Format("mtsToolCaliburn.ViewModels.{0}", viewModelPageUrl);
        }
    }
}
