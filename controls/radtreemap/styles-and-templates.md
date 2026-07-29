---
title: Styles and Templates
page_title: Styles and Templates
description: Check our &quot;Styles and Templates&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radtreemap-styles-and-templates
tags: styles,and,templates
published: True
position: 2
---

# Styles and Templates

This section is intended to give you a broad understanding of the possible ways in which you can change the visual appearance of the RadTreeMap and RadPivotMap.

You can modify the look of the RadTreeMap by using the __RadTreeMap.DefaultItemTemplate__ and __TypeDefinition.ItemTemplate__ properties. For the RadPivotMap you can use __RadPivotMap.LeafItemStyle__ and __GroupDefinition.ItemStyle__ properties. You can also use the __TypeDefiniton.ItemStyle__ which is common for both.

The following small practical samples will show you how to use this properties to customize your control:

## RadPivotMap

There could be cases in __RadPivotMap__ when the text per rectangle is chopped due to the size of the rectangles calculated, it is not adjustable by just tuning the text length and size because the rectangle size is recalculated every time when window size is changed. To have a fully readable labels you may wrap your TextBlock in a control like ViewBox for example which resizes itself based on the size of its content and put it in the header of your rectangle using __LeafTemplate__ like this:



<snippet id='radtreemap-styles-and-templates-block_1-xaml' />

This is the full source code of the sample:



<snippet id='radtreemap-styles-and-templates-block_2-cs' />
<snippet id='radtreemap-styles-and-templates-block_3-vb' />

>caution Since you wrapped the TextBlock in a ViewBox, the Size of the Text will change according to the space available which will lead to texts with different size (shown on the image below). If you don't want such appearance, you should consider removing the ViewBox and using __TextWrapping__ and __MaxWidth__ for the TextBlock-s.

The result is shown below:
![{{ site.framework_name }} RadTreeMap Custom Leaf Template](images/radtreemap_styles_and_templates_01.PNG)

## RadTreeMap

You can customize the way __RadTreeMap__ Items look like per *TypeDefinition*. This is where the __TypeDefinition's ItemStyle__ comes in handy. For example you want every Label to be colored Blue and to have a Red Border per every Item with TypeDefinition where the TargetTypeName is *File*.

>Please refer to the [Populating With Data RadTreeMap]({%slug radtreemap-populating-with-data-radtreemap%}) for the full source code of the sample.



<snippet id='radtreemap-styles-and-templates-block_4-xaml' />

The result is shown on the following image:
![{{ site.framework_name }} RadTreeMap Custom Item Style](images/radtreemap_styles_and_templates.PNG)