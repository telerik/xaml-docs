---
title: Rows and Columns
page_title: Rows and Columns
description: Check our &quot;Rows and Columns&quot; documentation article for the RadTileView {{ site.framework_name }} control.
slug: radtileview-rows-and-columns
tags: rows,and,columns
published: True
position: 1
---

# Rows and Columns

By default all __TileViewItems__ are ordered automatically like in the screenshot below:



<snippet id='radtileview-features-rows-and-columns-block_1-xaml' />

![{{ site.framework_name }} RadTileView Automatic Rows and Columns](images/radtileview_features_rows_columns_default.png)

## Setting the number of Columns

To set the number of columns you can use the __ColumnsCount__ property:		



<snippet id='radtileview-features-rows-and-columns-block_2-xaml' />

![{{ site.framework_name }} RadTileView Set Columns Count](images/radtileview_features_rows_columns_count.png)

To set the maximum number of columns you can use the __MaxColumns__ property:		



<snippet id='radtileview-features-rows-and-columns-block_3-xaml' />

The result from the above code is displayed below. As you can see now the items are ordered in two columns:
![{{ site.framework_name }} RadTileView Set Max Columns](images/radtileview_features_rows_columns_count.png)

##  Setting the number of Rows

To set the number of rows you can use the __RowsCount__ property.



<snippet id='radtileview-features-rows-and-columns-block_4-xaml' />

![{{ site.framework_name }} RadTileView Set Rows Count](images/radtileview_features_rows_columns_rows_count.png)

To set the maximum number of rows you can use the __MaxRows__ property:



<snippet id='radtileview-features-rows-and-columns-block_5-xaml' />

As you can see now the items are ordered in one row only:
![{{ site.framework_name }} RadTileView Set Max Rows](images/radtileview_features_rows_columns_rows_count.png)

When both __ColumnsCount/MaxColumns__ and __RowsCount/MaxRows__ properties are set, the value of __ColumnsCount/MaxColumns__ will have a priority.



<snippet id='radtileview-features-rows-and-columns-block_6-xaml' />

As you can see from the image below only the __ColumnsCount__ property is respected:
![{{ site.framework_name }} RadTileView Respected Columns Count](images/radtileview_features_rows_columns_count.png)

##  Setting Rows and Columns Size

You can control the height of the __restored__ tiles using the __RadTileView RowHeight__ property. The __RowHeight__ property is of type __GridLength__ and support the following values:		

* __Absolute sizing__ - sets exact height to the restored tiles

* __Star sizing (*)__ - the available height will be distributed equally among the restored tiles			  

* __Auto sizing__ - each restored tile will take as much space as it needs.			  

In order to set the width of the __restored__ tiles, you need to set the __RadTileView ColumnWidth__ property. The __ColumnWidth__ property is of type __GridLength__ and support the following values:		

* __Absolute sizing__ - sets exact width to the restored tiles			  

* __Star sizing (*)__ - the available width will be distributed equally among the restored tiles			  

* __Auto sizing__ - each restored tile will take as much space as it needs.			  

The __RadTileView__ exposes two properties that allow you to define the size of the __minimized__ items:		

* __MinimizedRowHeight__ - specifies the height of the minimized items. It is of type GridLength and therefore it allows defining absolute, start and auto sizing.			  

* __MinimizedColumnWidth__ - specifies the width of the minimized tiles. It is of type GridLength and therefore it allows defining absolute, start and auto sizing.			  

> Please note that the __RadTileViewItem__ also allows you to specify each item's size using the following properties:		  
>	- __RestoredHeight/RestoredWidth__ - specifies the size of the tile in a Restored state
>	- __MinimizedHeight/MinimizedWidth__ - specifies the size of the tile in a Minimized state				

## See Also
 * [Getting Started]({%slug radtileview-getting-started%})
 * [Minimizing And Maximizing]({%slug radtileview-minimizing-and-maximizing%})