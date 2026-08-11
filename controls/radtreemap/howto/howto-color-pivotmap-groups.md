---
title: How to Change the Color of PivotMap Groups
page_title: How to Change the Color of PivotMap Groups
description: Check our &quot;How to change the color of PivotMap groups&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radpivotmap-howto-change-color-group
tags: bind,color,pivotmap,background,itemstyle
published: True
position: 2
---

# How to Change the Color of PivotMap Groups

This topic will show you how to change the colors of the PivotMap groups. 

For the purpose of this example, we will create the following model.

__Example 1: Create MovieInfo Model__
<snippet id='radtreemap-howto-howto-color-pivotmap-groups-block_1-cs' />

Next, we can go ahead and create sample data.

__Example 2: Create Sample Data__
<snippet id='radtreemap-howto-howto-color-pivotmap-groups-block_2-cs' />

Now, we can declare our RadPivotMap control in XAML. To change the color of the groups, we can use the __ItemStyle__ of the TypeDefinition. This property is of type Style, which targets RadTreeMapItem. In the custom style, we can bind the Background property to the __DataItem__ object. The __DataItem__ is a wrapper for our business object. When we are using RadPivotMap control, the DataItem will hold the group and its items. The groups are represented by a __GroupingImpl<TGroupKey, TItem>()__ collection. Now to apply different colors, we can use __IValueConverter__. The converter will be applied to the binding of Background property. Inside the IValueConverter, we can check the Name of the collection and return different colors.

__Example 3: Declare our RadTreeMap in XAML__
<snippet id='radtreemap-howto-howto-color-pivotmap-groups-block_3-xaml' />

__Example 4: Create custom IValueConverter__
<snippet id='radtreemap-howto-howto-color-pivotmap-groups-block_4-cs' />

And finally, we need to set our DataContext to the MainViewModel.

__Example 4: Setting our DataContext__
<snippet id='radtreemap-howto-howto-color-pivotmap-groups-block_5-cs' />

If you run the application now, the RadPivotMap should display the following structure:

#### Figure 1: RadPivotMap with groups in different colors
![PivotMap Color Groups](images/radpivotmap-howto-change-color-group-1.png)

## See Also
* [Overview]({%slug radtreemap-overview %})
* [SDK Examples]({%slug radtreemap-sdk-examples %})
* [Populating With Data RadTreeMap]({%slug radtreemap-populating-with-data-radtreemap %})
* [Populating With Data RadPivotMap]({%slug radtreemap-populating-with-data-radpivotmap %})