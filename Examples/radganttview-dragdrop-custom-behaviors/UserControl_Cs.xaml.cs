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

#region radganttview-dragdrop-custom-behaviors-1
public class CustomDragDropBehavior : Telerik.Windows.Controls.GanttView.GanttDragDropBehavior
{
    protected override bool CanStartDrag(SchedulingDragDropState state)
    {
        var task = state.DraggedItem as GanttTask;
        if (task.IsMilestone)
            return false;

        return base.CanStartDrag(state);
    }
}
#endregion

#region radganttview-dragdrop-custom-behaviors-2
public class SnappingSchedulingResizeBehavior : SchedulingResizeBehavior
{
    protected override void Resize(SchedulingResizeState state)
    {
        if (state.IsResizeFromEnd)
        {
            state.DestinationSlot.End = RoundUpDateTime(state.DestinationSlot.End);
        }
        else
        {
            state.DestinationSlot.Start = RoundUpDateTime(state.DestinationSlot.Start);
        }

        base.Resize(state);
    }

    private DateTime RoundUpDateTime(DateTime dateTime)
    {
        DateTime result;
        if (dateTime.Hour >= 12)
        {
            result = RoundUpToNextDay(dateTime);
        }
        else
        {
            result = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        return result;
    }

    private static DateTime RoundUpToNextDay(DateTime dateTime)
    {
        DateTime result;
        if (dateTime.Day == DateTime.DaysInMonth(dateTime.Year, dateTime.Month))
        {
            if (dateTime.Month < 12)
            {
                result = new DateTime(dateTime.Year, dateTime.Month + 1, 1);
            }
            else
            {
                result = new DateTime(dateTime.Year + 1, 1, 1);
            }
        }
        else
        {
            result = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day + 1);
        }
        return result;
    }
}
#endregion
}
