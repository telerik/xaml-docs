---
title: Disable Default Animation in RadTreeView
page_title: Disable Default Animation in RadTreeView
description: Disable Default Animation in RadTreeView
slug: radtreeview-how-to-disable-default-animation
tags: disable,default,animation,in,radtreeview
published: True
position: 14
---

# Disable Default Animation in RadTreeView



## 

By default the __RadTreeView__ control's items are __expanded__and __collapsed__with an animation. However, there are cases when you might want to disable these animations, e.g. when you have a large number of subitems and it takes a longer time for the animations to complete. To disable the default animations, all you have to do is to set the following attached property to the __RadTreeView__control:  

#### __XAML__

{{region radtreeview-how-to-disable-default-animation_0}}
	<telerik:RadTreeView telerik:AnimationManager.IsAnimationEnabled="False"/>
	{{endregion}}



The referenced namespace is defined as follows: 

#### __XAML__

{{region radtreeview-how-to-disable-default-animation_1}}
	xmlns:telerik=http://schemas.telerik.com/2008/xaml/presentation
	{{endregion}}



Once you have declared the needed namespace, the only thing you have to do is setting the attached property to __False__. All treeview items will inherit that property from their parent __RadTreeView__.

>The default duration of the expand animation is 2 seconds.

# See Also

 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})

 * [Work with Selection]({%slug radtreeview-how-to-how-to-work-with-selection%})

 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
