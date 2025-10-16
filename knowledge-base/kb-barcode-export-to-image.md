---
title: Create Image From Barcode Without Adding the Control the UI
page_title: Generate Picture From QR Code Without Adding the Component in a Visual Tree
description: Export the RadBarcode control without adding it to the visual tree.
type: how-to
slug: kb-barcode-export-to-image
position: 0
tags: export,picture,generate,ui,visual,tree
ticketid: 1576269
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadBarcode for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to setup RadBarcode in code-behind and export it to an image, without adding it in the visual tree (the UI).

## Solution

To create an image from a WPF control, the control should be measured and arranged. This is done automatically by the framework when you add the control in the visual tree. To export the barcode without displaying it in the UI, measure and arrange it in code and then export it.

The export iself, can be done with [ExportExtensions.ExportToImage]({%slug common-export-support%}) method.


```C#
	public static void SaveQRCodeImage(string text)
	{
		var barcode = new RadBarcode();
		barcode.Background = Brushes.White;
		barcode.Symbology = new QRCode();
		barcode.Value = text;
		var resourceDictionary = new ResourceDictionary() 
		{ 
			Source = new Uri("/Telerik.Windows.Controls.DataVisualization;component/Themes/GenericVisualStudio2019.xaml", UriKind.RelativeOrAbsolute) 
		};
		barcode.Style = (Style)resourceDictionary["BarcodeStyle"];

		var size = new Size(200, 200);
		barcode.Measure(size);
		barcode.Arrange(new Rect(size));
		barcode.InvalidateMeasure();
		barcode.InvalidateArrange();
		barcode.UpdateLayout();

		using (Stream stream = File.Open("../../barcode-image.png", FileMode.OpenOrCreate))
		{
			Telerik.Windows.Media.Imaging.ExportExtensions.ExportToImage(barcode, stream, new PngBitmapEncoder());
		}
	}

	//--------------

	SaveQRCodeImage("https://docs.telerik.com/devtools/wpf/controls/radbarcode/barcode-getting-started");
```
