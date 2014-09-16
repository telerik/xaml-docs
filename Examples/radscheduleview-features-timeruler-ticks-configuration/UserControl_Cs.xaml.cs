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


#region radscheduleview-features-timeruler-ticks-configuration_2
var dayView = new DayViewDefinition()
{
	MinorTickLength = new FixedTickProvider(new DateTimeInterval(5, 0, 0, 0, 0)),
	MajorTickLength = new FixedTickProvider(new DateTimeInterval(0, 1, 0, 0, 0))
};
this.ScheduleView.ViewDefinitions.Add(dayView);


var timelineView = new TimelineViewDefinition()
{
	MinorTickLength = new FixedTickProvider(new DateTimeInterval(1, 0)),
	MajorTickLength = new FixedTickProvider(new DateTimeInterval(2, 0)),
	GroupTickLength = new FixedTickProvider(new DateTimeInterval(0, 0, 1))
};
this.ScheduleView.ViewDefinitions.Add(timelineView);
#endregion

}
