---
title: Office2013 Theme
page_title: Office2013 Theme
description: Office2013 Theme
slug: common-styling-appearance-office2013-theme
tags: office2013,theme
published: True
position: 5
---

# Office2013 Theme



The official Q3 2013 release of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} brought a brand new __external__ theme with a flat modern UI and three color variations – White, Light Gray, Dark Gray.
      

>important Тhe Office2013 theme can only be applied using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}). For this purpose you need to add NoXaml binaries to your application.
        

The following topic explains the specifics of the theme's color variations.
      

## Theme Variations

The following are the supported color variations of the Office2013 theme

* __White__: White color theme palette. This is also the default variation of the theme.
![Common Styling Appearance Office 2013 Theme 01](images/Common_Styling_Appearance_Office2013_Theme_01.png)

* __LightGray__: Light gray theme palette.
![Common Styling Appearance Office 2013 Theme 02](images/Common_Styling_Appearance_Office2013_Theme_02.png)

* __DarkGray__: Dark gray theme palette.
![Common Styling Appearance Office 2013 Theme 03](images/Common_Styling_Appearance_Office2013_Theme_03.png)

This is how the __ColorVariation__ looks:
        

#### __C#__

{{region common-styling-appearance-office2013-theme_0}}
	    /// <summary>
	    /// Represents theme color variations.
	    /// </summary>
	    public enum ColorVariation
	    {
	        /// <summary>
	        /// Represents Dark Grey Office2013 theme palette.
	        /// </summary>
	        DarkGrey,
	
	        /// <summary>
	        /// Represents Light Grey Office2013 theme palette.
	        /// </summary>
	        LightGrey,
	
	        /// <summary>
	        /// Represents the default White Office2013 theme palette.
	        /// </summary>
	        White
	    }
	{{endregion}}



## Theme Variation Changing

When using NoXAML assemblies in an application you should merge the necessary resource dictionaries from the corresponding theme assembly (in this case - __Telerik.Windows.Themes.Office2013.dll__). Alternitevely, you can merge the resource dictionaries as *.xaml files in your application (in case there is no reference to the theme assembly) in an appropriate place in your project (i.e. App.xaml). For more information about implicit styles refer to [this article]({%slug styling-apperance-implicit-styles-overview%}).
        

The __Office2013__ theme offers a very intuitive and easy way to change its color variation. You can change the variation by using the __LoadPreset()__ method of __Office2013Palette__ in the entry point of your application. You just have to pass to the method the desired color variation as a parameter.
        

For example, if you want to set the __DarkGray__ color variation, you should have the following code-block in your application:
{% if site.site_name == 'WPF' %}

#### __C#__

{{region common-styling-appearance-office2013-theme_1}}
    public MainWindow()
    {
        Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);

        InitializeComponent();
    }
	{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region common-styling-appearance-office2013-theme_2}}
    public UserControl()
    {
        Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);

        InitializeComponent();
    }
	{{endregion}}

{% endif %}

## Office2013 Palette brushes and colors
|Brush name|White|Light Gray|Dark Gray|
|----------|-----|----------|---------|
|AccentMain|FF0072C6|FF0072C6|FF0072C6|
|Accent|FF0072C6|FF0072C6|FF444444|
|Main|FFFFFFFF|FFFFFFFF|FFFFFFFF|
|Inverted|FF000000|FF000000|FF000000|
|Basic|FFFDFDFD|FFFDFDFD|FFFDFDFD|
|Strong|FF767676|FF767676|FF767676|
|Validation|FFFF0000|FFFF0000|FFFF0000|
|LowLightMain|FFF1F1F1|FFF1F1F1|FFF1F1F1|
|LowLight|FFFFFFFF|FFF1F1F1|FFE5E5E5|
|LowDark|FFFFFFFF|FFFAFAFA|FFF3F3F3|
|MediumLight|FFE1E1E1|FFE1E1E1|FFE1E1E1|
|MediumDark|FFC6C6C6|FFC6C6C6|FFC6C6C6|
|HighLight|FFD4D4D4|FFC6C6C6|FFABABAB|
|HighDark|FFABABAB|FFABABAB|FFABABAB|
|EffectLow|33FFFFFF|33FFFFFF|FF0072C6|
|EffectHigh|33000000|33000000|800072C6|
|EffectAccentLow|330072C6|330072C6|330072C6|
|EffectAccentHigh|800072C6|800072C6|800072C6|

# See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})