---
title: Customize the Buttons
page_title: Customize the Buttons
description: This article shows how to customize the appearance of the query and clear buttons of RadAutoSuggestBox.
slug: radautosuggestbox-appearance-customize-buttons
tags: delete,style,customize,buttons,query,clear
position: 0
---

# Customize the Buttons

RadAutoSuggestBox has two customizeable buttons - the clear button and the query button.

You can customize those by setting the __ClearButtonContent__ and __QueryButtonContent__ properties.

## Changing Button Icons

The default content template of the buttons contains a [RadGlyph]({%slug common-styling-appearance-radglyph%}) control, so you can use a [glyph code]({%slug common-styling-appearance-glyphs-reference-sheet%}) to easily change the default icons.

>tip See the default buttons appearance in the [Visual Structure]({%slug radautosuggestbox-visual-structure%}) article.

__Example 1: Changing the default glyphs__
```XAML
	  <telerik:RadAutoSuggestBox QueryButtonContent="&#xe019;" ClearButtonContent="&#xe10c;" />
```

#### Figure 1: Query and clear buttons with changed glyph icons
![{{ site.framework_name }} RadAutoSuggestBox Query and clear buttons with changed glyph icons](images/radautosuggestbox-appearance-customize-buttons-0.png)

## Customizing the Buttons UI

To replace the default RadGlyph element used to display the buttons' content, set the __QueryButtonContentTemplate__ and __ClearButtonContentTemplate__ properties of RadAutoSuggestBox.

__Example 2: Changing the default content template__
```XAML
	<telerik:RadAutoSuggestBox QueryButtonContent="Search" ClearButtonContent="X">
		<telerik:RadAutoSuggestBox.QueryButtonContentTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding}" Foreground="White" Background="#2D2D30" Padding="3" Opacity="0.8"/>
			</DataTemplate>
		</telerik:RadAutoSuggestBox.QueryButtonContentTemplate>
		<telerik:RadAutoSuggestBox.ClearButtonContentTemplate>
			<DataTemplate>
				<TextBlock Text="{Binding}" Foreground="Red" FontWeight="Bold"/>
			</DataTemplate>
		</telerik:RadAutoSuggestBox.ClearButtonContentTemplate>
	</telerik:RadAutoSuggestBox>
```

#### Figure 2: Query and clear buttons with changed content template
![{{ site.framework_name }} RadAutoSuggestBox Query and clear buttons with changed content template](images/radautosuggestbox-appearance-customize-buttons-1.png)

## Hiding the Buttons

To control the visibility of the query and clear buttons, set the __QueryButtonVisibility__ and __ClearButtonVisibility__ properties of RadAutoSuggestBox.

__Example 3: Hiding the query button__
```XAML
	<telerik:RadAutoSuggestBox QueryButtonVisibility="Collapsed" />
```

#### Figure 3: Hidden query button
![{{ site.framework_name }} RadAutoSuggestBox Hidden query button](images/radautosuggestbox-appearance-customize-buttons-2.png)

When the __ClearButtonVisibility__ property is set to __Auto__, the button shows only when the control is focused and the TextBox is not empty. This is the default behavior.

## Commands

To customize also the actions executed on query and clear button clicks, set the __QueryButtonCommand__ and __ClearButtonCommand__ properties of RadAutoSuggestBox. Read more in the [Commands]({%slug radautosuggestbox-features-commands%}) article.

## See Also  
 * [Getting Started]({%slug radautosuggestbox-getting-started%})
 * [Events]({%slug radautosuggestbox-events%})   
 * [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})
