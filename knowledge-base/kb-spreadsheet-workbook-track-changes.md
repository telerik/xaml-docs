---
title: Track changes in workbook
description: Learn how to track whether the content of a Workbook has been modified.
type: how-to
page_title: Track changes in workbook
slug: workbook-track-changes
position: 0
tags: spread, modify, change
res_type: kb
---

|Product Version|Product|Author|
|----|----|----|
|2020.2.617|RadSpreadsheet|[Tanya Dimitrova](https://www.telerik.com/blogs/author/tanya-dimitrova)|

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2020.2.617</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadSpreadsheet for WPF</td>
	    </tr>
    </tbody>
</table>

## Description
 
You need to track whether the content of a Workbook has been modified.

## Solution

Use the **WorkbookContentChanged** event.



```C#

    bool hasBeenWorkbookModified = false;
    workbook.WorkbookContentChanged += (sender, args) => { hasBeenWorkbookModified = true; }
                                        
```