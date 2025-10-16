---
title: Zoom In or Out a Worksheet
page_title:  Zoom In or Out a Worksheet
description:  Zoom In or Out a Worksheet.
slug: radspreadsheet-zoom-in-or-out-a-worksheet
tags: worksheet, zoom, scale, slider, scalefactor
published: True
position: 10
---

# Zoom In or Out a Worksheet

This article describes how you can change the zoom level of the [Worksheet](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/worksheet), which helps to take a close-up view of your **Worksheet** or to zoom out to see more of the page at a reduced size.

In order to do so there are two different approaches available: [Using UI](#using-ui) or [Programmatically](#programmatically).

## Using UI

On the status bar of the RadSpreadsheet app, move the zoom scale slider or click the '-' (_minus_) or '+' (_plus_) button to zoom in gradual increments.

![Zoom scale slider](images/RadSpreadsheet_HowTo_Zoom_In_Out_Worksheet_01.png)

The particular zoom setting is preserved when save/export the [Worksheet](https://docs.telerik.com/devtools/document-processing/libraries/radspreadstreamprocessing/model/worksheet). 

## Programmatically 
By using the [RadWorksheetEditor](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.spreadsheet.worksheets.radworksheeteditor)`s **ScaleFactor** property. The default value for the width and the height of the **ScaleFactor** is 1.

#### **C# Example 1: Zoom in**

```C#

    this.radSpreadsheet.ActiveWorksheetEditor.ScaleFactor = new Size(2, 2);
```

#### **C# Example 1: Zoom out**

```C#

    this.radSpreadsheet.ActiveWorksheetEditor.ScaleFactor = new Size(0.5, 0.5);
```
