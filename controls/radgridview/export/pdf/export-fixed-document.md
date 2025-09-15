---
title: ExportToRadFixedDocument
page_title: ExportToRadFixedDocument
description: Read about the ExportToRadFixedDocument functionality of Telerik's {{ site.framework_name }} DataGrid used to modify the content of the exported grid without any manual styling.
slug: gridview-export-fixed-document
tags: gridview,export,fixed,document
published: True
position: 2
---

# ExportToRadFixedDocument

In __R1 2016__, we introduced a new extension method related to the exporting of RadGridView - **ExportToRadFixedDocument**. You can use it if you need to modify the content of the exported RadGridView and avoid styling the document manually.

## Assembly References

**ExportToRadFixedDocument** uses additional libraries so you need to add references to the following assemblies:

* Telerik.Windows.Controls.GridView.Export.dll
* Telerik.Windows.Documents.Core.dll
* Telerik.Windows.Documents.Spreadsheet.dll 
* Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.dll

## Usage

This method exports the associated RadGridView to a [RadFixedDocument](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/model/radfixeddocument) object. **Example 1** shows how you can rotate the exported page before exporting.

__Example 1: Export RadGridView to a RadFixedDocument and rotate the page 90 degrees__
```C#
	private void Button_Click(object sender, RoutedEventArgs e)
        {	
			//Instantiate the RadFixedDocument object
            RadFixedDocument fixedDoc = this.clubsGrid.ExportToRadFixedDocument();
			
			//Modify the RadFixedDocument object
            foreach (var page in fixedDoc.Pages)
            {
                var actualPage = page as RadFixedPage;
                actualPage.Rotation =  Telerik.Windows.Documents.Fixed.Model.Data.Rotation.Rotate90;
            }

			//Export the RadFixedDocument to a PDF file
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "*.pdf";
          
            if (dialog.ShowDialog() == true)
            {

                var provider = new PdfFormatProvider();
                using (var output = dialog.OpenFile())
                {
                    provider.Export(fixedDoc, output, null);
                }
            }
        }
```

## GridViewDocumentExportOptions

The method can be overloaded and take __GridViewDocumentExportOptions__ as a parameter. You can use it to set the following export options:

* Culture
* Items
* ShowColumnFooters
* ShowGroupFooters
* ShowColumnHeaders
* ExportDefaultStyles  

>important The **ExportToRadFixedDocument** method utilizes the **PdfProcessing library**. You can check the respective [documentation](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/overview) for more information on how to use the library.

## See Also

* [SpreadsheetStreamingExport]({%slug gridview-export-spreadsheetstreamingexport%})
* [ExportToXlsx]({%slug gridview-export-xlsx%})
* [ExportToPdf]({%slug gridview-export-pdf%})
