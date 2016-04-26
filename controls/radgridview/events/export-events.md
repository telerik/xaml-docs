---
title: Export
page_title: Export
description: Export
slug: gridview-export-events
tags: export
published: True
position: 4
---

# RadGridView Export Events

You have more control over the exportation by utilizing the export events which are fired when you export data from RadGridView:
<Comment: I do not know what "the exportation" refers to. I suggest adding a sentence before this one that describes when and why a developer might want to export RadGridView events. Perhaps list examples of events that get exported. Where do events get exported to? What consumes/uses exported events?>
* [ElementExporting](#elementexporting)

* [ElementExported](#elementexported)

* [ElementExportingToDocument](#elementexportingtodocument)

* [ElementExportedToDocument](#elementexportedtodocument)

* [InitializingExcelMLStyles](#initializingexcelmlstyles-excelml-only)

## Export Events Life Cycle

The purpose of the events is to provide you with a mechanism to style or modify the exported data.
<Comment: The beginning of the sentence is confusing. Which events? Exported RadGridView events? >
When you call the __Export__ method of RadGridView, the __ElementExporting__ and __ElementExported__ events are fired. 

If you are using the more recently introduced __ExportToXlsx__ and __ExportToPdf__ methods, you should take advantage of the __ElementExportingToDocument__ and __ElementExportedToDocument__ events.

The __ElementExporting__ and __ElementExportingToDocument__ events can be cancelled for a particular row or cell. If they are not cancelled - the  __ElementExported__ or __ElementExportedToDocument__ event is fired for the associated RadGridView.

You can subscribe to the events either declaratively or from the code-behind, as shown in the next three examples.
<Comment: They style your team has followed in other help articles with code examples that differ in language but show the same technique is the give them the same example number. So, for example, below you would have [XAML] Example 1, [C#] Example 1 and [VB.NET] Example 1. If you change them, you should make similar changes in the body text and the examples through the whole article.>
#### __[XAML]Example 1: Subscribe to events declaratively__

{{region gridview-export-events_0}}

	<telerik:RadGridView x:Name="RadGridView1"
	                     ElementExporting="RadGridView1_ElementExporting"
	                     ElementExported="RadGridView1_ElementExported">
{{endregion}}

#### __[C#]Example 2: Subscribe to events from the code-behind__

{{region gridview-export-events_1}}

	RadGridView1.ElementExporting += new EventHandler<GridViewElementExportingEventArgs>(RadGridView1_ElementExporting);
	RadGridView1.ElementExported += new EventHandler<GridViewElementExportedEventArgs>(RadGridView1_ElementExported);
{{endregion}}


#### __[VB.NET]Example 3: Subscribe to events from the code-behind__

{{region gridview-export-events_2}}

	AddHandler RadGridView1.ElementExporting, AddressOf RadGridView1_ElementExporting
	AddHandler RadGridView1.ElementExported, AddressOf RadGridView1_ElementExported
{{endregion}}

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

You can use it in combination with the __Cancel__ property to omit the export of a certain element. <Comment: What does "it" refer to in the previous sentence? You have a lot of nouns so please replace "it" with the correct noun.>

>As of version __Q1 2015__, we have removed the obsolete class __GridViewExportEventArgs__ as well as the __TextAlignment__, __VerticalAlignment__, __Background__, __Foreground__, __FontFamily__, __FontSize__, __FontWeight__, __Width__, __Height__, __Styles__ and __Attributes__ properties from the __GridViewElementExportingEventArgs__ class. You can find detailed instructions on how to migrate your existing code related to styling in the [Backward Compatibility]({%slug radgridview-backward-compatibility%}#q1-2015) article.
	
## ElementExported

The __ElementExported__ event takes argument of type __GridViewElementExportedEventArgs__, which expose the following properties:

1. __Context__: Gets the current context.
2. __Element__: Gets the current element.
3. __Format__: Gets the current export format.
4. __Writer__: Gets the StreamWriter.

You can use the __ElementExported__ event if you want to write additional data to the stream. A common scenario is to add [Row Details]({%slug radgridview-row-details-overview%}) to the exported data, as shown in __Example 4__ and __Example 5__.
<Comment: See my previous comment about numbering examples that do the same function but differ in language.>	
#### __[C#] Example 4: Add row details to the exported data__

{{region gridview-export-events_5}}

	private void RadGridView1_ElementExported(object sender, GridViewElementExportedEventArgs e)
	{
	    if (e.Element == ExportElement.Row)
	    {
	        Employees obj = e.Context as Employees;
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
{{endregion}}

#### __[VB.NET] Example 5: Add row details to the exported data__

{{region gridview-export-events_6}}

	Private Sub RadGridView1_ElementExported(sender As Object, e As GridViewElementExportedEventArgs)
	 If e.Element = ExportElement.Row Then
	  Dim obj As Employees = TryCast(e.Context, Employees)
	  If obj IsNot Nothing Then
	   e.Writer.Write([String].Format("<tr><td style=""background-color:#CCC;"" colspan=""{0}"">", DirectCast(RadGridView1.Columns, IEnumerable(Of Telerik.Windows.Controls.GridViewColumn)).Count()))
	   e.Writer.Write([String].Format("<b>Birth date:</b> {0} <br />", obj.BirthDate))
	   e.Writer.Write([String].Format("<b>Hire date:</b> {0} <br />", obj.HireDate))
	   e.Writer.Write([String].Format("<b>Address:</b> {0} <br />", obj.Address))
	   e.Writer.Write([String].Format("<b>City:</b> {0} <br />", obj.City))
	   e.Writer.Write([String].Format("<b>Notes:</b> {0} <br />", obj.Notes))
	   e.Writer.Write("</td></tr>")
	  End If
	 End If
	End Sub
{{endregion}}

You can see the result in Figure 1.
<Comment: Please add an SEO-friendly caption to the figure.>
![](images/gridview_row_details_export.png)

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

>tipThis event will be only raised when exporting with __ExportFormat.ExcelML__.

You can define a style when the __InitializingExcelMLStyles__ event is raised, as shown in __Example 6__.

        
#### __[C#] Example 6: Define a style__

{{region gridview-export-events_7}}

	ExcelMLStyle style = new ExcelMLStyle("0");            
	style.Alignment.Horizontal = ExcelMLHorizontalAlignment.Automatic;
	e.Styles.Add(style);
{{endregion}}

Here is a list of the properties that could be set for __ExcelMLStyle__:
        
__Alignment__:
<Comment: Why does the list switch from a bullet list to a numbered list? Why is Vertical not at the same level as Horizontal? I suggest you do not use a numbered list here and in the lists below this one through the end of this article. Those are best used for step-by-step instructions. You could indent a bullet list more or change the type of bullet to create a sub-list.>
- Horizontal: You can choose a specific alignment through the ExcelMLHorizontalAlignment enumeration.
1. Vertical: You can choose a specific alignment through the ExcelMLVerticalAlignment enumeration.
1. Indent   
1. Rotate   
1. ShrinkToFit
1. VerticalText
1. WrapText
              
__Font__:

- Bold    
1. Color 
1. FontName
1. Italic
1. Outline (only for Mac)
1. Size
1. StrikeThrough
1. Underline: You can choose a specific underline through ExcelMLUnderline.
              

__Interior__:

- Color: You must also set a pattern in order to be applied in Interior.Color.
1. Pattern: You can choose a specific pattern through ExcelMLPattern.
1. PatternColor: You must also set a pattern in order to be applied in Interior.PatternColor.
              

__NumberFormat__:

- Format

__Example 7__ shows how to use __ExcelMLStyle__.
<Comment: Please review my sentence above and verify I did not say anything not accurate about the code example. Or, please rewrite my sentence and the caption for example 7 to be more SEO friendly.>
#### __[C#] Example 7: Modify the style before exporting__

{{region gridview-export-events_9}}

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
{{endregion}}


        
# See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
 
 * [Online Demo - Exporting to various formats](http://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](http://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)

