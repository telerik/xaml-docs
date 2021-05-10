---
title: Getting Started
page_title: Getting Started with WPF Barcode Control 
description: Check our &quot;Getting Started&quot; documentation article for Telerik Barcode for WPF control.
position: 1
slug: barcode-getting-started
---

# Getting Started

This article will guide you through the steps needed to add a basic **RadBarcode** control in your application.

## Assembly References

In order to use __RadBarcode__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisulization__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining a Barcode

If your app is setup, you are ready to add a **RadBarcode** control to it. __Example 1__ demonstrates a QRCode symbology. For more details on the available Barcode symbologies go to the [Supported Types]({%slug barcode-supported-types-overview %}) topic.

#### __[XAML] Example 1: Defining a RadBarcode__
{{region xaml-barcode-getting-started-0}}
	<telerik:RadBarcode Value="https://www.telerik.com/wpf"  Height="200" Width="200" x:Name="barcode">
		<telerik:RadBarcode.Symbology>
			<telerik:QRCode />
		</telerik:RadBarcode.Symbology>
	</telerik:RadBarcode>
{{endregion}}

#### Figure 1: Barcode Getting Started
![Getting Started Example](images/barcode_getting_started.png)

## See Also

- [Key Features]({% slug barcode-key-features%})
- [Supported Barcodes]({% slug barcode-supported-types-overview%})