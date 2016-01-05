---
title: BoxesItemStyle
page_title: BoxesItemStyle
description: BoxesItemStyle
slug: radautocompletebox-boxesitemstyle
tags: customizing,the,boxesitemstyle
published: True
position: 3
---

# BoxesItemStyle

The BoxesItemStyle property, introduced with the Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}, makes it really easy to customize the boxes of the selected items of __RadAutoCompleteBox__. The following article will demonstrates how to apply a custom __BoxesItemStyle__ to __RadAutoCompleteBox__.

## Applying BoxesItemStyle

First, you need to create __RadAutoCompleteBox__ with an ItemsSource bound to a collection of business object:

>Check {% if site.site_name == 'WPF' %}[this](http://docs.telerik.com/devtools/wpf/controls/radautocompletebox/populating-with-data/binding-to-object.html){% endif %}{% if site.site_name == 'Silverlight' %}[this](http://docs.telerik.com/devtools/silverlight/controls/radautocompletebox/populating-with-data/binding-to-object.html){% endif %} article for some more detailed information how to bind the __ItemsSource__ to a collection of business objects.

#### __[XAML] RadAutoCompleteBox declaration__

{{region radautocompletebox-boxesitemstyle_0}}
	<telerik:RadAutoCompleteBox x:Name="radautocomplete" Margin="10" ItemsSource="{Binding Agency}" DisplayMemberPath="Name"/>
{{endregion}}

The following screenshot shows how __RadAutoCompleteBox__ will look:

![radautocompletebox-boxesitemstyle-1](images/radautocompletebox-boxesitemstyle-1.png)

Next, you need to create a custom Style that targets __RadAutoCompleteBoxItem__ and customize the items as needed:

#### __[XAML] Custom BoxesItemStyle__

{{region radautocompletebox-boxesitemstyle_1}}
	<Style TargetType="telerik:RadAutoCompleteBoxItem" x:Key="CustomBoxesItemxStyle">
		<Setter Property="Foreground" Value="Yellow" />
		<Setter Property="Background" Value="LightBlue" />
		<Setter Property="FontFamily" Value="Calibri" />
		<Setter Property="FontSize" Value="14" />
		<Setter Property="BorderThickness" Value="1" />
		<Setter Property="BorderBrush" Value="Red" />
	</Style>
{{endregion}}

>If you are using {% if site.site_name == 'WPF' %}[Implicit Styles](http://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-implicit-styles-overview){% endif %}{% if site.site_name == 'Silverlight' %}[Implicit Styles](http://docs.telerik.com/devtools/silverlight/styling-and-appearance/styling-apperance-implicit-styles-overview){% endif %}, please notice that the Style should based on the default __RadAutoCompleteBoxItemStyle__.

#### __[XAML] Custom BoxesItemStyle with Implicit Styles__

{{region radautocompletebox-boxesitemstyle_2}}
	<Style TargetType="telerik:RadAutoCompleteBoxItem" x:Key="CustomBoxesItemxStyle" BasedOn="{StaticResource RadAutoCompleteBoxItemStyle}">
		<Setter Property="Foreground" Value="Yellow" />
		<Setter Property="Background" Value="LightBlue" />
		<Setter Property="FontFamily" Value="Calibri" />
		<Setter Property="FontSize" Value="14" />
		<Setter Property="BorderThickness" Value="1" />
		<Setter Property="BorderBrush" Value="Red" />
	</Style>
{{endregion}}

Finally, you need to set the __BoxesItemStyle__ property of __RadAutoCompleteBox__ with the created Style:

#### __[XAML] Setting of BoxesItemStyle__

{{region radautocompletebox-boxesitemstyle_3}}
	 <telerik:RadAutoCompleteBox x:Name="radautocomplete" Margin="10"
                                    ItemsSource="{Binding Agency}" 
                                    BoxesItemStyle="{StaticResource CustomBoxesItemxStyle}"
                                    DisplayMemberPath="Name"/>
{{endregion}}

The following screenshot shows how __RadAutoCompleteBox__ looks after the __BoxesItemStyle__ gets applied:

![radautocompletebox-radautocompletebox-boxesitemstyle-2](images/radautocompletebox-boxesitemstyle-2.png)

# See Also

 * [Overview]({%slug radautocompletebox-styles-and-templates-overview%})
 
 * [BoxesItemTemplate]({%slug radautocompletebox-customizing-boxes-itemtemplate%})
