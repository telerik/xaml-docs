---
title: RadBarcodeReader 
page_title: RadBarcodeReader 
description: Check our &quot;RadBarcodeReader&quot; documentation article for the RadBarcode {{ site.framework_name }} control.
slug: radbarcodereader-overview
tags: radbarcodereader,
published: True
position: 4
---

# {{ site.framework_name }} RadBarcodeReader 

RadBarcodeReader is the newest addition to the Barcode suite. The aim of the control is to decode image representations of one of the supported barcode symbologies.

Currently, all of the 1D barcodes, offered by Telerik are supported. The list is available [here]({%slug barcode-1d-specifications%}).        

When decoding a barcode image, the control will either display the type and text encoded in the image, or a warning specifying that no known symbology has been detected. A typical layout for the barcode reader is shown below:  
![Rad Barcode Reader-overview](images/RadBarcodeReader-overview.png)

And here is the XAML that produces the result:        

__Example 1: Barcode reader definition__  
<snippet id='radbarcode-radbarcodereader-overview-block_1-xaml' />

The Choose Image button lets the user choose an image path, to the image which will be decoded. The Decode Image triggers the decoding algorithm. The underlying text area is updated with the result of the decoding process.        

The RadBarcodeReader exposes the following properties:
* __OpenButtonText__: Gets or sets the string of the open image button            

* __DecodeButtonText__: Gets or sets the string of the decode image button            

* __ResultText__: Gets the decoded from the image string.

## BarcodeDecoder

If you do not wish to use the default UI provided by the RadBarcodeReader, you can create your own UI and use the **BarcodeDecoder** class to decode the provided image.

For the purpose, you need to create a new instance of the class, set its **ImageSource** property (of type **BitmapSource**) and call its **StartDecoding** method.

The class also exposes a **DecodingComplete** event which is fired once the decoding is completed. Its arguments are of type **DecodingEventArgs** and expose the following properties:

* **CodeType**: The type of the code recognized in the image, such as **Code128**, **UPCA** or **QR**. Its value is of the **BarcodeType** enumeration type.
* **Result**: A **string** representing the decoded text.
* **ErrorMessage**: A **string** representing the error message, which is populated if decoding fails.

**Example 2** demonstrates how you can use the BarcodeDecoder class.

__Example 2: Decoding an image with the BarcodeDecoder__

<snippet id='radbarcode-radbarcodereader-overview-example_2_decoding_an_image_with_the_barcodedecoder-cs' />
<snippet id='radbarcode-radbarcodereader-overview-example_2_decoding_an_image_with_the_barcodedecoder-vb' />


## Decoded Types

In some scenarios, to improve performance, you may want to specify the types of barcodes the reader will try to decode rather than have it iterate over all the available types.

This can also be useful to avoid conflicts between symbologies whose symbols may overlap, for example, **Code39** and **Code39Extended**.

For the purpose, you can use the **DecodeTypes** property of the RadBarcodeReader. It is a flags enumeration which holds the following types:

* **Code11** 
* **Code128** 
* **Code25Interleaved** 
* **Code25Standard** 
* **Code39** 
* **Code39Extended** 
* **Code93** 
* **Code93Extended** 
* **Codebar** 
* **CodeMSI** 
* **EAN13** 
* **EAN128** 
* **EAN8** 
* **Postnet** 
* **Planet** 
* **IntelligentMail** 
* **UPCA** 
* **UPCE** 
* **UPCSupplement2** 
* **UPCSupplement5** 
* **QR** 
* **PDF417** 
* **DataMatrix**

In addition, the following values can also be set:

* **All**: Decode all barcode types. This is the **default value**.
* **OneDimensional**: All 1D barcodes.
* **WidthModulated1D**: All width-modulated 1D barcodes (39/93 Extended included).
* **HeightModulated1D**: All height-modulated 1D barcodes.
* **TwoDimensional**: All 2D barcodes.

__Example 3: Specify DecodeTypes of RadBarcodeReader__  
<snippet id='radbarcode-radbarcodereader-overview-example_2_decoding_an_image_with_the_barcodedecoder-xaml' />

If you're using the **BarcodeDecoder** class to decode the barcode, similarly, you can use its **DecodeTypes** property to predefine the barcode types to be decoded.

__Example 4: Specify DecodeTypes of BarcodeDecoder__  
<snippet id='radbarcode-radbarcodereader-overview-example_2_decoding_an_image_with_the_barcodedecoder-cs' />
<snippet id='radbarcode-radbarcodereader-overview-example_2_decoding_an_image_with_the_barcodedecoder-vb' />


## See Also

* [Supported Types]({%slug barcode-supported-types-overview%})
