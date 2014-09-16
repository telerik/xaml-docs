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

#region radscheduleview-features-commands_0
RadScheduleViewCommands.CreateAppointment.Execute(null, ScheduleView);
RadScheduleViewCommands.CreateAppointmentWithDialog.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_1
RadScheduleViewCommands.CreateInlineAppointment.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_2
RadScheduleViewCommands.EditAppointment.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_3
RadScheduleViewCommands.DeleteAppointment.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_4
RadScheduleViewCommands.SetDayViewMode.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_5
RadScheduleViewCommands.SetWeekViewMode.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_6
RadScheduleViewCommands.SetMonthViewMode.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_7
RadScheduleViewCommands.SetTimelineViewMode.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_8
RadScheduleViewCommands.IncreaseVisibleDateLarge.Execute(null, ScheduleView);
RadScheduleViewCommands.DecreaseVisibleDateLarge.Execute(null, ScheduleView);
#endregion

#region radscheduleview-features-commands_9
RadScheduleViewCommands.GoToPreviousAppointment.Execute(null, ScheduleView);
RadScheduleViewCommands.GoToNextAppointment.Execute(null, ScheduleView);
#endregion



	}
}
