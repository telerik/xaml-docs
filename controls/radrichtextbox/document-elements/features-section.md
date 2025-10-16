---
title: Section
page_title: Section
description: Check our &quot;Section&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-section
tags: section, column
published: True
position: 2
---

# Section

The __Section__ class allows you to separate the content into sections. __Sections__ are chunks of the document that can be displayed on one or several pages.      

A __Section__ can contain only __Paragraph__ and __Table__ elements. You are also able to customize the section layout by setting its properties.      

This topic explains how to:

* [Create and Add a Section to RadDocument](#create-and-add-a-section-to-raddocument)

* [Customize a Section](#customize-a-section)

* [Add Paragraphs to a Section](#adding-paragraphs-to-a-section)

>tip To modify the document content at runtime we recommend using the [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) class when possible, instead of working with `RadDocument` directly. The document editor ensures that the document will be measured and arranged properly on each change.

## Create and add a Section to RadDocument

As explained in the [RadDocument article]({%slug radrichtextbox-features-document-elements-raddocument%}#specifics), the state of the document is essential for the methods that can be used on it.

For example, you can build a RadDocument from scratch and add Sections to it in the following way:

__Example 1: Add a Section to a Non-Measured Document__

```C#
	Section section = new Section();
	this.radRichTextBox.Document.Sections.Add(section);
```

Splitting an already measured document into two sections at the current caret position, on the other hand, can be done by inserting a section break:

__Example 2: Insert a Section Break in a Measured Document__

```C#
	this.radRichTextBox.InsertSectionBreak(SectionBreakType.NextPage);
```

The InsertSectionBreak() method accepts a parameter of type **SectionBreakType**. The possible values are:

* **SectionBreakType.NextPage**: The default value. The next section will start on the next page.

* **SectionBreakType.OddPage**: The next section will start on the next odd page.

* **SectionBreakType.EvenPage**: Analogically, the next section will start on the next even page.

* **SectionBreakType.Continuous**: The next section will start on the same page. This type of section break is useful for creating a formatting change, such as a different number of columns, on a page.

>The distribution of the document content in sections is only visible when the document is in Paged layout mode. Furthermore, the sections and section breaks can be persisted in XAML, Docx and Rtf. If you export the document to HTML or plain text, the section breaks will be lost.          

## Customize a Section

The __Section__ exposes several properties that allow you to customize the layout of the elements placed underneath it. These properties can be set directly to the section when the document is created programmatically. If the changes should be applied to the document after it has been loaded in the editor, the respective methods and commands should be used.

* __PageMargin__: Represents the margin towards the edges of the page when in __Paged__ mode.            

	__Example 3: Change the Page Margin of a Section__
	
	```C#
		//When creating a Section programmatically
		section.PageMargin = new Padding(40, 40, 30, 30);
		
		//When the section has already been added to the document
		this.editor.ChangeSectionPageMargin(new Padding(40, 40, 30, 30));
	```

	>If you would like to use the predefined margins, the **ToPadding()** method of **PageMarginTypesConverter** will help to automatically get the Padding values, which you need to set for the margins.

* __PageOrientation__: Specifies if the pages in the section should be in Portrait or Landscape mode.            

	__Example 4: Change the Page Orientation of a Section__

	```C#
		//When creating a Section programmatically
		section.PageOrientation = PageOrientation.Landscape;
		
		//When the section has already been added to the document
		this.editor.ChangeSectionPageOrientation(PageOrientation.Landscape);
	```

* **Columns**: Allows you to arrange the text in a Section into columns. More information on how to use this property is available in the [Section Columns help article]({%slug radrichtextbox-features-section-columns%}).

* __PageSize__: Specifies the size of the pages in the section. The PapertTypeConverter class and the enum PaperTypes provide convenient API and predefined sizes out of the box.            

	__Example 5: Change the Page Size of a Section__
	
	```C#
		//When creating a Section programmatically
		section.PageSize = PaperTypeConverter.ToSize(PaperTypes.A4);
		
		//When the section has already been added to the document
		this.editor.ChangeSectionPageSize(PaperTypeConverter.ToSize(PaperTypes.A4));
	```

* __LineNumbering__: Gets or sets the line numbering properties for the current Section object. For more information, check the [Line Numbering]({%slug radrichtextbox-features-line-numbering%}) topic.

### Add headers and footers to a Section

Each section has the following types of Headers and Footers - **Default** (used all through the section), **First** (used on the first page of the section) and **Even** (to be used on every even page; if set, overrides the default header/footer on all even pages of the section). Here is a how you can create a **Header**:

__Example 6: Create a Header__

```C#
	Header header = new Header() { Body = radDocument, IsLinkedToPrevious = false }; 
```

All header/footer types are set identically.

* In a non-measured document:

__Example 7: Assign the Header to a Section in a Non-Measured Document__

```C#	
	section.Headers.First = header;
```

* In a measured document:

__Example 8: Update the Header of an Existing Document__

```C#

	this.editor.UpdateHeader(this.editor.Document.Sections.First, HeaderFooterType.First, header);
```

Setting the Footers can be done in the same way.

## Adding Paragraphs to a Section

Paragraphs can be added to a section in the following ways:

* In a non-measured document:

__Example 9: Add a Paragraph to a Section in a Non-Measured Document__

```C#
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	section.Blocks.Add(paragraph);
```

* In a measured document:

__Example 10: Add a Paragraph to a Section in a Measured Document__

```C#
	this.radRichTextBox.InsertParagraph();
```

## See Also
 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})
 * [Span]({%slug radrichtextbox-features-document-elements-span%})
 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})
 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
 * [Merge Documents]({%slug radrichtextbox-features-merge-raddocumentmerger%})