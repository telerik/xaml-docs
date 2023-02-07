---
title: Overview
page_title: Overview
description: This article lists some important properties of the RadSlider, which allow for easy modification of its looks.
slug: radslider-styling-overview
tags: overview
published: True
position: 1
---

# Overview

`RadSlider` allows you to easily modify its appearance by providing some useful properties.

>important The pictures in this article demonstrate the RadSlider in the __Fluent__ theme.

## ThumbStyle

The `ThumbStyle` property allows you to control the appearance of the thumb, which is used to control the `Value`.

If you are using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) theming approach, base the custom style on the default __RadTickBarStyle__ using the `BasedOn` property.

#### __[XAML] Creating a custom style for the ThumbStyle property when using implicit styles theming approach__
{{region radslider-styling-overview-0}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="CustomThumbStyle" TargetType="Thumb" BasedOn="{StaticResource ThumbStyle}">
                <Setter Property="Width" Value="25" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           ThumbStyle="{StaticResource CustomThumbStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

If you are using the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming approach, merge the generic resource dictionary for the used theme. This resource dictionary is contained in the __Telerik.Windows.Controls__ assembly. Then, base the custom style on the default __TrackStyle__ using the `BasedOn` property. In the following example, the __GenericFluent.xaml__ dictionary of the __Telerik.Windows.Controls__ assembly is merged, because the __Fluent__ theme is used.

#### __[XAML] Creating a custom style for the ThumbStyle property when using StyleManager theming approach__
{{region radslider-styling-overview-1}}
    <Grid>
        <Grid.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/GenericFluent.xaml"/>
                </ResourceDictionary.MergedDictionaries>
                <Style x:Key="CustomThumbStyle" TargetType="Thumb" BasedOn="{StaticResource ThumbStyle}">
                    <Setter Property="Width" Value="25" />
                </Style>
            </ResourceDictionary>
            
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight"
                           ThumbStyle="{StaticResource CustomThumbStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

>tip If another theme is used, for example, __Office_Black__, change the __GenericFluent.xaml__ to __GenericOfficeBlack.xaml__.

__RadSlider with custom ThumbStyle__

![RadSlider with custom ThumbStyle](images/radslider_styles_templates_thumbstyle.png)

## SelectionMiddleThumbStyle

The `SelectionMiddleThumbStyle` property lets you control the appearance of the middle thumb, which is displayed when the `IsSelectionRangeEnabled` property is __True__.

If you are using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) theming approach, base the custom style on the default __SelectionMiddleThumbStyle__ using the `BasedOn` property.

#### __[XAML] Creating a custom style for the SelectionMiddleThumbStyle property using the implicit styles theming approach__
{{region xaml-radslider-styling-overview-2}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="CustomSelectionMiddleThumbStyle" TargetType="Thumb" BasedOn="{StaticResource SelectionMiddleThumbStyle}">
                <Setter Property="Height" Value="10" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           IsSelectionRangeEnabled="True"
                           Margin="5"
                           SelectionMiddleThumbStyle="{StaticResource CustomSelectionMiddleThumbStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

If you are using the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming approach, merge the generic resource dictionary for the used theme. This resource dictionary is contained in the __Telerik.Windows.Controls__ assembly. Then, base the custom style on the default __SelectionMiddleThumbStyle__ using the `BasedOn` property. In the following example, the __GenericFluent.xaml__ dictionary of the __Telerik.Windows.Controls__ assembly is merged, because the __Fluent__ theme is used.

#### __[XAML] Creating a custom style for the SelectionMiddleThumbStyle property using the StyleManager theming approach__
{{region xaml-radslider-styling-overview-3}}
    <Grid>
        <Grid.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/GenericFluent.xaml"/>
                </ResourceDictionary.MergedDictionaries>
                <Style x:Key="CustomSelectionMiddleThumbStyle" TargetType="Thumb" BasedOn="{StaticResource SelectionMiddleThumbStyle}">
                    <Setter Property="Height" Value="10" />
                </Style>
            </ResourceDictionary>  
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           IsSelectionRangeEnabled="True"
                           VerticalAlignment="Center"
                           TickPlacement="BottomRight"
                           SelectionMiddleThumbStyle="{StaticResource CustomSelectionMiddleThumbStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

>tip If another theme is used, for example, __Office_Black__, change the __GenericFluent.xaml__ to __GenericOfficeBlack.xaml__.

__RadSlider with custom SelectionMiddleThumbStyle__

![RadSlider with custom SelectionMiddleThumbStyle](images/radslider_styles_templates_selectionmiddlethumbstyle.png)

## DecreaseHandleStyle and IncreaseHandleStyle

The `DecreaseHandleStyle` and `IncreaseHandleStyle` properties allow you to modify the appearance of the two repeat buttons, which increase and decrease the `Value`. They are shown when the `HandlesVisibility` is __True__.

If you are using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) theming approach, base the custom styles on the default __DecreaseHandleStyle__ and __IncreaseHandleStyle__ styles using the `BasedOn` property.

#### __[XAML] Creating custom Styles for the DecreaseHandleStyle and IncreaseHandleStyle properties when using the implicit styles theming approach__
{{region xaml-radslider-styling-overview-4}}
    <Grid>
        <Grid.Resources> 
            <Style x:Key="CustomDecreaseHandleStyle" TargetType="RepeatButton" BasedOn="{StaticResource DecreaseHandleStyle}">
                <Setter Property="Foreground" Value="Red" />
            </Style>
            <Style x:Key="CustomIncreaseHandleStyle" TargetType="RepeatButton" BasedOn="{StaticResource IncreaseHandleStyle}">
                <Setter Property="Foreground" Value="Red" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           Margin="5"
                           HandlesVisibility="Visible"
                           DecreaseHandleStyle="{StaticResource CustomDecreaseHandleStyle}"
                           IncreaseHandleStyle="{StaticResource CustomIncreaseHandleStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

