---
title: CsvFormatProvider
page_title: CsvFormatProvider
description: CsvFormatProvider
slug: radspreadsheet-model-import-export-csvformatprovider-wpf
tags: csvformatprovider
publish: False
position: 4
site_name: WPF
---

# CsvFormatProvider



__RadSpreadsheet for WPF__ makes it easy to import and export csv files from both the user interface and code behind. Note
        that csv is a plain text format, meaning that it keeps only the contents of the worksheet without its formatting. Exporting a file to csv strips all styling
        and saves only cells text content. Moreover, it exports only the contents of the active worksheet – no support for exporting multiple worksheets into a csv
        at once is available.
      

By default exported values are delimited via the list separator specified by the current culture of the system. Note, however, that you can state explicitly
        the delimiter you would like to be used. This approach ensures that you will be able to open csv files exported with cultures different that the one on your
        machine.
      

When exporting the document model of __RadSpreadsheet__ escapes only the values that contain special symbols: double quote, delimiters
        and new line symbols. The process includes the following two steps:
      

1. If the value contains any double quotes, these are doubled. For example the value ab"cd turns into ab""cd.
          

1. After the value is processed as mentioned in step 1, the whole value is surrounded by double quotes, e.g. ab""cd is transformed to "ab""cd".
          

Note that even though the __CsvFormatProvider__ escapes only values containing special symbols, it reads correctly csv files in which
        all values have been escaped.
      

To import and export csv files, you need to use the __CsvFormatProvider__ class that appears in the
        Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv namespace. The __CsvFormatProvider__ implements the
        __IWorkbookFormatProvider__ interface which in turn is contained in the Telerik.Windows.Documents.Spreadsheet.FormatProviders namespace.
        That said, depenging on the whether you would like to work with the concrete class or the interface, you will need to include either the first to both
        namespaces.
      

## Import

The following snippet shows how to import a csv file using a FileStream. The code assures that a file with the specified name exists. Further, the sample 
          instantiates a __CsvFormatProvider__ and passes a FileStream to its __Import()__ method:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_0}}
	                string fileName = "FileName.csv";
	                if (!File.Exists(fileName))
	                {
	                    throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
	                }
	
	                Workbook workbook;
	                IWorkbookFormatProvider formatProvider = new CsvFormatProvider();
	
	                using (FileStream input = new FileStream(fileName, FileMode.Open))
	                {
	                    workbook = formatProvider.Import(input);
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_0}}
	            Dim fileName As String = "FileName.csv"
	            If Not File.Exists(fileName) Then
	                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	            End If
	
	            Dim workbook As Workbook
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	            Using input As New FileStream(fileName, FileMode.Open)
	                workbook = formatProvider.Import(input)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ExportCsv()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_1
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ImportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_3
	            Dim fileName As String = "FileName.csv"
	            If Not File.Exists(fileName) Then
	                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	            End If
	
	            Dim workbook As Workbook
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using input As New FileStream(fileName, FileMode.Open)
	                workbook = formatProvider.Import(input)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ExportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_4
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	    End Class
	
	
	End Class



## Export

The next example demonstrates how to export an existing Workbook to a csv file. The snippet creates a new workbook with a single worksheet. Further, it 
          creates a __CsvFormatProvider__ and invokes its __Export()__ method:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_1}}
	                Workbook workbook = new Workbook();
	                workbook.Worksheets.Add();
	
	                string fileName = "SampleFile.csv";
	                IWorkbookFormatProvider formatProvider = new CsvFormatProvider();
	
	                using (FileStream output = new FileStream(fileName, FileMode.Create))
	                {
	                    formatProvider.Export(workbook, output);
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_1}}
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ImportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_3
	            Dim fileName As String = "FileName.csv"
	            If Not File.Exists(fileName) Then
	                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	            End If
	
	            Dim workbook As Workbook
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using input As New FileStream(fileName, FileMode.Open)
	                workbook = formatProvider.Import(input)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ExportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_4
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	    End Class
	
	
	End Class



## Import and Export to CSV with Custom Delimiter

