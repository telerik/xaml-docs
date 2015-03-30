---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radspreadprocessing-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started



This article will get you started in using the __RadSpreadProcessing__ library. It contains the following sections:
      

* [Assembly References](#assembly-references)

* [Creating a Workbook](#creating-a-workbook)

* [Exporting](#exporting)

* [Using RadSpreadsheet](#using-radspreadsheet)

## Assembly References

In order to use the model of the __RadSpreadProcessing__ library in your project you need to add references to the following assemblies:
        

* Telerik.Windows.Documents.Core.dll
            

* Telerik.Windows.Documents.Spreadsheet.dll
            

* Telerik.Windows.Maths.dll
            

The following assemblies are required in order to be able to exporto to Xlsx and PDF formats:
        

* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll

* Telerik.Windows.Documents.Fixed.dll            

* Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.dll
            

* Telerik.Windows.Zip.dll
            

## Creating a Workbook

The document model allows you to instantiate a new [workbook]({%slug radspreadprocessing-working-wtih-workbooks-what-is-workbook%}) and populate it with any data you want.
        

__Example 1__ shows how you can create a workbook and add a new worksheet to it.
        

#### __[C#] Example 1: Create Workbook__

{{region radspreadprocessing-getting-started_0}}
    Workbook workbook = new Workbook();
    Worksheet worksheet = workbook.Worksheets.Add();
	{{endregion}}



You can then create a [CellSelection]({%slug radspreadprocessing-working-with-cells-get-set-clear-properties%}) and set any value to the selected cells. __Example 2__ shows how you can create a cell and set a string value to it.
        

#### __[C#] Example 2: Set Value of Cell__

{{region radspreadprocessing-getting-started_1}}
    CellSelection selection = worksheet.Cells[1, 1]; //B2 cell
    selection.SetValue("Hello RadSpreadProcessing");
	{{endregion}}



## Exporting

The __RadSpreadProcessing__ library supports a variety of formats to which you can export the contents of a workbook. __Example 3__ shows how you can export the previously created workbook to Xlsx format.
        

#### __[C#] Example 3: Export to Xlsx__

{{region radspreadprocessing-getting-started_2}}
    string fileName = "Hello.xlsx";
    IWorkbookFormatProvider formatProvider = new XlsxFormatProvider();

    using (FileStream input = new FileStream(fileName, FileMode.Open))
    {
        workbook = formatProvider.Import(input);
    }
	{{endregion}}



## Using RadSpreadsheet

__RadSpreadsheet__ is a UI control part of the Telerik UI for WPF/Silverlight suites. The document model explained in this section of the documentation and all its features are shared between the __RadSpreadProcessing__ library and __RadSpreadsheet__. [This help section]({%slug radspreadsheet-overview%}) contains information about all UI-specific features of __RadSpreadsheet__.
        

# See Also

 * [Whats is a Workbook?]({%slug radspreadprocessing-working-wtih-workbooks-what-is-workbook%})

 * [What is a Worksheet?]({%slug radspreadprocessing-working-with-worksheets-what-is-worksheet%})

 * [Get, Set and Clear Cell Properties]({%slug radspreadprocessing-working-with-cells-get-set-clear-properties%})

 * [Using XlsxFormatProvider]({%slug radspreadprocessing-formats-and-conversion-xlsx-xlsxformatprovider%})
