---
title: Hide Empty Tooltips in SelectionBoxTemplate
description: This article explains how to hide the tooltips from the RadComboBox's SelectionBoxTemplate when they don't have content.
type: how-to
page_title: How to Show SelectionBox Tooltip Only when the Tooltip Has Content
slug: kb-combobox-hide-empty-tooltips-selectionboxtemplate
position: 0
tags: combobox, hide, empty, content, tooltips, selectionboxtemplate
ticketid: 1447050
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3 1216</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadComboBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to show SelectionBox tooltip only when the tooltip has content.

## Solution

To achieve the desired result, you can add a **DataTrigger** to set the **Tooltip** to **null** when the corresponding property is an empty string. For example, you can define the [SelectionBoxTemplate]({%slug radcombobox-populating-with-data-selectionbox%}) as follows:



```XAML
	<DataTemplate x:Key="SelectionBoxTemplate">
		<TextBlock Text="{Binding Name}">
			<TextBlock.Style>
				<Style TargetType="TextBlock">
					<Setter Property="ToolTip" Value="{Binding Tooltip}" />
					<Style.Triggers>
						<DataTrigger Binding="{Binding Tooltip}" Value="">
							<Setter Property="ToolTip" Value="{x:Null}" />
						</DataTrigger>
					</Style.Triggers>
				</Style>
			</TextBlock.Style>                    
		</TextBlock>
	</DataTemplate>
```

## See Also
* [Selection Box Template]({%slug radcombobox-populating-with-data-selectionbox%})