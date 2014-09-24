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

#region radganttview-features-items-relations_0
var task1 = new GanttTask(date, date.AddDays(1), "task 1");
var task2 = new GanttTask(date.AddDays(1), date.AddDays(1).AddHours(15), "task 2");

task2.Dependencies.Add(new Dependency() { FromTask=task1 });
#endregion


}
