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

#region radganttview-dragdrop-radlistbox-0
public class ViewModel : ViewModelBase
{
	private ObservableCollection<Project> projects;

	public ViewModel()
	{
		this.projects = this.GetProjects();
	}

	public ObservableCollection<Project> Projects
	{
		get
		{
			return this.projects;
		}

		set
		{
			this.projects = value;
			this.OnPropertyChanged(() => this.Projects);
		}
	}

	private ObservableCollection<Project> GetProjects()
	{
		var projects = new ObservableCollection<Project>();
		projects.Add(new Project { Name = "Project 1", Start = DateTime.Today, End = DateTime.Today.AddDays(2) });
		projects.Add(new Project { Name = "Project 2", Start = DateTime.Today.AddDays(2), End = DateTime.Today.AddDays(4) });
		return projects;
	}
}
#endregion

#region radganttview-dragdrop-radlistbox-1
public class ViewModel : ViewModelBase
{
	...
	private ObservableCollection<GanttTask> tasks;

	private DateRange visibleRange;

	public ViewModel()
	{
		...
		var date = DateTime.Now;
		var ganttAPI = new GanttTask() { Start = date, End = date.AddDays(2), Title = "Design public API" };
		var ganttRendering = new GanttTask() { Start = date.AddDays(2).AddHours(8), End = date.AddDays(4), Title = "Gantt Rendering" };
		var ganttDemos = new GanttTask() { Start = date.AddDays(5), End = date.AddDays(7), Title = "Gantt Demos" };
		var milestone = new GanttTask() { Start = date.AddDays(7), End = date.AddDays(7).AddHours(1), Title = "Review", IsMilestone = true };
		ganttRendering.Dependencies.Add(new Dependency() { FromTask = ganttAPI });
		ganttDemos.Dependencies.Add(new Dependency() { FromTask = ganttRendering });
		var iterationTask = new GanttTask(date, date.AddDays(7), "Iteration 1")
		{
			Children = { ganttAPI, ganttRendering, ganttDemos, milestone }
		};

		this.tasks = new ObservableCollection<GanttTask>() { iterationTask };
		var start = this.tasks.Min(t => t.Start).Date;
		var end = this.tasks.Max(t => t.End).Date;
		this.visibleRange = new DateRange(start.AddHours(-12), end.AddDays(3));
	}
		
	...
		
	public ObservableCollection<GanttTask> GanttTasks
	{
		get
		{
			return this.tasks;
		}

		set
		{
			this.tasks = value;
			this.OnPropertyChanged(() => this.GanttTasks);
		}
	}

	public DateRange VisibleRange
	{
		get
		{
			return this.visibleRange;
		}

		set
		{
			this.visibleRange = value;
			this.OnPropertyChanged(() => this.VisibleRange);
		}
	}
		
	...
}
#endregion

#region radganttview-dragdrop-radlistbox-2
public class CustomGanttDragDropBehavior : GanttDragDropBehavior
{
	protected override bool CanStartDrag(SchedulingDragDropState state)
	{
		return state.IsReorderOperation;
	}
}
#endregion

#region radganttview-dragdrop-radlistbox-3
public class CustomGanttConverter : DataConverter
{
	public override object ConvertTo(object data, string format)
	{
		if (format == typeof(Project).FullName)
		{
			var project = DataObjectHelper.GetData(data, typeof(SchedulingDragOperationPayload), true) as SchedulingDragOperationPayload;
			if (project != null)
			{
				return project.DraggedItems.OfType<IGanttTask>().Select(p => new Project { Name = p.Title, Start = p.Start, End = p.End });
			}
		}

		return null;
	}

	public override string[] GetConvertToFormats()
	{
		return new[] { typeof(Project).FullName };
	}
}
#endregion

#region radganttview-dragdrop-radlistbox-4
public class CustomListBoxConverter : DataConverter
{
	public override object ConvertTo(object data)
	{
		var draggedProjectItem = (DataObjectHelper.GetData(data, typeof(Project), true) as List<object>).First() as Project;
		var task = new GanttTask { Title = draggedProjectItem.Name, Start = draggedProjectItem.Start, End = draggedProjectItem.End };

		return task;
	}
}
#endregion

#region radganttview-dragdrop-radlistbox-5

#endregion
}
