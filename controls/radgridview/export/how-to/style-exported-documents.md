---
title: Style Exported XLSX & PDF Documents
page_title: Style Exported XLSX & PDF Documents
description: Style Exported XLSX & PDF Documents
slug: gridview-export-style-exported-xlsx-pdf-documents
tags: style,exported,xlsx,pdf,documents
published: True
position: 7
---

# Style Exported XLSX & PDF Documents

If you need to style the exported RadGridView differently from its default style when exporting using the [ExportToXlsx]({%slug gridview-export-xlsx%}) & [ExportToPdf]({%slug gridview-export-pdf%}) methods, you can use the [ElementExportingToDocument]({%slug gridview-export-events%}#elementexportingtodocument) event and through the  **GridViewElementExportingToDocumentEventArgs** set the VisualParameters property to a new instance of the **CellSelectionStyle** class.

#### __[C#] Example 1: Style exported XLSX/PDF document__

{{region cs-gridview-export-style-exported-xlsx-pdf-documents_0}}
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
{{endregion}}

#### __[VB.NET] Example 1: Style exported XLSX/PDF document__

{{region vb-gridview-export-style-exported-xlsx-pdf-documents_0}}
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
{{endregion}}

## See Also

 * [Export]({%slug gridview-export%})

 * [Export Events]({%slug gridview-export-events%})

 * [ExportToXlsx]({%slug gridview-export-xlsx%})

 * [ExportToPdf]({%slug gridview-export-pdf%})
