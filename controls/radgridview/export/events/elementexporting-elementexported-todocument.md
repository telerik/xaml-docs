---
title: ElementExportingToDocument and ElementExportedToDocument
page_title:  ElementExportingToDocument and ElementExportedToDocument
description:  Learn how to utilize the ElementExportingToDocument and ElementExportedToDocument events which are fired when you export data from Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-events-elementexporting-elementexported-todocument
tags: grid,export,events,elementexporting,elementexported,todocument
published: True
position: 2
---

# ElementExportingToDocument and ElementExportedToDocument

You have more control over the exportation by utilizing the export events which are fired when you export data from RadGridView.

## Export Events Life Cycle

The purpose of the events is to provide you with a mechanism to style or modify the exported data.

When you call the __ExportToXlsx__, __ExportToPdf__, __ExportToWorkbook__ and __ExportToRadFixedDocument__ methods of RadGridView, the __ElementExportingToDocument__ and __ElementExportedToDocument__ events are fired. 

The __ElementExportingToDocument__ event can be cancelled for a particular row or cell. If it is not cancelled, the  __ElementExportedToDocument__ event is fired for the associated RadGridView.

You can subscribe to the events either declaratively or from the code-behind like this:

__Example 1: Subscribe to events declaratively:__

<snippet id='radgridview-export-events-elementexporting-elementexported-todocument-example_1_subscribe_to_events_declaratively-xaml' />


__Example 2: Subscribe to events from the code-behind:__

<snippet id='radgridview-export-events-elementexporting-elementexported-todocument-example_2_subscribe_to_events_from_the_code_behind-cs' />

<snippet id='radgridview-export-events-elementexporting-elementexported-todocument-example_2_subscribe_to_events_from_the_code_behind-vb' />


## ElementExportingToDocument

The event handler expects __GridViewElementExportingToDocumentEventArgs__ argument that has the following properties:

 - __Element__ - Gets the current element that is about to be exported.
 - __Cancel__ - Gets or sets a boolean value that indicates whether the event should be canceled or not.
 - __DataContext__ - the DataContext of the corresponding visual element. For example the DataContext of the **ExportElement.Row** is the underlying **GridViewRow**.
 - __Value__ - the value that is about to be exported.
 - __VisualParameters__ - they are of type __GridViewDocumentVisualExportParameters__ and have a property __Style__ which is of type CellSelectionStyle. It provides the ability to set the FontSize, Fill and etc. for the exported document.

## ElementExportedToDocument

The event handler expects __GridViewElementExportedToDocumentEventArgs__ argument that has the following properties:

 - __Element__ - the export Element.
 - __DataContext__ - the DataContext of the corresponding element.

## InitializingExcelMLStyles (ExcelML only)

>tip This event will be only raised when exporting with __ExportFormat.ExcelML__

You can define a Style when __InitializingExcelMLStyles__ event is raised.
For example:
        
__Example 6: Define a style:__

<snippet id='radgridview-export-events-elementexporting-elementexported-todocument-example_6_define_a_style-cs' />


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

<snippet id='radgridview-export-events-elementexporting-elementexported-todocument-example_7_apply_a_style_before_exporting-cs' />

        
## See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
 
 * [Online Demo - Exporting to various formats](https://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](https://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)
