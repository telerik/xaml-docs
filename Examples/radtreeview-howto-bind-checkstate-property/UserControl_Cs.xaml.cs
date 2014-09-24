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

#region radtreeview-howto-bind-checkstate-property_0
public class Person
{
    public bool IsChecked
    {
        get;
        set;
    }
    // Other class members...
}
#endregion

#region radtreeview-howto-bind-checkstate-property_3
public class CheckStateConverter : IValueConverter
{
    public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
    {
        bool result = ( bool )value;
        return result ? ToggleState.On : ToggleState.Off;
    }
    public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
    {
        ToggleState state = ( ToggleState )value;
        return state == ToggleState.On ? true : false;
    }
}
#endregion

#region radtreeview-howto-bind-checkstate-property_6
public class CheckStateConverter : IValueConverter
{
    public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
    {
        bool result = ( bool )value;
        return result ? ToggleState.On : ToggleState.Off;
    }
    public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
    {
        ToggleState state = ( ToggleState )value;
        return state == ToggleState.On ? true : false;
    }
}
#endregion
}
