---
title: Customize the TextBox
page_title: Customize the TextBox
description: This article shows how to customize the appearance of the TextBox part of RadAutoSuggestBox.
slug: radautosuggestbox-appearance-customize-textbox
tags: watermarktextbox,style,customize
position: 2
---

# Customize the TextBox

The appearance of the TextBox part of RadAutoSuggestBox can be customized via the __TextBoxStyle__ property of the control.

The TextBoxStyle property expects a Style object with a __TargetType__ set to __RadWaterMarkTextBox__.

#### __[XAML] Example 1: Setting TextBoxStyle__
{{region radautosuggestbox-appearance-customize-textbox-0}}
	<telerik:RadAutoSuggestBox>	
		<telerik:RadAutoSuggestBox.TextBoxStyle>
			<!-- The BasedOn property is required when using NoXaml dlls. Otherwise, you will need to extract and place the whole RadWatermarkTextBoxStyle here -->
			<Style TargetType="telerik:RadWatermarkTextBox" BasedOn="{StaticResource RadWatermarkTextBoxStyle}">
				<Setter Property="Foreground" Value="Red" />
				<Setter Property="Opacity" Value="0.5" />
				<Setter Property="FontWeight" Value="Bold" />                    
			</Style>
		</telerik:RadAutoSuggestBox.TextBoxStyle>
	</telerik:RadAutoSuggestBox>
{{endregion}}

![](images/radautosuggestbox-appearance-customize-textbox-0.png)

## See Also  
 * [Getting Started]({%slug radautosuggestbox-getting-started%})
 * [Events]({%slug radautosuggestbox-events%})  
 * [Buttons]({%slug radautosuggestbox-appearance-customize-buttons%})
 * [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})
