---
title: Unsupported Features
page_title: Unsupported Features
description: Unsupported Features
slug: radpdfviewer-unsupported-features
tags: unsupported,features
published: True
position: 8
---

# Unsupported Features

## Unsupported Content

The unsupported features include:

* Type3 fonts.

* Almost all fonts that are embedded in the PDF file should be displayed correctly. There are minimal limitations with some font formats.

* There are some limitations with CCITTFaxDecode filter.

* Lab, ICCBased.

* Password protection.

* JPXDecode filter: This filter does not work out of the box. However, there is API allowing to plug-in custom user-defined filters. This API is described in the [Customize PDF Rendering]({%slug radpdfviewer-customize-pdf-rendering%}) topic and an [SDK example](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomDecoder) showing the approach is available in our SDK repository on GitHub.
            
* Annotations: Full support for Widget and Link annotations. All other types of annotations are supported in read-only mode.

* Structured content: There are several ways to define structured content in a PDF file. RadPdfViewer does not support document outline and article threads. 

When a PDF file contains some of these items, it may be shown incorrectly or not shown at all.

## See Also

 * [Showing a File]({%slug radpdfviewer-showing-a-file%})

 * [Customize PDF Rendering]({%slug radpdfviewer-customize-pdf-rendering%})
