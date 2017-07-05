---
title: Using DocxFormatProvider
page_title: Using DocxFormatProvider
description: Using DocxFormatProvider
slug: radrichtextbox-import-export-using-docxformatprovider
tags: using-docxFormatProvider
published: True
position: 0
---

# Using DocxFormatProvider

__DocxFormatProvider__ makes it easy to import and export RadRichTextBox to/from DOCX format, preserving the entire document structure and formatting.

All you have to do in order to use DocxFormatProvider is to add references to the assemblies listed below:

* __Telerik.Windows.Documents.FormatProviders.OpenXml.dll__
* __Telerik.Windows.Zip.dll__

## Import
In order to import a __.docx__ file, you need to use the Import() method of DocxFormatProvider. The code in __Example 1__ shows how to use __DocxFormatProvider__ to import a DOCX document from a file.

#### __[C#] Example 1: Import document from a file__
{{region cs-radrichtextbox-import-export-using-docxformatprovider-0}}
	DocxFormatProvider provider = new DocxFormatProvider();
	using (FileStream inputStream = new FileStream("Sample.docx",FileMode.Open))
	{
		this.radRichTextBox.Document = provider.Import(inputStream);
	}
{{endregion}}

And here is how you can import a document from byte array containing the docx document:
        

#### __[C#] Example 2: Import document from a byte array__
{{region cs-radrichtextbox-formats-and-conversion-docx-docxformatprovider_1}}
    DocxFormatProvider provider = new DocxFormatProvider();
    RadDocument document = provider.Import(input);
{{endregion}}

## Export
In order to export a document to DOCX, you need to use the Export() method of DocxFormatProvider. __Example 2__ shows how to use __DocxFormatProvider__ to export __RadDocument__ to a file.

#### __[C#] Example 3: Export document to a file__
{{region cs-radrichtextbox-import-export-using-docxformatprovider-2}}
	DocxFormatProvider provider = new DocxFormatProvider();
	using (FileStream output =  new FileStream("Sample.docx",FileMode.OpenOrCreate))
	{
		RadDocument document = this.radRichTextBox.Document;
		provider.Export(document, output);
	}
{{endregion}}

You can also export the document to a byte array and preserve it in a database.

#### __[C#] Example 4: Export a document to a byte array__
{{region cs-radrichtextbox-import-export-using-docxformatprovider_3}}
    DocxFormatProvider provider = new DocxFormatProvider();
    RadDocument document = CreateRadDocument();
    byte[] output = provider.Export(document);
{{endregion}}

The resulting documents can be opened in any application that supports DOCX documents.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings] ({%slug radrichtextbox-import-export-docx-settings%})
