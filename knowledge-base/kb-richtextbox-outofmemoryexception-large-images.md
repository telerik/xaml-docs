---
title: OutOfMemoryException Occurs when Inserting or Manipulating Large Images in RadRichTextBox
description: Learn why inserting or manipulating extremely large images in RadRichTextBox can cause performance issues or an OutOfMemoryException.
components: ["richtextbox"]
type: troubleshooting
page_title: RadRichTextBox OutOfMemoryException when Inserting or Manipulating Images
slug: kb-richtextbox-outofmemoryexception-large-images
tags: radrichtextbox, troubleshooting, outofmemoryexception, images, radbitmap, writeablebitmap
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadRichTextBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

RadRichTextBox uses the `RadBitmap` class to visualize images. `RadBitmap`, in turn, internally uses <a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.imaging.writeablebitmap" target="_blank">WriteableBitmap</a>.

`WriteableBitmap` is not always efficient when populated with an extremely large image, and inserting or manipulating (for example, applying an effect to) such an image can cause a performance diminishment as well as an `OutOfMemoryException`.

## Solution

There is currently no workaround that lets RadRichTextBox handle extremely large images without the performance and memory impact described above. Reduce the size of an image before you insert it in the document to avoid the issue.

## See Also

* [Getting Started]({%slug radrichtextbox-getting-started%})
