---
title: DragDropManager Migration
page_title: DragDropManager Migration
description: Check our &quot;DragDropManager Migration&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-migration
tags: dragdropmanager,migration
published: True
position: 5
---

# DragDropManager Migration

The article explains the events of the __DragDropManager__.

## Events and API migration

The event that was fired when the drag Starts was __DragQuery__ for the RadDragAndDropManager. Now it is __OnDragInitialize__.

Bellow is the code for the DragQuery event is its corresponding code for the OnDragInitialize event:


```C#
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
```


```C#
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
```

The event corresponding to the __DragInfo__ event in RadDragAndDropManager is now __DragDropComplete__. The __DragDropComplete__ event is the equivalent of the __DragQuery with status DropComplete__.


```C#	
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
```


```C#
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
```

The __Drop__ event in DragDropManager corresponds to the __DropInfo event with status DropCompleted__.



```C#
	private void OnDropInfo( object sender, DragDropEventArgs e )
	{
	    ItemsControl box = e.Options.Destination as ItemsControl;
	    IList<ApplicationInfo> itemsSource = box.ItemsSource as IList<ApplicationInfo>;
	    ApplicationInfo payload = e.Options.Payload as ApplicationInfo;
	    if ( e.Options.Status == DragStatus.DropComplete )
	        if ( !itemsSource.Contains( payload ) )
	            itemsSource.Add( payload );
	}
```


```C#
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
```

The __DragInfo__ event corresponds to the __GiveFeedback__ event. Basically the GiveFeedback event can be used on the DragSource control to update the Cursor, and the DragEffects for the DragOperation.        

The __DropInfo__ event corresponds to the __DragOver__ event of DradDropManager. The __DragOver__ event can be used as a replacement for the __DropQuery/Info__ events for various purposes, one of which is to __update the AllowedEffects__ for the drag drop operation.  Works both on Source and Destination.


```C#
	private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
		if (!(e.OriginalSource is FrameworkElement))
		{
			e.Effects = DragDropEffects.None;
					e.Handled = true;
		}
	}	
```

The __CancelDrag__ event corresponds to the __QueryContinueDrag__ event. The CancelDrag() method logic can be replaced by subscribing to the QueryContinueDrag event and manipulating the Action property in the QueryContinueEventArgs.        

The control cursor can be set in the GiveFeedbackEventArgs.


```C#	
	private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
	{
	    args.SetCursor(Cursors.Arrow);
	    args.Handled = true;
	}	
```

## Events without analogue

* PreviewGiveFeedback

* PreviewQueryContinueDrag

* PreviewDragEnter

* PreviewDragLeave

* PreviewDragOver

* PreviewDrop

## Missing Functionality

* There is no AutoScrollBehavior out of the box

* There is no DragArrow Cue