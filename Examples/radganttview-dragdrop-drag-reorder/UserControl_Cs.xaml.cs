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

#region radganttview-dragdrop-drag-reorder_0
public class CustomGanttTask : GanttTask
{
    private bool isDragReorderAllowed;

    public bool IsDragReorderAllowed
    {
        get
        {
            return this.isDragReorderAllowed;
        }

        set
        {
            if (this.isDragReorderAllowed != value)
            {
                this.isDragReorderAllowed = value;
                this.OnPropertyChanged(() => this.IsDragReorderAllowed);
            }
        }
    }
}
#endregion

#region radganttview-dragdrop-drag-reorder_1
public class CustomGanttDragDropBehavior : GanttDragDropBehavior
{
    protected override bool CanStartDrag(SchedulingDragDropState state)
    {
        if (state.IsReorderOperation)
        {
            return ((CustomGanttTask)state.DraggedItem).IsDragReorderAllowed;
        }

        return base.CanStartDrag(state);
    }
}
#endregion

#region radganttview-dragdrop-drag-reorder_2

#endregion
}
