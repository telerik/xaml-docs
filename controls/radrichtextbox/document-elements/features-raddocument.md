---
title: RadDocument
page_title: RadDocument
description: RadDocument
slug: radrichtextbox-features-document-elements-raddocument
tags: raddocument
published: True
position: 1
---

# RadDocument



__RadDocument__ is the root element for __RadRichTextBox's__ content. It holds the collection of __Sections__ defined for the __RadRichTextBox__ content. It also allows you to configure the appearance of its child elements.
      

This topic will explain how you can customize the contents of the RadDocument.

* [Customizing a RadDocument](#customize-the-contents-of-raddocument)

* [Specifics](#specifics)

* [Adding Sections to a RadDocument](#adding-sections-to-raddocument)

## Customize the contents of RadDocument

__RadDocument__ exposes several properties that allow you to customize the layout of the elements placed underneath it. Here is a list of them:
        

* __LayoutMode__ - specifies whether the page should be in __Paged__, __Flow__ or __FlowNoWrap__ layout mode. To learn more about layout modes read   [
              here.
            ]({%slug radrichtextbox-features-layout-modes%})

* __DefaultPageLayoutSettings__ - this property is of type __PageLayoutSettings__. The __PageLayoutSettings__ class exposes the following properties:
            

* __Height__ - represents the height of the page.
              

* __Width__ - represents the width of the page.
              Here is an example:

#### __XAML__

{{region radrichtextbox-features-document-elements-raddocument_0}}
	<telerik:RadRichTextBox x:Name="radRichTextBox" LayoutMode="Paged">
	    <telerik:RadDocument DefaultPageLayoutSettings="600,800" />
	</telerik:RadRichTextBox>
	{{endregion}}



>The __DefaultPageLayoutSettings__ get applied only when Paged layout mode is used.
                  

* __SectionDefaultPageMargin__ - defines the default margin for each of the sections in the RadDocument. To assign different margins for each of the sections use the respective property of the __Section__class.
          

* __ParagraphDefaultSpacingAfter__ - defines the default spacing after for each of the paragraphs in the __RadDocument__. To assign different spacing after for each of the paragraphs use the respective property of the __Paragraph__ class.
          

* __ParagraphDefaultSpacingBefore__ - defines the default spacing before for each of the paragraphs in the __RadDocument__. To assign different spacing before for each of the paragraphs use the respective property of the __Paragraph__ class.
          

* __LineSpacing__ - specifies the value for the space between the lines.
          

* __LineSpacingType - specifies the type of spacing:__

* __AtLeast -__ the space between the lines should equal or greater than the value of the __LineSpacing__ property.
              

* __Auto -__ the space between the lines is determined automatically.
              

* __Exact -__ the space between the lines should equal to the value of the __LineSpacing__ property__.__

* __ShowFormattingSymbols__ - indicates whether the formatting symbols should be displayed or not.
          

## Specifics

The first time a __RadDocument__ is shown inside a __RadRichTextBox__ in the Visual Tree, it is measured by the framework and arranges its children.
      This is the moment when the layout cycle is completed, each of the document elements calculates its size and arranges its children.

As the two states of the document - measured and not measured are too diffrent, distinct methods for manipulating the content of the document should be used before the document is measured and 
      after the first time that it is shown in the editor.

## Adding Sections to RadDocument

As explained in the previous section, the state of the document is essential for the methods that can be used on it.

For example, you can build a RadDocument from scratch and add Sections to it in the following way:

#### __CS__

{{region radrichtextbox-features-document-elements-raddocument_0}}
	Section section = new Section();
	this.radRichTextBox.Document.Sections.Add(section);
	{{endregion}}



Splitting an already measured document into two sections at the current caret position, on the other hand, can be done by inserting a section break:

#### __CS__

{{region radrichtextbox-features-document-elements-raddocument_1}}
	this.radRichTextBox.InsertSectionBreak(SectionBreakType.NextPage);
	{{endregion}}



You can also specify the position at which the section break should be inserted and its style:

#### __CS__

{{region radrichtextbox-features-document-elements-raddocument_2}}
	this.editor.Document.InsertSectionBreak(this.editor.Document.CaretPosition, this.editor.CurrentEditingStyle, SectionBreakType.NextPage);
	{{endregion}}



Both methods accept a parameter of type SectionBreakType. The possible values are:

* SectionBreakType.NextPage - the default value. The next section will start on the next page.

* SectionBreakType.OddPage - the next section will start on the next odd page.

* SectionBreakType.EvenPage - analogically, the next section will start on the next even page.

>The distribution of the document content in sections is only visible when the document is in Paged layout mode.
         Furthermore, the sections and section breaks can be persisted in XAML, docx and RTF. If you export the document to HTML or plain text, the section breaks will be lost.

# See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

 * [Span]({%slug radrichtextbox-features-document-elements-span%})

 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})

 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
