---
title: Zoom In or Out
page_title: Zoom In or Out a RadFixedDocument
description: Zoom In or Out a RadFixedDocument.
slug: radpdfviewer-zoom-in-or-out-a-radfixeddocument
tags: pdfviewer, zoom, scale, scalefactor
published: True
position: 10
---

# Zoom In or Out

This article describes how you can change the zoom level of the [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%}), which helps to take a close-up view of your **RadFixedDocument** or to zoom out to see more of the page at a reduced size.

In order to do so there are two different approaches available: [Using UI](#using-ui) or [Programmatically](#programmatically).

## Using UI

On the {% if site.site_name == 'WPF' %}[RadPdfViewerToolbar]({%slug radpdfviewer-default-ui%}){% endif %}{% if site.site_name == 'Silverlight' %}UI{% endif %} of **RadPdfViewer**, click the zoom in or zoom out magnifier button to zoom in gradual increments or enter a magnification percentage in the toolbar, either by typing or choosing from the dropdown menu.

![Zoom scale](images/RadPdfViewer_HowTo_Zoom_In_Out_RadFixedDocument_01.png)

>The particular zoom setting is **not** preserved when save/export the [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%}).

## Programmatically

By using the **RadPdfViewer**'s **ScaleFactor** property. The default value of the **ScaleFactor** is 1.

#### **[C#] Example 1: Zoom in**

```C#

    this.pdfViewer.ScaleFactor = 2;
```

#### **[C#] Example 2: Zoom out**

```C#

    this.pdfViewer.ScaleFactor = 0.5;
```