By default the __CsvFormatProvider__ class imports and exports files using the list separator specified by the current culture of the
          system. In certain cases, however, you may want to be able to set the delimiter manually. For example, if a csv file is saved with Spanish culture, the
          symbol used to separate values is semicolon (;). You will not be able to open this file on a machine with English culture, since the English list separator
          is a comma (,). The document model of __RadSpreadsheet__ offers an easy solution to the issue. The CsvFormatProvider
          class has a __Settings__ property of type __CsvSettings__ that allows you to explicitly specify the delimiter to
          be used while importing and exporting files. To set the property you need to create a class that inherits the __CsvFormatProvider__
          and overrides the __Settings__ property. The following snippet illustrates how this can be achieved:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_2}}
	
	        public class CustomCsvFormatProvider : CsvFormatProvider
	        {
	            public override CsvSettings Settings
	            {
	                get
	                {
	                    return new CsvSettings() { Delimiter = ';' };
	                }
	            }
	        }
	
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_2}}
	
	    Public Class CustomCsvFormatProvider
	        Inherits CsvFormatProvider
	        Public Overrides ReadOnly Property Settings() As CsvSettings
	            Get
	                Return New CsvSettings() With { _
	                    .Delimiter = ";"c _
	                }
	            End Get
	        End Property
	    End Class
	
	    '#End Region
	
	    Public Class WpfCsvFormatProvider
	        Private Sub ImportCsv()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_0
	            Dim fileName As String = "FileName.csv"
	            If Not File.Exists(fileName) Then
	                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	            End If
	
	            Dim workbook As Workbook
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	            Using input As New FileStream(fileName, FileMode.Open)
	                workbook = formatProvider.Import(input)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ExportCsv()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_1
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ImportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_3
	            Dim fileName As String = "FileName.csv"
	            If Not File.Exists(fileName) Then
	                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	            End If
	
	            Dim workbook As Workbook
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using input As New FileStream(fileName, FileMode.Open)
	                workbook = formatProvider.Import(input)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ExportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_4
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	    End Class
	
	
	End Class



Once you add the above class to your code, you can use the __CustomCsvFormatProvider__ instead of the CsvFormatProvider to import and
          export files. The following snippet uses the new class to ensure that the imported file will be opened with a semicolon delimiter:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_3}}
	                string fileName = "FileName.csv";
	                if (!File.Exists(fileName))
	                {
	                    throw new FileNotFoundException(String.Format("File {0} was not found!", fileName));
	                }
	
	                Workbook workbook;
	                IWorkbookFormatProvider formatProvider = new CustomCsvFormatProvider();
	
	                using (FileStream input = new FileStream(fileName, FileMode.Open))
	                {
	                    workbook = formatProvider.Import(input);
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_3}}
	            Dim fileName As String = "FileName.csv"
	            If Not File.Exists(fileName) Then
	                Throw New FileNotFoundException([String].Format("File {0} was not found!", fileName))
	            End If
	
	            Dim workbook As Workbook
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using input As New FileStream(fileName, FileMode.Open)
	                workbook = formatProvider.Import(input)
	            End Using
	            '#End Region
	        End Sub
	
	        Private Sub ExportCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-wpf_4
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	    End Class
	
	
	End Class



The next snippet uses the __CustomFormatProvider__ to export csv files with semicolon delimiter:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_4}}
	                Workbook workbook = new Workbook();
	                workbook.Worksheets.Add();
	
	                string fileName = "SampleFile.csv";
	                IWorkbookFormatProvider formatProvider = new CustomCsvFormatProvider();
	
	                using (FileStream output = new FileStream(fileName, FileMode.Create))
	                {
	                    formatProvider.Export(workbook, output);
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-wpf_4}}
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim fileName As String = "SampleFile.csv"
	            Dim formatProvider As IWorkbookFormatProvider = New CustomCsvFormatProvider()
	
	            Using output As New FileStream(fileName, FileMode.Create)
	                formatProvider.Export(workbook, output)
	            End Using
	            '#End Region
	        End Sub
	    End Class
	
	
	End Class



# See Also
