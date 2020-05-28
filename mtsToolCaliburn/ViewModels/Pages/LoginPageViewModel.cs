using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace mtsToolCaliburn.ViewModels.Pages
{
    public class LoginPageViewModel : Screen, ILoginPage
    {
        private PackIconMaterialKind _loginKeepSigned;
        public PackIconMaterialKind LoginKeepSigned
        {
            get
            {
                return _loginKeepSigned;
            }
            set
            {
                _loginKeepSigned = value;
                NotifyOfPropertyChange(() => LoginKeepSigned);
            }
        }
        
        public LoginPageViewModel()
        {
            LoginKeepSigned = PackIconMaterialKind.CheckboxBlankOutline;
        }

        public void KeepAccoutSigned()
        {
            if (LoginKeepSigned == PackIconMaterialKind.CheckboxBlankOutline)
                LoginKeepSigned = PackIconMaterialKind.CheckboxMarked;
            else
                LoginKeepSigned = PackIconMaterialKind.CheckboxBlankOutline;
        }

        public void LoginCancel()
        {
            Application.Current.Shutdown();
        }

    }
}
