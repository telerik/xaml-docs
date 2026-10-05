---
title: Decoding JPEG 2000 Images
page_title: Decoding JPEG 2000 Images
description: Check our &quot;Decoding JPEG 2000 Images&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
components: ["pdfviewer"]
slug: radpdfviewer-customization-and-extensibility-decoding-jpeg2000-images
tags: pdfviewer,jpx,jpeg2000,decoder,jpxdecodeutils
published: True
position: 3
---

# Decoding JPEG 2000 Images

PDF files can store JPEG 2000 image data using the `JPXDecode` filter. __RadPdfViewer__ relies on __RadPdfProcessing__ to open, render, and export the underlying PDF document, and you can enable JPX decoding by registering an optional decoder from the `Telerik.Windows.Documents.JpxDecodeUtils` NuGet package&mdash;no custom `IPdfFilter` implementation is required for this scenario.

>tip This complements the fully custom decoder approach described in [Customize PDF Rendering]({%slug radpdfviewer-customize-pdf-rendering%}). Use the built-in `JpxImageDecoder` whenever you only need standard JPEG 2000 decoding, and fall back to a custom `IPdfFilter` implementation only for specialized decoding requirements.

## Installing the Decoder Package

Add the `Telerik.Windows.Documents.JpxDecodeUtils` NuGet package to the project that hosts __RadPdfViewer__.

## Registering the JpxImageDecoder

The `FixedExtensibilityManager.JpxImageDecoder` property is global for the application, so register a single `JpxImageDecoder` instance once, before any PDF document that contains JPX images is imported, rendered, or exported. A good place to do this is during application or view startup, before __RadPdfViewer__ loads a document.

__Registering the JpxImageDecoder on startup__

```C#
if (FixedExtensibilityManager.JpxImageDecoder == null)
{
	FixedExtensibilityManager.JpxImageDecoder = new JpxImageDecoder();
}
```

Once registered, __RadPdfViewer__ uses this decoder automatically whenever it encounters JPX-encoded images in a loaded PDF document. For more information about working with images in __RadPdfProcessing__, see the [Images](https://www.telerik.com/document-processing-libraries/documentation/libraries/radpdfprocessing/cross-platform/images) article in the Document Processing Libraries documentation.

## Handling Missing Decoder Registration

If a document requires JPX decoding and no decoder is registered, __RadPdfProcessing__ throws a `JpxImageDecoderNotConfiguredException`. Attach a handler to the respective import and export exception events to skip the unsupported images instead of failing the whole operation, and leave all other exception types unhandled so unrelated errors are not silently swallowed.

## See Also

* [Customize PDF Rendering]({%slug radpdfviewer-customize-pdf-rendering%})
* [Custom Document Presenter]({%slug radpdfviewer-customization-and-extensibility-custom-document-presenter%})
* [Images in RadPdfProcessing](https://www.telerik.com/document-processing-libraries/documentation/libraries/radpdfprocessing/cross-platform/images)
