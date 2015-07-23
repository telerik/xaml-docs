---
title: ImageInline
page_title: ImageInline
description: ImageInline
slug: radwordsprocessing-model-imageinline
tags: imageinline
published: True
position: 8
---

# ImageInline



__ImageInline__ element is an inline-level flow content element intended to contain an image object.
      

* [Inserting an ImageInline](#inserting-an-imageinline)

* [Modifying an ImageInline](#modifying-an-imageinline)

* [Exporting an ImageInline](#exporting-an-imageinline)

## Inserting an ImageInline

You can use the following code snippet to create an ImageInline and add it to a [Paragraph]({%slug radwordsprocessing-model-paragraph%}):
        

#### __C#__

{{region radwordsprocessing-model-imageinline_0}}
    ImageInline imageInline = new ImageInline(document);
    paragraph.Inlines.Add(imageInline);
{{endregion}}



>tipThe parent __Paragraph__ should belong to the same document that is passed to the constructor of the __ImageInline__.
          

You can add an image at a specific index in the __Inlines__ collection of a paragraph using the __Insert()__ method. Here is how to add an ImageInline at the beginning of a paragraph:
        

#### __C#__

{{region radwordsprocessing-model-imageinline_1}}
    ImageInline imageInline = new ImageInline(document);
    paragraph.Inlines.Insert(0, imageInline);
{{endregion}}



You can also use the __AddImageInline()__ method of the __Inlines__ collection of a paragraph. The method creates a new ImageInline, adds it to the paragraph and returns it.
        

#### __C#__

{{region radwordsprocessing-model-imageinline_2}}
    ImageInline imageInline = paragraph.Inlines.AddImageInline();
{{endregion}}



Inserting __ImageInline__ element in RadFlowDocument can also be achieved with [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}).
        

#### __C#__

{{region radwordsprocessing-model-imageinline_3}}
    RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);

    using (Stream stream = this.GetResourceStream("Telerik_logo.png"))
    {
        editor.InsertImageInline(stream, "png", new Size(118, 28));
    }
{{endregion}}



## Modifying an ImageInline

The __ImageInline__ element exposes the following properties:
        

* __Image__: Represents the image object that is contained in the ImageInline. It is a read-only composite object that contains the properties listed below:

    * __ImageSource__: Specifies the image source that is visualized in the image object.

    * __Name__: Represents the name of the image.

    * __Width__: The width of the image.

    * __Height__: The height of the image.

    * __IsHorizontallyFlipped__: Specifies whether the image is horizontally flipped.

    * __IsVerticallyFlipped__: Specifies whether the image is vertically flipped.

    * __RotationAngle__: Specifies the rotation angle of the image.
                

## Exporting an ImageInline

This section will explain the behavior of the __InlineImage.Size__ property and how the image sizes are exported to the supported formats.

* __Insert image without specifying its size__
	* Model: Size will be Size.Empty.
	* Export to DOCX: Size will be decoded
	* Export to RTF: Size will be decoded
	* Export HTML: Width and height attributes will not be exported


* __Insert image and set its size to Size.Empty__
	* Model: Size will be Size.Empty
	* Export to DOCX: Size will be (1,1)
	* Export to RTF: Size will be (1,1)
	* Export to HTML: Width and height attributes will not be exported

* __Inserting image without specifying its size and obtain its size later (through the property getter)__
	* Model: Size will be decoded




# See Also

 * [ImageInline API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_shapes_imageinline.html)

 * [Document model]({%slug radwordsprocessing-model%})

 * [FloatingImage]({%slug radwordsprocessing-model-floatingimage%})

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})
