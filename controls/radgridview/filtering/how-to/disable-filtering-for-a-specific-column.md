---
title: Disable Filtering for a Specific Column
page_title: Disable Filtering for a Specific Column
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to disable filtering for a specific column.
slug: gridview-filtering-disable-filtering-for-a-specific-column
tags: disable,filtering,for,a,specific,column
published: True
position: 1
---

# Disable Filtering for a Specific Column

You can disable the filtering for a specific column by setting its **IsFilterable** property to **False**. This will hide the filtering UI of the respective column and the end user will not be able to perform filtering. The property's default value is **True**.

__Example 1: Disable the filtering of the Name column in XAML__

<snippet id='radgridview-filtering-how-to-disable-filtering-for-a-specific-column-example_1_disable_the_filtering_of_the_name_column_in_xaml-xaml' />


__Example 2: Disable the filtering of the Name column when generating it__

<snippet id='radgridview-filtering-how-to-disable-filtering-for-a-specific-column-example_2_disable_the_filtering_of_the_name_column_when_generating_it-cs' />

<snippet id='radgridview-filtering-how-to-disable-filtering-for-a-specific-column-example_2_disable_the_filtering_of_the_name_column_when_generating_it-vb' />


#### Figure 1: The Name column with disabled filtering

![Telerik UI for {{ site.framework_name }} RadGridView Name column with filtering disabled and no funnel icon](images/disable-filter.png)

>important If the data displayed in the column is not filterable in the first place, setting the IsFilterable property will not have any effect. To learn what your objects need to implement for the column to become filterable, please have a look at the [Filter a Custom Type]({%slug gridview-filtering-howto-filter-a-custom-type%}) article.

## See Also

* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Filter a Custom Type]({%slug gridview-filtering-howto-filter-a-custom-type%})
* [AutoGeneratingColumn Event]({%slug gridview-column-resize-event%}#autogeneratingcolumn)
