---
title: Change Windows Handedness Settings in Code Behind
page_title: How to change Windows Tablet PC Handedness Settings
description: Change where the Popup menus appear on the screen by setting SystemParameters.MenuDropAlignment.
type: how-to
slug: kb-common-change-windows-handedness-settings
position: 0
tags: windows,tablet,settings,left-handed,right-handed,handedness,pc
ticketid: 1429407
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>Progress® Telerik® UI for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to change windows handedness settings in code behind.

## Solution

To change the Windows Handedness settings in code, you can set the __SystemParameters.MenuDropAlignment__ property. The method need to be called after the InitializeComponent() method.


```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			SetAlignment();
		}
	}

	public static void SetAlignment()
	{
		var ifLeft = SystemParameters.MenuDropAlignment;	  
		if (ifLeft)
		{
			var t = typeof(SystemParameters);
			var field = t.GetField("_menuDropAlignment", BindingFlags.NonPublic | BindingFlags.Static);
			field.SetValue(null, false);
		}
	}
```
