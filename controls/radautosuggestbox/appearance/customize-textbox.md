---
title: Customize the TextBox
page_title: Customize the TextBox
description: This article shows how to customize the appearance of the TextBox part of RadAutoSuggestBox.
slug: radautosuggestbox-appearance-customize-textbox
tags: watermarktextbox,style,customize
position: 2
---

# {{ site.framework_name }} RadAutoSuggestBox Customize the TextBox

The appearance of the TextBox part of RadAutoSuggestBox can be customized via the __TextBoxStyle__ property of the control.

The TextBoxStyle property expects a Style object with a __TargetType__ set to __RadWatermarkTextBox__.

#### __[XAML] Example 1: Setting TextBoxStyle__
{{region radautosuggestbox-appearance-customize-textbox-0}}
	<telerik:RadAutoSuggestBox Foreground="Red">	
		<telerik:RadAutoSuggestBox.TextBoxStyle>
			<!-- The BasedOn property is required when using NoXaml dlls. Otherwise, remove the setting. -->
			<Style TargetType="telerik:RadWatermarkTextBox" BasedOn="{StaticResource RadWatermarkTextBoxStyle}">				
				<Setter Property="Opacity" Value="0.5" />
				<Setter Property="FontWeight" Value="Bold" />                    
			</Style>
		</telerik:RadAutoSuggestBox.TextBoxStyle>
	</telerik:RadAutoSuggestBox>
{{endregion}}

![{{ site.framework_name }} RadAutoSuggestBox Custom TextBoxStyle](images/radautosuggestbox-appearance-customize-textbox-0.png)

## See Also  
 * [Getting Started]({%slug radautosuggestbox-getting-started%})
 * [Events]({%slug radautosuggestbox-events%})
 * [Buttons]({%slug radautosuggestbox-appearance-customize-buttons%})
 * [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})
 * [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
