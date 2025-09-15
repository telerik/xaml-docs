---
title: Select  the clicked Item of a RadTreeView
page_title: Select  the clicked Item of a RadTreeView
description: Check our &quot;Select  the clicked Item of a RadTreeView&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-select-the-clicked-item-of-radtreeview
tags: select,,the,clicked,item,of,a,radtreeview
published: True
position: 1
---

# Select  the clicked Item of a RadTreeView

This tutorial will show you how to select the item that was clicked, while opening the __RadContextMenu__. In order to achieve this, you have to do the following things:

* Handle the __Opened__ event of the __RadContextMenu__

* Get an instance of the clicked __RadTreeViewItem__

* Set the __SelectedItem__ of the __RadTreeView__

Before starting, here is a sample __RadTreeView__ with a sample __RadContextMenu__ attached.

#### __XAML__

```XAML
	<telerik:RadTreeView x:Name="radTreeView">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu">
	            <telerik:RadMenuItem Header="Menu Option 1" />
	            <telerik:RadMenuItem Header="Menu Option 2" />
	            <telerik:RadMenuItem Header="Menu Option 3" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	    <telerik:RadTreeViewItem Header="Category1">
	        <telerik:RadTreeViewItem Header="Product1" />
	        <telerik:RadTreeViewItem Header="Product2" />
	        <telerik:RadTreeViewItem Header="Product3" />
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Category2" />
	    <telerik:RadTreeViewItem Header="Category3" />
	    <telerik:RadTreeViewItem Header="Category4">
	        <telerik:RadTreeViewItem Header="Product A" />
	        <telerik:RadTreeViewItem Header="Product B" />
	        <telerik:RadTreeViewItem Header="Product C" />
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Category5" />
	</telerik:RadTreeView>
```

To handle the __Opened__ event attach an event handler to it.

#### __XAML__

```XAML
	<telerik:RadContextMenu x:Name="radContextMenu1" 
	                        Opened="RadContextMenu_Opened">
	    <telerik:RadMenuItem Header="Menu Option 1" />
	    <telerik:RadMenuItem Header="Menu Option 2" />
	    <telerik:RadMenuItem Header="Menu Option 3" />
	</telerik:RadContextMenu>
```

#### __C#__

```C#
	private void RadContextMenu_Opened( object sender, RoutedEventArgs e )
	{
	}
```

#### __VB.NET__

```VB.NET
	Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
	End Sub
```

In it get the instance of the clicked __RadTreeViewItem__ by calling the __GetClickedElement\<T\>()__ method of the __RadContextMenu__.

#### __C#__

```C#
	private void RadContextMenu_Opened(object sender, RoutedEventArgs e)
	{
	    RadTreeViewItem item = this.radContextMenu.GetClickedElement<RadTreeViewItem>();
	}
```

#### __VB.NET__

```VB.NET
	Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
	    Dim item As RadTreeViewItem = Me.radContextMenu.GetClickedElement(Of RadTreeViewItem)()
	End Sub
```

The last thing to do is to set the __SelectedItem__ property of the __RadTreeView__ to the __instance__ of the __RadTreeView__ item that has been clicked.

>If you are having a dynamic data scenario, where the __RadTreeView__ is bound to a collection, you have to set the __SelectedItem__ property to the __DataContext__ of the clicked __RadTreeViewItem__.

#### __C#__

```C#
	private void RadContextMenu_Opened(object sender, RoutedEventArgs e)
	{
	    RadTreeViewItem item = this.radContextMenu.GetClickedElement<RadTreeViewItem>();
	    if (item != null)
	    {
	        this.radTreeView.SelectedItem = item;
	    }
	}
```

#### __VB.NET__

```VB.NET
	Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
	    Dim item As RadTreeViewItem = Me.radContextMenu.GetClickedElement(Of RadTreeViewItem)()
	    If item Is Nothing Then
	        Me.radTreeView.SelectedItem = item
	    End If
	End Sub
```

## See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
