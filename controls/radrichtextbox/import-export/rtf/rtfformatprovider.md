---
title: Using RtfFormatProvider
page_title: Using RtfFormatProvider
description: Check our &quot;Using RtfFormatProvider&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-rtf-rtfformatprovider
tags: using-rtfFormatProvider
published: True
position: 0
---

# Using RtfFormatProvider

__RtfFormatProvider__ makes it easy to import and export __RadDocument__ to/from RTF format, preserving the entire document structure and formatting.
      

All you have to do in order to use __RtfFormatProvider__ is to add a reference to `Telerik.Windows.Documents.FormatProviders.Rtf.dll`.
  
## Import

In order to import an RTF document, you need to use the __Import()__ method of __RtfFormatProvider__.
    
The code from __Example 1__ shows how to use __RtfFormatProvider__ to import an RTF document from a file.
     
#### __[C#] Example 1: Import document from a file__

{{region cs-radrichtextbox-import-export-rtf-rtfformatprovider_0}}
    RtfFormatProvider provider = new RtfFormatProvider();
    using (Stream input = File.OpenRead("Sample.rtf"))
    {
        RadDocument document = provider.Import(input);
    }
{{endregion}}

And here is how you can import a document from string containing the RTF document:

#### __[C#] Example 2: Import document from a string__

{{region cs-radrichtextbox-import-export-rtf-rtfformatprovider_1}}
    RtfFormatProvider provider = new RtfFormatProvider();
    RadDocument document = provider.Import(input);
{{endregion}}

The resulting __RadDocument__ can be used like any code-generated document.
 
## Export

In order to export a document to RTF, you need to use the __Export()__ method of __RtfFormatProvider__.
        
__Example 3__ shows how to use __RtfFormatProvider__ to export __RadDocument__ to a file.

#### __[C#] Example 3: Export a document to a file__

{{region cs-radrichtextbox-import-export-rtf-rtfformatprovider_2}}
    RtfFormatProvider provider = new RtfFormatProvider();
    using (Stream output = File.Create("sample.rtf"))
    {
        RadDocument document = CreateRadDocument();
        provider.Export(document, output);
    }
{{endregion}}

You can also export the document to a string and preserve it in a database.

#### __[C#] Example 4: Export a document to a string__

{{region cs-radrichtextbox-import-export-rtf-rtfformatprovider_3}}
    RtfFormatProvider provider = new RtfFormatProvider();
    RadDocument document = CreateRadDocument();
    string output = provider.Export(document);
{{endregion}}

The resulting documents can be opened in any application that supports RTF documents.

>tipHowever, the format providers cannot be used in XAML and you have to implement a logic that will call their Import() and Export() methods. This is something that you might not want to be concerned with when using RadRichTextBox in a data bound scenarios. For such cases, the [DataProvider]({%slug radrichtextbox-features-data-providers%}) classes are used. They wrap the FormatProviders' functionality and allow its usage in XAML.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-rtf-settings%})
 * [DataProvider]({%slug radrichtextbox-features-data-providers%})
