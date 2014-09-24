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

#region radtreeview-how-to-set-drag-cue-feedback-deny-drop-0
DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, true);
#endregion

#region radtreeview-how-to-set-drag-cue-feedback-deny-drop-1
private void OnDragOverTree(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options != null && options.DropPosition == Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem != null && options.DropTargetItem.Item is Division)
    {
        options.DropAction = DropAction.None;
    }
}
#endregion

#region radtreeview-how-to-set-drag-cue-feedback-deny-drop-2
private void OnDragOverTree(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    if (options != null && options.DropPosition == Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem != null && options.DropTargetItem.Item is Division)
    {
        options.DropAction = DropAction.None;
        var dragVisual = options.DragVisual as TreeViewDragVisual;
        if (dragVisual != null)
        {
            dragVisual.IsDropPossible = false;
            dragVisual.DropActionText = "Cannot drop into ";
        } 

    }
}
#endregion
}
