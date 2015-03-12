---
title: FloatingImage
page_title: FloatingImage
description: FloatingImage
slug: radwordsprocessing-model-floatingimage
tags: floatingimage
published: True
position: 9
---

# FloatingImage



__FloatingImage__ is an inline-level anchor flow document element linked with a floating image object.
      

* [Inserting a FloatingImage](#inserting-a-floatingimage)

* [Modify an FloatingImage](#modify-an-floatingimage)

## Inserting a FloatingImage

The following code snippet creates a FloatingImage and adds it to a [Paragraph]({%slug radwordsprocessing-model-paragraph%}).
        

#### __C#__

{{region radwordsprocessing-model-floatingimage_0}}
    FloatingImage floatingImage = new FloatingImage(document);
    paragraph.Inlines.Add(floatingImage);
{{endregion}}



>tipThe parent __Paragraph__ should belong to the same document that is passed to the constructor of the __FloatingImage__.
          

You can add an image at a specific index in the __Inlines__ collection of a paragraph using the __Insert()__ method. Here is how to add a FloatingImage at the beginning of a paragraph:
        

#### __C#__

{{region radwordsprocessing-model-floatingimage_1}}
    FloatingImage floatingImage = new FloatingImage(document);
    paragraph.Inlines.Insert(0, floatingImage);
{{endregion}}



You can also use the __AddFloatingImage()__ method of the __Inlines__ collection of a paragraph. The method creates a new __FloatingImage__, adds it to the paragraph and returns it.
        

#### __C#__

{{region radwordsprocessing-model-floatingimage_2}}
    FloatingImage floatingImage = paragraph.Inlines.AddFloatingImage();
{{endregion}}



Inserting __FloatingImage__ element in RadFlowDocument can also be achieved with [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}).
        

#### __C#__

{{region radwordsprocessing-model-floatingimage_3}}
    RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);

    using (Stream stream = this.GetResourceStream("Telerik_logo.png"))
    {
        editor.InsertFloatingImage(stream, "png", new Size(118, 28));
    }
{{endregion}}



## Modify an FloatingImage

The __FloatingImage__ element exposes the following properties:
        

* __Image__: Represents the image object that is contained in the FloatingImage. It is a read-only composite object that contains the properties listed below:

    * __ImageSource__: Specifies the image source that is visualized in the image object.

    * __Name__: Represents the name of the image.

    * __Width__: The width of the image.

    * __Height__: The height of the image.

    * __IsHorizontallyFlipped__: Specifies whether the image is horizontally flipped.

    * __IsVerticallyFlipped__: Specifies whether the image is vertically flipped.

    * __RotationAngle__: Specifies the rotation angle of the image.

* __AllowOverlap__: Specifies whether the image is allowed to overlap the contents of the other image objects. The default value is true.

* __IsLocked__: Specifies if the anchor can be modified at runtime.

* __ShapeWrapping__: Specifies the image wrapping. It is composite objects and contains the properties listed below:

    * __WrappingType__: The wrapping type. The default value is Square.

    * __TextWrap__: The text wrap. The default value is BothSides.

* __LayoutInCell__: Indicates if the layout of the image should be calculated relative to the cell that is holding the shape.

* __IsBehindDocument__: Indicates if the shape should be displayed behind the document content.

* __ZIndex__: Specifies the ZIndex of the floating image.

* __Margin__: Represents the margins for the floating image.

* __HorizontalPosition__: Specifies the horizontal position of the floating image. It is composite object that contains the properties listed below:

    * __ValueType__: Specifies whether the positioning should be based on the Offset or the Alignment value. The default value is Offset.

    * __RelativeFrom__: Specifies the relative horizontal positioning base. The default value is Column.

    * __Alignment__: Specifies the alignment to be used if the position type is Alignment.

    * __Offset__: Specifies the offset to be used if the position type is Offset.

* __VerticalPosition__: Specifies the vertical position of the floating image. It is composite object that contains the properties listed below:

    * __ValueType__: Specifies whether the positioning should be based on the Offset or the Alignment value. The default value is Offset.

    * __RelativeFrom__: Specifies the relative horizontal positioning base. The default value is Column.

    * __Alignment__: Specifies the alignment to be used if the position type is Alignment.

    * __Offset__: Specifies the offset to be used if the position type is Offset.
                

# See Also

 * [FloatingImage API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_shapes_floatingimage.html)

 * [Document model]({%slug radwordsprocessing-model%})

 * [ImageInline]({%slug radwordsprocessing-model-imageinline%})

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})
