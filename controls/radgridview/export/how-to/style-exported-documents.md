---
title: Style Exported XLSX and PDF Documents
page_title: Style Exported XLSX and PDF Documents
description: Read this article to learn how to style XLSX and PDF documents exported from RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-style-exported-xlsx-pdf-documents
tags: style,exported,xlsx,pdf,documents
published: True
position: 7
---

# Style Exported XLSX and PDF Documents

If you need to style the exported RadGridView differently from its default style when exporting using the [ExportToXlsx]({%slug gridview-export-xlsx%}) & [ExportToPdf]({%slug gridview-export-pdf%}) methods, you can use the [ElementExportingToDocument]({%slug gridview-export-events%}#elementexportingtodocument) event and through the  **GridViewElementExportingToDocumentEventArgs** set the VisualParameters property to a new instance of the [CellSelectionStyle](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.gridview.cellselectionstyle) class.

The class provides the following useful properties:
* **CellBorders**: Gets or sets the borders of the cells.
* **Fill**: Gets or sets the fill of the cells.
* **FontFamily**: Gets or sets the font family of the text of the cells.
* **FontSize**: Gets or sets the font size of the text.
* **ForeColor**: Gets or sets the foreground of the text of the cells.
* **Format**: Gets or sets the format of the text.
* **HorizontalAlignment**: Gets or sets the horizontal alignment.
* **Indent**: Gets or sets the intent of the cells.
* **IsBold**: Gets or sets the IsBold property of the cells.
* **IsItalic**: Gets or sets the isItalic property of the cells.
* **IsLocked**: Gets or sets the isLocked property of the cells.
* **IsWrapped**: Gets or sets the IsWrapped property of the cells.
* **StyleName**: Gets or sets the StyleName property of the cells.
* **Underline**: Gets or sets the Underline of the text in the cells.
* **VerticalAlignment**: Gets or sets the vertical alignment.

__Example 1: Style exported XLSX/PDF document__

```C#
	private void ElementExportingToDocument(object sender, GridViewElementExportingToDocumentEventArgs e)
	{
	    if (e.Element == ExportElement.HeaderRow)
	    {
	        (e.VisualParameters as GridViewDocumentVisualExportParameters).Style = new CellSelectionStyle()
	        {
	            FontSize = 20,
	            IsBold = true,
	            Fill = new PatternFill(PatternType.Solid, Colors.Blue, Colors.Blue),
	            ForeColor = new ThemableColor(Colors.White)
	        };
	    }
	    else if (e.Element == ExportElement.Row)
	    {
	        (e.VisualParameters as GridViewDocumentVisualExportParameters).Style = new CellSelectionStyle()
	        {
	            Fill = new PatternFill(PatternType.Solid, Colors.White, Colors.White),
	            ForeColor = new ThemableColor(Colors.Black)
	        };
	    }
	}
```
```VB.NET
	Private Sub ElementExportingToDocument(ByVal sender As Object, ByVal e As GridViewElementExportingToDocumentEventArgs)
	    If e.Element = ExportElement.HeaderRow Then
	        TryCast(e.VisualParameters, GridViewDocumentVisualExportParameters).Style = New CellSelectionStyle() With {
	            .FontSize = 20,
	            .IsBold = True,
	            .Fill = New PatternFill(PatternType.Solid, Colors.Blue, Colors.Blue),
	            .ForeColor = New ThemableColor(Colors.White)
	        }
	    ElseIf e.Element = ExportElement.Row Then
	        TryCast(e.VisualParameters, GridViewDocumentVisualExportParameters).Style = New CellSelectionStyle() With {
	            .Fill = New PatternFill(PatternType.Solid, Colors.White, Colors.White),
	            .ForeColor = New ThemableColor(Colors.Black)
	        }
	    End If
	End Sub
```

## See Also

 * [Export]({%slug gridview-export%})

 * [Export Events]({%slug gridview-export-events%})

 * [ExportToXlsx]({%slug gridview-export-xlsx%})

 * [ExportToPdf]({%slug gridview-export-pdf%})
