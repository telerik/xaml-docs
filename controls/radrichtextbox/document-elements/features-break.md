---
title: Break
page_title: Break
description: Break
slug: radrichtextbox-features-document-elements-break
tags: Break
published: True
position: 8
---

# Break


Break element is an inline-level flow content element which indicates that a break should be placed at the current position. There are two types of breaks:

* __Line Break__: Breaks the current line and starts a new one

* __Page Break__: Breaks the current page and starts a new one

## Inserting a Break

The Break elements can be used only in the context of a Paragraph element. The [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%}) exposes a collection of __Inlines__, to which the breaks can be added. Here is a sample code-snippet which illustrates this:

#### __C#__

{{region radrichtextbox-features-document-elements-break_0}}

	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Break br = new Break(BreakType.PageBreak);
	paragraph.Inlines.Add(br);
	section.Blocks.Add(paragraph);
	
{{ednregion}}


#### __VB.NET__

{{region radrichtextbox-features-document-elements-break_1}}

    Dim section As New Section()
    Dim paragraph As New Paragraph()
    Dim break As Break = New Break(BreakType.PageBreak)
    paragraph.Inlines.Add(break)
    section.Blocks.Add(paragraph)

{{ednregion}}

## Modifying a Break

The __Break__ element exposes a __BreakType__ property which specifies the type of the break. 

{{region radrichtextbox-features-document-elements-break_2}}

	br.BreakType = BreakType.LineBreak;

{{ednregion}}

# See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})

 * [Section]({%slug radrichtextbox-features-document-elements-section%})

 * [Span]({%slug radrichtextbox-features-document-elements-span%})

 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})

 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
