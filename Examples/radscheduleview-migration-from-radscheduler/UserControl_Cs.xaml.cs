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

#region radscheduleview-migration-from-radscheduler_4
if (this.radScheduleView.BeginEdit(appointment))
{   
    appointment.Subject = "New Subject";
    this.radScheduleView.Commit();
}
#endregion

#region radscheduleview-migration-from-radscheduler_6
this.radScheduleView.Remove(appointment);
#endregion
}
