---
title: How to Bind the Color of the TreeMapItems
page_title: How to Bind the Color of the TreeMapItems
description: Check our &quot;How to bind the color of the TreeMapItems&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radtreemap-howto-bind-color
tags: bind,color,treemapitem,background,itemstyle
published: True
position: 1
---

# How to Bind the Color of the TreeMapItems

This topic will show you how to bind the color of the TreeMapItems. 

For the purpose of this example, we will create the following model.

__Example 1: Create ItemInfo Model__
<snippet id='radtreemap-howto-howto-bind-treemapitems-colors-block_1-cs' />

Next, we can go ahead and create sample data.

__Example 2: Create Sample Data__
<snippet id='radtreemap-howto-howto-bind-treemapitems-colors-block_2-cs' />

Now, we can declare our RadTreeMap control in XAML. To bind the color of the items, we can use the __ItemStyle__ of the TypeDefinition. This property is of type Style which targets RadTreeMapItem.

__Example 3: Declare our RadTreeMap in XAML__
<snippet id='radtreemap-howto-howto-bind-treemapitems-colors-block_3-xaml' />

And finally, we need to set our DataContext to the ViewModel.

__Example 4: Setting our DataContext__
<snippet id='radtreemap-howto-howto-bind-treemapitems-colors-block_4-cs' />

If you run the application now, the RadTreeMap should display the following structure:

#### Figure 1: RadTreeMap with bound colors 
![TreeMap Bind Color](images/radtreemap-howto-bind-color-1.png)

## See Also
* [Overview]({%slug radtreemap-overview %})
* [SDK Examples]({%slug radtreemap-sdk-examples %})
* [Populating With Data RadTreeMap]({%slug radtreemap-populating-with-data-radtreemap %})
* [Populating With Data RadPivotMap]({%slug radtreemap-populating-with-data-radpivotmap %})