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


Break element is an inline-level flow content element, which indicates that a break should be placed at the current position. There are three types of breaks:

* __Line Break__: Breaks the current line and starts a new one.

* __Page Break__: Breaks the current page and starts a new one.

* __Column Break__: Breaks the current [section column]({%slug radrichtextbox-features-section-columns%}) and starts a new one. If the current section is not divided into columns, or the column break occurs in the last column on the current page, then the restart location for text will be the next page of the document.

## Inserting a Break

The Break elements can be used only in the context of a Paragraph element. The [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%}) exposes a collection of __Inlines__, to which the breaks can be added. __Example 1__ shows how to achieve this.

#### __[C#] Example 1: Insert a break__

{{region radrichtextbox-features-document-elements-break_0}}

	Section section = new Section();
	Paragraph paragraph = new Paragraph();
	Break br = new Break(BreakType.PageBreak);
	paragraph.Inlines.Add(br);
	section.Blocks.Add(paragraph);
	
{{endregion}}


#### __[VB.NET] Example 1: Insert a break__

{{region radrichtextbox-features-document-elements-break_1}}

    Dim section As New Section()
    Dim paragraph As New Paragraph()
    Dim break As Break = New Break(BreakType.PageBreak)
    paragraph.Inlines.Add(break)
    section.Blocks.Add(paragraph)

{{endregion}}

## Modifying a Break

The __Break__ element exposes a __BreakType__ property, which specifies the type of the break. __Example 2__ demonstrates how to change it.

#### __[C#] Example 2: Modify a break__

{{region radrichtextbox-features-document-elements-break_2}}

	br.BreakType = BreakType.LineBreak;

{{endregion}}

# See Also

 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
 * [Section]({%slug radrichtextbox-features-document-elements-section%})
 * [Span]({%slug radrichtextbox-features-document-elements-span%})
 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})
 * [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%})
