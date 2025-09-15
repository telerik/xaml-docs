---
title: Cancel Invalid Cell Edit on Click Outside of RadGridView 
description: Revert changes in invalid GridViewCell when another control gets the focus.
page_title: Cancel Invalid Cell Edit Mode on Button Click
type: how-to
slug: kb-gridview-cancel-edit-on-lostfocus
position: 0
tags: lostfocus,gotfocus,invalid,validation,cell,cancel
ticketid: 1446704
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
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to cancel changes in invalid GridViewCell and exit edit mode when another control gets the focus.

## Solution

To do this, you can subscribe for the GotFocus event of the control that should steal the focus from RadGridView and in the event handler, call the __CancelEdit__ method of RadGridView.


```XAML
	<Grid>
		<telerik:RadGridView x:Name="radGridView" />
		<telerik:RadButton x:Name="cancelEditButton" GotFocus="cancelEditButton_GotFocus"/>
	</Grid>
```


```C#
	private void cancelEditButton_GotFocus(object sender, RoutedEventArgs e)
	{
		this.radGridView.CancelEdit();
	}
```