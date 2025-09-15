---
title: Enable and Disable Items
page_title: Enable and Disable Items
description: Check our &quot;Enable and Disable Items&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-feautres-treeviewitem-enable-disable-items
tags: enable,and,disable,items
published: True
position: 3
---

# Enable and Disable Items

By using the API of the __RadTreeView__ control you can easily disable or enable a node. You can set the boolean property __IsEnabled__ to each one of the following objects:

* __RadTreeView__
* __RadTreeViewItem__

This tutorial will walk you through the common tasks of __enabling__ and __disabling__ treeview item(s) declaratively and programmatically.

## Enable and Disable Items Declaratively 

This is a snapshot of a regular __RadTreeView__ with a couple of items.

![{{ site.framework_name }} RadTreeView Sample Items](images/RadTreeView_TreeViewItemEnableDisableItems_001.png)

And here is the XAML declaration:

#### __XAML__

```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView">
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football">
	            <telerik:RadTreeViewItem Header="Futsal"/>
	            <telerik:RadTreeViewItem Header="Soccer"
	                x:Name="radTreeViewItemSoccer"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Tennis"/>
	        <telerik:RadTreeViewItem Header="Cycling"/>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	```

By default all items in the treeview are enabled (their __IsEnabled__ property is set to __True__). That means you can select, expand, collapse, drag and drop these items. If you want to disable a specific item, just add the following attribute to the treeview item declaration: 

#### __XAML__

```XAML
	<telerik:RadTreeViewItem IsEnabled="False"/>
	```

If you want to disable the whole treeview then add the same attribute to the treeview declaration. On the next snapshot the whole treeview is disabled. 

![{{ site.framework_name }} RadTreeView Disabled Items](images/RadTreeView_TreeViewItemEnableDisableItems_010.png)

Here is the XAML declaration. Note that if you set the __IsEnabled__ property to __False__ for the __RadTreeView__ object then all treeview items will be disabled. 

#### __XAML__

```XAML
	<telerik:RadTreeView Margin="8" x:Name="radTreeView" IsEnabled="False">
	    <telerik:RadTreeViewItem Header="Sport Categories" IsExpanded="True">
	        <telerik:RadTreeViewItem Header="Football" IsExpanded="True">
	            <telerik:RadTreeViewItem Header="Futsal"/>
	            <telerik:RadTreeViewItem Header="Soccer"
	                x:Name="radTreeViewItemSoccer"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Tennis"/>
	        <telerik:RadTreeViewItem Header="Cycling"/>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	```

## Enable and Disable Items Programmatically

In order to disable a treeview item, you have to set the __IsEnabled__ property of an instance of the __RadTreeViewItem__ class. 

#### __C#__

```C#
	private void DisableTreeViewItem()
	{
	    radTreeViewItemSoccer.IsEnabled = false;
	}
	```

#### __VB.NET__

```VB.NET
	Private Sub DisableTreeViewItem()
	    radTreeViewItemSoccer.IsEnabled = False
	End Sub
	```
	
If you want to disable the whole treeview then you have to set the __IsEnabled__ property of an instance of the __RadTreeView__ class. 

#### __C#__

```C#
	private void DisableTreeView()
	{
	    radTreeView.IsEnabled = false;
	}
	```

#### __VB.NET__

```VB.NET
	Private Sub DisableTreeView()
	    radTreeView.IsEnabled = False
	End Sub
	```

>tip Consider disabling treeview items in XAML instead of code-behind whenever it's possible. This includes situations when you know what items you need to disable at design time.

## Events 

Both __RadTreeView__ and __RadTreeViewItem__ offer you __IsEnabledChanged__ event which is raised, when the tree or an item is enabled/disabled.

#### __XAML__

```XAML
	<telerik:RadTreeViewItem Header="Soccer"
	    x:Name="radTreeViewItemSoccer" IsEnabledChanged="radTreeViewItemSoccer_IsEnabledChanged"/>
	```

You can also attach to the __IsEnabledChanged__ event in the code-behind.

#### __C#__

```C#
	this.radTreeViewItemSoccer.IsEnabledChanged += new DependencyPropertyChangedEventHandler( radTreeViewItemSoccer_IsEnabledChanged );
	```

#### __VB.NET__

```VB.NET
	AddHandler Me.radTreeViewItemSoccer.IsEnabledChanged, AddressOf radTreeViewItemSoccer_IsEnabledChanged
	```

## See Also
 * [How to Edit An Item]({%slug radtreeview-feautres-treeviewitem-item-editing%})
 * [Item Images]({%slug radtreeview-feautres-treeviewitem-item-images%})
 * [Working with selection]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})
 * [BringIntoView Support]({%slug radtreeview-features-treeviewitem-bring-into-view-support%})
