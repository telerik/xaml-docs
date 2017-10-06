---
title: Overview
page_title: Overview
description: Overview
slug: radspreadstreamprocessing-overview
tags: overview
published: True
position: 0
---

# Overview

Thank you for choosing Telerik **RadSpreadStreamProcessing**!

This article briefly explains the specifics of **RadSpreadStreamProcessing** - what is spread streaming, how it works compared to the RadSpreadProcessing library and when to use it.

>**RadSpreadStreamProcessing** is part of the **Telerik Document Processing** libraries. The full documentation for this component is available at [https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamsprocessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/overview).


![](images/SpreadStreamProcessing-Overview_01.png)

## What is Spread Streaming?

Spread streaming is a document processing paradigm that allows you to create big spreadsheet documents with great performance and minimal memory footprint. 

The key for the memory efficiency is that the spread streaming library writes the spreadsheet content directly to a stream without creating and preserving the spreadsheet document model in memory. Each time an exporter object is disposed, the set values are written into the stream. This allows you to create large documents with an excellent performance.

## Key Features

Some of the features you can take advantage of are:

* Export to XLSX or CSV files
* Writing directly into a stream
* Append new worksheets to existing ones
* Grouping
* [Styling](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/cell-styles) and [formatting cells](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/cells#set-a-format)
* Hidden [rows](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/row) and [columns](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/column)
* [Freezing panes](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/features/worksheet-view-exporter#freeze-panes)

## RadSpreadStreamProcessing vs. RadSpreadProcessing

There are two main differences between the libraries.
* __RadSpreadStreamProcessing__ can be used only to create documents and append data to existing ones. On the other hand you can use the __RadSpreadProcessing__ also for reading and modifying the content of documents.
* __RadSpreadStreamProcessing__ writes directly into a stream, unlike [RadSpreadProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/overview) which creates models for the elements in the document. This is why the memory used with the spread streaming library is significantly lower than when using __RadSpreadProcessing__.

## When to Use RadSpreadStreamProcessing

You can use the spread stream processing to create and export large amount of data with a low memory footprint and great performance. You can also append data to already existing document stream.