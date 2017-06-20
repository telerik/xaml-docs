---
title: Using TxtFormatProvider
page_title: Using TxtFormatProvider
description: Using TxtFormatProvider
slug: radrichtextbox-import-export-txt-txtformatprovider
tags: using-txtFormatProvider
published: True
position: 0
---

# Using TxtFormatProvider

__TxtFormatProvider__ makes it easy to import and export __RadDocument__ to/from plain text format, preserving the document structure. 

To use __TxtFormatProvider__, you should add references to: 
	
* __Telerik.Windows.Documents.dll__
        
## Import

In order to import a plain text document, you need to use the __Import()__ method of __TxtFormatProvider__. __Example 1__ shows how to use __TxtFormatProvider__ to import a document from a file.

#### __[C#] Example 1: Import document from a file__

{{region cs-radrichtextbox-import-export-txt-txtformatprovider_0}}
    TxtFormatProvider provider = new TxtFormatProvider();
    using (Stream input = File.OpenRead("Sample.txt"))
    {
        RadDocument document = provider.Import(input);
    }
{{endregion}}

And here is how you can import a document from string:
        
#### __[C#] Example 2: Import document from a string__

{{region cs-radrichtextbox-import-export-txt-txtformatprovider_1}}
    TxtFormatProvider provider = new TxtFormatProvider();
    RadDocument document = provider.Import(input);
{{endregion}}

The resulting __RadDocument__ can be manipulated like any code-generated document.

## Export

In order to export a document to plain text, you need to use the __Export()__ method of __TxtFormatProvider__.
 
__Example 3__ shows how to use __TxtFormatProvider__ to export __RadDocument__ to a file.

#### __[C#] Example 3: Export a document to a file__

{{region cs-radrichtextbox-formats-and-conversion-txt-txtformatprovider_2}}
    TxtFormatProvider provider = new TxtFormatProvider();
    using (Stream output = File.OpenWrite("sample.txt"))
    {
        RadDocument document = CreateRadDocument();
        provider.Export(document, output);
    }
{{endregion}}

You can also export the document to a string and preserve it in a database.

#### __[C#] Example 4: Export a document to a string__

{{region cs-radrichtextbox-formats-and-conversion-txt-txtformatprovider_3}}
    TxtFormatProvider provider = new TxtFormatProvider();
    RadDocument document = CreateRadDocument();
    string output = provider.Export(document);
{{endregion}}

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Plain Text]({%slug radrichtextbox-import-export-plain-text%})
