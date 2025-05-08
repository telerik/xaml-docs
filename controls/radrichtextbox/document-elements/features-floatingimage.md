---
title: Floating Images
page_title: FloatingImage
description: FloatingImage.
slug: radrichtextbox-features-document-elements-floatingimage
tags: Image,floating,FloatingImageBlock
published: True
position: 6
---

# Floating Images

The floating images in RadRichTextBox are represented as inline images wrapped in floating block containers. This functionality allows images to be displayed inside the document and positioned on its own line or wrapped up by the content around. 

This topic will explain you how to use the **FloatingImageBlock** element.

>tip To modify the document content at runtime we recommend using the [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) class when possible, instead of working with `RadDocument` directly. The document editor ensures that the document will be measured and arranged properly on each change.

## Supported Image Extensions

With **RadRichTextBox**, you can work with images from the following file formats:

`JPG`
`JPEG`
`PNG`
`BMP`
`TIFF`
`TIF`
`GIF`
`ICO`
`ICON`
`WMF`
`EMF`

## FloatingImageBlock Class Overview

The **FloatingImageBlock** class is used to insert floating images in a document. This class wraps an inline image in a floating block allowing the customer to position the image on the exact position they would like to. **FloatingImageBlock** derives from [**FloatingBlock**](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.floatingblock) whose base class is **AnnotationMarkerBase**. With that said, the floating blocks are implemented using annotations.

FloatingImageBlock exposes members enabling you to control the image inside the container and its positioning.

- **ImageInline ImageInline**: Represents the image inside the floating block. For more information about this object, refer to the [ImageInline]({%slug radrichtextbox-features-document-elements-inlineimage%}) topic.

- **bool AffectsLayout**: Gets a value indicating whether the block affects the layout of the document. The layout is not affected in the cases when the **WrappingStyle** property of the block is set to WrappingStyle.**BehindText** or WrappingStyle.**InFrontOfText**.

- **bool AllowOverlap**: Indicates whether the block can overlap with other blocks.

