---
title: ElementExporting and ElementExported
page_title:  ElementExporting and ElementExported
description:  Learn how to utilize the ElementExporting and ElementExported events which are fired when you export data from RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-events-elementexporting-elementexported
tags: grid,export,events,elementexporting,elementexported
published: True
position: 1
---

# ElementExporting and ElementExported

You have more control over the exportation by utilizing the export events which are fired when you export data from RadGridView.

## Export Events Life Cycle

The purpose of the events is to provide you with a mechanism to style or modify the exported data.

When you call the __Export__ method of RadGridView the __ElementExporting__ and __ElementExported__ events are fired. 

The __ElementExporting__ event can be cancelled for a particular row or cell. If it is not cancelled, the  __ElementExported__ event is fired for the associated RadGridView.

You can subscribe to the events either declaratively or from the code-behind like this:

__Example 1: Subscribe to events declaratively:__

<snippet id='radgridview-export-events-elementexporting-elementexported-example_1_subscribe_to_events_declaratively-xaml' />


__Example 2: Subscribe to events from the code-behind:__

<snippet id='radgridview-export-events-elementexporting-elementexported-example_2_subscribe_to_events_from_the_code_behind-cs' />

<snippet id='radgridview-export-events-elementexporting-elementexported-example_2_subscribe_to_events_from_the_code_behind-vb' />


## ElementExporting

The event was introcuded in __Q1 2010 SP2__ as a direct replacement of the obsolete __Exporting__ event.
The event takes argument of type __GridViewElementExportingEventArgs__ which expose the following properties:

- __Cancel__: Gets or sets a boolean value that indicates whether the event should be canceled or not.
- __Context__: Gets the data context of the element that is about to be exported. In case the element is *Cell* the *DataContext* would be the underlying GridViewDataColumn.
- __Element__: Gets the current element that is about to be exported.
- __Format__: Gets the current export format - ExcelMl, Html, etc.
- __Value__: 	Gets or sets the value that is about to be exported. You can use it to change a certain element`s value.
- __ShouldEncodeValue__: Gets or sets a value indicating whether special characters in the cell value will be escaped.
- __VisualParameters__: Gets the visual export parameters. (Introduced in __Q3 2013__)

The event argument`s property __Element__ identifies the currently exported element. The possible element types are defined in the __ExportElement__ enumeration:

- *Cell*
- *GroupHeaderCell*
- *GroupHeaderRow*
- *GroupHeaderRow*
- *HeaderRow*
- *Row*
- *Table*

You can use it in combination with the __Cancel__ property to omit the export of a certain element.
	
## ElementExported

The event takes argument of type __GridViewElementExportedEventArgs__ which expose the following properties:

1. __Context__: Gets the data context of the exported element
2. __Element__: Gets the element that was exported.
3. __Format__: Gets the export format.
4. __Writer__: Gets the StreamWriter. You can use it to write additional information for the exported element.

You can use this event if you want to write additional data to the stream. A common scenario is to add [Row Details]({%slug radgridview-row-details-overview%}) to the exported data :
	
__Example 4: Add row details to the exported data with ExportFormat.Html__

<snippet id='radgridview-export-events-elementexporting-elementexported-example_4_add_row_details_to_the_exported_data_with_exportformat_html-cs' />

<snippet id='radgridview-export-events-elementexporting-elementexported-example_4_add_row_details_to_the_exported_data_with_exportformat_html-vb' />


The result is:

![Telerik UI for {{ site.framework_name }} RadGridView export showing row details included in the exported HTML output](../images/gridview_row_details_export.png)

## DataContext of the Export Elements

Each of the four events exposes a property which holds the **DataContext** for this particular **ExportElement**. Here is a breakdown of all the possible contexts:

* **GridViewRow**: The context of the **Row** export element.
* **GridViewHeaderRow**: The context of the **HeaderRow** export element.
* **GridViewDataColumn**: The context of the **HeaderCell**, **GroupFooterCell**, **FooterCell** and **Cell** export elements.
* **GroupingImpl<TGroupKey, TItem>**: The context of the **GroupHeaderRow**, **GroupHeaderCell** and **GroupFooterRow** export elements.
* **GridViewFooterRow**: The context of the **FooterRow** export element.

You can use these contexts to conditionally style and format the exported elements.

## InitializingExcelMLStyles (ExcelML only)

>tip This event will be only raised when exporting with __ExportFormat.ExcelML__

You can define a Style when __InitializingExcelMLStyles__ event is raised.
For example:
        
__Example 6: Define a style:__

<snippet id='radgridview-export-events-elementexporting-elementexported-example_6_define_a_style-cs' />


You can find a list of the properties that could be set for __ExcelMLStyle__:
        
__Alignment:__

- Horizontal - you can choose a specific alignment through ExcelMLHorizontalAlignment enumeration.
1. Vertical - you can choose a specific alignment through ExcelMLVerticalAlignment enumeration.
1. Indent   
1. Rotate   
1. ShrinkToFit
1. VerticalText
1. WrapText
              
__Font:__

- Bold    
1. Color 
1. FontName
1. Italic
1. Outline (only for Mac)
1. Size
1. StrikeThrough
1. Underline - you can choose a specific underline through ExcelMLUnderline
              

__Interior:__

- Color - You must also set Pattern in order to be applied Interior.Color
1. Pattern - you can choose a specific pattern through ExcelMLPattern
1. PatternColor - You must also set Pattern in order to be applied Interior.PatternColor
              

__NumberFormat:__

- Format

__Example 7: Apply a style before exporting:__

<snippet id='radgridview-export-events-elementexporting-elementexported-example_7_apply_a_style_before_exporting-cs' />

        
## See Also

* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToPdf]({%slug gridview-export-pdf%})
