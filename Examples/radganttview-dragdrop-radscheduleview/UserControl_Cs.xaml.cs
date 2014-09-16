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

#region radganttview-dragdrop-radscheduleview-0
public class ViewModel : ViewModelBase
{
	private ObservableCollection<Appointment> appointments;

	public ViewModel()
	{
		this.appointments = this.GetAppointments();
	}

	public ObservableCollection<Appointment> Appointments
	{
		get
		{
			return this.appointments;
		}

		set
		{
			this.appointments = value;
			this.OnPropertyChanged(() => this.Appointments);
		}
	}

	private ObservableCollection<Appointment> GetAppointments()
	{
		var appointments = new ObservableCollection<Appointment>();
		appointments.Add(new Appointment
		{
			Subject = "Alexander Tuckings",
			Body = "Software Developer - C#, VB.NET / JavaScript",
			Start = DateTime.Today,
			End = DateTime.Today.AddHours(1)
		});
		appointments.Add(new Appointment
		{
			Subject = "Pett Grishith",
			Body = "ASP.NET Support Officer - Microsot SQL Server 2005 /2008",
			Start = DateTime.Today.AddDays(1),
			End = DateTime.Today.AddDays(1).AddHours(2)
		});
		appointments.Add(new Appointment
		{
			Subject = "Earick Danstin",
			Body = "Software Developer - experience with C# and ASP.NET, experience with MS SQL Server",
			Start = DateTime.Today.AddDays(2),
			End = DateTime.Today.AddDays(2).AddHours(3)
		});

		return appointments;
	}
}
#endregion

#region radganttview-dragdrop-radscheduleview-1
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

#region radganttview-dragdrop-radscheduleview-2
public class CustomGanttDragDropBehavior : GanttDragDropBehavior
{
	protected override bool CanStartDrag(SchedulingDragDropState state)
	{
		return state.IsReorderOperation;
	}
}
#endregion

#region radganttview-dragdrop-radscheduleview-3
public class CustomScheduleViewDragDropBehavior : ScheduleViewDragDropBehavior
{
	public override IEnumerable<IOccurrence> ConvertDraggedData(object data)
	{
		var payload = DataObjectHelper.GetData(data, typeof(SchedulingDragOperationPayload), true) as SchedulingDragOperationPayload;
		if (payload != null)
		{
			return payload.DraggedItems.OfType<IGanttTask>().Select(p => new Appointment { Subject = p.Title, Start = p.Start, End = p.End }).ToList<IOccurrence>();
		}

		return base.ConvertDraggedData(data);
	}

	public override bool CanStartDrag(Telerik.Windows.Controls.DragDropState state)
	{
		return state.DraggedAppointments.Count() < 2;
	}
}
#endregion

#region radganttview-dragdrop-radscheduleview-4
public class CustomScheduleViewConverter : IDataObjectProvider
{
	public object GetData(string type, bool autoConvert, IEnumerable<IOccurrence> draggedAppointments)
	{
		if (type == typeof(IDateRange).FullName)
		{
			return draggedAppointments.Select(this.CreateGanttTaskForOccurence);
		}

		return null;
	}

	public string[] GetFormats()
	{
		return new[] { typeof(ScheduleViewDragDropPayload).FullName };
	}

	private IDateRange CreateGanttTaskForOccurence(IOccurrence arg)
	{
		var app = arg as IAppointment;
		if (app != null)
		{
			return new GanttTask { Title = app.Subject, Start = app.Start, End = app.End };
		}

		return null;
	}
}
#endregion

	#region radganttview-dragdrop-radscheduleview-5

	#endregion

}
