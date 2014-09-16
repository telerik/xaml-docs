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

#region radscheduleview-howto-get-clicked-element_0
public class ClickedElementToResourceNameConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        if (value is Appointment)
        {
            var appointment = value as Appointment;

            return "The Resource for this Appointment is: " + appointment.Resources.First();

        }
        else if (value is Slot)
        {
            var slot = value as Slot;

            return "The Resource for this Slot is: " + slot.Resources.First();
        }

        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return value;
    }
}
#endregion
}
