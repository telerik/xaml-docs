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

#region radscheduleview-viewdefinition-overview_0
            MonthViewDefinition monthDefintion = new MonthViewDefinition();
            DayViewDefinition dayDefintion = new DayViewDefinition();
            WeekViewDefinition weekDefinition = new WeekViewDefinition();
            TimelineViewDefinition timelineDefinition = new TimelineViewDefinition();
            this.scheduleView.ViewDefinitions.Add(monthDefintion);
            this.scheduleView.ViewDefinitions.Add(dayDefintion);
            this.scheduleView.ViewDefinitions.Add(timelineDefinition);
            this.scheduleView.ViewDefinitions.Add(weekDefinition);

#endregion
}
