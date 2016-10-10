---
title: Font Glyphs Overview
page_title: Font Glyphs Overview
description: Font Glyphs Overview
slug: common-styling-appearance-glyphs-overview
tags: glyphs, telerikwebui, office2016, fonts, foregrounds, text, icons
published: True
position: 0
---

# Font Glyphs Overview

With the new Office2016 theme we introduced a new approach to add icons and icon-like images. We are providing font "glyphs" via the __TelerikWebUI__ font. The glyphs are vector symbols that can be used as information-carrying icons or interaction indicators. 

This article explains the specifics of this approach, demonstrates usage with examples and provides a reference sheet for the available glyphs.

> You can find a list with all available glyphs in the [reference sheet]({%slug common-styling-appearance-glyphs-reference-sheet%}).

The TelerikWebUI font provides over 400 individual glyphs. We have chosen this approach to define the icons in the Office2016 because it provides a number of advantages and benefits.
* The glyphs are vector paths which are easily scalable without loss of quality.

* There is a wide range of different beautiful built-in glyphs to choose from.

* They are easily colored – since they are text shapes. It is achieved by setting a Foreground color, which allows their usage in scenarios where the background of the control changes between light and dark color in different interaction states – e.g. buttons.

* They are all contained in the small font file and available for use with the inclusion of the Telerik.Windows.Controls assembly and merging the needed resource dictionary for easier referencing.

* They are available for use in any of our themes, when the needed resources are included. They are __not__ specific for the Office2016.

The __recommended size__ for the TelerikWebUI glyphs is 16 or any multiple of it (e.g. 32, 48, 64 etc.) since they are designed for 16px height. However, they are vector paths and, like any font, would look clean, distinguishable, non-pixelated and beautiful in almost any size, which is their advantage to raster images and icons.

The available glyphs are separated in several groups, based on their usage:
* __Navigation and Layout__
* __Action__
* __Media__
* __Toggle__
* __Alert and Notification__
* __Image__
* __Editor__
* __Map__
* __Social__
* __File__

## Using glyphs

The glyphs are basically text shapes, so they need to be hosted in a control with a text contents. Recommended for this is a __TextBlock__ as it has no special styling.

#### __[XAML] Example 1: Using glyphs__
	<TextBlock FontFamily=”{StaticResource TelerikWebUI}” 
			   FontSize=”16” 
			   Text=”{StaticResource GlyphHeart}” 
			   FontWeight=”Normal” 
			   Foreground=”{telerik:Office2016Resource ResourceKey=IconBrush}”/>

The content of the text-hosting element is set in a string with format *&#xe[3-digit number];*

Since this string carries no meaning for the glyph it relates to, we are providing a dictionary with key-value pairs for all available glyphs. This enables the usage of more meaningful references for the needed glyphs.

#### __[XAML] Example 2: Setting a glyph__
	<!-- Glyph string -->
	<TextBlock Text="&#xe101;" /> 
	
	<!-- Meaningful reference name -->
	<TextBlock Text="{StaticResource GlyphRedo}" /> 

Furthermore that allows inclusions to the __TelerikWebUI__ font as it is extended occasionally, sometimes shifting the numbers of some of the existing glyphs. The resource dictionary is updated and shipped with the font in the assembly with every change, without a need for changes in the already existing projects.

In order to use the glyph references and the font as __StaticResources__ in a project, you need to include the __Telerik.Windoes.Controls.dll__ and merge the required dictionary in the application resources.

#### __[XAML] Example 3: Adding the ResourceDictionary with the fonts__
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 

In the UI for WPF controls the needed resources are provided, so this inclusion is required only in case you would like to use the font and the glyphs in your custom project.

Changing the glyphs’ color is achieved by changing the foreground of the holding element, in the same manner as the foreground of a regular font. This is extremely useful in scenarios when the background of the control changes in different interaction states (see __Example 4__).

#### __[XAML] Example 4: Setting glyph foreground__
	<telerik:RadToggleButton HorizontalAlignment="Center" VerticalAlignment="Center" Padding="10">
		<TextBlock Text="{StaticResource GlyphLock}" 
		           FontFamily="{StaticResource TelerikWebUI}" 
				   FontSize="16" 
				   Foreground="{Binding RelativeSource={RelativeSource AncestorType=ContentPresenter}, 
				   Path=(TextElement.Foreground)}" />
	</telerik:RadToggleButton>

#### __Figure 1: Updated glyph foreground based on the interaction state of the control - normal, mouse over and pressed__  
![](images/common-styling-appearance-glyphs-overview-0.png)

__Example 5__ demonstrates how to change the glyph based on a __RadToggleButton__ being checked or unchecked.

#### __[XAML] Example 5: Dynamic glyph change__
	<telerik:RadToggleButton HorizontalAlignment="Center" VerticalAlignment="Center" Padding="10" >
		<TextBlock FontFamily="{StaticResource TelerikWebUI}" FontSize="16"
			   Foreground="{Binding RelativeSource={RelativeSource AncestorType=ContentPresenter}, Path=(TextElement.Foreground)}" />
		<telerik:RadToggleButton.Resources>
			<Style TargetType="TextBlock">
				<Style.Triggers>
					<DataTrigger Binding="{Binding RelativeSource={RelativeSource AncestorType={x:Type telerik:RadToggleButton}}, Path=IsChecked}" Value="True">
						<Setter Property="Text" Value="{StaticResource GlyphUnlock}" />
					</DataTrigger>
					<DataTrigger Binding="{Binding RelativeSource={RelativeSource AncestorType={x:Type telerik:RadToggleButton}}, Path=IsChecked}" Value="False">
						<Setter Property="Text" Value="{StaticResource GlyphLock}" />
					</DataTrigger>
				</Style.Triggers>
			</Style>
		</telerik:RadToggleButton.Resources>
	</telerik:RadToggleButton>

#### __Figure 2: Dynamic change of the glyph icon when RadToggleButton is toggled__  
![](images/common-styling-appearance-glyphs-overview-1.png)

## See Also

* [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
* [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
* [Glyphs Reference Sheet]({%slug common-styling-appearance-glyphs-reference-sheet%})
