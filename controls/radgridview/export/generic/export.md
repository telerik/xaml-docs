---
title: Export
page_title: Export
description: Learn how to export data from Telerik's {{ site.framework_name }} DataGrid by using the Export method gives you control over which elements are included in the exported data.
slug: gridview-export
tags: grid,export
published: True
position: 1
---

# Export

If you need to export RadGridView`s content, its __Export__ method comes to help. It was introduced in __Q1 2010__ and it is the preferred method of exporting data. Furthermore, it gives you control over which elements are included in the exported data.

The method expects two parameters:

1. __Stream__ - usually the file stream which you are exporting data to.

2. __GridViewExportOptions__ or __GridViewCsvExportOptions__ - used to set the following export options: 

* __Format__ - the possible formats are defined in the __ExportFormat__ enumeration: Csv, ExcelML, Html or Text

* __Encoding__ - the possible values are Encoding.Unicode, Encoding.UTF8, etc.

* __ShowColumnHeaders__ - determines whether to export the column headers

* __ShowColumnFooters__ - determines whether to export the column footers

* __ShowGroupFooters__ - determines whether to export the group footers

* __ColumnDelimiter__ - determines the string that will separate the cells of the exported data. Default is comma ",". __Available in GridViewCsvExportOptions only__.

* __RowDelimiter__ - determines the string that will separate the rows of the exported data. Default is new line. __Available in GridViewCsvExportOptions only__.

* __UseSystemCultureSeparator__ - if set, the RadGridView will use the system List Separator string, specified in Control Panel's Regional Options, to separate cells. This property overrides the __ColumnDelimiter__ property. __Available in GridViewCsvExportOptions only__.


__Example 1__ shows how to display a "Save File" dialog asking the user to save the file in excel format:

__Example 1: Save RadGridView`s content in Excel file__

```C#
	void btnExport_Click(object sender, RoutedEventArgs e)
	{
	    string extension = "xls";
	    SaveFileDialog dialog = new SaveFileDialog()
	    {
	        DefaultExt = extension,
	        Filter = String.Format("{1} files (\*.{0})|\*.{0}|All files (*.*)|*.*", extension, "Excel"),
	        FilterIndex = 1
	    };
	    if (dialog.ShowDialog() == true)
	    {
	        using (Stream stream = dialog.OpenFile())
	        {
	            gridViewExport.Export(stream,
	             new GridViewExportOptions()
	             {
	                 Format = ExportFormat.Html,
	                 ShowColumnHeaders = true,
	                 ShowColumnFooters = true,
	                 ShowGroupFooters = false,
	             });
	        }
	    }
	}
```
```VB.NET
	Private Sub btnExport_Click(sender As Object, e As RoutedEventArgs)
	    Dim extension As String = "xls"
	    Dim dialog As New SaveFileDialog() With {
	     .DefaultExt = extension,
	     .Filter = String.Format("{1} files (\*.{0})|\*.{0}|All files (*.*)|*.*", extension, "Excel"),
	     .FilterIndex = 1
	    }
	    If dialog.ShowDialog() = True Then
	        Using stream As Stream = dialog.OpenFile()
	            gridViewExport.Export(stream, New GridViewExportOptions() With {
	             .Format = ExportFormat.Html,
	             .ShowColumnHeaders = True,
	             .ShowColumnFooters = True,
	             .ShowGroupFooters = False
	            })
	        End Using
	    End If
	End Sub
```
        
In addition, __RadGridView__ provides built-in methods to get the content of your GridView control in different formats:

* __Text__ - each row is exported on new line (\r\n) with values separated by tabs (\t). In order to export to this format use the __ToText()__ method.

* __CSV__ - each row is exported on new line (\r\n) with values surrounded by quotation marks and separated by commas. In order to export to this format use the __ToCsv()__ method.

* __Html__ - the content of the __RadGridView__ is exported in standard Html table. In order to export to this format use the __ToHtml()__ method.

* __ExcelML__ - the content of the __RadGridView__ is exported to Excel XML format. In order to export to this format use the __ToExcelML()__ method.

>The export methods (__ToHtml()__, __ToCsv()__, __ToText()__ and __ToExcelML()__) are implemented in the class __ExportExtension__ as extension methods to the standard __RadGridView__ control. In order to use these methods you have to import the __Telerik.Windows.Controls__ namespace.


__Example 2: Save content to String__

```C#
	string htmlExport = this.gridViewExport.ToHtml(true);
```
```VB.NET
	Dim htmlExport As String = Me.gridViewExport.ToHtml(True)
```

        
## See Also

* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToPdf]({%slug gridview-export-pdf%})
