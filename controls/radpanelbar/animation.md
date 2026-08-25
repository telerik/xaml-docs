---
title: Animation
page_title: Animation - RadPanelBar
description: Expand and collapse animation for the RadPanelBar {{site.framework_name}} control.
slug: radpanelbar-features-animation
tags: expand, collapse, animation
published: True
position: 5
---

# Animation

By default the RadPanelBar control's items are expanded and collapsed without an animation. To enable the expand\collapse animations you can use the **telerik:AnimationManager.IsAnimationEnabled** attached property. To customize the animation you could use the **PanelBarExpandCollapseAnimation** object.

## Enable Animation in RadPanelBar

The animation is enabled by setting the **telerik:AnimationManager.IsAnimationEnabled** property to **True**.

__Enabling the Expand/Collapse Animation__
```XAML
<telerik:RadPanelBar xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                     telerik:AnimationManager.IsAnimationEnabled="True">
```

## Change Animation Direction

The animation direction is controlled by the **Direction** property of the **PanelBarExpandCollapseAnimation** class and it is either **In** or **Out**.

__Setting the Expand/Collapse Direction__

```XAML
<telerik:RadPanelBar xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                     xmlns:animationNavigation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls.Navigation"> 
	<telerik:AnimationManager.AnimationSelector>
		<telerik:AnimationSelector>
			<animationNavigation:PanelBarExpandCollapseAnimation AnimationName="Expand" Direction="In"/>
			<animationNavigation:PanelBarExpandCollapseAnimation AnimationName="Collapse" Direction="Out"/>
		</telerik:AnimationSelector>
	</telerik:AnimationManager.AnimationSelector>
</telerik:RadPanelBar> 
```

## Change Animation Speed

The speed of the expand\collapse is also customizable via the **AnimationManager.AnimationSelector** attached property.

__Changing the Animation Speed__

```XAML
<telerik:RadPanelBar xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                     xmlns:animationNavigation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls.Navigation"> 
	<telerik:AnimationManager.AnimationSelector>
		<telerik:AnimationSelector>
			<animationNavigation:PanelBarExpandCollapseAnimation AnimationName="Expand" Direction="In" SpeedRatio="0.25"/>
			<animationNavigation:PanelBarExpandCollapseAnimation AnimationName="Collapse" Direction="Out" SpeedRatio="0.25"/>
		</telerik:AnimationSelector>
	</telerik:AnimationManager.AnimationSelector>
</telerik:RadPanelBar>
```

The **SpeedRatio** property controls the duration. A value of 0.25 means that the animation will play a quarter (25%) of the default animation duration (for example, 15 of 60 seconds). A value of 1, means that the default time will be used. A value of 1.33 means that the animation will be played 33% faster than the default time.

## See Also
* [Getting Started]({%slug radpanelbar-populating%})
* [Visual Structure]({%slug radpanelbar-structure%})
