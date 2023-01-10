---
title: Overview
page_title: Overview
description: This article lists some important properties of the RadSlider, which allow for easy modification of its looks.
slug: radslider-styling-overview
tags: overview
published: True
position: 1
---

# {{ site.framework_name }} RadSlider Overview

__RadSlider__ allows you to easily modify its appearance by providing some useful properties.

> The pictures in this article demonstrate the RadSlider in the __Office2016__ theme.

## ThumbStyle

Via the ThumbStyle property you can control the appearance of the thumb which is used to control the **Value**.

#### [XAML] Example 1: Specify ThumbStyle

{{region xaml-radslider-styling-overview_0}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="ThumbStyle" TargetType="Thumb" BasedOn="{StaticResource ThumbStyle}">
                <Setter Property="Width" Value="25" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           ThumbStyle="{StaticResource ThumbStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

#### __Figure 1: RadSlider with custom ThumbStyle__
![RadSlider with custom ThumbStyle](images/radslider_styles_templates_thumbstyle.png)

## SelectionMiddleThumbStyle

Via the SelectionMiddleThumbStyle property you can control the appearance of the middle thumb which is displayed when the __IsSelectionRangeEnabled__ property is True.

#### [XAML] Example 2: Specify SelectionMiddleThumbStyle

{{region xaml-radslider-styling-overview_1}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="SelectionMiddleThumbStyle" TargetType="Thumb" BasedOn="{StaticResource SelectionMiddleThumbStyle}">
                <Setter Property="Height" Value="10" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           IsSelectionRangeEnabled="True"
                           Margin="5"
                           SelectionMiddleThumbStyle="{StaticResource SelectionMiddleThumbStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

#### __Figure 2: RadSlider with custom SelectionMiddleThumbStyle__
![RadSlider with custom SelectionMiddleThumbStyle](images/radslider_styles_templates_selectionmiddlethumbstyle.png)

## DecreaseHandleStyle and IncreaseHandleStyle

The DecreaseHandleStyle and IncreaseHandleStyle properties allow you to modify the appearance of the two repeat buttons which increase and decrease the Value. They are shown when the __HandlesVisibility__ is True.

#### [XAML] Example 3: Set DecreaseHandleStyle and IncreaseHandleStyle
{{region xaml-radslider-styling-overview_2}}
    <Grid>
        <Grid.Resources>
            <Style x:Key="DecreaseHandleStyle" TargetType="RepeatButton" BasedOn="{StaticResource DecreaseHandleStyle}">
                <Setter Property="Foreground" Value="Red" />
            </Style>
            <Style x:Key="IncreaseHandleStyle" TargetType="RepeatButton" BasedOn="{StaticResource IncreaseHandleStyle}">
                <Setter Property="Foreground" Value="Red" />
            </Style>
        </Grid.Resources>
        <telerik:RadSlider Minimum="0" 
                           Maximum="100" 
                           TickFrequency="10"
                           TickPlacement="BottomRight" 
                           Margin="5"
                           HandlesVisibility="Visible"
                           DecreaseHandleStyle="{StaticResource DecreaseHandleStyle}"
                           IncreaseHandleStyle="{StaticResource IncreaseHandleStyle}">
            <telerik:RadSlider.TickTemplate>
                <DataTemplate>
                    <TextBlock Text="{Binding}" />
                </DataTemplate>
            </telerik:RadSlider.TickTemplate>
        </telerik:RadSlider>
    </Grid>
{{endregion}}

#### __Figure 3: RadSlider with custom DecreaseHandleStyle and IncreaseHandleStyle__
![RadSlider with custom DecreaseHandleStyle and IncreaseHandleStyle](images/radslider_styles_templates_decreasethumbstyle_increasethumbstyle.png)

## TickBarStyle

The TickBarStyle property allows you to modify the appearance of the bottom and top tickbars - the controls which displays the ticks.

#### [XAML] Example 4: Set TickBarStyle

{{region xaml-radslider-styling-overview_3}}
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

#### __Figure 4: RadSlider with custom TickBarStyle__
![RadSlider with custom TickBarStyle](images/radslider_styles_templates_tickbarstyle.png)

## TrackStyle

The TrackStyle property lets you modify the appearance of the RadSlider track.

#### [XAML] Example 5: Set TrackStyle

{{region xaml-radslider-styling-overview_4}}
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

#### __Figure 5: RadSlider with custom TrackStyle__
![RadSlider with custom TrackStyle](images/radslider_styles_templates_trackstyle.png)

>tip The styles in the examples are based on the default styles for the theme. This is the correct approach when the [implicit styling]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) approach is used. If the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager) theming mechanism is chosen there is no need to base the custom styles on the default one. 

>tip In order to learn how to further modify any of the elements referenced in the article by extracting their control template, read the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.
