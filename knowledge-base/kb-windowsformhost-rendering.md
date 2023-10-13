---
title: Windows Form Host is Not Rendering if The Panel is Collapsible
description: "This article demonstrates how to render window host if the Panel is folding"
type: how-to
page_title: Render Windows Form Host if The Panel is Collapsible in RadRibbonView For WPF
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
