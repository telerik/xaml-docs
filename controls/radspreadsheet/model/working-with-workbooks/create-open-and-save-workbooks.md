---
title: Create, Open and Save Workbooks
page_title: Create, Open and Save Workbooks
description: Create, Open and Save Workbooks
slug: radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks
tags: create,,open,and,save,workbooks
publish: False
position: 1
---

# Create, Open and Save Workbooks



__RadSpreadsheet__ allows you to create workbooks from scratch, open existing files as workbooks and save workbooks
        into different file formats. This article aims to help you get familiar with these operations.
      

## Create a Workbook

The fact that the document model of __RadSpreadsheet__ is completely decoupled from UI enables numerous server side
          scenarios that build a document from scratch. The model allows you to instantiate a new workbook using the nullary constructor of the
          __Workbook__ class. Note that when a new workbook is created in this manner its __Worksheet__'s
          collection is still empty. The following snippet creates a new workbook and adds its first worksheet, which also becomes the
          __ActiveWorksheet__ of the workbook:
        

#### __C#__

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_0}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	        '#End Region
	    End Sub
	
	    Public Sub ImportWorkbookFromXlsx()
	        '#Region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_1
	        Const FilePath As String = "http://localhost:54352/Resourses/SampleFile.xlsx"
	        Dim webClient As New WebClient()
	
	        webClient.OpenReadCompleted += Function(sender, eventArgs)
	                                           Dim formatProvider As New XlsxFormatProvider()
	                                           Dim workbook As Workbook = formatProvider.Import(eventArgs.Result)
	
	                                       End Function
	
	        webClient.OpenReadAsync(New Uri(FilePath))
	        '#End Region
	    End Sub
	
	    Public Sub ExportWorkbookToCsvSL()
	        '#Region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_2
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
	
	    Public Sub ExportWorkbookToCsvWPF()
	        '#Region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_3
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim fileName As String = "SampleFile.csv"
	        Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class



## Open a Workbook

__RadSpreadsheet__ document model allows you to easily import a workbook from a number of formats. Currently, the model
          supports csv, txt and xlsx formats. To import a workbook, you need to instantiate a specific format provider, invoke its
          __Import()__ method and pass a stream as an argument. The following example uses a WebClient to download a csv file stored on a server.
          Further, the code creates a __CsvFormatProvider__ object and invokes its __Import()__ method:
        

#### __C#__

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_1}}
	            const string FilePath = @"http://localhost:54352/Resourses/SampleFile.xlsx";
	            WebClient webClient = new WebClient();
	
	            webClient.OpenReadCompleted += (sender, eventArgs) =>
	            {
	                XlsxFormatProvider formatProvider = new XlsxFormatProvider();
	                Workbook workbook = formatProvider.Import(eventArgs.Result);
	            };
	
	            webClient.OpenReadAsync(new Uri(FilePath));
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_1}}
	        Const FilePath As String = "http://localhost:54352/Resourses/SampleFile.xlsx"
	        Dim webClient As New WebClient()
	
	        webClient.OpenReadCompleted += Function(sender, eventArgs)
	                                           Dim formatProvider As New XlsxFormatProvider()
	                                           Dim workbook As Workbook = formatProvider.Import(eventArgs.Result)
	
	                                       End Function
	
	        webClient.OpenReadAsync(New Uri(FilePath))
	        '#End Region
	    End Sub
	
	    Public Sub ExportWorkbookToCsvSL()
	        '#Region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_2
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
	
	    Public Sub ExportWorkbookToCsvWPF()
	        '#Region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_3
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim fileName As String = "SampleFile.csv"
	        Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class



More information about import is available in the
          [
            Import/Export
          ]({%slug radspreadsheet-import-export%}) section.
        

## Save a Workbook{% if site.site_name == 'Silverlight' %}

__RadSpreadsheet__ also allows you to save a workbook into a csv, txt and xlsx formats. To export a workbook, you need 
              to instantiate the format provider you would like to use and invoke its __Export()__ method.
            

For security purposes accessing files in Silverlight can be achieved only through user-initiated dialogs. That said, to save workbook's 
              contents into a csv file, you need to use the SaveFileDialog. The following example passes the stream returned by the dialog and the current 
              workbook to the __Export()__ method of the __CsvFormatProvider__:
            

#### __C#__

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_2}}
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

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_2}}
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
	
	    Public Sub ExportWorkbookToCsvWPF()
	        '#Region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_3
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim fileName As String = "SampleFile.csv"
	        Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class

{% endif %}{% if site.site_name == 'WPF' %}

__RadSpreadsheet__ also allows you to save a workbook into a csv, txt and xlsx formats. To export a workbook, you need 
              to instantiate the format provider you would like to use and invoke its __Export()__ method. The next example 
              demonstrates how to export an existing Workbook to a csv file. The snippet creates a new workbook with a single worksheet. Further, it 
              creates a __CsvFormatProvider__ and invokes its __Export()__ method:
            

#### __C#__

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_3}}
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

{{region radspreadsheet-model-working-with-workbooks-create-open-and-save-workbooks_3}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add()
	
	        Dim fileName As String = "SampleFile.csv"
	        Dim formatProvider As IWorkbookFormatProvider = New CsvFormatProvider()
	
	        Using output As New FileStream(fileName, FileMode.Create)
	            formatProvider.Export(workbook, output)
	        End Using
	        '#End Region
	    End Sub
	
	End Class

{% endif %}

More information about export is available in the
          [
            Import/Export
          ]({%slug radspreadsheet-import-export%})
          section.
        

# See Also
