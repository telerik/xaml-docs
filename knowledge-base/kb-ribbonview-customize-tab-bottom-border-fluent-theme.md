---
title: Custom Style for Selected Tab Border Color and Thickness in Fluent theme
description: Create a style for the underline border of the selected tab. Change its color and thickness in code behind. 
type: how-to
page_title: Customize RadRibbonTab bottom border without extracting ControlTemplate in Fluent theme
slug: kb-ribbonview-customize-tab-bottom-border-fluent-theme
position: 0
tags: childrenoftype,underline
ticketid: 1387740
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.116</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadRibbonView for WPF</td>
	</tr>
</table>

## Description

How to change the color and thickness of the blue underline border of the selected tab in RadRibbonView in Fluent Theme.

## Solution

To customize RadRibbonTab in code, follow the next few steps:

1. Subscribe to the Loaded event of RadRibbonTab.
2. In the event handler call the [ChildrenOfType<T>()]({%slug common-visual-tree-helpers%}) method to get all Border elements of the loaded RadRibbonTab. 
3. Call the FirstOrDefault() method (from the System.Linq namespace) to find the Border with x:Name="SelectedVisual". This is the element presenting the border around the selected tab.
4. Set the BorderBrush and BorderThicknes properties of the Border control.


```XAML
	<telerik:RadRibbonView>
		<telerik:RadRibbonTab Header="Home" Loaded="RadRibbonTab_Loaded" />
		<telerik:RadRibbonTab Header="Insert" Loaded="RadRibbonTab_Loaded" />
		<telerik:RadRibbonTab Header="View" Loaded="RadRibbonTab_Loaded" />            
	</telerik:RadRibbonView>
```


```C#
	private void RadRibbonTab_Loaded(object sender, RoutedEventArgs e)
	{
		var tab = (RadRibbonTab)sender;
		var border = tab.ChildrenOfType<Border>().FirstOrDefault(x => x.Name == "SelectedVisual");
		if (border != null)
		{
			border.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFCD43"));
			border.BorderThickness = new Thickness(0, 0, 0, 8);
		}
	}
```

![Before (left) and after (right) visual example](images/kb-ribbonview-customize-tab-bottom-border-fluent-theme-0.png)

## See Also
* [Visual Tree Helpers]({%slug common-visual-tree-helpers%})
* [RibbonView Getting Started]({%slug radribbonview-gettingstarted%})
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})

