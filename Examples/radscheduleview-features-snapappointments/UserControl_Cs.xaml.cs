using System;
using Telerik.Windows.Controls.ScheduleView;

namespace AppointmentSelectionBehaviorWithResources
{

#region radscheduleview-features-snapappointments_2
public class CustomSnapBehavior : Telerik.Windows.Controls.ScheduleView.SnapBehavior
{
}
#endregion

#region radscheduleview-features-snapappointments_3
public class CustomSnapBehavior : Telerik.Windows.Controls.ScheduleView.SnapBehavior
{

	public override DateTime SnapEnd(SnapData snapData, DateTime timeToSnap)
	{
		if (timeToSnap >= snapData.OriginalData.End)
		{
			return SnapToTimeSpan(TimeSpan.FromMinutes(5), timeToSnap, true);
		}
		else
		{
			return SnapToTimeSpan(TimeSpan.FromMinutes(5), timeToSnap, false);
		}
	}

	public override DateTime SnapStart(SnapData snapData, DateTime timeToSnap)
	{
		if (timeToSnap >= snapData.OriginalData.End)
		{
			return SnapToTimeSpan(TimeSpan.FromMinutes(5), timeToSnap, true);
		}
		else
		{
			return SnapToTimeSpan(TimeSpan.FromMinutes(5), timeToSnap, false);
		}
	}

	public static DateTime SnapToTimeSpan(TimeSpan timeSpan, DateTime timeToSnap, bool roundToBiggestNumber)
	{
		var difference = timeToSnap.Ticks % timeSpan.Ticks;
		if (roundToBiggestNumber)
		{
			return timeToSnap.AddTicks(timeSpan.Ticks - difference);
		}

		return timeToSnap.AddTicks(-difference);
	}
}
#endregion

}
