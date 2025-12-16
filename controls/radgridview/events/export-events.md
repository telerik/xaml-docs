---
title: Export
page_title: Export Events
description: Learn more about the export events of Telerik's {{ site.framework_name }} DataGrid that occur when you export data from the grid.
slug: gridview-events-export-events
tags: export
published: True
position: 4
---

# Export Events

You have more control over the exportation by utilizing the export events which are fired when you export data from RadGridView:

* [ElementExporting](#elementexporting)

* [ElementExported](#elementexported)

* [ElementExportingToDocument](#elementexportingtodocument)

* [ElementExportedToDocument](#elementexportedtodocument)

* [InitializingExcelMLStyles](#initializingexcelmlstyles-excelml-only)

## Export Events Life Cycle

The purpose of the events is to provide you with a mechanism to style or modify the exported data.

When you call the __Export__ method of RadGridView, the __ElementExporting__ and __ElementExported__ events are fired. 

If you are using the more recently introduced __ExportToXlsx__ and __ExportToPdf__ methods, you should take advantage of the __ElementExportingToDocument__ and __ElementExportedToDocument__ events.

The __ElementExporting__ and __ElementExportingToDocument__ events can be cancelled for a particular row or cell. If they are not cancelled - the  __ElementExported__ or __ElementExportedToDocument__ event is fired for the associated RadGridView.

You can subscribe to the events either declaratively or from the code-behind, as shown in the next three examples.

__Example 1: Subscribe to events declaratively__
```XAML
	<telerik:RadGridView x:Name="RadGridView1"
	             ElementExporting="RadGridView1_ElementExporting"
	             ElementExported="RadGridView1_ElementExported" />
```

__Example 2: Subscribe to events from the code-behind__
```C#
	RadGridView1.ElementExporting += RadGridView1_ElementExporting;
	RadGridView1.ElementExported += RadGridView1_ElementExported;
```
```VB.NET
	AddHandler RadGridView1.ElementExporting, AddressOf RadGridView1_ElementExporting
	AddHandler RadGridView1.ElementExported, AddressOf RadGridView1_ElementExported
```

## ElementExporting

Telerik introduced the __ElementExporting__ event in __Q1 2010 SP2__ as a direct replacement of the obsolete __Exporting__ event.
The __ElementExporting__ event takes argument of type __GridViewElementExportingEventArgs__, which expose the following properties:

- __Cancel__: Gets or sets a boolean value that indicates whether the event should be canceled or not.
- __Context__: Gets the current context.
- __Element__: Gets the current element that is about to be exported.
- __Format__: Gets the current export format.
- __Value__: Gets or sets the value to be exported.
- __ShouldEncodeValue__: Gets or sets a value indicating whether special characters in the cell value will be escaped.
- __VisualParameters__: Gets the visual export parameters. (Introduced in __Q3 2013__.)

The event argument's property __Element__ identifies the currently exported element. The possible element types are defined in the __ExportElement__ enumeration:

- *Cell*
- *GroupHeaderCell*
- *GroupHeaderRow*
- *GroupHeaderRow*
- *HeaderRow*
- *Row*
- *Table*

You can use the Element property in combination with the __Cancel__ property to omit the export of a certain element.
	
## ElementExported

The __ElementExported__ event takes argument of type __GridViewElementExportedEventArgs__, which expose the following properties:

- __Context__: Gets the current context.
- __Element__: Gets the current element.
- __Format__: Gets the current export format.
- __Writer__: Gets the StreamWriter.

You can use the __ElementExported__ event if you want to write additional data to the stream. A common scenario is to add [Row Details]({%slug radgridview-row-details-overview%}) to the exported data, as shown in __Example 3__.

__Example 3: Add row details to the exported data__

```C#
	private void RadGridView1_ElementExported(object sender, GridViewElementExportedEventArgs e)
	{
	    if (e.Element == ExportElement.Row)
	    {
	        Employee obj = e.Context as Employee;
	        if (obj != null)
	        {
	            e.Writer.Write(String.Format(@"<tr><td style=""background-color:#CCC;"" colspan=""{0}"">",
	                ((IEnumerable<Telerik.Windows.Controls.GridViewColumn>)RadGridView1.Columns).Count()));
	            e.Writer.Write(String.Format(@"<b>Birth date:</b> {0} <br />", obj.BirthDate));
	            e.Writer.Write(String.Format(@"<b>Hire date:</b> {0} <br />", obj.HireDate));
	            e.Writer.Write(String.Format(@"<b>Address:</b> {0} <br />", obj.Address));
	            e.Writer.Write(String.Format(@"<b>City:</b> {0} <br />", obj.City));
	            e.Writer.Write(String.Format(@"<b>Notes:</b> {0} <br />", obj.Notes));
	            e.Writer.Write("</td></tr>");
	        }
	    }
	}
```
```VB.NET
	Private Sub RadGridView1_ElementExported(ByVal sender As Object, ByVal e As GridViewElementExportedEventArgs)
	    If e.Element = ExportElement.Row Then
	        Dim obj As Employee = TryCast(e.Context, Employee)
	        If obj IsNot Nothing Then
	            e.Writer.Write(String.Format("<tr><td style=""background-color:#CCC;"" colspan=""{0}"">", DirectCast(RadGridView1.Columns, IEnumerable(Of Telerik.Windows.Controls.GridViewColumn)).Count()))
	            e.Writer.Write(String.Format("<b>Birth date:</b> {0} <br />", obj.BirthDate))
	            e.Writer.Write(String.Format("<b>Hire date:</b> {0} <br />", obj.HireDate))
	            e.Writer.Write(String.Format("<b>Address:</b> {0} <br />", obj.Address))
	            e.Writer.Write(String.Format("<b>City:</b> {0} <br />", obj.City))
	            e.Writer.Write(String.Format("<b>Notes:</b> {0} <br />", obj.Notes))
	            e.Writer.Write("</td></tr>")
	        End If
	    End If
	End Sub
```

You can see the result in **Figure 1**.

#### __Figure 1: Exporting Row Details__

![Row Details Export in RadGridView - Telerik's {{ site.framework_name }} DataGrid](images/gridview_row_details_export.png)

## ElementExportingToDocument

The __ElementExportingToDocument__ event is fired when exporting with *ExportToXlsx* or *ExportToPdf* methods.
The event handler expects a __GridViewElementExportingToDocumentEventArgs__ argument that has the following properties:

 - __Element__: The export element.
 - __Cancel__: The event is cancelable.
 - __DataContext__: The DataContext of the corresponding visual element. For example, the DataContext of a row is its corresponding data item.
 - __Value__: The value to be exported.
 - __VisualParameters__: They are of type __GridViewDocumentVisualExportParameters__ and have a __Style__ property that is of type CellSelectionStyle. It provides the ability to set the FontSize, Fill, etc., for the exported document.

## ElementExportedToDocument

The __ElementExportedToDocument__ event is fired when exporting with the *ExportToXlsx* or *ExportToPdf* methods.
The event handler expects a __GridViewElementExportedToDocumentEventArgs__ argument that has the following properties:

 - __Element__: The export Element.
 - __DataContext__: The DataContext of the corresponding visual element.

## InitializingExcelMLStyles (ExcelML only)

>tip This event will be only raised when exporting with __ExportFormat.ExcelML__.

You can define a style when the __InitializingExcelMLStyles__ event is raised, as shown in __Example 4__.

        
__Example 4: Define a style__

```C#
	ExcelMLStyle style = new ExcelMLStyle("0");
	style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	e.Styles.Add(style);
```
```VB.NET
	Dim style As New ExcelMLStyle("0")
	style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic
	e.Styles.Add(style)
	'
```

Here is a list of the properties that could be set for __ExcelMLStyle__:
        
__Alignment__:
- Horizontal: You can choose a specific alignment through the ExcelMLHorizontalAlignment enumeration.
- Vertical: You can choose a specific alignment through the ExcelMLVerticalAlignment enumeration.
- Indent   
- Rotate   
- ShrinkToFit
- VerticalText
- WrapText
              
__Font__:

- Bold    
- Color 
- FontName
- Italic
- Outline (only for Mac)
- Size
- StrikeThrough
- Underline: You can choose a specific underline through ExcelMLUnderline.
              

__Interior__:

- Color: You must also set a pattern in order to be applied in Interior.Color.
- Pattern: You can choose a specific pattern through ExcelMLPattern.
- PatternColor: You must also set a pattern in order to be applied in Interior.PatternColor.
              

__NumberFormat__:

- Format

__Example 5__ shows how to use __ExcelMLStyle__.

__Example 5: Modify the style before exporting__

```C#
	private void clubsGrid_InitializingExcelMLStyles_1(object sender, ExcelMLStylesEventArgs e)
	{
	    ExcelMLStyle style = new ExcelMLStyle("0");
	
	    // Alignment
	    style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	    style.Alignment.Vertical = ExcelMLVerticalAlignment.Top;
	    style.Alignment.Indent = 5;
	    style.Alignment.Rotate = 0;
	    style.Alignment.ShrinkToFit = true;
	    style.Alignment.VerticalText = true;
	    style.Alignment.WrapText = true;
	
	    // Font
	    style.Font.Bold = true;
	    style.Font.Color = "Beige";
	    style.Font.FontName = "Calibri";
	    style.Font.Italic = true;
	    style.Font.Outline = true;
	    style.Font.Shadow = true;
	    style.Font.Size = 10;
	    style.Font.StrikeThrough = true;
	    style.Font.Underline = ExcelMLUnderline.Double;
	
	    // Interior
	    style.Interior.Color = "Green";
	    style.Interior.Pattern = ExcelMLPattern.Solid;
	    style.Interior.PatternColor = "#FF0000";
	
	    // NumberFormat
	    style.NumberFormat.Format = "00.00";
	
	    e.Styles.Add(style);
	}
```
```VB.NET
	Private Sub clubsGrid_InitializingExcelMLStyles_1(ByVal sender As Object, ByVal e As ExcelMLStylesEventArgs)
	    Dim style As New ExcelMLStyle("0")
	
	    ' Alignment
	    style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic
	    style.Alignment.Vertical = ExcelMLVerticalAlignment.Top
	    style.Alignment.Indent = 5
	    style.Alignment.Rotate = 0
	    style.Alignment.ShrinkToFit = True
	    style.Alignment.VerticalText = True
	    style.Alignment.WrapText = True
	
	    ' Font
	    style.Font.Bold = True
	    style.Font.Color = "Beige"
	    style.Font.FontName = "Calibri"
	    style.Font.Italic = True
	    style.Font.Outline = True
	    style.Font.Shadow = True
	    style.Font.Size = 10
	    style.Font.StrikeThrough = True
	    style.Font.Underline = ExcelMLUnderline.Double
	
	    ' Interior
	    style.Interior.Color = "Green"
	    style.Interior.Pattern = ExcelMLPattern.Solid
	    style.Interior.PatternColor = "#FF0000"
	
	    ' NumberFormat
	    style.NumberFormat.Format = "00.00"
	
	    e.Styles.Add(style)
	End Sub
```
        
## See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
 
 * [Online Demo - Exporting to various formats](https://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](https://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)

