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

#region radscheduleview-features-recurrences-draggingrecurrentappointment_0
var reviewApp = new Appointment()
{
     Subject = "Review",
     Start = new DateTime(2013,9,30,9,0,0),
     End = new DateTime(2013,9,30,9,30,0)
};
reviewApp.RecurrenceRule = new RecurrenceRule(
     new RecurrencePattern()
     {
        Frequency = RecurrenceFrequency.Weekly,
        DaysOfWeekMask = RecurrenceDays.Monday | RecurrenceDays.Wednesday,
        MaxOccurrences = 10
      }
);
#endregion
}
