---
title: Format Group Header Cell Content
page_title: Format Group Header Cell Content
description: Read this article to learn how to format group header cell content within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-export-group-header-cell-content
tags: export, group, header, cell, content
published: True
position: 8
---

# Format Group Header Cell Content

By handling the [ElementExportingToDocument]({%slug gridview-export-events%}) of the RadGridView control, you can specify a custom format for the exported group header cells. For example, you can export the captions of the aggregate results with their formatted value (based on the [ResultFormatString]({%slug gridview-columns-aggregate-functions%}#resultformatstring) of the function) as well as the number of items in the group.

__Example 1: Custom Group Header Cell Export Content__

<snippet id='radgridview-export-how-to-export-group-header-cell-content-example_1_custom_group_header_cell_export_content-cs' />

<snippet id='radgridview-export-how-to-export-group-header-cell-content-example_1_custom_group_header_cell_export_content-vb' />


__Custom Group Header Cell Export Content__

![Telerik UI for WPF RadGridView export showing custom group header cell content with aggregates](images/format-groupheadercell-result.png)

## See Also

 * [Group Aggregates]({%slug gridview-grouping-aggregates%})
 * [Aggregate Functions]({%slug gridview-columns-aggregate-functions%})
 * [Export Events]({%slug gridview-export-events%})
 * [ExportToXlsx]({%slug gridview-export-xlsx%})
 * [ExportToPdf]({%slug gridview-export-pdf%})
