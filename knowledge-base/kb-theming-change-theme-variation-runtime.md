---
title: How to Change Theme Variation During Runtime
description: This article explains how to change a theme's variation while the application is running.
type: how-to
page_title: Switch Theme's Variation while Application Is Running
slug: kb-theming-change-theme-variation-runtime
position: 0
tags: theming, change, theme, variation, runtime
ticketid: 1459581
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.1020</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Progress® Telerik® UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to change a theme's variation during runtime.

## Solution

To change a theme's variation during runtime and reflect this change in the UI, you need to call the **LoadPreset** method and reload the required resource dictionaries.



```C#
	private void ThemeVariationsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedItem = (RadComboBoxItem)e.AddedItems[0];
		var colorVariationName = selectedItem.Content.ToString(); // Light or Dark
		var colorVariation = (FluentPalette.ColorVariation)Enum.Parse(typeof(FluentPalette.ColorVariation), colorVariationName);
		FluentPalette.LoadPreset(colorVariation);
		OnResetTheme();
	}

	private static void OnResetTheme()
	{
		Application.Current.Resources.MergedDictionaries.Clear();
		Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
		{
			Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
		});
		Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
		{
			Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
		});
		Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
		{
			Source = new Uri("/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
		});

		// add any other required dictionaries
	}
```

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})