---
title: ComboBox Content Truncated When Height Set to Less Than 26px in Office2016 Theme
page_title: Content Element of RadComboBox is Clipped If Height is Smaller Than 26px
description: The content control inside of RadComboBox gets clipped when the Height of the combobox is less than 26px in Office2016 them.
type: troubleshooting
slug: kb-combobox-content-clipped-when-small-height
position: 0
tags: content,height,minheight
ticketid: 1414330
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2 618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadComboBox for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

The content control inside of RadComboBox gets clipped when the Height of the combobox is less than 26px in Office2016 them.

Note that only the content gets clipped and not the control itself. The expected behavior is that the content is clipped, but also the control becomes smaller.

## Solution

Set the MinHeight property of the child RadToggleButton to the same MinHeight as RadComboBox.


	```C#
	private void RadComboBox_Loaded(object sender, RoutedEventArgs e)
	{
		var comboBox = (RadComboBox)sender;
		var toggle = comboBox.FindChildByType<RadToggleButton>();
		toggle.MinHeight = comboBox.MinHeight;
	}
```

## See Also
* [FindChildByType]({%slug common-visual-tree-helpers%})