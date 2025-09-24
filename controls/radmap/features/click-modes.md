---
title: Click Modes
page_title: Click Modes
description: Check our &quot;Click Modes&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-click-modes
tags: click,modes
published: True
position: 3
---

# Click Modes

The __RadMap__ supports both single and double mouse clicks. It provides you with a predefined behaviors for them out of the box. The possible values are to be found in the __MouseBehavior__ enumeration:

* __Center__ - positions the clicked or double clicked point into the center of the map.

* __None__ - the click or double click does nothing.

* __ZoomPointToCenter__ - zooms in to the clicked or double clicked point and positions it into the center of the map.

* __ZoomToPoint__ - zooms in to the clicked or double clicked point.

In order to configure the behavior for the single click you have to set the __MouseClickMode__ property. For the double click mode set the __MouseDoubleClickMode__ property.

Here is an example:


```XAML
	<telerik:RadMap x:Name="radMap"
	                MouseClickMode="Center"
	                MouseDoubleClickMode="ZoomToPoint" /
```

If you want to implement a custom behavior for one or both of them, just set the respective mode to __None__ and handle the respective event:

>tip Also you can set these properties to __None__ in order to prevent the users from zooming. Additionally setting the __MouseDragMode__ property to __None__ will disable them from panning.


```XAML
	<telerik:RadMap x:Name="radMap"
	                MouseClickMode="None"
	                MouseDoubleClickMode="None"
	                MapMouseClick="radMap_MapMouseClick"
	                MapMouseDoubleClick="radMap_MapMouseDoubleClick" />
```


```C#
	private void radMap_MapMouseClick( object sender, MapMouseRoutedEventArgs e )
	{
	    //implement logic regarding single click here
	}
	private void radMap_MapMouseDoubleClick( object sender, MapMouseRoutedEventArgs e )
	{
	    //implement logic regarding double click here
	}
```
```VB.NET
	Private Sub radMap_MapMouseClick(sender As Object, e As MapMouseRoutedEventArgs)
	 'implement logic regarding single click here'
	End Sub
	Private Sub radMap_MapMouseDoubleClick(sender As Object, e As MapMouseRoutedEventArgs)
	 'implement logic regarding double click here'
	End Sub
```

## See Also
 * [Navigation]({%slug radmap-features-navigation%})
 * [Zoom Modes]({%slug radmap-features-zoom-modes%})
 * [Distance and Scale]({%slug radmap-features-dsitance-and-scale%})
 * [Mouse Location]({%slug radmap-features-mouse-location%})
 * [Default Layout]({%slug radmap-features-default-layout%})