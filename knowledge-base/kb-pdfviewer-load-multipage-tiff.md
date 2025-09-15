---
title: Loading a multipage Tiff file in a RadPdfViewer
description: Create a PDF document from a multipage TIFF file and show it in the RadPdfViewer.
type: how-to
page_title: How to show a multipage Tiff file in the RadPdfViewer
slug: kb-pdfviewer-load-multipage-tiff
position: 0
tags: pdf, pdfviewer, tiff, tif
ticketid: 1469284
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
            <td>Product</td>
            <td>RadPDFViewer for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to show a multipage Tiff file in the RadPdfViewer.

## Solution

This functionality can be achieved by splitting the multipage TIFF file into single page ones. Then to insert them into a [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%}) as a **RadFixedPages** content.

__Example 1: Loading the TIFF file__
```C#

    private void LoadTiff(object sender, RoutedEventArgs e)
    {
        RadFixedDocument radFixedDocument = new RadFixedDocument();

        Stream[] tiffStreams = this.SplitTiff("SampleData/test.tiff");
        foreach (Stream tiffStream in tiffStreams)
        {
            RadFixedPage documentPage = new RadFixedPage();
            ImageSource imageSource = new ImageSource(tiffStream);
            documentPage.Content.AddImage(imageSource);
            radFixedDocument.Pages.Add(documentPage);
        }

        using (Stream documentStream = new MemoryStream())
        {
            PdfFormatProvider pdfFormatProvider = new PdfFormatProvider();
            pdfFormatProvider.Export(radFixedDocument, documentStream);

            RadFixedDocument document = new PdfFormatProvider(documentStream).Import();
            this.pdfViewer.Document = document;
        }
    }

```

__Example 2: Splitting the TIFF file__
```C#

    private Stream[] SplitTiff(string inputFilePath)
    {
        //Get the frame dimension list from the image of the file and
        System.Drawing.Image tiffImage = System.Drawing.Image.FromFile(inputFilePath);
        //get the globally unique identifier (GUID)
        Guid objGuid = tiffImage.FrameDimensionsList[0];
        //create the frame dimension
        FrameDimension dimension = new FrameDimension(objGuid);
        //Gets the total number of frames in the .tiff file
        int noOfPages = tiffImage.GetFrameCount(dimension);

        ImageCodecInfo encodeInfo = null;
        ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
        for (int j = 0; j < imageEncoders.Length; j++)
        {
            if (imageEncoders[j].MimeType == "image/tiff")
            {
                encodeInfo = imageEncoders[j];
                break;
            }
        }

        Stream[] tiffStreams = new Stream[noOfPages];

        foreach (Guid guid in tiffImage.FrameDimensionsList)
        {
            for (int index = 0; index < noOfPages; index++)
            {
                FrameDimension currentFrame = new FrameDimension(guid);
                tiffImage.SelectActiveFrame(currentFrame, index);

                Stream tiffStream = new MemoryStream();
                tiffImage.Save(tiffStream, ImageFormat.Tiff);
                tiffStreams[index] = tiffStream;
            }
        }

        return tiffStreams;
    }

```

## Notes

There is a request to create a new TIFF Viewer Control. Make sure to cast your vote for it as this directly affects its priority: [New Control: TIFF Viewer](https://feedback.telerik.com/wpf/1352234-new-control-tiff-viewer).
