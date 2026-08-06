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

>You can check the appearance of a specific control in a certain theme by viewing its "Theming" demo in our {% if site.site_name == 'WPF' %}[Telerik UI for WPF demos](https://demos.telerik.com/wpf/){% else %}[Telerik UI for Silverlight demos](https://demos.telerik.com/silverlight/){% endif %}.

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
**[Windows 11]({%slug common-styling-appearance-windows11-theme%})** | ![Telerik UI for WPF Windows 11 theme preview](images/Windows11Theme.png) | Yes | System, Light, Dark
**[Office 2019]({%slug common-styling-appearance-Office2019-theme%})** | ![Telerik UI for WPF Office 2019 theme preview](images/Office2019Theme.png) | Yes | Light, Gray, Dark
**[Visual Studio 2019]({%slug common-styling-appearance-visualstudio2019-theme%})** | ![Telerik UI for WPF Visual Studio 2019 theme preview](images/VisualStudio2019Theme.png) | Yes | Blue, Dark
**[Crystal]({%slug common-styling-appearance-crystal-theme%})** | ![Telerik UI for WPF Crystal theme preview](images/CrystalTheme.png) | Yes | Light, Dark
**[Fluent]({%slug common-styling-appearance-fluent-theme%})** | ![Telerik UI for WPF Fluent theme preview](images/FluentTheme.png) | Yes | Light, Dark
**[Material]({%slug common-styling-appearance-material-theme%})** | ![Telerik UI for WPF Material theme preview](images/MaterialTheme.png) | Yes | Light, Dark
**[Office 2016 Touch]({%slug common-styling-appearance-office2016touch-theme%})** | ![Telerik UI for WPF Office 2016 Touch theme preview](images/Office2016TouchTheme.png) | Yes | -
**[Office 2016]({%slug common-styling-appearance-office2016-theme%})** | ![Telerik UI for WPF Office 2016 theme preview](images/Office2016Theme.png) | Yes | -
**[Green]({%slug common-styling-appearance-green-theme%})** | ![Telerik UI for WPF Green theme preview](images/GreenTheme.png)| Yes | Light, Dark{% endif %}
**[Visual Studio 2013]({%slug common-styling-appearance-visualstudio2013-theme%})** | ![Telerik UI for WPF Visual Studio 2013 theme preview](images/VisualStudio2013Theme.png) | Yes | Light, Blue, Dark
**[Office 2013]({%slug common-styling-appearance-office2013-theme%})** | ![Telerik UI for WPF Office 2013 theme preview](images/Office2013Theme.png) | Yes | White, LightGray, DarkGray
**[Windows 8 Touch]({%slug common-styles-appearance-colorizing-metro-theme%})** | ![Telerik UI for WPF Windows 8 Touch theme preview](images/Windows8TouchTheme.png) | Yes | -
**[Windows 8]({%slug common-styles-appearance-colorizing-metro-theme%})** | ![Telerik UI for WPF Windows 8 theme preview](images/Windows8Theme.png) | Yes | -
**Expression Dark** | ![Telerik UI for WPF Expression Dark theme preview](images/ExpressionDarkTheme.png) | No | -
**Windows 7** | ![Telerik UI for WPF Windows 7 theme preview](images/Windows7Theme.png) | No | -
**Transparent** | ![Telerik UI for WPF Transparent theme preview](images/TransparentTheme.png) | No | -
**Vista** | ![Telerik UI for WPF Vista theme preview](images/VistaTheme.png) | No | -
**Summer** | ![Telerik UI for WPF Summer theme preview](images/SummerTheme.png) | No | -
**Office Silver** | ![Telerik UI for WPF Office Silver theme preview](images/OfficeSilver.png) | No | -
**Office Blue** | ![Telerik UI for WPF Office Blue theme preview](images/OfficeBlue.png) | No | -
**Office Black** | ![Telerik UI for WPF Office Black theme preview](images/OfficeBlack.png) | No | -

*The names of the color variations from this list correspond to the different presets that can be loaded - e.g. VisualStudio2013Palette.LoadPreset(VisualStudio2013Palette.ColorVariation.Dark); will load the dark variation of the Visual Studio 2013 theme. All themes which support ThemePalettes are present in the [Color Theme Generator for custom theme variations]({%slug common-styling-color-theme-generator%}), which allows for creating custom color variations even for themes that do not have ColorVariations.*

## See Also  
* [Apply a Theme with Implicit Styles]({%slug styling-apperance-implicit-styles-overview%})
* [Generate Custom Theme Variations]({%slug common-styling-color-theme-generator%})
