---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbarcodeqr-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started


## 


>In order to use __RadBarcodeQR__ in your projects you have to add references to the following two assemblies:<br/> * __Telerik.Windows.Data.dll__ <br/> * __Telerik.Windows.Controls.dll__ <br/> * __Telerik.Windows.Controls.DataVisualization.dll__

You also have to declare the following namespace in your UserControl:

#### __XAML__

{{region radbarcodeqr-getting-started-telerik-xmlns-definition}}
	 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}

## Defining RadBarcodeQR

#### __XAML__

{{region radbarcodeqr-getting-started-qrcode-declaration}}
	<telerik:RadBarcodeQR  Version="20" ErrorCorrectionLevel="H" Text="Sample text" 
							Mode="Byte" ECI="ISO8859_1" 
							FNC1="FNC1SecondPosition" 
							ApplicationIndicator="00">
	</telerik:RadBarcodeQR>
{{endregion}}



## See Also

__Other Resources__

[Overview](a881ccfb-f368-4cf7-b14c-6896efd15f5e)

[QRCode Visual Structure]({%slug radbarcodeqr-qrcode-visual-structure%})

[QRCode Properties]({%slug radbarcodeqr-features%})
