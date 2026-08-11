---
title: IME Support
page_title: IME Support
description: Check our &quot;IME Support&quot; documentation article for the RadRichTextBox WPF control.
slug: radrichtextbox-features-ime-support
tags: ime, support
published: True
position: 11
---

# IME Support

`RadRichTextBox` provides built-in support for the most commonly used Microsoft IMEs like Chinese IME, Japanese IME, Korean IME and etc., which are shipped with the Windows OS. Further, you can easily add support for the IME which is used in your application. 

>important When working with the IME inside RadRichTextBox, moving the caret position or performing a selection inside the composition will be disabled.

## Use Previous Version of Microsoft IME

The RadRichTextBox class exposes the `UsePreviousVersionOfMicrosoftIme` property. It controls whether the previous version of the Microsoft IME will be used.

>important When using Japanese, the UsePreviousVersionOfMicrosoftIme property needs to be synchronized with the OS settings. To learn more about how to revert to the previous version of the IME, you check this [article](https://support.microsoft.com/en-us/windows/revert-to-a-previous-version-of-an-ime-input-method-editor-adcc9caa-17cb-44d8-b46e-f5b473b4dd77).

__Reverting to the previous version of Microsoft IME__
<snippet id='radrichtextbox-ime-support-block_1-cs' />
<snippet id='radrichtextbox-ime-support-block_2-vb' />

## Caret class

The caret is the UI which shows where the current document position is. It is represented by the `Caret` class. It also provides ability to modify the text. It exposes several events which are corresponding to the relevant text operation.

* `TextInputStart`&mdash;This event is fired when a UI element initially gets text. 
* `TextInputUpdate`&mdash;This event is fired when text continues to be composed and IME is used.
* `TextInput`&mdash;This event is fired when the text should be committed.

Additionally, the Caret class also exposes the `CurrentImeLanguage` property, which provides information about the current IME language. It is of the type of `ImeLanguage` and it can return one of the following options:

* `Korean`&mdash;The current IME language is Korean.
* `Japanese`&mdash;The current IME language is Japanese.
* `Chinese`&mdash;The current IME language is Chinese.
* `Other`&mdash;The current IME language is not Korean, Japanese, nor Chinese.

### How the text is inserted in RadRichTextBox?

The `CaretTextInputHandler` class is responsible for the text insertion in RadRichTextBox. It is attached to the Caret’s `TextInserted` event, which has `TextInsertedEventArgs` as event arguments. 

The TextInsertedEventArgs class exposes the following properties:

* `Text`&mdash;This property represents the text which is entered.
* `ImeLanguage`&mdash;This property provides information about the current IME language.
* `CurrentEvent`&mdash;This property contains the type of action that is performed that raises the TextInserted event. It is of the type of `InputEvents` and the possible events are as follows:
	* `OnTextInputStart`&mdash;This action will be present when starting a new text input.
	* `OnTextInputUpdate`&mdash;This action will be present when updating the text input.
	* `OnTextInput`&mdash;This action will be present when ending the text input.
	* `OnStandardTextInput`&mdash;This action will be present when insering standart text without using the IME.

>important With the __2025 Q1__ release, the `ShouldPersist` and `ShouldStartNewComposition` properties of the TextInsertedEventArgs class are now obsoleted. To learn more about the obsoleted API, check the [Breaking Changes]({%slug radrichtextbox-backward-compatibility%}) article.

When you are executing your logic in the overridden Caret event handlers, it is important to execute the `OnTextInserted` method with the desired TextInsertedEventArgs, so the TextInserted event will be fired and the CaretTextInputHandler will process the text depending on the arguments.

## Custom IME Support

If you want to add support for another input method editor, you can easily achieve it by creating a custom caret and plug it in the RadRichTextBox. Here is what is necessary to know before doing that.

## ICaretFactory interface

The `ICaretFactory` interface has a `CreateCaret` method which is responsible for the caret creation. It returns the caret which should handle the text input.

## How to implement your own IME support?

To achieve a different than the Microsoft IME support, you should implement your own caret which inherits RadRichTextBox’s Caret class and overrides the handlers of the above mentioned events. In these overridden methods you can execute the specific logic for the corresponding input method editor. 

__Extending the Caret class__
<snippet id='radrichtextbox-ime-support-block_3-cs' />
<snippet id='radrichtextbox-ime-support-block_4-vb' />

The inherited caret should be created by a factory class, which should implement the `ICaretFactory` interface.

__Implementing a custom caret factory__
<snippet id='radrichtextbox-ime-support-block_5-cs' />
<snippet id='radrichtextbox-ime-support-block_6-vb' />

The last thing you should do, is to set the RadRichTextBox’ `CaretFactory` property to be your factory class.

__Setting the custom caret factory__
<snippet id='radrichtextbox-ime-support-block_7-cs' />
<snippet id='radrichtextbox-ime-support-block_8-vb' />

>tip You can download a runnable project of the previous example from our online SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomCaret).

## See Also
 * [SDK Example Custom Caret](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomCaret) 
 * [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%})
 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})