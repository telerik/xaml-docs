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

#region radganttview-features-timeruler-conversion-1
var maxTicks = this.GanttView.VisibleRange.End.Subtract(this.GanttView.VisibleRange.Start).Ticks / 760;

this.GanttView.PixelLength = TimeSpan.FromTicks(maxTicks);
#endregion

#region radganttview-features-timeruler-conversion-2
var maxTicks = this.GanttView.PixelLength.Ticks;

var pixels = this.GanttView.VisibleRange.End.Subtract(this.GanttView.VisibleRange.Start).Ticks / maxTicks;
#endregion
}
