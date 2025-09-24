---
title: Rotation
page_title: Rotation
description: Check our &quot;Rotation&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-rotation
tags: rotation
published: True
position: 0
---

# Rotation

__RadDiagram__ gives you the ability to rotate shapes by dragging their __Rotation Thumb__ or by changing their __RotationAngle__ property.	  

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. The {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article describes how to set the theme as an application theme.		

## Enable/Disable Rotation

By default the __RadDiagram__ is enabled for rotation manipulation. In order to disable this functionality, you can set __IsRotationEnabled__ to __False__


```XAML
	<telerik:RadDiagram IsRotationEnabled="False">
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CloudShape}" Position="100 80" />
	</telerik:RadDiagram>		
```

![Rad Diagrams-Featires-Rotation-Disabled](images/RadDiagrams-Features-Rotation-Disabled.png)

## Rotation Angle

You can rotate shapes by using their __RotationAngle__ property:		


```XAML
	<telerik:RadDiagram>
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CloudShape}"
								RotationAngle="45"
								Position="200 200"
								x:Name="shape"/>
	</telerik:RadDiagram>		
```

![Rad Diagrams-Features-Rotation](images/RadDiagrams-Features-Rotation.png)

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Resizing]({%slug raddiagrams-features-resizing%})
 * [ZOrder]({%slug raddiagrams-features-zorder%})
 * [Selection]({%slug raddiagrams-features-selection%})
 * [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%})
 * [Clipboard Operations]({%slug raddiagrams-features-clipboard%})