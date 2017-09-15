---
title: Mouse Support
page_title: Mouse Support
description: Mouse Support
slug: gridview-overview-mouse-support
tags: mouse,support
published: True
position: 11
---

# Mouse Support

__RadGridView__ exposes several useful events, which can help you control the mouse interaction and get notified when mouse events occur. Moreover, using the mouse you can perform some most common tasks, such as:

* Change the __selection.__

* __Sort__ by clicking on the column headers.

* __Group__ by one or more columns.

* __Expand\Collapse__ groups or hierarchical grids.

* __Resize__ and __reorder__ columns.

* __Freeze\Unfreeze__ columns.

* Define\Remove simple __filters__.

* Start\End cell __editing.__

## Events

Here is a list of the common mouse events exposed by __RadGridView__, __GridViewRow__ and __GridViewCell__ objects:

* __MouseWheel__ - occurs when the user rotates the mouse wheel. The type of the passed event arguments is __MouseWheelEventArgs__.

* __MouseMove__ - occurs when the coordinate position of the mouse changes. The type of the passed event arguments is __MouseEventArgs__.

* __MouseLeftButtonDown__ - occurs when the left mouse button is pressed. The type of the passed event arguments is __MouseButtonEventArgs__.

* __MouseLeftButtonUp__ - occurs when the left mouse button is released. The type of the passed event arguments is __MouseButtonEventArgs__.

* __MouseLeave__ - occurs when the mouse leaves the control. The type of the passed event arguments is __MouseEventArgs__.

* __MouseEnter__ - occurs when the mouse enters the control. The type of the passed event arguments is __MouseEventArgs__.

* __LostMouseCapture__ - occurs when the object loses mouse capture. The type of the passed event arguments is __MouseEventArgs__.

* __MouseDoubleClick__ - occurs when the grid view cell is double clicked by the user. The type of the passed event arguments is __MouseButtonEventArgs__. Note that this event is available only in the __GridViewCell__ object.

In the example below you can see how to attach to __MouseWheel__ event from XAML.

#### __XAML__

{{region xaml-gridview-overview-mouse-support_0}}
	<telerik:RadGridView x:Name="radGridView" MouseWheel="radGridView_MouseWheel" />
{{endregion}}


>It is always a good practice to attach your event handlers in the XAML, whenever your application logic allows this.

The implementation of the event handler __radGridView_MouseWheel__ is located in the code-behind file (C# or VB.NET) and looks like this:

#### __C#__

{{region cs-gridview-overview-mouse-support_1}}
	private void radGridView_MouseWheel(object sender, MouseWheelEventArgs e)
	{
	    MessageBox.Show("The mouse wheel has changed: " + e.Delta);
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-overview-mouse-support_2}}
	Private Sub radGridView_MouseWheel(ByVal sender As Object, ByVal e As MouseWheelEventArgs)
	    MessageBox.Show("The mouse wheel has changed: " & e.Delta)
	End Sub
{{endregion}}

The RadGridView actually uses and handles many of the mouse events. If you would like to handle them yourself, you should use the AddHandler() method of the GridView and set True for the __HandledEventsToo__ input parameter.
        

#### __C#__

{{region cs-gridview-overview-mouse-support_3}}
	this.radGridView.AddHandler(RadGridView.MouseWheelEvent, new MouseWheelEventHandler(radGridView_MouseWheel), true);
{{endregion}}


#### __VB.NET__

{{region vb-gridview-overview-mouse-support_4}}
	Me.radGridView.AddHandler(RadGridView.MouseWheelEvent, New MouseWheelEventHandler(AddressOf radGridView_MouseWheel), True)
{{endregion}}


## See Also

 * [Keyboard Support]({%slug gridview-overview-keyboard-support%})

 * [Data Binding]({%slug gridview-overview-data-binding%})

 * [Managing Data]({%slug gridview-overview-managing-data%})
