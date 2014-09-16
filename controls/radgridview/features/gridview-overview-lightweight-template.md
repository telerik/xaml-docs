---
title: Lightweight Templates
page_title: Lightweight Templates
description: Lightweight Templates
slug: gridview-overview-lightweight-template
tags: lightweight,templates
published: True
position: 8
---

# Lightweight Templates



With __2013 Q2 SP__ we have introduced lightweight templates for __RadGridView and RadTreeListView__. 

They are represented by several additional __simplified styles, which you can merge in your project__. The main idea of simplifying templates of different parts of RadGridView is to limit the number of visual elements within the templates in order to __speed up the performance__ of RadGridView/RadTreeListView. 
      

>importantThe Lightweight Templates can only be applied with NoXaml binaries and Implicit Themes. You can find more information on them [here]({%slug styling-apperance-implicit-styles-overview%}).
        

>tip{% if site.site_name == 'WPF' %}

The performance on loading the visual elements will be increased __up to 50%__ when the lightweight templates are applied.
          {% endif %}{% if site.site_name == 'Silverlight' %}

The performance on loading the visual elements will be increased __up to 25%__ when the lightweight templates are applied.
          {% endif %}

>Please note that the __row details/hierarchy__ option is __not supported__ with these templates.
        

These styles are separated in the following directions:

* Core styles

* Core styles including validation

## Core styles

The CoreStyles are a basic alternative of the standard __GridViewCell, GridViewRow, TreeListViewRow__ including basic еffects and funcionalities such as __hover, selection, currency, grouping__ for these elements. These core styles are included within the themes of RadGridView and you may reference it in your project as shown below:
        

#### __XAML__

{{region gridview-overview-lightweight-template_0}}
	    <Window.Resources>
	        <ResourceDictionary>
	            <ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.GridView.xaml"/>
	            </ResourceDictionary.MergedDictionaries>
	            <Style TargetType="telerik:GridViewRow" BasedOn="{StaticResource GridViewRowCoreStyle}"/>
	            <Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellCoreStyle}"/>
	            <Style TargetType="telerik:TreeListViewRow" BasedOn="{StaticResource TreeListViewRowCoreStyle}"/>
	        </ResourceDictionary>
	    </Window.Resources>
	{{endregion}}

![gridview overview lightweight 0](images/gridview_overview_lightweight_0.png)

>tipFor __RadGridView__ you need to merge only the CoreStyles for __GridViewCell and GridViewRow__. For __RadTreeListView__ you need to merge the styles for __GridViewCell and TreeListViewRow__.

>__GridViewRowCoreStyle__ does not contain a row indicator. Please set the __RowIndicatorVisibility__ property of the RadGridView to __Collapsed__ to avoid any visual differences between the row's headers and cells.
          

## Core styles with validation

The CoreValidationStyles are an alternative of the standard __GridViewCell, GridViewRow, TreeListViewRow__. They include basic еffects and funcionalities such as __hover, selection, currency, grouping, validation__ for these elements. These core styles are included within the themes of RadGridView and you may reference it in your project as shown below:
        

#### __XAML__

{{region gridview-overview-lightweight-template_1}}
	<Window.Resources>
	        <ResourceDictionary>
	            <ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Input.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.GridView.xaml"/>
	            </ResourceDictionary.MergedDictionaries>
	            <Style TargetType="telerik:GridViewRow" BasedOn="{StaticResource GridViewRowCoreValidationStyle}"/>
	            <Style TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellCoreValidationStyle}"/>
	            <Style TargetType="telerik:TreeListViewRow" BasedOn="{StaticResource TreeListViewRowCoreValidationStyle}"/>
	        </ResourceDictionary>
	    </Window.Resources>
	{{endregion}}

![gridview overview lightweight 1](images/gridview_overview_lightweight_1.png)

>__GridViewRowCoreValidationStyle__ contains a row indicator, which you can use to perform validation.
          

>tipFor __RadGridView__ you need to merge only the CoreStyles for __GridViewCell and GridViewRow__. For __RadTreeListView__ you need to merge the styles for __GridViewCell and TreeListViewRow__.
          

You can download a __runnable solution__ from our online SDK repository
          [here](https://github.com/telerik/xaml-sdk/), the example is listed under __GridView/LightweightTemplates__.
        

# See Also
