---
title: Foreground color does not change in a custom header
page_title: Foreground color does not change in a custom header
description: Foreground color does not change in a custom header
slug: gridview-troubleshooting-styling-custom-header
tags: foreground,color,does,not,change,in,a,custom,header
published: True
position: 14
---

# Foreground color does not change in a custom header

__PROBLEM__

You declare a custom header for a column (__Example 1__):

#### __[XAML] Example 1: Initial declaration of a custom header__

{{region xaml-gridview-troubleshooting-styling-custom-header_0}}
	<telerik:GridViewDataColumn.Header>
	    <TextBlock Text="My Custom Header"
	TextWrapping="Wrap" />
	</telerik:GridViewDataColumn.Header>
{{endregion}}



As a result, the __Foreground__ color of the custom header does not change on mouse hover (__Figure 1__ ), sorting, etc.		

__Figure 1:__ The __Foreground__ color of the custom header does not change, when the column is hovered.

![gridview-troubleshooting-styling-custom-header-Problem](images/gridview-troubleshooting-styling-custom-header-Problem.png)

__CAUSE__

Your custom header is not automatically bound to the default theme's __Foreground__ color.
		
__SOLUTION__

You can bind the __Foreground__ property of the custom header(in this example this is a __TextBlock__) to the __Foreground__ property of the control containing the content of the __GridViewHeaderCell__(__Example 2__ ). In this case the container is a __ContentControl__ with __x:Name="ContentPresenter"__, which is located in the default __GridViewHeaderCellTemplate__. You can observe the result in __Figure 2__.
		

#### __[XAML] Example 2: Final declaration of a custom header__

{% if site.site_name == 'WPF' %}

{{region xaml-gridview-troubleshooting-styling-custom-header_1}}
	<telerik:GridViewDataColumn.Header>
	    <TextBlock Foreground="{Binding Foreground,
	                  RelativeSource={RelativeSource AncestorType={x:Type ContentControl}}}"
	Text="My Custom Header"
	TextWrapping="Wrap" />
	</telerik:GridViewDataColumn.Header>
{{endregion}}

{% endif %}

{% if site.site_name == 'Silverlight' %}

{{region gridview-troubleshooting-styling-custom-header_1}}

	<telerik:GridViewDataColumn.Header>
    <TextBlock Foreground="{Binding Foreground,
               RelativeSource={RelativeSource AncestorType=UserControl}}"
               Text="My Custom Header"
               TextWrapping="Wrap" />
	</telerik:GridViewDataColumn.Header>
{{endregion}}

{% endif %}



__Figure 2:__ The __Foreground__ color of the custom header now changes, when the column is hovered.
![gridview-troubleshooting-styling-custom-header-Solution](images/gridview-troubleshooting-styling-custom-header-Solution.png)

