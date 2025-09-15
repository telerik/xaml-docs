---
title: RadBusyindicator Freezes when exporting RadGridView to Excel File
description: Busy indicator not working while saving DataGrid to .xls or .xlsx format. Minimize this with ExportToWorkbook() method and BackgroundWorker.
page_title: RadBusyIndicator animation stops during exporting to file
type: troubleshooting
slug: kb-gridview-busyindicator-freezes-while-exporting-excel
position: 0
tags: xlsx, excel, exporttoworkbook, backgroundworker
ticketid: 1388486
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2017.3.1018</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadBusyIndicator for WPF</td>
	</tr>
</table>

## Description

RadBusyindicator freezes while RadGridView export is running.

## Solution

To minimize this, separate the creating of the document model from the saving of the file. Saving of the file can be executed on a separate thread. Also, use the ExportToWorkbook() method for creating the document model.


```C#
	private BackgroundWorker backgroundWorker;
	private Stream documentStream;

	private void ExportToXlsX(RadGridView gridView)
	{
		SaveFileDialog dialog = new SaveFileDialog()
		{
			DefaultExt = "xlsx",
			Filter = String.Format("Workbooks (*.{0})|*.{0}|All files (*.*)|*.*", "xlsx"),
			FilterIndex = 1
		};
		
		if (dialog.ShowDialog() == true)
		{
			var document = gridView.ExportToWorkbook(new GridViewDocumentExportOptions()
			{
				ShowColumnFooters = true,
				ShowColumnHeaders = true,
				ShowGroupFooters = true
			});                                
			this.documentStream = dialog.OpenFile();
			
			var backgroundWorker = new BackgroundWorker();		
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			
			this.radBusyIndicator.IsBusy = true;
			backgroundWorker.RunWorkerAsync(document);
		}
	}

	private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		var formatProvider = new XlsxFormatProvider();
		formatProvider.Export((Workbook)e.Argument, this.documentStream);
		
		this.documentStream.Close();
		
		App.Current.Dispatcher.BeginInvoke(new Action(() => 
		{
			this.radBusyIndicator.IsBusy = false;
		}));
	}
```

## See Also  
* [Export Overview]({%slug gridview-export-overview%})
* [ExportToWorkbook]({%slug gridview-export-workbook%})
* [RadBusyIndicator]({%slug radbusyindicator-overview%})
