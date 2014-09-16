---
title: TxtFormatProvider
page_title: TxtFormatProvider
description: TxtFormatProvider
slug: radspreadsheet-model-import-export-txtformatprovider-silverlight
tags: txtformatprovider
publish: False
position: 5
site_name: Silverlight
---

# TxtFormatProvider



__RadSpreadsheet for Silverlight__ makes it easy to import and export txt files from both the user interface and code behind. Bear in
        mind though that for security purposes Silverlight requires every action that involves accessing files on the client machine to be (1) initialized by the user
        and (2) performed through the file dialogs. To open a file through the UI you can use
        [OpenFileDialog](http://msdn.microsoft.com/en-us/library/system.windows.controls.openfiledialog(v=vs.95).aspx)
        and to save it –
        [SaveFileDialog](http://msdn.microsoft.com/en-us/library/system.windows.controls.savefiledialog(v=vs.95).aspx).
      

Note that txt is a plain text format and holds only the contents of the worksheet without its formatting. Exporting a file to txt strips all styling and saves
        only cell's text content using tab as a delimiter. Moreover, it exports only the contents of the active worksheet – no support for exporting multiple
        worksheets into a txt at once is available. Importing from txt respectively creates a new workbook with a single worksheet named *Sheet1*.
      

In order to import and export txt files you need an instance of __TxtFormatProvider__, which is contained in the
        Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt namespace. The __TxtFormatProvider__ implements the interface
        __IWorkbookFormatProvider__ that appears in the Telerik.Windows.Documents.Spreadsheet.FormatProviders namespace. That said, depending on
        whether you would like to work with the concrete class or the interface, you will need to include either the first or both namespaces.
      

## Import

This section contains two examples that aim to illustrate how to import a file that resides on a web server and how to open a txt file through the OpenFileDialog.
        

The following snippet shows how to import a txt file that is located on a web server. To read the file from the server, the sample instantiates a
          [WebClient](http://msdn.microsoft.com/en-us/library/system.net.webclient(v=vs.95).aspx).
          Further, it subscribes to the OpenReadCompleted event of the web client, which is triggered once the OpenReadAsync() method completes. Note that the example
          does not use any UI, which may cause a Security Exception if you try to change the resource string to point to some external web resource.
        

#### __C#__

{{region radspreadsheet-model-import-export-txtformatprovider-silverlight_0}}
	        public void ImportWorkbookFromTxt(string fileName)
	        {
	            string filePath = string.Format(@"http://localhost:54352/Files/{0}", fileName);
	            WebClient webClient = new WebClient();
	
	            webClient.OpenReadCompleted += webClient_OpenReadCompleted;
	            webClient.OpenReadAsync(new Uri(filePath));
	        }
	
	        private void webClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
	        {
	            TxtFormatProvider formatProvider = new TxtFormatProvider();
	            Workbook workbook = formatProvider.Import(e.Result);
	        }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-txtformatprovider-silverlight_0}}
	    Public Sub ImportWorkbookFromTxt(fileName As String)
	        Dim filePath As String = String.Format("http://localhost:54352/Files/{0}", fileName)
	        Dim webClient As New WebClient()
	
	        AddHandler webClient.OpenReadCompleted, AddressOf webClient_OpenReadCompleted
	        webClient.OpenReadAsync(New Uri(filePath))
	    End Sub
	
	    Private Sub webClient_OpenReadCompleted(sender As Object, e As OpenReadCompletedEventArgs)
	        Dim formatProvider As New TxtFormatProvider()
	        Dim workbook As Workbook = formatProvider.Import(e.Result)
	    End Sub
	#End Region
	
	    Private Sub ImportWorkbookFromTxtUsingOpenFileDialog()
	        '#Region radspreadsheet-model-import-export-txtformatprovider-silverlight_1
	        Dim workbook As Workbook
	
	        Dim openFileDialog As New OpenFileDialog()
	        Dim formatProvider As IWorkbookFormatProvider = New TxtFormatProvider()
	        openFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*"
	
	        If openFileDialog.ShowDialog() = True Then
	            Using input As Stream = openFileDialog.File.OpenRead()
	                workbook = formatProvider.Import(input)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub ExportWorkbookToTxt()
	        '#Region radspreadsheet-model-import-export-txtformatprovider-silverlight_2
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim saveFileDialog As New SaveFileDialog()
	        Dim formatProvider As New TxtFormatProvider()
	        saveFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*"
	
	        If saveFileDialog.ShowDialog() = True Then
	            Using output As Stream = saveFileDialog.OpenFile()
	                formatProvider.Export(workbook, output)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	End Class



The next example shows how to import a txt file that resides on the client machine. As already mentioned accessing files in Silverlight requires the usage 
          of user-initiated dialogs for security purposes. That said, to open a file that is on the client, you should use an OpenFileDialog instance and retrieve a 
          stream to the file. Once you have the stream you can import it as a Workbook.
        

#### __C#__

{{region radspreadsheet-model-import-export-txtformatprovider-silverlight_1}}
	            Workbook workbook;
	
	            OpenFileDialog openFileDialog = new OpenFileDialog();
	            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();
	            openFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*";
	
	            if (openFileDialog.ShowDialog() == true)
	            {
	                using (Stream input = openFileDialog.File.OpenRead())
	                {
	                    workbook = formatProvider.Import(input);
	                }
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-txtformatprovider-silverlight_1}}
	        Dim workbook As Workbook
	
	        Dim openFileDialog As New OpenFileDialog()
	        Dim formatProvider As IWorkbookFormatProvider = New TxtFormatProvider()
	        openFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*"
	
	        If openFileDialog.ShowDialog() = True Then
	            Using input As Stream = openFileDialog.File.OpenRead()
	                workbook = formatProvider.Import(input)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub ExportWorkbookToTxt()
	        '#Region radspreadsheet-model-import-export-txtformatprovider-silverlight_2
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim saveFileDialog As New SaveFileDialog()
	        Dim formatProvider As New TxtFormatProvider()
	        saveFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*"
	
	        If saveFileDialog.ShowDialog() = True Then
	            Using output As Stream = saveFileDialog.OpenFile()
	                formatProvider.Export(workbook, output)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	End Class



## Export

As already mentioned, for security purposes accessing files in Silverlight can be achieved only through user-initiated dialogs. That said, to save 
          workbook's contents into a txt file, you need to use the SaveFileDialog. The following example passes the stream returned by the dialog and the current 
          workbook to the __Export()__ method of the __TxtFormatProvider__:
        

#### __C#__

{{region radspreadsheet-model-import-export-txtformatprovider-silverlight_2}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            SaveFileDialog saveFileDialog = new SaveFileDialog();
	            TxtFormatProvider formatProvider = new TxtFormatProvider();
	            saveFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*";
	
	            if (saveFileDialog.ShowDialog() == true)
	            {
	                using (Stream output = saveFileDialog.OpenFile())
	                {
	                    formatProvider.Export(workbook, output);
	                }
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-import-export-txtformatprovider-silverlight_2}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim saveFileDialog As New SaveFileDialog()
	        Dim formatProvider As New TxtFormatProvider()
	        saveFileDialog.Filter = "TXT (tab delimited) (*.txt)|*.txt|All Files (*.*)|*.*"
	
	        If saveFileDialog.ShowDialog() = True Then
	            Using output As Stream = saveFileDialog.OpenFile()
	                formatProvider.Export(workbook, output)
	            End Using
	        End If
	        '#End Region
	    End Sub
	
	End Class



# See Also
