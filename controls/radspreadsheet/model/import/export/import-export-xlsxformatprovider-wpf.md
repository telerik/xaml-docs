---
title: XlsxFormatProvider
page_title: XlsxFormatProvider
description: XlsxFormatProvider
slug: radspreadsheet-model-import-export-xlsxformatprovider-wpf
tags: xlsxformatprovider
publish: False
position: 2
site_name: WPF
---

# XlsxFormatProvider



__RadSpreadsheet for WPF__ makes it easy to import and export xlsx files both from user interface and code behind. An xlsx file is a 
        group of zipped files that conform to the Office Open XML schema. That said, the format allows you export all parts of a workbook: worksheets, formula values, 
        formatting, hyperlinks, etc.
      

>Unlike the csv and txt format providers, the __XlsxFormatProvider__ requires references to the following assemblies:
        

* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll
            

* Telerik.Windows.Zip.dll
            

Once you reference the aforementioned assemblies, you need to create an instance of the __XlsxFormatProvider__ in order to import and
        export xlsx files. This provider appears in the Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx namespace. The
        __XlsxFormatProvider__ implements the __IWorkbookFormatProvider__ interface, which in turn appears in the
        Telerik.Windows.Documents.Spreadsheet.FormatProviders. That said, depending on the whether you would like to work with the concrete class or the interface,
        you will need to include either the first to both namespaces.
      

## Import

The following snippet shows how to import a xlsx file using a FileStream. The code assures that a file with the specified name exists. Further, the sample
          instantiates a __XlsxFormatProvider__ and passes a FileStream to its __Import()__ method:
        

#### __C#__

{{region radspreadsheet-model-import-export-xlsxformatprovider-wpf_0}}
	            string fileName = "SampleFile.xlsx";
	            if (!File.Exists(fileName))
	            {
	                throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
	            }
	
	            Workbook workbook;
	            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();
	
	            using (FileStream input = new FileStream(fileName, FileMode.Open))
	            {
	                workbook = formatProvider.Import(input);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-xlsxformatprovider-wpf_0}}
	        Dim fileName As String = "SampleFile.xlsx"
	        If Not File.Exists(fileName) Then
	            Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	        End If
	
	        Dim workbook As Workbook
	        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
	
	        Using input As New FileStream(fileName, FileMode.Open)
	            workbook = formatProvider.Import(input)
	        End Using
	        '#End Region
	    End Sub
	
	    Private Sub ExportXlsx()
	        '#Region radspreadsheet-model-import-export-xlsxformatprovider-wpf_1
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	        Dim fileName As String = "SampleFile.xlsx"
	
	        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class



## Export

The next example demonstrates how to export an existing Workbook to a xlsx file. The snippet creates a new workbook with a single worksheet. Further, it
          creates a __XlsxFormatProvider__ and invokes its __Export()__ method:
        

#### __C#__

{{region radspreadsheet-model-import-export-xlsxformatprovider-wpf_1}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	            string fileName = "SampleFile.xlsx";
	
	            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();
	
	            using (FileStream output = new FileStream(fileName, FileMode.Create))
	            {
	                formatProvider.Export(workbook, output);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-xlsxformatprovider-wpf_1}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	        Dim fileName As String = "SampleFile.xlsx"
	
	        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class



# See Also
