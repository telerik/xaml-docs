---
title: Using XamlFormatProvider
page_title: Using XamlFormatProvider
description: Check our &quot;Using XamlFormatProvider&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-using-xamlformatprovider
tags: using-xamlFormatProvider
published: True
position: 2
--- 

# Using XamlFormatProvider

__XamlFormatProvider__ makes it easy to import and export RadDocument to/from XAML format. This is the native format of RadRichTextBox and Using it guarantees that anything in the document will be preserved exactly the same as it is in the control. 

 >note Since R2 2023 SP1 the XamlFormatProvider automatically verifies the imported XAML. More information is available in the [Xaml Verification]({%slug radrichtextbox-import-export-xaml-verification%}) article.

To use __XamlFormatProvider__, you should add a reference to `Telerik.Windows.Documents.FormatProviders.Xaml.dll`.

## Import

In order to import a XAML document, you can use the overloads of the __Import()__ method.

__Example 1__ shows how to use XamlFormatProvider to import XAML document from a file.

__Example 1: Import XAML document from a file__
```C#
	XamlFormatProvider xamlformatProvider = new XamlFormatProvider();
	using (FileStream inputStream = new FileStream("XamlDocument.xaml",FileMode.Open))
	{
		this.radRichTextBox.Document = xamlformatProvider.Import(inputStream);
	}
```


## Export

In order to export a document to XAML, you need to use the __Export()__ method of XamlFormatProvider. 

__Example 2__ shows how to use __XamlFormatProvider__ to export __RadDocument__ to a file.

__Example 3: Export document to a file__
```C#
	XamlFormatProvider provider = new XamlFormatProvider();
	using (FileStream output =  new FileStream("XamlDocument.xaml",FileMode.OpenOrCreate))
	{
		RadDocument document = this.radRichTextBox.Document;
		provider.Export(document, output);
	}
```

>tip However, the format providers cannot be used in XAML and you have to implement a logic that will call their Import() and Export() methods. This is something that you might not want to be concerned with when using RadRichTextBox in a data bound scenarios. For such cases, the [DataProvider]({%slug radrichtextbox-features-data-providers%}) classes are used. They wrap the FormatProviders' functionality and allow its usage in XAML.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-xaml-settings%})
 * [DataProvider]({%slug radrichtextbox-features-data-providers%})
 