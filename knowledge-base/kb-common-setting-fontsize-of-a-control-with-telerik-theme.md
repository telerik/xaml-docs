---
title: Setting the FontSize in C# when a Telerik theme is applied
description: Change the default FontSize in code-behind when a Telerik theme is applied.
type: how-to
page_title: Set a different FontSize which has a Telerik theme applied
slug: kb-common-setting-fontsize-in-code-behind-for-a-telerik-theme
position: 0
tags: fontsize, fontfamily, theme, theming, palettes
ticketid: 1470081
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.513</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>


## Description
How to set a different font size in C# for themes which support palettes.

## Solution
When using any of the [Telerik themes]({%slug common-styling-appearance-available-themes%}) which support palettes (the ones with the links from the list), you can dynamically change the FontSize and FontFamily properties of all components in the application.

Most controls use the theme Palette's FontSize property, yet all themes support a different number of various font sizes. For example, if the Office2016Theme is applied to your application, you can change the following font size properties of its palette:

__Example 1: Modifying the FontSize and FontFamily in the Office2016 theme__
```C#
	Office2016Palette.Palette.FontSizeS = 10; 
	Office2016Palette.Palette.FontSize = 12; 
	Office2016Palette.Palette.FontSizeL = 14;
	Office2016Palette.Palette.FontFamily = new FontFamily("Segoe UI"); 
```

The values assigned to the Palette's font size properties are the default ones. You can change them on a click of a button as well at run-time. The following Example 2 how to change the default FontFamily from "Segoe UI" to "Calibri" and the FontSize from 12 to 14.


__Example 2: Changing the default FontSize and FontFamily in the Office2016 theme on a button click__
```C#
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e) 
	{ 
		Office2016Palette.Palette.FontSize = 14; 
		Office2016Palette.Palette.FontFamily = new FontFamily("Calibri"); 
	} 
```

#### __Figure 1: Setting different FontSize and FontFamily__
![{{ site.framework_name }} Setting different FontSize and FontFamily](../styling-and-appearance/images/common-styling-appearance-office2016-theme-1.png)	

The approach used in the above code snippets is applicable for the following themes - [Windows8]({%slug common-styles-appearance-colorizing-metro-theme%}#changing-fonts), [Windows8Touch]({%slug common-styles-appearance-colorizing-metro-theme%}#changing-fonts), [Office2013]({%slug common-styling-appearance-office2013-theme%}#changing-fonts), [VisualStudio2013]({%slug common-styling-appearance-visualstudio2013-theme%}#changing-fonts), [Office2016]({%slug common-styling-appearance-office2016-theme%}#changing-fonts), [Office2016Touch]({%slug common-styling-appearance-office2016touch-theme%}#changing-fonts), [Green]({%slug common-styling-appearance-green-theme%}#changing-fonts), [Fluent]({%slug common-styling-appearance-fluent-theme%}#changing-fonts), [Material]({%slug common-styling-appearance-material-theme%}#changing-fonts), [Crystal]({%slug common-styling-appearance-crystal-theme%}#changing-fonts) and [VisualStudio2019]({%slug common-styling-appearance-visualstudio2019-theme%}#changing-fonts).

>If you are using a different theme, which does not have a palette, you can change the font size of the application through Application.Current.MainWindow.FontSize or apply it directly for the control you wish, e.g. this.dataGrid.FontSize = 20.

## See Also  
* [Available Themes]({%slug common-styling-appearance-available-themes%})
* [Theme Helper]({%slug styling-appearance-theme-helper%})
* [Switching Themes at Runtime]({%slug styling-apperance-themes-runtime%})
