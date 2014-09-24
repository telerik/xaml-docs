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

#region radscheduleview-end-user-capabilities-create-appointment_0
IAppointment appointment = this.radScheduleView.CreateNew();
appointment.Start = DateTime.Now;
appointment.End = DateTime.Now.AddHours(1);
appointment.Subject = "New appointment";
this.radScheduleView.Commit();
#endregion
}
