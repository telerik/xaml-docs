---
title: Frequently Asked Questions
page_title: Frequently Asked Questions
description: Check our &quot;Frequently Asked Questions&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-frequently-asked-questions
tags: frequently,asked,questions
published: True
position: 2
---

# Frequently Asked Questions

This topic aims to answer some of the frequently asked questions about the use of RadRichTextBox.

## Setting Default Style Settings on the Document

RadRichTextBox has a Boolean property called __DocumentInheritsDefaultStyleSettings__, which must be set to __True__, if you want to set some default font properties. Otherwise your settings for the following properties would be disregarded:

* FontFamily;

* FontSize;

* FontStyle (Normal/Italic);

* FontWeight (Normal/Bold).

* Foreground;

Here is how you can do that in XAML:

__Example 1: Applying default style settings on the document__

<snippet id='radrichtextbox-frequently-asked-questions-block_1-xaml' />

If you run that in an example with a __RadRichTextBoxRibbonUI__ and/or __SelectionMiniToolBar__, you will notice that the value of the FontSize they show is 12. That is so, because the unit they use when measuring is points, as opposed to RadRichTextBox's default measuring unit – DIP. You can also set these properties in code behind. If you decide on that option, you can also make use of the methods that the class __Telerik.Windows.Documents.Model.Unit__ exposes for converting between different measuring units. The following code produces the same result as the XAML above: 

__Example 1: Applying default style settings on the document__  
<snippet id='radrichtextbox-frequently-asked-questions-block_2-cs' />

>These settings will not be applied on text which is imported by a rich-text [format provider]({%slug radrichtextbox-features-import-export%}), as the settings defined in the input file/string will be applied.          

## How to Get and Set the Text of RadRichTextBox

RadRichTextBox does not have a Text property because different formats for import and export of documents are supported – RTF, HTML, XAML, docX, plain text and PDF (export only). In order to set the contents of the document, it should be clear what format the data is in. For easier extensibility and separation of concerns, format providers that deal with the import and export of the documents are used. Here is a list of the currently available format providers and the assemblies they are included in:

* TxtFormatProvider (plain text) – Telerik.Windows.Documents;

* DocxFormatProvider - Telerik.Windows.Documents.FormatProviders.OpenXml;

* HtmlFormatProvider - Telerik.Windows.Documents.FormatProviders.Html;

* XamlFormatProvider - Telerik.Windows.Documents.FormatProviders.Xaml;

* RtfFormatProvider – Telerik.Windows.Documents.FormatProviders.Rtf;

* PdfFormatProvider - Telerik.Windows.Documents.FormatProviders.Pdf;

You can read more about the use of format providers [here]({%slug radrichtextbox-features-import-export%}). Overall, what you need to do to get the content of the document in a specific format is to create an instance of the corresponding provider and export the document. An example is illustrated below:        

__Example 2: Export a document__  
<snippet id='radrichtextbox-frequently-asked-questions-block_3-cs' />

To get the text stripped of all formatting, you can use __TxtFormatProvider__, which is included in the __Telerik.Windows.Documents.dll__ assembly. Setting the content of RadRichTextBox can be done in the same manner if you have the content in one of these formats. For example, importing an HTML string to RadDocument can be done as follows:

__Example 3: Import a document__  
<snippet id='radrichtextbox-frequently-asked-questions-block_4-cs' />

If you wish to preserve the initial content of the document and insert text at different positions in the document, you can use the __Insert~__ methods of __RadRichTextBox__ or [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}). The Insert method of RadRichTextBox uses the current span style of the document, i.e. the text is included in the document just as it would have been if you typed it at that position.

__Example 4: Inserting text in RadRichTextBox at caret position__  
<snippet id='radrichtextbox-frequently-asked-questions-block_5-cs' />

You can manipulate the caret position before invoking the Insert~() method in order to change the position where the new content will appear. You can find more information on document positions and their usage [here]({%slug radrichtextbox-features-positioning%}).       

## Setting the Margins of the Document

If you are using a document in [flow layout mode]({%slug radrichtextbox-features-layout-modes%}#flow), the document respects the value you set to the Padding property that RadRichTextBox inherits from Control. 

__Example 5: Set padding__  
<snippet id='radrichtextbox-frequently-asked-questions-block_6-xaml' />

__Example 5: Set padding__  
<snippet id='radrichtextbox-frequently-asked-questions-block_7-cs' />

With [paged layout mode]({%slug radrichtextbox-features-layout-modes%}#paged), you can set the margin of the document like this:

__Example 6: Apply margin to a Section__  
<snippet id='radrichtextbox-frequently-asked-questions-block_8-xaml' />

__Example 6: Apply margin to a Section__  
<snippet id='radrichtextbox-frequently-asked-questions-block_9-cs' />

If you are using [data providers]({%slug radrichtextbox-features-data-providers%}) to bind the content of RadRichTextBox, a new document will be created for every change in the string property which is the binding source. In that case, setting these properties should be done on DocumentChanged.        

## Inserting Multiple Consecutive Tables

Inserting multiple [Table]({%slug radrichtextbox-features-document-elements-tables%}) elements in a RadDocument one after another results in them being separated by some space. This may also happen when importing a document from one of the supported formats. The additional space is caused by an empty paragraph appended between the tables and is expected as RadDocument's structure does not allow adjacent tables.        

When [building a document from code]({%slug radrichtextbox-getting-started%}), you should also follow the same approach and add paragraphs between tables in order to prevent possible issues from arising.        