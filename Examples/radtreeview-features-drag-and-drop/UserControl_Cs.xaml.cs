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

#region radtreeview-features-drag-and-drop_2
  private void EnableDragAndDrop()
        {
            radTreeView.IsDragDropEnabled = true;
        }
#endregion

#region radtreeview-features-drag-and-drop_5
private void EnableDragOfMultipleNodes()
{
    radTreeView.SelectionMode = Telerik.Windows.Controls.SelectionMode.Multiple;
}
#endregion

#region radtreeview-features-drag-and-drop_8
private void DisableDropOnSpecificItem()
{
    radTreeViewItemTennis.IsDropAllowed = false;
}
#endregion

#region radtreeview-features-drag-and-drop_11
private void DisableDragPreview()
{
    radTreeView.IsDragPreviewEnabled = false;
}
#endregion

#region radtreeview-features-drag-and-drop_14
private void DisableDragTooltip()
{
    radTreeView.IsDragTooltipEnabled = false;
}
#endregion

#region radtreeview-features-drag-and-drop_17
private void DisableDropPreviewLine()
{
    radTreeView.IsDropPreviewLineEnabled = false;
}
#endregion

#region radtreeview-features-drag-and-drop_20
private void radTreeView_PreviewDragEnded( object sender, RadTreeViewDragEndedEventArgs e )
{
    e.Handled = true;
}
#endregion

#region radtreeview-features-drag-and-drop_22
private void radTreeView_DragStarted( object sender, RadTreeViewDragEventArgs e )
{
    Collection<Object> draggedItems = e.DraggedItems;
}
#endregion

#region radtreeview-features-drag-and-drop_24
private void radTreeView_DragEnded( object sender, RadTreeViewDragEndedEventArgs e )
{
    // Get the dragged items.
    Collection<Object> draggedItems = e.DraggedItems;
    // Get the drop position.
    DropPosition dropPosition = e.DropPosition;
    switch ( dropPosition )
    {
        case DropPosition.After:
            MessageBox.Show( "After" );
            break;
        case DropPosition.Before:
            MessageBox.Show( "Before" );
            break;
        case DropPosition.Inside:
            MessageBox.Show( "Inside" );
            break;
    }
    // Get is canceled
    bool isCanceled = e.IsCanceled;
    // Target drop item
    RadTreeViewItem targetDropItem = e.TargetDropItem;
    if ( targetDropItem.Header.ToString() == "Tennis" )
    {
        // Do something
    }
}
#endregion

#region radtreeview-features-drag-and-drop_1
private void EnableDragAndDrop()
{
    radTreeView.IsDragDropEnabled = true;
    TreeViewSettings.SetDragDropExecutionMode(radTreeView, TreeViewDragDropExecutionMode.New);
    DragDropManager.AddDragInitializeHandler(radTreeView,OnDragInitialized,true);
}

private void OnDragInitialized(object sender, DragInitializeEventArgs e)
{
       TreeViewDragDropOptions options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;    
}
#endregion
#region radtreeview-features-drag-and-drop_3
private void EnableDragAndDrop()
{
    radTreeView.IsDragDropEnabled = true;
    TreeViewSettings.SetDragDropExecutionMode(radTreeView, TreeViewDragDropExecutionMode.New);
     DragDropManager.AddDragOverHandler(radTreeView2, OnTreeItemDragOver, true);
}

private void OnTreeItemDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
    options.DropAction = DropAction.Copy;
}
#endregion
}
