---
title: Grid Export
page_title: Grid Export
description: Grid Export
slug: gridview-export
tags: grid,export
published: True
position: 0
---

# Grid Export


As of __Q1 2010__ (version number 2010.1.0309+), RadGridView has a new method - __Export__ which gives you more control over which elements are included in the exported data.

It is the preferred method of exporting data. The method expects two parameters:

1. __Stream__ - usually the file stream which you are exporting data to.

2. __GridViewExportOptions__ or __GridViewCsvExportOptions__ object - use it to set the following export options: 

* __Format__ - the possible formats are defined in the __ExportFormat__ enumeration: Csv, ExcelML, Html or Text

* __Encoding__ - the possible values are Encoding.Unicode, Encoding.UTF8, etc.

* __ShowColumnHeaders__ - determines whether to export the column headers

* __ShowColumnFooters__ - determines whether to export the column footers

* __ShowGroupFooters__ - determines whether to export the group footers

* __ColumnDelimiter__ - determines the string that will separate the cells of the exported data. Default is comma ",". __Available in GridViewCsvExportOptions only__.

* __RowDelimiter__ - determines the string that will separate the rows of the exported data. Default is new line. __Available in GridViewCsvExportOptions only__.

* __UseSystemCultureSeparator__ - if set, the RadGridView will use the system List Separator string, specified in Control Panel's Regional Options, to separate cells. This property overrides the __ColumnDelimiter__ property. __Available in GridViewCsvExportOptions only__.


>RadGridView's Export() method will not export an image, but its path. You can only export more user friendly text, but not the image itself.

The following example shows how to show a save file dialog asking the user to save the file in excel format:

#### __C#__

{{region gridview-export_0}}

	public MainPage()
	{
	 InitializeComponent();
	 btnExport.Click += new RoutedEventHandler(btnExport_Click); 
	}
	void btnExport_Click(object sender, RoutedEventArgs e)
	{
	 string extension = "xls";
	 SaveFileDialog dialog = new SaveFileDialog()
	 {
	  DefaultExt = extension,
	  Filter = String.Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"),
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
{{endregion}}

> As of __Q1 2015 RadGridView__ exposes two new methods: __ExportToXlsx__ and __ExportToPdf__, thus the  __Xlsx__ and __Pdf__ values from the __ExportFormat__ enum are obsolete.



#### __VB.NET__

{{region gridview-export_1}}

	Public Sub New()
	 InitializeComponent()
	 AddHandler btnExport.Click, AddressOf btnExport_Click
	End Sub
	Private Sub btnExport_Click(sender As Object, e As RoutedEventArgs)
	 Dim extension As String = "xls"
	 Dim dialog As New SaveFileDialog() With { _
	  .DefaultExt = extension, _
	  .Filter = [String].Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"), _
	  .FilterIndex = 1 _
	 }
	If dialog.ShowDialog() = True Then
	  Using stream As Stream = dialog.OpenFile()
	   gridViewExport.Export(stream, New GridViewExportOptions() With { _
	    .Format = ExportFormat.Html, _
	    .ShowColumnHeaders = True, _
	    .ShowColumnFooters = True, _
	    .ShowGroupFooters = False _
	   })
	  End Using
	 End If
	End Sub
{{endregion}}

>When opening an exported ".xls" file with Excel 2007 or later, you will get a warning message. The reason for it is that the RadGridView can export to HTML and ExcelML formats - in both cases not native for Excel 2007. In case of exporting to HTML format you will get such warning, however if you export to ExcelML format with XML extension you will not get it.
        

In addition,__RadGridView__ provides a built-in methods to get the content of your grid view control in different formats:

* __Text__ - each row is exported on new line (\r\n) with values separated by tabs (\t). In order to export to this format use the __ToText()__ method.

* __CSV__ - each row is exported on new line (\r\n) with values surrounded by quotation marks and separated by commas. In order to export to this format use the __ToCsv()__ method.

* __Html__ - the content of the __RadGridView__ is exported in standard Html table. In order to export to this format use the __ToHtml()__ method.

* __ExcelML__ - the content of the __RadGridView__ is exported to Excel XML format. In order to export to this format use the __ToExcelML()__ method.

>The export methods (__ToHtml()__, __ToCsv()__, __ToText()__ and __ToExcelML()__) are implemented in the class __ExportExtension__ as extension methods to the standard __RadGridView__ control. In order to see and call these methods you have to import the __Telerik.Windows.Controls__ namespace.

#### __C#__

{{region gridview-export_2}}

	using Telerik.Windows.Controls;
	...
	string htmlExport = this.ExportGrid.ToHtml(true);
{{endregion}}


#### __VB.NET__

{{region gridview-export_3}}

	Imports Telerik.Windows.Controls
	...
	Dim htmlExport As String = Me.ExportGrid.ToHtml(True)
{{endregion}}


## Exporting Events

As of __Q1 2010 SP2__, __RadGridView__ provides two new events which fire when you export data from RadGridView - __ElementExporting__ and __ElementExported__. 

__ElementExporting__ is a direct replacement of the __Exporting__ event which is used before Q1 2010 SP2. The __Exporting__ event was obsoleted with __Q2 2010__. You can use the events to format or modify the exported data.


As of __Q3 2013 GridViewElementExportingEventArgs__ exposes a new argument __VisualParameters__. The value of the property depends on the export format. Please note that it is only valid when exporting with 
[ExportFormat.ExcelML]({%slug gridview-export-excelml%}) and [ExportFormat.Html]({%slug gridview-export-html%}).
        
As of __Q3 2013__ RadGridView provides a new event __InitializingExcelMLStyles__ (when exporting with __ExportFormat.ExcelML__ only).

>The __InitializingExcelMLStyles__ method will be only raised when exporting with __ExportFormat.ExcelML__

As of __Q1 2015__ RadGridView provides two new events - __ElementExportingToDocument__ and __ElementExportedToDocument__ which fire when RadGridView is exported to Xlsx or Pdf.

Read more about these events [here]({%slug gridview-export-events%}).
        
# See Also

 * [Grid Async Export]({%slug gridview-export-async%})

 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})

 * [ExportFormat.Html]({%slug gridview-export-html%})
 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%})
 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})

 * [Export Events]({%slug gridview-export-events%})
 
 * [Online Demo - Exporting to various formats](http://demos.telerik.com/silverlight/#GridView/Exporting)
 
 * [Online Demo - Exporting Row Details](http://demos.telerik.com/silverlight/#GridView/ExportingRowDetails)
