---
title: Export Numeric Value
page_title: Export Numeric Value
description: Export Numeric Value
slug: gridview-export-numeric-value
tags: export,string,value
published: True
position: 4
---

# Export Numeric Value

__PROBLEM__

When exporting a RadGridView to Excel using __ExportFormat.ExcelML__, if you have applied a DataFormatString for a certain column of type integer, the values are exported as strings.


__CAUSE__

The content of each cell within the column is treated as string due to the formatting that was applied.


__SOLUTION__

You need to parse the value back to a numeric type by utilizing the __ElementExporting__ event.

Here is a small sample code:
        

#### __[C#]Example 1: Handling the ElementExporting event:__

{{region cs-gridview-export-troubleshooting-export-string_0}}

	 void clubsGrid_ElementExporting(object sender, GridViewElementExportingEventArgs e)
        {
            if (e.Element == ExportElement.Cell)
            {
                var column = e.Context as GridViewDataColumn;
                if (column.Header.ToString() == "Stadium")
                {
                    e.Value = double.Parse(e.Value.ToString());
                }
            }
       }

{{endregion}}

#### __[VB.NET]Example 2: Handling the ElementExporting event:__

{{region vb-gridview-export-troubleshooting-export-string_1}}

    Private Sub clubsGrid_ElementExporting(sender As Object, e As GridViewElementExportingEventArgs)
        Dim column = TryCast(e.Context, GridViewDataColumn)
        If e.Element = ExportElement.Cell Then
            If column.Header.ToString() = "My String Column" Then
                e.Value = String.Format("=T(""{0}"")", e.Value)
            End If
        End If
    End Sub
{{endregion}}




