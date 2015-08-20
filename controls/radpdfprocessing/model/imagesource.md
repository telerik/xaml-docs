---
title: ImageSource
page_title: ImageSource
description: ImageSource
slug: radpdfprocessing-model-imagesource
tags: imagesource
published: True
position: 5
---

# ImageSource



__ImageSource__ represents a single, constant set of pixels at a certain size. It can be used by multiple [Image]({%slug radpdfprocessing-model-image%}) objects in order to be drawn in a PDF file.
      

## Creating ImageSource

The ImageSource class has five public contrustor overloads and can be created from a [Stream](http://msdn.microsoft.com/en-us/library/system.io.stream(v=vs.110).aspx), [BitmapSource](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.bitmapsource(v=vs.110).aspx) object or using the [__EncodedImageData__](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_Model_Resources_EncodedImageData.htm) class:

* __public ImageSource(Stream stream)__: Creates an __ImageSource__ object from a stream that contains image.

* __public ImageSource(Stream stream, FormatProviders.Pdf.Export.ImageQuality imageQuality)__: Creates an __ImageSource__ object from a stream and allows to specify the image quality through the [ImageQuality enumeration](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_FormatProviders_Pdf_Export_ImageQuality.htm).

* __public ImageSource(BitmapSource bitmapSource)__: Creates a new __ImageSource__ object from a BitmapSource object.

* __public ImageSource(BitmapSource bitmapSource, FormatProviders.Pdf.Export.ImageQuality imageQuality)__: Creates an __ImageSource__ instance from a BitmapSource object and allows to specify the image quality.

* __public ImageSource(EncodedImageData imageSourceInfo)__: Initializes a new instance of __ImageSource__ using the  [EncodedImageData class](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_Model_Resources_EncodedImageData.htm).
        

__Example 1__ illustrates how you can create an ImageSource using a __FileStream__.
        

#### __[C#] Example 1: Create ImageSource from Stream__

{{region radpdfprocessing-model-imagesource_0}}
    using (FileStream source = File.Open(filename, FileMode.Open))
    {
        ImageSource imageSource = new ImageSource(source);
    }
{{endregion}}


With the __EncodedImageData__ class you can create an __ImageSource__ with encoded image data. This way the image quality will not be reduced on import.

__Example 2__ demonstrates how you can create an __ImageSource__ using the __EncodedImageData__ class.
        

#### __[C#] Example 2: Create ImageSource from Encoded Image Data__
{{region radpdfprocessing-model-imagesource_2}}
	EncodedImageData imageData = new EncodedImageData(imageBytes, 8, 655, 983, ColorSpaceNames.DeviceRgb, new string[] { PdfFilterNames.DCTDecode });
{{endregion}}

## Methods

The ImageSource class exposes two methods, which could help you to get the data from the ImageSource object.

* __BitmapSource GetBitmapSource()__: Gets the BitmapSource of the image.

* __EncodedImageData GetEncodedImageData()__: Returns the encoded image data. This method can be used if you need to directly export the images from the PDF document.

>tip You could check this [example in our SDK repository](https://github.com/telerik/xaml-sdk/tree/master/PdfProcessing/CreateDocumentWithImages), which demonstrates how to insert JPEG and JPEG2000 images in a PDF document without the need of decoding the images on import. This way the exported images will not be re-encoded and their image quality will be preserved.

## Extensions

__RadPdfProcessing__ exposes an extension method allowing to convert every BitmapSource to an ImageSource that can be used for the creation of [Image]({%slug radpdfprocessing-model-image%}) elements. __Example 3__ shows how you can use the ToImageSource() extension method over a previously created bitmap.
        

#### __[C#] Example 3: Create ImageSource with Extension Method__

{{region radpdfprocessing-model-imagesource_1}}
    BitmapImage bitmap = new BitmapImage();
    bitmap.BeginInit();
    bitmap.UriSource = new Uri(filename, UriKind.RelativeOrAbsolute);
    bitmap.EndInit();

    return bitmap.ToImageSource();
{{endregion}}



# See Also

 * [Image]({%slug radpdfprocessing-model-image%})
