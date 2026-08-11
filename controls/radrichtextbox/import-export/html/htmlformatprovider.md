---
title: Using HtmlFormatProvider
page_title: Using HtmlFormatProvider
description: Check our &quot;Using HtmlFormatProvider&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-html-htmlformatprovider
tags: using-htmlFormatProvider
published: True
position: 0
---

# Using HtmlFormatProvider

__HtmlFormatProvider__ makes it easy to import and export __RadDocument__ to/from HTML format, preserving as much as possible of the document structure and formatting.

To use __HtmlFormatProvider__, you should add a reference to `Telerik.Windows.Documents.FormatProviders.Html.dll`.

## Import

In order to import an HTML document you can use the overloads of the __HtmlFormatProvider.Import()__ method.

__Example 1__ shows how to use HtmlFormatProvider to import an HTML document from a file.

__Example 1: Import HTML file__

<snippet id='radrichtextbox-import-export-html-htmlformatprovider-block_1-cs' />

__Example 2__ shows how you can import an HTML string.
 
__Example 2: Import HTML string__

<snippet id='radrichtextbox-import-export-html-htmlformatprovider-block_2-cs' />

The resulting __RadDocument__ can be used like any code-generated document.
        
## Export

With the overloads of the __Export()__ method you can export the document to an HTML string or a file.

__Example 3__ shows how to use the HtmlFormatProvider to export an instance of RadDocument to a file:

__Example 3: Export HTML to file__

<snippet id='radrichtextbox-import-export-html-htmlformatprovider-block_3-cs' />

You can also export the document to a string variable like shown in __Example 4__.

__Example 4: Export HTML to string__

<snippet id='radrichtextbox-import-export-html-htmlformatprovider-block_4-cs' />

>tip However, the format providers cannot be used in XAML and you have to implement a logic that will call their Import() and Export() methods. This is something that you might not want to be concerned with when using RadRichTextBox in a data bound scenarios. For such cases, the [DataProvider]({%slug radrichtextbox-features-data-providers%}) classes are used. They wrap the FormatProviders' functionality and allow its usage in XAML.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Settings]({%slug radrichtextbox-import-export-html-settings%}) 
 * [DataProvider]({%slug radrichtextbox-features-data-providers%})