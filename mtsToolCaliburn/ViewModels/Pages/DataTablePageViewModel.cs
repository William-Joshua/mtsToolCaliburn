using Caliburn.Micro;
using mtsToolCaliburn.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace mtsToolCaliburn.ViewModels.Pages
{
    public class DataTablePageViewModel : Screen
    {
        /// <summary>
        /// 表单默认分页行数
        /// </summary>
        private static string _defaulePagination = "10";
        /// <summary>
        /// 分页数目
        /// </summary>
        private string _paginationLine = _defaulePagination;
        public string PaginationLine
        {
            get
            {
                return _paginationLine;
            }
            set
            {
                _paginationLine = value;
                NotifyOfPropertyChange(() => PaginationLine);
            }
        }
        
        /// <summary>
        /// 快速查询框
        /// </summary>
        private string _tableSearchValue = string.Empty;
        public string TableSearchValue
        {
            get
            {
                return _tableSearchValue;
            }
            set
            {
                _tableSearchValue = value;
                NotifyOfPropertyChange(() => TableSearchValue);
            }
        }

        /// <summary>
        /// 表单快速查询
        /// </summary>
        public void QuickQueryTableSearch()
        {
            Expression<Func< DataTableEntry,bool>> allTableContains = DataTabeAllTableContainsExpression<DataTableEntry>(_tableSearchValue);
            throw new NotImplementedException();
        }

        private Expression<Func<T, bool>> DataTabeAllTableContainsExpression<T>(string tableSearchValue)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "x");
            Expression proerty = Expression.Property(parameterExpression, typeof(T).GetProperty("Customer"));
            ConstantExpression constantExpression = Expression.Constant(tableSearchValue, typeof(string));

            MethodCallExpression allTableContains = Expression.Call(
            proerty,
            typeof(T).GetMethod("Contains"),
             new Expression[] { constantExpression });
            return Expression.Lambda<Func<T, bool>>(allTableContains, new ParameterExpression[]{
                    parameterExpression});
        }

        /// <summary>
        /// 表单数据源
        /// </summary>
        private ObservableCollection<DataTableEntry> _dataTableEntries;
        public ObservableCollection<DataTableEntry> DataTableEntries
        {
            get
            {
                return _dataTableEntries;
            }
            set
            {
                _dataTableEntries = value;
                NotifyOfPropertyChange(() => DataTableEntries);
            }
        }

        private List<DataTableEntry> _dataTableEntriesSource;
        
        public DataTablePageViewModel()
        {
               DataTableEntries = new ObservableCollection<DataTableEntry>();
            DataTableEntries.Add(new DataTableEntry(1, "2012/08/03", "Edinburgh", "New York", "$1500", "$3200",DataTableStatus.OnHold));
            DataTableEntries.Add(new DataTableEntry(2, "2015/04/01", "Doe", "Brazil", "$4500", "$7500", DataTableStatus.Pending));
            DataTableEntries.Add(new DataTableEntry(3, "2010/11/21", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry(4, "2016/01/12", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry(5, "2017/12/28", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry(6, "2000/10/30", "Sam", "Tokyo", "$2100", "$6300", DataTableStatus.OnHold));
            DataTableEntries.Add(new DataTableEntry(7, "2011/03/11", "Cris", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry(8, "2015/06/25", "Cris", "Italy", "$6300", "$2100	", DataTableStatus.OnHold));
            DataTableEntries.Add(new DataTableEntry(9, "2016/11/12", "Cris", "Tokyo", "$2100", "$6300", DataTableStatus.Closed));
            DataTableEntries.Add(new DataTableEntry(10, "2003/12/26", "Tom", "Germany", "$1100", "$2300", DataTableStatus.Pending));
        }
    }
}
