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
* **FoldingChanged**: Occurs when a folding region is created, removed, opened or closed.

## See Also

* [Commands]({%slug radsyntaxeditor-commands%})
