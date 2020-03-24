---
title: Styling the RadToggleButton
page_title: Styling the RadToggleButton
description: Check our &quot;Styling the RadToggleButton&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-styles-and-templates-styling-the-radtogglebutton
tags: styling,the,radtogglebutton
published: True
position: 7
---

# Styling the RadToggleButton

The __RadToggleButton__ can be styled by creating an appropriate __Style__ (or use Implicit Style) and setting it to the __Style__ property of the control. 

You have two options:

## Create an empty implicit style and set it up on your own 

#### __[C#] Example 1: Create custom implicit style__
{{region radbuttons-styles-and-templates-styling-the-radtogglebutton-0}}
	<Window.Resources>
		<Style TargetType="telerik:RadToggleButton">
			<Setter Property="Opacity" Value="0.5"/>
			<Setter Property="BorderBrush" Value="Red"/>
			<Setter Property="BorderThickness" Value="2"/>
		</Style>
	</Window.Resources>
	<Grid>
		<telerik:RadToggleButton Width="200" Height="200" Content="Check"  VerticalAlignment="Center" HorizontalAlignment="Center"/>
	</Grid>
{{endregion}}

## Edit the default template of the control

If you prefer, you can [manually extract the needed style from the respective XAML file]({%slug styling-apperance-editing-control-templates%}#extracting-control-templates-manually-from-the-theme-xaml-file) in the **Themes.Implicit** folder of your **Telerik UI** installation and modify its code to suit your needs.

>tip If you choose to define the style in the App.xaml file, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

>importantNote that when changing a __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be impacted due to the omission of the required parts. The required parts are usually marked with the prefix "__PART___".

## See Also
 * [Toggle Button]({%slug radbuttons-features-toggle-button%})
 * [Template Structures]({%slug radbuttons-styles-and-templates-template-structures%})
 * [Styling the ButtonChrome]({%slug radbuttons-styles-and-templates-styling-buttonchrome%})
