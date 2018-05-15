---
title: Header Template
page_title: Header Template
description: Header Template
slug: radtimepicker-header-template
tags: header,template
published: True
position: 1
---

# Header Template

In __RadTimePicker__ it is possible to customize the built-in text and template of the __Header__ and __HeaderTemplate__.        

The next example will demonstrate the necessary steps in order to customize the Header and HeaderTemplate of the RadTimePicker control. 

> Please note that if you are using [NoXaml]({%slug styling-apperance-implicit-styles-overview%}) dlls, you need to base your style on the default one for the theme. You can read more about that in the [Styling the Controls]({%slug implicit-styles-styling-the-controls%}) article.      

#### __[XAML] Example 1: Define Style targeting RadClock__

{{region xaml-radtimepicker-header-template_0}}
	<Style x:Key="RadClockStyle" TargetType="telerik:RadClock" >
	
	</Style>
{{endregion}}

#### __[XAML] Example 2: Set Header property__

{{region xaml-radtimepicker-header-template_1}}
	<Style x:Key="RadClockStyle1" TargetType="telerik:RadClock" >
		<Setter Property="Header" Value="Custom Header and HeaderTemplate"/>
	</Style>
{{endregion}}

#### __[XAML] Example 3: Set HeaderTemplate property__

{{region xaml-radtimepicker-header-template_2}}
	<Style x:Key="RadClockStyle2" TargetType="telerik:RadClock" >
		<Setter Property="Header" Value="Custom Header and HeaderTemplate"/>
		<Setter Property="HeaderTemplate">
			<Setter.Value>
				<DataTemplate>
					<Border BorderBrush="White" BorderThickness="1" Margin="3">
						<TextBlock Text="{Binding}" Margin="5"/>
					</Border>
				</DataTemplate>
			</Setter.Value>
		</Setter>
	</Style>
{{endregion}}

#### __[XAML] Example 4: Set RadTimePicker's ClockStyle property__

{{region xaml-radtimepicker-header-template_3}}
	<telerik:RadTimePicker ClockStyle="{StaticResource RadClockStyle2}"/>
{{endregion}}

#### __Figure 1: RadTimePicker with styled header__

![radtimepicker-header-template-1](images/radtimepicker-header-template-1.png)
