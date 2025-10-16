---
title: Set Width of Filter Dialog in RadGridView for WPF
description: "This article provides a solution for controlling the width of the filter dialog in RadGridView for WPF when the checkbox list contains long text items."
type: how-to
page_title: How to Limit the Width of the Filter Dialog in RadGridView for WPF
slug: kb-gridview-set-width-filteringcontrol
tags: radgridview, wpf, filter-dialog, width, checkbox-list
res_type: kb
---

## Environment

| Property | Value |
| --- | --- |
| Product | RadGridView for WPF |
| Version | 2023.3.1114 |

## Description

How to limit the width of the filter dialog (FilteringControl) in RadGridView for WPF when the checkbox list contains long text items. 

## Solution

To change the width of the filter dialog you can set the `Width` or `MaxWidth` of the `FilteringControl`. This can be done via the `FilteringControlStyle` property of the columns.


```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}">
		<telerik:GridViewDataColumn.FilteringControlStyle>
			<!-- if you use the Telerik NoXaml dlls, you will need to add the following setting to the Style object -->
			<!-- BasedOn="{StaticResource FilteringControlStyle}" -->
			<Style TargetType="telerik:FilteringControl">
				<Setter Property="MaxWidth" Value="150" />
			</Style>
		</telerik:GridViewDataColumn.FilteringControlStyle>
	</telerik:GridViewDataColumn>
```
