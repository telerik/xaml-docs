---
title: Auto Size RadImageEditor Picture
page_title: AutoSize ImageEditor Image
description: Show the RadImageEditor image without zoom applied.
type: how-to
slug: kb-imageeditor-auto-size-picture
position: 0
tags: autosize,picture,zoom
ticketid: 1421809
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2018.3.911</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadImageEditor for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to auto size RadImageEditor's picture so that no zooming is applied.

## Solution

Set the __ScaleFactor__ property of RadImageEditor to 0.


```XAML
	<telerik:RadImageEditor ScaleFactor="0" />
```

If you use RadImageEditorUI, subscribe to its ImageEditorLoaded event and set the property there.


```C#
	private void RadImageEditorUI_ImageEditorLoaded(object sender, EventArgs e)
	{
		var radImageEditorUI = (RadImageEditorUI)sender;
		radImageEditorUI.ImageEditor.ScaleFactor = 0;
	}
```