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

#region radscheduleview-populating-with-data-binding-to-db-viewmodel-wpf_1
private void OnSaveExecuted(object param) 
{
	ScheduleViewRepository.SaveData();
}

...

public static bool SaveData()
{
	return ScheduleViewRepository.Context.SaveChanges() > 0;
}
#endregion

#region radscheduleview-populating-with-data-binding-to-db-viewmodel-wpf_2
private void LoadData()
{
	this.ResourceTypes.AddRange(ScheduleViewRepository.Context.SqlResourceTypes);

	this.TimeMarkers.AddRange(ScheduleViewRepository.Context.TimeMarkers);

	this.Categories.AddRange(ScheduleViewRepository.Context.Categories);
}
#endregion


#region radscheduleview-populating-with-data-binding-to-db-viewmodel-wpf_3
private void OnAppointmentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
	if (e.Action == NotifyCollectionChangedAction.Add)
	{
		var app = e.NewItems == null ? null : e.NewItems[0] as SqlAppointment;
		if (app != null && app.EntityState == EntityState.Added)
		{
			ScheduleViewRepository.Context.AddToSqlAppointments(app);
		}
	}
	else if (e.Action == NotifyCollectionChangedAction.Remove)
	{
		var app = e.OldItems == null ? null : e.OldItems[0] as SqlAppointment;
		if (app != null && ScheduleViewRepository.Context.SqlAppointments.Any(a => a.SqlAppointmentId == app.SqlAppointmentId))
		{
			if (app.RecurrenceRule != null)
			{
				var tempList = app.RecurrenceRule.Exceptions.ToList();

				foreach (SqlExceptionOccurrence item in tempList)
				{
					ScheduleViewRepository.Context.SqlExceptionOccurrences.DeleteObject(item);
				}
			}

			var tempAppList = ScheduleViewRepository.Context.SqlAppointmentResources.ToList();

			foreach (var item in tempAppList)
			{
				ScheduleViewRepository.Context.SqlAppointmentResources.DeleteObject(item);
			}

			ScheduleViewRepository.Context.SqlAppointments.DeleteObject(app);
		}
	}
}
#endregion
}
