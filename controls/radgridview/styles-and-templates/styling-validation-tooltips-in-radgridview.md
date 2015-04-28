---
title: Styling Validation Tooltips
page_title: Styling Validation Tooltips
description: Styling Validation Tooltips
slug: styling-validation-tooltip-in-gridview
tags: styling,validation,tooltips,in,gridview
published: True
position: 22
---

## Styling Validation ToolTips in RadGridView ##

> Before reading this topic, you might find useful to get familiar with RadGridView’s [validation]({%slug gridview-managing-data-validation%}) functionality.

__RadGridView__ has two validation layers: UI and data. Interface such as __IDataErrorInfo__ is used by data layer validation and __RadGridView's__ role here is just to update underlying value via binding at the right moment. 

{% if site.site_name == 'WPF' %}
Error validation template comes from __WPF__ framework. 
{% endif %}

{% if site.site_name == 'Silverlight' %}
Especially for __Silverlight__ a special __ValidationToolTip__ element was developed for common input controls and native MS controls that are supported by __Telerik__ themes. 
{% endif %}

![](images/Validation-Tooltip.png)

__RadGridView__ supports different validation modes and the validation tooltip depends on different factors. Visually all tooltips are the same, but they appear on different elements. In edit mode validation tooltip depends on the editor and __GridViewEditorPresenter__ element. __GridViewEditorPresenter__ is a generic container for all type of editors. In view mode validation tooltip depends on the cell and on the row.

> You can check this [article]({%slug gridview-styling-editorpresenter%}) documentation article on how to style the __GridViewEditorPresenter__

{% if site.site_name == 'WPF' %}
When data is being validated on property level, the default error template for __WPF__ appears. This is a thin red line around the control. In the world of __WPF__ you can easily restyle validation error template of any control.
 
An exception of this rule are the MS controls that could be styled in all Telerik themes. They inherit the same look and feel presented for each theme, as part of the Telerik theme suite.  
{% endif %}

> To learn how to customize any Telerik theme check the [Setting a Theme(Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) article.

__RadGridView's__ validation tooltip styles are located in __Telerik.Windows.Controls.GridView.xaml__, those related to editors in the respective theme XAML mark-up file.

You can follow [this]({%slug styling-apperance-editing-control-templates%}) article on two different approaches on how to extract the __ControlTemplates__ of the validation tooltip. With __Microsoft Expression Blend__ you could easily extract the desired validation tooltip template of any element. Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default __ControlTemplates__ of the controls. 

Default XAML mark-up for __GridViewCell’s__ validation tooltip in __Office_Black theme__:

#### [XAML] Example 1 - GridViewCell validation tooltip in Office_Black theme: 

	<ControlTemplate x:Key="GridViewCell_ValidationToolTipTemplate" TargetType="ToolTip">

    . . .
    
    <ItemsControl ItemsSource="{TemplateBinding Content}">
        <ItemsControl.ItemTemplate>
            <DataTemplate>
                <Border MinHeight="22"
                        Background="{StaticResource GridView_ValidationTooltipBackground}"
                        BorderBrush="{StaticResource GridView_ValidationTooltipOuterBorder}"
                        BorderThickness="1"
                        CornerRadius="{StaticResource GridView_ValidationTooltipCornerRadius}">
                                <Border BorderBrush="{StaticResource GridView_ValidationTooltipInnerBorder}"
                                        BorderThickness="1">
                        <TextBlock Margin="4 1" MaxWidth="250" 
                                   Foreground="{StaticResource GridView_ValidationTooltipForeground}" 
                                   Text="{Binding}" TextWrapping="Wrap"/>
                    </Border>
                </Border>
            </DataTemplate>
        </ItemsControl.ItemTemplate>
        <ItemsControl.ItemsPanel>
            <ItemsPanelTemplate>
                <StackPanel/>
            </ItemsPanelTemplate>
        </ItemsControl.ItemsPanel>
    </ItemsControl>

    . . .

	</ControlTemplate>

Default XAML mark-up for __GridViewEditorPresenter’s__ validation tooltip in __Office_Black theme__:

#### [XAML] Example 2 - GridViewEditorPresenter validation tooltip in Office_Black theme:

	<ControlTemplate x:Key="GridViewEditorPresenter_ValidationToolTipTemplate" TargetType="ToolTip">
   
    . . .

    <Border MinHeight="22"
            Background="{StaticResource GridView_ValidationTooltipBackground}"
            BorderBrush="{StaticResource GridView_ValidationTooltipOuterBorder}"
            BorderThickness="1"
            CornerRadius="{StaticResource GridView_ValidationTooltipCornerRadius}">
        <Border BorderBrush="{StaticResource GridView_ValidationTooltipInnerBorder}"   BorderThickness="1">
            <TextBlock Margin="4 1" MaxWidth="250" 
                       Foreground="{StaticResource   GridView_ValidationTooltipForeground}" 
                       Text="{TemplateBinding Content}" TextWrapping="Wrap"/>
        </Border>
    </Border>

    . . .

	</ControlTemplate>

Default XAML mark-up for __GridViewRow’s__ validation tooltip in __Office_Black theme__:

#### [XAML] Example 3 - GridViewRow validation tooltip in Office_Black theme:

	<ControlTemplate x:Key="GridViewRow_ValidationToolTipTemplate" TargetType="ToolTip">

	. . .
	
	<ItemsControl ItemsSource="{TemplateBinding Content}">
	    <ItemsControl.ItemTemplate>
	        <DataTemplate>
	            <Border
	                    MinHeight="22"
	                    Background="{StaticResource GridView_ValidationTooltipBackground}"
	                    BorderBrush="{StaticResource GridView_ValidationTooltipOuterBorder}"
	                    BorderThickness="1"
	                    CornerRadius="{StaticResource GridView_ValidationTooltipCornerRadius}">
	                	<Border BorderBrush="{StaticResource GridView_ValidationTooltipInnerBorder}" BorderThickness="1">
	                    <TextBlock Margin="4 1" MaxWidth="250" Foreground="{StaticResource GridView_ValidationTooltipForeground}" Text="{Binding}" TextWrapping="Wrap"/>
	                </Border>
	            </Border>
	        </DataTemplate>
	    </ItemsControl.ItemTemplate>
    <ItemsControl.ItemsPanel>
        <ItemsPanelTemplate>
            <StackPanel/>
        </ItemsPanelTemplate>
    </ItemsControl.ItemsPanel>
	</ItemsControl>

	. . .

	</ControlTemplate>






