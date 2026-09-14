---
title: Extract All Images from a Worksheet and Save Them as Files
description: Learn how to import an XLSX workbook and extract all embedded images from each worksheet to save them as image files using RadSpreadsheet.
components: ["spreadsheet"]
type: how-to
page_title: Extract and Save All Images from a Worksheet in RadSpreadsheet
slug: kb-spreadsheet-extract-images-from-worksheet
tags: spreadsheet, xlsx, images, extract, floatingimage, worksheet, imagesource
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.812| RadSpreadsheet for WPF |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

A common requirement when working with Excel spreadsheets imported into [RadSpreadsheet]({%slug radspreadsheet-overview%}) is extracting all embedded images from the worksheets and saving them to disk as image files (such as PNG or JPEG).

Worksheets in a `Workbook` represent floating pictures and images via the `Images` collection on each `Worksheet`. Each item in `worksheet.Images` is a `FloatingImage` that exposes an `ImageSource` property containing the image format extension and the raw binary bytes (`byte[]`).

## Solution

To extract and save all images from an imported XLSX file:

1. Import the workbook using `XlsxFormatProvider`.
2. Iterate through each `Worksheet` in `workbook.Worksheets`.
3. Iterate through `worksheet.Images` to access each `FloatingImage`.
4. Use `image.ImageSource.Extension` to determine the image format (such as `png`, `jpeg`).
5. Write `image.ImageSource.Data` to disk using `File.WriteAllBytes()`.

### Required Assembly References

Ensure your project references the following assemblies:

* `Telerik.Windows.Documents.Spreadsheet`
* `Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml`

### Example

```csharp
using System;
using System.IO;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;

public static void ExtractImagesFromWorkbook(string workbookPath, string outputDirectory)
{
    // Load the workbook from a file stream
    var provider = new XlsxFormatProvider();
    Workbook workbook;
    using (var stream = File.OpenRead(workbookPath))
    {
        workbook = provider.Import(stream, null);
    }

    // Iterate through worksheets and save extracted images as files.
    Directory.CreateDirectory(outputDirectory);
    int imageNumber = 1;

    foreach (var worksheet in workbook.Worksheets)
    {
        foreach (var image in worksheet.Images)
        {
            var imageSource = image.ImageSource;
            string extension = imageSource.Extension.TrimStart('.');
            string outputPath = Path.Combine(outputDirectory, $"Image_{imageNumber}.{extension}");
            File.WriteAllBytes(outputPath, imageSource.Data);
            imageNumber++;
        }
    }
}
```

## See Also

* [Import/Export in RadSpreadsheet]({%slug radspreadsheet-import-export%})
* [Worksheet Model in RadSpreadsheet]({%slug radspreadsheet-model-worksheet%})
* [Knowledge Base Articles]({%slug radspreadsheet-kb-articles%})
