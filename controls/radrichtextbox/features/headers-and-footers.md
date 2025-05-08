---
title: Headers and Footers
page_title: Headers and Footers
description: Check our &quot;Headers and Footers&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-headers-and-footers
tags: headers,and,footers
published: True
---

# Headers and Footers

`RadRichTextBox` supports Headers and Footers in its document when in Paged [layout mode]({%slug radrichtextbox-features-layout-modes%}).

>Note that Headers and Footers are not persisted when exporting with HtmlFormatProvider. You can read more about this [here]({%slug radrichtextbox-features-import-export%}).

The topic contains the following sections:

* [Header Footer Types](#header-footer-types)

* [Customizing Headers And Footers](#customizing-headers-and-footers)

* [Disabling Headers and Footers](#disabling-headers-and-footers)

## Header Footer Types

The `Headers` and `Footers` are properties of a Section and each section in the document can have the following types of Headers and Footers:

* `First`&mdash;Used only on the first page of the section.

* `Even`&mdash;Used on all even numbered pages in the section.

* `Default`&mdash;Used on all pages of the section, where First or Even are not applicable or not specified.

## Customizing Headers and Footers

The following example demonstrates how you can create a Header.

#### __[C#] Create Header__
{{region radrichtextbox-features-headers-and-footers_0}}
	Header header = new Header() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument represents the content of a Header, 
	                                                                                 //typically contains a few paragraphs
{{endregion}}

When it comes to using a Header created in this manner, this depends on the state of the document - if it has been measured or not.

* In a non-measured document, which you are building in code-behind, you can set the Default page Header of a section as illustrated below:

	#### __[C#] Set Header of a Section__
	{{region radrichtextbox-features-headers-and-footers_1}}
		section.Headers.Default = header;
	{{endregion}}

* In a measured document (a document that has been previewed in the editor), you can change the Default page header of the first section like shown in the next example:

	#### __[C#] Update a Header in Measured Document__
	{{region radrichtextbox-features-headers-and-footers_2}}
		this.radRichTextBox.UpdateHeader(this.radRichTextBox.Document.Sections.First, HeaderFooterType.Default, header);
	{{endregion}}

All header/footer types - Default, First and Even are set identically. The only thing you should add when you set the First or Even Header/Footer of the document, is to set the property of the section that notifies the document to use different Header/Footer than the default one using one of the properties illustrated below:
     
#### __[C#] Set Different Even/Odd Header__
{{region radrichtextbox-features-headers-and-footers_3}}
	this.radRichTextBox.Document.Sections.First.HasDifferentFirstPageHeaderFooter = true;
	//or
	this.radRichTextBox.Document.HasDifferentEvenAndOddHeadersFooters = true;
{{endregion}}

Setting the Footers can be done in the same way. Here is the respective code for footers:

* Creating a Footer:

	#### __[C#] Create Footer__
	{{region radrichtextbox-features-headers-and-footers_4}}

		Footer footer = new Footer() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument is an instance of RadDocument, representing the content of the footer.
	{{endregion}}

* Setting the Footer to be used in a particular section:

    * In a non-measured document:

		#### __[C#] Set Footer of a Section__
		{{region radrichtextbox-features-headers-and-footers_5}}
			section.Footers.Default = footer;
		{{endregion}}

    * In a measured document:
		#### __[C#] Update a Footer in Measured Document__
		{{region radrichtextbox-features-headers-and-footers_6}}
			this.radRichTextBox.UpdateFooter(this.radRichTextBox.Document.Sections.First, HeaderFooterType.Default, footer);
		{{endregion}}

As for setting different footers for the first page or the even page, this is done by passing the respective parameter to the UpdateFooter() method - HeaderFooterType.First or HeaderFooterType.Even and setting the corresponding property of the document/editor.

#### __[C#] Set Different Even/Odd Footer__
{{region radrichtextbox-features-headers-and-footers_3}}
	this.radRichTextBox.Document.Sections.First.HasDifferentFirstPageHeaderFooter = true;
	//or
	this.radRichTextBox.Document.HasDifferentEvenAndOddHeadersFooters = true;
{{endregion}}

## Disabling Headers and Footers

Headers and footers are only present in Paged layout mode, so the easiest way to remove them is to change the layout mode. In case you wish to show documents in paged mode and still disable headers and footers, you can do so by removing the UI layer responsible for their visualization - `HeaderFooterLayer`.

>tip The concept of UI layers and their usage are explained in [this article]({%slug radrichtextbox-features-custom-ui-layers%}).

#### __[C#] Disable Headers and Footers__
{{region radrichtextbox-features-headers-and-footers_7}}
	class CustomUILayerBuilder : UILayersBuilder
	{
	    protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
	    {
	        base.BuildUILayersOverride(uiLayerContainer);
	        uiLayerContainer.UILayers.Remove(DefaultUILayers.HeaderFooterLayer);
	    }
	}
{{endregion}}

## Working with the Headers and Footers

The Headers and Footers can be retrieved, for example, via interating the `Sections` collection of the `Document` property of the RadRichTextBox control. Each [Section]({%slug radrichtextbox-features-document-elements-section%}#add-headers-and-footers-to-a-section) instance exposes this information via its API.

#### __[C#] Retrieving the Headers__
{{region radrichtextbox-features-headers-and-footers_8}}
	foreach (Telerik.Windows.Documents.Model.Section section in this.radRichTextBox.Document.Sections)
	{
	    if (!section.Headers.Default.IsEmpty)
	    {
	        RadDocument radDocument = new RadDocument();
	        Section section1 = new Section();
	        Paragraph paragraph = new Paragraph();
	        Span span = new Span("Default");
	        paragraph.Inlines.Add(span);
	        section.Blocks.Add(paragraph);
	
	        RadDocument document = new RadDocument();
	        document.Sections.Add(section1);
	
	        section.Headers.Default.Body = document;
	    }
	
	    if (!section.Headers.First.IsEmpty)
	    {
	        RadDocument radDocument = new RadDocument();
	        Section section1 = new Section();
	        Paragraph paragraph = new Paragraph();
	        Span span = new Span("First");
	        paragraph.Inlines.Add(span);
	        section.Blocks.Add(paragraph);
	
	        RadDocument document = new RadDocument();
	        document.Sections.Add(section1);
	
	        section.Headers.Default.Body = document;
	    }
	
	    if (!section.Headers.Even.IsEmpty)
	    {
	        RadDocument radDocument = new RadDocument();
	        Section section1 = new Section();
	        Paragraph paragraph = new Paragraph();
	        Span span = new Span("Even");
	        paragraph.Inlines.Add(span);
	        section.Blocks.Add(paragraph);
	
	        RadDocument document = new RadDocument();
	        document.Sections.Add(section1);
	
	        section.Headers.Default.Body = document;
	    }
	}
{{endregion}}

Additionally, the RadRichTextBox control exposes the `ActiveDocumentEditor` property. It provides information about the currently active editor that you can utilize to access the Headers and Footers.

>tip More information about the ActiveDocumentEditor property can be found [here]({%slug radrichtextbox-getting-started-activedocumenteditor%}).

## See Also  
 * [Section]({%slug radrichtextbox-features-document-elements-section%})  
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})