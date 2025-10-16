---
title: Loading a Multipage Tiff File in a RadPdfViewer Using TiffBitmapDecoder
description: Create a PDF document from a multipage TIFF file and show it in the RadPdfViewer using TiffBitmapDecoder.
type: how-to
page_title: How to Show a Multipage Tiff File in the RadPdfViewer Using TiffBitmapDecoder
slug: kb-pdfviewer-load-multipage-tiff-using-tiffbitmapdecoder
position: 0
tags: pdf, pdfviewer, tiff, tif, tiffbitmapdecoder
ticketid: 1530181
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2021.2.913</td>
	    </tr>
	    <tr>
            <td>Product</td>
            <td>RadPDFViewer for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to show a multipage Tiff file in the RadPdfViewer with the help of the _System.Windows.Media.Imaging.**TiffBitmapDecoder**_.

## Solution

This functionality can be achieved by splitting the multipage TIFF file into single page ones. Then to insert them into a [RadFixedDocument]({%slug radpdfviewer-document-model-radfixeddocument%}) as a **RadFixedPages** content.

__Example 1: Loading the TIFF file__
```C#

    private void LoadTiff(object sender, RoutedEventArgs e)
    {
        RadFixedDocument radFixedDocument = new RadFixedDocument();

        Bitmap[] bitmaps = this.SplitTiff("SampleData/test.tiff");
        for (int i = 0; i < bitmaps.Length; i++)
        {
            BitmapSource bitmapSource = ConvertToBitmapSource(bitmaps[i]);
            RadFixedPage documentPage = new RadFixedPage();
            ImageSource imageSource = new ImageSource(bitmapSource, ImageQuality.High);
            documentPage.Content.AddImage(imageSource);
            radFixedDocument.Pages.Add(documentPage);
        }

        this.pdfViewer.Document = radFixedDocument;
    }

```

__Example 2: Splitting the TIFF file__
```C#

    private Bitmap[] SplitTiff(string inputFilePath)
    {
        Bitmap[] bitmaps;

        using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(inputFilePath)))
        {
            TiffBitmapDecoder tiffDecoder = new TiffBitmapDecoder(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);

            int noOfPages = tiffDecoder.Frames.Count;
            bitmaps = new Bitmap[noOfPages];

            for (int i = 0; i < noOfPages; ++i)
            {
                Bitmap bitmap;
                using (var outStream = new MemoryStream())
                {
                    BitmapEncoder bitmapEncoder = new BmpBitmapEncoder();
                    bitmapEncoder.Frames.Add(BitmapFrame.Create(tiffDecoder.Frames[i]));
                    bitmapEncoder.Save(outStream);
                    bitmap = new Bitmap(outStream);
                }

                bitmaps[i] = bitmap;
            }
        }

        return bitmaps;
    }

```

__Example 3: Converting the Bitmap to a BitmapSource__
```C#

    private BitmapSource ConvertToBitmapSource(Bitmap bitmap)
    {
        BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(
            bitmap.GetHbitmap(),
            IntPtr.Zero,
            Int32Rect.Empty,
            BitmapSizeOptions.FromEmptyOptions());

        return bitmapSource;
    }

```

## Notes

There is a request to create a new TIFF Viewer Control. Make sure to cast your vote for it as this directly affects its priority: [New Control: TIFF Viewer](https://feedback.telerik.com/wpf/1352234-new-control-tiff-viewer).
