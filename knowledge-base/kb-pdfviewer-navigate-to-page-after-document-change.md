---
title: Navigating to a Specific Page After Changing a Document in RadPdfViewer
description: Learn how to navigate to a page after changing a document in RadPdfViewer for WPF with GoToPage or GoToDestination when the viewer is ready.
type: how-to
page_title: Navigate to a Page After a Document Change | Telerik UI for WPF
slug: kb-pdfviewer-navigate-to-page-after-document-change
tags: radpdfviewer, pdfviewer, documentchanged, gotopage, scale-mode, navigation
components: ["pdfviewer"]
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.4.1110| RadPdfViewer |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Calling `GoToPage` from the `DocumentChanged` event can occur before the viewer finishes processing a document change. The same timing issue can occur when you change `ScaleMode` and call `GoToPage` in that handler.

## Solution

Use the following steps to call `GoToPage` after the viewer completes its document update:

1. For an initial direct `Document` assignment, wait until the `RadPdfViewer` control raises its `Loaded` event before setting the document. The control applies its template and initializes the presenter before it raises `Loaded`.
2. In the `DocumentChanged` handler, confirm that `e.NewDocument` is not `null`.
3. Use `Dispatcher.BeginInvoke` to queue the requested `ScaleMode` and `GoToPage` calls. Set `ScaleMode` first, then call `GoToPage`.

The following handler assumes that the window defines `pdfViewer`, `requestedScaleMode`, and `targetPageNumber` fields:

```csharp {.skip-repl}
private void PdfViewer_DocumentChanged(object sender, Telerik.Windows.Documents.Fixed.DocumentChangedEventArgs e)
{
    if (e.NewDocument == null)
    {
        return;
    }

    this.pdfViewer.Dispatcher.BeginInvoke(new System.Action(() =>
    {
        this.pdfViewer.ScaleMode = this.requestedScaleMode;
        this.pdfViewer.GoToPage(this.targetPageNumber);
    }));
}
```

The dispatcher callback runs after the current document-change handler and the viewer's fit update complete. Set `targetPageNumber` to a valid page number in the new document.

You can also navigate with a `Destination` object when you need to target a location on a page. Call `this.pdfViewer.GoToDestination(destination)` from the same dispatcher callback after the viewer completes its update. The destination's `Page` must belong to the new document. The viewer throws an `ArgumentException` if it belongs to another document. A `Destination` also supports horizontal and vertical offsets. For details on creating a destination, see the [RadPdfViewer annotations article]({%slug radpdfviewer-document-model-annotations%}).

>note The `PdfDocumentSource.Loaded` event indicates that the document source completed import. It does not indicate that `RadPdfViewer` completed its document-change update.

## See Also

* [Loading a PDF file in RadPdfViewer]({%slug radpdfviewer-showing-a-file%})
* [Troubleshooting common RadPdfViewer problems]({%slug radpdfviewer-troubleshooting-common-problems%})
