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

#region radganttview-populating-with-data-viewmodel_1
public class MyViewModel
{
}
#endregion

#region radganttview-populating-with-data-viewmodel_2
public class MyViewModel : PropertyChangedBase
{
	private ObservableCollection<GanttTask> tasks;

	public ObservableCollection<GanttTask> Tasks
	{
		get
		{
			return tasks;
		}
		set
		{
			tasks = value;
			OnPropertyChanged(() => Tasks);
		}
	}
}
#endregion

#region radganttview-populating-with-data-viewmodel_3
public MyViewModel()
{
	var date = DateTime.Now;
			
	var ganttAPI = new GanttTask() { Start = date, End = date.AddDays(2), Title = "Design public API" };
	var ganttRendering = new GanttTask() { Start = date.AddDays(2).AddHours(8), End = date.AddDays(4), Title = "Gantt Rendering" };
	var ganttDemos = new GanttTask() { Start = date.AddDays(5), End = date.AddDays(7), Title = "Gantt Demos" };

	var milestone = new GanttTask() { Start = date.AddDays(7), End = date.AddDays(7).AddHours(1), Title = "Review", IsMilestone = true };

	ganttRendering.Dependencies.Add( new Dependency() { FromTask=ganttAPI });
	ganttDemos.Dependencies.Add(new Dependency() { FromTask = ganttRendering });

	var iterationTask = new GanttTask(date, date.AddDays(7), "Iteration 1")  {
		Children = { ganttAPI, ganttRendering, ganttDemos, milestone }
	};
			

	this.tasks = new ObservableCollection<GanttTask>() { iterationTask };
}
#endregion

#region radganttview-populating-with-data-viewmodel_5
this.DataContext = new MyViewModel();
#endregion
}
