---
title: Hyperlink
page_title: Hyperlink
description: Hyperlink
slug: radrichtextbox-features-document-elements-hyperlink
tags: hyperlink
published: True
---

# Hyperlink



The __Telerik.Windows.Documents.Model.Hyperlink__ class has been obsoleted with regard to the newly extended functionality of hyperlinks, allowing the following scenarios:
      

* having a hyperlink span several paragraphs;

* being able to embed all kind of elements inside hyperlinks, e.g. images, tables and table elements;

* making bookmarks in the document the targets of hyperlinks.

The classes that encapsulate the functionality of hyperlinks are [HyperlinkInfo](#hyperlinkinfo), [HyperlinkRangeStart and HyperlinkRangeEnd](#hyperlinkrangestart-and-hyperlinkrangeend).
      

[Other customization options](#othercustomizationoptions) include setting the tool tip format and detecting the click of hyperlinks.
      



## HyperlinkInfo

More often than not, you would only need to use objects of type HyperlinkInfo. HyperlinkInfo objects have the following properties:

* IsAnchor - a boolean property determining if the hyperlink points to a URL or a bookmark;

* NavigateUri - the URI of the hyperlink;

* Target - determines if the link should be opened in another window (if set to HyperlinkTargets.Blank) or in the same frame (HyperlinkTargets.Self).

For example, a link to our Silverlight MSWord demo can be inserted in the document programmatically as follows:

#### __C#__

{{region radrichtextbox-features-document-elements-hyperlink_0}}
	HyperlinkInfo info = new HyperlinkInfo()
	{
	    NavigateUri = "http://demos.telerik.com/silverlight/#RichTextBox/TelerikEditor",
	    Target = HyperlinkTargets.Blank,
	    IsAnchor = false
	};
	this.richTextBox.InsertHyperlink(info, "RichTextBox demo");
{{endregion}}



A link to a bookmark is inserted by specifying the bookmark's name as NavigateUri and setting the IsAnchor to true:

#### __C#__

{{region radrichtextbox-features-document-elements-hyperlink_1}}
	HyperlinkInfo info = new HyperlinkInfo()
	{
	   NavigateUri = "bookmark1",
	   Target = HyperlinkTargets.Self,
	   IsAnchor = true
	};
	this.richTextBox.InsertHyperlink(info, "Link to Bookmark 1");
{{endregion}}



You can also use the overloaded methods for inserting a hyperlink:

* public void __InsertHyperlink__(HyperlinkInfo hyperlinkInfo, string hyperlinkText, StyleDefinition hyperlinkStyle) - insert a hyperlink using a custom style, different from the default blue font color and single underline;
          

* public void __InsertHyperlink__(HyperlinkInfo hyperlinkInfo, IEnumerable<Inline> inlines) - insert a hyperlink which spans several different adjacent inlines, e.g. part of the hyperlink text is Bold or there is an image inside the hyperlink;
          

* public void __InsertHyperlink__(HyperlinkInfo hyperlinkInfo) - create a hyperlink from the currently selected part of the document;
          

* public void __InsertHyperlink__(HyperlinkInfo hyperlinkInfo, StyleDefinition hyperlinkStyle) - create a hyperlink from the currently selected part of the document and change the style of the text to the style passed as second argument.


Removing a hyperlink (and keeping the part of the document that the hyperlink spanned) can be done by positioning the caret in the hyperlink and invoking

#### __C#__

{{region radrichtextbox-features-document-elements-hyperlink_2}}
	this.richTextBox.RemoveHyperlink();
{{endregion}}



## HyperlinkRangeStart and HyperlinkRangeEnd

HyperlinkRangeStart and HyperlinkRangeEnd are Inline DocumentElements and can be added to the inlines of a document, if you are building the contents of a RadDocument in code-behind.

Here is an example that creates a document with a hyperlink spanning several paragraphs, including an image in one of the paragraphs:

#### __C#__

{{region radrichtextbox-features-document-elements-hyperlink_3}}
	HyperlinkRangeStart hyperlinkStart = new HyperlinkRangeStart();
	HyperlinkRangeEnd hyperlinkEnd = new HyperlinkRangeEnd();
	hyperlinkEnd.PairWithStart(hyperlinkStart);
	HyperlinkInfo hyperlinkInfo = new HyperlinkInfo() { NavigateUri = "http://telerik.com", Target = HyperlinkTargets.Blank };
	hyperlinkStart.HyperlinkInfo = hyperlinkInfo;
	RadDocument document = new RadDocument();
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Span spanBefore = new Span("Text before the image ");
	ImageInline image = new ImageInline(new Uri("/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/32/Picture.png", UriKind.Relative));
	image.Size = new Size(32, 32);
	Span spanAfter = new Span(" and some text after the image");
	paragraph.Inlines.Add(hyperlinkStart);
	paragraph.Inlines.Add(spanBefore);
	paragraph.Inlines.Add(image);
	paragraph.Inlines.Add(spanAfter);
	section.Blocks.Add(paragraph);
	Paragraph anotherParagraph = new Paragraph();
	anotherParagraph.Inlines.Add(new Span("Another paragraph here and still in hyperlink"));
	anotherParagraph.Inlines.Add(hyperlinkEnd);
	section.Blocks.Add(anotherParagraph);
	document.Sections.Add(section);
	this.richTextBox.Document = document;
{{endregion}}



The result:

![](images/RadRichTextBox_Features_LayoutElements_Hyperlinks_ImageInHyperlink.png)

You will also need to use HyperlinkRangeStart and HyperlinkRangeEnd, if you are using hyperlinks for the implementation of a custom logic and want to get all hyperlinks from the document, manipulate the properties of the HyperlinkInfo or the whole part of the document that is included in the hyperlink.

For instance, here is how you can delete all hyperlinks in the document and replace them with some text:

#### __C#__

{{region radrichtextbox-features-document-elements-hyperlink_4}}
	IEnumerable<HyperlinkRangeStart> links = this.richTextBox.Document.EnumerateChildrenOfType<HyperlinkRangeStart>();
	foreach (HyperlinkRangeStart link in links)
	{
	    this.richTextBox.Document.CaretPosition.MoveToInline(link.FirstLayoutBox as InlineLayoutBox, 0);
	    this.richTextBox.Document.Selection.SelectAnnotationRange(link);
	    this.richTextBox.Delete(false);
	    this.richTextBox.Insert("Removed hyperlink");
	}
{{endregion}}



## Other Customization Options

### __ToolTip__

By default, hyperlinks take a fixed string as a tool tip. The default format shows the URI of the hyperlink.

You have control over it using the __HyperlinkToolTipFormatString__ of RadRichTextBox, which will set the format for all hyperlinks in the document.
        

### __HyperlinkClicked__

When you click on a hyperlink, the __HyperlinkClicked__ event of __RadRichTextBox__ is fired. The sender of the event is the document element, which you have clicked, e.g. a Span, an Image, InlineUIContainer, etc. The event args on the other hand, provide the possibility to mark the event as handled and prevent the default action. Custom logic can also be implemented depending on the __HyperlinkTarget__ and __URL__, which are also visible as properties of the event args.
        

![](images/RadRichTextBox_Features_LayoutElements_Hyperlinks_HyperlinkClicked.png)

## See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

 * [Span]({%slug radrichtextbox-features-document-elements-span%})

 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
