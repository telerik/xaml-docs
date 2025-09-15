---
title: Paste an Image from the Clipboard to RadImageEditor
description: How to paste an image file or selection from the clipboard to RadImageEditor.
type: how-to
page_title: Get an Image from the Clipboard and Load it in RadImageEditor
slug: kb-image-editor-paste-image-from-clipboard
position: 0
tags: radimageeditor,paste,image,clipboard
ticketid: 1409064
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadImageEditor for WPF</td>
	</tr>
</table>


## Description

Paste an image file or selection from the clipboard to RadImageEditor.

## Solution

The following code snippet demonstrates how to get an image from the clipboard and load it in RadImageEditor.


```C#

	this.ImageEditor.KeyUp += (s, e) =>
	{
		if (e.Key == Key.V && KeyboardModifiers.IsControlDown)
		{
			var image = Clipboard.GetImage();
			if (image != null)
			{
				this.ImageEditor.Image = new RadBitmap(image);
			}
			else
			{
				var files = Clipboard.GetFileDropList();

				if (files.Count > 0)
				{
				 	var file = new FileStream(files[0], FileMode.Open);
				 	this.ImageEditor.Image = new RadBitmap(file);
				}
			}
		}
	};
```
```VB.NET

 	AddHandler Me.ImageEditor.KeyUp, Sub(s, e)
		If e.Key = Key.V AndAlso KeyboardModifiers.IsControlDown Then
		  Dim image = Clipboard.GetImage()
		  If image IsNot Nothing Then
			Me.ImageEditor.Image = New RadBitmap(image)
		  Else
			Dim files = Clipboard.GetFileDropList()
			If files.Count > 0 Then
				Dim file = New FileStream(files(0), FileMode.Open)
				Me.ImageEditor.Image = New RadBitmap(file)
			End If
		  End If
		End If
	End Sub
```

The first if statement checks whether an image was copied from another image. If this is not the case, we check whether a whole image file has been copied to the clipboard.
