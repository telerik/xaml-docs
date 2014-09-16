---
title: Headers and Footers
page_title: Headers and Footers
description: Headers and Footers
slug: radrichtextbox-features-headers-and-footers
tags: headers,and,footers
publish: True
position: 8
---

# Headers and Footers



__RadRichTextBox__ supports Headers and Footers in its document when in Paged [layout mode]({%slug radrichtextbox-features-layout-modes%}).
      

>Note that Headers and Footers are not persisted when exporting with HtmlFormatProvider
          You can read more about this [here]({%slug radrichtextbox-features-import-export%})

The topic contains the following sections:

* [Header Footer Types](Header_Footer_Types)

* [Customizing Headers And Footers](Customizing_Headers_And_Footers)

* [Disabling Headers and Footers](Disabling_Headers_and_Footers)

## Header Footer Types

The Headers and Footers are properties of a Section and each section in the document can have the following types of Headers and Footers:

* __Default__ - used all through the section;
            

* __First__ - used on the first page of the section only;
            

* __Even__ - to be used on every even page.
            

## Customizing Headers and Footers

Here is an example how you can create a Header: 

#### __C#__

{{region radrichtextbox-features-headers-and-footers_0}}
	Header header = new Header() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument is an instance of RadDocument, representing the content of a Header, 
	                                                                                 //typically contains a few paragraphs
	{{endregion}}



When it comes to using a Header created in this manner, this depends on the state of the document - if it has been measured or not.

* In a non-measured document, which you are building in code-behind, you can set the Default page Header of a section in the following way:

#### __C#__

{{region radrichtextbox-features-headers-and-footers_1}}
	section.Headers.Default = header;
	{{endregion}}



* In a measured document (a document that has been previewed in the editor), you can change the Default page header of the first section like this:

#### __C#__

{{region radrichtextbox-features-headers-and-footers_2}}
	this.editor.UpdateHeader(this.editor.Document.Sections.First, HeaderFooterType.Default, header);
	{{endregion}}



All header/footer types - Default, First and Even are set identically. The only thing you should add when you set the First or Even Header/Footer of the document,
          is to set the property of the section that notifies the document to use different Header/Footer than the default one using one of the following properties:
        

#### __C#__

{{region radrichtextbox-features-headers-and-footers_3}}
	this.editor.Document.Sections.First.HasDifferentFirstPageHeaderFooter = true;
	//or
	this.editor.Document.HasDifferentEvenAndOddHeadersFooters = true;
	{{endregion}}



Setting the Footers can be done in the same way. Here is the respective code for footers:

* Creating a Footer:

#### __C#__

{{region radrichtextbox-features-headers-and-footers_4}}
	Footer header = new Footer() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument is an instance of RadDocument, representing the content of the footer, 
	{{endregion}}



* Setting the Footer to be used in a particular section:

* In a non-measured document:

#### __C#__

{{region radrichtextbox-features-headers-and-footers_5}}
	section.Footers.Default = footer;
	{{endregion}}



* In a measured document:

#### __C#__

{{region radrichtextbox-features-headers-and-footers_6}}
	this.editor.UpdateFooter(this.editor.Document.Sections.First, HeaderFooterType.Default, footer);
	{{endregion}}



As for setting different footers for the first page or the even page, this is done by passing the respective parameter to the UpdateFooter method - HeaderFooterType.First or HeaderFooterType.Even and setting the corresponding property of the document/editor:

#### __C#__

{{region radrichtextbox-features-headers-and-footers_3}}
	this.editor.Document.Sections.First.HasDifferentFirstPageHeaderFooter = true;
	//or
	this.editor.Document.HasDifferentEvenAndOddHeadersFooters = true;
	{{endregion}}



## Disabling Headers and Footers

Headers and footers are only present in Paged layout mode, so the easiest way to remove them is to change the layout mode. In case you wish
          to show documents in paged mode and still disable headers and footers, you can do so by removing the UI layer responsible for their visualization - __HeaderFooterLayer__.
        

>tipThe concept of UI layers and their usage are explained in [this article]({%slug radrichtextbox-features-custom-ui-layers%}).
          

#### __C#__

{{region radrichtextbox-features-headers-and-footers_7}}
	class CustomUILayerBuilder : UILayersBuilder
	{
	    protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
	    {
	        this.BuildUILayersOverride(uiLayerContainer);
	        uiLayerContainer.UILayers.Remove(DefaultUILayers.HeaderFooterLayer);
	    }
	}
	{{endregion}}



# See Also

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
