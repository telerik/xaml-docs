---
title: Disable Default Animation in RadTreeView
page_title: Disable Default Animation in RadTreeView
description: Check our &quot;Disable Default Animation in RadTreeView&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-disable-default-animation
tags: disable,default,animation,in,radtreeview
published: True
position: 14
---

# Disable Default Animation in RadTreeView

By default the __RadTreeView__ control's items are __expanded__ and __collapsed__ with an animation. However, there are cases when you might want to disable these animations, e.g. when you have a large number of subitems and it takes a longer time for the animations to complete. To disable the default animations, all you have to do is to set the following attached property to the __RadTreeView__ control:  



```XAML
	<telerik:RadTreeView telerik:AnimationManager.IsAnimationEnabled="False"/>
```

The referenced namespace is defined as follows: 



```XAML
	xmlns:telerik=http://schemas.telerik.com/2008/xaml/presentation
```

Once you have declared the needed namespace, the only thing you have to do is setting the attached property to __False__. All treeview items will inherit that property from their parent __RadTreeView__.

>The default duration of the expand animation is 2 seconds.

## See Also
 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})
 * [Selection]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})