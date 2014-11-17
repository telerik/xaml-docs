using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Controls.ScheduleView;

namespace AppointmentSelectionBehaviorWithResources
{

#region radscheduleview_features_appointment_selection_behavior_0
public class CustomAppointmentSelectionBehavior : AppointmentSelectionBehavior
{
}
#endregion

#region radscheduleview_features_appointment_selection_behavior_1
public class CustomAppointmentSelectionBehavior : AppointmentSelectionBehavior
{
	protected override IEnumerable<IOccurrence> GetSelectedAppointments(AppointmentSelectionState state, IOccurrence target)
	{
		var result = base.GetSelectedAppointments(state, target);

		if (result.Skip(1).Any())
		{
			var firstSelected = state.CurrentSelectedAppointments.First();
			var firstSelectedAppointment = GetAppointment(firstSelected);
			var firstSelectedResource = firstSelectedAppointment.Resources[0];

			return result.Where(occ => GetAppointment(occ).Resources.Contains(firstSelectedResource));
		}
		return result;
	}

	private static IAppointment GetAppointment(IOccurrence occurence)
	{
		return occurence is IAppointment ? ((IAppointment)occurence) : ((Occurrence)occurence).Appointment;
	}
}
#endregion

}
