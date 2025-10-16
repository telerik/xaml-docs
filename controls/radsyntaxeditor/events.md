---
title: Events
page_title: Events
description: This article lists and explains the events exposed by the RadSyntaxEditor control.
slug: radsyntaxeditor-events
tags: events,radsyntaxeditor
position: 3
---

# Events

Here is a list of events exposed by the RadSyntaxEditor control:

* **PreviewSyntaxEditorKeyUp**: Occurs before the **KeyUp** event when a key is pressed while focus is on this control.
* **PreviewSyntaxEditorKeyDown**: Occurs before the **KeyDown** event when a key is pressed while focus is on this control.
* **PreviewSyntaxEditorMouseLeftButtonDown**: Occurs when the left mouse button is pressed while the mouse pointer is over the control.
* **PreviewSyntaxEditorMouseRightButtonDown**: Occurs when the right mouse button is pressed while the mouse pointer is over the control.
* **PreviewSyntaxEditorInput**: Occurs when the control receives keyboard input.
* **ScaleFactorChanged**: Occurs when the **ScaleFactor** of the control changes.
* **ViewportChanged**: Occurs when the viewport changes. This can happen when the control is resized, it is scrolled, or if its **ScaleFactor** changes.
* **DocumentChanging**: Occurs when the current document is about to change.
* **DocumentChanged**: Occurs when the current document has changed.
* **DocumentContentChanging**: Occurs when the document's content is about to change.
* **DocumentContentChanged**: Occurs when the document's content has changed.
* **LayoutPropertiesChanged**: Occurs when one of the layout related properties has changed.
* **IsReadOnlyChanged**: Occurs when the IsReadOnly property of the control has changed.
* **CommandExecuting**: Occurs when a command is about to be executed.
* **CommandExecuted**: Occurs when a command has been executed.
* **CommandError**: Occurs when a command has been canceled due to an error.
* **SelectionChanged**: Occurs when the selection of the control changes.
* **TextSearched**: Occurs when text is searched in the document.
* **SearchPanelOpened**: Occurs when the search panel is opened. The event is fired by the protected **OnSearchPanelOpened** method of the RadSyntaxEditor which can in turn be overridden to invoke custom logic.
* **SearchPanelClosed**: Occurs when the search panel is closed. The event is fired by the protected **OnSearchPanelClosed** method of the RadSyntaxEditor which can in turn be overridden to invoke custom logic.

## Other

As of **R1 2020**, the **CompletionListWindow** which is of type **CompletionListPopup** exposes a **TextInserting** event. Its arguments are of type **CompletionListTextInsertingEventArgs** and provide the following properties:

* **Cancel**: Gets or sets a value indication whether the text insertion should be cancelled.
* **SpanToReplace**: Gets or sets the span which will be replaced with the inserted text.
* **TextToInsert**: Gets or sets the text that is selected from the CompletionListPopup.

**Example 1** demonstrates how to use this event to replace the text which was entered before an item from the completion list was selected.

__Example 1: Handle the TextInserting event__
```C#

    private void CompletionListWindow_TextInserting(object sender, CompletionListTextInsertingEventArgs e)
    {
        string lineText = this.syntaxEditor.Document.CurrentSnapshot.GetLineFromPosition(this.syntaxEditor.CaretPosition.Index).GetText();
        string[] splitted = lineText.Split(new char[] { ' ' });
        string lastWord = splitted.Last();
        if (e.TextToInsert.ToLower().StartsWith(lastWord.ToLower()))
        {
            int wordLength = lastWord.Length;
            int spanEnd = e.SpanToReplace.Start;
            e.SpanToReplace = Telerik.Windows.SyntaxEditor.Core.Text.Span.FromBounds(spanEnd - wordLength, spanEnd);
        }
    }
```

## See Also

* [Commands]({%slug radsyntaxeditor-commands%})
* [IntelliPrompts]({%slug radsyntaxeditor-features-intelliprompts%})
