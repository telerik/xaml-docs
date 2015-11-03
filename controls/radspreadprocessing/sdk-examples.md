---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radspreadprocessing-sdk-examples
tags: sdk,examples
published: True
position: 2
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadSpreadProcessing__.

## List of all RadSpreadProcessing SDK examples:

{% if site.site_name == 'WPF' %}

* __[Convert documents](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/ConvertDocuments)__ - This project demonstrates how to use RadSpreadProcessing to convert different document formats.
* __[Create modify export](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/CreateModifyExport)__ - This project demonstrates how to:
- Create an expense report document from scratch using formulas.
- Modify the document using themes, styles and images.
- Export three expense reports for each individual company department, filtering the data before saving it to PDF files.

This example is related to SpreadProcessing blog post series "SpreadProcessing - Complete Solution to Create, Modify and Export Spreadsheets". The posts may be found on the following links:
- Part 1: http://blogs.telerik.com/blogs/14-09-09/spreadprocessing---complete-solution-to-create-modify-and-export-spreadsheets---part-i
- Part 2: http://blogs.telerik.com/blogs/14-11-24/spreadprocessing---complete-solution-to-create-modify-and-export-spreadsheets---part-ii
- Part 3: http://blogs.telerik.com/blogs/15-03-24/spreadprocessing-complete-solution-to-create-modify-and-export-spreadsheets-part-iii

* __[Generate documents](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/GenerateDocuments)__ - This project demonstrates how to use RadSpreadProcessing to generate document from scratch and export it to a file.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Convert documents](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/ConvertDocuments)__ - This project demonstrates how to use RadSpreadProcessing to convert different document formats.
* __[Create modify export](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/CreateModifyExport)__ - This project demonstrates how to:
- Create an expense report document from scratch using formulas.
- Modify the document using themes, styles and images.
- Export three expense reports for each individual company department, filtering the data before saving it to PDF files.

This example is related to SpreadProcessing blog post series "SpreadProcessing - Complete Solution to Create, Modify and Export Spreadsheets". The posts may be found on the following links:
- Part 1: http://blogs.telerik.com/blogs/14-09-09/spreadprocessing---complete-solution-to-create-modify-and-export-spreadsheets---part-i
- Part 2: http://blogs.telerik.com/blogs/14-11-24/spreadprocessing---complete-solution-to-create-modify-and-export-spreadsheets---part-ii
- Part 3: http://blogs.telerik.com/blogs/15-03-24/spreadprocessing-complete-solution-to-create-modify-and-export-spreadsheets-part-iii

* __[Generate documents](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/GenerateDocuments)__ - This project demonstrates how to use RadSpreadProcessing to generate document from scratch and export it to a file.
* __[Register and export pdf fonts](https://github.com/telerik/xaml-sdk/tree/master/SpreadProcessing/RegisterAndExportPdfFonts)__ - This project demonstrates how to:
 1. Check if all used fonts in a Workbook are registered in the FontsRepository before exporting to PDF.
 2. Register the missing fonts using the WCF service from RegisterAndExportPdfFonts.Web project.
 3. Export the Workbook to PDF after all fonts are registered.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).