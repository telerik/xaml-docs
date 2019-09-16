---
title: Change Windows Handedness Settings in code behind
description: Change Windows Handedness settings in code
type: how-to
page_title: How to change Windows Tablet PC Handedness Settings
slug: kb-common-change-windows-handedness-settings
position: 1
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
	    	<td>UI for WPF</td>
	    </tr>
    </tbody>
</table>


## Description

To change the Windows Handedness settings in code, you can set the __SystemParameters.MenuDropAlignment__ property. The method need to be called after the InitializeComponent() method.

#### __[C#]__
{{region kb-common-change-windows-handedness-settings-0}}
	public partial class Window1 : Window
		{
			public Window1()
			{
				InitializeComponent();
				this.SetAlignment();
			}
		}

	public static void SetAlignment()
	{
		var ifLeft = SystemParameters.MenuDropAlignment;
	  
		if (ifLeft)
		{
			// change to false
			var t = typeof(SystemParameters);
			var field = t.GetField("_menuDropAlignment", BindingFlags.NonPublic | BindingFlags.Static);
			field.SetValue(null, false);
	  
			ifLeft = SystemParameters.MenuDropAlignment;
		}
	}
{{endregion}}