---
title: Using DocxFormatProvider
page_title: Using DocxFormatProvider
description: Check our &quot;Using DocxFormatProvider&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-using-docxformatprovider
tags: using-docxFormatProvider
published: True
position: 0
---

# Using DocxFormatProvider

__DocxFormatProvider__ makes it easy to import and export RadRichTextBox to/from DOCX format, preserving the entire document structure and formatting.

All you have to do in order to use DocxFormatProvider is to add a reference to `Telerik.Windows.Documents.FormatProviders.OpenXml.dll`.

## Import
In order to import a __.docx__ file, you need to use the Import() method of DocxFormatProvider. The code in __Example 1__ shows how to use __DocxFormatProvider__ to import a DOCX document from a file.

__Example 1: Import document from a file__
<snippet id='radrichtextbox-import-export-docx-docxformatprovider-block_1-cs' />

And here is how you can import a document from byte array containing the docx document:
        

__Example 2: Import document from a byte array__
<snippet id='radrichtextbox-import-export-docx-docxformatprovider-block_2-cs' />

## Export
In order to export a document to DOCX, you need to use the Export() method of DocxFormatProvider. __Example 2__ shows how to use __DocxFormatProvider__ to export __RadDocument__ to a file.

__Example 3: Export document to a file__
<snippet id='radrichtextbox-import-export-docx-docxformatprovider-block_3-cs' />

You can also export the document to a byte array and preserve it in a database.

__Example 4: Export a document to a byte array__
<snippet id='radrichtextbox-import-export-docx-docxformatprovider-block_4-cs' />

The resulting documents can be opened in any application that supports DOCX documents.

>tip However, the format providers cannot be used in XAML and you have to implement a logic that will call their Import() and Export() methods. This is something that you might not want to be concerned with when using RadRichTextBox in a data bound scenarios. For such cases, the [DataProvider]({%slug radrichtextbox-features-data-providers%}) classes are used. They wrap the FormatProviders' functionality and allow its usage in XAML.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings] ({%slug radrichtextbox-import-export-docx-settings%})
 * [DataProvider]({%slug radrichtextbox-features-data-providers%})