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

#region radganttview-features-items-highlighting_0
public class MyViewModel : PropertyChangedBase
{
	private ObservableCollection<GanttTask> tasks;

	public ObservableCollection<GanttTask> Tasks
	{
	...
	}

	private ObservableCollection<GanttTask> highlightedTasks;

	public ObservableCollection<GanttTask> HighlightedTasks
	{
		get
		{
			return highlightedTasks;
		}
		set
		{
			highlightedTasks = value;
			OnPropertyChanged(() => HighlightedTasks);
		}
	}
...
}
#endregion


#region radganttview-features-items-highlighting_1
public MyViewModel()
{
	...
	this.HighlightedTasks = new ObservableCollection<GanttTask>() { Tasks[0], Tasks[2] };
}
#endregion
}
