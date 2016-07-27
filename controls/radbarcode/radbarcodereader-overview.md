---
title: RadBarcodeReader 
page_title: RadBarcodeReader 
description: RadBarcodeReader 
slug: radbarcodereader-overview
tags: radbarcodereader,
published: True
position: 4
---

# RadBarcodeReader 

RadBarcodeReader is the newest addition to the Barcode suite. The aim of the control is to decode image representations of one of the supported barcode symbologies.

Currently, all of the 1D barcodes, offered by Telerik are supported. The list is available [here]({%slug radbarcode-barcode-specifications%}).        

When decoding a barcode image, the control will either display the type and text encoded in the image, or a warning specifying that no known symbology has been detected. A typical layout for the barcode reader is shown below:  
![Rad Barcode Reader-overview](images/RadBarcodeReader-overview.png)

And here is the XAML that produces the result:        

#### __[XAML] Example 1: Barcode reader definition__  
{{region xaml-radbarcodereader-overview-0}}
	<!--The values below are the default ones, so you do not need to specify them-->
	<telerik:RadBarcodeReader OpenButtonText="Choose Image" DecodeButtonText="Decode Image"/>
{{endregion}}

The Choose Image button lets the user choose an image path, to the image which will be decoded. The Decode Image triggers the decoding algorithm. The underlying text area is updated with the result of the decoding process.        

The RadBarcodeReader exposes the following properties:
* __OpenButtonText__ - gets or sets the string of the open image button            

* __DecodeButtonText__ - gets or sets the string of the decode image button            

* __ResultText__ - gets the decoded from the image string.