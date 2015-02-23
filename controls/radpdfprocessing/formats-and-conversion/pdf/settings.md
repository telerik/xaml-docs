---
title: Settings
page_title: Settings
description: Settings
slug: radpdfprocessing-formats-and-conversion-pdf-settings
tags: settings
published: True
position: 3
---

# Settings



__PdfFormatProvider__ provides you with the ability to import/export PDF documents. Additionally, you can take advantage of the import/export settings that give you modification options.
      

## Import Settings

You can specify the import settings you wish through the __ImportSettings__ property of __PdfFormatProvider__.The available import settings are these:

__UserPasswordNeeded__

The event is fired when a user password is needed to open the document. The password can be specified in the __PasswordNeededEventArgs.Password__ property.
        

__Example 1__ shows how you can create a __PdfImportSettings__ object and assign it to a PdfFormatProvider.
        

#### __[C#] Example 1: Import Settings__

{{region radpdfprocessing-formats-and-conversion-pdf-settings_0}}
    PdfFormatProvider provider = new PdfFormatProvider();
    PdfImportSettings settings = new PdfImportSettings();
    settings.UserPasswordNeeded += (s, a) =>
    {
        a.Password = "D0cum3ntP4ssw0rd";
    };

    provider.ImportSettings = settings;
{{endregion}}



## Export Settings

In order to modify the way content is exported you can set the __ExportSettings__ property of __PdfFormatProvider__. These are the modification options you can use:
        

__IsEncrypted__

This property specifies if the document should be encrypted. The default value is False.

>This setting is ignored when __ComplianceLevel__ differs from __None__ as PDF/A compliant documents do not allow encryption.

__UserPassword__

The password to be used if the document is encrypted. The default password is empty string.
        

__ImageQuality__

The ImageQuality property specifies the quality with which images are exported to PDF. The higher the quality, the bigger the PDF document. Possible values for this property are High, Medium, and Low. The default quality is Medium.

__ComplianceLevel__

Specifies the PDF/A compliance level. It can have one of the following values: 

* __None__: Specify no compliance level.
* __PdfA1B__: Specify PDF/A-1b compliance level.
* __PdfA2B__: Specify PDF/A-2b compliance level.
* __PdfA2U__: Specify PDF/A-2u compliance level.
* __PdfA3B__: Specify PDF/A-3b compliance level.
* __PdfA3U__: Specify PDF/A-3u compliance level.

The default value is __None__. For more information on PDF/A compliance check the PDF/A Compliance article.

__Example 2__ shows ow you can create a __PdfExportSettings__ object and assign it to a PdfFormatProvider.
        

#### __[C#] Example 2: Export Settings__

{{region radpdfprocessing-formats-and-conversion-pdf-settings_1}}
    PdfFormatProvider provider = new PdfFormatProvider();
    PdfExportSettings settings = new PdfExportSettings();
    settings.IsEncrypted = true;
    settings.UserPassword = "D0cum3ntP4ssw0rd";
    settings.ImageQuality = ImageQuality.High;
    settings.ComplianceLevel = PdfComplianceLevel.PdfA2B;

    provider.ExportSettings = settings;
{{endregion}}


## See Also

* [PdfExportSettings API Reference](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_FormatProviders_Pdf_Export_PdfExportSettings.htm)
* [How to Comply with PDF/A Standard]({%slug radpdfprocessing-howto-comply-with-pdfa-standard%})