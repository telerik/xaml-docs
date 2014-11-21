---
title: RadFixedDocumentEditor
page_title: RadFixedDocumentEditor
description: RadFixedDocumentEditor
slug: radpdfprocessing-editing-radfixeddocumenteditor
tags: radfixeddocumenteditor
published: True
position: 6
---

# RadFixedDocumentEditor



__RadFixedDocumentEditor__ is a utility class aiming to allow the creation of [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%}) in a flow-like manner. The editor provides methods that enable the generation of documents which automatically flows to pages.
      

* [Creating RadFixedDocumentEditor](#creating-radfixeddocumenteditor)

* [Sections](#sections)

* [Starting New Section](#starting-new-section)

* [Paragraphs](#paragraphs)

* [Tables](#tables)

## Creating RadFixedDocumentEditor

__Example 1__ demonstrates how a RadFixedDocumentEditor instance can be created.
        

#### __[C#] Example 1: Create RadFixedDocumentEditor__

{{region radpdfprocessing-editing-radfixeddocumenteditor_0}}
    RadFixedDocumentEditor editor = new RadFixedDocumentEditor(radFixedDocument);
{{endregion}}



>__RadFixedDocumentEditor__ inherits from __IDisposable__ so it should be properly disposed when the document is created. Otherwise, some of the content may not be finished, i.e. it might not appear on the PDF document.
          

## Sections

__Section__ is a sequence of [RadFixedPages]({%slug radpdfprocessing-model-radfixedpage%}) with the same properties.
        

### SectionProperties

The section properties are responsible for the page size, margins and orientation of __RadFixedPages__ in a section. Below is the complete list of section properties.
            

* __PageSize__: The size of the pages that are part of the section.
                

* __PageMargins__: The page margins of a page.
                

* __PageRotation__: The page rotation. This is enum that can take one of the following values.
                

 * __Rotate0__: The page is not rotated. This is the default value.
                    

 * __Rotate90__: The page is rotated to 90°.
                    

 * __Rotate180__: The page is rotated to 180°.
                    

 * __Rotate270__: The page is rotated to 270°.
                    

### Starting New Section

The first section in a document starts as soon as a content is inserted to the editor. You can change the Section properties before inserting any content and they will be applied to the section that is automatically created.
            

Adding an additional section is achieved with the __InsertSectionBreak()__ method as demonstrated in __Example 2__.
            

#### __[C#] Example 2: Start a Section__

{{region radpdfprocessing-editing-radfixeddocumenteditor_1}}
    editor.InsertSectionBreak();
{{endregion}}



If you want to change the properties of the next section, make sure to do it __before__ you insert the section break. New properties are only used for newly created sections.
            

## Paragraphs

__Paragraphs__ are blocks of flowing inlines - images and text.
        

### ParagraphProperties

Similar to the section properties, paragraph has its own properties that are responsible for the way it looks.
            

* __SpacingBefore__: Represent the spacing before.
                

* __SpacingAfter__: Represents the spacing after.
                

* __LineSpacing__: The spacing between the lines.
                

* __FirstLineIndent__: The indent for the first line.
                

* __LeftIndent__: The left indent.
                

* __RightIndent__: The right indent.
                

* __BackgroundColor__: The background color.
                

* __HorizontalAlignment__: The horizontal alignment of the content.
                

### Starting New Paragraph

The first paragraph is created as soon as content is inserted in the editor. You can change paragraph properties before inserting content and when the first paragraph is created automatically, it will use the desired properties.
            

In order to start a new paragraph use the code in __Example 3__.
            

#### __[C#] Example 3: Start a Paragraph__

{{region radpdfprocessing-editing-radfixeddocumenteditor_2}}
    editor.InsertParagraph();
{{endregion}}



The result of this method is that new paragraph is started and it uses the current paragraph properties. Until a new paragraph is started, changes in the paragraph properties are not applied.
            

### Inlines

A Paragraph is built of two types of inlines - runs and images.
            

### Runs

__Run__ represents a collection of characters that have the same properties.
                

__CharacterProperties__

The character properties that are responsible for the look of the runs are listed below.
                

* __FontSize__: The font size.
                    

* __Font__: The font.
                    

* __ForegroundColor__: The foreground color.
                    

* __HighlightColor__: The highlight color.
                    

* __BaselineAlignment__: Describes how the baseline for a text-based element is positioned on the vertical axis, relative to the established baseline for text.
                    

 * __Baseline__: A baseline that is aligned at the actual baseline of the containing box.
                        

 * __Subscript__: A baseline that is aligned at the subscript position of the containing box.
                        

 * __Superscript__: A baseline that is aligned at the superscript position of the containing box.
                        

* __UnderlinePattern__: Тhe underline pattern. Two patterns are supported.
                    

 * __None__: There is no underline. This is the default value.
                        

 * __Single__: The underline is a single line.
                        

* __UnderlineColor__: The color of the underline.
                    

__Inserting a Run__

There are a number of overloads that insert a run. The code snippet in __Example 4__ inserts a a couple of new runs with specific font family, style and weight.
                

#### __[C#] Example 4: Insert Run__

{{region radpdfprocessing-editing-radfixeddocumenteditor_3}}
    editor.InsertRun("text");
    editor.InsertRun(fontFamily, "text");
{{endregion}}



There are a number of overloads that insert a run. The code snippet in __Example 5__ inserts a a couple of new runs, one of which with a specific font family.
                

The code in __Example 5__ inserts a new run and a line break after it.
                

#### __[C#] Example 5: Insert Run and Break Line__

{{region radpdfprocessing-editing-radfixeddocumenteditor_4}}
    editor.InsertLine("Line of text");
{{endregion}}



### Images

Image inline is a combination of an [ImageSource]({%slug radpdfprocessing-model-imagesource%}) object and its desired size.
                

__Inserting an Image__

You can insert image inline using one of the following methods:
                

__editor.InsertImageInline(imageSource);__

__editor.InsertImageInline(imageSource, size);__

## Tables

The __Table__ class implements the __IBlockElement__ interface and an instance of this class can be easily inserted as a new block in the document. You could insert the table using the __InsertTable()__ method like illustarted in __Example 6__. __RadFixedDocumentEditor__ takes care for positioning, measuring and splitting the table onto pages.
        

#### __[C#] Example 6: Insert Table__

{{region radpdfprocessing-editing-radfixeddocumenteditor_5}}
    editor.InsertTable(table);
{{endregion}}



Additionally you can specify the __TableLayoutType__ through RadFixedDocumentEditor's TableProperties. There are two options for the table layout:
        

* __FixedWidth__: The table width fits the available page width.
            

* __AutoFit__: The table width will be as big as needed for the fitting of its contents.
            

For more detailed information on tables follow this link to [Table]({%slug radpdfprocessing-editing-table%}) documentation article.
        

# See Also

 * [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%})

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

 * [ImageSource]({%slug radpdfprocessing-model-imagesource%})

 * [Table]({%slug radpdfprocessing-editing-table%})
