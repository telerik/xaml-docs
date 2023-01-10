---
title: Format Group Header Cell Content
page_title: Format Group Header Cell Content
description: Read this article to learn how to format group header cell content within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-group-header-cell-content
tags: export, group, header, cell, content
published: True
position: 8
---

# {{ site.framework_name }} RadGridView Format Group Header Cell Content

By handling the [ElementExportingToDocument]({%slug gridview-export-events%}#elementexportingtodocument) of the RadGridView control, you can specify a custom format for the exported group header cells. For example, you can export the captions of the aggregate results with their formatted value (based on the [ResultFormatString]({%slug gridview-columns-aggregate-functions%}#resultformatstring) of the function) as well as the number of items in the group.

#### __[C#] Example 1: Custom Group Header Cell Export Content__

{{region cs-gridview-export-group-header-cell-content-1}}
    private void Grid_ElementExportingToDocument(object sender, GridViewElementExportingToDocumentEventArgs e)
    {
        if (e.Element == ExportElement.GroupHeaderCell)
        {
            var group = e.DataContext as QueryableCollectionViewGroup;
            string value = group.Key.ToString() + " (" + group.ItemCount + " items)" + new String(' ', 4);
            foreach (var result in group.AggregateResults)
            {
                value += result.Caption + " " + result.FormattedValue + new String(' ', 4);
            }

            e.Value = value;
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: Custom Group Header Cell Export Content__

{{region vb-gridview-export-group-header-cell-content-1}}
	Private Sub Grid_ElementExportingToDocument(ByVal sender As Object, ByVal e As GridViewElementExportingToDocumentEventArgs)
		If e.Element = ExportElement.GroupHeaderCell Then
			Dim group = TryCast(e.DataContext, QueryableCollectionViewGroup)
			Dim value As String = group.Key.ToString() & " (" & group.ItemCount & " items)" & New String(" "c, 4)
			For Each result In group.AggregateResults
				value &= result.Caption & " " & result.FormattedValue + New String(" "c, 4)
			Next result

			e.Value = value
		End If
	End Sub
{{endregion}}

{% figure 1, "Custom Group Header Cell Export Content", "format-groupheadercell-result.png" %}

## See Also

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})
 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
 * [Export Events]({%slug gridview-export-events%})
 * [ExportToXlsx]({%slug gridview-export-xlsx%})
 * [ExportToPdf]({%slug gridview-export-pdf%})
