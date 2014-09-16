---
title: FixedContentEditor
page_title: FixedContentEditor
description: FixedContentEditor
slug: radpdfprocessing-editing-fixedcontenteditor
tags: fixedcontenteditor
publish: True
position: 0
---

# FixedContentEditor



__FixedContentEditor__ is utility class that is intended to simplify the process of creating and editing the content of an __IContentRootElement__ such as [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%}).
      

The current article will get you familiar with the following topics:
      

* [Creating FixedContentEditor](#creating-fixedcontenteditor)

* [Inserting Elements](#inserting-elements)

* [Positioning](#positioning)

* [Changing Current Styles](#changing-current-styles)

## Creating FixedContentEditor

__FixedContentEditor__ is always associated to a single __IContentRootElement__ which it takes as a constructor parameter when it is created. __Example 1__ shows how you can create an editor.
        

#### __[C#] Example 1: Create FixedContentEditor__

{{region radpdfprocessing-editing-fixedcontenteditor_0}}
	            FixedContentEditor editor = new FixedContentEditor(contentRootElement);
	{{endregion}}



The editor maintains an internal [Position]({%slug radpdfprocessing-concepts-position%}) inside the content root element. When a new element is created, its position is being set to the current position of the editor. The initial position of the editor can be specified when it is created.
        

__Example 2__ demonstrates how you can create а FixedContentEditor with specific initial position.
        

#### __[C#] Example 2: Create FixedContentEditor with Specific IPosition__

{{region radpdfprocessing-editing-fixedcontenteditor_1}}
	            FixedContentEditor editor = new FixedContentEditor(contentRootElement, initialPosition);
	{{endregion}}



## Inserting Elements

Composing a [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%}) normally requires to create all elements and specify exactly how they should look. The __FixedContentEditor__ takes care of most things for you. This section explains how you can add different type of elements.
        

### Inserting Text

Inserting а [TextFragment]({%slug radpdfprocessing-model-textfragment%}) can be done with the __public void DrawText(string text)__ method. __Example 3__ inserts a fragment with content "First text fragment.".
            

#### __[C#] Example 3: Insert TextFragment__

{{region radpdfprocessing-editing-fixedcontenteditor_2}}
	            editor.DrawText("First text fragment.");
	{{endregion}}



__Figure 1__ shows the result of __Example 3__.
            

Figure 1: TextFragment Result![Rad Pdf Processing Editing Fixed Content Editor 01](images/RadPdfProcessing_Editing_FixedContentEditor_01.png)

### Inserting Paragraph

__Example 4__ shows how you can start a new paragraph with the __BeginText()__ method.
            

#### __[C#] Example 4: Insert Paragraph__

{{region radpdfprocessing-editing-fixedcontenteditor_3}}
	            using (editor.BeginText())
	            {
	                editor.DrawText("First sentence.");
	                editor.DrawText("Second sentence.");
	            }
	{{endregion}}



__Figure 2__ shows the result of __Example 4__.
            

Figure 2: Paragraph![Rad Pdf Processing Editing Fixed Content Editor 02](images/RadPdfProcessing_Editing_FixedContentEditor_02.png)

The __BeginText()__ method returns an IDisposable object, which ends the paragraph when disposed. A paragraph can also be ended using the __EndText()__ method.
            

>tipBuilding a paragraph with the FixedContentEditor is much simpler than creating TextFragments yourself. The __BeginText()__ method would flow the content of a paragraph for you if this is necessary.
              

### Inserting Image

__FixedContentEditor__ provides several overloads for inserting an [Image]({%slug radpdfprocessing-model-image%}).
            

__public void DrawImage(Stream stream, ImageFormat imageFormat);__

__public void DrawImage(Stream stream, ImageFormat imageFormat, double width, double height);__

__public void DrawImage(Stream stream, ImageFormat imageFormat, Size size);__

__public void DrawImage(ImageSource source);__

__public void DrawImage(ImageSource source, Size size);__

__public void DrawImage(ImageSource source, double width, double height);__

__Example 5__ shows how you can add an image created from a Stream.
            

#### __[C#] Example 5: Insert Image__

{{region radpdfprocessing-editing-fixedcontenteditor_4}}
	            using (Stream stream = this.GetResourceStream("Telerik_logo.jpg"))
	            {
	                editor.DrawImage(stream, ImageFormat.Jpeg, new Size(118, 28));
	            }
	{{endregion}}



Figure 3: Image Result![Rad Pdf Processing Editing Fixed Content Editor 04](images/RadPdfProcessing_Editing_FixedContentEditor_04.png)

### Inserting Geometries

The following methods can be used to insert different [Geometries]({%slug radpdfprocessing-concepts-geometry%}) in the document:
            

__public void DrawLine(Point point1, Point point2)__: Inserts a line between the specified points.
            

__public void DrawRectangle(Rect rectangle)__: Inserts a rectangle.
            

__public void DrawEllipse(Point center, double radiusX, double radiusY)__: Inserts an ellipse.
            

__public void DrawCircle(Point center, double radius)__: Inserts a circle.
            

__public void DrawPath(PathGeometry pathGeometry)__: Inserts a custom path geometry.
            

__Example 6__ shows how you can add an ellipse using one of FixedContentEditor's methods.
            

#### __[C#] Example 6: Insert Ellipse__

{{region radpdfprocessing-editing-fixedcontenteditor_5}}
	            editor.DrawEllipse(new Point(250, 70), 136, 48);
	{{endregion}}



### Inserting Clipping

__FixedContentEditor__ exposes a __Clipping__ property which defines the [Clipping]({%slug radpdfprocessing-concepts-clipping%}) to be used for the inserted content elements. The following methods can be used to push and pop clippings:
            

__public IDisposable PushClipping(GeometryBase clip)__: Inserts a new clipping defined from the specified geometry.
            

__public IDisposable PushClipping(Rect clip)__: Inserts a new clipping defined from the specified rectangle.
            

__public Clipping PopClipping()__: Pops the last clipping, which was inserted with the editor.
            

When the returned __xIDisposable__ object from the __PushClipping()__ method is disposed, the clipping is popped from the clippings in the editor.
            

When a new clipping is pushed, it is set as a clipping to the current clipping in the editor. __Example 7__ shows how a clipping can be pushed:
            

#### __[C#] Example 7: Push Clipping__

{{region radpdfprocessing-editing-fixedcontenteditor_6}}
	            string visibleText = "The last word in this text is";
	            string text = string.Format("{0} clipped.", visibleText); //The last word in this text is clipped.
	            Size visisibleTextSize = editor.MeasureText(visibleText);
	
	            using (editor.PushClipping(new Rect(new Point(0, 0), visisibleTextSize)))
	            {
	                editor.DrawText(text);
	            }
	{{endregion}}



__Figure 4__ shows the result of __Example 7__.
            

Figure 4: Clipping Result![Rad Pdf Processing Editing Fixed Content Editor 03](images/RadPdfProcessing_Editing_FixedContentEditor_03.png)

## Positioning

The [Position]({%slug radpdfprocessing-concepts-position%})  property exposed by __FixedContentEditor__ allows an easy way to manipulate the position of inserted content elements.
        

The code in __Example 8__ shows how to manipulate the position of the inserted content elements and __Figure 5__ shows the result of the code.
        

#### __[C#] Example 8: Scale and Rotate Content__

{{region radpdfprocessing-editing-fixedcontenteditor_7}}
	            editor.Position.Scale(1.5, 0.5);
	            editor.Position.Rotate(10);
	            editor.DrawText("Image:");
	            editor.Position.Translate(0, 20);
	            using (Stream stream = this.GetResourceStream("Telerik_logo.jpg"))
	            {
	                editor.DrawImage(stream, ImageFormat.Jpeg, new Size(118, 28));
	            }
	{{endregion}}



Figure 5: Positioning Result![Rad Pdf Processing Editing Fixed Content Editor 05](images/RadPdfProcessing_Editing_FixedContentEditor_05.png)

## Changing Current Styles

When you use the draw methods of the __FixedContentEditor__, it creates different content elements. You can control the look of the newly created elements with the following properties:
        

* __GraphicProperties__: These properties are used to hold the graphics control parameters. The following parameters can be modified:
            

* __IsFilled__: Specifies whether content elements should be filled.
                

* __IsStroked__: Specified whether content elements should be stroked.
                

* __FillColor__: The color which should be used to fill the content elements.
                

* __IsStroked__: Specified whether content elements should be stroked.
                

* __StrokeColor__: The color which should be used to stroke the content elements.
                

* __StrokeThickness__: The width of the stroke outline of content elements.
                

* __MiterLimit__: The miter limit for graphic elements.
                

* __StrokeDashOffset__: The dash array for graphic elements.
                

* __StrokeDashArray__: The stroke dash array for graphic elements.
                

* __StrokeLineJoin__: The stroke line join for graphic elements.
                

* __StrokeLineCap__: The stroke line cap for graphic elements.
                

* __TextProperties__: These properties are used to hold the parameters used for text fragments. The following parameters can be modified:
            

* __TextDecoration__: Property of type
                  [TextDecoration](http://www.telerik.com/help/wpf/t_telerik_windows_documents_fixed_model_text_textdecorations.html)
                  which specifies the text decorations for inserted text. The possible values are __None__ and __Underline__.
                

* __CharacterSpacing__: The character spacing for text fragments.
                

* __WordSpacing__: The word spacing for text fragments.
                

* __HorizontalScaling__: The horizontal scaling for text fragments.
                

* __FontSize__: The font size for text fragments.
                

* __RenderingMode__: The rendering mode for text fragments.
                

* __TextRise__: The text rise for text fragments.
                

* __LineHeight__: The height for each line of the inserted text.
                

* __TextBlockHeigh__: The height of the test block which holds the inserted text.
                

* __TextBlockWidth__: The width of the text block which holds the inserted text.
                

* __Font__: The font for the inserted text.
                

* __HorizontalAlignment__: The horizontal positioning of the inserted text in the text block.
                

* __VerticalAlignment__: The vertical positioning of the inserted text in the text block.
                

__FixedContentEditor__ exposes the following methods which can be used to save the current properties:
        

__public IDisposable SaveTextProperties()__: Saves the current text properties.
        

__public IDisposable SaveGraphicProperties()__: Saves the current graphic properties.
        

Both methods return an IDisposable object, which restores the previously saved properties when disposed. The previously saved properties can also be restored using the following methods:
        

__public void RestoreGraphicProperties()__: Restores the previously saved graphic properties.
        

__public void RestoreTextProperties()__: Restores the previously saved text properties.
        

# See Also

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

 * [Position]({%slug radpdfprocessing-concepts-position%})

 * [TextFragment]({%slug radpdfprocessing-model-textfragment%})

 * [Image]({%slug radpdfprocessing-model-image%})

 * [Geometry]({%slug radpdfprocessing-concepts-geometry%})

 * [Clipping]({%slug radpdfprocessing-concepts-clipping%})
