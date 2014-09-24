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

#region radscheduleview-viewdefinition-specificproperties_2
     weekDefinition.ShowWeekGroupHeaders = true;
	 weekDefinition.WeekGroupHeaderStringFormat = "Week number {0}, {1:D}";
#endregion
}
