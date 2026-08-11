---
title: Export Custom Column
page_title: Export Custom Column
description: Read this article to learn how to automatically export a custom column from RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-custom-column
tags: export,string,value
published: True
position: 6
---

# Exporting Custom Column

>important As of __R1 2018__ the __GetCellContent__ method is __no longer__ used for exporting a custom column content. Instead, the __GetExportCellContent__ one of GridViewBoundColumnBase needs to be overriden. Check __Example 2__.

In order to automatically export a custom column, without handling some of the exporting events, it should implement the **IExportableColumn** interface. The interface exposes the following methods and properties:

* **GetCellContent**: Gets the content of the cell. You can override it to return custom value.
* **DataFormatString**:  Gets or sets the string format applied to the column.
* **ExportedElementWidth**:  Gets the actual width of the column.

> The GridViewBoundColumnBase class implements the interface so you can directly override the method.

#### **[C#]Example 1: Overriden GetCellContent method**
 
<snippet id='radgridview-export-how-to-export-custom-column-block_1-cs' />


#### **[C#]Example 2: Overriden GetExportCellContent method**

<snippet id='radgridview-export-how-to-export-custom-column-block_2-cs' />


The values from the exported column will appear in Excel as shown in **Figure 1**.

#### **Figure 1: Exported Custom Column to Excel**

![Telerik UI for {{ site.framework_name }} RadGridView exported custom column values shown in Excel](images/gridview_exported-custom-column.png)

## See Also

* [Export Events]({%slug gridview-export-events%})
* [Export to Excel]({%slug gridview-export-xlsx%})
* [Export to Pdf]({%slug gridview-export-pdf%})
