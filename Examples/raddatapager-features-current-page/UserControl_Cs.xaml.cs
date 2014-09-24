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

#region raddatapager-features-current-page_0
public class IndexToNumberConverter : IValueConverter
{
    public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
    {
        return ( int )value + 1;
    }
    public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
    {
        return ( int )value - 1;
    }
}
#endregion
}
