---
title: Upgrading to the new version of RadBarcode
page_title: WPF Barcode Documentation - Upgrading to the new version of RadBarcode
description: Check our &quot;Upgrading to the new version of RadBarcode&quot; documentation article for Telerik Barcode for WPF control.
position: 2
slug: barcode-upgrading
---

# Upgrading to the new version of RadBarcode

Since the __R2 2021__ release the RadBarcode has a new and improved version, which will support more features. The older version will be deprecated, however upgrading is easy and this article will walk you through the process. 

## General Guidelines

This section contains an overview of how you can take advantage of the new barcode. Previously there were multiple classes (RadBarcode11, RadBarcodeQR, RadBarcodeCodebar) each responsible for handling a different type of barcode. The new version only contains one __RadBarcode__ class and you can use its __Symbology__ property in order to specify the type of barcode. The properties that were previously available on the specific barcode class are now available on the Symbology level. Additionally the __Text__ property should be replaced with __Value__. The next section contains some specific examples demonstrating the upgrade process.

## Examples 

__Example 1__ demonstrates how to upgrade the __RadBarcode128__ class.

__Example 1: RadBarcode128 Upgrade__  
```C#

    <!-- old version -->
	<telerik:RadBarcode128 Text="CODE 128" ShowChecksum="True" RestrictAspectRatio="False" />

    <!-- new version -->
    <telerik:RadBarcode Value="CODE 128">
        <telerik:RadBarcode.Symbology>
            <telerik:Code128 AutoChecksum="True" SizingMode="Stretch" />
        </telerik:RadBarcode.Symbology>
    </telerik:RadBarcode>
```

__Example 2__ demonstrates how to upgrade the __RadBarcodeQR__ class.

__Example 2: RadBarcodeQR Upgrade__  
```C#

    <!-- old version -->
	<telerik:RadBarcodeQR ApplicationIndicator="App1"
                                       ECI="None"
                                       ErrorCorrectionLevel="M"
                                       FNC1="FNC1FirstPosition"
                                       Mode="Byte"
                                       Version="11"
                                       Text="www.telerik.com"/>

    <!-- new version -->
    <telerik:RadBarcode Value="www.telerik.com">
        <telerik:RadBarcode.Symbology>
            <telerik:QRCode ApplicationIndicator="App1"
                                    ECIMode="None"
                                    ErrorCorrectionLevel="L"
                                    FNC1Mode="FirstPosition"
                                    CodeMode="Byte"
                                    Version="11"/>
        </telerik:RadBarcode.Symbology>
    </telerik:RadBarcode>
```

__Example 3__ demonstrates how to upgrade the __RadBarcodePDF417__ class.

__Example 3: RadBarcodePDF417 Upgrade__  
```C#

    <!-- old version -->
	<telerik:RadBarcodePDF417 Columns="5"
                                               Rows="3"
                                               EncodingMode="Numeric"
                                               ErrorCorrectionLevel="4"
                                               Text="www.telerik.com"/>

    <!-- new version -->
    <telerik:RadBarcode Value="www.telerik.com">
        <telerik:RadBarcode.Symbology>
            <telerik:PDF417 Columns="5"
                                        Rows="3"
                                        EncodingMode="Numeric"
                                        ErrorCorrectionLevel="4"/>
        </telerik:RadBarcode.Symbology>
    </telerik:RadBarcode>
```

## Newly Supported Formats

The upgraded version of the RadBarcode supports some new barcode types (DataMatrix, EAN128, EAN128A, EAN128B, EAN128C, IntelligentMail, Planet). For more information, check out the [Supported Types]({%slug barcode-supported-types-overview %}) article. 

## See Also

- [Supported Types]({%slug barcode-supported-types-overview %})
