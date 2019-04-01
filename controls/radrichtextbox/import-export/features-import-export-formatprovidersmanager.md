---
title: Format Providers Manager
page_title: Format Providers Manager
description: Format Providers Manager
slug: radrichtextbox-features-import-export-formatprovidersmanager
tags: import/export
published: True
position: 1
---

# Format Providers Manager


__RadRichTextBox__ contains the **DocumentFormatProvidersManager** class that allows you to specify a set of format providers which can be used importing or exporting files letting the manager choose the appropriate format provider. The class also exposes methods that return all registered providers and supported file extensions.


## Registering Format Providers

The **DocumentFormatProvidersManager** class exposes a method that allows you to register format providers. The manager has the docx, html, rtf, pdf and txt format providers registered by default through [MEF]({%slug radrichtextbox-mef%}). The snippet in __Example 1__ illustrates how to register a custom format provider. The same can be used for registering the default format providers when the MEF fails to load them automatically due to restrictions, for example.


#### __[C#] Example 1: Register provider__

{{region radrichtextbox-features-import-export-formatprovidersmanager_0}}
   
    DocumentFormatProvidersManager.RegisterFormatProvider(new CustomHtmlFormatProvider());
{{endregion}}



#### __[VB.NET] Example 1: Register provider__

{{region radrichtextbox-features-import-export-formatprovidersmanager_1}}

	DocumentFormatProvidersManager.RegisterFormatProvider(New CustomHtmlFormatProvider())
{{endregion}}

You can also disable the automatic load of the default providers using the **AutomaticallyLoadFormatProviders** property. When it is set to `true`, you should manually take care of registering the format providers you would like to use in the application.

## Retrieve Registered Providers and Supported Extensions

The **DocumentFormatProvidersManager** class offers several approaches to retrieve the registered format providers. All the providers are available in the FormatProviders property. The class offers the **GetProviderByName()** static method that searches through the registered providers to find a provider with a specific name. Also, the manager exposes the __GetProvderByExtension()__ method. Both are useful when you need to obtain one of the default format providers used by the UI and tweak it using the exposed settings.

#### __[C#] Example 2: Modify default provider's settings__

{{region radrichtextbox-features-import-export-formatprovidersmanager_2}}

    DocxFormatProvider docxFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("docx") as DocxFormatProvider;
    docxFormatProvider.ExportSettings.FieldResultMode = FieldDisplayMode.Code;
{{endregion}}

#### __[VB.NET] Example 2: Modify default provider's settings__
{{region radrichtextbox-features-import-export-formatprovidersmanager_3}}

     Dim docxFormatProvider As DocxFormatProvider = TryCast(DocumentFormatProvidersManager.GetProviderByExtension("docx"), DocxFormatProvider)
     docxFormatProvider.ExportSettings.FieldResultMode = FieldDisplayMode.Code
{{endregion}}


The class also contains a static method  __GetSupportedExtensions()__ that returns an IEnumeable of the currently supported file extensions.

## See Also 

* [Using XamlFormatProvider]({%slug radrichtextbox-import-export-using-xamlformatprovider%})

* [Using HtmlFormatProvider]({%slug radrichtextbox-import-export-html-htmlformatprovider%})

* [Using DocxFormatProvider]({%slug radrichtextbox-import-export-using-docxformatprovider%})

* [Using RtfFormatProvider]({%slug radrichtextbox-import-export-rtf-rtfformatprovider%})

* [Using PdfFormatProvider]({%slug radrichtextbox-import-export-pdf-pdfformatprovider%})

* [Using TxtFormatProvider]({%slug radrichtextbox-import-export-txt-txtformatprovider%})

* [MEF]({%slug radrichtextbox-mef%})