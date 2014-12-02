---
title: General Information
page_title: General Information
description: General Information
slug: radspreadprocessing-formats-and-conversion-general-information
tags: formats,and,conversion
published: True
position: 0
---

# General Information



__RadSpreadProcessing__'s document model allows you to easily open and save files of different formats. Currently, the supported formats include:
      

* __Xlsx__: Rich text format, which exports the whole content of a workbook: worksheets, formula values, formatting, hyperlinks etc.

* __Pdf__: Fixed format, which preserves the content of a workbook in independent from software or hardware manner.

* __Csv__(comma separated): Plain text format that saves the content of the cell in the active worksheet. The format strips all formatting and keeps only the result values of cells. These values are separated by a culture dependent delimiter.

* __Txt__(tab delimited): Plain text format, which preserves only the content of the cells in the active worksheet. The format does not save any formatting and keeps only the result values of the cells. These values are delimited via tabs.


          

The document model exposes three format providers that work with each of the formats above: __XlsxFormatProvider__, __CsvFormatProvider__ and __TxtFormatProvider__. All of them implement the __IWorkbookFormatProvider__ interface and, thus, share a common API that enables import and export of files. To conform to the interface each of the providers implements two methods that, respectively, turn a stream into a workbook and save the contents of the workbook into a stream:
      

* Workbook Import(Stream input)

* void Export(Workbook workbook, Stream output)

>Unlike the __CsvFormatProvider__ and __TxtFormatProvider__ classes, the __XlsxFormatProvider__ requires references to the following assemblies:

>* Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.dll

>* Telerik.Windows.Zip.dll

> __PdfFormatProvider__ requires reference to the following assembly:

>* Telerik.Windows.Documents.Spreadsheet.FormatProviders.Pdf.dll


The document model of RadSpreadProcessing also contains a __WorkbookFormatProvidersManager__ class, which exposes a whole set of useful static methods. The manager allows you to specify a set of format providers you would like to use. Then you can import and export a file leaving the manager to choose the appropriate format provider to use. You only need to specify the extension of the file that you open or save:
      

* public static Workbook Import(string extension, Stream input)

* public static void Export(Workbook workbook, string extension, Stream output)

The *Formats and Conversion* section contains three separate articles dedicated on each of the format providers and one article that illustrates how to work with the [WorkbookFormatProvidersManager]({%slug radspreadprocessing-formats-and-conversion-format-providers-manager%}) class.
      

# See Also

 * [Activate a Worksheet]({%slug radspreadprocessing-working-with-worksheets-activate-worksheet%})
