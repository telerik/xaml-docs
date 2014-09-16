---
title: Hierarchical Data
page_title: Hierarchical Data
description: Hierarchical Data
slug: common-data-binding-hierarchical-data
tags: hierarchical,data
publish: True
position: 4
---

# Hierarchical Data



## 

__RadTreeView__, __RadMenu__ and __RadPanelBar__ inherit from __HeaderedItemsControl__ and they can display hierarchical data, e.g. collections that contain other collections.

The __HierarchicalDataTemplate__ class is designed to be used with __HeaderedItemsControl__ types to display such data. There should be virtually no differences between the usage of __HierarchicalDataTemplate__ in __RadTreeView__, __RadMenu__ or __RadPanelBar__. 

The following example demonstrates how to create a hierarchical data source and bind a __RadTreeView__ to it, using a __HierarchicalDataTemplate__. The __ItemsSource__ property of the __HierarchicalDataTemplate__ specifies the binding that has to be applied to the __ItemsSource__ property of each item. The __DataTemplate__ property specifies the template that has to be applied on each item, while the __ItemTemplate__ is the template, applied on its child items. You can nest several __HierarchicalDataTemplate__ declarations if you need deeper level of hierarchy.

#### __XAML__

{{region common-data-binding-hierarchical-data_0}}
	<telerikNavigation:RadTreeView x:Name="radTreeView" ItemsSource="{Binding}">
	
	    <telerikNavigation:RadTreeView.ItemTemplate>
	
	        <telerik:HierarchicalDataTemplate ItemsSource="{Binding Products}">
	            <StackPanel Orientation="Horizontal">
	                <TextBlock Text="{Binding Name}" Foreground="Red" />
	                <TextBlock Margin="10,0,0,0" Text="{Binding Description}" />
	            </StackPanel>
	        </telerik:HierarchicalDataTemplate>
	
	    </telerikNavigation:RadTreeView.ItemTemplate>
	
	</telerikNavigation:RadTreeView>
	{{endregion}}



# See Also

 * [Style Selectors]({%slug common-data-binding-style-selectors%})

 * [Template Selectors]({%slug common-data-binding-template-selectors%})

 * [Data Conversion]({%slug common-data-binding-data-conversion%})
