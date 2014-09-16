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

#region radscheduleview-viewdefinition-configuration_1
	dayDefintion.LargeChangeInterval = new Telerik.Windows.Controls.ScheduleView.
	DateTimeInterval(2, 0);
	monthDefinition.LargeChangeInterval = new Telerik.Windows.Controls.ScheduleView.
	DateTimeInterval(4, 2);
#endregion

#region radscheduleview-viewdefinition-configuration_3
	monthDefintion.SmallChangeInterval = new Telerik.Windows.Controls.ScheduleView.
	DateTimeInterval(11, 0);
	timelineDefinition.SmallChangeInterval = new Telerik.Windows.Controls.ScheduleView.
	DateTimeInterval(3, 0);
#endregion

#region radscheduleview-viewdefinition-configuration_5
	dayDefintion.DayStartTime = new TimeSpan(7, 30, 00);
	weekDefinition.DayStartTime = new TimeSpan(8, 0, 0);
	timelineDefinition.DayStartTime = new TimeSpan(11, 30, 0);
#endregion

#region radscheduleview-viewdefinition-configuration_7
	dayDefintion.DayStartTime = new TimeSpan(17, 30, 00);
	weekDefinition.DayStartTime = new TimeSpan(18, 0, 0);
	timelineDefinition.DayStartTime = new TimeSpan(21, 30, 0);
#endregion

#region radscheduleview-viewdefinition-configuration_9
	dayDefintion.VisibleDays = 4;
	weekDefinition.VisibleDays = 11;
	monthDefintion.VisibleDays = 21;
	timelineDefinition.VisibleDays = 9;
#endregion

#region radscheduleview-viewdefinition-configuration_11
	dayDefintion.Orientation = Orientation.Horizontal;
	weekDefinition.Orientation = Orientation.Horizontal;
	timelineDefinition.Orientation = Orientation.Vertical;
#endregion




}
