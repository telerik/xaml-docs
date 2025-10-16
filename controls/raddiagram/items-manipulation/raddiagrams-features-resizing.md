---
title: Resizing
page_title: Resizing
description: Check our &quot;Resizing&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-resizing
tags: resizing
published: True
position: 1
---

# Resizing

__RadDiagram__ gives you the ability to resize shapes by dragging their __Resizing Thumbs__. You can also use the Shapes' __Width__ and __Height__ for this purpose.

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		

## Enable/Disable Resizing

By default the __RadDiagram__ is enabled for resizing manipulation. In order to disable this functionality, you can set __IsResizingEnabled__ to __False__


```XAML
	<telerik:RadDiagram IsResizingEnabled="False">
		<telerik:RadDiagramShape 
								 Geometry="{telerik:CommonShape ShapeType=RoundedRectangleShape}"
								 Position="100 80" />
	</telerik:RadDiagram>
```

![Rad Diagrams-Features-Resizing-Disabled](images/RadDiagrams-Features-Resizing-Disabled.png)

## Width and Height

You can resize shapes by using their __Width__ and __Height__ properties:


```XAML
	<telerik:RadDiagram>
		<telerik:RadDiagramShape Width="300" 
								 Height="30"
								 Geometry="{telerik:CommonShape ShapeType=RoundedRectangleShape}"
								 Position="100 80" />
	</telerik:RadDiagram>
```

![Rad Diagrams-Features-Resizing](images/RadDiagrams-Features-Resizing.png)

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Items Editing]({%slug raddiagrams-features-edit%})
 * [Rotation]({%slug raddiagrams-features-rotation%})
 * [ZOrder]({%slug raddiagrams-features-zorder%})
 * [Selection]({%slug raddiagrams-features-selection%})