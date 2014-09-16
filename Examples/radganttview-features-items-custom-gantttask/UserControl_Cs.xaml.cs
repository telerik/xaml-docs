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

#region radganttview-features-items-custom-gantttask_0
public class MyGanttTask : GanttTask
{
}
#endregion

#region radganttview-features-items-custom-gantttask_1
public class MyGanttTask : GanttTask
{
	public string CustomDescription { get; set; }
}
#endregion

#region radganttview-features-items-custom-gantttask_2
public class ViewModel : ViewModelBase
{
	private ObservableCollection<MyGanttTask> tasks;

	private DateRange visibleTime;

	public ViewModel()
	{
		var date = DateTime.Now;
		var ganttAPI = new MyGanttTask()
		{
			Start = date,
			End = date.AddDays(2),
			Title = "Design public API",
			Description = "Description: Design public API",
			CustomDescription = "Custom Description: Design public API"
		};
		var ganttRendering = new MyGanttTask()
		{
			Start = date.AddDays(2).AddHours(8),
			End = date.AddDays(4),
			Title = "Gantt Rendering",
			Description = "Description: Gantt Rendering",
			CustomDescription = "Custom Description: Gantt Rendering"
		};
		var ganttDemos = new MyGanttTask()
		{
			Start = date.AddDays(4.5),
			End = date.AddDays(7),
			Title = "Gantt Demos",
			Description = "Description: Gantt Demos",
			CustomDescription = "Custom Description: Gantt Demos"
		};
		var milestone = new MyGanttTask()
		{
			Start = date.AddDays(7),
			End = date.AddDays(7).AddHours(1),
			Title = "Review",
			Description = "Description: Review",
			IsMilestone = true,
			CustomDescription = "Custom Description: Review"
		};

		ganttRendering.Dependencies.Add(new Dependency() { FromTask = ganttAPI });
		ganttDemos.Dependencies.Add(new Dependency() { FromTask = ganttRendering });

		var iterationTask = new MyGanttTask()
		{
			Start = date,
			End = date.AddDays(7),
			Title = "Iteration 1",
			Children = { ganttAPI, ganttRendering, ganttDemos, milestone },
			CustomDescription = "Custom Description: Iteration 1"
		};

		this.tasks = new ObservableCollection<MyGanttTask>() { iterationTask };
		this.visibleTime = new DateRange(date.AddDays(-1), date.AddDays(9));
	}

	public ObservableCollection<MyGanttTask> Tasks
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

	public DateRange VisibleTime
	{
		get { return this.visibleTime; }
		set
		{
			if (this.visibleTime != value)
			{
				this.visibleTime = value;
				this.OnPropertyChanged(() => this.VisibleTime);
			}
		}
	}
}
#endregion

#region radganttview-features-items-custom-gantttask_3
IEnumerable IDependant.Dependencies
{
	get { return this.Dependencies; }
}

public IDependency AddDependency(IGanttTask fromTask, DependencyType type)
{
	if (fromTask != null)
	{
		var dependency = new Dependency { FromTask = fromTask, Type = type };

		this.Dependencies.Add(dependency);
		return dependency;
	}

	return null;
}

public bool RemoveDependency(IDependency dependency)
{
	return false;
}
#endregion
}
