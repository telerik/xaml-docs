---
title: Bind to a Selected Item
page_title: Bind to a Selected Item
description: Check our &quot;Bind to a Selected Item&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-bind-selected-item
tags: bind,to,a,selected,item
published: True
position: 10
---

# Bind to a Selected Item

__RadTreeView__ exposes __SelectedItem__ property, which is a __DependencyProperty__ and can be used in a data binding.

#### __XAML__

```XAML
	<telerik:RadTreeView SelectedItem="{Binding SelectedItem, Mode=TwoWay}"/>
```

If you want to bind to the __RadTreeViewItem__'s __IsSelected__ property when your treeview is [data bound to an object]({%slug radtreeview-populating-with-data-data-binding-to-object%}), then you need to use an __ItemContainerStyle__.

#### __XAML__

```XAML
	<telerik:RadTreeView>
	    <telerik:RadTreeView.ItemContainerStyle>
	        <Style TargetType="telerik:RadTreeViewItem">
	            <Setter Property="IsSelected" Value="{Binding Path=Select, Mode=TwoWay}" />
	        </Style >
	    </telerik:RadTreeView.ItemContainerStyle>
	</telerik:RadTreeView>
	```

> When using __NoXaml__ dlls, the __Style__ set to the __ItemContainerStyle__ property should have its __BasedOn__ property set to __{StaticResource RadTreeViewItemStyle}__.

## See Also
 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})
 * [Add Context Menu]({%slug radtreeview-how-to-add-context-menu%})
 * [Change the Default Height of a TreeViewItem]({%slug radtreeview-how-to-change-default-height-treeviewitem%})