---
title: Execute saving the exported Excel document on a separate thread in GridView
description: How to execute the Excel export on a separate thread in order to make the application more responsive.
type: how-to
page_title: Move the exporting to a file execution of an Excel data to new thread in RadGridView
slug: kb-gridview-separate-excel-export-execution
position: 0
tags: performance,export,excel,speed
ticketid: 1575027
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to execute the Excel export on a separate thread in order to make the application more responsive.

## Solution 1

The RadGridView export is executed on the UI thread. This is required because of the single thread nature of WPF. The export access objects that are part of the framework and this should happen on the UI thread.

The export itself consists of two actions - preparing the document model and saving it into a stream (usually a file stream). The action that saves the file to a stream can be moved to a separate thread once the document model is ready. This is useful if you export big amount of data which hangs the UI. With this approach the time needed for the saving of the file can be spent on another thread instead of taking time from the UI thread. 

To do this, you can use the [ExportToWorkbook]({%slug gridview-export-workbook%}) method to prepare the document model. This will return a [Workbook](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/working-with-workbooks/working-with-workbooks-what-is-workbook). The `Workbook` can be send to another thread which can [save it to a file](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/formats-and-conversion/import-and-export-to-excel-file-formats/xls/xlsformatprovider).


```C#
	private BackgroundWorker worker;
	private Workbook documentToExport;
	private XlsxFormatProvider provider = new XlsxFormatProvider();

	private void InitializeExportWorker()
	{
		worker = new BackgroundWorker();
		worker.DoWork += Worker_DoWork;
		worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
	}

	private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		// report export completed if needed
		this.documentToExport = null;
	}

	private void Worker_DoWork(object sender, DoWorkEventArgs e)
	{   
		using (var output = File.Open("sampleDocument.xlsx", FileMode.OpenOrCreate))
		{
			provider.Export(this.documentToExport, output);
		}
	}

	public MainWindow()
	{
		InitializeExportWorker();
		InitializeComponent(); 		
	}

	private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		this.documentToExport = this.gridView.ExportToWorkbook();
		this.worker.RunWorkerAsync();
	}
```

## Solution 2

To speed up the performance you can use also the SpreadStreaming export feature of RadGridView. Read more in the [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%}) article.