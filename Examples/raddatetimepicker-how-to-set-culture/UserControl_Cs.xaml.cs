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

#region raddatetimepicker-how-to-set-culture-1
InitializeComponent();

var culture = new CultureInfo("en-US");
Thread.CurrentThread.CurrentCulture = culture;
Thread.CurrentThread.CurrentUICulture = culture;
#endregion

#region raddatetimepicker-how-to-set-culture-2
InitializeComponent();

var culture = new CultureInfo("en-US");
var dtfInfo = new DateTimeFormatInfo
{
    ShortDatePattern = "MM-dd-yyyy",
    ShortTimePattern = "HH:mm",
    DateSeparator = "-"
};
culture.DateTimeFormat = dtfInfo;
Thread.CurrentThread.CurrentCulture = culture;
Thread.CurrentThread.CurrentUICulture = culture;
#endregion

#region raddatetimepicker-how-to-set-culture-3
InitializeComponent();

var culture = new CultureInfo("en-US");
var dtfInfo = new DateTimeFormatInfo
{
    ShortDatePattern = "MM-dd-yyyy",
    ShortTimePattern = "HH:mm"
};
culture.DateTimeFormat = dtfInfo;
Thread.CurrentThread.CurrentCulture = culture;
Thread.CurrentThread.CurrentUICulture = culture;
#endregion
}
