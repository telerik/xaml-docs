---
title: Caret
page_title: Caret
description: Check our &quot;Caret&quot; documentation article for the RadRichTextBox WPF control.
slug: radrichtextbox-features-caret
tags: radrichtextbox, caret
published: True
---

# Caret & Caret Factory

`RadRichTextBox` has its own custom caret logic that is responsible for the caret functionality inside the `RadDocument`. It specifies the current position in the document and also allows you to modify the text. The control allows allows you to customize the default behavior via the `Caret` class and the `ICaretFactory` interface.

## Caret 

The Caret class represents the caret in the RadDocument object. It exposes the following API:

* `Text`&mdash;Gets or sets the text contents of the text box, with all new lines removed.
* `InputState`&mdash;Provides information about the input state of the caret. It is of the type of `InputStates`, which has `Standard` and `Ime` as options.
* `CaretBaseLineOffset`&mdash;Returns the value of the base line offset of the caret.
* `IsBlinking`&mdash;Gets or sets a value indicating whether the caret is blinking.
* `EnableAsynchronousTextInsertion`&mdash;Controls whether or not the text should be added asynchronously to the RadDocument when typing fast.
* `MinimumTextInsertedInterval`&mdash;Gets or sets the minimum interval (in milliseconds) between two consecutive raises of the caret's `TextInserted` event. The value is respected only when the `EnableAsynchronousTextInsertion` is set to true. The default value is __15__.
* `LastInputEvent`&mdash;Provides information about the last input event that was raised when performing text operations. The property is of the type of `InputEvents` enumeration and the available types of the input events are `OnTextInputStart`, `OnTextInputUpdate`, and `OnTextInput`. For more information about the input events, check this [section]({%slug radrichtextbox-features-ime-support%}#caret-class).
* `ShouldStartNewComposition`&mdash;This property identifies if a new text composition should be started.
* `ShouldPersist`&mdash;This property carries the information if the composition text should be persisted.

The following example showcases how to disable asynchronous text addition when typing fast:

__Creating a custom caret__
```C#
    public class MyCaret : Caret
    {
        public MyCaret()
            : base()
        {
            this.EnableAsynchronousTextInsertion = false;
        }
    }
```

## Caret Factory

RadRichTextBox allows you to define a custom caret factory. To do so, create a class and implement the `ICaretFactory` interface. This factory is used to return a new instance of your custom Caret class via the `CreateCaret` method. To set it on the RadRichTextBox instance, use its `CaretFactory` property.

__Creating a custom caret factory__
```C#
    public class MyCaretFactory : ICaretFactory
    {
        public Caret CreateCaret()
        {
            return new MyCaret();
        }
    }
```

__Setting the custom caret factory to the RadRichTextBox control__
```XAML
    this.radRichTextBox.CaretFactory = new MyCaretFactory();
```

>tip You can find a runnable project with a customization to the caret functionality of the RadRichTextBox control in our [SDK repository](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomCaret). Additionally, you can view it in our [SDK Samples Browser](sdk-samples-browser) application under the name __Custom Caret__.