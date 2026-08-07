---
title: Configuring Interaction Providers
page_title: Configuring Interaction Providers
description: Check our &quot;Configuring Interaction Providers&quot; documentation article for the RadInlineAIAssistant control.
slug: radinlineaiassistant-configuring-interaction-providers
tags: interaction providers, configuring interaction providers, radinlineaiassistant
published: True
position: 4
---

# Configuring Interaction Providers

`RadInlineAIAssistant` does not read from or write to its target element directly. Instead, it delegates all of that to an `InteractionProvider`&mdash;an implementation of the `IInlineAssistantInteractionProvider` interface, set through the `InteractionProvider` property.

## The IInlineAssistantInteractionProvider Interface

`IInlineAssistantInteractionProvider` exposes the following members:

* `TargetElement`&mdash;Gets the `FrameworkElement` that the assistant interacts with. It is used as the `Popup` placement target.
* `FullText`&mdash;Gets the full text of the target element.
* `SelectedText`&mdash;Gets the currently selected text in the target element.
* `InsertText(string)`&mdash;Inserts the specified text at the current caret position.
* `ReplaceSelectedText(string)`&mdash;Replaces the currently selected text with the specified text.
* `CanInsertText(string)`&mdash;Determines whether text can currently be inserted. Backs the `CanExecute` state of the `Insert` command.
* `CanReplaceSelectedText(string)`&mdash;Determines whether the current selection can be replaced. Backs the `CanExecute` state of the `Replace` command.
* `GetPosition()`&mdash;Returns the screen point where the assistant popup should open, or `null` if it should not open (for example, because the caret is currently scrolled outside of the visible viewport).

>caution `InteractionProvider` must be set before `IsOpen` is set to `true`. Otherwise, an `InvalidOperationException` is thrown.

## Built-in Providers

The following built-in providers are available:

* `InlineAIAssistantTextBoxProvider`&mdash;Implements the interface for a `TextBox`. It is created automatically for you when the assistant is attached to a `TextBox` and no `InteractionProvider` has been set yet.
* `InlineAIAssistantRadRichTextBoxProvider`&mdash;Implements the interface for a `RadRichTextBox`, reading and writing the document's plain text. It ships with the RichTextBox assembly and is not created automatically&mdash;set it explicitly. To use it, add a reference to the assembly (or NuGet package) that contains the `RadRichTextBox` control, as described in the [RadRichTextBox Getting Started]({%slug radrichtextbox-getting-started%}) article.

__Attaching a RadInlineAIAssistant to a RadRichTextBox__
```C#
RadInlineAIAssistant assistant = new RadInlineAIAssistant();
assistant.InteractionProvider = new InlineAIAssistantRadRichTextBoxProvider(this.radRichTextBox);
assistant.PromptRequest += this.OnPromptRequest;

RadInlineAIAssistant.SetInlineAIAssistant(this.radRichTextBox, assistant);
```

## Implementing a Custom Provider

For any other target element, implement `IInlineAssistantInteractionProvider` yourself and assign it to `InteractionProvider` before opening the assistant. This is also useful when you want to customize the built-in behavior, for example by deriving from `InlineAIAssistantTextBoxProvider` or `InlineAIAssistantRadRichTextBoxProvider` and overriding one or more of their virtual members, such as `GetPosition`, to control exactly where the assistant popup opens.

>tip If your target element is a `RadRichTextBox`, use the built-in `InlineAIAssistantRadRichTextBoxProvider` described above instead of implementing a custom provider.

The following example implements the interface for the native WPF `RichTextBox`, which has no built-in provider.

__Implementing IInlineAssistantInteractionProvider for a RichTextBox__
```C#
public class InlineAIAssistantRichTextBoxProvider : IInlineAssistantInteractionProvider
{
    private RichTextBox richTextBox;

    public InlineAIAssistantRichTextBoxProvider(RichTextBox richTextBox)
    {
        this.richTextBox = richTextBox;
    }

    public FrameworkElement TargetElement => this.richTextBox;

    public string FullText => new TextRange(this.richTextBox.Document.ContentStart, this.richTextBox.Document.ContentEnd).Text;

    public string SelectedText => this.richTextBox.Selection.Text;

    public bool CanInsertText(string text)
    {
        return !this.richTextBox.IsReadOnly;
    }

    public bool CanReplaceSelectedText(string text)
    {
        return !this.richTextBox.IsReadOnly && !this.richTextBox.Selection.IsEmpty;
    }

    public void InsertText(string text)
    {
        this.richTextBox.CaretPosition.InsertTextInRun(text);
    }

    public void ReplaceSelectedText(string text)
    {
        this.richTextBox.Selection.Text = text;
    }

    public Point? GetPosition()
    {
        Rect caretRect = this.richTextBox.CaretPosition.GetCharacterRect(LogicalDirection.Forward);
        Rect viewportRect = new Rect(0, 0, this.richTextBox.ActualWidth, this.richTextBox.ActualHeight);

        if (!viewportRect.Contains(caretRect.BottomRight))
        {
            // The caret is scrolled outside of the visible area, so the assistant should not open.
            return null;
        }

        return this.richTextBox.PointToScreen(caretRect.BottomRight);
    }
}
```

__Attaching the custom provider to a RichTextBox__
```C#
RadInlineAIAssistant assistant = new RadInlineAIAssistant();
assistant.InteractionProvider = new InlineAIAssistantRichTextBoxProvider(this.richTextBox);
assistant.PromptRequest += this.OnPromptRequest;

RadInlineAIAssistant.SetInlineAIAssistant(this.richTextBox, assistant);
```

## See Also
* [Getting Started]({%slug radinlineaiassistant-getting-started%})
* [Configuring Commands]({%slug radinlineaiassistant-configuring-commands%})
* [Handling Responses]({%slug radinlineaiassistant-handling-responses%})
