---
title: Styling the ButtonChrome
page_title: Styling the ButtonChrome
description: Check our &quot;Styling the ButtonChrome&quot; documentation article for the RadButtons WPF control.
slug: radbuttons-styles-and-templates-styling-buttonchrome
tags: styling,the,buttonchrome
published: True
position: 2
---

# Styling the ButtonChrome

The __ButtonChrome__ control was part of the template of the __RadButtons__. It was responsible for the visual appearance of the button. If you're using an older version of the RadControls, this article will help you style the __ButtonChrome__ control. It can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

## Create an empty implicit style and set it up on your own. 

> The ButtonChrome is located in the following namespace: xmlns:chromes="clr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls"

#### __[C#] Example 1: Create custom implicit style__
{{region radbuttons-styles-and-templates-styling-buttonchrome-0}}
	<Window.Resources>
		<Style TargetType="chromes:ButtonChrome">
			<Setter Property="Opacity" Value="0.5"/>
			<Setter Property="BorderBrush" Value="Red"/>
			<Setter Property="BorderThickness" Value="1"/>
		</Style>
	</Window.Resources>
	<Grid>
		<chromes:ButtonChrome Width="200" Height="200"  VerticalAlignment="Center" HorizontalAlignment="Center"/>
	</Grid>
{{endregion}}

## Edit the default template of the control

If you prefer, you can [manually extract the needed style from the respective XAML file]({%slug styling-apperance-editing-control-templates%}#extracting-control-templates-manually-from-the-theme-xaml-file) in the **Themes.Implicit** folder of your **Telerik UI** installation and modify its code to suit your needs.

>tip If you choose to define the style in the App.xaml file, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

>importantNote that when changing a __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be impacted due to the omission of the required parts. The required parts are usually marked with the prefix "__PART___".


## See Also
 * [Template Structures]({%slug radbuttons-styles-and-templates-template-structures%})
 * [Styling the RadButton]({%slug radbuttons-styles-and-templates-styling-the-radbutton%})
 * [Styling the RadDropDownButton]({%slug radbuttons-styles-and-templates-styling-the-radropdownbutton%})
 * [Styling the RadRadioButton]({%slug radbuttons-styles-and-templates-styling-the-radradiobutton%})
 * [Styling the RadSplitButton]({%slug radbuttons-styles-and-templates-styling-the-radsplitbutton%})
 * [Styling the RadToggleButton]({%slug radbuttons-styles-and-templates-styling-the-radtogglebutton%})
