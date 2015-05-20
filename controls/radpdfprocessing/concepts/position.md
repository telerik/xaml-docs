---
title: Position
page_title: Position
description: Position
slug: radpdfprocessing-concepts-position
tags: position
published: True
position: 4
---

# Position



The __Position__ property exposed by the __PositionContentElement__ abstract class is used for manipulating the position of elements.
      

>tipYou can find a diagram representing the structure in __RadPdfProcessing__ [here]({%slug radpdfprocessing-model-general-information%}).
        

The position is represented by the __IPosition__ interface which provides the following methods:
      



__void Scale(double scaleX, double scaleY)__: Applies the specified scale.
      

__void ScaleAt(double scaleX, double scaleY, double centerX, double centerY)__: Applies the specified scale about the specified coordinates.
      

__void Rotate(double angle)__: Applies the specified rotation.
      

__void RotateAt(double angle, double centerX, double centerY)__: Applies the specified rotation about the specified coordinates.
      

__void Translate(double offsetX, double offsetY)__: Applies the specified translation.
      

__void Clear()__: Clears the position, restoring it to its initial state.
      

__IPosition Clone()__: Clones the position.
      

The IPosition interface exposes a __Matrix__ property which represents the matrix constructed from the applied transformations.
      

IPosition interface is implemented by the following classes:
      

* [MatrixPosition](#matrixposition)

* [SimplePosition](#simpleposition)

By default, PositionContentElements use MatrixPosition, whereas [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%}) uses SimplePosition.
      

## MatrixPosition

Each of the applied transformations is being appended to all the previously applied ones. When the Matrix property is calculated, the order of the applied transformations is the same as the order of the invocation of the transform methods.
        

The __MatrixPosition__ class exposes a static __Default__ property, which represents the default __MatrixPosition__. The default Matrix of the default MatrixPosition is the __Identity matrix__.
        

__Example 1__ shows how transformations can be appended.
        

#### __[C#] Example 1: Trasform MatrixPosition__

{{region radpdfprocessing-concepts-position_0}}
    MatrixPosition matrixPosition = new MatrixPosition();
    matrixPosition.Translate(20, 20); // Translates the position by (20, 20)
    matrixPosition.Translate(30, 30); // Translates the position by (30, 30).
{{endregion}}



The resulting matrix position was translated both horizontally and vertically by 50.
        

## SimplePosition

Each of the applied transformations overwrites the previous transformations of the same type. When the value of the __Matrix__ property is being calculated, the order of the transformations is the following:
        

1. Scale
            

1. Rotate
            

1. Translate
            

The __SimplePosition__ class exposes a static __Default__ property which represents the default SimplePosition.
        

__Example 2__ shows how transformations overwrite the previous transformations of the same type:
        

#### __[C#] Example 2: Trasform SimplePosition__

{{region radpdfprocessing-concepts-position_1}}
    SimplePosition simplePosition = new SimplePosition();
    simplePosition.Translate(20, 20); // Translates the position by (30, 30).
    simplePosition.Translate(30, 30); // Translates the position by (20, 20) overwriting the previous translations.
{{endregion}}



The resulting simple position was translated both horizontally and vertically by 30, because of the transformation overwriting.
        

# See Also

 * [Model]({%slug radpdfprocessing-model-general-information%})

 * [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%})
