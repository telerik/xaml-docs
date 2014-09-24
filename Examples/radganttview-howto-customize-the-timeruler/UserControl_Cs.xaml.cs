using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	public partial class App : Application
	{
	}

	#region radganttview-howto-customize-the-timeruler-0
	public class MyViewModel : ViewModelBase
	{
		private ObservableCollection<GanttTask> tasks;

		private DateRange visibleTime;

		public MyViewModel()
		{
			var date = DateTime.Now;
			var ganttAPI = new GanttTask()
			{
				Start = date,
				End = date.AddDays(2),
				Title = "Design public API",
				Description = "Description: Design public API"
			};

			var ganttRendering = new GanttTask()
			{
				Start = date.AddDays(2).AddHours(8),
				End = date.AddDays(4),
				Title = "Gantt Rendering",
				Description = "Description: Gantt Rendering"
			};

			var ganttDemos = new GanttTask()
			{
				Start = date.AddDays(4.5),
				End = date.AddDays(7),
				Title = "Gantt Demos",
				Description = "Description: Gantt Demos"
			};

			var milestone = new GanttTask()
			{
				Start = date.AddDays(7),
				End = date.AddDays(7).AddHours(1),
				Title = "Review",
				Description = "Review",
				IsMilestone = true
			};


			ganttRendering.Dependencies.Add(new Dependency { FromTask = ganttAPI });
			ganttDemos.Dependencies.Add(new Dependency { FromTask = ganttRendering });

			var iterationTask = new GanttTask()
			{
				Start = date,
				End = date.AddDays(7),
				Title = "Iteration 1",
				Children = { ganttAPI, ganttRendering, ganttDemos, milestone }
			};

			this.tasks = new ObservableCollection<GanttTask>() { iterationTask };
			this.visibleTime = new DateRange(date.AddDays(-1), date.AddDays(9));
		}

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

		public DateRange VisibleTime
		{
			get
			{
				return this.visibleTime;
			}
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

	#region radganttview-howto-customize-the-timeruler-1
	public class TimeRulerDeadlineTickInfo : IEventInfo, ICellCoordinates
	{
		private Range<long> timeRange;

		public TimeRulerDeadlineTickInfo(long timeRange)
		{
			this.timeRange = new Range<long>(timeRange);
		}

		public Range<long> TimeRange
		{
			get { return this.timeRange; }
		}

		public Range<int> CellCoordinates
		{
			get { return new Range<int>(0, 2); }
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeruler-2
	public class TimeRulerDeadlineBehavior : DefaultTimeRulerVisualizationBehavior
	{
		private DateTime projectDeadline;
		public DateTime ProjectDeadline
		{
			get { return this.projectDeadline; }
			set
			{
				if (this.projectDeadline != value)
				{
					this.projectDeadline = value;
					this.OnPropertyChanged(string.Empty);
				}
			}
		}

		public override System.Collections.IEnumerable GetVisibleItems(TimeRulerVisualizationState state)
		{
			foreach (var majorTick in base.GetVisibleItems(state))
			{
				yield return majorTick;
			}

			yield return new TimeRulerDeadlineTickInfo(this.projectDeadline.Ticks);
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeruler-3
	public class MyViewModel : ViewModelBase
	{
		...
		private DateTime projectDeadline = DateTime.Today;

		private TimeRulerDeadlineBehavior timeRulerDeadlineBehavior;

		public MyViewModel()
		{
			...
			this.timeRulerDeadlineBehavior = new TimeRulerDeadlineBehavior();
			this.ProjectDeadline = date.AddDays(8);
		}

		...

		public DateTime ProjectDeadline
		{
			get
			{
				return this.projectDeadline;
			}
			set
			{
				if (this.projectDeadline != value)
				{
					this.projectDeadline = value;
					var behavior = this.timeRulerDeadlineBehavior as TimeRulerDeadlineBehavior;
					if (behavior != null)
					{
						behavior.ProjectDeadline = value;
					}
					this.OnPropertyChanged(() => this.ProjectDeadline);
				}
			}
		}

		public TimeRulerDeadlineBehavior TimeRulerDeadlineBehavior
		{
			get
			{
				return timeRulerDeadlineBehavior;
			}
			set
			{
				timeRulerDeadlineBehavior = value;
				OnPropertyChanged(() => this.TimeRulerDeadlineBehavior);
			}
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeruler-4
	public class TimeRulerDeadlineContainer : Control, IDataContainer
	{
		public TimeRulerDeadlineContainer()
		{
			this.DefaultStyleKey = typeof(TimeRulerDeadlineContainer);
		}

		public object DataItem { get; set; }
	}
	#endregion

	#region radganttview-howto-customize-the-timeruler-5
	public class TimeRulerDeadlineContainerSelector : DefaultTimeRulerContainerSelector
	{
		private static readonly ContainerTypeIdentifier timeRulerDeadlineContainerType = ContainerTypeIdentifier.FromType<TimeRulerDeadlineContainer>();

		public override ContainerTypeIdentifier GetContainerType(object item)
		{
			if (item is TimeRulerDeadlineTickInfo)
			{
				return timeRulerDeadlineContainerType;
			}
			return base.GetContainerType(item);
		}
	}
	#endregion
}
