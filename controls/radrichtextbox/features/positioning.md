---
title: Positioning
page_title: Positioning
description: Positioning
slug: radrichtextbox-features-positioning
tags: positioning
published: True
position: 0
---

# Positioning



The positioning feature in the __RadRichTextBox__ is used to navigate through document's content and to get information about the document's elements at a specific position. The __RadDocument__ uses the positioning to track the movement of the caret and to control the selection.
      

The positioning is implemented via the __DocumentPosition__ class. This class can be used by the developer to programmatically control the positioning or the selection. __DocumentPosition__ offers methods, such as __MoveToNextWord()__, __MoveToPreviousWord()__, __MoveToCurrentLineStart/End()__ and so on, which will navigate to the given document element. In order to get information about the element at a given position you can use several methods such as __GetCurrentSpanBox()__, __GetCurrentParagraphBox()__, __GetCurrentSectionBox()__ and so on.
      

__DocumentPosition__ also redefines equality and comparison operators for more convenience, when you should find whether the __DocumentPosition__ is before or after another position in the natural flow of the document. By default __RadRichTextBox__ moves __Document.CaretPosition__ using arrow keys or on mouse click. __DocumentPosition__ can also be obtained by giving the coordinates of a point in the document using the method __DocumentPosition.SetPosition__.
      

You can manage the caret position for a specific __RadDocument__ by either accessing its __CaretPosition__ property, which is of type __DocumentPosition__, or by creating a new instance of the __DocumentPosition__ class and associating it with the desired __RadDocument__.
      

>When using the __CaretPosition__ property you are directly managing the caret position in the __RadDocument__. By using the __DocumentPosition__ class you can create instances of several positions inside the document without changing the current caret position.
        

## CaretPosition property

Here is an example of how to use the __CaretPosition__ property to get the current word.
        

#### __C#__

{{region radrichtextbox-features-positioning_0}}
	string currentSpanText = this.radRichTextBox.Document.CaretPosition.GetCurrentSpanBox().Text;
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-positioning_1}}
	Dim currentSpanText As String = Me.radRichTextBox.Document.CaretPosition.GetCurrentSpanBox().Text
{{endregion}}



## DocumentPosition class

An alternative of using the __CaretPosition__ property is to create an instance of the __DocumentPosition__ class. Here is the same example from the previous chapter done with an instance of the __DocumentPosition__ class.
        

>When instantiated in such a way, the position will be at the start of the document, so the result will be the first word in the text.The position of the instance won't be affected by the UI. To change it you have to use {% if site.site_name == 'Silverlight' %}[the API of the DocumentPosition class](http://www.telerik.com/help/silverlight/t_telerik_windows_documents_documentposition.html){% endif %}{% if site.site_name == 'WPF' %}[the API of the DocumentPosition class](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_documents_documentposition.htm){% endif %}.
            

#### __C#__

{{region radrichtextbox-features-positioning_2}}
	DocumentPosition position = new DocumentPosition( this.radRichTextBox.Document );
	string currentSpanText = position.GetCurrentSpanBox().Text;
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-positioning_3}}
	Dim position As New DocumentPosition(Me.radRichTextBox.Document)
	Dim currentSpanText As String = position.GetCurrentSpanBox().Text
{{endregion}}



# See Also

 * [Selection]({%slug radrichtextbox-features-selection%})

 * [History]({%slug radrichtextbox-features-history%})
