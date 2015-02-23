---
title: Settings
page_title: Settings
description: Settings
slug: radwordsprocessing-formats-and-conversion-pdf-settings
tags: settings, pdf
published: True
position: 3
---

# Settings



__PdfFormatProvider__ allows to export of __RadFlowDocument__ to PDF. Using the provider’s ExportSettings property you can control how exactly the result file should be exported.
      

## Export Settings

The __PdfExportSettings__ class derives from the __Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export.PdfExportSettings__ class related to the [RadPdfProcessing]({%slug radpdfprocessing-overview%}) library. Thus, the export allows you to controls the encryption, image quality and other PDF format related properties. More information on the settings are available in the [export settings article for RadPdfProcessing]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%}).

__Example 1__ demonstrates how to export a __RadFlowDocument__ instance to PDF and specify that it needs to be PDF/A compliant.


>tipIn order to specify export settings to the PdfFormatProvider you need to add both the Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export and Telerik.Windows.Documents.Flow.FormatProviders.Pdf.Export namespaces. In __Example 1__ the *Fixed* alias corresponds to the *Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export* namespace.


#### __[C#] Example 1: Export PDF/A Compliant Document__

{{region radwordsprocessing-formats-and-conversion-pdf-settings_0}}
	PdfFormatProvider provider = new PdfFormatProvider();
	PdfExportSettings settings = new PdfExportSettings();
	settings.ComplianceLevel = Fixed.PdfComplianceLevel.PdfA2B;
	
	provider.ExportSettings = settings;
	
	using (Stream output = File.OpenWrite("sample.pdf"))
	{
	    RadFlowDocument document = CreateRadFlowDocument();
	    provider.Export(document, output);
	}
{{endregion}}


>PDF/A standard requires documents to contain all fonts used in them within the document. RadPdfProcessing does not support embedding of the standard 14 fonts used in PDF documents that are listed [here]({%slug radpdfprocessing-concepts-fonts%}), so using them will prevent the document from complying with the standard.


## Extensibility Manager


The __ExtensibilityManager__ property of the PdfExportSettings class allows to easily extend the currently supported functionality of the RadFlowDocument export to PDF. 


ExtensibilityManager provides an option to control how lists with different __NumberingStyle__ options are exported to PDF. This can be achieved by registering custom implementation of the __INumberingStyleConverter__ interface for some concrete __NumberingStyle__ enumeration value. 

__Example 2__ shows how to register a custom *ChineseCountingConverter* class instance that converts a number with NumberingStyle.ChineseCounting.


#### __[C#] Example 2: Register Numbering Style Converter__

{{region radwordsprocessing-formats-and-conversion-pdf-settings_1}}
	provider.ExportSettings.ExtensibilityManager.RegisterNumberingStyleConverter(NumberingStyle.ChineseCounting, new ChineseCountingConverter());
{{endregion}}



## See Also

* [PdfProcessing Export Settings]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%})
* [PdfProcessing PDF/A Compliancy]({%slug radpdfprocessing-howto-comply-with-pdfa-standard%})



