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

#region radscheduleview-features-recurrences-recurrencepattern_0
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Monthly,
    MaxOccurrences = 10
};
var copyPattern = pattern.Copy();
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_2
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Monthly,
    MaxOccurrences = 10
};
var newPattern = new RecurrencePattern();
newPattern.CopyFrom(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_4
var startDate = new DateTime(2011, 05, 11, 10, 0, 0);
var appointment = new Appointment() {
    Start = startDate,
    End = startDate.AddHours(2),
    Subject = "Example"
};
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_6
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Daily
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_8
var pattern = new RecurrencePattern() {
      Frequency = RecurrenceFrequency.Weekly,
      DaysOfWeekMask = RecurrenceDays.WeekDays
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_10
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Daily,
    DaysOfWeekMask = RecurrenceDays.EveryDay,
    Interval = 3
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_12
var pattern = new RecurrencePattern() {
    DayOfMonth = 5,
    Frequency = RecurrenceFrequency.Monthly,
    Interval = 2
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_14
var pattern = new RecurrencePattern() {
    DayOrdinal = 2,
    DaysOfWeekMask = RecurrenceDays.Monday,
    Frequency = RecurrenceFrequency.Monthly,
    Interval = 2
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_16
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Yearly,
    MonthOfYear = 11,
    DayOfMonth = 13
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_18
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Daily,
    MaxOccurrences = 3
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepattern_20
var pattern = new RecurrencePattern() {
    Frequency = RecurrenceFrequency.Daily,
    RecursUntil = new DateTime( 2011, 05, 24, 10, 0, 0 )
};
appointment.RecurrenceRule = new RecurrenceRule(pattern);
#endregion
}
