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


#region radscheduleview-features-timeruler-scrolling_1
ScheduleView.FirstVisibleTime = TimeSpan.FromHours(8);
#endregion

#region radscheduleview-features-timeruler-scrolling_2
ScheduleView.ScrollIntoView(meetingApp);
#endregion

#region radscheduleview-features-timeruler-scrolling_3
ScheduleView.ScrollIntoView(meetingApp, true);
#endregion

#region radscheduleview-features-timeruler-scrolling_4
ScheduleView.ScrollTimeRuler(TimeSpan.FromHours(10), true);
#endregion
}
