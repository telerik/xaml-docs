---
title: Zoom In and Out
page_title: Zoom In and Out a RadFixedDocument
description: Zoom In and Out a RadFixedDocument.
slug: radpdfviewer-zoom-in-or-out-a-radfixeddocument
tags: pdfviewer, zoom, scale, scalefactor
published: True
position: 14
---

# Zoom In and Out

This article describes how you can change the zoom level of the [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%}), which helps to take a close-up view of your **RadFixedDocument** or to zoom out to see more of the page at a reduced size.

In order to do so there are two different approaches available: [Using UI](#using-ui) or [Programmatically](#programmatically).

## Using UI

On the [RadPdfViewerToolbar]({%slug radpdfviewer-default-ui%}) of **RadPdfViewer**, click the zoom in or zoom out magnifier button to zoom in gradual increments or enter a magnification percentage in the toolbar, either by typing or choosing from the dropdown menu.

![Zoom scale](images/RadPdfViewer_HowTo_Zoom_In_Out_RadFixedDocument_01.png)

>The particular zoom setting is **not** preserved when save/export the [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%}).

## Programmatically

By using the **RadPdfViewer**'s **ScaleFactor** property. The default value of the **ScaleFactor** is 1.

__Zoom in__

```C#
    this.pdfViewer.ScaleFactor = 2;
```

__Zoom out__

```C#
    this.pdfViewer.ScaleFactor = 0.5;
```
