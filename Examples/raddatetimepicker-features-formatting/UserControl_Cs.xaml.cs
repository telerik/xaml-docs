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

#region raddatetimepicker-features-formatting_2
this.radDateTimePicker.Culture = new System.Globalization.CultureInfo( "de" );
#endregion

#region raddatetimepicker-features-formatting_4
this.radDateTimePicker.Culture = new System.Globalization.CultureInfo("en-US");
this.radDateTimePicker.Culture.DateTimeFormat.ShortDatePattern = "dd-MMM";
this.radDateTimePicker.Culture.DateTimeFormat.ShortTimePattern = "h tt";
#endregion
}
