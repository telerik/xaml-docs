---
title: DataContext of the Export Elements
page_title:  DataContext of the Export Elements
description:  Learn how to use a number of contexts to conditionally style and format the elements exported from RadGridView - Telerik's WPF DataGrid.
slug: gridview-export-events
tags: grid,export,events
published: True
position: 3
---

# DataContext of the Export Elements

Each of the export events exposes a property which holds the **DataContext** for this particular **ExportElement**. Here is a breakdown of all the possible contexts:

* **GridViewRow**: The context of the **Row** export element.
* **GridViewHeaderRow**: The context of the **HeaderRow** export element.
* **GridViewDataColumn**: The context of the **HeaderCell**, **GroupFooterCell**, **FooterCell** and **Cell** export elements.
* **GroupingImpl<TGroupKey, TItem>**: The context of the **GroupHeaderRow**, **GroupHeaderCell** and **GroupFooterRow** export elements.
* **GridViewFooterRow**: The context of the **FooterRow** export element.

You can use these contexts to conditionally style and format the exported elements.
        
## See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
 
 * [Online Demo - Exporting to various formats](https://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](https://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)
