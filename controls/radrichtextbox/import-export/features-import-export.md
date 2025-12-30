---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-import-export
tags: import/export
published: True
position: 0
---

# Overview



__RadRichTextBox__ allows you to export and import its content. This is useful in case you want to save the user's input into a data base and then load it from there, or if you want to save/load the content of __RadRichTextBox__ to/from a file. To import and export you have to use a specific class that implements the __IDocumentFormatProvider__. You can find built-in classes, that implement this interface, for each of the supported formats. Currently __RadRichTextBox__ can export and import the following formats:
      

* __XAML__: To import/export __XAML__ documents you have to use the [__XamlFormatProvider__]({%slug radrichtextbox-import-export-using-xamlformatprovider%}) class.

* __DOCX__: To import/export __DOCX__ documents you have to use the [__DocxFormatProvider__]({%slug radrichtextbox-import-export-using-docxformatprovider%}) class.

* __HTML__: To import/export __HTML__ documents you have to use the [__HtmlFormatProvider__]({%slug radrichtextbox-import-export-html-htmlformatprovider%}) class.
     
* __RTF__: To import/export __RTF__ documents you have to use the [__RtfFormatProvider__]({%slug radrichtextbox-import-export-rtf-rtfformatprovider%}) class.

* __Plain text__: To import/export plain text documents you have to use the [__TxtFormatProvider__]({%slug radrichtextbox-import-export-txt-txtformatprovider%}) class.

* __PDF__: To export documents to __PDF__ you have to use the [__PdfFormatProvider__]({%slug radrichtextbox-import-export-pdf-pdfformatprovider%}) class.
          

>tip Each __FormatProvider__ class is located in a separate assembly matching its name. For example, the __XamlFormatProvider__ class is in the __Telerik.Windows.Documents.FormatProviders.Xaml.dll__ assembly. The only exception is the __TxtFormatProvider__, which is included in __Telerik.Windows.Documents__.
        

## Specifics

__RadRichTextBox__'s format providers can import/export a wide variety of features supported by the control. However, features which are not yet supported are stripped on import. Such examples are content controls like text boxes, check boxes, etc. which can be inserted in the document in some rich text editors such as Microsoft Word or can be included in the HTML.
        
## See Also

 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})

 * [History]({%slug radrichtextbox-features-history%})
