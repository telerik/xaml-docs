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

#region radscheduleview-howto-set-custom-appointment-height_0
public class AppointmentStyleSelector : OrientedAppointmentItemStyleSelector
{
    public Style SmallAppointmentStyle { get; set; }
    public Style RegularAppointmentStyle { get; set; }
    public Style BigAppointmentStyle { get; set; }

    public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDefinition)
    {
        var appointment = item as Appointment;

        if (appointment != null)
        {
            if (appointment.Duration() <= new TimeSpan(1, 0, 0))
            {
                return this.SmallAppointmentStyle;
            }
            else if (appointment.Duration() <= new TimeSpan(2, 0, 0))
            {
                return this.RegularAppointmentStyle;
            }
            else if (appointment.Duration() > new TimeSpan(2, 0, 0))
            {
                return this.BigAppointmentStyle;
            }
        }

        return base.SelectStyle(item, container, activeViewDefinition);
    }
}
#endregion
}
