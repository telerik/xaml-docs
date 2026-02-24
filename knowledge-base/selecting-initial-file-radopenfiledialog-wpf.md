---
title: Selecting Initial File in RadOpenFileDialog in UI for WPF
description: Learn how to select the initial file in RadOpenFileDialog when opening it.
type: how-to
page_title: How to Select an Initial File in RadOpenFileDialog in UI for WPF
meta_title: How to Select an Initial File in RadOpenFileDialog in UI for WPF
slug: selecting-initial-file-radopenfiledialog-wpf
tags: filedialogs, radopenfiledialog, wpf, loaded-event, childrenoftype, filebrowserlistbox, filename
res_type: kb
ticketid: 1709974
---

## Environment

<table>
<tbody>
<tr>
<td> Product </td>
<td> 
UI for WPF RadFileDialogs
</td>
</tr>
<tr>
<td> Version </td>
<td> Current </td>
</tr>
</tbody>
</table>

## Description

I need to select an initial file in [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%}) when opening it. While setting the `FileName` property displays the path in the edit box at the bottom of the dialog, the file is not selected in the file list.

This knowledge base article also answers the following questions:
- How do I preselect a file in RadOpenFileDialog?
- How to set the selected file in RadOpenFileDialog in UI for WPF?
- How can I highlight a file in RadOpenFileDialog's file list?

## Solution

RadOpenFileDialog does not provide this functionality out of the box. To achieve this, use custom logic by subscribing to the `Loaded` event of the dialog. Retrieve the `FileBrowserListBox` element using the `ChildrenOfType` extension method and set its `SelectedItem` property to the file matching the `FileName` property.

Follow these steps:

1. Subscribe to the `Loaded` event of the RadOpenFileDialog instance.
2. Access the `FileBrowserListBox` element using the `ChildrenOfType` extension method.
3. Check if its items contain a file matching the `FileName` property of RadOpenFileDialog.
4. Set the matching file to the `SelectedItem` property of `FileBrowserListBox`.

Here is the code snippet implementing this logic:

```csharp
private void OpenFileDialog_Loaded(object sender, RoutedEventArgs e)
{
    RadOpenFileDialog openFileDialog = (RadOpenFileDialog)sender;

    // Retrieve the FileBrowserListBox element.
    FileBrowserListBox fileBrowserListBox = openFileDialog.ChildrenOfType<FileBrowserListBox>().FirstOrDefault();

    if (fileBrowserListBox != null)
    {
        // Find the file matching the FileName property.
        FileSystemInfoWrapper selectedFileSystemInfoWrapper = fileBrowserListBox.ItemsSource
            .Cast<FileSystemInfoWrapper>()
            .Where(x => openFileDialog.FileName.Contains(x.Name))
            .FirstOrDefault();

        if (selectedFileSystemInfoWrapper != null)
        {
            // Set the matching file as the selected item.
            fileBrowserListBox.SelectedItem = selectedFileSystemInfoWrapper;
        }
    }
}
```

Attach the `Loaded` event handler to the dialog:

```csharp
RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
openFileDialog.Loaded += OpenFileDialog_Loaded;
```

This approach ensures that the specified file is selected in the file list when the dialog is displayed.
