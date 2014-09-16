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

#region radscheduleview-populating-with-data-binding-to-db-midtier_0
private int[] GetSqlAppointmentsIdsByRange(DateTime start, DateTime end)
{
	var result = this.ObjectContext.SqlAppointments.Where(a => (a.Start >= start && a.End <= end)).ToList<SqlAppointment>();

	return result.OfType<SqlAppointment>().Select(e => e.SqlAppointmentId).ToArray();
}

public IQueryable<SqlAppointment> GetSqlAppointmentsByRange(DateTime start, DateTime end)
{
	var ids = GetSqlAppointmentsIdsByRange(start, end);

	var result = this.ObjectContext.SqlAppointments.Where(a => ids.Contains(a.SqlAppointmentId)).ToList<SqlAppointment>();

	// Load the recurrent appointments
	foreach (var item in this.ObjectContext.SqlAppointments.Where(a => !string.IsNullOrEmpty(a.RecurrencePattern)))
	{
		if (Helper.IsOccurrenceInRange(item.RecurrencePattern, start, end) && !result.Contains(item))
		{
			result.Add(item);
		}
	}

	// Load the exceptions
	foreach (var item in this.ObjectContext.SqlAppointments.Where(a => a.Start < end && a.SqlExceptionOccurrences.Count != 0))
	{
		if (item.SqlExceptionOccurrences.Any(e => e.SqlExceptionAppointment != null && 
													e.SqlExceptionAppointment.Start >= start && 
													e.SqlExceptionAppointment.End <= end))
		{
			result.Add(item);
		}
	}

	return result.AsQueryable<SqlAppointment>();
}
#endregion
}