If you are using the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming approach, merge the generic resource dictionary for the used theme. This resource dictionary is contained in the __Telerik.Windows.Controls__ assembly. Then, base the custom styles on the default __DecreaseHandleStyle__ and __IncreaseHandleStyle__ styles using the `BasedOn` property. In the following example, the __GenericFluent.xaml__ dictionary of the __Telerik.Windows.Controls__ assembly is merged, because the __Fluent__ theme is used.

#### __[XAML] Creating custom Styles for the DecreaseHandleStyle and IncreaseHandleStyle properties when using the StyleManager theming approach__
{{region xaml-radslider-styling-overview-5}}
    <Grid>
        <Grid.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/GenericFluent.xaml"/>
                </ResourceDictionary.MergedDictionaries>
                <Style x:Key="CustomDecreaseHandleStyle" TargetType="RepeatButton" BasedOn="{StaticResource DecreaseHandleStyle}">
                    <Setter Property="Foreground" Value="Red" />
                </Style>
                <Style x:Key="CustomIncreaseHandleStyle" TargetType="RepeatButton" BasedOn="{StaticResource IncreaseHandleStyle}">
                    <Setter Property="Foreground" Value="Red" />
                </Style>
            </ResourceDictionary>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           Margin="5"
                           HandlesVisibility="Visible"
                           DecreaseHandleStyle="{StaticResource CustomDecreaseHandleStyle}"
                           IncreaseHandleStyle="{StaticResource CustomIncreaseHandleStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

>tip If another theme is used, for example, __Office_Black__, change the __GenericFluent.xaml__ to __GenericOfficeBlack.xaml__.

__RadSlider with custom DecreaseHandleStyle and IncreaseHandleStyle__

![RadSlider with custom DecreaseHandleStyle and IncreaseHandleStyle](images/radslider_styles_templates_decreasethumbstyle_increasethumbstyle.png)

## TickBarStyle

The `TickBarStyle` property allows you to modify the appearance of the bottom and top tickbars - the controls which displays the ticks.

If you are using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) theming approach, base the custom style on the default __RadTickBarStyle__ using the `BasedOn` property as shown in the following example:

#### __[XAML] Creating a custom style for the TickBarStyle property when using the implicit styles theming approach__
{{region xaml-radslider-styling-overview-6}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="TickBarStyle" TargetType="telerik:RadTickBar" BasedOn="{StaticResource RadTickBarStyle}">
                <Setter Property="Foreground" Value="Red" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           Margin="10"
                           TickBarStyle="{StaticResource TickBarStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

If you are using the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming approach, set the `ItemsPanel` property of the `RadTickBar` element to a new instance of the `TickBarPanel` object.

#### __[XAML] Creating a custom style for the TickBarStyle property when using the StyleManager theming approach__
{{region xaml-radslider-styling-overview-7}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="CustomTickBarStyle" TargetType="telerik:RadTickBar">
                <Setter Property="Foreground" Value="Red" />
                <Setter Property="ItemsPanel">
                    <Setter.Value>
                        <ItemsPanelTemplate>
                            <telerik:TickBarPanel Background="Transparent"/>
                        </ItemsPanelTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           Margin="10"
                           TickBarStyle="{StaticResource CustomTickBarStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

__RadSlider with custom TickBarStyle__

![RadSlider with custom TickBarStyle](images/radslider_styles_templates_tickbarstyle.png)

## TrackStyle

The `TrackStyle` property lets you modify the appearance of the RadSlider's track. 

When using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) theming approach and __NoXaml__ binaries, base the custom style on the default __TrackStyle__. This style comes from the chosen theme using the `BasedOn` property.

#### __[XAML] Creating a custom style for the TrackStyle property when using the implicit styles theming approach__
{{region xaml-radslider-styling-overview-8}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="CustomTrackStyle" TargetType="ContentControl" BasedOn="{StaticResource TrackStyle}">
                <Setter Property="Height" Value="25" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           Margin="10"
                           TrackStyle="{StaticResource CustomTrackStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

When using the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) and __Xaml__ binaries, merge the resource dictionary for the used theme. This resource dictionary is contained in the __Telerik.Windows.Controls__ assembly. Then, base the custom style on the default __TrackStyle__ using the `BasedOn` property. In the following example, the __GenericFluent.xaml__ dictionary of the __Telerik.Windows.Controls__ assembly is merged, because the __Fluent__ theme is used.

#### __[XAML] Creating a custom style for the TrackStyle property when using the StyleManager theming approach__
{{region xaml-radslider-styling-overview-9}}
    <Grid>
        <Grid.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    <ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/GenericFluent.xaml"/>
                </ResourceDictionary.MergedDictionaries>
                <Style x:Key="CustomTrackStyle" TargetType="ContentControl" BasedOn="{StaticResource TrackStyle}">
                    <Setter Property="Height" Value="25" />
                </Style>
            </ResourceDictionary>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0"  
                       Maximum="100"  
                       TickFrequency="10" 
                       TickPlacement="BottomRight"  
                       Margin="10" 
                       TrackStyle="{StaticResource CustomTrackStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

>tip If another theme is used, for example, __Office_Black__, change the __GenericFluent.xaml__ to __GenericOfficeBlack.xaml__.

__RadSlider with custom TrackStyle__

![RadSlider with custom TrackStyle](images/radslider_styles_templates_trackstyle.png)

>tip In order to learn how to further modify any of the elements referenced in the article by extracting their control template, read the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.
