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
      

* having a hyperlink which spans several paragraphs;

* being able to embed all kind of elements inside hyperlinks, e.g. images, tables and table elements;

* making bookmarks in the document the targets of hyperlinks.

The classes that encapsulate the functionality of hyperlinks are [HyperlinkInfo](#hyperlinkinfo), [HyperlinkRangeStart and HyperlinkRangeEnd](#hyperlinkrangestart-and-hyperlinkrangeend).
      

You can also use the exposed [customization options](#othercustomizationoptions) for setting the tool tip format and detecting the click of hyperlinks.
      



## HyperlinkInfo

More often than not, you would only need to use objects of type HyperlinkInfo. HyperlinkInfo objects have the following properties:

* **IsAnchor**: A boolean property determining if the hyperlink points to a URL or a bookmark;

* **NavigateUri**: The URI of the hyperlink;

* **Target**: Determines if the link should be opened in another window (if set to HyperlinkTargets.Blank) or in the same frame (HyperlinkTargets.Self).


#### __[C#] Example 1: Inserting a hyperlink in a document programmatically__

{{region radrichtextbox-features-document-elements-hyperlink_0}}
	HyperlinkInfo info = new HyperlinkInfo()
	{
	    NavigateUri = "https://demos.telerik.com/silverlight/#RichTextBox/TelerikEditor",
	    Target = HyperlinkTargets.Blank,
	    IsAnchor = false
	};
	this.radRichTextBox.InsertHyperlink(info, "RichTextBox demo");
{{endregion}}



A link to a bookmark is inserted by specifying the bookmark's name as **NavigateUri** and setting the **IsAnchor** to *true*.

#### __[C#] Example 2:  Inserting a hyperlink pointing to a bookmark in a document programmatically__

{{region radrichtextbox-features-document-elements-hyperlink_1}}

	HyperlinkInfo info = new HyperlinkInfo()
	{
	   NavigateUri = "bookmark1",
	   Target = HyperlinkTargets.Self,
	   IsAnchor = true
	};
	this.radRichTextBox.InsertHyperlink(info, "Link to Bookmark 1");
{{endregion}}



You can also use the overloaded methods for inserting a hyperlink:
         

* public void __InsertHyperlink(HyperlinkInfo hyperlinkInfo, IEnumerable&lt;Inline&gt; inlines)__: Inserts a hyperlink which spans several different adjacent inlines, e.g. part of the hyperlink text is Bold or there is an image inside the hyperlink;
          

* public void __InsertHyperlink(HyperlinkInfo hyperlinkInfo)__: Creates a hyperlink from the currently selected part of the document;


Removing a hyperlink (and keeping the part of the document that the hyperlink spanned) can be done by positioning the caret in the hyperlink and invoking the method dedicated to do that.

#### __[C#] Example 3: Remove a hyperlink__

{{region radrichtextbox-features-document-elements-hyperlink_2}}

	this.radRichTextBox.RemoveHyperlink();
{{endregion}}



## HyperlinkRangeStart and HyperlinkRangeEnd

HyperlinkRangeStart and HyperlinkRangeEnd are Inline DocumentElements and can be added to the inlines of a document, if you are building the contents of a RadDocument in code-behind.

#### __[C#] Example 4: Add hyperlink that spans on multiple document elements__

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
	this.radRichTextBox.Document = document;
{{endregion}}



The result:

![Hyperlink spanning on an image](images/RadRichTextBox_Features_LayoutElements_Hyperlinks_ImageInHyperlink.png)

You will also need to use **HyperlinkRangeStart** and **HyperlinkRangeEnd** if you are using hyperlinks for the implementation of a custom logic and want to get all hyperlinks from the document, manipulate the properties of the **HyperlinkInfo** or the whole part of the document that is included in the hyperlink.

#### __[C#] Example 5: Delete all hyperlinks in a document and replace them with text__

{{region radrichtextbox-features-document-elements-hyperlink_4}}

	IEnumerable<HyperlinkRangeStart> links = this.radRichTextBox.Document.EnumerateChildrenOfType<HyperlinkRangeStart>();
	foreach (HyperlinkRangeStart link in links)
	{
	    this.radRichTextBox.Document.CaretPosition.MoveToInline(link.FirstLayoutBox as InlineLayoutBox, 0);
	    this.radRichTextBox.Document.Selection.SelectAnnotationRange(link);
	    this.radRichTextBox.Delete(false);
	    this.radRichTextBox.Insert("Removed hyperlink");
	}
{{endregion}}



## Other Customization Options

### __ToolTip__

By default, hyperlinks take a fixed string as a tool tip. The default format shows the URI of the hyperlink.

You have control over it using the __HyperlinkToolTipFormatString__ property of RadRichTextBox, which will set the format for all hyperlinks in the document.
        

### __HyperlinkClicked__

When you click on a hyperlink, the __HyperlinkClicked__ event of __RadRichTextBox__ is fired. The sender of the event is the document element, which the user has clicked on, e.g. a Span, an Image, InlineUIContainer, etc. The event args on the other hand, provide the possibility to mark the event as handled and prevent the default action. Custom logic can also be implemented depending on the __HyperlinkTarget__ and __URL__, which are also visible as properties of the event args.
        

![Handling HyperlinkClicked event of RadRichTextBox](images/RadRichTextBox_Features_LayoutElements_Hyperlinks_HyperlinkClicked.png)


### Styling a Hyperlink 

By default, when the users insert a hyperlink in RadRichTextBox, it is styled with the built-in Hyperlink style. If you would like to change the default appearance of the hyperlinks in a document, you can do so by modifying the style.

>For more information about the styles in RadRichTextBox, check the [Styles]({%slug radrichtextbox-features-styles%}) topic.

#### [C#] Example 6: Change the default hyperlink style

{{region radrichtextbox-features-document-elements-hyperlink_4}}
	
	StyleDefinition hyperlinkStyle = this.radRichTextBox.Document.StyleRepository[RadDocumentDefaultStyles.HyperlinkStyleName];
	hyperlinkStyle.SpanStyle.FontSize = 20; 
	hyperlinkStyle.SpanStyle.ForeColor = Colors.Green;
	hyperlinkStyle.SpanStyle.UnderlineDecoration = UnderlineTypes.None;
{{endregion}}

Here is how the customized style looks like:

![Custom style for hyperlink in RadRichTextBox](images/RadRichTextBox_Features_LayoutElements_Hyperlinks_CustomStyle.png)

## See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

 * [Span]({%slug radrichtextbox-features-document-elements-span%})

 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
