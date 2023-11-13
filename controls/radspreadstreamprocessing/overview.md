---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadSpreadStreamProcessing {{ site.framework_name }} control.
slug: radspreadstreamprocessing-overview
tags: overview
published: True
position: 0
CTAControlName: RadSpreadStreamProcessing
---

# {{ site.framework_name }} SpreadStreamProcessing Overview

This article briefly explains the specifics of **RadSpreadStreamProcessing** - what is spread streaming, how it works compared to the RadSpreadProcessing library and when to use it.

>**RadSpreadStreamProcessing** is part of the **Telerik Document Processing** libraries. The full documentation for this component is available at [https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamsprocessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/overview).

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![SpreadStreamProcessing Fast Export image](images/SpreadStreamProcessing-Overview_01.png)


## What is Spread Streaming?

Spread streaming is a document processing paradigm that allows you to create or read big spreadsheet documents with great performance and minimal memory footprint. 

The key for the memory efficiency is that the spread streaming library writes the spreadsheet content directly to a stream without creating and preserving the spreadsheet document model in memory. Each time an exporter object is disposed, the set values are written into the stream. This allows you to create large documents with an excellent performance.

While reading, only the required chunk of information is parsed to ensure there are no application resources kept without user need.

## Key Features


Some of the features you can take advantage of are:

* [Export](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/export) to XLSX or CSV files

* [Import](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/import) from XLSX or CSV files

* Writing directly into a stream; or parsing required data only

* **Append** new worksheets to existing workbook

* **Grouping**: Helps you organize data in sections, to be able to show and hide the currently relevant chunks.

* **Hidden [rows](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/row) and [columns](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/column)**: The API allows you to set the hidden state of each row or column.

* [**Cell formatting**](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/cells#set-a-format): A number of properties enabling you to apply the desired look to a cell.

* [**Cell styles**](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/cell-styles): Using cell styles allows you to apply multiple format options in one step and also offers an easy approach to achieve consistency in cell formatting.

* [**Merge cells**](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/cells#merge-cells): You have the ability to merge two or more adjacent cells into a single cell that spans over multiple rows and columns.

* **Controlling the view state of a sheet:**
	* [Setting scale factor](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#scale-a-document)
	* [Control over the selection and the active cell](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#add-selection-to-a-document)
	* [Show/hide gridlines](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#hide-grid-lines-and-row-or-column-headers)
	* [Show/hide row and column headers](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#ide-grid-lines-and-row-or-column-headers)
	* [Freezing panes](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#freeze-panes): Keep part of the worksheet always visible while scrolling.
	* [Changing the first visible cell](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#change-the-first-visible-cell): when you would like to show a particular part of the sheet to the user on opening the document in a viewer.

## RadSpreadStreamProcessing vs. RadSpreadProcessing

Following are the main differences between the two spreadsheet processing libraries.

* __RadSpreadStreamProcessing__ writes directly into a stream, unlike [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview), which creates models for the elements in the document. This is why the memory used with the spread streaming library is significantly lower than when using __RadSpreadProcessing__.
* __RadSpreadStreamProcessing__ does not perform any formula or other layout-related calculations, which makes its file generation performance much better compared to __RadSpreadProcessing__.


## When to Use RadSpreadStreamProcessing

You can use the __RadSpreadStreamProcessing__ library to create or read __large amount of data__ with a low memory footprint and great performance. You can also append data to an already existing document stream. The generated document can be exported directly to a file on the file system or to a stream (for example, to send it to the client).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF SpreadStreamProcessing Homepage](https://www.telerik.com/products/wpf/spreadstreamprocessing.aspx)
* [Get Started with the Telerik UI for WPF SpreadStreamProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/getting-started)
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF SpreadStreamProcessing Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

