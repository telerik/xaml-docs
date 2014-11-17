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

#region coverflow-navigation_3
public class IntToIntValueConverter : IValueConverter
{
       object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
       {
              int val;
              int param;
              if ((int.TryParse(value.ToString(), out val) && (int.TryParse(parameter.ToString(), out param))))
              {
                     return val + param;
              }
              return value;
       }
       object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
       {
              if (value is int && parameter is int)
              {
                     return (int)value + (int)parameter;
              }
              return DependencyProperty.UnsetValue;
       }
}
#endregion
}
