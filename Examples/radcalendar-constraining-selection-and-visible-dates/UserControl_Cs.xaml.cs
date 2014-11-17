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

#region radcalendar-constraining-selection-and-visible-dates_0
if (RadCalendar.IsDisplayDateValid(calendar, DateTime.Today))
{
    calendar.DisplayDate = DateTime.Today;
}
if (RadCalendar.IsDisplayDateStartValid(calendar, DateTime.Today.AddDays(-13)))
{
    calendar.DisplayDateStart = DateTime.Today.AddDays(-13);
}
if (RadCalendar.IsSelectableDateStartValid(calendar, DateTime.Today.AddDays(-5)))
{
    calendar.SelectableDateStart = DateTime.Today.AddDays(-5);
}
#endregion
}
