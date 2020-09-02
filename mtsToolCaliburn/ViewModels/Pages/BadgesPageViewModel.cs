using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace mtsToolCaliburn.ViewModels.Pages
{
    public class BadgesPageViewModel : Screen
    {
        public ObservableCollection<BadgesEntry> NormalBadgesEntries { get; set; }
        public ObservableCollection<BadgesEntry> BadgePillsEntries { get; set; }
        public ObservableCollection<BadgesEntry> BadgeOutlinedVariationsEntries { get; set; }

        public BadgesPageViewModel()
        {
            NormalBadgesEntries = new ObservableCollection<BadgesEntry>();
            NormalBadgesEntries.Add(new BadgesEntry("Primary label", BadgeType.PRIMARY));
            NormalBadgesEntries.Add(new BadgesEntry("Info label", BadgeType.INFO));
            NormalBadgesEntries.Add(new BadgesEntry("Danger label", BadgeType.DANGER));
            NormalBadgesEntries.Add(new BadgesEntry("Success label", BadgeType.SUCCESS));
            NormalBadgesEntries.Add(new BadgesEntry("Warning label", BadgeType.WARNING));
            BadgePillsEntries = new ObservableCollection<BadgesEntry>();
            BadgePillsEntries.Add(new BadgesEntry("Primary label", BadgeType.PRIMARY));
            BadgePillsEntries.Add(new BadgesEntry("Info label", BadgeType.INFO));
            BadgePillsEntries.Add(new BadgesEntry("Danger label", BadgeType.DANGER));
            BadgePillsEntries.Add(new BadgesEntry("Success label", BadgeType.SUCCESS));
            BadgePillsEntries.Add(new BadgesEntry("Warning label", BadgeType.WARNING));
            BadgeOutlinedVariationsEntries = new ObservableCollection<BadgesEntry>();
            BadgeOutlinedVariationsEntries.Add(new BadgesEntry("Primary label", BadgeType.PRIMARY));
            BadgeOutlinedVariationsEntries.Add(new BadgesEntry("Info label", BadgeType.INFO));
            BadgeOutlinedVariationsEntries.Add(new BadgesEntry("Danger label", BadgeType.DANGER));
            BadgeOutlinedVariationsEntries.Add(new BadgesEntry("Success label", BadgeType.SUCCESS));
            BadgeOutlinedVariationsEntries.Add(new BadgesEntry("Warning label", BadgeType.WARNING));
        }

    }
    public class NormalBadgesConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var badgesEntry = (BadgeType)value;
            return App.Current.Resources[string.Format("badge-{0}", (Enum.GetName(typeof(BadgeType), badgesEntry)).ToLower())];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class BadgePillsConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var badgesEntry = (BadgeType)value;
            return App.Current.Resources[string.Format("badge-pill-{0}", (Enum.GetName(typeof(BadgeType), badgesEntry)).ToLower())];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class BadgeOutlineNormalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var badgesEntry = (BadgeType)value;
            return App.Current.Resources[string.Format("badge-outline-normal-{0}", (Enum.GetName(typeof(BadgeType), badgesEntry)).ToLower())];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class BadgeOutlineRoundedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var badgesEntry = (BadgeType)value;
            return App.Current.Resources[string.Format("badge-outline-rounded-{0}", (Enum.GetName(typeof(BadgeType), badgesEntry)).ToLower())];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class BadgesEntry
    {
        public string Item { get; set; }

        public BadgeType Label { get; set; }

        public BadgesEntry(string item, BadgeType label)
        {
            Item = item;
            Label = label;
        }
    }

    public enum BadgeType
    {
        PRIMARY,
        INFO,
        DANGER,
        SUCCESS,
        WARNING
    }
}
