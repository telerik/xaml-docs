---
title: Editing Flag Enum Column in RadGridView
description: How to use FlagEnumEditor to create flag enum editor in the Telerik WPF DataGrid cells.
type: how-to
page_title: How to Create Flag Enums Column in RadGridView
slug: kb-gridview-flag-enum-edit-column
tags: flags, enum, column
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| RadGridView for WPF | 2022.2.511 |

## Description

How to create a cell editor with a drop down that can be used to change the value of a flag enumeration, in RadGridView.

## Solution

To do that, use the [FlagEnumEditor]({%slug radpropertygrid-radenumeditor%}) control in the [CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%}) of the corresponding `GridViewDataColumn`.

#### __[XAML]__
{{region kb-gridview-flag-enum-edit-column-0}}
	<telerik:RadGridView.Columns>
		<telerik:GridViewDataColumn DataMemberBinding="{Binding MyEnumProperty}">
			<telerik:GridViewDataColumn.CellEditTemplate>
				<DataTemplate>
					<telerik:FlagEnumEditor Value="{Binding MyEnumProperty, Mode=TwoWay}" EnumType="local:MyEnumType" />
				</DataTemplate>
			</telerik:GridViewDataColumn.CellEditTemplate>
		</telerik:GridViewDataColumn>
	</telerik:RadGridView.Columns>
{{endregion}}


