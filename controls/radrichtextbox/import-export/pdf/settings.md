---
title: Settings
page_title: Settings
description: Check our &quot;Settings&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-import-export-pdf-settings
tags: settings
published: True
position: 0
---

# Settings

__PdfFormatProvider__ allows for export of PDF documents and respectively export of RadRichTextBox to PDF. Additionally, the export settings provide modification options. The current article outlines the available settings.

## Export Settings

__PdfFormatProvider__ exposes __ExportSettings__, which allow you to control image quality, encryption, compliance level and other PDF format related properties.

* __CommentsExportMode__: A property of type __PdfCommentsExportMode__ that gets or sets how the comments should be exported.
	* __None__: Default mode. The comments will not be exported.
	* __NativePdfAnnotations__: The comments will be exported as PDF annotation.
* __ContentsCompressionMode__: A property of type __PdfContentsCompressionMode__ that gets or sets a value indicating the compression mode used when compressing page contents. This property is an enumeration and it allows the following values:
	* __None__: No compression.
	* __Deflate__: The deflate algorithm will be applied to compress the text content of the document.
	* __Automatic__: Default mode. The best algorithm will be automatically decided upon for you. Currently __Deflate__ is always used.
* __ContentsDeflaterCompressionLevel__: A property of type __integer__ between -1 and 9 that gets or sets a value indicating the compression level to be used when deflating the content of the document.
	* __-1__: Automatic compression, which is currently 6 (Optimal Compression).
	* __0__: No Compression. This is the default value of the property.
	* __9__: Best Compression. 
* __DocumentInfo__: A property of type __PdfDocumentInfo__. You can use this class to retrieve or change the document information. The document information which you can get or change is: Author, Creator, IncludeCreationDate, Keywords, Producer, Subject, Title.
* __DrawPageBodyBackground__: A property of type __bool__ that gets or sets a value indicating whether the exporter will draw a rectangle below the page body contents.
* __FloatingUIContainersExportMode:__  A property of type __PdfInlineUIContainersExportMode__ that get or sets the current mode when exporting floating UI containers.
	* __None__: When set, the floating UI containers will not be exported.
	* __Image__: Default mode. All the __FloatingUIContainers__ in the document are added as images in the PDF document. 
* __ImagesCompressionMode:__  A property of type __PdfImagesCompressionMode__ that gets or sets a value indicating the compression mode used when compressing images.
	* __None__: No compression.
	* __Deflate__: The deflate algorithm will be applied to compress the images.
	* __Jpeg__: The Jpeg algorithm will be applied to compress the images.
	* __Automatic__: Default mode. The best algorithm will be automatically decided upon for you.	Currently, __Jpeg__ is used for JPEG images, and __Deflate__ for all others.
* __ImagesDeflaterCompressionLevel__:  A property of type __integer__ between -1 and 9 that gets or sets a value indicating the compression level to be used when deflating the images in the document. This property is respected when an image is compressed with __Deflate__ mode (see __ImagesCompressionMode__).
	* __-1__: Automatic compression, which is currently 6 (Optimal Compression).
	* __0__: No Compression. This is the default value of the property.
	* __9__: Best Compression. 
* __InlineUIContainersExportMode__: A property of type __PdfInlineUIContainersExportMode__ that get or sets the mode used when exporting inline UI containers.
	* __None__: The inline UI containers will not be exported.
	* __Image__: Default mode. All the __InlineUIContainers__ are added as images to the PDF document. 

__Example 1: Setting the ExportSettings of the PdfFormatProvider__
```C#
	PdfExportSettings pdfExportSettings = new PdfExportSettings();
	pdfExportSettings.ContentsDeflaterCompressionLevel = 9;
	pdfExportSettings.DrawPageBodyBackground = false;
	
	PdfFormatProvider pdfFormatProvider = new PdfFormatProvider();
	pdfFormatProvider.ExportSettings = pdfExportSettings;
```

>__PDF import__ is currently __not__ supported, so there are no import settings.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using PdfFormatProvider]({%slug radrichtextbox-import-export-html-htmlformatprovider%})
