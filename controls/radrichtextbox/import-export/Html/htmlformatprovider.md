---
title: Using HtmlFormatProvider
page_title: Using HtmlFormatProvider
description: Using HtmlFormatProvider
slug: radrichtextbox-import-export-html-htmlformatprovider
tags: using-htmlFormatProvider
published: True
position: 0
---

# Using HtmlFormatProvider

__HtmlFormatProvider__ makes it easy to import and export __RadDocument__ to/from HTML format, preserving as much as possible of the document structure and formatting.

To use __HtmlFormatProvider__, you should add references to the assembly listed below:

* __Telerik.Windows.Documents.FormatProviders.Html__

## Import

In order to import an HTML document you can use the overloads of the __HtmlFormatProvider.Import()__ method.

__Example 1__ shows how to use HtmlFormatProvider to import an HTML document from a file.

#### __[C#] Example 1: Import HTML file__

{{region cs-radrichtextbox-import-export-html-htmlformatprovider_0}}
    using (Stream input = File.Create(@"Sample.html"))
    {
        HtmlFormatProvider provider = new HtmlFormatProvider();
        RadDocument document = provider.Import(input);
    }
{{endregion}}

__Example 2__ shows how you can import an HTML string.
 
#### __[C#] Example 2: Import HTML string__

{{region cs-radrichtextbox-import-export-html-htmlformatprovider_1}}
    string html = "<p>hello world!</p>";
    HtmlFormatProvider provider = new HtmlFormatProvider();
    RadDocument document = provider.Import(html);
{{endregion}}

The resulting __RadDocument__ can be used like any code-generated document.
        
## Export

In order to export a document to HTML you can use the overloads of the __HtmlFormatProvider.Export()__ method.

__Example 3__ shows how to use the HtmlFormatProvider to export an instance of RadDocument to a file:

#### __[C#] Example 3: Export HTML to file__

{{region radrichtextbox-formats-and-conversion-html-htmlformatprovider_2}}
    HtmlFormatProvider provider = new HtmlFormatProvider();
    using (Stream output = File.Create("Sample.html"))
    {
        RadDocument document = CreateRadDocument();
        provider.Export(document, output);
    }
{{endregion}}

You can also export the document to a string variable like shown in __Example 4__.

#### __[C#] Example 4: Export HTML to string__

{{region radrichtextbox-formats-and-conversion-html-htmlformatprovider_3}}
    RadDocument document = CreateRadDocument();
    HtmlFormatProvider provider = new HtmlFormatProvider();
    string html = provider.Export(document);
{{endregion}}

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-html-settings%}) 