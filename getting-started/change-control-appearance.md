---
title: Change Control Appearance
page_title: Change Control Appearance
description: This article explains how to customize the appearance of the controls from the Telerik UI for {{ site.framework_name }} suite.
slug: getting-started-change-control-appearance
tags: Change Control Appearance
published: True
position: 4
---

# Change Control Appearance

The UI for WPF controls use [Themes]({%slug styling-apperance-implicit-styles-overview%}) to change their appearance. The suite provides over 25 built-in themes that can fit in the majority of desktop application designs. A list of all the available themes can be found [here]({%slug common-styling-appearance-available-themes%}).

There are two mechanisms that can be used to set a theme:

* [Using Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles)
	In this case use NoXaml dlls.
	
* [Using StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager)
	In this case use Xaml dlls.

It is important to not mix the two approaches and always use the **correct assemblies** for the respective mechanism.

## Custom Appearance

If you wish to simply change a few of the colors or font sizes of your controls, you can [define a new style]({%slug implicit-styles-styling-the-controls%}) for them and override the desired properties. 

__Custom styles for RadListBox__

```XAML
    <Style TargetType="telerik:RadListBox">
        <Setter Property="Foreground" Value="Green" />
        <Setter Property="FontSize" Value="22" />
    </Style>
```

If you wish to apply further customizations such as repositioning the building parts of a control, however, you will most probably need to [edit its control template]({%slug styling-apperance-editing-control-templates%}).

## Color Theme Generator

All Telerik themes starting from [Windows8` and later]({%slug common-styling-appearance-available-themes%}) (like __Windows11__, **Crystal**, **Fluent**, **Material**, **Office2016**, etc.) are fully customizable using the assocaited [theme palettes]({%slug styling-appearance-theme-helper%}) properties.

For seamless color customization and faster palette creation that looks great and matches all controls, we created the [Color Theme Generator]({%slug common-styling-color-theme-generator%}).

## Next Steps 
* [More Learning Resources]({%slug getting-started-next-steps%})
* [Start from the First Steps]({%slug getting-started-first-steps%})

## See Also

* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})
* [Styling the Controls]({%slug implicit-styles-styling-the-controls%})
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
* [Available Themes]({%slug common-styling-appearance-available-themes%})
* [Color Theme Generator]({%slug common-styling-color-theme-generator%})