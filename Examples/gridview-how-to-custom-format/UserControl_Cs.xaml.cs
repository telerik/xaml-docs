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
#region gridview-how-to-custom-format_0
private void Application_Startup(object sender, StartupEventArgs e)
{
	System.Globalization.CultureInfo cultureInfo =
			new System.Globalization.CultureInfo("en-US");
	System.Globalization.DateTimeFormatInfo dateTimeInfo =
	new System.Globalization.DateTimeFormatInfo();
	dateTimeInfo.LongDatePattern = "dd--MMM--yyyy";
	dateTimeInfo.ShortDatePattern = "dd--MMM--yy";
	cultureInfo.DateTimeFormat = dateTimeInfo;
	cultureInfo.NumberFormat.NumberGroupSeparator = "/";
	cultureInfo.NumberFormat.NegativeSign = "/";

	Thread.CurrentThread.CurrentCulture = cultureInfo;
	Thread.CurrentThread.CurrentUICulture = cultureInfo;

	this.RootVisual = new MainPage();
}
#endregion

}
