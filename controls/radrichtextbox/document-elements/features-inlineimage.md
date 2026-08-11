---
title: ImageInline
page_title: ImageInline
description: Check our &quot;ImageInline&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-inlineimage
tags: Image,Inline
published: True
position: 5
---

# ImageInline

The __ImageInline__ class allows images to be displayed inside the document. The __ImageInline__ can only be used in the context of a __Paragraph__ class. As it is an inline element, it gets placed after the previous inline element until the end of the line. If there is no space left, the element will be wrapped on the next line.

This topic will explain you how to use the __ImageInline__ element.

>tip To modify the document content at runtime we recommend using the [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) class when possible, instead of working with `RadDocument` directly. The document editor ensures that the document will be measured and arranged properly on each change.

## Supported Image Extensions

With **RadRichTextBox**, you can work with images from the following file formats:

* `JPG`
* `JPEG`
* `PNG`
* `BMP`
* `TIFF`
* `TIF`
* `GIF`
* `ICO`
* `ICON`
* `WMF`
* `EMF`

## Add in XAML

Here is an example of an __ImageInline__ element used in XAML at design time.



<snippet id='radrichtextbox-document-elements-features-inlineimage-block_1-xaml' />

## Add in Code Behind

Here is an example of how to add an __ImageInline__ element in the code behind.



<snippet id='radrichtextbox-document-elements-features-inlineimage-block_2-cs' />
<snippet id='radrichtextbox-document-elements-features-inlineimage-block_3-vb' />

## Add via UI

Here is an example of how to allow the user to select an image and add it to the document. For that purpose a __RadButton__ and an __OpenFileDialog__ are used. When the file stream from the __OpenFileDialog__ gets obtained, it's passed to the __InsertImage()__ API method of the __RadRichTextBox__. This method takes as an argument the extension of the image, which can be again obtained from the __FileInfo__ object. After calling the __InsertImage()__ method, the image will appear in the document with its default width and height.



<snippet id='radrichtextbox-document-elements-features-inlineimage-block_4-xaml' />



<snippet id='radrichtextbox-document-elements-features-inlineimage-block_5-cs' />
<snippet id='radrichtextbox-document-elements-features-inlineimage-block_6-vb' />

## See Also  
 * [Editing Images]({%slug radrichtextbox-features-editing-images%}) 
 * [Floating Images]({%slug radrichtextbox-features-document-elements-floatingimage%})
 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
 * [Section]({%slug radrichtextbox-features-document-elements-section%})
 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})
 * [Span]({%slug radrichtextbox-features-document-elements-span%})
 * [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%})