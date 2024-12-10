---
title: Overview
page_title: Overview
description: Discover RadPdfViewer and the functionalities it comes with. 
slug: radpdfviewer-overview
tags: overview
published: True
position: 0
CTAControlName: RadPdfViewer
---

# {{ site.framework_name }} PdfViewer Overview

Thank you for choosing Telerik __RadPdfViewer__!

__RadPdfViewer__ is a control that can display PDF files natively in {{ site.framework_name }}. 

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![RadPdfViewer Overview](images/RadPdfViewer_radpdfviewer_overview_02.png)

## Features

Some of the key features coming out-of-the-box with **RadPdfViewer** are:

* [**Interactive Forms**]({%slug radpdfviewer-features-interactive-forms%}): The control supports different types of interactive forms and enables the end user to modify their values.
{% if site.site_name == 'WPF' %}

* [**Bookmarks (Document Outlines)**]({%slug radpdfviewer-features-bookmarks%}): RadPdfViewer can show the bookmarks of the document and ease the navigation inside.

* [**Digital Signatures**]({%slug radpdfviewer-features-digital-signature%}): The user can show digitally signed documents and validate the signatures inside. Signing a document is supported as well.
{% endif %}

* [**Saving a Document**]({%slug radpdfviewer-save-as%}): When the user modifies the forms in a document or signs it, or just want to create another file from the document, they can use the Save As functionality of the viewer. 

* [**Annotations**]({%slug radpdfviewer-document-model-annotations%}): Full support for Widget and Link annotations. **RadPdfViewer** provides a read-only support for all other types of annotations.

* **Fonts**: Built-in support for **TrueType**, **Type1** and **CID** fonts.

* [**Create an Image from a PDF Page**]({%slug radpdfviewer-exporting-fixedpage-to-image%}): An API for exporting a PDF document page to an image.

* Working with [positions]({%slug radpdfviewer-text-text-position%}) and modifying the [selection]({%slug radpdfviewer-text-text-selection%}) in the document.

* The control comes with a **predefined UI** that is intuitive and provides the means for utilizing the features of the control. Different dialogs are available as well.

* Using the UI you can easily [zoom in and out]({%slug radpdfviewer-zoom-in-or-out-a-radfixeddocument%}).

* **Scroll** the document in the viewer. 

* You can also use **pan** and **text selection** by specifying a different [viewer mode]({%slug radpdfviewer-viewer-modes%}).

* The control utilizes **virtualization** in order to guarantee good performance with larger documents as well.

* **RadPdfViewer** allows [**printing**]({%slug radpdfviewer-printing%}) of the document loaded in it.

* You can [**rotate**]({%slug radpdfviewer-rotation%}) the document as well.
{% if site.site_name == 'WPF' %}
* An easy to use [**Predefined UI**]({%slug radpdfviewer-default-ui%}). The UI also provides a number of customization options to fit the different requirements you might have.
{% endif %}
* [**Context Menu**]({%slug radpdfviewer-context-menu%}) to provide easy access to several of the features of the control. 

* Extensible support for different stream compression filters. [[Read more]({%slug radpdfviewer-customize-pdf-rendering%})]

* Support for documents encrypted with **Encryption Algorithm 4 (RC4/AES-128)** 

* The API provides different options for **extending** and **customizing** the control.

* Type3 fonts (Available in R1 2021).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF PDFViewer Homepage](https://www.telerik.com/products/wpf/pdf-viewer.aspx)
* [Get Started with the Telerik UI for WPF PDFViewer]({%slug radpdfviewer-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF PDFViewer Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also  
* [Useful Security Tips]({%slug security-tips%})

 * [Getting Started]({%slug radpdfviewer-getting-started%})
 * [Wiring UI]({%slug radpdfviewer-wiring-ui%})
 * [Showing a File]({%slug radpdfviewer-showing-a-file%})
