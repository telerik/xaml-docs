---
title: Settings
page_title: Settings
description: Settings
slug: radrichtextbox-import-export-pdf-settings
tags: settings
published: True
position: 0
---

# Settings

__PdfFormatProvider__ allows for import of PDF documents and respectively export of RadRichTextBox to PDF. Additionally, the import/export settings provide modification options. The current article outlines the available settings.

## Export Settings

__PdfFormatProvider__ exposes __ExportSettings__, which allow you to control image quality, encryption, compliance level and other PDF format related properties.

* __CommentsExportMode__: A property of type __PdfCommentsExportMode__ that gets or sets how the comments should be exported.
	* __None__: The comments will not be exported.
	* __NativePdfAnnotations__: The comments will be exported as PDF annotation.
* __ContentsCompressionMode__: A property of type __PdfContentsCompressionMode__ that gets or sets a value indicating the compression mode used when compressing page contents. This property is an enumeration and it allows the following values:
	* __None__: No compression
	* __Deflate__: The deflate algorithm will be applied to compress the text content of the document.
	* __Automatic__: The best algorithm will be automatically decided upon for you. 
* __ContentsDeflaterCompressionLevel__: A property of type __integer__ between -1 and 9 that gets or sets a value indicating the compression level to be used when deflating the content of the document.
	* __-1__: Default Compression. 
	* __0__: No Compression. 
	* __9__: Best Compression. 
* __DocumentInfo__: A property of type __PdfDocumentInfo__. You can use this class to retrieve or change the document information.
* __DrawPageBodyBackground__: A property of type __bool__ that gets or sets a value indicating whether the exporter will draw a rectangle below the page body contents.
* __FloatingUIContainersExportMode:__  A property of type __PdfInlineUIContainersExportMode__ that get or sets the current mode when exporting floating UI containers.
	* __None__: When set the floating UI containers will not be exported.
	* __Image__: Default mode.
* __ImagesCompressionMode:__  A property of type __PdfImagesCompressionMode__ that gets or sets a value indicating the compression mode used when compressing images.
	* __None__: No compression.
	* __Deflate__: The deflate algorithm will be applied to compress the images.
	* __Jpeg__: The jpeg algorithm will be applied to compress the images.
	* __Automatic__: The best algorithm will be automatically decided upon for you.	
* __ImagesDeflaterCompressionLevel__:  A property of type __integer__. Same as __ContentsDeflaterCompressionLevel__, but applied to the images in the document. This property is respected when an image is compressed with __Deflate__ mode.
* __InlineUIContainersExportMode__: A property of type __PdfInlineUIContainersExportMode__ that get or sets the current mode when exporting inline UI containers.
	* __None__: When set the inline UI containers will not be exported.
	* __Image__: Default mode.

#### __[C#] Example 1: Setting the ExportSettings of the PdfFormatProvider__
{{region c#-radrichtextbox-import-export-pdf-settings_0}}
	PdfExportSettings pdfExportSettings = new PdfExportSettings();
	pdfExportSettings.ContentsDeflaterCompressionLevel = 9;
	pdfExportSettings.DrawPageBodyBackground = false;
	
	PdfFormatProvider pdfFormatProvider = new PdfFormatProvider();
	pdfFormatProvider.ExportSettings = pdfExportSettings;
{{endregion}}

>__PDF import__ is currently __not__ supported, so there are no import settings.

## See Also

 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Using PdfFormatProvider]({%slug radrichtextbox-import-export-html-htmlformatprovider%})
