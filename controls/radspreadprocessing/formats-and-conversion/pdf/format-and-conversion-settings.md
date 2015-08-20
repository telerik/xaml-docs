---
title: Settings
page_title: Settings
description: Settings
slug: radspreadprocessing-format-and-conversion-pdf-settings
tags: settings
published: True
position: 3
---

# Settings



__PdfFormatProvider__ allows to import and export PDF documents. Additionally, there are a number of settings that allow you to modify the import/export. The current article outlines the available settings.
      

## 

__PdfExportSettings__ allow controlling how a __Workbook__ is exported to PDF. Using __PdfExportSettings__ you may specify:
        

* __ExportWhat option__: Enumeration specifying whether to export the __Active Sheet__, the __Entire Workbook__ or the current __Selection__.
            

* __IgnorePrintArea option__: Boolean value indicating whether or not to ignore print area when exporting worksheets.
            

* __SelectedRanges property__: A list of ranges specifying which areas of the active worksheet should be exported. Using the __ExportWhat.Selection__ option you may specify that you need to export exactly this __SelectedRanges__ from the current worksheet, __ignoring PrintArea and PageBreaks__ from __WorksheetPageSetup__.

* __PdfFileSettings__:  A property of type __Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export.PdfExportSettings__ which is a class related to the [RadPdfProcessing library]({%slug radpdfprocessing-overview%}). Thus, the property allows you to controls the encryption, image quality and other PDF format related properties. More information on the settings are available in the [export settings article for RadPdfProcessing]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%}).


__Example 1__ shows how to export the Entire Workbook without ignoring the __PrintArea__ property in all worksheets:
        

#### __[C#] Example 1: Export Entire Workbook__

{{region radspreadprocessing-formats-and-conversion-pdf-settings_0}}
    PdfFormatProvider provider = new PdfFormatProvider();
    provider.ExportSettings = new PdfExportSettings(ExportWhat.EntireWorkbook, false);
{{endregion}}



__Example 2__ shows how to export only two selected ranges from the active worksheet, ignoring print areas and page breaks:
        

#### __[C#] Example 2: Export Selection__

{{region radspreadprocessing-formats-and-conversion-pdf-settings_1}}
    CellRange[] rangesToExport = new CellRange[]
    {
        new CellRange(2, 3, 10, 15),
        new CellRange(4, 5, 8, 20)
    };

    PdfFormatProvider provider = new PdfFormatProvider();
    provider.ExportSettings = new PdfExportSettings(rangesToExport);
{{endregion}}


>In order to specify file export settings to the __PdfFormatProvider__ you need to add both the Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export and Telerik.Windows.Documents.Flow.FormatProviders.Pdf.Export namespaces. In Example 3 the *Fixed* alias corresponds to the __Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export__ namespace.


Another export option is to specify settings specific to the PDF format to the exported document. __Example 3__ demonstrates how to utilize the __PdfFileSettings__ property in order to export a PDF/A-compliant document.


#### __[C#] Example 3: Export PDF/A Compliant Document__

{{region radspreadprocessing-formats-and-conversion-pdf-settings_2}}
    PdfFormatProvider provider = new PdfFormatProvider();

    Fixed.PdfExportSettings fileSettings = new Fixed.PdfExportSettings();
    fileSettings.ComplianceLevel = Fixed.PdfComplianceLevel.PdfA2B;

    provider.ExportSettings.PdfFileSettings = fileSettings;
{{endregion}}


## See Also

* [PdfProcessing Export Settings]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%})
* [PdfProcessing PDF/A Compliancy]({%slug radpdfprocessing-howto-comply-with-pdfa-standard%})