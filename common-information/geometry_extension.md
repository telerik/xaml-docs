---
title: Geometry Extension
page_title: WPF Documentation - Geometry Extension
description: Check our &quot;Geometry Extension&quot; documentation article for WPF controls 
slug: common-geometry-extension
tags: geometry, extension
published: True
position: 6
---

# Geometry Extension

In **R3 2021** we introduced the **Geometry Extension** class which provides easy access to the most common geometries used in applications. This extension is especially useful for users that want to give a new shiny look to their control which supports custom geometry. Here is the list of all geometry types:

* __Circle__
* __Ellipse__
* __Rectangle__
* __RoundedRectangle__
* __Square__
* __Triangle__
* __RightTriangle__
* __Pentagon__
* __Hexagon__
* __Heptagon__
* __Octagon__
* __Star5__
* __Cloud__
* __Oval__
 
**Figure 1**, demonstrate how all geometries which this extension provides look like when applied to the [RadBadge]({%slug radbadge-overview%}) control.

#### **Figure 1: Geometries** 
![Geometry Types](images/radbadge-key-properties_2.png)

__Example 1 and Example 2__ demonstrate how you can use the extension in XAML and code-behind. To apply a custom geometry in code-behind, you can use the `GeometryFactory.SetGeometry()` method.

__Example 1: Set Custom Geometry in XAML__
```XAML
	<telerik:RadButton Width="85" Height="30" Content="Notifications"  VerticalAlignment="Center" HorizontalAlignment="Center">
		<telerik:RadBadge.Badge>
			<telerik:RadBadge Content="99" BadgeType="ContentOnly" Background="#FFFFC000" Geometry="{telerik:Geometry Type=Oval}" />
		</telerik:RadBadge.Badge>
	</telerik:RadButton>
```


__Example 2: Set Custom Geometry In Code__
```C#
	public Example()
	{
		this.InitializeComponent();
		this.badge.Geometry = GeometryFactory.SetGeometry(GeometryType.Hexagon);
	}
```

Additional to this, all [glyph icons]({%slug common-styling-appearance-glyphs-reference-sheet%}) can be converted to `Geometry` objects using the [RadGlyph.GetGeometry]({%slug common-styling-appearance-radglyph%}#use-glyphs-as-geometry) static method.

## See Also

* [Getting Started]({%slug common-faq%})
* [Introduction]({%slug introduction%})
