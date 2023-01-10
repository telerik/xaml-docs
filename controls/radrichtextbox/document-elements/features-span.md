---
title: Span
page_title: Span
description: Check our &quot;Span&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-span
tags: span
published: True
position: 4
---

# {{ site.framework_name }} RadRichTextBox Span



The __Span__ class represents an inline object that allows you to display formatted text. The __Spans__ can only be used in the context of a __Paragraph__ class. As the spans are inline elements they get placed one after another and the text inside them gets wrapped to the next line if the space is insufficient.

This topic will explain you how to:

* [Use Spans](#use-spans)

* [Add Text to a Span](#add-text-to-a-span)

* [Customize a Span](#customize-a-span)

## Use Spans

The __Spans__ can be used only in the context of the [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%}) element. The __Paragraph__ exposes a collection of Inlines, to which the spans can be added. This can also be done directly in XAML.

#### __XAML__

{{region radrichtextbox-features-document-elements-span_0}}
	<telerik:RadRichTextBox x:Name="radRichTextBox">
	    <telerik:RadDocument>
	        <telerik:Section>
	            <telerik:Paragraph>
	                <telerik:Span Text="Span declared in XAML" />
	            </telerik:Paragraph>
	        </telerik:Section>
	    </telerik:RadDocument>
	</telerik:RadRichTextBox>
{{endregion}}



#### __C#__

{{region radrichtextbox-features-document-elements-span_1}}
	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Span span = new Span("Span declared in code-behind");
	paragraph.Inlines.Add( span );
	section.Blocks.Add( paragraph );
	this.radRichTextBox.Document.Sections.Add( section );
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-document-elements-span_2}}
	Dim section As New Section()
	Dim paragraph As New Paragraph()
	Dim span As New Span("Span declared in code-behind")
	paragraph.Inlines.Add(span)
	section.Blocks.Add(paragraph)
	Me.radRichTextBox.Document.Sections.Add(section)
{{endregion}}



## Add Text to a Span

To specify the text in the __Span__ you can use its __Text__ property.

#### __XAML__

{{region radrichtextbox-features-document-elements-span_3}}
	<telerik:Span Text="Thank you for choosing Telerik RadRichTextBox!" />
{{endregion}}



#### __C#__

{{region radrichtextbox-features-document-elements-span_4}}
	Span span = new Span();
	span.Text = "Thank you for choosing Telerik RadRichTextBox!";
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-document-elements-span_5}}
	Dim span As New Span()
	span.Text = "Thank you for choosing Telerik RadRichTextBox!"
{{endregion}}



## Customize a Span

The __Span__ exposes several properties that allow you to customize the layout of the elements placed underneath it. Here is a list of them:

* __BaselineAlignment__ - indicates whether the text is __Baseline__, __Subscript__ or __Superscript__.

* __FontFamily__ - represents the name of the text's font.

* __FontSize__ - represent the size of the text.

* __FontStyle__ - indicates whether the text should have its style set to italic or to normal.

* __FontWeight__ - represents the value for the text's weight.

* __ForeColor__ - represents the foreground color for the text.

* __HighlightColor__ - represents the background color for the text.

* __Strikethrough__ - indicates whether the text should be stroke through.

* __UnderlineDecoration__ - indicates whether the text should be underlined.

## See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})

 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})

 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
