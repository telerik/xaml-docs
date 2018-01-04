---
title: Overview
page_title: Overview
description: Discover RadPdfViewer and the functionalities it comes with. 
slug: radpdfviewer-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}![RadPdfViewer Silverlight Icon](images/RadPdfViewer_Overview_sl.png){% endif %}
{% if site.site_name == 'WPF' %}![RadPdfViewer WPF Icon](images/RadPdfViewer_Overview_wpf.png){% endif %}

Thank you for choosing Telerik __RadPdfViewer__!

__RadPdfViewer__ is a control that can display PDF files natively in {{ site.framework_name }}. 

![RadPdfViewer Overview](images/RadPdfViewer_radpdfviewer_overview_02.png)

## Features

Some of the key features coming out-of-the-box with **RadPdfViewer** are:

* [**Interactive Forms**]({%slug radpdfviewer-features-interactive-forms%}): The control supports different types of interactive forms and enables the end user to modify their values.
{% if site.site_name == 'WPF' %}

* [**Digital Signatures**]({%slug radpdfviewer-features-digital-signature%}): The user can show digitally signed documents and validate the signatures inside. Signing a document is supported as well.
{% endif %}

* [**Saving a Document**]({%slug radpdfviewer-save-as%}): When the user modifies the forms in a document or signs it, or just want to create another file from the document, they can use the Save As functionality of the viewer. 

* [**Annotations**]({%slug radpdfviewer-document-model-annotations%}): Full support for Widget and Link annotations. **RadPdfViewer** provides a read-only support for all other types of annotations.

* **Fonts**: Built-in support for **TrueType**, **Type1** and **CID** fonts.

* [**Create an Image from a PDF Page**]({%slug radpdfviewer-exporting-fixedpage-to-image%}): An API for exporting a PDF document page to an image.

* Working with [positions]({%slug radpdfviewer-text-text-position%}) and modifying the [selection]({%slug radpdfviewer-text-text-selection%}) in the document.

* The control comes with a **predefined UI** that is intuitive and provides the means for utilizing the features of the control. Different dialogs are available as well.

* Using the UI you can easily **zoom in and out**.

* **Scroll** the document in the viewer. 

* You can also use **pan** and **text selection** by specifying a different [viewer mode]({%slug radpdfviewer-viewer-modes%}).

* The control utilizes **virtualization** in order to guarantee good performance with larger documents as well.

* **RadPdfViewer** allows [**printing**]({%slug radpdfviewer-printing%}) of the document loaded in it.

* You can [**rotate**]({%slug radpdfviewer-rotation%}) the document as well.

* [**Context Menu**]({%slug radpdfviewer-context-menu%}) to provide easy access to several of the features of the control. 

* Extensible support for different stream compression filters. [[Read more]({%slug radpdfviewer-customize-pdf-rendering%})]

* Support for documents encrypted with **Encryption Algorithm 4 (RC4)** 

* The API provides different options for **extending** and **customizing** the control.

## See Also

 * [Getting Started]({%slug radpdfviewer-getting-started%})
 * [Wiring UI]({%slug radpdfviewer-wiring-ui%})
 * [Showing a File]({%slug radpdfviewer-showing-a-file%})
