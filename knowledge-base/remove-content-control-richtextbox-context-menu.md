---
title: Deleting a Content Control in a Context Menu
description: Learn how to delete a content control in a RichTextBox context menu in the ContextMenu_Showing event for UI for WPF.
type: how-to
page_title: How to Remove Content Control in RichTextBox Context Menu for WPF
meta_title: How to Remove Content Control in RichTextBox Context Menu for WPF
slug: remove-content-control-richtextbox-context-menu
tags: richtextbox, ui for wpf, content control, context menu, delete
res_type: kb
ticketid: 1712424
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RichTextBox for UI for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>Current</td>
</tr>
</tbody>
</table>

## Description

I need to delete a content control from the RichTextBox when using a custom context menu in the `ContextMenu_Showing` event.

This knowledge base article also answers the following questions:
- How to add a "Remove Content Control" option inside a RichTextBox context menu?
- How to delete a content control from a document in RichTextBox for WPF?
- How to handle content control deletion through a custom menu in RichTextBox?

## Solution

To delete a content control, use the `SelectAnnotationRange` method of the `Selection` property of the `RadDocument` class. Pass the `SdtRangeStart` instance of the clicked content control as a parameter. Then, invoke the `Delete` method of the `ActiveDocumentEditor` property of the `RadRichTextBox` control.

Follow these steps:

1. Handle the `ContextMenu_Showing` event to add a menu option for removing the content control.
2. Implement logic to detect if the caret is over a content control.
3. Use the `SelectAnnotationRange` method to select the content control and the `Delete` method to remove it.

Here is an example implementation:

```csharp
private void ContextMenu_Showing(object sender, Telerik.Windows.Controls.RichTextBoxUI.Menus.ContextMenuEventArgs e)
{
    if (IsCaretOverContentControl())
    {
        RadMenuItem menuItem = new RadMenuItem()
        {
            Header = "Remove Content Control"
        };
        menuItem.Click += MenuItem_Click;

        ContextMenuGroup contextMenuGroup = new ContextMenuGroup();
        contextMenuGroup.Add(menuItem);
        e.ContextMenuGroupCollection.Add(contextMenuGroup);
    }
}

private void MenuItem_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
    SdtRangeStart sdtRangeStart = GetContainingSdtRangeStart(this.rtb.Document.CaretPosition);
    if (sdtRangeStart == null || sdtRangeStart.SdtEnd == null)
        return;

    this.rtb.Document.Selection.SelectAnnotationRange(sdtRangeStart);
    this.rtb.ActiveDocumentEditor.Delete(false);
}

private bool IsCaretOverContentControl()
{
    var caretPosition = this.rtb.Document.CaretPosition;

    SdtRangeStart sdtStart = GetContainingSdtRangeStart(caretPosition);
    return sdtStart != null;
}

private SdtRangeStart GetContainingSdtRangeStart(DocumentPosition caretPosition)
{
    var paragraph = caretPosition.GetCurrentParagraph();
    if (paragraph == null)
        return null;

    var element = caretPosition.GetCurrentInline();
    DocumentElement current = element as DocumentElement;

    while (current != null)
    {
        if (current is SdtRangeEnd)
            return null;

        if (current is SdtRangeStart sdtStart)
            return sdtStart;

        current = current.PreviousSibling;
    }

    return null;
}
```

### Key Details:
- The `ContextMenu_Showing` event customizes the context menu by adding a "Remove Content Control" option.
- The `MenuItem_Click` method performs the deletion by selecting and removing the content control.

## See Also

- [RichTextBox Overview](https://docs.telerik.com/devtools/wpf/controls/richtextbox/overview)
- [Context Menu Customization in RichTextBox](https://docs.telerik.com/devtools/wpf/controls/richtextbox/features/context-menu)
- [RadRichTextBox API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.radrichtextbox)
