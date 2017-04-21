---
title: Using XamlFormatProvider
page_title: Using XamlFormatProvider
description: Using XamlFormatProvider
slug: radrichtextbox-import-export-using-xamlformatprovider
tags: using-xamlFormatProvider
published: True
position: 2
--- 

# Using XamlFormatProvider

__XamlFormatProvider__ makes it easy to import and export RadDocument to/from XAML format, preserving as much as possible of the document structure and formatting. 

To use __XamlFormatProvider__, you should add references to:

* __Telerik.Windows.Documents.FormatProviders.Xaml.dll__

## Import Settings
In order to import an XAML document you can use the overloads of the __Import()__ method.

__Example 1__ shows how to use XamlFormatProvider to import XAML document from a file.

#### __[C#] Example 1: Import XAML document from a file__
{{region cs-radrichtextbox-import-export-using-xamlformatprovider-0}}
	XamlFormatProvider xamlformatProvider = new XamlFormatProvider();
	using (FileStream inputStream = new FileStream("XamlDocument.xml",FileMode.Open))
	{
		this.radRichTextBox.Document = xamlformatProvider.Import(inputStream);
	}
{{endregion}}


## Export Settings
In order to export a document to XAML, you need to use the __Export()__ method of XamlFormatProvider. 

__Example 2__ shows how to use __XamlFormatProvider__ to export __RadDocument__ to a file.

#### __[C#] Example 3: Export document to a file__
{{region cs-radrichtextbox-import-export-using-xamlformatprovider-1}}
	XamlFormatProvider provider = new XamlFormatProvider();
	using (FileStream output =  new FileStream("XamlDocument.xml",FileMode.OpenOrCreate))
	{
		RadDocument document = this.radRichTextBox.Document;
		provider.Export(document, output);
	}
{{endregion}}

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-xaml-settings%})
