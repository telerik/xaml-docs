---
title: Return Focus to RadMultiColumnComboBox After its Drop Down Closes
description: Focus back the control when its drop down popup gets closed.
page_title: Bring Back the Focus to RadMultiColumnComboBox or GridViewMultiColumnComboBoxColumn When its Popup gets Closed.
type: how-to
slug: kb-multicolumncombobox-return-focus-after-popup-close
position: 0
tags: loses,focus,dropdown,close
ticketid: 1449317
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3.917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadMultiColumnComboBox for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to return the focus to RadMultiColumnComboBox after the Popup with its drop down content closes. 

## Solution

To do this, you can subscribe to the __DropDownClosed__ event of the control and in the event handler manually focus the text input control.


```C#
	public MainWindow()
	{
		InitializeComponent();
		this.radMultiColumnComboBox.AddHandler(RadDropDownButton.DropDownClosedEvent, new RoutedEventHandler(OnMCCBDropDownClosed));
	}
	
	private void OnMCCBDropDownClosed(object sender, RoutedEventArgs e)
	{
		var mccb = (RadMultiColumnComboBox)sender;
		mccb.ChildrenOfType<RadWatermarkTextBox>().First().Focus();
	}
```

If you use the __GridViewMultiColumnComboBoxColumn__, you can use the __PreparedCellForEdit__ event of RadGridView in order to get the RadMultiColumnComboBox instance and attach the DropDownClosed event handler.


```C#
	private void RadGridView_PreparedCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
	{
		var mccb = e.EditingElement as RadMultiColumnComboBox;
		if (mccb ! null)
		{
			mccb.AddHandler(RadDropDownButton.DropDownClosedEvent, new RoutedEventHandler(OnMCCBDropDownClosed));
		}		
	}
	
	private void OnMCCBDropDownClosed(object sender, RoutedEventArgs e)
	{
		var mccb = (RadMultiColumnComboBox)sender;
		mccb.ChildrenOfType<RadWatermarkTextBox>().First().Focus();
	}
```
