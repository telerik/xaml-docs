---
title: Customize PDF Rendering
page_title: Customize PDF Rendering
description: Check our &quot;Customize PDF Rendering&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-customize-pdf-rendering
tags: customize,pdf,rendering
published: True
position: 0
---

# Customize PDF Rendering

__RadPdfViewer__ provides customization options for the way PDF documents are rendered.      

## Creating a Decoder

When rendering the content, RadPdfViewer uses different decoders. It finds the decoder that it needs to use by its name. These are the decoders that can be plugged:        

* __ASCIIHexDecode__

* __ASCII85Decode__

* __LZWDecode__

* __FlateDecode__

* __RunLengthDecode__

* __CCITTFaxDecode__

* __JBIG2Decode__

* __DCTDecode__

* __JPXDecode__

**Table 1** indicates the status of the respective decoders in RadPdfViewer.
        
#### **Table 1: Decoders support in RadPdfViewer**
<table><tr><td>

Fully supported</td>
<td>Partially supported</td>
<td>Not supported</td></tr>
</th>
<tr><td>ASCII85Decode</td>
<td>CCITTFaxDecode</td>
<td>JPXDecode</td></tr>
<tr><td>LZWDecode</td>
<td></td>
<td></td></tr>
<tr><td>FlateDecode</td>
<td></td>
<td></td></tr>
<tr><td>DCTDecode</td>
<td></td>
<td></td></tr>
<tr><td>ASCIIHexDecode</td>
<td></td>
<td></td></tr>
<tr><td>RunLengthDecode</td>
<td></td>
<td></td></tr>
<tr>
<td>JBIG2Decode</td><td></td><td></td></tr></table>

>tip Although **JPXDecode** is not supported out-of-the-box, you can implement a custom decoder and enable RadPdfViewer to read and render the content that uses this filter following the guides in this article. An implementation of this scenario is available in the [Custom Decoder example](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomDecoder) from our SDK repository as well. 

All decoders implement the __IPdfFilter__ interface and if you decide, you can implement your own decoder and set the viewer to use it. RadPdfViewer uses the __Name__ property in order to recognize the filter - it must return one of the values listed above.        

For example, you can create a custom decoder for Tiff images by implementing the interface and setting the Name of the filter to CCITTFaxDecode. Then, just register the new class by calling FiltersManager.RegisterFilter() method and the viewer will use your implementation instead of the default one.
        
The cod from **Example 1** shows the members that should be implemented when inheriting the IPdfFilter interface.

#### **[C#] Example 1: Members of IPdfFilter**

```C#
	public class CustomFilter : IPdfFilter
	{
	    public byte[] Encode(PdfObject encodedObject, byte[] inputData)
	    {
	        throw new NotImplementedException();
	    }
	
	    public byte[] Decode(PdfObject decodedObject, byte[] inputData, DecodeParameters parms)
	    {
	        throw new NotImplementedException();
	    }
	
	    public string Name { get { return PdfFilterNames.CCITTFaxDecode; } }
	}
```

You should also register the filter as demonstrated in **Example 2**:

#### **[C#] Example 2: Register a custom filter**

```C#
	private PDFAndTiffFilter _filter;
	
	public MainWindow()
	{
	    _filter = new PDFAndTiffFilter();
	    FiltersManager.RegisterFilter(_filter);
	    InitializeComponent();
	}
```

The result that a custom filter should return depends on the type of the filter. For the binary filters it is enough to decode the byte array into decoded byte array using the respective algorithm. As for the filters listed below, additional transformation is required.
        
* **CCITTFaxDecode**

* **JBIG2Decode**

* **JPXDecode**

* **DCTDecode**
	>You can override the DctDecode class and its Decode() method. This will enable you to call the DecodeWithJpegDecode() method in order to achieve backward compatibility by using Telerik's JpegDecoder. In some cases, this approach decodes faster than the BitmapImage class, which is currently used to decode the images.


RadPdfViewer expects these filters to return data that depends on the decoded object's colors space and bits per component (there are such properties in the __decodedObject__). The resulting byte array should contain exactly BitsPerComponent bits for each color component in the color space. For example, if you have RGB color space and 8 bits per component, the resulting byte array should contains a single byte value for each Red, Green and Blue value (for each pixel) in the decoded image.
        
## See Also 

* [Custom Document Presenter]({%slug radpdfviewer-customization-and-extensibility-custom-document-presenter%})