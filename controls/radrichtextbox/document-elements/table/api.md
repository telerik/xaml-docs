--- 
title: Properties and Methods
page_title: Properties and Methods
description: Properties and Methods
slug: radrichtextbox-features-api
tags: table, header, row, repeat
published: True
position: 5
---

### Properties

|__Property__|__Description__|
|---|---|
|__LayoutMode__|Gets or sets then table layout mode.|
|__PreferredWidth__|Gets or sets the preferred width of the table.|
|__FlowDirection__|Gets or sets the flow direction of the table contents.|
|__CellPadding__| Gets or sets the cell padding.|
|__Background__|Gets or sets the table background.|
|__TableIndent__|Gets or sets the table indent.|
|__CellSpacing__|Gets or sets the cell spacing.|

### Methods for adding or Inserting Rows

|__Method__|__Description__|
|---|---|
|__AddRow__|Adds copy of the last TableRow in the table.|
|__AddRowAbove(TableRow existingRow)__|Copies a specified TableRow and adds the copy above it.|
|__AddRowAtIndex__| Adds a TableRow at a specific index.|
|__AddRowBelow(TableRow existingRow)__|Copies a specified Telerik.Windows.Documents.Model.TableRow and adds the copy below it.|
|__DeleteRow(TableRow row)__| Deletes a TableRow|
 

### RadRichTextBox exposes the following methods that regard the creation or deletion of a table:

|__Method__|__Description__|
|---|---|
|__DeleteTable__|Deletes the currently selected table.|
|__DeleteTableColumn__|Deletes the currently selected column.|
|__DeleteTableRow__|Deletes the currently selected row.|
|__InsertTable__|Inserts a table. Allows you to specify the number of rows and columns. Has an overload that allows you to specify if a Paragraph should be inserted before the table.|
|__InsertTableColumn__|Inserts a column at the end of the table.|
|__InsertTableColumnToTheLeft__|Inserts a column to the left of the selected one.|
|__InsertTableColumnToTheRight__|Inserts a column to the right of the selected one.|
|__InsertTableRow__|Inserts a row at the end of the table.|
|__InsertTableRowAbove__|Inserts a row above the selected one.|
|__InsertTableRowBelow__|Inserts a row below the selected one.|
 
### Methods for Formatting Tables

|__Method__|__Description__|
|---|---|
|__ChangeTableBorders__|Modifies the borders of the currently selected table via a [__TableBorders__]{% if site.site_name == 'Silverlight' %}(https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.model.tableborders){%endif%}{% if site.site_name == 'WPF' %}(https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.tableborders){%endif%} object.|
|__ChangeTableCellBackground__|Sets the background color of the currently selected cell.|
|__ChangeTableCellBorders__|Modifies the borders of the currently selected table via a [__TableCellBorders__ ]{% if site.site_name == 'Silverlight' %}(https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.model.tablecellborders){%endif%}{% if site.site_name == 'WPF' %}(https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.tablecellborders){%endif%} or a [__Border__]{% if site.site_name == 'Silverlight' %}(https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.model.border){%endif%}{% if site.site_name == 'WPF' %}(https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.border){%endif%} object.|
|__ChangeTableCellSpacing__| Modifies the spacing between the cells.|
|__ChangeTableCellContentAlignment__|Modifies the horizontal and vertical content alignment of the currently selected cell.|
|__ChangeTableCellVerticalContentAlignment__|Modifies the vertical alignment of the currently selected cell.|
|__ChangeTableCellHorizontalContentAlignment__|Modifies the horizontal alignment of the currently selected cell.|
|__ChangeTableCellPadding__|Modifies the padding of the currently selected cell.|
|__ChangeTableDefaultCellPadding__|Modifies the default cell padding of the currently selected table.|
|__ChangeTableLayoutMode__|Modifies the layout mode of a table.|
|__ChangeTableHorizontalAlignment__|Modifies the horizontal alignment of the currently selected table.|
|__ChangeTableGridColumnWidth__|Modifies the width of the column with the specified zero-based index.|
|__ChangeTableRowHeight__|Changes the height of a table row.|
|__MergeTableCells__|Merges the currently selected cells.|
|__UnmergeTableCells__|Splits the currently selected table cell if it has been merged.|
 
>important In versions earlier than Q1 2015 before and after each Table element is inserted a Paragraph. When the Table is inserted via the UI or the InsertTable() method this is done automatically, otherwise paragraphs should be inserted manually. In next versions the Paragraph before the Table is not mandatory.
