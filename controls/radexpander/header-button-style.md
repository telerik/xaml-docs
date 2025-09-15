---
title: Customizing Header Button
page_title: Header Button Style
description: This article will show you how to customize the header button style of the RadExpander control.
slug: radexpander-features-header-button-style
tags: button style, header button, expander, expander button
published: True
position: 2
---

# HeaderButtonStyle

The `RadExpander` control allows you to customize the style of its header, which is represented by a `RadToggleButton` element. 

To change the header button style, assign a new `Style` with `TargetType="RadToggleButton"` to the `HeaderButtonStyle` property of `RadExpander`. This action will override the default style of the `RadToggleButton` element. You can base the custom style on the __ExpanderHeaderButtonStyle__ style, to keep the default look of the `RadToggleButton` while applying the needed customizations. To do so, set the `BasedOn` property. Different logic would have to be introduced depending on the used theming approach.

If the [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) theming approach is used, you can directly base the custom Style on the `ExpanderHeaderButtonStyle` style via the `BasedOn` property.

__Approach when applying a theme via Implicit Styles__
```XAML
    <telerik:RadExpander Header="My Expander">
        <telerik:RadExpander.HeaderButtonStyle>
            <Style TargetType="telerik:RadToggleButton" BasedOn="{StaticResource ExpanderHeaderButtonStyle}">
                <Setter Property="Foreground" Value="Red"/>
                <Setter Property="FontWeight" Value="SemiBold"/>
                <Setter Property="Margin" Value="5 5 0 0"/>
            </Style>
        </telerik:RadExpander.HeaderButtonStyle>
    </telerik:RadExpander>
```

If the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming approach is used, merge the resource dictionary for the used theme, which is contained in the __Telerik.Windows.Controls__ assembly. In the following example, the __GenericFluent.xaml__ dictionary is merged, because the __Fluent__ theme is used. 

>tip If another theme is used, for example, __Office_Black__, change the __GenericFluent.xaml__ to __GenericOfficeBlack.xaml__.

__Approach when applying a theme via StyleManager__
```XAML
    <telerik:RadExpander Header="My Expander">
        <telerik:RadExpander.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/GenericFluent.xaml"/>
                </ResourceDictionary.MergedDictionaries>
            </ResourceDictionary>
        </telerik:RadExpander.Resources>
        <telerik:RadExpander.HeaderButtonStyle>
            <Style TargetType="telerik:RadToggleButton" BasedOn="{StaticResource ExpanderHeaderButtonStyle}">
                <Setter Property="Foreground" Value="Red"/>
                <Setter Property="FontWeight" Value="SemiBold"/>
                <Setter Property="Margin" Value="5 5 0 0"/>
            </Style>
        </telerik:RadExpander.HeaderButtonStyle>
    </telerik:RadExpander>
```

Both of these approaches produce the following result:

![RadExpander with custom Style based on its default one](images/radexpander-header-button-style-0.png)
