---
title: Available Themes
page_title: Available Themes
description: Check out all available themes inside Telerik UI for {{ site.framework_name }} suite.
slug: common-styling-appearance-available-themes
tags: themes, available
published: True
position: 1
---
# {{ site.framework_name }} Themes Suite

The __UI for {{ site.framework_name }}__ suite comes with a variety of predefined themes which you can apply to your application. Some of the themes have ThemePalette, allowing for different color variations to expand this variety even more. Below you can find a list of the available themes, a glimpse of their appearance, the support of a ThemePalette, and the built-in color variations (if such are present).

>You can check the appearance of a specific control in a certain theme by viewing its "Theming" demo in our {% if site.site_name == 'WPF' %}[WPF Controls Examples application](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples application](https://demos.telerik.com/silverlight/){% endif %}.

The table is ordered chronologically, where the first theme in the list is the latest released.

<style>
table th:first-of-type {
    width: 20%;
}
table th:nth-of-type(2) {
    width: 50%;
}
table th:nth-of-type(3) {
    width: 10%;
}
table th:nth-of-type(4) {
    width: 20%;
}
</style>

Theme name | Appearance | Theme Palette | Variations 
---|---|---|---{% if site.site_name == 'WPF' %}
**[Windows 11]({%slug common-styling-appearance-windows11-theme%})** | ![Windows 11](images/Windows11Theme.png) | Yes | System, Light, Dark
**[Office 2019]({%slug common-styling-appearance-Office2019-theme%})** | ![Office 2019](images/Office2019Theme.png) | Yes | Light, Gray, Dark
**[Visual Studio 2019]({%slug common-styling-appearance-visualstudio2019-theme%})** | ![Visual Studio 2019](images/VisualStudio2019Theme.png) | Yes | Blue, Dark
**[Crystal]({%slug common-styling-appearance-crystal-theme%})** | ![Crystal](images/CrystalTheme.png) | Yes | Light, Dark
**[Fluent]({%slug common-styling-appearance-fluent-theme%})** | ![Fluent](images/FluentTheme.png) | Yes | Light, Dark
**[Material]({%slug common-styling-appearance-material-theme%})** | ![Material](images/MaterialTheme.png) | Yes | Light, Dark
**[Office 2016 Touch]({%slug common-styling-appearance-office2016touch-theme%})** | ![Office 2016 Touch](images/Office2016TouchTheme.png) | Yes | -
**[Office 2016]({%slug common-styling-appearance-office2016-theme%})** | ![Office 2016](images/Office2016Theme.png) | Yes | -
**[Green]({%slug common-styling-appearance-green-theme%})** | ![Green](images/GreenTheme.png)| Yes | Light, Dark{% endif %}
**[Visual Studio 2013]({%slug common-styling-appearance-visualstudio2013-theme%})** | ![Visual Studio 2013](images/VisualStudio2013Theme.png) | Yes | Light, Blue, Dark
**[Office 2013]({%slug common-styling-appearance-office2013-theme%})** | ![Office 2013](images/Office2013Theme.png) | Yes | White, LightGray, DarkGray
**[Windows 8 Touch]({%slug common-styles-appearance-colorizing-metro-theme%})** | ![Windows 8 Touch](images/Windows8TouchTheme.png) | Yes | -
**[Windows 8]({%slug common-styles-appearance-colorizing-metro-theme%})** | ![Windows 8](images/Windows8Theme.png) | Yes | -
**Expression Dark** | ![Expression Dark](images/ExpressionDarkTheme.png) | No | -
**Windows 7** | ![Windows 7](images/Windows7Theme.png) | No | -
**Transparent** | ![Transparent](images/TransparentTheme.png) | No | -
**Vista** | ![Vista](images/VistaTheme.png) | No | -
**Summer** | ![Summer](images/SummerTheme.png) | No | -
**Office Silver** | ![Office Silver](images/OfficeSilver.png) | No | -
**Office Blue** | ![Office Blue](images/OfficeBlue.png) | No | -
**Office Black** | ![Office Black](images/OfficeBlack.png) | No | -

*The names of the color variations from this list correspond to the different presets that can be loaded - e.g. VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Dark); will load the dark variation of the Visual Studio 2013 theme. All themes which support ThemePalettes are present in the [Color Theme Generator]({%slug common-styling-color-theme-generator%}), which allows for creating custom color variations even for themes that do not have ColorVariations.*

## See Also  
* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [Color Theme Generator]({%slug common-styling-color-theme-generator%})
