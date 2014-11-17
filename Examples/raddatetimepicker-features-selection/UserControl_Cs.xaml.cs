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

#region raddatetimepicker-features-selection_1
this.radDateTimePicker.SelectedValue = new DateTime( 2010, 1, 5, 10, 0, 0 );
#endregion
}
