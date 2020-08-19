using Caliburn.Micro;
using mtsToolCaliburn.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.ViewModels.Pages
{
    public class DataTablePageViewModel : Screen
    {
        public ObservableCollection<DataTableEntry> DataTableEntries { get; set; } 

        public DataTablePageViewModel()
        {
            DataTableEntries = new ObservableCollection<DataTableEntry>();
            DataTableEntries.Add(new DataTableEntry("1", "2012/08/03", "Edinburgh", "New York", "$1500", "$3200",DataTableStatus.OnHold));
            DataTableEntries.Add(new DataTableEntry("2", "2015/04/01", "Doe", "Brazil", "$4500", "$7500", DataTableStatus.Pending));
            DataTableEntries.Add(new DataTableEntry("3", "2010/11/21", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry("4", "2016/01/12", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry("5", "2017/12/28", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry("6", "2000/10/30", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.OnHold));
            DataTableEntries.Add(new DataTableEntry("7", "2011/03/11", "Cris", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry("8", "2015/06/25", "Cris", "Italy", "$6300", "$2100	", DataTableStatus.OnHold));
            DataTableEntries.Add(new DataTableEntry("9", "2016/11/12", "Cris", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry("10", "2003/12/26", "Tom", "Germany", "$1100", "$2300", DataTableStatus.Pending));
        }
    }
}
