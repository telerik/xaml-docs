---
title: Using TextFormatProvider
page_title: Using TextFormatProvider
description: Using TextFormatProvider
slug: radpdfprocessing-formats-and-conversion-plain-text-textformatprovider
tags: using,textformatprovider
published: True
position: 1
---

# Using TextFormatProvider


__TextFormatProvider__ makes it easy to export __RadFixedDocument__ to plain text format, preserving the document structure.

All you have to do in order to use __TextFormatProvider__ is add references to the assemblies listed below:
      

* Telerik.Windows.Documents.Core.dll
          

* Telerik.Windows.Documents.Fixed.dll


## Export

In order to export a document to plain text you need to use the __Export()__ method of __TextFormatProvider__.
        

__Example 1__ shows how to use __TextFormatProvider__ to export __RadFixedDocument__ to a string.
        

#### __[C#] Example 1: Export RadFixedDocument to string__

{{region radwordsprocessing-formats-and-conversion-txt-tеxtformatprovider_0}}
	TextFormatProvider provider = new TextFormatProvider();
	RadFixedDocument document = CreateRadFixedDocument();
	string documentContent = provider.Export(document);
{{endregion}}


# See Also

* [Plain text]({%slug radpdfprocessing-formats-and-conversion-plain-text-text%})

* [TextFormatProvider Settings]({%slug radpdfprocessing-formats-and-conversion-plain-text-settings%})
