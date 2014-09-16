---
title: XlsxFormatProvider
page_title: XlsxFormatProvider
description: XlsxFormatProvider
slug: radspreadsheet-model-import-export-xlsxformatprovider-silverlight
tags: xlsxformatprovider
publish: False
position: 1
site_name: Silverlight
---

# XlsxFormatProvider



__RadSpreadsheet for Silverlight__ makes it easy to import and export xlsx files from both the user interface and code behind. Bear in
        mind though that for security purposes Silverlight requires every action that involves accessing files on the client machine to be (1) initialized by the user
        and (2) performed through the file dialogs. To open a file through the UI you can use
        [OpenFileDialog](http://msdn.microsoft.com/en-us/library/system.windows.controls.openfiledialog(v=vs.95).aspx)
        and to save it –
        [SaveFileDialog](http://msdn.microsoft.com/en-us/library/system.windows.controls.savefiledialog(v=vs.95).aspx).
      

The xlsx format is a group of zipped files that conform to the Office Open XML schema. That said, the format allows you export all parts of a workbook:
        worksheets, formula values, formatting, hyperlinks, etc.
      

>Unlike the csv and txt format providers, the __XlsxFormatProvider__ requires references to the following assemblies:
        

* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll
            

* Telerik.Windows.Zip.dll
            

Once you reference the aforementioned assemblies, you need to create an instance of the __XlsxFormatProvider__ in order to import and 
        export xlsx files. This provider appears in the Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx namespace. The 
        __XlsxFormatProvider__ implements the __IWorkbookFormatProvider__ interface, which in turn appears in the 
        Telerik.Windows.Documents.Spreadsheet.FormatProviders. That said, depending on the whether you would like to work with the concrete class or the interface, 
        you will need to include either the first to both namespaces.
      

## Import

This section demonstrates how to import a file that resides on a web server and how to open a xlsx file through the OpenFileDialog.
        

The following snippet shows how to import a xlsx file that is located on a web server. To read the file from the server, the sample instantiates a
          [WebClient](http://msdn.microsoft.com/en-us/library/system.net.webclient(v=vs.95).aspx).
          Further, it subscribes to the OpenReadCompleted event of the *webclient*, which is triggered once the OpenReadAsync() method
          completes. Note that the example does not use any UI, which may cause a Security Exception if you try change the resource string to point to some external
          web resource.
        

#### __C#__

{{region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_0}}
	        public void ImportWorkbookFromXlsx(string fileName)
	        {
	            string filePath = string.Format(@"http://localhost:54352/Files/{0}", fileName);
	            WebClient webClient = new WebClient();
	
	            webClient.OpenReadCompleted += webClient_OpenReadCompleted;
	            webClient.OpenReadAsync(new Uri(filePath));
	        }
	
	        private void webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
	        {
	            XlsxFormatProvider formatProvider = new XlsxFormatProvider();
	
	            Workbook workbook = formatProvider.Import(e.Result);
	        }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_0}}
	    Public Sub ImportWorkbookFromXlsx(fileName As String)
	        Dim filePath As String = String.Format("http://localhost:54352/Files/{0}", fileName)
	        Dim webClient As New WebClient()
	
	        AddHandler webClient.OpenReadCompleted, AddressOf webClient_OpenReadCompleted
	        webClient.OpenReadAsync(New Uri(filePath))
	    End Sub
	
	    Private Sub webClient_OpenReadCompleted(sender As Object, e As OpenReadCompletedEventArgs)
	        Dim formatProvider As New XlsxFormatProvider()
	
	        Dim workbook As Workbook = formatProvider.Import(e.Result)
	    End Sub
	    '#End Region
	
	
	    Private Sub ImportWorkbookFromXlsxUsingOpenFileDialog()
	        '#Region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_1
	        Dim workbook As Workbook
	
	        Dim openFileDialog As New OpenFileDialog()
	        Dim formatProvider As New XlsxFormatProvider()
	        openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
	
	        If openFileDialog.ShowDialog() = True Then
	            Using input As Stream = openFileDialog.File.OpenRead()
	                workbook = formatProvider.Import(input)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub ExportWorkbookToXlsx()
	        '#Region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_2
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim saveFileDialog As New SaveFileDialog()
	        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
	        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
	
	        If saveFileDialog.ShowDialog() = True Then
	            Using output As Stream = saveFileDialog.OpenFile()
	                formatProvider.Export(workbook, output)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	End Class



The next example shows how to import a xlsx file that resides on the client machine. As already mentioned accessing files in Silverlight requires the usage
          of user-initiated dialogs for security purposes. That said, to open a file that is on the client, you should use an OpenFileDialog instance and retrieve a
          stream to the file. Once you have the stream you can import it as a Workbook.
        

#### __C#__

{{region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_1}}
	            Workbook workbook;
	
	            OpenFileDialog openFileDialog = new OpenFileDialog();
	            XlsxFormatProvider formatProvider = new XlsxFormatProvider();
	            openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
	
	            if (openFileDialog.ShowDialog() == true)
	            {
	                using (Stream input = openFileDialog.File.OpenRead())
	                {
	                    workbook = formatProvider.Import(input);
	                }
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_1}}
	        Dim workbook As Workbook
	
	        Dim openFileDialog As New OpenFileDialog()
	        Dim formatProvider As New XlsxFormatProvider()
	        openFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
	
	        If openFileDialog.ShowDialog() = True Then
	            Using input As Stream = openFileDialog.File.OpenRead()
	                workbook = formatProvider.Import(input)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub ExportWorkbookToXlsx()
	        '#Region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_2
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim saveFileDialog As New SaveFileDialog()
	        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
	        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
	
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
          workbook's contents into a xlsx file, you need to use the SaveFileDialog. The following example passes the stream returned by the dialog and the
          current workbook to the __Export()__ method of the __XlsxFormatProvider__:
        

#### __C#__

{{region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_2}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            SaveFileDialog saveFileDialog = new SaveFileDialog();
	            IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();
	            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
	
	            if (saveFileDialog.ShowDialog() == true)
	            {
	                using (Stream output = saveFileDialog.OpenFile())
	                {
	                    formatProvider.Export(workbook, output);
	                }
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-xlsxformatprovider-silverlight_2}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim saveFileDialog As New SaveFileDialog()
	        Dim formatProvider As IWorkbookFormatProvider = New XlsxFormatProvider()
	        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
	
	        If saveFileDialog.ShowDialog() = True Then
	            Using output As Stream = saveFileDialog.OpenFile()
	                formatProvider.Export(workbook, output)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	End Class



# See Also
