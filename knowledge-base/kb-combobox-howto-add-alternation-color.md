---
title: Add alternation color to the drop-down items of RadComboBox
description: Using AlternationCount property of RadComboBox 
type: how-to
page_title: How to add alternation color to the drop-down items of RadComboBox
slug: kb-combobox-howto-add-alternation-color
position: 0
tags: alternationcount, radcombobox, alternationindex
ticketid: 1495739
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3 1116</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadComboBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to add alternation color to the items inside the drop-down content of RadComboBox control.

## Solution

To add alternation color to the items inside the drop-down content you can take advantage of the AlternationCount property. This property comes from the native ItemsControl class. As the RadComboBox inherits ItemsControl you can take advante of this funtionality.

The following example demonstrates how to use this property and how to apply custom color to the alternation items.


```C#
	<telerik:RadComboBox AlternationCount="2" ItemsSource="{Binding Data}" DisplayMemberPath="Name">
		<telerik:RadComboBox.ItemContainerStyle>
			<Style TargetType="telerik:RadComboBoxItem">
				<Style.Triggers>
					<Trigger Property="ItemsControl.AlternationIndex" Value="0">
						<Setter Property="Background" Value="Bisque"/>
						<Setter Property="Foreground" Value="Purple"/>
					</Trigger>
					<Trigger Property="ItemsControl.AlternationIndex" Value="1">
						<Setter Property="Background" Value="LightBlue"/>
						<Setter Property="Foreground" Value="Navy"/>
					</Trigger>
				</Style.Triggers>
			</Style>
		</telerik:RadComboBox.ItemContainerStyle>
	</telerik:RadComboBox>
```