---
title: Using TxtFormatProvider
page_title: Using TxtFormatProvider
description: Using TxtFormatProvider
slug: radspreadprocessing-formats-and-conversion-txt-txtformatprovider
tags: using,txtformatprovider
publish: True
position: 0
---

# Using TxtFormatProvider



__TxtFormatProvider__ makes it easy to import and export TXT files. Note that TXT is a plain text format and holds only the contents of the worksheet without its formatting. Exporting a file to this format strips all styling and saves only cell's result value with their format applied using tab as a delimiter. Moreover, it exports only the contents of the active worksheet – no support for exporting multiple worksheets into a txt at once is available. Importing from TXT respectively creates a new workbook with a single worksheet named *Sheet1*.
      

In order to import and export txt files you need an instance of __TxtFormatProvider__, which is contained in the Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt namespace. The __TxtFormatProvider__ implements the interface __IWorkbookFormatProvider__ that appears in the Telerik.Windows.Documents.Spreadsheet.FormatProviders namespace.
      

## Import

__Example 1__ shows how to import a txt file using a FileStream. The sample instantiates a __TxtFormatProvider__ and passes a FileStream to its __Import()__ method:
        

#### __[C#] Example 1: Import TXT File__

{{region radspreadprocessing-formats-and-conversion-txt-txtformatprovider_0}}
	            Workbook workbook;
	            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();
	
	            using (FileStream input = new FileStream(fileName, FileMode.Open))
	            {
	                workbook = formatProvider.Import(input);
	            }
	{{endregion}}



## Export

__Example 2__ demonstrates how to export an existing Workbook to a TXT file. The snippet creates a new workbook with a single worksheet. Further, it
          creates a __TxtFormatProvider__ and invokes its __Export()__ method:
        

#### __[C#] Example 2: Export TXT File__

{{region radspreadprocessing-formats-and-conversion-txt-txtformatprovider_1}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add();
	
	            string fileName = "SampleFile.txt";
	            IWorkbookFormatProvider formatProvider = new TxtFormatProvider();
	
	            using (FileStream output = new FileStream(fileName, FileMode.Create))
	            {
	                formatProvider.Export(workbook, output);
	            }
	{{endregion}}


