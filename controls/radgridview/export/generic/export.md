---
title: Export
page_title: Export
description: Learn how to export RadGridView data to ExcelML, HTML, CSV, or plain text with the Export method and configure the exported elements.
components: ["gridview"]
slug: gridview-export
tags: grid,export
published: True
position: 1
---

# Export

The `Export` method exports `RadGridView` data in Progress® Telerik® UI for WPF to ExcelML, HTML, comma-separated values (CSV), or plain text. Use its export options to control which elements to include.

For XLSX files, use [Exporting to XLSX with `ExportToXlsx`]({%slug gridview-export-xlsx%}) instead. For large datasets, use the recommended [Streaming export with `GridViewSpreadStreamExport`]({%slug gridview-export-spreadsheetstreamingexport%}) approach.

The `Export` method expects two parameters:

* `Stream`&mdash;The destination stream, usually a file stream.

* `GridViewExportOptions` or `GridViewCsvExportOptions`&mdash;The export options.

Configure the export with these options:

* `Format`&mdash;Sets the format through the `ExportFormat` enumeration: `Csv`, `ExcelML`, `Html`, or `Text`.

* `Encoding`&mdash;Sets the character encoding, such as `Encoding.Unicode` or `Encoding.UTF8`.

* `ShowColumnHeaders`&mdash;Determines whether to export the column headers.

* `ShowColumnFooters`&mdash;Determines whether to export the column footers.

* `ShowGroupFooters`&mdash;Determines whether to export the group footers.

* `ColumnDelimiter`&mdash;Sets the string that separates cells. The default is a comma (`","`). Available only in `GridViewCsvExportOptions` for CSV export.

* `RowDelimiter`&mdash;Sets the string that separates rows. The default is a newline. Available only in `GridViewCsvExportOptions` for CSV export.

* `UseSystemCultureSeparator`&mdash;Uses the system **List Separator** setting in **Control Panel** regional options to separate cells when enabled. This property overrides `ColumnDelimiter`. Available only in `GridViewCsvExportOptions` for CSV export.

The legacy `Export` formats do not produce XLSX files. ExcelML is an XML format, not HTML or XLSX.

>important Match the filename extension to the selected export format. Renaming HTML or ExcelML output to `.xls` or `.xlsx` does not convert it to that format. A mismatch can trigger an Excel warning.

Example 1 illustrates a save-file dialog for exported content:

**Example 1: Saving RadGridView content to a file**

<snippet id='radgridview-export-generic-export-example_1_save_radgridview_s_content_in_excel_file-cs' />

<snippet id='radgridview-export-generic-export-example_1_save_radgridview_s_content_in_excel_file-vb' />

`RadGridView` also provides extension methods that return the exported content as a string:

* Plain text&mdash;`ToText()` exports each row on a new line (`\r\n`) with values separated by tabs (`\t`).

* CSV&mdash;`ToCsv()` exports each row on a new line (`\r\n`) with values surrounded by quotation marks and separated by commas.

* HTML&mdash;`ToHtml()` exports the content as a standard HTML table.

* ExcelML&mdash;`ToExcelML()` exports the content in Excel XML format.

>note The `ExportExtension` class implements `ToHtml()`, `ToCsv()`, `ToText()`, and `ToExcelML()` as extension methods for `RadGridView`. Import the `Telerik.Windows.Controls` namespace to use these methods.

Example 2 illustrates export to a string:

**Example 2: Saving content to a string**

<snippet id='radgridview-export-generic-export-example_2_save_content_to_string-cs' />

<snippet id='radgridview-export-generic-export-example_2_save_content_to_string-vb' />

## See Also

* [Streaming export with `GridViewSpreadStreamExport`]({%slug gridview-export-spreadsheetstreamingexport%})
* [Exporting to XLSX with `ExportToXlsx`]({%slug gridview-export-xlsx%})
* [Exporting to PDF with `ExportToPdf`]({%slug gridview-export-pdf%})
