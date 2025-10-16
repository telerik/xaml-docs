---
title: How to Edit An Item
page_title: How to Edit An Item
description: Check our &quot;How to Edit An Item&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-feautres-treeviewitem-item-editing
tags: how,to,edit,an,item
published: True
position: 1
---

# How to Edit an Item

__RadTreeView__ supports editing the displayed text of the item. The purpose of this tutorial is to show you:

* How to enable/disable the item editing behavior.
* How to start, end and cancel editing declaratively and programmatically.
* What kind of events the treeview API offers you for managing the edit process.

#### Figure 1: RadTreeView with several items 
![{{ site.framework_name }} RadTreeView RadTreeView with several items](images/RadTreeView_TreeViewItemEditing_001.png)

__Example 1: RadTreeView populate with several items__  
```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView">
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football">
	            <telerik:RadTreeViewItem Header="Futsal"
	        x:Name="radTreeViewItemFutsal"/>
	            <telerik:RadTreeViewItem Header="Soccer"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Tennis"/>
	        <telerik:RadTreeViewItem Header="Cycling"/>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
```

## Enable Editing 

By default the treeview is not editable. In order to enable editing you need to set the __IsEditable__ property of RadTreeView to __True__. The default value is False.

__Example 2: Enable editing in XAML__  
```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView" IsEditable="True">
```

__Example 3: Enable editing in code__  
```C#	
	radTreeView.IsEditable = true;
```
```VB.NET	
	radTreeView.IsEditable = True
```

## Toggle Editing by Using Keyboard

Once the edit behavior is enabled, you can start the editing process by selecting an item and pressing the __F2__ key.

If you want to cancel the current edit operation and to preserve any text changes, you should press the __Esc__ key.

## Toggle Editing Programmatically

You can manually enter or exit the edit mode of RadTreeViewItem by setting its __IsInEditMode__.

__Example 4: Start editing via code__
```C#	
	radTreeViewItem.IsInEditMode = true;	
```
```VB.NET
	radTreeViewItem.IsInEditMode = True
```

#### Figure 2: RadTreeViewItem in edit mode 
![{{ site.framework_name }} RadTreeView RadTreeViewItem in edit mode](images/RadTreeView_TreeViewItemEditing_010.png)

__Example 5: Exit editing via code__
```C#
	radTreeViewItem.IsInEditMode = false;
```
```VB.NET
	radTreeViewItem.IsInEditMode = False
```

> Setting the __IsInEditMode__ property to False don't save the changes explicitly. To do so call the CommintEdit() method.

## Saving the Changes by Using the Keyboard

After entering the new text, in order to save your changes you should press the __Enter__ key.

## Saving the Changes Programmatically

If you want to finish the process of editing in code-behind and to save the changes manually, you need to call the __CommitEdit()__ method of the corresponding RadTreeViewItem.

__Example 6: Commit changes__
```C#	
	radTreeViewItem.CommitEidt();
```
```VB.NET
	radTreeViewItem.CommitEidt();
```

## Cancelling the Edit Operation Programmatically

In order to cancel the edit process in the code-behind you need to invoke the __CancelEdit()__ method of the editing treeview item. This method discards modifications to data since the last save.

__Example 5: Cancel editing__
```C#	
	radTreeViewItemFutsal.CancelEdit();
```
```VB.NET
	radTreeViewItemFutsal.CancelEdit()
```

## Events

The Telerik RadTreeView and RadTreeViewItem classes offer you several events for managing the edit process. These events are available both on the RadTreeView and on the RadTreeViewItem classes.

__Example 6: Subscribing to edit events__
```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView" IsEditable="True"
	        PreviewEditStarted="radTreeView_PreviewEditStarted"
	        EditStarted="radTreeView_EditStarted"
	        PreviewEdited="radTreeView_PreviewEdited"
	        EditCanceled="radTreeView_EditCanceled"
	        Edited="radTreeView_Edited">
```

The __PreviewEditStarted__ event occurs when the treeview item is about to be edited. The __EditStarted__ event is fired when the treeview item is already in edit mode. The type of the passed event arguments for both of the events is RadRoutedEventArgs.

__Example 7: Accessing the editing RadTreeViewItem in the PreviewEditStarted event handler__
```C#
	private void radTreeView_PreviewEditStarted( object sender, RadRoutedEventArgs e )
	{
	    RadTreeViewItem targetItem = e.Source as RadTreeViewItem;
	}
```
```VB.NET
	Private Sub radTreeView_PreviewEditStarted(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
	    Dim targetItem As RadTreeViewItem = TryCast(e.Source, RadTreeViewItem)
	End Sub
```

The __PreviewEdited__ event is fired just before the new __Header__ text of the item is applied. If the treeview is data bound you can update the data source with the new value. The __Edited__ event is fired once the new __Header__ text for the item is applied. You can get access to the new text of the __Header__ property, as well as to the old one, via the __RadTreeViewItemEditedEventArgs__ of the __PreviewEdited__ and __Edited__ events.

#### Figure 3: Getting the header text
![{{ site.framework_name }} RadTreeView Getting the header text](images/RadTreeView_TreeViewItemEditing_020.png)

>If the the __ItemEditTemplate__ property is set and it does not contain a __TextBox__, then the __NewText__ and __OldText__ properties will not be used.

In the event handler you can place some code that has to be executed when the item is edited. For example, change the background color of the edited item: 

__Example 8: Setting the background of the edited RadTreeViewItem__
```C#
	private void radTreeView_Edited( object sender, RadTreeViewItemEditedEventArgs e )
	{
	    ( e.Source as RadTreeViewItem ).Background = new SolidColorBrush( Colors.Red );
	}
```
```VB.NET
	Private Sub radTreeView_Edited(ByVal sender As Object, ByVal e As RadTreeViewItemEditedEventArgs)
	    TryCast(e.Source, RadTreeViewItem).Background = New SolidColorBrush(Colors.Red)
	End Sub
```

#### Figure 4: RadTreeViewItem with its background changed on edit
![{{ site.framework_name }} RadTreeView RadTreeViewItem with its background changed on edit](images/RadTreeView_TreeViewItemEditing_030.png)

## ItemEditTemplate and ItemEditTemplateSelector

Telerik RadTreeView also supports ItemEditTemplate and ItemEditTemplateSelector. To learn more on how to do that, visit the [Item Edit Template]({%slug radtreeview-populating-with-data-item-edit-template%}) and [Item Edit Template Selector]({%slug radtreeview-populating-with-data-item-edit-template-selector%}) topics.

## See Also
 * [Item Images]({%slug radtreeview-feautres-treeviewitem-item-images%})
 * [Enable and Disable Items]({%slug radtreeview-feautres-treeviewitem-enable-disable-items%})
 * [Working with Selections]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})
 * [BringIntoView Support]({%slug radtreeview-features-treeviewitem-bring-into-view-support%})
