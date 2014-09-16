---
title: Create, Open and Save Workbooks
page_title: Create, Open and Save Workbooks
description: Create, Open and Save Workbooks
slug: radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks
tags: create,,open,and,save,workbooks
publish: True
position: 1
---

# Create, Open and Save Workbooks



You have the possibility to create workbooks from scratch, open existing files as workbooks and save workbooks into different file formats. This article aims to help you get familiar with these operations.
      

* [Create a Workbook](#create-a-workbook)

* [Open a Workbook](#open-a-workbook)

* [Save a Workbook](#save-a-workbook)

## Create a Workbook

The fact that the document model of __RadSpreadsheet__ is completely decoupled from UI enables numerous server side scenarios that build a document from scratch. The model allows you to instantiate a new workbook using the nullary constructor of the __Workbook__ class. Note that when a new workbook is created in this manner its __Worksheet__'s collection is still empty. __Example 1__ creates a new workbook and adds its first worksheet, which also becomes the __ActiveWorksheet__ of the workbook:
        

#### __[C#] Example 1: Create a workbook and add a worksheet to it__

{{region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	{{endregion}}



## Open a Workbook

__RadSpreadsheet__ document model allows you to easily import a workbook from a number of formats. Currently, the model supports csv, txt and xlsx formats. To import a workbook, you need to instantiate a specific format provider, invoke its __Import()__ method and pass a stream as an argument. __Example 2__ uses a WebClient to download a csv file stored on a server. Further, the code creates a __CsvFormatProvider__ object and invokes its __Import()__ method:
        

#### __[C#] Example 2: Download and import xlsx file__

{{region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_1}}
	            const string FilePath = @"http://localhost:54352/Resourses/SampleFile.xlsx";
	            WebClient webClient = new WebClient();
	
	            webClient.OpenReadCompleted += (sender, eventArgs) =>
	            {
	                XlsxFormatProvider formatProvider = new XlsxFormatProvider();
	                Workbook workbook = formatProvider.Import(eventArgs.Result);
	            };
	
	            webClient.OpenReadAsync(new Uri(FilePath));
	{{endregion}}



More information about import is available in the [Formats and Conversion]({%slug radspreadprocessing-formats-and-conversion%}) section.
        

## Save a Workbook{% if site.site_name == 'Silverlight' %}

__RadSpreadsheet__ also allows you to save a workbook into a csv, txt and xlsx formats. To export a workbook, you need to instantiate the format provider you would like to use and invoke its __Export()__ method.
          

For security purposes accessing files in Silverlight can be achieved only through user-initiated dialogs. That said, to save workbook's contents into a csv file, you need to use the SaveFileDialog. __Example 3__ passes the stream returned by the dialog and the current workbook to the __Export()__ method of the __CsvFormatProvider__:
          

#### __[C#] Example 3: Save csv file using SaveFileDialog__

{{region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_2}}
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

{% endif %}{% if site.site_name == 'WPF' %}

__RadSpreadsheet__ also allows you to save a workbook into a csv, txt and xlsx formats. To export a workbook, you need to instantiate the format provider you would like to use and invoke its __Export()__ method. __Example 3__ demonstrates how to export an existing Workbook to a csv file. The snippet creates a new workbook with a single worksheet. Further, it
            creates a __CsvFormatProvider__ and invokes its __Export()__ method:
          

#### __[C#] Example 3: Save csv file__

{{region radspreadprocessing-working-with-workbooks-create-open-and-save-workbooks_3}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            string fileName = "SampleFile.csv";
	            IWorkbookFormatProvider formatProvider = new CsvFormatProvider();
	
	            using (FileStream output = new FileStream(fileName, FileMode.Create))
	            {
	                formatProvider.Export(workbook, output);
	            }
	{{endregion}}

{% endif %}

More information about export is available in the [Formats and Conversion]({%slug radspreadprocessing-formats-and-conversion%}) section.
        
