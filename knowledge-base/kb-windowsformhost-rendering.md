---
title: Windows Form Host is Not Rendering If the Panel is Collapsible
description: "How to render Windows Form host if the Panel is collapsible"
type: how-to
page_title: How to render Windows Form Host if the Panel is Collapsible in RadRibbonView for WPF
slug: kb-windowsformhost-rendering
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

How to render `Windows Form Host` if the `Panel` is collapsible in `RadRibbonView` element.


## Solution

To host `Windows Forms` content in a `WPF Window` or Popup, you should disable its transparency, otherwise the `Windows Forms` content won't get displayed.

#### __[C#]__
{{region kb-windowsformhost-rendering}}
	private void RadRibbonView_Loaded(object sender, RoutedEventArgs e)
	{
		var ribbonView = (RadRibbonView)sender;
		var popup = ribbonView.ChildrenOfType<Popup>().FirstOrDefault(x => x.Name == "TabContentPopup");
		if (popup != null)
		{
			popup.AllowsTransparency = false;
		}
	}
{{endregion}}
