using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.ViewModels.Pages
{
    public class BasicTablePageViewModel : Screen
    {

        public ObservableCollection<BasicTableEntry> BasicTableEntries { get; set; }
        public ObservableCollection<HoverableTableEntry> HoverableTableEntries { get; set; }

    }

    public class BasicTableEntry
    {
        public BasicTableEntry()
        {

        }
    }

    public class HoverableTableEntry
    {
        public HoverableTableEntry()
        {

        }
    }

}
