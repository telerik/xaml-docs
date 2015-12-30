---
title: ImageQuality
page_title: ImageQuality
description: ImageQuality
slug: radpdfprocessing-concepts-imagequality
tags: image, quality
published: True
position: 5
---

# ImageQuality 

This article explains how to use the ImageQuality enumeration to change the export of images in **RadPdfProcessing** and how it reflects the images in different scenarios.

* [Overview](#overview)

* [Using ImageQuality](#using-imagequality)

## Overview

The [ImageQuality enumeration](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_FormatProviders_Pdf_Export_ImageQuality.htm) allows you to control the quality of the images when exporting to PDF. Possible values for this property are High, Medium, and Low. Since Q1 2016, the **default value of ImageQuality is High**.


## Using ImageQuality

The quality of the images reflects the size of the PDF document. The higher the quality, the bigger the document size. This property can be set both in [PdfExportSettings]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%}) and in the constructor of [ImageSource]({%slug radpdfprocessing-model-imagesource%}). 

>tipYou can download a runnable project, which demonstrates different approaches for working with images in __RadPdfProcessing__ from our [SDK repository](https://github.com/telerik/xaml-sdk/tree/master/PdfProcessing/CreateDocumentWithImages).

### Set a Default Value for all Images in a Document
 
In order to specify the default **ImageQuality** value when exporting to PDF, you should use the [PdfExportSettings]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%}).

#### __[C#] Example 1: Set a Default Value for all Images in a Document__

{{region radpdfprocessing-concepts-imagequality_0}}
	PdfExportSettings settings = new PdfExportSettings();
    settings.ImageQuality = ImageQuality.Medium;
{{endregion}}

### Specify the Image Quality of an Image

If you need some particular image to be exported with different **ImageQuality** value, you should specify this value in the constructor of [ImageSource]({%slug radpdfprocessing-model-imagesource%}) in order to override the default one.

#### __[C#] Example 2: Set the Image Quality of an Image__

{{region radpdfprocessing-concepts-imagequality_1}}
	ImageSource imageSource = new ImageSource(bitmap, ImageQuality.Medium);
{{endregion}}


### ImageQuality and EncodedImageData Class

When you construct an **ImageSource** object with [EncodedImageData](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_Model_Resources_EncodedImageData.htm), the image is inserted in the PDF file as it is, without decoding and re-encoding the image data. As **RadPdfProcessing** does not process the image data in this case, the **PdfExportSettings.ImageQuality** property is not used for this specific image and setting a value won’t take effect.

### ImageQuality.High With JPEG and JPEG2000 Images

When **ImageQuality** of an image is set to **High**, **RadPdfProcessing** internally checks the image stream before processing it. If the image is JPEG or JPEG2000, it is inserted in the PDF file as it is, without processing the image pixels. This way, **RadPdfProcessing** provides fast and lossless quality export of JPEG and JPEG2000 files, which guarantees maximum quality in the exported document.

> JPEG2000 images in **RadPdfProcessing** can be inserted only with **ImageQuality.High**. Exporting them with lower ImageQuality value requires decoding JPEG2000 files which is currently unsupported by the library. 

# See also

* [ImageQuality API Reference](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Fixed_FormatProviders_Pdf_Export_ImageQuality.htm)

* [ImageSource]({%slug radpdfprocessing-model-imagesource%})

* [PdfExportSettings]({%slug radpdfprocessing-formats-and-conversion-pdf-settings%})