---
title: Working with MouseLeftButtonDown Event
page_title: Working with MouseLeftButtonDown Event
description: Check our &quot;Working with MouseLeftButtonDown Event&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-events-working-mouse-left-button-down-event
tags: working,with,mouseleftbuttondown,event
published: True
position: 2
---

# Working with MouseLeftButtonDown Event

The purpose of this tutorial is to show you how to handle the __MouseLeftButtonDown__ event of the __RadTreeView/Item__. 

## Attaching to the MouseLeftButtonDown Event

Probably the first solution crossing your mind is to attach to the __MouseLeftButtonDown__ directly, using the exposed by the __RadTreeView__ object event.

```XAML
	<telerik:RadTreeView x:Name="radTreeView" MouseLeftButtonDown="radTreeView_MouseLeftButtonDown"/>
```

And this is the most straight-forward way to do it. However, if you use the above approach, you __won't be able__ to track the __MouseLeftButtonDown__ event. The reason - by design, the __RadTreeView__ items mark the __MouseLeftButtonDown__ event as __handled__.

Telerik RadControls API allows you to also listen for events that have been already handled. You should attach to the __MouseLeftButtonDown__ event using the __AddHandler__ extension methods. Check out the code snippet below and be sure that you are using/importing the __Telerik.Windows__ namespace.

```C#
	using Telerik.Windows;
	this.radTreeView.AddHandler(RadTreeViewItem.MouseLeftButtonDownEvent, new MouseButtonEventHandler(this.radTreeView_MouseLeftButtonDown), true);
	private void radTreeView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
	    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
	}
```
```VB.NET
	Imports Telerik.Windows
	Me.radTreeView.[AddHandler](RadTreeViewItem.MouseLeftButtonDownEvent, New MouseButtonEventHandler(Me.radTreeView_MouseLeftButtonDown), True)
	Private Sub radTreeView_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
	    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
	End Sub
```

## See Also
 * [Events - Overview]({%slug radtreeview-events-overview%})
 * [Working with ItemPrepared Event]({%slug radtreeview-events-working-with-item-prepared-event%})