- **TextWrap TextWrap**: Determines how the text should be positioned around the floating block. You can check the possible values in [TextWrap API Reference](https://docs.telerik.com/devtools/WPF/api/telerik.windows.documents.model.TextWrap).

- **WrappingStyle WrappingStyle**: Defines how the other elements can be wrapped around the floating block. You can check the possible values in [WrappingStyle API Reference](https://docs.telerik.com/devtools/WPF/api/telerik.windows.documents.model.wrappingstyle).

- **FloatingBlockHorizontalPosition HorizontalPosition**: Determines the horizontal position of the block. The position is described using the following properties:
    
    - **HorizontalRelativeFrom RelativeFrom**: Determines the horizontal object or edge the position should be relative from using the values of the [HorizontalRelativeFrom](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.floatingblocks.horizontalrelativefrom) enumeration.
    - **PositionValueType ValueType**: Determines whether the position should be moved with a specific offset or aligned to other elements. You can check the possible values in [PositionValueType API Reference](https://docs.telerik.com/devtools/WPF/api/telerik.windows.documents.model.floatingblocks.positionvaluetype).
    - **RadHorizontalAlignment Alignment**: The alignment. You can check the possible values in [RadHorizontalAlignment API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.layout.radhorizontalalignment).
    - **double Offset**: The offset.
    
* **FloatingBlockVerticalPosition VerticalPosition**: Determines the vertical position of the block. The position is described using the following properties:

    - **VerticalRelativeFrom RelativeFrom**: Determines the vertical object or edge the position should be relative from using the values of the [VerticalRelativeFrom](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.floatingblocks.verticalrelativefrom) enumeration.
    - **PositionValueType ValueType**: Determines whether the position should be moved with a specific offset or aligned to other elements. You can check the possible values in [PositionValueType API Reference](https://docs.telerik.com/devtools/WPF/api/telerik.windows.documents.model.floatingblocks.positionvaluetype).
    - **RadVerticalAlignment Alignment**: The alignment. You can check the possible values in [RadVerticalAlignment API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.layout.radverticalalignment).
    - **double Offset**: The offset.

## Add in XAML

**Example 1** shows how a **FloatingImageBlock** element can be defined in XAML at design time.

#### __[XAML] Example 1: FloatingImageBlock definition__

{{region radrichtextbox-features-document-elements-floatingimages_0}}

    <telerik:RadRichTextBox x:Name="radRichTextBox" Height="500">
        <telerik:RadDocument>
            <telerik:Section>
                <telerik:Paragraph>
                    <telerik:FloatingImageBlock AllowOverlap="False" AnnotationID="0" Margin="10,0,10,0" TextWrap="BothSides" WrappingStyle="Square">
                        <telerik:FloatingImageBlock.HorizontalPosition>
                            <telerik:FloatingBlockHorizontalPosition Alignment="Left" Offset="0" RelativeFrom="Paragraph" ValueType="Offset" />
                        </telerik:FloatingImageBlock.HorizontalPosition>
                        <telerik:FloatingImageBlock.VerticalPosition>
                            <telerik:FloatingBlockVerticalPosition Alignment="Top" Offset="0" RelativeFrom="Paragraph" ValueType="Offset" />
                        </telerik:FloatingImageBlock.VerticalPosition>
                        <telerik:ImageInline Extension="png" Height="159" Width="318" UriSource="/Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png" />
                    </telerik:FloatingImageBlock>
                </telerik:Paragraph>
            </telerik:Section>
        </telerik:RadDocument>
    </telerik:RadRichTextBox>
{{endregion}}

## Add in Code Behind

You can work with FloatingImageBlock objects in code-behind as well. 

#### __[C#] Example 2: Define FloatingImageBlock in code-behind__

{{region radrichtextbox-features-document-elements-floatingimage_1}}

    private FloatingImageBlock CreateFloatingImageBlock()
    {
        Stream stream = Application.GetResourceStream(new Uri(@"/Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream;
        Size size = new Size(236, 50);
        ImageInline image = new ImageInline(stream, size, "png");
    
        FloatingImageBlock floatingBlock = new FloatingImageBlock();
        floatingBlock.ImageInline = image;
        floatingBlock.HorizontalPosition = new FloatingBlockHorizontalPosition(HorizontalRelativeFrom.Paragraph, 120);
    
        return floatingBlock;
    }
{{endregion}}

#### __[VB.NET] Example 2: Define FloatingImageBlock in code-behind__

{{region radrichtextbox-features-document-elements-floatingimage_2}}

    Private Function CreateFloatingImageBlock() As FloatingImageBlock
        Dim stream As Stream = Application.GetResourceStream(New Uri("/Help.RadRichTextBoxSamples;component/Demos/Images/RadRichTextBox.png", UriKind.RelativeOrAbsolute)).Stream
        Dim size As Size = New Size(236, 50)
        Dim image As ImageInline = New ImageInline(stream, size, "png")
        Dim floatingBlock As FloatingImageBlock = New FloatingImageBlock()
        floatingBlock.ImageInline = image
        floatingBlock.HorizontalPosition = New FloatingBlockHorizontalPosition(HorizontalRelativeFrom.Paragraph, 120)
        Return floatingBlock
    End Function
{{endregion}}

Once you have defined the image, you will need to insert it in the document. Two approaches are available: using directly the model, appropriate when you are just constructing the document, or through the methods of RadDocumentEditor, when the document is already visualized in RadRichTextBox.

#### __[C#] Example 3: Insert FloatingImageBlock through the model__

{{region radrichtextbox-features-document-elements-floatingimage_3}}

    Section section = new Section();
    Paragraph paragraph = new Paragraph();
    paragraph.Inlines.Add(this.CreateFloatingImageBlock());
    section.Children.Add(paragraph);
    
    RadDocument document = new RadDocument();
    document.Sections.Add(section);
    this.radRichTextBox.Document = document;
{{endregion}}

#### __[VB.NET] Example 3: Insert FloatingImageBlock through the model__

{{region radrichtextbox-features-document-elements-floatingimage_4}}

    Dim section As Section = New Section()
    Dim paragraph As Paragraph = New Paragraph()
    paragraph.Inlines.Add(Me.CreateFloatingImageBlock())
    section.Children.Add(paragraph)
    
    Dim document As RadDocument = New RadDocument()
    document.Sections.Add(section)
    Me.radRichTextBox.Document = document
{{endregion}}

In case an existing document should be edited, you can add a floating image to it using the **InsertInline()** method exposed by the **RadRichTextBox** and **RadDocumentEditor** classes.

#### __[C#] Example 4: Insert FloatingImageBlock using IDocumentEditor__
{{region radrichtextbox-features-document-elements-floatingimage_4}}

    FloatingImageBlock floatingBlock = this.CreateFloatingImageBlock();
    this.radRichTextBox.InsertInline(floatingBlock);
{{endregion}}

#### __[VB.NET] Example 4: Insert FloatingImageBlock using IDocumentEditor__
{{region radrichtextbox-features-document-elements-floatingimage_5}}

    Dim floatingBlock As FloatingImageBlock = Me.CreateFloatingImageBlock()
    Me.radRichTextBox.InsertInline(floatingBlock)
{{endregion}}

## See Also

 * [ImageInline]({%slug radrichtextbox-features-document-elements-inlineimage%}) 
 * [Editing Images]({%slug radrichtextbox-features-editing-images%})  
 * [Annotations]({%slug radrichtextbox-features-document-elements-annotations%}) 
 * [FloatingBlock API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.floatingblock)
 * [Elements Hierarchy]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
 * [Section]({%slug radrichtextbox-features-document-elements-section%})
 * [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})
 * [Span]({%slug radrichtextbox-features-document-elements-span%})
