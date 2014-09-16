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

#region radganttview-features-items-gantttask-deadline_0
var task = new GanttTask()
{
    Start = new DateTime(2014, 6, 6),
    End = new DateTime(2014, 6, 8),
    Deadline = new DateTime(2014,6,9),
    Title = "Gantt Rendering"
};
#endregion

#region radganttview-features-items-gantttask-deadline_1
public class CustomGanttTask : GanttTask
{
    protected override bool CheckIsExpired()
    {
        return this.Deadline < this.Start;
    }
}
#endregion
}
