---
title: Printing to Microsoft Print to PDF Produces 0-Byte PDF File
description: Learn why printing a RadRichTextBox document to Microsoft Print to PDF can result in a 0-byte corrupt file and how to resolve it using PdfFormatProvider.
components: ["richtextbox"]
type: troubleshooting
page_title: RadRichTextBox Print to Microsoft Print to PDF Results in 0-Byte Corrupt PDF
slug: kb-richtextbox-printing-to-pdf-zero-bytes
position: 0
tags: radrichtextbox, printing, pdf, microsoft print to pdf, 0 byte, zero bytes, corrupt, calibri, pdfformatprovider
res_type: kb
---

## Environment

| Property | Value |
|---|---|
| Product | RadRichTextBox for WPF |
| Component | RadRichTextBox / DocumentPrintPresenter |

## Description

When printing a document from `RadRichTextBox` using the standard `PrintDialog` and selecting **Microsoft Print to PDF**, the resulting `.pdf` file is 0 bytes and cannot be opened. No exception is thrown, and the `PrintStarted` and `PrintCompleted` events fire normally.

This issue typically reproduces when using fonts such as **Calibri**, whereas other fonts (like Times New Roman or Arial) may print as expected.

## Cause

`RadRichTextBox` native printing uses the WPF visual print pipeline (`PrintDialog.PrintDocument`), which writes visual elements to the Windows print spooler via XPS. Certain virtual printer drivers—notably **Microsoft Print to PDF**—can fail to subset or embed specific TrueType/OpenType fonts (such as Calibri) during XPS-to-PDF conversion. When this failure occurs inside the printer driver, the spooler process terminates the PDF generation silently, creating an empty (0-byte) file without throwing a .NET exception.

## Solution

To generate PDF documents reliably from a `RadDocument`, use the dedicated [PdfFormatProvider]({%slug radrichtextbox-import-export-pdf-pdfformatprovider%}) instead of printing to a virtual printer driver. `PdfFormatProvider` serializes the document structure directly into PDF format without going through the Windows print spooler or printer drivers.

```C#
using System.IO;
using Telerik.Windows.Documents.FormatProviders.Pdf;

// ...

PdfFormatProvider provider = new PdfFormatProvider();
using (Stream output = File.OpenWrite("output.pdf"))
{
    provider.Export(this.radRichTextBox.Document, output, null);
}
```

If printing through a physical printer or `PrintDialog` is strictly required, change the font family of the document to a font that does not encounter driver-level embedding issues (e.g., Arial or Times New Roman).

## See Also

* [Printing in RadRichTextBox]({%slug radrichtextbox-printing%})
* [Using PdfFormatProvider]({%slug radrichtextbox-import-export-pdf-pdfformatprovider%})
* [Troubleshooting Common Problems]({%slug radrichtextbox-troubleshooting-common-problems%})
