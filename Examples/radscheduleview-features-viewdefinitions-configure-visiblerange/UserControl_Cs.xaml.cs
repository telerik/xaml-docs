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

#region radscheduleview-features-viewdefinitions-configure-visiblerange_0
protected virtual DateTime GetVisibleRangeStart (DateTime currentDate, CultureInfo culture, DayOfWeek? firstDayOfWeek);

protected virtual DateTime GetVisibleRangeEnd(DateTime currentDate, CultureInfo culture, DayOfWeek? firstDayOfWeek);

#endregion



#region radscheduleview-features-viewdefinitions-configure-visiblerange_1
public class CustomMonthViewDefinition : MonthViewDefinition
{
	protected override DateTime GetVisibleRangeStart(DateTime currentDate, CultureInfo culture, DayOfWeek? firstDayOfWeek)
	{
		return CalendarHelper.GetFirstDayOfWeek(currentDate, firstDayOfWeek.Value);
	}
}
#endregion

}
