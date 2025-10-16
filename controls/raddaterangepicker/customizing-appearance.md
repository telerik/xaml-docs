---
title: Customizing Appearance
page_title: Customizing Appearance
description: Check our &quot;Customizing Appearance&quot; documentation article for the RadDateRangePicker WPF control.
slug: raddaterangepicker-customizing-appearance
tags: daterangepicker,input,customizing,styles,templates
published: True
position: 11
---

# Customizing Appearance

DateRangePicker provides several properties that can be used to customize its appearance.

## Showing Week Names and Numbers in the Calendar

By default the calendars in the drop down display only the day numbers, but the week number and dates can be shown as well. To do that, use the `AreWeekNamesVisible`  and `AreWeekNumbersVisible` properties of `RadDateRangePicker`.

__Setting the AreWeekNumbersVisible and AreWeekNamesVisible properties__
```XAML
	<telerik:RadDateRangePicker AreWeekNamesVisible="True" AreWeekNumbersVisible="True" />
```

![Picture showing the week names and numbers of WPF RadDateRangePicker](images/raddaterangepicker-customizing-appearance-0.png)

## Customizing the Clear Button

The clear button is displayed on hover of the text input area. The button can be hidden by setting the `IsClearButtonVisible` property the of `RadDateRangePicker` to `false`.

__Setting the IsClearButtonVisible property__
```XAML
	<telerik:RadDateRangePicker IsClearButtonVisible="False"/>
```

To further customize the button, use the `ClearButtonStyle` property. The property expects a `Style` object with its target type set to `RadButton`.

__Using the ClearButtonStyle property__
```XAML
	<Grid>
		<!-- if you use the NoXaml dlls and the Implicit Styles theming mechanism you don't need this ResourceDictionary -->
		<Grid.Resources>
			<ResourceDictionary Source="/Telerik.Windows.Controls.Input;component/Themes/GenericWindows11.xaml"/>
		</Grid.Resources>
		
		<telerik:RadDateRangePicker>
			<telerik:RadDateRangePicker.ClearButtonStyle>
				<Style TargetType="telerik:RadButton" BasedOn="{StaticResource DateRangeMaskedInputClearButtonStyle}">
					<Setter Property="Foreground" Value="White"/>
					<Setter Property="Background" Value="Purple"/>
					<Setter Property="Padding" Value="10"/>
				</Style>
			</telerik:RadDateRangePicker.ClearButtonStyle>
		</telerik:RadDateRangePicker>
	</Grid>
```

![Picture showing customized clear button style of WPF RadDateRangePicker](images/raddaterangepicker-customizing-appearance-1.png)

## Hiding the Top Bar and Header

The top bar visual in the drop down displays the selected dates and their total number. To hide the top bar, set the `IsTopBarVisible` property of `RadDateRangePicker` to `false`.

__Setting the IsTopBarVisible property__
```XAML	
	<telerik:RadDateRangePicker IsTopBarVisible="False"/>
```

![Picture showing WPF RadDateRangePicker without its top bar](images/raddaterangepicker-customizing-appearance-2.png)

The header visuals in the drop down display the current view (month or year) of each calendar, along with the arrow buttons for changing the current view range. To hide the headers, set the `HeaderVisibility` property of `RadDateRangePicker` to `Collapsed` or `Hidden`.

__Setting the HeaderVisibility property__
```XAML	
	<telerik:RadDateRangePicker HeaderVisibility="Collapsed"/>
```

![Picture showing WPF RadDateRangePicker without its calendar headers](images/raddaterangepicker-customizing-appearance-3.png)

## Hiding the Custom Ranges Panel

The custom ranges panel is displayed next to the calendars in the drop down. To hide this panel, set the `IsDefaultRangesPanelVisible` property of `RadDateRangePicker`.

__Setting the IsDefaultRangesPanelVisible property__
```XAML	
	<telerik:RadDateRangePicker IsDefaultRangesPanelVisible="False"/>
```

![Picture showing WPF RadDateRangePicker without its custom ranges panel](images/raddaterangepicker-customizing-appearance-4.png)

## See Also  
* [Text Input Formatting]({%slug raddaterangepicker-text-input-formatting%})
* [Getting Started]({%slug raddaterangepicker-getting-started%})