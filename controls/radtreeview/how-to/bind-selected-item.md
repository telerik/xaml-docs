---
title: Bind to a Selected Item
page_title: Bind to a Selected Item
description: Bind to a Selected Item
slug: radtreeview-how-to-bind-selected-item
tags: bind,to,a,selected,item
publish: True
position: 10
---

# Bind to a Selected Item



## 

__RadTreeView__ exposes __SelectedItem__ property, which is a __DependencyProperty__ and can be used in a data binding.
		

#### __XAML__

{{region radtreeview-how-to-bind-selected-item_0}}
	<telerik:RadTreeView SelectedItem="{Binding SelectedItem, Mode=TwoWay}"/>
	{{endregion}}



If you want to bind to the __RadTreeViewItem__'s __IsSelected__ property when your treeview is [data bound to an object]({%slug radtreeview-populating-with-data-data-binding-to-object%}), then you need to use an __ItemContainerStyle__.
		

#### __XAML__

{{region radtreeview-how-to-bind-selected-item_1}}
	<telerik:RadTreeView>
	    <telerik:RadTreeView.ItemContainerStyle>
	        <Style TargetType="telerik:RadTreeViewItem">
	            <Setter Property="IsSelected" Value="{Binding Path=Select, Mode=TwoWay}" />
	        </Style >
	    </telerik:RadTreeView.ItemContainerStyle>
	</telerik:RadTreeView>
	{{endregion}}



# See Also

 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})

 * [Add Context Menu]({%slug radtreeview-how-to-add-context-menu%})

 * [Change the Default Height of a TreeViewItem]({%slug radtreeview-how-to-change-default-height-treeviewitem%})
