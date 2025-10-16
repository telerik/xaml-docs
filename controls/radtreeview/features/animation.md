---
title: Animation
page_title: Animation
description: This article shows how to modify of remove the default animations of the RadTreeView items.
slug: radtreeview-features-animation
tags: mouse,animation
published: True
position: 0
---

# Animation

By default the RadTreeView control's items are expanded and collapsed with an animation. The expand\collapse animations are represented by a __TreeViewExpandCollapseAnimation__ object. This class derives from __RadAnimation__. The animation direction is controlled by the AnimationType property of the __TreeViewExpandCollapseAnimation__ class. So if you want to change the speed of the expand\collapse you can use the __AnimationManager.AnimationSelector__ attached property.

## Change Animation Speed

__Example 1: Change animation speed__
```XAML
	<telerik:RadTreeView xmlns:animationNavigation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls.Navigation" >
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<animationNavigation:TreeViewExpandCollapseAnimation AnimationName="Expand"
							Direction="In" SpeedRatio="0.25" />
				<animationNavigation:TreeViewExpandCollapseAnimation AnimationName="Collapse"
							Direction="Out" SpeedRatio="0.25" />
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadTreeView>
```

The __SpeedRatio__ property controls the duration. A value of 0.25 means that the animation will play a quarter (25%) of the default animation duration (for example, 15 of 60 seconds). A value of 1, means that the default time will be used. A value of 1.33 means that the animation will be played 33% faster than the default time.

## Disable Default Animation in RadTreeView

When you have a large number of subitems it takes a longer time for the animations to complete. In this case you can consider disabling the animation to speed up the expand\collapse performance. To disable the default animations, all you have to do is to set the following attached property to the RadTreeView control: 

__Example 1: Disable expand\collapse animation__
```XAML
	<telerik:RadTreeView telerik:AnimationManager.IsAnimationEnabled="False"/>
```
	
## See Also
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
 * [Keyboard Support]({%slug radtreeview-features-keyboard-support%})
 * [Selection]({%slug radtreeview-feautres-treeviewitem-selection%})
