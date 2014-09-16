---
title: How to Change the Position of the Tab Strip of RadTabControl
page_title: How to Change the Position of the Tab Strip of RadTabControl
description: How to Change the Position of the Tab Strip of RadTabControl
slug: radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-radtabcontrol
tags: how,to,change,the,position,of,the,tab,strip,of,radtabcontrol
publish: True
position: 6
---

# How to Change the Position of the Tab Strip of RadTabControl



## 

The [tab strip placement]({%slug radtabcontrol-visual-structure%}) can be controlled via the 
        property __TabStripPlacement__. It allows you to define the exact position where the tab strip should appear 
        using the __Telerik.Windows.Controls.Dock__ enumeration. The four possible choices are:![](images/RadTabControl_Figure_00660.png)

#### __XAML__

{{region radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-RadTabControl_0}}
	<telerik:RadTabControl x:Name="radTabControl" TabStripPlacement="Bottom">
	    <telerik:RadTabItem Header="Calendar"/>
	    <telerik:RadTabItem Header="Colors"/>
	    <telerik:RadTabItem Header="Quote"/>
	</telerik:RadTabControl>
	{{endregion}}



The same operation can be done in the code-behind:

#### __C#__

{{region radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-RadTabControl_1}}
	private void SetTabStripPlacement()
	{
	    radTabControl.TabStripPlacement = Telerik.Windows.Controls.Dock.Bottom;
	}
	{{endregion}}



#### __VB.NET__

{{region radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-RadTabControl_2}}
	Private Sub SetTabStripPlacement()
	    radTabControl.TabStripPlacement = Telerik.Windows.Controls.Dock.Bottom
	End Sub
	{{endregion}}



# See Also

 * [How to Select Control in Expression Blend]({%slug radtabcontrol-how-to-select-control-in-expression-blend%})

 * [How to Create Multi-line Tabs]({%slug radtabcontrol-how-to-create-multi-line-tabs%})

 * [How to Add Close Button to the Tab Headers]({%slug radtabcontrol-how-to-add-close-button-to-the-tab-headers%})
