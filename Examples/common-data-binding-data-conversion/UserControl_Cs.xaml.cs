using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region common-data-binding-data-conversion_0
public class BackgroundConverter: IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        TimeSlot slot = value as TimeSlot;
        if (slot.Start == DateTime.Today)
            return  new SolidColorBrush(Colors.Red);
        return  new SolidColorBrush(Colors.White);
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return null;
    }
}
#endregion
}
