---
title: Export with SpreadsheetStreamingExport
page_title: Export with SpreadsheetStreamingExport
description: Export FAQ
slug: gridview-export-spreadsheetstreamingexport
tags: export,spreadsheetstreamingexport
published: True
position: 9
---

# Export with SpreadsheetStreamingExport

The __GridViewSpreadStreamExport__ uses the [RadSpreadStreamProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/overview) library which allows you to create big documents (without loading the entire document in the memory) and export them to the most common formats. 
* [Assembly References](#assembly-references)
* [Exporting](#exporting)
* [Asynchronous Export](#asynchronous-export)
* [Events](#events)

## Assembly References

The __Export with SpreadsheetStreamingExport__ functionality uses additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.Spreadsheet.dll 
* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll
* Telerik.Windows.Zip.dll
* Telerik.Windows.Controls.GridView.Export.dll
* Telerik.Windows.Controls.GridView.SpreadSheetStreamingExport.dll

>  __Telerik.Windows.Controls.GridView.SpreadSheetStreamingExport.dll__ is a new binary introduced in __R1 2019__. 

## Exporting

In order to export RadGridView, an instance of the __GridViewSpreadStreamExport__ has to be defined. The instance of the __RadGridView__ object that needs to be exported has to be passed as a parameter. Then, calling the __RunExport__ method will trigger the export mechanism. It accepts the name of the file that is to be exported and a __SpreadStreamExportRenderer__ instance.

#### __[C#] Example 1: Exporting RadGridView with GridViewSpreadStreamExport__
{{region gridview-export-spreadsheetstreamingexport_0}}
	GridViewSpreadStreamExport spreadStreamExport = new GridViewSpreadStreamExport(this.clubsGrid);
	spreadStreamExport.RunExport(dialog.FileName.ToString(), new SpreadStreamExportRenderer());
{{endregion}}

When the exporting operation is completed, the __ExportCompleted__ event of __GridViewSpreadStreamExport__ is raised.

## Asynchronous Export

Exporting __RadGridView__ asynchronously can be achieved by utilizing the __RunExportAsync__ method of __GridViewSpreadStreamExport__. 

#### __[C#] Example 2: Exporting RadGridView Asynchronously__
{{region gridview-export-spreadsheetstreamingexport_1}}
	GridViewSpreadStreamExport spreadStreamExport = new GridViewSpreadStreamExport(this.clubsGrid);
	spreadStreamExport.RunExportAsync(dialog.FileName.ToString(), new SpreadStreamExportRenderer());
{{endregion}}

When the progress of the asynchronous export changes, the __AsyncExportProgressChanged__ event of __GridViewSpreadStreamExport__ is triggered. Finally, when the export operation is over, the __AsyncExportCompleted__ event is raised.

## Events

Apart from the previously discussed __ExportCompleted__, __AsyncExportProgressChanged__ and __AsyncExportCompleted__ events, __GridViewSpreadStreamExport__ exposes a couple of other events that provide different options for manipulating the exported data.

### CellFormatting

This event occurs for every cell that is being exported. It can be used for styling the cells or applying custom format to the cells values.

#### __[C#] Example 3: Handling the CellFormatting event__
{{region gridview-export-spreadsheetstreamingexport_2}}
	 private void SpreadStreamExport_CellFormatting(object sender, SpreadStreamCellFormattingEventArgs e)
		{
			e.CellStyleInfo.Background = Colors.Blue;
			e.CellStyleInfo.Foreground = Colors.OrangeRed;
			e.CellStyleInfo.FontSize = 11;
			e.CellStyleInfo.FontFamily = new FontFamily("Comic Sans MS");
		}
{{endregion}}

### RowCreated

Occurs when a new row is created in current worksheet. This is suitable place to set any row properties (like height) and/or add indent cells.

#### __[C#] Example 3: Handling the RowCreated event__
{{region gridview-export-spreadsheetstreamingexport_3}}
	 private void SpreadStreamExport_RowCreated(object sender, SpreadStreamRowEventArgs e)
        {
            var row = e.Row as Telerik.Documents.SpreadsheetStreaming.IRowExporter;
            row.SetHeightInPixels(30);
        }
{{endregion}}

### RowExporting

Occurs before every spread row is exported. This is suitable place to add any additional cells at the end of the row.

#### __[C#] Example 4: Handling the RowExporting event__
{{region gridview-export-spreadsheetstreamingexport_4}}
	if (e.GridRowIndex % 2 == 0)
            {
                var row = e.Row as IRowExporter;
                using (ICellExporter cell = row.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat()
                    {
                        Fill = SpreadPatternFill.CreateSolidFill(new SpreadColor(100, 100, 100))
                    };
                    cell.SetValue("---");
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;
                    format.LeftBorder = new SpreadBorder(SpreadBorderStyle.Double, SpreadThemableColor.FromRgb(100, 100, 100));
                    format.RightBorder = new SpreadBorder(SpreadBorderStyle.Double, SpreadThemableColor.FromRgb(100, 100, 100));
                    cell.SetFormat(format);
                }
            }
{{endregion}}

## See Also

 * [Grid Export]({#slug gridview-export})
 * [Grid Async Export]({%slug gridview-export-async%})
 * [ExportFormat.ExcelML]({%slug gridview-export-excelml%})
 * [ExportFormat.Html]({%slug gridview-export-html%}) 
 * [ExportFormat.Xlsx]({%slug gridview-export-xlsx%}) 
 * [ExportFormat.Pdf]({%slug gridview-export-pdf%})
