---
title: Open a RadOpenFileDialog when Using the RadCloudUpload
description: Replace the Default OpenFileDialog when Browsing Files.
type: how-to
page_title: Use a RadOpenFileDialog to Select the Files to be Uploaded
slug: kb-cloudupload-howto-show-radfileopendialog
position: 0
tags: cloudupload, replace, openfiledialog
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadCloudUpload for WPF</td>
	</tr>
</table>

## Description

How to replace the default MS OpenFileDialog with a [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%}).

## Solution

Handle the __AddingFiles__ event of the RadCloudUpload control, cancel the creation of the default dialog with the **CancelDialogOpening** property, open a new RadOpenFileDialog and populate the **FileNames** collection with the files, selected in the dialog.


```C#
    private void RadCloudUpload_AddingFiles(object sender, AddingFilesEventArgs e)
    {
        e.CancelDialogOpening = true;

        if (fileDialog == null)
        {
            fileDialog = new RadOpenFileDialog();
            fileDialog.Multiselect = true;
        }

        if (fileDialog.ShowDialog() == true)
        {
            foreach (var file in fileDialog.FileNames)
            {
                e.FileNames.Add(file);
            }
        }
    }
```
```VB.NET
	Private Sub RadCloudUpload_AddingFiles(ByVal sender As Object, ByVal e As AddingFilesEventArgs)
		e.CancelDialogOpening = True

		If fileDialog Is Nothing Then
			fileDialog = New RadOpenFileDialog()
			fileDialog.Multiselect = True
		End If

		If fileDialog.ShowDialog() = True Then
			For Each file In fileDialog.FileNames
				e.FileNames.Add(file)
			Next file
		End If
	End Sub
```

## See Also

* [RadCloudUpload Eventts]({%slug radcloudupload-features-events%})
* [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})