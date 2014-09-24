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

#region radscheduleview-features-recurrences-overview_0
var startDate = new DateTime(2011, 05, 11, 10, 0, 0);
var appointment = new Appointment() {
    Start = startDate,
    End = startDate.AddMinutes(30),
    Subject = "Daily appointment"
};
#endregion

#region radscheduleview-features-recurrences-overview_2
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Daily,
    DaysOfWeekMask = RecurrenceDays.EveryDay,
    MaxOccurrences = 4
};
#endregion

#region radscheduleview-features-recurrences-overview_4
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-overview_6
appointment.RecurrenceRule.AddException(new DateTime(2011, 05, 14, 10, 0, 0));
#endregion

#region radscheduleview-features-recurrences-overview_8
var exceptionAppointment = (Appointment)appointment.Copy();
exceptionAppointment.Start = new DateTime(2011, 05, 18, 11, 0, 0);
exceptionAppointment.End = exceptionAppointment.Start.AddMinutes(45);
appointment.RecurrenceRule.AddException(new DateTime(2011, 05, 15, 10, 0, 0), exceptionAppointment);
#endregion
}
