---
title: IME Support
page_title: IME Support
description: IME Support
slug: radrichtextbox-features-ime-support
tags: ime, support
published: True
position: 11
---

# IME Support

__RadRichTextBox__ provides built-in support for the most commonly used Microsoft IMEs like Chinese IME, Japanese IME, Korean IME and etc. which are shipped with the Windows OS. Further, you can easily add support for the IME which is used in your application. 


## Caret class

The caret is the UI which represents where the current document position is. It also provides ability to modify the text. It exposes several events which are corresponding to the relevant text operation.

* __TextInputStart__: This event is fired when a UI element initially gets text. 
* __TextInputUpdate__: This event is fired when text continues to be composed and IME is used.
* __TextInput__: This event is fired when the text should be committed.


### How the text is inserted in RadRichTextBox?

The **CaretTextInputHandler** class is responsible for the text insertion in RadRichTextBox. It is attached to the Caret’s **TextInserted** event, which has TextInsertedEventArgs as event arguments. 


__TextInsertedEventArgs__

* __Text__: This property represents the text which is entered.
* __ShouldPersist__: This property carries the information if the composition text should be persisted.
* __ShouldStartNewComposition__: This property identifies if a new text composition should be started.

When you are executing your logic in the overridden Caret event handlers, it is important to execute the **OnTextInserted** method with the desired TextInsertedEventArgs, so the TextInserted event will be fired and the CaretTextInputHandler will process the text depending on the arguments.


## Custom IME Support

If you want to add support for another input method editor, you can easily achieve it by creating a custom caret and plug it in the __RadRichTextBox__. Here is what is necessary to know before doing that.


## ICaretFactory interface

The **ICaretFactory** interface has a CreateCaret() method which is responsible for the caret creation. It returns the caret which should handle the text input.


## How to implement your own IME support?

To achieve a different than the Microsoft IME support, you should implement your own caret which inherits RadRichTextBox’s Caret class and overrides the handlers of the above mentioned events. In these overridden methods you can execute the specific logic for the corresponding input method editor. 


#### __C#__

{{region radrichtextbox-ime-support-0}}
	public class SogouCaret : Caret
	{
	    protected override void OnTextInputStart(object sender, TextCompositionEventArgs e)
	
	    protected override void OnTextInputUpdate(object sender, TextCompositionEventArgs e)
	
	    protected override void OnTextInput(TextCompositionEventArgs e)
	}
{{endregion}}

#### __VB.NET__

{{region radrichtextbox-ime-support-1}}
	Public Class SogouCaret
	    Inherits Caret
	
	    Protected Overloads Sub OnTextInputStart(ByVal sender As Object, ByVal e As TextCompositionEventArgs)
	
	    Protected Overloads Sub OnTextInputUpdate(ByVal sender As Object, ByVal e As TextCompositionEventArgs)
	
	    Protected Overloads Sub OnTextInput(ByVal e As TextCompositionEventArgs)
	
	End Class
{{endregion}}


The inherited caret should be created by a factory class, which should implement the ICaretFactory interface.

#### __C#__

{{region radrichtextbox-ime-support-2}}
	public class SogouCaretFactory : ICaretFactory
	{
	    public Caret CreateCaret()
	    {
	        return new SogouCaret();
	    }
	}
{{endregion}}

#### __VB.NET__

{{region radrichtextbox-ime-support-3}}
	Public Class SogouCaretFactory
	    Implements ICaretFactory
	
	    Public Function CreateCaret() As Caret Implements ICaretFactory.CreateCaret
	        Return New SogouCaret()
	    End Function
	
	End Class
{{endregion}}


The last thing you should do, is to set the RadRichTextBox’ CaretFactory property to be your factory class.

#### __C#__

{{region radrichtextbox-ime-support-4}}
	this.radRichTextBox.CaretFactory = new SogouCaretFactory();
{{endregion}}

#### __VB.NET__

{{region radrichtextbox-ime-support-5}}
	Me.radRichTextBox.CaretFactory = new SogouCaretFactory()
{{endregion}}


>tipYou can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomCaret).



## See Also
 * [SDK Example Custom Caret](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomCaret) 

 * [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%})

 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})
