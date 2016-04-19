---
title: Section
page_title: Section
description: Section
slug: radrichtextbox-features-document-elements-section
tags: section
published: True
position: 2
---

# Section



The __Section__ class allows you to separate the content into sections. __Sections__ are chunks of the document that can be displayed on one or several pages.
      

A __Section__ can contain only __Paragraph__ and __Table__ elements. You are also able to customize the section layout by setting its properties.
      

This topic will explain you how to:

* [Create and Add a Section to RadDocument](#create-and-add-a-section-to-raddocument)

* [Customize a Section](#customize-a-section)

* [Add Paragraphs to a Section](#adding-paragraphs-to-a-section)

## Create and add a Section to RadDocument

As explained in the [RadDocument article]({%slug radrichtextbox-features-document-elements-raddocument%}#specifics), the state of the document is essential for the methods that can be used on it.

For example, you can build a RadDocument from scratch and add Sections to it in the following way:

#### __[C#] Example 1: Add a Section to a Non-Measured Document__

{{region radrichtextbox-features-document-elements-raddocument_0}}
	Section section = new Section();
	this.radRichTextBox.Document.Sections.Add(section);
{{endregion}}



Splitting an already measured document into two sections at the current caret position, on the other hand, can be done by inserting a section break:

#### __[C#] Example 2: Insert a Section Break in a Measured Document__

{{region radrichtextbox-features-document-elements-raddocument_1}}
	this.radRichTextBox.InsertSectionBreak(SectionBreakType.NextPage);
{{endregion}}


The InsertSectionBreak() method accept a parameter of type **SectionBreakType**. The possible values are:

* **SectionBreakType.NextPage**: The default value. The next section will start on the next page.

* **SectionBreakType.OddPage**: The next section will start on the next odd page.

* **SectionBreakType.EvenPage**: Analogically, the next section will start on the next even page.

>The distribution of the document content in sections is only visible when the document is in Paged layout mode. Furthermore, the sections and section breaks can be persisted in XAML, Docx and Rtf. If you export the document to HTML or plain text, the section breaks will be lost.
          

## Customize a Section

The __Section__ exposes several properties that allow you to customize the layout of the elements placed underneath it. These properties can be set directly to the section when the document is created programmatically. If the changes should be applied to the document after it has been loaded in the editor, the respective methods and commands should be used.

Here is a list of these properties:
        

* __PageMargin__: Represents the margin towards the edges of the page when in __Paged__ mode.
            

	#### __[C#] Example 3: Change the Page Margin of a Section__
	
	{{region radrichtextbox-features-document-elements-section_7}}
		//When creating a Section programmatically
		section.PageMargin = new Padding(40, 40, 30, 30);
		
		//When the section has already been added to the document
		this.editor.ChangeSectionPageMargin(new Padding(40, 40, 30, 30));
	{{endregion}}



* __PageOrientation__: Specifies if the pages in the section should be in Portrait or Landscape mode.
            

	#### __[C#] Example 4: Change the Page Orientation of a Section__

	{{region radrichtextbox-features-document-elements-section_8}}
		//When creating a Section programmatically
		section.PageOrientation = PageOrientation.Landscape;
		
		//When the section has already been added to the document
		this.editor.ChangeSectionPageOrientation(PageOrientation.Landscape);
	{{endregion}}



* __PageSize__: Specifies the size of the pages in the section. The PapertTypeConverter class and the enum PaperTypes provide convenient API and predefined sizes out of the box.
            

	#### __[C#] Example 5: Change the Page Size of a Section__
	
	{{region radrichtextbox-features-document-elements-section_9}}
		//When creating a Section programmatically
		section.PageSize = PaperTypeConverter.ToSize(PaperTypes.A4);
		
		//When the section has already been added to the document
		this.editor.ChangeSectionPageSize(PaperTypeConverter.ToSize(PaperTypes.A4));
	{{endregion}}



### Add headers and footers to a Section

Each section has the following types of Headers and Footers - **Default** (used all through the section), **First** (used on the first page of the section) and **Even** (to be used on every even page; if set, overrides the default header/footer on all even pages of the section). Here is a how you can create a **Header**:

#### __[C#] Example 6: Create a Header__

{{region radrichtextbox-features-document-elements-section_2}}
	Header header = new Header() { Body = radDocument, IsLinkedToPrevious = false }; 
{{endregion}}

All header/footer types are set identically.

   * In a non-measured document:

	#### __[C#] Example 7: Assign the Header to a Section in a Non-Measured Document__
	
	{{region radrichtextbox-features-document-elements-section_3}}
	
		section.Headers.First = header;
	{{endregion}}



   * In a measured document:

	#### __[C#] Example 8: Update the Header of an Existing Document__
	
	{{region radrichtextbox-features-document-elements-section_4}}
	
		this.editor.UpdateHeader(this.editor.Document.Sections.First, HeaderFooterType.First, header);
	{{endregion}}

Setting the Footers can be done in the same way.

## Adding Paragraphs to a Section

Paragraphs can be added to a section in the following ways:

   * In a non-measured document:
	
	#### __[C#] Example 9: Add a Paragraph to a Section in a Non-Measured Document__
	
	{{region radrichtextbox-features-document-elements-section_5}}
		Section section = new Section();
		Paragraph paragraph = new Paragraph();
		section.Blocks.Add(paragraph);
	{{endregion}}



   * In a measured document:
	
	#### __[C#] Example 10: Add a Paragraph to a Section in a Measured Document__
	
	{{region radrichtextbox-features-document-elements-section_6}}
		this.radRichTextBox.InsertParagraph();
	{{endregion}}



# See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})

 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

 * [Span]({%slug radrichtextbox-features-document-elements-span%})

 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})

 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
