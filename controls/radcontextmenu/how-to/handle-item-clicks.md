---
title: Handle Item Clicks
page_title: Handle Item Clicks
description: Check our &quot;Handle Item Clicks&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-handle-item-clicks
tags: handle,item,clicks
published: True
position: 4
---

# Handle Item Clicks



There are two ways to handle a click on an item:

* [Handle the Click event of the RadMenuItem](#handle-the-click-event-of-the-radmenuitem)

* [Handle the ItemClick event of the RadContextMenu](#handle-the-itemclick-event-of-the-radcontextmenu)

## Handle the Click event of the RadMenuItem

Handling the __Click__ event of each item is the straight-forward way. But it has some __disadvantages__:

* You have to attach an event handler to each item. This makes the code harder to maintain.

* It is not suitable when having dynamic items.

>If the __RadMenuItem__ is in the role of a header (has child items), the __ItemClick__ event won't be raised unless the __NotifyOnHeaderClick__ property is set to __True__.

Here is an example of an event handler attached to the __Click__ event and how to get the instance of the clicked item.



```XAML
	<telerik:RadContextMenu>
	    <telerik:RadMenuItem Header="Item 1"
	                         Click="RadMenuItem_Click" />
	    <telerik:RadMenuItem Header="Item 2"
	                         Click="RadMenuItem_Click" />
	    <telerik:RadMenuItem Header="Item 3"
	                         Click="RadMenuItem_Click" />
	</telerik:RadContextMenu>
```



```C#
	private void RadMenuItem_Click( object sender, RadRoutedEventArgs e )
	{
	    RadMenuItem item = sender as RadMenuItem;
	    //implement the logic regarding the instance here.
	}
```



```VB.NET
	Private Sub RadMenuItem_Click(sender As Object, e As RadRoutedEventArgs)
	    Dim item As RadMenuItem = TryCast(sender, RadMenuItem)
	    'implement the logic regarding the instance here.
	End Sub
```

## Handle the ItemClick event of the RadContextMenu

Handling the __ItemClick__ event of the __RadContextMenu__ gives you more flexibility, as it fires each time a child menu item is clicked. This approach is the most suitable when having a dynamic data scenario.

>If the __RadMenuItem__ is in the role of a header (has child items), the __ItemClick__ event won't be raised unless the __NotifyOnHeaderClick__ property is set to __True__.

Here is an example of an event handler attached to the __ItemClick__ event and how to get the instance of the clicked item.



```XAML
	<telerik:RadContextMenu ItemClick="radContextMenu_ItemClick">
	    <telerik:RadMenuItem Header="Item 1" />
	    <telerik:RadMenuItem Header="Item 2" />
	    <telerik:RadMenuItem Header="Item 3" />
	</telerik:RadContextMenu>
```



```C#
	private void radContextMenu_ItemClick(object sender, RadRoutedEventArgs e)
	{
	    RadMenuItem item = e.OriginalSource as RadMenuItem;
	    //implement the logic regarding the instance here.
	}
```



```VB.NET
	Private Sub radContextMenu_ItemClick(sender As Object, e As RadRoutedEventArgs)
	    Dim item As RadMenuItem = TryCast(e.OriginalSource, RadMenuItem)
	    'implement the logic regarding the instance here.
	End Sub
```

## See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Events - Overview]({%slug radcontextmenu-events-overview%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})
