---
title: BoxesItemStyle
page_title: BoxesItemStyle
description: Check our &quot;BoxesItemStyle&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-boxesitemstyle
tags: customizing,the,boxesitemstyle
published: True
position: 3
---

# BoxesItemStyle

The __BoxesItemStyle__ property, introduced with the Q1 2016 release of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}, makes it easy to customize the boxes of the selected items of a  __RadAutoCompleteBox__. The following article will demonstrate how to apply a custom __BoxesItemStyle__ to a __RadAutoCompleteBox__.

## Applying BoxesItemStyle

First, you need to create a __RadAutoCompleteBox__ with an ItemsSource bound to a collection of business objects:

>Check {% if site.site_name == 'WPF' %}[this](https://docs.telerik.com/devtools/wpf/controls/radautocompletebox/populating-with-data/binding-to-object.html){% endif %}{% if site.site_name == 'Silverlight' %}[this](https://docs.telerik.com/devtools/silverlight/controls/radautocompletebox/populating-with-data/binding-to-object.html){% endif %} article for some more detailed information how to bind the __ItemsSource__ to a collection of business objects.

__RadAutoCompleteBox declaration__

```XAML
	<telerik:RadAutoCompleteBox x:Name="radautocomplete1" Margin="10" ItemsSource="{Binding Agency}" DisplayMemberPath="Name"/>
```

The following screenshot shows how __RadAutoCompleteBox__ will look:

![radautocompletebox-boxesitemstyle-1](images/radautocompletebox-boxesitemstyle-1.png)

Next, you need to create a custom Style that targets __RadAutoCompleteBoxItem__ and customize the items as needed:

__Custom BoxesItemStyle__

```XAML
	<Style TargetType="telerik:RadAutoCompleteBoxItem" x:Key="CustomBoxesItemxStyle">
	  <Setter Property="Foreground" Value="Yellow" />
	  <Setter Property="Background" Value="LightBlue" />
	  <Setter Property="FontFamily" Value="Calibri" />
	  <Setter Property="FontSize" Value="14" />
	  <Setter Property="BorderThickness" Value="1" />
	  <Setter Property="BorderBrush" Value="Red" />
	</Style>
```

>If you are using {% if site.site_name == 'WPF' %}[Implicit Styles](https://docs.telerik.com/devtools/wpf/styling-and-appearance/styling-apperance-implicit-styles-overview){% endif %}{% if site.site_name == 'Silverlight' %}[Implicit Styles](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/styling-apperance-implicit-styles-overview){% endif %}, please notice that the Style should based on the default __RadAutoCompleteBoxItemStyle__.

__Custom BoxesItemStyle with Implicit Styles__

```XAML
	<Style TargetType="telerik:RadAutoCompleteBoxItem" x:Key="CustomBoxesItemxStyle1" BasedOn="{StaticResource RadAutoCompleteBoxItemStyle}">
	  <Setter Property="Foreground" Value="Yellow" />
	  <Setter Property="Background" Value="LightBlue" />
	  <Setter Property="FontFamily" Value="Calibri" />
	  <Setter Property="FontSize" Value="14" />
	  <Setter Property="BorderThickness" Value="1" />
	  <Setter Property="BorderBrush" Value="Red" />
	</Style>
```

Finally, you need to set the __BoxesItemStyle__ property of the __RadAutoCompleteBox__ with the created Style:

__Setting of BoxesItemStyle__

```XAML
	<telerik:RadAutoCompleteBox x:Name="radautocomplete" Margin="10"
	                                ItemsSource="{Binding Agency}"
	                                BoxesItemStyle="{StaticResource CustomBoxesItemxStyle}"
	                                DisplayMemberPath="Name"/>
```

The following screenshot shows how the __RadAutoCompleteBox__ looks after the __BoxesItemStyle__ gets applied:

![radautocompletebox-radautocompletebox-boxesitemstyle-2](images/radautocompletebox-boxesitemstyle-2.png)

## See Also

 * [Overview]({%slug radautocompletebox-styles-and-templates-overview%})
 
 * [BoxesItemTemplate]({%slug radautocompletebox-customizing-boxes-itemtemplate%})
