---
title: How to center labels in RadPivotMap
description: Align RadTreeMapItem labels towards the center.
type: how-to
page_title: Position the labels of RadTreeMapItems without children in the center 
slug: kb-pivotmap-howto-center-labels
position: 0
tags: label, radtreemapitem, position, center
ticketid: 1444422
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadPivotMap for WPF</td>
	</tr>
</table>

## Description

How to center the labels for RadTreeMapItems without children. 

## Solution

[Extract and edit]({%slug styling-apperance-editing-control-templates%}) the RadTreeMapItem ControlTemplate and update the position of the element with x:Name="ContentPresenter" when the RadTreeMapItem does not have any children. __Example 1__ demonstrates this approach by adding a DataTrigger inside the ControlTemplate. 

__Example 1: Modifying the RadTreeMapItem ControlTemplate in the Office_Black theme__
```XAML
	<!-- If you are using the NoXaml dlls, you should add the BasedOn attribute: BasedOn="{StaticResource RadTreeMapItemStyle}"-->
    <Style TargetType="telerik:RadTreeMapItem" >
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="telerik:RadTreeMapItem">
                    <Grid>
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="CommonStates">
                                <VisualState x:Name="Normal"/>
                                <VisualState x:Name="MouseOver">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="MouseOverVisual" Storyboard.TargetProperty="BorderBrush" Duration="0.00:00:00.05">
                                            <DiscreteObjectKeyFrame KeyTime="0.00:00:00.0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <LinearGradientBrush StartPoint="0,0" EndPoint="3,3" MappingMode="Absolute" SpreadMethod="Repeat">
                                                        <GradientStop Color="#B2000000" Offset="0"/>
                                                        <GradientStop Color="#B2000000" Offset="0.5"/>
                                                        <GradientStop Color="#D8FFFFFF" Offset="0.5"/>
                                                        <GradientStop Color="#D8FFFFFF" Offset="1"/>
                                                    </LinearGradientBrush>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Pressed">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="SelectedVisual" Storyboard.TargetProperty="Background" Duration="0.00:00:00.05">
                                            <DiscreteObjectKeyFrame KeyTime="0.00:00:00.0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <LinearGradientBrush StartPoint="0,0" EndPoint="3,3" MappingMode="Absolute" SpreadMethod="Repeat">
                                                        <GradientStop Color="#66000000" Offset="0"/>
                                                        <GradientStop Color="#66000000" Offset="0.15"/>
                                                        <GradientStop Color="#26FFFFFF" Offset="0.15"/>
                                                        <GradientStop Color="#26FFFFFF" Offset="1"/>
                                                    </LinearGradientBrush>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Border
                    Name="border"
                    Background="{TemplateBinding Background}"
                    BorderBrush="{TemplateBinding BorderBrush}"
                    BorderThickness="{TemplateBinding BorderThickness}"
                    SnapsToDevicePixels="True">
                            <Border x:Name="SelectedVisual">
                                <Grid Margin="{TemplateBinding Padding}">
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="Auto"/>
                                        <RowDefinition Height="*"/>
                                    </Grid.RowDefinitions>
                                    <ContentPresenter x:Name="ContentPresenter"
                                Grid.Row="0"
                                Content="{TemplateBinding Header}"
                                ContentTemplate="{TemplateBinding HeaderTemplate}"
                                ContentTemplateSelector="{TemplateBinding HeaderTemplateSelector}"
                                HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/>
                                    <ItemsPresenter Grid.Row="1" />
                                </Grid>
                            </Border>
                        </Border>
                        <Border x:Name="MouseOverVisual" BorderThickness="1" SnapsToDevicePixels="True"/>
                    </Grid>
                    <!-- This trigger changes the position of the ContentPresenter when the item does not have any children-->
                    <ControlTemplate.Triggers>
                        <DataTrigger Binding="{Binding Items.Count, RelativeSource={RelativeSource Self}}" Value="0">
                            <Setter Property="Grid.Row" TargetName="ContentPresenter" Value="1" />
                        </DataTrigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
``` 

>If you are using a different theme, make sure to exract and edit the ControlTemplate for the corresponding theme. 

## See Also

* [Getting Start with RadPivotMap]({%slug radtreemap-getting-started-pivotmap%})