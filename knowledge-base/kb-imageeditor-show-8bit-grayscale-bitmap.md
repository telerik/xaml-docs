---
title: How To Display 8-bit Grayscale BitmapImage
description: this topic describes how to display 8-bit grayscale bitmapimage in RadImageEditor control.
type: how-to
page_title: Show 8-bit Grayscale BitmapImage Inside RadImageEditor
slug: kb-imageeditor-show-8bit-grayscale-bitmap
position: 
tags: imageeditor, bitmapimage, 8-bit, 8 bit, grayscale
ticketid: 1457141
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.917</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadImageEditor for WPF</td>
		</tr>
	</tbody>
</table>


## Solution
To show a grayscale image, you can use the FormatConvertedBitmap class as shown in the [following article](https://www.c-sharpcorner.com/uploadfile/mahesh/grayscale-image-in-wpf/). The following code snippet demonstrate this approach:


```C#
	private void CreateGrayScaleImage()
	{
		var bmpImage = new BitmapImage();
		bmpImage.BeginInit();
		bmpImage.UriSource = new Uri(@"C:\images\myImage.png", UriKind.RelativeOrAbsolute);
		bmpImage.EndInit();

		var grayBitmap = new FormatConvertedBitmap();
		grayBitmap.BeginInit();
		grayBitmap.Source = bmpImage;
		grayBitmap.DestinationFormat = PixelFormats.Gray8;
		grayBitmap.EndInit();

		this.radImageEditor.Image = new RadBitmap(grayBitmap);
	}
```


