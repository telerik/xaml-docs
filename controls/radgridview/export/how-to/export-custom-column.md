---
title: Export Custom Column
page_title: Export Custom Column
description: Export Custom Column
slug: gridview-export-custom-column
tags: export,string,value
published: True
position: 6
---

# Exporting Custom Column

In order to automatically export a custom column, without handling some of the exporting events, it should implement the **IExportableColumn** interface. The interface exposes  the following methods and properties:

* **GetCellContent**: gets the content of the cell. You can override it to return custom value.
* **DataFormatString**:  gets or sets the string format applied to the column.
* **ExportedElementWidth**:  gets the actual width of the column.

>important The GridViewBoundColumnBase class implements the interface so you can directly override the method.

#### **Example 1: Overriden GetCellContent method**
 
	   protected override object GetCellContent(object item)
	   {
	       var columnProperty = item.GetType().GetProperty(this.DataMemberBinding.Path.Path);
	       return string.Format("@ {0} @", columnProperty.GetValue(item, null) as string);
	   }
 
The values from the exported column will appear in Excel as shown in **Figure 1**.

#### **Figure 1: Exported Custom Column to Excel**

![exported custom column](images/gridview_exported-custom-column.png)

## See Also

* [Export Events]({%slug gridview-export-events%})
* [Export to Excel]({%slug gridview-export-xlsx%})
* [Export to Pdf]({%slug gridview-export-pdf%})