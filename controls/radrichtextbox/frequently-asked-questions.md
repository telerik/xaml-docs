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

## Assembly References

In order to use __RadRichTextBox__ in your project, you need to add a reference to the __Telerik.Windows.Controls__, __Telerik.Windows.Data__, __Telerik.Windows.Documents__, __Telerik.Windows.Documents.Core__, __Telerik.Windows.Documents.Flow__ and __System.ComponentModel.Composition__ assemblies.

{% if site.site_name == 'Silverlight' %}You can find more info [here]({%slug installation-installing-controls-dependencies%}).{% endif %}

{% if site.site_name == 'WPF' %}You can find more info [here]({%slug installation-installing-controls-dependencies-wpf%}).{% endif %}
        

## Setting Default Style Settings on the Document

RadRichTextBox has a Boolean property called __DocumentInheritsDefaultStyleSettings__, which must be set to __True__, if you want to set some default font properties. Otherwise your settings for the following properties would be disregarded:
        

* FontFamily;

* FontSize;

* FontStyle (Normal/Italic);

* FontWeight (Normal/Bold).

* Foreground;


Here is how you can do that in XAML:

#### __[XAML] Example 1: Applying default style settings on the document__

{{region radrichtextbox-frequently-asked-questions_0}}
    <telerik:RadRichTextBox Name="radRichTextBox1" Grid.Row="1" FontFamily="Comic Sans MS" FontSize="16" FontStyle="Italic" FontWeight="Bold" DocumentInheritsDefaultStyleSettings="True" Foreground="Red"/>
{{endregion}}



If you run that in an example with a __RadRichTextBoxRibbonUI__ and/or __SelectionMiniToolBar__, you will notice that the value of the FontSize they show is 12. That is so, because the unit they use when measuring is points, as opposed to RadRichTextBox's default measuring unit – DIP. You can also set these properties in code behind. If you decide on that option, you can also make use of the methods that the class __Telerik.Windows.Documents.Model.Unit__ exposes for converting between different measuring units. The following code produces the same result as the XAML above:
        

#### __[C#] Example 1: Applying default style settings on the document__

{{region radrichtextbox-frequently-asked-questions_1}}

    	this.radRichTextBox1.FontFamily = new FontFamily("Comic Sans MS");
        this.radRichTextBox1.FontSize = Unit.PointToDip(12);
        this.radRichTextBox1.FontStyle = FontStyles.Italic;
        this.radRichTextBox1.FontWeight = FontWeights.Bold;
	this.radRichTextBox1.Foreground = Brushes.Red;
        this.radRichTextBox1.DocumentInheritsDefaultStyleSettings = true;
{{endregion}}



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
        

#### __[C#] Example 2: Export a document__

{{region radrichtextbox-frequently-asked-questions_2}}
    public string GetXAML(RadDocument document)
    {
        XamlFormatProvider provider = new XamlFormatProvider();
        return provider.Export(document);
    }
{{endregion}}



To get the text stripped of all formatting, you can use __TxtFormatProvider__, which is included in the __Telerik.Windows.Documents.dll__ assembly. Setting the content of RadRichTextBox can be done in the same manner if you have the content in one of these formats. For example, importing an HTML string to RadDocument can be done as follows:
        



#### __[C#] Example 3: Import a document__

{{region radrichtextbox-frequently-asked-questions_3}}
    public RadDocument ImportHtml(string content)
    {
        HtmlFormatProvider provider = new HtmlFormatProvider();
        return provider.Import(content);
    }
{{endregion}}



If you wish to preserve the initial content of the document and insert text at different positions in the document, you can use the __Insert~__ methods of __RadRichTextBox__ or [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}). The Insert method of RadRichTextBox uses the current span style of the document, i.e. the text is included in the document just as it would have been if you typed it at that position.
        

#### __[C#] Example 4: Inserting text in RadRichTextBox at caret position__

{{region radrichtextbox-frequently-asked-questions_4}}
    this.radRichTextBox.Insert(textToInsert);
{{endregion}}



You can manipulate the caret position before invoking the Insert~() method in order to change the position where the new content will appear. You can find more information on document positions and their usage [here]({%slug radrichtextbox-features-positioning%}).
        

## Setting the Margins of the Document

If you are using a document in [flow layout mode]({%slug radrichtextbox-features-layout-modes%}#flow), the document respects the value you set to the Padding property that RadRichTextBox inherits from Control. 

#### __[XAML] Example 5: Set padding__

{{region radrichtextbox-frequently-asked-questions_1}}
    <telerik:RadRichTextBox Name="radRichTextBox" Padding="0,20,100,60" />
{{endregion}}


#### __[C#] Example 5: Set padding__

{{region radrichtextbox-frequently-asked-questions_9}}
    this.editor.Padding = new Thickness(0, 20, 100, 60);
{{endregion}}


With [paged layout mode]({%slug radrichtextbox-features-layout-modes%}#paged), you can set the margin of the document like this:



#### __[XAML] Example 6: Apply margin to a Section__

{{region radrichtextbox-frequently-asked-questions_2}}
    <telerik:RadRichTextBox Name="editor" LayoutMode="Paged">
        <telerik:RadDocument SectionDefaultPageMargin="0,20,100,60" />
    </telerik:RadRichTextBox>
{{endregion}}



#### __[C#] Example 6: Apply margin to a Section__

{{region radrichtextbox-frequently-asked-questions_10}}
    this.editor.Document.LayoutMode = DocumentLayoutMode.Paged;
    this.editor.Document.SectionDefaultPageMargin = new Telerik.Windows.Documents.Layout.Padding(0, 20, 100, 60);
{{endregion}}



If you are using [data providers]({%slug radrichtextbox-features-data-providers%}) to bind the content of RadRichTextBox, a new document will be created for every change in the string property which is the binding source. In that case, setting these properties should be done on DocumentChanged.
        

## Inserting Multiple Consecutive Tables

Inserting multiple [Table]({%slug radrichtextbox-features-document-elements-tables%}) elements in a RadDocument one after another results in them being separated by some space. This may also happen when importing a document from one of the supported formats. The additional space is caused by an empty paragraph appended between the tables and is expected as RadDocument's structure does not allow adjacent tables.
        

When [building a document from code]({%slug radrichtextbox-getting-started%}), you should also follow the same approach and add paragraphs between tables in order to prevent possible issues from arising.
        
