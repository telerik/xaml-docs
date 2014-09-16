---
title: Paragraph
page_title: Paragraph
description: Paragraph
slug: radwordsprocessing-model-paragraph
tags: paragraph
publish: True
position: 2
---

# Paragraph



The __Paragraph__ class allows you to separate the content into paragraphs. It is responsible for displaying inline
        elements such as [Run]({%slug radwordsprocessing-model-run%}), [FloatingImage]({%slug radwordsprocessing-model-floatingimage%}),
        [ImageInline]({%slug radwordsprocessing-model-imageinline%}) etc. It is also possible to configure the appearance of the paragraph by modifying
        its parameters.
      

* [Inserting a Paragraph](#inserting-a-paragraph)

* [Modifying a Paragraph](#modifying-a-paragraph)

* [Operating with a Paragraph](#operating-with-a-paragraph)

## Inserting a Paragraph

Paragraphs can be added as a child of a
          [BlockContainer](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_blockcontainerbase.html)
          element – [Section]({%slug radwordsprocessing-model-section%}), [TableCell]({%slug radwordsprocessing-model-tablecell%}),
          [Headers and Footers]({%slug radwordsprocessing-model-headers-footers%}), through the __Blocks__ collection.
        

The following code snippet creates and inserts a Paragraph to a Section.
        

#### __C#__

{{region radwordsprocessing-model-paragraph_0}}
	            Paragraph paragraph = new Paragraph(document);
	            section.Blocks.Add(paragraph);
	{{endregion}}



>tipThe parent BlockContainer element (in this case - the *section*) should belong to the same document that is
            passed to the constructor of the __Paragraph__.
          

You can add a paragraph at a specific index in the __Blocks__ collection of a __BlockContainer__
          using the __Insert()__ method. Here is how to add a paragraph at the beginning of a section:
        

#### __C#__

{{region radwordsprocessing-model-paragraph_1}}
	            Paragraph paragraph = new Paragraph(document);
	            section.Blocks.Insert(0, paragraph);
	{{endregion}}



You can also use the __AddParagraph()__ method of the __Blocks__ collection of a __BlockContainer__.
          The method creates a new __Paragraph__ instance, adds it to the container and returns it:
        

#### __C#__

{{region radwordsprocessing-model-paragraph_2}}
	            Paragraph paragraph = section.Blocks.AddParagraph();
	{{endregion}}



Inserting a new Paragraph in the document can also be achieved with the [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) class:
        

#### __C#__

{{region radwordsprocessing-model-paragraph_3}}
	            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
	            Paragraph paragraph = editor.InsertParagraph();
	{{endregion}}



## Modifying a Paragraph

__Paragraph__ exposes several properties that allow you to customize the layout of the elements placed underneath it. Here is a list
          of them:
        

* __Properties__:  Gets all paragraph properties as ParagraphProperties object. More info on how to use section properties can be
              found in [Style Properties]({%slug radwordsprocessing-concepts-style-properties%}) article.
            

* __StyleId__:  Represents the ID of the style applied on the Paragraph element.
            

* __Inlines__: Represents the inline elements in the paragraph. Exposes methods for adding a Run, an ImageInline and a FloatingImage
              elements.
            

* __FlowDirection__: Specifies the text flow direction. The default value is LeftToRight.
            

* __TextAlignment__: Represents the alignment of the text inside the Paragraph.
            

* __Spacing__: Defines the Paragraph spacing.
            

* __KeepOnePage__: Indicates if the Paragraph should be rendered on one page when the document is shown in page view mode.
            

* __KeepWithNextParagraph__: Indicates if the Paragraph should be rendered at least partly on the same page with the following
              paragraph when this is possible and when the document is shown in page view mode.
            

* __OutlineLevel__: Defines the level of the Paragraph in TOC field. The default value is Level9 – no level.
            

* __ApplyEastAsianLineBreakingRules__: Specifies whether East-Asian line breaking rules are applied to the Paragraph.
            

* __PageBreakBefore__: Specifies if the Paragraph should be rendered on a new page when the document is shown in page view mode.
            

* __Borders__: Defines the borders of the Paragraph.
            

* __ContextualSpacing__: Defines whether spacing before/after are ignored when preceding/following paragraph has same paragraph style.
            

* __MirrorIndents__: Defines whether left and right indents should be swapped on odd pages.
            

* __Indentation__: Defines a set of indentations which can be applied to a Paragraph element through a ParagraphIndentation object.
              __ParagraphIndentation__ is a composite one and contains the following properties:
            

* __FirstLineIndent__: Indicates the additional indentation which is applied to the first line of the paragraph.
                

* __HangingIndent__: Specifies a value which is removed from the indentation of the first line of the paragraph, by
                  moving the indentation on the first line back towards the beginning of the direction of text flow.
                

* __LeftIndent__: Indicates the indentation which is applied to the left side of the whole paragraph.
                

* __RightIndent__: Indicates the indentation which is applied to the right side of the whole paragraph.
                

* __Shading__: Represents the shading applied to the paragraph. It is a composite object and is read-only.
              You can obtain the following properties from it:
            

* __BackgroundColor__: Specifies the background color for the shading.
                

* __PatternColor__: Specifies the pattern color for the shading.
                

* __Pattern__: Specifies the pattern which is used to lay the pattern color over the background color for the shading.
                

* __AllowOverflowPunctuation__: Defines whether the last punctuation character on a line can overflow in paragraph margin/indent.
            

## Operating with a Paragraph

You can add inline elements to a __Paragraph__ instance.
        

### Adding a Run

The following code snippet adds a run to an existing paragraph:
            

#### __C#__

{{region radwordsprocessing-model-paragraph_4}}
	            Run run = paragraph.Inlines.AddRun();
	{{endregion}}



For more information about __Run__ element, you can read [this article]({%slug radwordsprocessing-model-run%}).
            

### Adding an ImageInline

The following code snippet adds an inline image to an existing paragraph:
            

#### __C#__

{{region radwordsprocessing-model-paragraph_5}}
	            ImageInline imageInline = paragraph.Inlines.AddImageInline();
	{{endregion}}



For more information about __ImageInline__ element, you can read [this article]({%slug radwordsprocessing-model-imageinline%}).
            

### Adding a FloatingImage

The following code snippet adds a floating image to an existing paragraph:
            

#### __C#__

{{region radwordsprocessing-model-paragraph_6}}
	            FloatingImage floatingImage = paragraph.Inlines.AddFloatingImage();
	{{endregion}}



For more information about __ImageInline__ element, you can read [this article]({%slug radwordsprocessing-model-floatingimage%}).
            

# See Also[Paragraph API Reference](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_flow_model_paragraph.html)

 * [Section]({%slug radwordsprocessing-model-section%})

 * [TableCell]({%slug radwordsprocessing-model-tablecell%})

 * [Headers and Footers]({%slug radwordsprocessing-model-headers-footers%})

 * [Run]({%slug radwordsprocessing-model-run%})
