---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadInlineAIAssistant control.
slug: radinlineaiassistant-events
tags: events, radinlineaiassistant
published: True
position: 3
---

# Events

This topic covers the specific events exposed by the `RadInlineAIAssistant` control.

## PromptRequest

The `PromptRequest` event is raised when the end user submits the prompt input or selects a command from the [Commands]({%slug radinlineaiassistant-configuring-commands%}) dropdown. The event arguments are of type `InlineAIAssistantPromptRequestEventArgs` and expose the following members:

* `Prompt`&mdash;Gets the prompt text that was requested by the user (the input text, or the selected command's `Text`).
* `SelectedText`&mdash;Gets the currently selected text in the target element, as reported by the current `InteractionProvider`.
* `FullText`&mdash;Gets the full text of the target element, as reported by the current `InteractionProvider`.
* `SetResponse(string)`&mdash;Sets a single, immediate response text.
* `SetResponse(IAsyncEnumerable<string>)`&mdash;Sets a stream of response chunks that are appended as they arrive.

>tip Read more about setting an immediate or a streamed response in the [Handling Responses]({%slug radinlineaiassistant-handling-responses%}) article.

__Using the PromptRequest event to set a response__
```C#
private void OnPromptRequest(object sender, InlineAIAssistantPromptRequestEventArgs e)
{
    // Pass e.Prompt (and, optionally, e.SelectedText / e.FullText) to your AI model.
    e.SetResponse("This is a sample AI-generated response.");
}
```

## Opening

The `Opening` event occurs before a particular instance of `RadInlineAIAssistant` opens. It is raised only when the assistant is opened through an attached-element trigger&mdash;a touch tap-and-hold-then-release gesture on the target element, or an event named in the `OpeningEventName` property&mdash;and is not raised when the `IsOpen` property is set directly. Setting `Handled` to `true` in the handler prevents the assistant from opening.

__Canceling the Opening event__
```C#
private void OnAssistantOpening(object sender, RadRoutedEventArgs e)
{
    e.Handled = true;
}
```

## Opened

The `Opened` event occurs when a particular instance of `RadInlineAIAssistant` opens, regardless of whether it was opened through the attached-element trigger or by setting `IsOpen` directly.

__Using the Opened event__
```C#
private void OnAssistantOpened(object sender, RadRoutedEventArgs e)
{
}
```

## Closed

The `Closed` event occurs when a particular instance of `RadInlineAIAssistant` closes, regardless of whether it was closed through user interaction (for example, pressing `Escape` or clicking outside of it) or by setting `IsOpen` directly.

__Using the Closed event__
```C#
private void OnAssistantClosed(object sender, RadRoutedEventArgs e)
{
}
```

## See Also
* [Getting Started]({%slug radinlineaiassistant-getting-started%})
* [Configuring Interaction Providers]({%slug radinlineaiassistant-configuring-interaction-providers%})
* [Configuring Commands]({%slug radinlineaiassistant-configuring-commands%})
* [Handling Responses]({%slug radinlineaiassistant-handling-responses%})
