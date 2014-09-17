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



Due to the fact that
          {% if site.site_name == 'WPF' %}
            the Silverlight and WPF version of the control share a common code base and
          {% endif %}
          there are some limitations in Silverlight,
          some features are not yet supported.
        

## Unsupported Content

The unsupported features include:

* Type3 fonts;

* Almost all fonts that are embedded in the PDF file should be displayed correctly. There are minimal limitations with some font formats;

* There are some limitations with CCITTFaxDecode filter;

* Pattern, Lab, ICCBased;

* Encrypted documents when a non-standard encryption method is used, or the document is password-protected;

* JBIG2Decode, JPXDecode, Crypt filters.
              We have provided API to plug-in custom user-defined filters, but the filters do not work out of the box;
            

* Annotations - of all annotations, only link is supported;

* Structured content - there are several ways to define structured content in a PDF file.
            RadPdfViewer does not support document outline, article threads and interactive form.

When a PDF file contains some of these items, it may be shown incorrectly or not shown at all.

# See Also

 * [Showing a File]({%slug radpdfviewer-showing-a-file%})

 * [Customize PDF Rendering]({%slug radpdfviewer-customize-pdf-rendering%})
