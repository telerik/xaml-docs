---
title: CsvFormatProvider
page_title: CsvFormatProvider
description: CsvFormatProvider
slug: radspreadsheet-model-import-export-csvformatprovider-silverlight
tags: csvformatprovider
publish: False
position: 3
site_name: Silverlight
---

# CsvFormatProvider



__RadSpreadsheet for Silverlight__ makes it easy to import and export csv files from both the user interface and code behind. Bear in
        mind though that for security purposes Silverlight requires every action that involves accessing files on the client machine to be (1) initialized by the user
        and (2) performed through the file dialogs. To open a file through the UI you can use
        [OpenFileDialog](http://msdn.microsoft.com/en-us/library/system.windows.controls.openfiledialog(v=vs.95).aspx)
        and to save it –
        [SaveFileDialog](http://msdn.microsoft.com/en-us/library/system.windows.controls.savefiledialog(v=vs.95).aspx).
      

Note that csv is a plain text format,meaning that it keeps only the contents of the worksheet without its formatting. Exporting a file to csv strips all styling and saves
        only cell's text content using tab as a delimiter. Moreover, it exports only the contents of the active worksheet – no support for exporting multiple
        worksheets into a csv at once is available.
      

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
        That said, depending on the whether you would like to work with the concrete class or the interface, you will need to include either the first to both
        namespaces.
      

## Import

This section demonstrates how to import a file that resides on a web server and how to open a csv file through the OpenFileDialog.
        

The following snippet shows how to import a csv file that is located on a web server. To read the file from the server, the sample instantiates a
          [WebClient](http://msdn.microsoft.com/en-us/library/system.net.webclient(v=vs.95).aspx).
          Further, it subscribes to the OpenReadCompleted event of the *webclient*, which is triggered once the OpenReadAsync() method
          completes. Note that the example does not use any UI, which may cause a Security Exception if you try change the resource string to point to some external
          web resource.
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_0}}
	            public void ImportWorkbookFromCsv(string fileName)
	            {
	                string filePath = string.Format(@"http://localhost:54352/Files/{0}", fileName);
	                WebClient webClient = new WebClient();
	
	                webClient.OpenReadCompleted += webClient_OpenReadCompleted;
	                webClient.OpenReadAsync(new Uri(filePath));
	            }
	
	            private void webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
	            {
	                CsvFormatProvider formatProvider = new CsvFormatProvider();
	                Workbook workbook = formatProvider.Import(e.Result);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_0}}
	        Public Sub ImportWorkbookFromCsv(fileName As String)
	            Dim filePath As String = String.Format("http://localhost:54352/Files/{0}", fileName)
	            Dim webClient As New WebClient()
	
	            AddHandler webClient.OpenReadCompleted, AddressOf webClient_OpenReadCompleted
	            webClient.OpenReadAsync(New Uri(filePath))
	        End Sub
	
	        Private Sub webClient_OpenReadCompleted(sender As Object, e As OpenReadCompletedEventArgs)
	            Dim formatProvider As New CsvFormatProvider()
	            Dim workbook As Workbook = formatProvider.Import(e.Result)
	        End Sub
	        '#End Region
	
	        Private Sub ImportWorkbookFromCsvUsingOpenFileDialog()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_1
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsv()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_2
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Private Sub ImportWorkbookFromCsvUsingOpenFileDialogCuctomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_4
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	    End Class



The next example shows how to import a csv file that resides on the client machine. As already mentioned accessing files in Silverlight requires the usage 
          of user-initiated dialogs for security purposes. That said, to open a file that is on the client, you should use an OpenFileDialog instance and retrieve a 
          stream to the file. Once you have the stream you can import it as a Workbook.
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_1}}
	                Workbook workbook;
	
	                OpenFileDialog openFileDialog = new OpenFileDialog();
	                IWorkbookFormatProvider formatProvider = new CsvFormatProvider();
	                openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";
	
	                if (openFileDialog.ShowDialog() == true)
	                {
	                    using (Stream input = openFileDialog.File.OpenRead())
	                    {
	                        workbook = formatProvider.Import(input);
	                    }
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_1}}
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsv()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_2
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Private Sub ImportWorkbookFromCsvUsingOpenFileDialogCuctomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_4
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	    End Class



## Export

