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

#region raddatetimepicker-how-to-set-first-day-calendar_1
public SetFirstDayOfWeekExample()
{
    InitializeComponent();
    CultureInfo cultureInfo = new CultureInfo( "en-US" );
    DateTimeFormatInfo dateInfo = new DateTimeFormatInfo();
    dateInfo.FirstDayOfWeek = DayOfWeek.Friday;
    cultureInfo.DateTimeFormat = dateInfo;
    this.radDateTimePicker.Culture = cultureInfo;
}
#endregion
}
