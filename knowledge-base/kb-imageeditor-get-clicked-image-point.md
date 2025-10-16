---
title: Get Click Coordinates Relative to the Image of RadImageEditor
description: How to get the image cooridnates of clicked point in the RadImageEditor control.
type: how-to
page_title: Get Clicked Point on the ImageEditor Image Control
slug: kb-imageeditor-get-clicked-image-point
position: 0
tags: imageeditor
ticketid: 1531598
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.2.511</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadImageEditor for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to get the image cooridnates of the clicked point in the RadImageEditor control.

## Solution

To do this, you can subscribe to the MouseLeftButtonDown event of RadImageEditor and calculate the coordinates based on the mouse position, the image size and the control's size.


```C#
	 public MainWindow()
	 {
     		InitializeComponent();
     		this.imageEditor.AddHandler(RadImageEditor.MouseLeftButtonDownEvent, new MouseButtonEventHandler(imageEditor_MouseLeftButtonDown), true);
 	}
  
	private void imageEditor_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		var image = e.OriginalSource as Image;
		if (image != null)
		{
			Point mousePosition = e.GetPosition(image);
			double relativeWidth = mousePosition.X / image.ActualWidth;
			double relativeHeight = mousePosition.Y / image.ActualHeight;
			
			var originalImageWidth = ((WriteableBitmap)image.Source).PixelWidth;
			var originalImageHeight = ((WriteableBitmap)image.Source).PixelHeight;

			var pixelXPosition = originalImageWidth * relativeWidth;
			var pixelYPosition = originalImageHeight * relativeHeight;
		}
	}
```

