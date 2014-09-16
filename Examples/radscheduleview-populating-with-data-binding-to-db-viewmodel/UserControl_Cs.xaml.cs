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

#region radscheduleview-populating-with-data-binding-to-db-viewmodel_1
private void OnSaveExecuted(object param)
{
	ScheduleViewRepository.SaveData();
}

...

public static void SaveData()
{
	if (ScheduleViewRepository.Context.HasChanges && !ScheduleViewRepository.Context.IsSubmitting)
	{
		try
		{
			ScheduleViewRepository.Context.SubmitChanges(OnSubmitChangesCompleted, null);
		}
		catch (System.Exception)
		{
			throw;
		}
	}
}
#endregion

#region radscheduleview-populating-with-data-binding-to-db-viewmodel_2
private void LoadData()
{
	ScheduleViewRepository.Context.Load(ScheduleViewRepository.Context.GetSqlResourcesQuery()).Completed += (o, e) =>
	{
		ScheduleViewRepository.Context.Load(ScheduleViewRepository.Context.GetSqlResourceTypesQuery()).Completed += (s, a) =>
		{
			this.ResourceTypes.AddRange((s as LoadOperation).Entities);
		};

		this.OnPropertyChanged(() => this.ResourceTypes);
	};

	ScheduleViewRepository.Context.Load(ScheduleViewRepository.Context.GetTimeMarkersQuery()).Completed += (o, e) =>
	{
		this.TimeMarkers.AddRange((o as LoadOperation).Entities);
	};

	ScheduleViewRepository.Context.Load(ScheduleViewRepository.Context.GetCategoriesQuery()).Completed += (o, e) =>
	{
		this.Categories.AddRange((o as LoadOperation).Entities);
	};
}
#endregion


#region radscheduleview-populating-with-data-binding-to-db-viewmodel_3
private void OnAppointmentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
{
	if (e.Action == NotifyCollectionChangedAction.Add)
	{
		var app = e.NewItems == null ? null : e.NewItems[0] as SqlAppointment;
		if (app != null && app.EntityState != EntityState.Unmodified)
		{
			ScheduleViewRepository.Context.SqlAppointments.Add(app);
		}
	}
	else if (e.Action == NotifyCollectionChangedAction.Remove)
	{
		var app = e.OldItems == null ? null : e.OldItems[0] as SqlAppointment;
		if (app != null && ScheduleViewRepository.Context.SqlAppointments.Contains(app))
		{
			if (app.RecurrenceRule != null)
			{
				foreach (SqlExceptionOccurrence item in app.RecurrenceRule.Exceptions)
				{
					ScheduleViewRepository.Context.SqlExceptionOccurrences.Remove(item);
				}
			}

			foreach (var resource in app.SqlAppointmentResources)
			{
				ScheduleViewRepository.Context.SqlAppointmentResources.Remove(resource);
			}
			ScheduleViewRepository.Context.SqlAppointments.Remove(app);
		}
	}
}
#endregion
}
