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

#region raddatetimepicke-getting-started_2
RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
#endregion

#region raddatetimepicke-getting-started_4
DateTime? userSelectedValue = this.radDateTimePicker.SelectedValue;
DateTime? userSelectedDate = this.radDateTimePicker.SelectedDate;
TimeSpan? userSelectedTime = this.radDateTimePicker.SelectedTime;
#endregion
}
