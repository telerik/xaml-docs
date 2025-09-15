---
title: Disable File Rename on Double Click in ExplorerControl
description: How to disable file rename on fast double click in RadFileDialogs ExplorerControl.
type: how-to
page_title: Cancel Rename on Fast File Double Click in ExplorerControl
slug: kb-file-dialogs-disable-double-click-rename
position: 0
tags: explorer,control,rename,double,click
ticketid: 1526045
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2022.3.1109</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadFileDialogs for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to disable file rename on fast double click in RadFileDialogs ExplorerControl.

## Solution

A common behavior on double click is file select and open. In the `ExplorerControl` there is no file opening, so instead a file renaming action is started when you double click the file. To cancel the file renaming, subscribe to the `Renaming` event of `ExplorerControl` and set the `Cancel` property of the event arguments to `true`. The double click action can be indicated through the `PreviewMouseDoubleClick` event of the `ExplorerControl`.


```C#
	private bool isDoubleClick = false;
	
	private void ExplorerControl_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
	{
		isDoubleClick = true;
	}

	private void ExplorerControl_Renaming(object sender, Telerik.Windows.Controls.FileDialogs.RenamingEventArgs e)
	{
		if (e.FileInfo is FileInfoWrapper && this.isDoubleClick)
		{
			e.Cancel = true;
		}
		isDoubleClick = false;
	}
```