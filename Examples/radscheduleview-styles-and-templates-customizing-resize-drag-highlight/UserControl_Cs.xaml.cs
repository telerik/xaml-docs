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

	#region radganttview-howto-customize-the-timeline-0
	public class GanttDeadlineTask : GanttTask
	{
		private DateTime? ganttDeadLine;

		public DateTime? GanttDeadLine
		{
			get
			{
				return this.ganttDeadLine;
			}
			set
			{
				if (this.ganttDeadLine != value)
				{
					this.ganttDeadLine = value;
					this.OnPropertyChanged(() => this.GanttDeadLine);
				}
			}
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-1
	public class MyViewModel : ViewModelBase
	{
		private ObservableCollection<GanttTask> _Tasks;
		private DateRange _VisibleTime;

		public MyViewModel()
		{
			var date = DateTime.Now;
			var ganttAPI = new GanttDeadlineTask()
			{
				Start = date,
				End = date.AddDays(2),
				Title = "Design public API",
				Description = "Description: Design public API",
				GanttDeadLine = date.AddDays(1)
			};
			var ganttRendering = new GanttDeadlineTask()
			{
				Start = date.AddDays(2).AddHours(8),
				End = date.AddDays(4),
				Title = "Gantt Rendering",
				Description = "Description: Gantt Rendering",
				GanttDeadLine = date.AddDays(5)
			};
			var ganttDemos = new GanttDeadlineTask()
			{
				Start = date.AddDays(4.5),
				End = date.AddDays(7),
				Title = "Gantt Demos",
				Description = "Description: Gantt Demos",
				GanttDeadLine = date.AddDays(7)
			};
			var milestone = new GanttDeadlineTask()
			{
				Start = date.AddDays(7),
				End = date.AddDays(7).AddHours(1),
				Title = "Review",
				Description = "Review",
				GanttDeadLine = date.AddDays(8),
				IsMilestone = true
			};
			ganttRendering.Dependencies.Add(new Dependency() { FromTask = ganttAPI });
			ganttDemos.Dependencies.Add(new Dependency() { FromTask = ganttRendering });
			var iterationTask = new GanttTask(date, date.AddDays(7), "Iteration 1")
			{
				Children = { ganttAPI, ganttRendering, ganttDemos, milestone }
			};
			this._Tasks = new ObservableCollection<GanttTask>() { iterationTask };
			this._VisibleTime = new DateRange(date.AddDays(-1), date.AddDays(9));
		}

		public ObservableCollection<GanttTask> Tasks
		{
			get { return this._Tasks; }
			set
			{
				if (this._Tasks != value)
				{
					this._Tasks = value;
					this.OnPropertyChanged(() => this.Tasks);
				}
			}
		}

		public DateRange VisibleTime
		{
			get { return this._VisibleTime; }
			set
			{
				if (this._VisibleTime != value)
				{
					this._VisibleTime = value;
					this.OnPropertyChanged(() => this.VisibleTime);
				}
			}
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-2
	public class TimeLineDeadlineEventInfo : SlotInfo
	{
		public TimeLineDeadlineEventInfo(Range<long> timeRange, int index)
			: base(timeRange, index, index)
		{
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as TimeLineDeadlineEventInfo);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-3
	public class TimeLineDeadlineBehavior : DefaultGanttTimeLineVisualizationBehavior
	{
		protected override IEnumerable<IEventInfo> GetEventInfos(TimeLineVisualizationState state, Telerik.Windows.Core.HierarchicalItem hierarchicalItem)
		{
			foreach (var eventInfo in base.GetEventInfos(state, hierarchicalItem))
			{
				yield return eventInfo;
			}

			var task = hierarchicalItem.SourceItem as GanttDeadlineTask;
			var deadline = task != null ? task.GanttDeadLine : default(DateTime?);

			if (deadline.HasValue)
			{
				var roundedDeadline = state.Rounder.Round(new DateRange(deadline.Value, deadline.Value));
				var deadlineRange = new Range<long>(roundedDeadline.Start.Ticks, roundedDeadline.End.Ticks);

				if (deadlineRange.IntersectsWith(state.VisibleTimeRange))
				{
					yield return new TimeLineDeadlineEventInfo(deadlineRange, hierarchicalItem.Index);
				}
			}
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-4
	public class MyViewModel : ViewModelBase
	{
		...
		private ITimeLineVisualizationBehavior _TimeLineDeadlineBehavior;

		public MyViewModel()
		{
			...
			this._TimeLineDeadlineBehavior = new TimeLineDeadlineBehavior();
		}

		...

		public ITimeLineVisualizationBehavior TimeLineDeadlineBehavior
		{
			get { return this._TimeLineDeadlineBehavior; }
			set
			{
				if (this._TimeLineDeadlineBehavior != value)
				{
					this._TimeLineDeadlineBehavior = value;
					this.OnPropertyChanged(() => this.TimeLineDeadlineBehavior);
				}
			}
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-5
	public class TimeLineDeadlineContainer : Control, IDataContainer
	{
		public TimeLineDeadlineContainer()
		{
			this.DefaultStyleKey = typeof(TimeLineDeadlineContainer);
		}

		public object DataItem { get; set; }
	}
	#endregion
	
	#region radganttview-howto-customize-the-timeline-6
	public class TimeLineDeadlineContainerSelector : DefaultTimeLineContainerSelector
	{
		private static readonly ContainerTypeIdentifier timelineDeadlineEventInfoContainerType = ContainerTypeIdentifier.FromType<TimeLineDeadlineContainer>();

		public override ContainerTypeIdentifier GetContainerType(object item)
		{
			if (item is TimeLineDeadlineEventInfo)
			{
				return timelineDeadlineEventInfoContainerType;
			}

			return base.GetContainerType(item);
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-7
	public class TimeLineDeadlineEventInfo : TimeSlotInfo
	{
		public TimeLineDeadlineEventInfo(Range<long> timeRange)
			: base(timeRange)
		{
		}

		public override bool Equals(object obj)
		{
			return this.Equals(obj as TimeLineDeadlineEventInfo);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-8
	public class TimeLineDeadlineBehavior : DefaultGanttTimeLineVisualizationBehavior
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

		protected override System.Collections.IEnumerable GetBackgroundData(TimeLineVisualizationState state)
		{
			foreach (var background in base.GetBackgroundData(state))
			{
				yield return background;
			}

			var visibleRange = state.VisibleTimeRange;
			var deadline = state.Rounder.Round(new DateRange(this.projectDeadline, this.projectDeadline));
			var deadlineRange = new Range<long>(deadline.Start.Ticks, deadline.End.Ticks);

			if (visibleRange.IntersectsWith(deadlineRange))
			{
				yield return new TimeLineDeadlineEventInfo(deadlineRange);
			}
		}
	}
	#endregion

	#region radganttview-howto-customize-the-timeline-9
	public class MyViewModel : ViewModelBase
	{
		...
		private DateTime _ProjectDeadline;

		public MyViewModel()
		{
			...
			this.ProjectDeadline = date.AddDays(8);
		}

		public DateTime ProjectDeadline
		{
			get { return this._ProjectDeadline; }
			set
			{
				if (this._ProjectDeadline != value)
				{
					this._ProjectDeadline = value;
					var behavior = this._TimeLineDeadlineBehavior as TimeLineDeadlineBehavior;
					if (behavior != null)
					{
						behavior.ProjectDeadline = value;
					}
					this.OnPropertyChanged(() => this.ProjectDeadline);
				}
			}
		}
	}
	#endregion
}
