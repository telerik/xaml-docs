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

#region dragdropmanager-migration_0
private void OnDragQuery( object sender, DragDropQueryEventArgs e )
{
    ListBoxItem listBoxItem = e.Options.Source as ListBoxItem;
    ListBox box = ItemsControl.ItemsControlFromItemContainer( listBoxItem ) as ListBox;
    if ( e.Options.Status == DragStatus.DragQuery && box != null )
    {
        e.Options.Payload = box.SelectedItem;
        ContentControl cue = new ContentControl();
        cue.ContentTemplate = this.Resources["ApplicationDragTemplate"] as DataTemplate;
        cue.Content = box.SelectedItem;
        e.Options.DragCue = cue;
        e.Options.ArrowCue = RadDragAndDropManager.GenerateArrowCue();
    }
    e.QueryResult = true;
}
#endregion

#region dragdropmanager-migration_1
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    args.AllowedEffects = DragDropEffects.All; // Coresponds to the QueryResult
    
    // Coresponds to the payload setting
    var payload = DragDropPayloadManager.GeneratePayload(null);
    payload.SetData("DragData", ((FrameworkElement)args.OriginalSource).DataContext);
    args.Data = payload;

    // Coresponds to the cue setting (e.Options.DragCue)
    args.DragVisual = new ContentControl { Content = args.Data, ContentTemplate = LayoutRoot.Resources["ApplicationTemplate"] as DataTemplate };
}

#endregion

#region dragdropmanager-migration_2

private void OnDragInfo( object sender, DragDropEventArgs e )
{
    ListBoxItem listBoxItem = e.Options.Source as ListBoxItem;
    ListBox box = ItemsControl.ItemsControlFromItemContainer( listBoxItem ) as ListBox;
    IList<ApplicationInfo> itemsSource = box.ItemsSource as IList<ApplicationInfo>;
    ApplicationInfo payload = e.Options.Payload as ApplicationInfo;
    if ( e.Options.Status == DragStatus.DragComplete )
    {
        if ( payload != null && itemsSource.Contains( payload ) )
        {
            itemsSource.Remove( payload );
        }
    }
}

#endregion

#region dragdropmanager-migration_3
public void OnDragCompleted(object sender, Telerik.Windows.DragDrop.DragDropCompletedEventArgs args)
{
	if (args.Effects != DragDropEffects.Scroll && args.Effects != DragDropEffects.Move)
	{
		var sourceControl = sender as ListBox;
		var sourceItems = sourceControl.ItemsSource as IList;
		var draggedData = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
 
		if (sourceItems != null)
		{
			sourceItems.Remove(draggedData);
		}
	}
}

#endregion

#region dragdropmanager-migration_4
private void OnDropInfo( object sender, DragDropEventArgs e )
{
    ItemsControl box = e.Options.Destination as ItemsControl;
    IList<ApplicationInfo> itemsSource = box.ItemsSource as IList<ApplicationInfo>;
    ApplicationInfo payload = e.Options.Payload as ApplicationInfo;
    if ( e.Options.Status == DragStatus.DropComplete )
        if ( !itemsSource.Contains( payload ) )
            itemsSource.Add( payload );
}
#endregion

#region dragdropmanager-migration_5
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
{
	var destinationControl = sender as ListBox;
	var destinationItems = destinationControl.ItemsSource as IList;
	var draggedData = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
 
	if (draggedData != null && args.Effects != DragDropEffects.None)
	{
		destinationItems.Add(draggedData);
	}
}
#endregion

#region dragdropmanager-migration_6
private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
	if (!(e.OriginalSource is FrameworkElement))
	{
		e.Effects = DragDropEffects.None;
				e.Handled = true;
	}
}

#endregion

#region dragdropmanager-migration_7

private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
{
    args.SetCursor(Cursors.Arrow);
    args.Handled = true;
}

#endregion

}
