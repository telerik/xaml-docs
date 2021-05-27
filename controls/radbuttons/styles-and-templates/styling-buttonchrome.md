---
title: Styling the ButtonChrome
page_title: Styling the ButtonChrome
description: Check our &quot;Styling the ButtonChrome&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-styles-and-templates-styling-buttonchrome
tags: styling,the,buttonchrome
published: True
position: 2
---

# Styling the ButtonChrome

__ButtonChrome__ is a Control that has no input functionality. It was part of the template of the __RadButtons__. It was responsible for the visual appearance of the button. If you're using an older version of the RadControls, this article will help you style the __ButtonChrome__ control. It can be styled by creating an appropriate __Style__ and setting it to the __Style__ property of the control. 

## Properties

The Button chrome’s appearance is controlled by several Boolean typed properties:
* __RenderMouseOver__: render as MouseOvered button;
* __RenderPressed__: render as Pressed button;
* __RenderEnabled__: default True. When set to False render as Disabled button;
* __RenderNormal__: default True. When set to False render transparent as toolbar button;
* __RenderChecked__: renders as checked ToggleButton;
* __RenderActive__: used in SplitButtons;
* __RenderActive__: renders as MouseOvered ListBoxItem;
* __RenderSelected__: renders as Selected ListBoxItem;
* __RenderFocused__: renderes as Focused item;
* __Orientation__: default Horizontal can be set to Vertical to rotate the gradients in some states;
* __CornerRadius__: used to set the outer corners;
* __InnerCornerRadius__: readonly. Computed as decreased CornerRadius.

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

![style buttonchrome](images/styling_buttonchrome_0.png)

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
