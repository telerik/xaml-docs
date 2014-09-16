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

#region radganttview-features-items-addremove_0
var summaryTask = new GanttTask()
{
	Start = new DateTime(2012,2,13),
	End = new DateTime(2012,2,20),
	Title = "Iteration 3",
	Progress = 45
};

Tasks.Add(summaryTask);
#endregion

#region radganttview-features-items-addremove_1
var task1 = new GanttTask()
{
	Start = new DateTime(2012,2,13),
	End = new DateTime(2012, 2, 16),
	Title = "testing"
};

var task2 = new GanttTask()
{
	Start = new DateTime(2012, 2, 16),
	End = new DateTime(2012, 2, 20),
	Title = "fixing"
};

summaryTask.Children.Add(task1);
summaryTask.Children.Add(task2);
#endregion

#region radganttview-features-items-addremove_2
summaryTask.Children.Remove(task1);
summaryTask.Children.RemoveAt(0);

Tasks.Remove(summaryTask);
#endregion
}
