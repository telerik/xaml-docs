---
title: Enable and Disable Menu Items
page_title: Enable and Disable Menu Items
description: Enable and Disable Menu Items
slug: radmenu-how-to-enable-disable-menu-items
tags: enable,and,disable,menu,items
published: True
position: 2
---

# Enable and Disable Menu Items

This topic will show you how to enable and disable menu items. There are several major cases that will serve as examples:

* Disable all menu items

* Disable a static menu item

* Disable a dynamic menu item

## Disable all Menu Items

Disabling all menu items can be easily done by just setting the __IsEnabled__ property of the __RadMenu__ parent control to __False__.

#### __XAML__

{{region radmenu-how-to-enable-disable-menu-items_0}}
	<telerik:RadMenu VerticalAlignment="Top"
	                           IsEnabled="False">
	    ...
	</telerik:RadMenu>
{{endregion}}

This will disable the top-level menu items and they won't be expandable. 

![](images/RadMenu_How_To_Enable_Disable_01.png)

## Disable a Static Menu Item

To disable a static menu item you just have to set its __IsEnabled__ property to __False__.

#### __XAML__

{{region radmenu-how-to-enable-disable-menu-items_1}}
	<telerik:RadMenuItem Header="Save as ..." IsEnabled="False" />
{{endregion}}

>Note that disabling an item will prevent it from expanding its child items (if any).

![](images/RadMenu_How_To_Enable_Disable_02.png)

## Disable a Dynamic Menu Item

>tipBefore you continue reading this topic, you might find useful to take a look at the [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%}) topic.

In order to disable a dynamic menu item you have to bind its __IsEnabled__ property to the appropriate boolean property of your data item. To do this you have to define a __ContainerBinding__ for the __HierarchicalDataTemplate__, used to display the items. In this way the __IsEnabled__ property of the data item's container (the __RadMenuItem__) will be bound.

#### __XAML__

{{region radmenu-how-to-enable-disable-menu-items_2}}
	<telerik:HierarchicalDataTemplate x:Key="ItemTemplate"
	                                  ItemsSource="{Binding SubItems}">
	    <telerik:ContainerBinding.ContainerBindings>
	        <telerik:ContainerBindingCollection>
	            <telerik:ContainerBinding PropertyName="IsEnabled"
	                                      Binding="{Binding CanClickItem}" />
	        </telerik:ContainerBindingCollection>
	    </telerik:ContainerBinding.ContainerBindings>
	    <TextBlock Text="{Binding Text}" />
	</telerik:HierarchicalDataTemplate>
{{endregion}}

# See Also

 * [Checkable Items]({%slug radmenu-features-checkable-items%})

 * [Separator Items]({%slug radmenu-features-separator-items%})

 * [Commands]({%slug radmenu-features-commands%})
