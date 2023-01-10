---
title: Overview
page_title: Hierarchy Overview
description: Learn how you can display hierarchical data in the form of nested tables when working with RadGridView - Telerik's {{ site.framework_name }} DataGrid. 
slug: gridview-hierachy-overview
tags: overview
published: True
position: 0
---

# {{ site.framework_name }} RadGridView Hierarchy Overview

Besides the trivial tabular data visualization, the __RadGridView__ is capable of displaying hierarchical data in the form of nested tables. In the [Basic Hierarchies]({%slug gridview-basic-hierarchies%}) topic you can find information about the basics of building a hierarchical grid.

#### __Figure 1: Basic Hierarchies__
![GridView Basic Hierarchies](images/gridview-basic-hierarchies.PNG)

The __RadGridView__ also allows you to create hierarchies in your grid based on some custom logic. 
In that case you can benefit from the __RowDetails options__. To learn more about these take a look at the [Row Details]({%slug radgridview-row-details-overview%}) topic.

#### __Figure 2: Row Details__
![GridView Row Details](images/gridview-row-details.PNG)

In the cases when the nested grids should display data of the same type as the master grid, you can build a self-referencing grid. To learn more about the self-referencing approach take a look at the [Self-Referencing GridView]({%slug gridview-self-referencing-grid%}) topic.

#### __Figure 3: Self-Referencing GridView__
![GridView Self-Referencing](images/gridview-self-referencing.PNG)


>important Please bear in mind that the **DataContext** of the row details presenter and the hierarchy child presenter is the **parent row** and not the context of the RadGridView itself. You can change the DataContext either in the [LoadingRowDetails]({%slug radgridview-row-details-programming%}) event when dealing with row details or in the [DataLoding]({%slug gridview-how-to-access-child-gridview%}) event when building a hierarchy with table definitions.

## See Also

 * [Basic Hierarchies]({%slug gridview-basic-hierarchies%})

 * [Custom Hierarchies]({%slug gridview-custom-hierarchies%})

 * [Self-Referencing GridView]({%slug gridview-self-referencing-grid%})

 * [Row Details Events]({%slug radgridview-row-details-programming%})

 * [Set Properties of the Child RadGridView]({%slug gridview-how-to-access-child-gridview%})
