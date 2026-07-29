---
title: Setting a Theme
page_title: Setting a Theme
description: Check our &quot;Setting a Theme&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-styles-and-templates-setting-theme
tags: setting,a,theme
published: True
position: 0
---

# Setting a Theme

The purpose of this article is to show you how to set a built-in theme to __RadDesktopAlert__.

>__RadDesktopAlert__ supports styling using __Implicit Styles__. Detailed information about the use of __Implicit Styles__ you could find [here]({%slug styling-apperance-implicit-styles-overview%}).

The following Xaml files should be merger in App.xaml file in order a theme to be correctly applied to the DesktopAlert:

* Telerik.Windows.Controls.xaml

* Telerik.Windows.Controls.Navigation.xaml

You could do that using one of the following approaches:

* Directly from the theme assembly: 

	For example let's apply VisualStudio2013 theme to __RadDesktopAlert__ - a reference to Telerik.Windows.Themes.VisualStudio2013.dll should be added as well:
	
	__Figure 1:__ Adding the needed references	
	![Rad Desktop Alert Setting Theme 01](images/RadDesktopAlert_Setting_Theme_01.png)
	
	After that merge the xaml files in the App.xaml as shown in __Example 1__:
	
	__Example 1: Merging the .xaml files__

	<snippet id='raddesktopalert-styles-and-templates-setting-theme-example_1_merging_the_xaml_files-xaml' />

	
* Add references to the required assemblies from Binaries.NoXaml folder. Create a Themes folder in your project that contains the corresponding .xaml files from Themes.Implicit/../VisualStudio2013/../Themes/ folder located in the installation folder:

	__Figure 2:__ Copying the .xaml files
	![Rad Desktop Alert Setting Theme 01](images/RadDesktopAlert_Setting_Theme_02.png)
	
	__Example 2__ shows how to merge the copied .xaml files.            

	__Example 2: Merging the .xaml files__

	<snippet id='raddesktopalert-styles-and-templates-setting-theme-example_2_merging_the_xaml_files-xaml' />

	
Either way you choose, the end result will be the following:

__Figure 3:__ DesktopAlert with VisualStudio2013 theme applied
![Rad Desktop Alert Setting Theme 03](images/RadDesktopAlert_Setting_Theme_03.png)

## See Also

 * [Getting Started]({%slug raddesktopalert-getting-started%})

 * [Visual Structure]({%slug raddesktopalert-visual-structure%})