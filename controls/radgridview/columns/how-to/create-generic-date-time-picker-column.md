---
title: Create Generic DateTimePicker Column
page_title: Create Generic DateTimePicker Column
description: Create Generic DateTimePicker Column
slug: gridview-how-to-create-generic-date-time-picker-column
tags: create,custom,generic,datetimepicker,column
published: True
position: 14
---

# Create Generic DateTimePicker Column

> The approach of creating a custom __DateTimePicker Column__ is described in the [Create Custom DateTimePicker Column]({%slug gridview-how-to-create-date-time-picker-column%}) article.

In order to make your custom __DateTimePicker Column__ reusable, instead of binding its __RadDatePicker/RadTimePicker SelectedValue__ property to a specific one from your business object, you can bind it to __SelectedDate/SelectedTime__ property of the corresponding control. Thus, the custom __DateTimePicker Column__ could  be used with different data sources. 

#### __[XAML] Example 1: Declaration of Generic DateTimePicker Column__

	<UserControl x:Class="CustomDateTimePickerColumn_WPF.CustomDateTimePicker"
			 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
			 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
			 xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
			 xmlns:local="clr-namespace:CustomDateTimePickerColumn_WPF"
			 xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
			 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition />
            <ColumnDefinition />
        </Grid.ColumnDefinitions>
        <Grid.Resources>
            <Style x:Key="RadClockStyle" TargetType="telerik:RadClock">
                <Setter Property="Header" Value="TimePicker" />
            </Style>
        </Grid.Resources>
        <telerik:RadDatePicker x:Name="Calendar"
							   SelectedValue="{Binding SelectedDate,
											   RelativeSource={RelativeSource AncestorType={x:Type local:CustomDateTimePicker}}}"
							   SelectionChanged="OnCalendarSelectionChanged" />
        <telerik:RadTimePicker x:Name="TimePicker"
							   Grid.Column="1"
							   ClockStyle="{StaticResource RadClockStyle}"
							   SelectedValue="{Binding SelectedDate,
											   RelativeSource={RelativeSource AncestorType={x:Type local:CustomDateTimePicker}}}"
							   SelectionChanged="OnTimePickerSelectionChanged" />
    </Grid>
	</UserControl>


# See Also
 
 * [Add a button column]({%slug gridview-add-button-column%})

 * [Create Custom Editor with RadGridView]({%slug radgridview-howto-create-custom-editor%})