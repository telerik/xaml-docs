---
title: Paragraph
page_title: Paragraph
description: Check our &quot;Paragraph&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-paragraph
tags: paragraph
published: True
position: 3
---

# Paragraph

The paragraph class allows you to separate the content into paragraphs. It is responsible for displaying inline elements such as __Span__, __HyperlinkRangeStart__ and __End__, __InlineImage__ etc. You are also able to configure the appearance of the paragraph by modifying its parameters.

This topic will explain you how to:

* [Use Paragraphs](#use-paragraphs)

* [Add inline elements to a Paragraph](#add-inline-elements-to-a-paragraph)

* [Customize the Paragraph](#customize-the-paragraph)

>tip To modify the document content at runtime we recommend using the [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) class when possible, instead of working with `RadDocument` directly. The document editor ensures that the document will be measured and arranged properly on each change.

## Use Paragraphs

The __Paragraph__ can be used only in the context of a [Section]({%slug radrichtextbox-features-document-elements-section%}) or a TableCell element. The section exposes a collection of Blocks, to which the paragraphs can be added. This can also be done directly in XAML.



```XAML
	<telerik:RadRichTextBox x:Name="radRichTextBox">
	    <telerik:RadRichTextBox.Document>
	        <telerik:RadDocument LayoutMode="Paged">
	            <telerik:Section>
	                <telerik:Paragraph />
	                <telerik:Paragraph />
	            </telerik:Section>
	        </telerik:RadDocument>
	    </telerik:RadRichTextBox.Document>
	</telerik:RadRichTextBox>
```



```C#
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	section.Blocks.Add( paragraph );
	RadDocument document = new RadDocument();
	document.Sections.Add(section);
	
	this.radRichTextBox.Document = document;
```



```VB.NET
	Dim section As New Section()
	Dim paragraph As New Paragraph()
	section.Blocks.Add(paragraph)
	Dim document As New RadDocument()
	document.Sections.Add(section)
	
	Me.radRichTextBox.Document = document
```

## Add inline elements to a Paragraph

To add inline elements such as Span, HyperlinkRangeStart and End, or InlineImage you have to use the Inlines collection of the Paragraph. In XAML you can directly wrap the inline elements inside the paragraph element.


```XAML
	<telerik:RadRichTextBox x:Name="radRichTextBox">
	    <telerik:RadDocument>
	        <telerik:Section>
	            <telerik:Paragraph>
	                <telerik:Span Text="Span declared in XAML" />
	            </telerik:Paragraph>
	        </telerik:Section>
	    </telerik:RadDocument>
	</telerik:RadRichTextBox>
```


```C#
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Span span = new Span("Span declared in code-behind");
	paragraph.Inlines.Add( span );
	section.Blocks.Add( paragraph );
	RadDocument document = new RadDocument();
	document.Sections.Add(section);
	
	this.radRichTextBox.Document = document;
```


```VB.NET
	Dim section As New Section()
	Dim paragraph As New Paragraph()
	Dim span As New Span("Span declared in code-behind")
	paragraph.Inlines.Add(span)
	section.Blocks.Add(paragraph)
	Dim document As New RadDocument()
	document.Sections.Add(section)
	
	Me.radRichTextBox.Document = document
```

## Customize the Paragraph

The __Paragraph__ exposes several properties that allow you to customize the layout of the elements placed underneath it. Here is a list of them:

* __FontSize__: Represents the font size of the text inside the __Paragraph__. If not explicitly set to its child elements, they inherit its value.

* __LineSpacing__: Specifies the value for the space between the lines.

* __LineSpacingType__: Specifies the type of spacing:

	* __AtLeast__: The space between the lines should equal or greater than the value of the __LineSpacing__ property.

	* __Auto__: The space between the lines is determined automatically.

	* __Exact__: The space between the lines should equal to the value of the __LineSpacing__ property.

* __LeftIndent__: Represents the size of the indent to the left size of the __Paragraph__. The indent gets applied together with the respective margins to the layout.

* __RightIndent__: Represents the size of the indent to the right size of the __Paragraph__. The indent gets applied together with the respective margins to the layout.

* __SpacingAfter__: Represents the size of the empty space after the __Paragraph__.

* __SpacingBefore__: Represents the size of the empty space before the __Paragraph__.

* __TextAlignment__: Represents the alignment of the text inside the __Paragraph__.

* __SuppressLineNumbers__: Gets or sets a boolean value indicating whether the line numbering for the current __Paragraph__ is suppressed.

## See Also  
 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
 * [Section]({%slug radrichtextbox-features-document-elements-section%})
 * [Span]({%slug radrichtextbox-features-document-elements-span%})
 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})
 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})