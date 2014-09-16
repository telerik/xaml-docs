---
title: TxtFormatProvider
page_title: TxtFormatProvider
description: TxtFormatProvider
slug: radspreadsheet-model-import-export-txtformatprovider-wpf
tags: txtformatprovider
published: False
position: 6
site_name: WPF
---

# TxtFormatProvider



__RadSpreadsheet for WPF__ makes it easy to import and export txt files both from user interface and code behind. Note that txt is a plain
        text format and holds only the contents of the worksheet without its formatting. Exporting a file to txt strips all styling and saves only cells text content
        using tab as a delimiter. Moreover, it exports only the contents of the active worksheet – no support for exporting multiple worksheets into a txt at once is
        available. Importing from txt respectively creates a new workbook with a single worksheet named *Sheet1*.
      

In order to import and export txt files you need an instance of __TxtFormatProvider__, which is contained in the
        Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt namespace. The __TxtFormatProvider__ implements the interface
        __IWorkbookFormatProvider__ that appears in the Telerik.Windows.Documents.Spreadsheet.FormatProviders namespace. That said, depending on
        whether you would like to work with the concrete class or the interface, you will need to include either the first or both namespaces.
      

## Import

The following snippet shows how to import a txt file using a FileStream. The code assures that a file with the specified name exists. Further, the sample 
          instantiates a __TxtFormatProvider__ and passes a FileStream to its __Import()__ method:
        

#### __C#__

{{region radspreadsheet-model-import-export-txtformatprovider-wpf_0}}
	            string fileName = "SampleFile.txt";
	            if (!File.Exists(fileName))
	            {
	                throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
	            }
	
	            Workbook workbook;
	            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();
	
	            using (FileStream input = new FileStream(fileName, FileMode.Open))
	            {
	                workbook = formatProvider.Import(input);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-txtformatprovider-wpf_0}}
	        Dim fileName As String = "SampleFile.txt"
	        If Not File.Exists(fileName) Then
	            Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	        End If
	
	        Dim workbook As Workbook
	        Dim formatProvider As IWorkbookFormatProvider = New TxtFormatProvider()
	
	        Using input As New FileStream(fileName, FileMode.Open)
	            workbook = formatProvider.Import(input)
	        End Using
	        '#End Region
	    End Sub
	
	    Private Sub ExportTxt()
	        '#Region radspreadsheet-model-import-export-txtformatprovider-wpf_1
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim fileName As String = "SampleFile.txt"
	        Dim formatProvider As IWorkbookFormatProvider = New TxtFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class



## Export

The next example demonstrates how to export an existing Workbook to a txt file. The snippet creates a new workbook with a single worksheet. Further, it 
          creates a __TxtFormatProvider__ and invokes its __Export()__ method:
        

#### __C#__

{{region radspreadsheet-model-import-export-txtformatprovider-wpf_1}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            string fileName = "SampleFile.txt";
	            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();
	
	            using (FileStream output = new FileStream(fileName, FileMode.Create))
	            {
	                formatProvider.Export(workbook, output);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-txtformatprovider-wpf_1}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim fileName As String = "SampleFile.txt"
	        Dim formatProvider As IWorkbookFormatProvider = New TxtFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class



# See Also
