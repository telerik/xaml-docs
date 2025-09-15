---
title: Slider Middle Thumb Is not Displayed as Expected when Setting a Custom Style
description: The middle thumb of the RadSlider control is not displayed correctly after setting a custom style for it.
page_title: When Creating a Custom Style for the Middle Thumb It Is not Displayed Correctly
type: troubleshooting
slug: kb-slider-style-middle-thumb-style-manager
position: 0
tags: slider,middle,thumb,not,displayed,expected,correctly,setting,custom,style
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2020.3.916</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadSlider for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

When creating a custom style for the middle thumb of the RadSlider, it is not displayed correctly.

## Solution

The most likely cause for this issue is that you're using the [StyleManager theming approach]({%slug common-styling-apperance-setting-theme-wpf%}). In this case to change the style of the middle thumb you need to override the default **Thumb** style and template. You also need to set an appropriate **Height** for it, depending on the theme you're using.

The example below includes the optimal Height values for each of the [themes]({%slug common-styling-appearance-available-themes%}) provided by the Telerik UI for WPF suite.


```XAML
	<Style x:Key="CustomSelectionMiddleThumbStyle" TargetType="Thumb">
		<!--Office2013, VisualStudio2013, ExpressionDark, VisualStudio2019-->
		<Setter Property="Height" Value="6" />
		<!--Windows8, Crystal -->
		<Setter Property="Height" Value="3" />
		<!--Windows8Touch-->
		<Setter Property="Height" Value="9" />
		<!--Office_Black, Office_Blue, Office_Silver, Summer, Vista,Green-->
		<Setter Property="Height" Value="4" />
		<!--Transparent-->
		<Setter Property="Height" Value="5" />
		<!--Fluent, Material, Office2016, Office2019-->
		<Setter Property="Height" Value="2" />
		<!--Office2016Touch-->
		<Setter Property="Height" Value="10" />

		<!-- Desired Background and BorderBrush -->
		<Setter Property="Background" Value="Blue" />
		<Setter Property="BorderBrush" Value="Red" />
		<Setter Property="Template">
			<Setter.Value>
				<ControlTemplate TargetType="Thumb">
					<Grid>
						<Border x:Name="BorderVisual"
								BorderBrush="{TemplateBinding BorderBrush}"
								BorderThickness="{TemplateBinding BorderThickness}"
								Background="{TemplateBinding Background}" />
					</Grid>
				</ControlTemplate>
			</Setter.Value>
		</Setter>
	</Style>

	<Style TargetType="telerik:RadSlider">
		<Setter Property="SelectionMiddleThumbStyle" Value="{StaticResource CustomSelectionMiddleThumbStyle}" />
	</Style>
```

## See Also
* [StyleManager ThemingApproach]({%slug common-styling-apperance-setting-theme-wpf%})
* [Available Themes]({%slug common-styling-appearance-available-themes%})