---
title: Styling and Appearance
page_title: Styling and Appearance
description: Check our &quot;Styling and Appearance&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-styling-and-appearance
tags: styling,appearance
published: True
position: 0
---

# {{ site.framework_name }} RadVirtualGrid Styling and Appearance

__RadVirtualGrid__ is designed to handle huge amounts of data while keeping its performance and overall user experience intact. Thus, the control does not utilize the common templating mechanism provided by WPF and does not add its visual elements to the visual tree. It provides a set of properties for customizing its appearance. 

> When updating the visual properties for the headers of the control at runtime, the __UpdateHeadersUI__ method needs to be called. For any other modifications of the visual properties at runtime, the __UpdateUI__ method is to be called.

* __Background__: Sets the Background of the cell.

* __Foreground__: Sets the Foreground of the cell.

* __ColumnWidth__: Sets the Width of the Columns. The property is of type double.

* __RowHeight__: Sets the Height of the Rows. The property is of type double.

* __ColumnHeaderHeight__: Sets the Height of the Column Headers. The property is of type double.

* __RowHeaderWidth__: Sets the Width of the Row Headers. The property is of type double.

* __LinesVisibility__: This property controls the way lines of the grid are visualized. It is an enumeration that has four values to choose from: __Both__, __Horizontal__, __Vertical__ and __None__.

* __FontFamily__: Sets the FontFamily of the cell.

* __FontSize__: Sets the FontSize of the cell content.The property is of type double.

* __CellPadding__: Gets or sets a value that indicates the cells' text padding.

* __CellTextAlignment__: An enumeration property, which value can be set to the one of the following ones: __Left__, __Right__, __Center__, __Justify__.

>The ability to use the __CellTextAlignment__ mechanism depends on the value of the __MeasureTextOnRender__ property. More information can be found in the [Getting Started]({%slug virtualgrid-getting-started2%}) topic.

The styling options of the control support applying __Brushes__ to various of its elements. They are described in the following figure. 

#### __Figure 1: RadVirtualGrid's Visual Elements__ 
![RadVirtualGrid's Visual Elements](images/RadVirtualGrid_Styling_01.png)

The full set of properties is listed below.

* __HorizontalLinesBrush__

* __VerticalLinesBrush__

* __RowHeaderBackground__

* __PinnedRowHeaderBackground__

* __PinnedRowHeaderBackground__

* __RowHeaderForeground__

* __ColumnHeaderForeground__

* __CurrentCellStroke__

* __PinnedCellBackground__

* __PinnedCellForeground__

* __RowHeaderLinesBrush__

* __ColumnHeaderLinesBrush__

## See also

* [Conditional Styling]({%slug virtualgrid-conditional-styling%})