As already mentioned for security purposes accessing files in Silverlight can be achieved only through user-initiated dialogs. That said, to save 
          workbook's contents into a csv file, you need to use the SaveFileDialog. The following example passes the stream returned by the dialog and the 
          current workbook to the __Export()__ method of the __CsvFormatProvider__:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_2}}
	                Workbook workbook = new Workbook();
	                workbook.Worksheets.Add();
	
	                SaveFileDialog saveFileDialog = new SaveFileDialog();
	                CsvFormatProvider formatProvider = new CsvFormatProvider();
	                saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";
	
	                if (saveFileDialog.ShowDialog() == true)
	                {
	                    using (Stream output = saveFileDialog.OpenFile())
	                    {
	                        formatProvider.Export(workbook, output);
	                    }
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_2}}
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Private Sub ImportWorkbookFromCsvUsingOpenFileDialogCuctomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_4
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
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

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_3}}
	
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

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_3}}
	
	    Public Class CustomCsvFormatProvider
	        Inherits CsvFormatProvider
	        Public Overrides ReadOnly Property Settings() As CsvSettings
	            Get
	                Return New CsvSettings() With {.Delimiter = ";"c}
	            End Get
	        End Property
	    End Class
	
	    '#End Region
	
	    Public Class SilverlightCsvFormatProvider
	        '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_0
	        Public Sub ImportWorkbookFromCsv(fileName As String)
	            Dim filePath As String = String.Format("http://localhost:54352/Files/{0}", fileName)
	            Dim webClient As New WebClient()
	
	            AddHandler webClient.OpenReadCompleted, AddressOf webClient_OpenReadCompleted
	            webClient.OpenReadAsync(New Uri(filePath))
	        End Sub
	
	        Private Sub webClient_OpenReadCompleted(sender As Object, e As OpenReadCompletedEventArgs)
	            Dim formatProvider As New CsvFormatProvider()
	            Dim workbook As Workbook = formatProvider.Import(e.Result)
	        End Sub
	        '#End Region
	
	        Private Sub ImportWorkbookFromCsvUsingOpenFileDialog()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_1
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsv()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_2
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Private Sub ImportWorkbookFromCsvUsingOpenFileDialogCuctomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_4
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	    End Class



Once you add the above class to your code, you can use the __CustomCsvFormatProvider__ instead of the CsvFormatProvider to import and 
          export files. The following snippet uses the new class to ensure that the imported file will be opened with a semicolon delimiter:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_4}}
	                Workbook workbook;
	
	                OpenFileDialog openFileDialog = new OpenFileDialog();
	                CustomCsvFormatProvider formatProvider = new CustomCsvFormatProvider();
	                openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";
	
	                if (openFileDialog.ShowDialog() == true)
	                {
	                    using (Stream input = openFileDialog.File.OpenRead())
	                    {
	                        workbook = formatProvider.Import(input);
	                    }
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_4}}
	            Dim workbook As Workbook
	
	            Dim openFileDialog As New OpenFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            openFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If openFileDialog.ShowDialog() = True Then
	                Using input As Stream = openFileDialog.File.OpenRead()
	                    workbook = formatProvider.Import(input)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	        Public Sub ExportWorkbookToCsvCustomDelimiter()
	            '#Region radspreadsheet-model-import-export-csvformatprovider-silverlight_5
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	    End Class



The next snippet uses the __CustomFormatProvider__ to export csv files with semicolon delimiter:
        

#### __C#__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_5}}
	                Workbook workbook = new Workbook();
	                workbook.Worksheets.Add();
	
	                SaveFileDialog saveFileDialog = new SaveFileDialog();
	                CustomCsvFormatProvider formatProvider = new CustomCsvFormatProvider();
	                saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*";
	
	                if (saveFileDialog.ShowDialog() == true)
	                {
	                    using (Stream output = saveFileDialog.OpenFile())
	                    {
	                        formatProvider.Export(workbook, output);
	                    }
	                }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-csvformatprovider-silverlight_5}}
	            Dim workbook As New Workbook()
	            workbook.Worksheets.Add()
	
	            Dim saveFileDialog As New SaveFileDialog()
	            Dim formatProvider As New CustomCsvFormatProvider()
	            saveFileDialog.Filter = "CSV (comma delimited) (*.csv)|*.csv|All Files (*.*)|*.*"
	
	            If saveFileDialog.ShowDialog() = True Then
	                Using output As Stream = saveFileDialog.OpenFile()
	                    formatProvider.Export(workbook, output)
	                End Using
	            End If
	            '#End Region
	        End Sub
	
	    End Class



# See Also
