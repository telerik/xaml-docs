---
title: Settings
page_title: WPF Barcode Documentation - Data Matrix Settings
description: Check our &quot;Settings&quot; documentation article for Telerik Barcode for WPF control.
position: 0
published: True
slug: barcode-data-matrix-settings
---

# Settings

This article explains the specific Data Matrix code settings.

## Encodation

The encodation determines the type of contents encoded by the Data Matrix barcode. Choosing a proper encodation imposes validation rules, but reduces the barcode size and improves its readability.

The following table shows the supported encodations and provides information about their restrictions and data storing requirements:

* **ASCII**: Allowed characters include double digit numerics and all values from the ASCII table. The double digit numerics use 4 bits. The ASCII values in the 0-127 range use 8 bits. The ASCII values in 128-255 range use 16 bits.

* **C40**: Used primarily for upper-case alphanumerics. The upper-case alphanumeric characters use 5.33 bits. The lower-case and special characters use 10.66 bits.

* **Text**: Used primarily for lower-case alphanumerics. The lower-case alphanumeric characters use 5.33 bits. The upper-case and special characters use 10.66 bits.

* **X12**: Uses the characters from ANSI X12 EDI data set. Each character takes 5.33 bits.

* **EDIFACT**: Used to encode ASCII values in the 32-94 range. Each character takes 6 bits.

* **Base256**: Used to encode characters in the whole ASCII range. Each character takes 8 bits.

* **AsciiGS1**: Used to encode FNC1 characters in the ASCII range

## SymbolSize

Sets the symbol size and shape of the generated barcode. It can be automatically determined using SquareAuto or RectangleAuto, or specific like __Square32x32__ or __Rectangle16x48__.

## TextEncoding

Determines character encoding used to encode the barcode contents. By default it is set to UTF-8, which uses more bits per character and may increase the size of the barcode image.

__Example 1: DataMatrix Example__  
```C#
	<telerik:RadBarcode Value="https://www.telerik.com/wpf" Height="200" Width="200" x:Name="barcode" Foreground="Black"  VerticalAlignment="Top">
		<telerik:RadBarcode.Symbology>
			<telerik:DataMatrix  />
		</telerik:RadBarcode.Symbology>
	</telerik:RadBarcode>
```

## See Also

* [Key Features]({% slug barcode-key-features%})
* [Supported Barcodes]({% slug barcode-supported-types-overview%})
