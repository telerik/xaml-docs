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

#region dragdropmanager-behaviors-listboxandscheduleview_0
public class ScheduleViewToAppointmentConverter : DataConverter
{		
	public override string[] GetConvertToFormats()
	{
		return new string[] { typeof(ScheduleViewDragDropPayload).FullName};
	}

	public override object ConvertTo(object data, string format)
	{
			
		if (format == typeof(ScheduleViewDragDropPayload).FullName && DataObjectHelper.GetDataPresent(data, typeof(Appointment), false))
		{
			var appointments = (IEnumerable)DataObjectHelper.GetData(data, typeof(Appointment), false);
			if (appointments != null)
			{
				return new ScheduleViewDragDropPayload(null, appointments.OfType<IOccurrence>().ToList());
			}
		}			
		return null;
	}
}
#endregion

#region dragdropmanager-behaviors-listboxandscheduleview_1
public class CustomScheduleViewDragDropBehavior : ScheduleViewDragDropBehavior
{
	public override IEnumerable<IOccurrence> ConvertDraggedData(object data)
	{
		if (DataObjectHelper.GetDataPresent(data, typeof(Appointment), false))
		{
			var appointments = DataObjectHelper.GetData(data, typeof(Appointment), true) as IEnumerable;
			if (appointments != null)
			{
				return appointments.OfType<IOccurrence>();
			}
		}

		return base.ConvertDraggedData(data);
	}
}
#endregion

}
