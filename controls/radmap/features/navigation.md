---
title: Navigation
page_title: Navigation
description: Check our &quot;Navigation&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-navigation
tags: navigation
published: True
position: 2
---

# Navigation

When working with the __RadMap__ control, the user would likely try to pan or zoom the map using mouse and/or keyboard or using the map navigation control. The developer is also able to implement outside navigation using the __RadMap__'s API  or to just predefine a start location. To do this you can use the following properties:

* __Center__ - represents the center point of the map view and is of type Location.

* __ZoomLevel__ - represents different levels of detail available on the map. The maximum level of available detail is determined by the location you are zooming into, for example some areas can be zoomed in further than other areas. 

>tip By default each change of the current map location is animated. The animation is controlled via the __UseSpringAnimations__ property with default value of __True__. If you want to disable the animation simply set it to __False__.

If you want to hide the navigation control you have to set the __NaviagtionVisibility__ to __Collapsed__.

#### __XAML__
```XAML
	<telerik:RadMap x:Name="radMap"
	                NavigationVisibility="Collapsed">
	</telerik:RadMap>
```

If you want to disable the user from zooming and panning, you have to set the following properties:

#### __XAML__
```XAML
	<telerik:RadMap x:Name="radMap"
	                NavigationVisibility="Collapsed"
	                IsMouseWheelZoomEnabled="False"
	                IsKeyboardNavigationEnabled="False"
	                MouseClickMode="None"
	                MouseDoubleClickMode="None"
	                MouseDragMode="None"
	                ZoomBarVisibility="Collapsed">
	</telerik:RadMap>
```

Additionally as the UI navigation control is represented by the __MapNavigation__ control, you are able to use it outside the __RadMap__ and place it somewhere around it. In this case you have to either hide the original one by using the __NavigationVisibility__ property of the __RadMap__ or the __UseDefaultLayout__ one.

>tip Setting the __UseDefaultLayout__ property to __False__ will hide all of the UI controls inside the __RadMap__. To learn more click [here]({%slug radmap-features-default-layout%}).

In order to use the __MapNavigation__ outside of the __RadMap__ you have to set its __MapControl__ property to the respective __RadMap__ instance. Additionally you can handle its __CenterButtonClick__ event and implement your custom logic in the event handler. Here is an example:

#### __XAML__
```XAML
	<StackPanel>
	    <telerik:RadMap x:Name="radMap"
	                    Width="600"
	                    Height="480"
	                    NavigationVisibility="Collapsed">
	    </telerik:RadMap>
	    <telerik:MapNavigation MapControl="{Binding ElementName=radMap}"
	                            Margin="10" />
	</StackPanel>
```

Here is a snapshot of the result.

![{{ site.framework_name }} RadMap Map Navigation Outside](images/RadMap_Features_Navigation_01.png)

## See Also
 * [Click Modes]({%slug radmap-features-click-modes%})
 * [Zoom Modes]({%slug radmap-features-zoom-modes%})
 * [Distance and Scale]({%slug radmap-features-dsitance-and-scale%})
 * [Mouse Location]({%slug radmap-features-mouse-location%})
 * [Default Layout]({%slug radmap-features-default-layout%})