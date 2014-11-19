---
title: Text and Graphic Properties
page_title: Text and Graphic Properties
description: Text and Graphic Properties
slug: radpdfprocessing-editing-text-and-graphic-properties
tags: text,and,graphic,properties
published: True
position: 5
---

# Text and Graphic Properties



When using the methods of [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%}) or [Block]({%slug radpdfprocessing-editing-block%}) classes they will create different content elements. You can control the look of the newly created elements with the following properties:
      

## GraphicProperties

These properties are used to hold the current graphics control parameters. The following parameters can be modified using the __GraphicProperties__:
        

* __IsFilled__: Specifies whether content elements should be filled.
            

* __IsStroked__: Specified whether content elements should be stroked.
            

* __FillColor__: The color which will be used to fill the content elements.
            

* __StrokeColor__: The color which will be used to stroke the content elements.
            

* __StrokeThickness__: The width of the stroke outline of content elements.
            

* __MiterLimit__: Specifies the miter limit for graphic elements.
            

* __StrokeDashOffset__: The dash array for graphic elements.
            

* __StrokeDashArray__: The stroke dash array for graphic elements.
            

* __StrokeLineJoin__: The stroke line join for graphic elements.
            

* __StrokeLineCap__: The stroke line cap for graphic elements.
            

## TextProperties

These properties are used to hold the parameters used for text fragments. The following parameters can be modified using the __TextProperties__:
        

* __UnderlinePattern__: The underline pattern. Two patterns are supported.
            

 * __None__: There is no underline. This is the default value.
                

 * __Single__: The underline is single line.
                

* __CharacterSpacing__: The character spacing for text fragments.
            

* __WordSpacing__: The word spacing for text fragments.
            

* __HorizontalScaling__: The horizontal scaling for text fragments.
            

* __FontSize__: The font size for text fragments.
            

* __RenderingMode__: The rendering mode for text fragments.
            

* __BaselineAlignment__: Describes how the baseline for a text-based element is positioned on the vertical axis, relative to the established baseline for text.
            

 * __Baseline__: A baseline that is aligned at the actual baseline of the containing box.
                

 * __Subscript__: A baseline that is aligned at the subscript position of the containing box.
                

 * __Superscript__: A baseline that is aligned at the superscript position of the containing box.
                

* __Font__: The font for the inserted text.
            

* __HorizontalAlignment__: The horizontal positioning of the inserted text in the text block.
            

* __VerticalAlignment__: The vertical positioning of the inserted text in the text block.
            

The TextProperties also exposes the following methods which can be used for changing the current font:
        

__TextProperties.TrySetFont(FontFamily fontFamily);__

__TextProperties.TrySetFont(fontFamily, fontStyle, fontWeight);__

## Preserving Current State

Both Text and Graphic properties contains methods that can preserve and restore the current state.
        

__properties.Save();__

__properties.Restore();__

>The Save() method returns __IDisposable__ object that will execute Restore() as soon as the dispose method is called and can be used in a using statement.
          

# See Also

 * [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%})

 * [Block]({%slug radpdfprocessing-editing-block%})
