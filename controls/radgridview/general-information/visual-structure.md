---
title: Visual Structure
page_title: Visual Structure
description: Check out the visual representation of columns, rows, cells, scroll bars, buttons and other essential elements of RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-visual-structure
tags: visual,structure
published: True
position: 1
---

# Visual Structure

This section defines terms and concepts used in the scope of __RadGridView__ you have to get familiar with prior to continue reading this help.

RadGridView is an essential user interface control used to display data in tabular format. The represented data is organized in rows and columns and can be additionally sorted, filtered or structured in groups and sub-groups. Below you can see snapshots and explanations of the main visual elements of the control organized in logical groups.

* [RadGridView Visual Structure](#radgridview-visual-structure)

* [Filtering Visual Structure](#filtering-visual-structure)

* [Grouping Visual Structure](#grouping-visual-structure)

## RadGridView Visual Structure

![Telerik {{ site.framework_name }} DataGrid Visual Structure 1 new](images/RadGridView_VisualStructure_2_new.png)  

![Telerik {{ site.framework_name }} DataGrid Visual Structure 2 new](images/gridview-visual-structure-0.png)

* __Columns__: Essential building block, represented by the base class __GridViewColumn__. There is a lot of functionality coming out-of-the-box for the grid columns. They can be data bound, frozen, reordered, hidden, renamed or auto generated based on the underlying data source. Moreover you can sort, filter or group your data by one or more of the columns. You can customize their look and feel in numerous ways. [Read more]({%slug gridview-columns-defining-columns%}).

* __Frozen Columns__: By using the frozen columns you will be able to stop your columns from horizontally  scrolling. Just drag and drop the splitter to your right or left and freeze/unfreeze the columns you like. It is represented by the __FrozenColumnsSplitter__ object. [Read more]({%slug gridview-columns-frozen-columns%}).

* __Rows__: Another essential building block of the control, represented by __GridViewRow__ objects. Improve the way your data is presented using Row Details inside the grid or outside it using Details Presenter. Moreover you can control the data editing using the methods and events exposed by the GridViewRow object. [Read more]({%slug gridview-rows-overview%}).

* __Cells__: Cells are the visual elements that do the actual representation of your data. They are represented by the __GridViewCell__ object. They are also responsible for validating the data entered by the user against the underlying data type.
            
* __Header Row__: This is a special row where all column headers are displayed. It is represented by the __GridViewHeaderRow__ object.

* __Row Indicators__: Each row has its own row indicator, placed on its left end. Small black arrow inside the row indicator marks the current item. You can show/hide the row indicators for the whole grid or customize the way they look.
            
* __Column Footers__: The column footers are used to display the results of aggregate functions, such as Sum, Count, Min, Max, Average, etc . You can also customize the column footers and place any kind of controls inside them. [Read more]({%slug gridview-columns-column-footers%}).

* __Scroll bars__: RadGridView will automatically show and hide scrollbars when needed. Choose between two types of scrolling: __Real time and Deferred__. Every hierarchical level has its own scrollbars.
            
* __Grid Lines__: Grid lines are the markers that separate grid's visual elements from each other. You can easily control the way your grid lines are visualized. 

* __Row Details__: Each row is capable of presenting additional information by means of a Row Details template. The Row Details template is a __DataTemplate__ defined on the grid- or row-level and is used for displaying row data without affecting the dimensions of the row and the cells within it.  			  
One of the advantages of using a Row Details template is that it can be displayed for the selected row only, thus providing a more compact layout. Another benefit of Row Details is the option of placing the Details Presenter outside RadGridView, which provides more room for traditional rows without depriving the user of the additional information. [Read more]({%slug radgridview-row-details-overview%}).

{% if site.site_name == 'WPF' %}
* __SearchPanel__: The search panel is shown when you press the __Ctrl+F__ key combo. It allows you to search as you type. Read more about this in the [Search as you Type]({%slug radgridview-search-as-you-type%}) article.
{% endif %}

* __ControlPanel__: The control panel allows you to define additional buttons with custom functionality in the header part of RadGridView. Read more about this in the [Control Panel]({%slug gridview-overview-controlpanel%}) article.

* __NewRowElement__: The new row element can be displayed on top or bottom of the data grid and allows you to easily add a new row by simply clicking on the element. Read more about this in the [Adding Rows]({%slug gridview-rows-adding-rows%}) article.

* __InvalidBorder__: The validation (red) border is shown when the cell value is invalid. When you hover the ribbon on the top right corner of the cell, an error tooltip is shown. Read more about this in the [Data Validation]({%slug gridview-managing-data-validation%}) article.

* __ValidationErrorTooltip__: The validation error tooltip is shown when you hover the top right corner of an invalid cell.

* __SortIndicator__: The sort indicator is shown in the column header when it is sorted. 

* __EditIndicator__: This is a type of row indicator shown when the row is in edit mode.

## Filtering Visual Structure

![Telerik {{ site.framework_name }} DataGrid Visual Structure Filtering](images/RadGridView_VisualStructure_Filtering.png)

* __Filter Icon__: You can see the filter icon placed inside the column header of each column that allows filtering.
            
* __Filtering Dialog__: Clicking the filtering icon in the column headers opens a menu with the distinct values for the current column and the user can select which of those values to be displayed. The user can enter a filter criterion in the filter box. A drop-down list allows the user to select a filter expression that is applied to the criterion for the column. When the user presses the "Filter" button, the grid displays only the records that match the filter criteria specified using the filter boxes. Using this functionality you can filter your data by multiple columns. You can easily disable this functionality by setting the __IsFilterable__ property of the __GridViewColumn__ to __False__.

* __Distinct Filter Values__: Each filtering dialog automatically displays a list with all of the distinct values in a certain column. This allows you to create filters with just a few clicks of your mouse.            

* __Close Button__: It allows closing the dialog without clearing the filters.
		
* __Field Filter__: Consists of the following parts:	 
			
	* __Operator__: It specifies the comparison operator to be used. 

	* __Match Case ToggleButton__: It specifies if the filtered value will be perceived as case sensitive or insensitive. 
				
	* __Logical Operator__: It specifies the logical operator between the two criteria of the field filter.
For more information you can refer to the [Basic Filtering]({%slug gridview-filtering-basic%}) and [Programmatic Filtering]({%slug gridview-filtering-programmatic%}) articles.		

>tip Read more about the filtering feature in the [Filtering]({%slug gridview-overview-filtering%}) article.

## Grouping Visual Structure

![Telerik {{ site.framework_name }} DataGrid Visual Structure 4 new](images/RadGridView_VisualStructure_4_new.png)

* __Group Panel__: The grouping panel is placed right above the control and it displays the columns by which your grid has been grouped. To group the grid just drag and drop the needed columns in the grouping area. To remove the grouping by certain column just click the x button of the appropriate column in the grouping panel. [Read more]({%slug gridview-grouping-basics%}).

* __Group Panel Item__: Represents the column, by which the data is being grouped.
            
* __Group Header__: This represents the group header.		

* __Group Expander__: Using this button, you can expand/collapse the groups.	

* __Group Row__: This is the UI element that hosts and displays group records, represented by a __GroupHeaderRow__/__GridViewGroupRow__ object depending on the [GroupRenderMode]({%slug gridview-grouping-groupingmodes%}). The group row allows for expanding and collapsing the records in the group.

* __Indent Cell__: The __GridViewIndentCell__ appears when the grid data is grouped or has hierarchical structure, to facilitate the expand/collapse functionality. The expand cell is always placed in front of all other grid content columns and cannot be moved.
            
>tip Read more about the grouping feature in the [Grouping]({%slug gridview-overview-grouping%}) article.
