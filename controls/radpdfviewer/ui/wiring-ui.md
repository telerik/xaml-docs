---
title: Wiring UI
page_title: Wiring UI
description: Check our &quot;Wiring UI&quot; documentation article for the RadPdfViewer WPF control.
slug: radpdfviewer-wiring-ui
tags: wiring,ui
published: True
position: 0
---

# Wiring UI

`RadPdfViewer` provides commands and respective command descriptors that you can easily bind to when creating UI. They are available via the `CommandDescriptors` property of the control. This allows you to bind the command descriptors to any UI element that supports commanding, such as `Button`, `MenuItem`, `RadButton`, `RadMenuItem`, etc.

## Default Command descriptors

The commandDescriptors collection of RadPdfViewer is predefined with a set of default command descriptors. Each command descriptor corresponds to a specific command that the `RadPdfViewer` supports. These commands include actions such as opening a PDF document, navigating through pages, zooming in and out, and more.

>tip Each command descriptor provides a `Command` property that you can bind to the `Command` property of your UI element.

The CommandDescriptors collection exposes the following command descriptors:

* `OpenCommandDescriptor`&mdash;Opens a PDF document in the viewer.
* `SaveAsCommandDescriptor`&mdash;Saves the current PDF document to a specified location.
* `PageUpCommandDescriptor`&mdash;Navigates to the previous page in the document.
* `PageDownCommandDescriptor`&mdash;Navigates to the next page in the document.
* `ZoomInCommandDescriptor`&mdash;Increases the zoom level of the document.
* `ZoomOutCommandDescriptor`&mdash;Decreases the zoom level of the document.
* `PrintCommandDescriptor`&mdash;Prints the current PDF document.
* `CopyCommandDescriptor`&mdash;Copies the selected text to the clipboard.
* `SelectAllCommandDescriptor`&mdash;Selects all text in the document.
* `MoveCaretLineDownCommandDescriptor`&mdash;Moves the caret down one line in the text.
* `MoveCaretLineUpCommandDescriptor`&mdash;Moves the caret up one line in the text.
* `MoveCaretToStartOfDocumentCommandDescriptor`&mdash;Moves the caret to the start of the document.
* `MoveCaretToEndOfDocumentCommandDescriptor`&mdash;Moves the caret to the end of the document.
* `MoveCaretToLineStartCommandDescriptor`&mdash;Moves the caret to the start of the current line.
* `MoveCaretToLineEndCommandDescriptor`&mdash;Moves the caret to the end of the current line.
* `MoveCaretToNextWordCommandDescriptor`&mdash;Moves the caret to the next word in the text.
* `MoveCaretToPreviousWordCommandDescriptor`&mdash;Moves the caret to the previous word in the text.
* `MoveCaretToNextCharacterCommandDescriptor`&mdash;Moves the caret to the next character in the text.
* `MoveCaretToPreviousCharacterCommandDescriptor`&mdash;Moves the caret to the previous character in the text.
* `ShowFindDialogCommandDescriptor`&mdash;Displays the find dialog for searching text in the document.
* `FitToWidthCommandDescriptor`&mdash;Adjusts the zoom level to fit the page width to the viewer.
* `FitToPageCommandDescriptor`&mdash;Adjusts the zoom level to fit the entire page to the viewer.
* `FindCommandDescriptor`&mdash;Finds the next occurrence of the specified text in the document.
* `FindPreviousCommandDescriptor`&mdash;Finds the previous occurrence of the specified text in the document.
* `RotateClockwiseCommandDescriptor`&mdash;Rotates the document 90 degrees clockwise.
* `RotateCounterClockwiseCommandDescriptor`&mdash;Rotates the document 90 degrees counter-clockwise.
* `SetFixedDocumentPagesPresenterCommandDescriptor`&mdash;Sets the document presenter to pages view mode.
* `SetFixedDocumentSinglePageViewPresenterCommandDescriptor`&mdash;Sets the document presenter to single page view mode.
* `FitToPageFixedDocumentSinglePageViewPresenterCommandDescriptor`&mdash;Adjusts the zoom to fit the page when in single page view mode.
* `FitToWidthFixedDocumentPagesPresenterCommandDescriptor`&mdash;Adjusts the zoom to fit the page width when in pages view mode.
* `ActivateBookmarkItemCommandDescriptor`&mdash;Activates a bookmark item and navigates to its destination or executes its action.
* `SyncCurrentBookmarkItemCommandDescriptor`&mdash;Synchronizes the current bookmark item with the viewer's current position.
* `ValidateSignaturesCommandDescriptor`&mdash;Validates all digital signatures in the document.
* `ShowSignaturePropertiesDialogCommandDescriptor`&mdash;Displays the properties dialog for a selected signature.
* `ShowSignSignatureDialogCommandDescriptor`&mdash;Displays the dialog for signing a signature field.
* `SignSignatureCommandDescriptor`&mdash;Signs a signature field in the document.
* `MoveDownCommandDescriptor`&mdash;Moves down in the document (moves caret down in text selection mode or scrolls down in pan mode).
* `MoveUpCommandDescriptor`&mdash;Moves up in the document (moves caret up in text selection mode or scrolls up in pan mode).
* `MoveRightCommandDescriptor`&mdash;Moves right in the document (moves caret right in text selection mode or scrolls right in pan mode).
* `MoveLeftCommandDescriptor`&mdash;Moves left in the document (moves caret left in text selection mode or scrolls left in pan mode).

>tip Find a runnable project showing RadPdfViewer in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/FirstLook). The project is wired to work with `RadToolBar` and `RadContextMenu`. You can note how the DataContext of the toolbar is bound to the instance of RadPdfViewer on the same page.