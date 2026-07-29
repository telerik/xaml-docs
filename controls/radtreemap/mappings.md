---
title: Mappings
page_title: Mappings
description: Check our &quot;Mappings&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radtreemap-mappings
tags: mappings
published: True
position: 6
---

# Mappings

## Colorizers

The __Colorizer__ selects color for the nodes of the __RadTreeMap__ and __RadPivotMap__ control depending on their value. It maps some property of the data (usually their value) to a property of the node, for example, the background color. Each __Colorizer__ produces a brush that is applied to the property whose name is specified in the __TargetPropertyName__ property. The default property is the __Background__ of the RadTreeMapItem.

The list of Colorizers is as follows:

* *ValueBrushColorizer* - Represents a colorizer, which contains a set of *RangeBrush* objects. It chooses the brush to be applied according to the *RadTreeMapItem* value and the *From* and *To* values of each *RangeBrush*. The values of each *RangeBrush* can be absolute or relative (between 0 and 1) depending on the *IsAbsolute* property value.

* *ValueGradientColorizer* - Represents a colorizer, which contains a set of *GradientStops*. It chooses the brush to be applied according to the *RadTreeMapItem* value and colorizer's gradient stops. Each *GradientStop.Offset* value can be absolute or relative (between 0 and 1) depending on the *IsAbsolute* property value.

* *BrushColorizer* - Paints an item by using a brush.

* *PaletteColorizer* - Represents a colorizer, which holds a set of Brush objects.

* *DesaturationColorizer* - Represents a colorizer which reduces the level of saturation of a given *StartColor* depending on the *RadTreeMapItem* value. The level of desaturation can be controlled using *From* and *To* properties.

You can also set custom colors for the Children of the __RadTreeMap__ item by using the following properties:

* ChildrenBackgroundBrush - sets Background
* ChildrenBorderBrush - sets Border Brush
* ChildrenForegroundBrush - sets Foreground

## Custom Mappings

Sets the properties for the nodes of the __RadTreeMap__ and __RadPivotMap__ control depending on a custom business logic.



<snippet id='radtreemap-mappings-block_1-cs' />
<snippet id='radtreemap-mappings-block_2-vb' />