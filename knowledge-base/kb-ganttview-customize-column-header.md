---
title: Customize Column Header
description: This article will show you how to display complex structure in the headers of the columns of RadGanttView.
page_title: Display Complex Structure in the Columns Headers
type: how-to
slug: kb-ganttview-customize-column-header
position: 0
tags: ganttview, column, customize, header
res_type: kb
ticketid: 1648836
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.1.423</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGanttView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The header of the ColumnDefinition class is represented by a ColumnHeaderContainer element. The default style of this element sets its ContentTemplate property to a TextBlock element. This element displays the value set to the Header property of the ColumnDefinition class. This prevents setting complex structure for the headers of the columns.

## Solution

Create a new `Style` with `TargetType="ColumnHeaderContainer"` and add a new `Setter` for the `ContentTemplate` property. Then, set it to a new `DataTemplate` with a `ContentPresenter` instance in it.

#### __[XAML] Creatring a new Style that targets the ColumnHeaderContainer and sets a custom DataTemplate to its ContentTemplate property__
{{region kb-ganttview-customize-column-header-0}}
    <!--If NoXaml is used base the Style on the default one: BasedOn="{StaticResource ColumnHeaderContainerStyle}"-->
    <Style TargetType="telerik:ColumnHeaderContainer">
        <Setter Property="ContentTemplate">
            <Setter.Value>
                <DataTemplate>
                    <ContentPresenter Content="{Binding Header}"/>
                </DataTemplate>
            </Setter.Value>
        </Setter>
    </Style>
{{endregion}}

#### __[XAML] Setting a complex structure to the Header property of a ColumnDefinition instance__
{{region kb-ganttview-customize-column-header-1}}
    <telerik:ColumnDefinition MemberBinding="{Binding DurationDays}" Width="100">
        <telerik:ColumnDefinition.Header>
            <StackPanel Orientation="Vertical">
                <Label Content="Duration" Foreground="Red"/>
                <Label Content="in days" Foreground="Red"/>
            </StackPanel>
        </telerik:ColumnDefinition.Header>
    </telerik:ColumnDefinition>
{{endregion}}

__GanttView ColumnDefinition with complex structure set to its Header property__

![GanttView ColumnDefinition with complex structure set to its Header property](images/kb-ganttview-customize-column-header-0.png)