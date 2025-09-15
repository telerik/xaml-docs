---
title: WinForms Host is Not Rendering if The RadRibbonView Panel is Collapsible
description: "The content of RadRibbonView is not visible when the control is minimizable and WindowsFormsHost is used."
type: troubleshooting
page_title: Render Windows Form Host when the RibbonView content is minimized
slug: kb-ribbonview-window-host-rendering
position: 0
tags: windowsform, ribbonview, rendering, collapsible
ticketid: 1603732
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadRibbonView for WPF</td>
        </tr>
    </tbody>
</table>

## Description

The content of `RadRibbonView` is not visible when the control is [minimizable]({%slug radribbonview-minimization%}) and `WindowsFormsHost` is used.

## Solution

To host `WindowsFormsHost` content in a WPF Window or Popup, you should disable its transparency, otherwise the `WindowsFormsHost` content won't get displayed.


```C#
	private void RadRibbonView_Loaded(object sender, RoutedEventArgs e)
	{
		var ribbonView = (RadRibbonView)sender;
		var popup = ribbonView.ChildrenOfType<Popup>().FirstOrDefault(x => x.Name == "TabContentPopup");
		if (popup != null)
		{
			popup.AllowsTransparency = false;
		}
	}
```
