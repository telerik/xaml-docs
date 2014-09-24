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

#region radscheduleview-features-recurrences-recurrencepatternhelper_0
var pattern = new RecurrencePattern()
{
    Frequency = RecurrenceFrequency.Daily,
    DaysOfWeekMask = RecurrenceDays.WeekDays,
    Interval = 3,
    MaxOccurrences = 10
};
#endregion

#region radscheduleview-features-recurrences-recurrencepatternhelper_2
var serializedPattern = RecurrencePatternHelper.RecurrencePatternToString(pattern);
#endregion

#region radscheduleview-features-recurrences-recurrencepatternhelper_4
var serializedPattern = "FREQ=DAILY;COUNT=10;INTERVAL=3;BYDAY=MO,TU,WE,TH,FR";
RecurrencePattern pattern;
RecurrencePatternHelper.TryParseRecurrencePattern(serializedPattern, out pattern);
#endregion
}
