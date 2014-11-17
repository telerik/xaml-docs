---
title: Customize PDF Rendering
page_title: Customize PDF Rendering
description: Customize PDF Rendering
slug: radpdfviewer-customize-pdf-rendering
tags: customize,pdf,rendering
published: True
position: 0
---

# Customize PDF Rendering



__RadPdfViewer__ provides some customization options for the way PDF documents are rendered.
      

## Creating a Decoder

When rendering the text, RadPdfViewer uses different decoders. It finds the decoder that it needs to use by its name. These are the decoders that can be plugged:
        

* __ASCIIHexDecode__

* __ASCII85Decode__

* __LZWDecode__

* __FlateDecode__

* __RunLengthDecode__

* __CCITTFaxDecode__

* __JBIG2Decode__

* __DCTDecode__

* __JPXDecode__

The following table indicates the status of the respective decoders in RadPdfViewer:
        
<table><tr><td>

Fully supported</td>
<td>Partially supported</td>
<td>Not supported</td></tr>
</th>
<tr><td>ASCII85Decode</td>
<td>ASCIIHexDecode</td>
<td>JBIG2Decode</td></tr>
<tr><td>LZWDecode</td>
<td></td>
<td>JPXDecode</td></tr>
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
<td></td></tr></table>

All decoders implement the __IPdfFilter__ interface and if you decide, you can implement your own decoder and set the viewer to use it. RadPdfViewer uses the __Name__ property in order to recognize the filter - it must return one of the values listed above.
        

For example, you can create a custom decoder for Tiff images by implementing the interface and setting the Name of the filter to CCITTFaxDecode. Then, just register the new class by calling FiltersManager.RegisterFilter() method and the viewer will use your implementaion instead of the default one.
        

Inheriting from IPdfFilter will result in the following:

#### __CS__

{{region radpdfviewer-customize-pdf-rendering_0}}
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
{{endregion}}


You should also register the filter as follows:{% if site.site_name == 'Silverlight' %}

#### __CS__

{{region radpdfviewer-customize-pdf-rendering_1}}
	private PDFAndTiffFilter _filter;
	
	public MainPage()
	{
	    _filter = new PDFAndTiffFilter();
	    FiltersManager.RegisterFilter(_filter);
	    InitializeComponent();
	}
{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __CS__

{{region radpdfviewer-customize-pdf-rendering_2}}
	private PDFAndTiffFilter _filter;
	
	public MainWindow()
	{
	    _filter = new PDFAndTiffFilter();
	    FiltersManager.RegisterFilter(_filter);
	    InitializeComponent();
	}
{{endregion}}

{% endif %}

The result that a custom filter should return depends on the type of the filter. For the binary filters it is enough to decode the byte array into decoded byte array using the respective algorithm. As for the filters listed below, additional transformation is required.
        

RadPdfViewer expects these filters to return data that depends on the decoded object's colors space and bits per component (there are such properties in the __decodedObject__). The resulting byte array should contain exactly BitsPerComponent bits for each color component in the color space. For example, if you have RGB color space and 8 bits per component, the resulting byte array should contains a single byte value for each Red, Green and Blue value (for each pixel) in the decoded image.
        

* __CCITTFaxDecode__

* __JBIG2Decode__

* __DCTDecode__

* __JPXDecode__