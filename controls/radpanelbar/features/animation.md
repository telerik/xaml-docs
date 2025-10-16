---
title: Animation
page_title: Animation - RadPanelBar
description: Expand and collapse animation for the RadPanelBar {{site.framework_name}} control.
slug: radpanelbar-features-animation
tags: expand, collapse, animation
published: True
position: 0
---

# Animation

By default the RadPanelBar control's items are expanded and collapsed without an animation. To enable the expand\collapse animations you can use the **telerik:AnimationManager.IsAnimationEnabled** attached property. To customize the animation you could use the **PanelBarExpandCollapseAnimation** object.

## Enable Animation in RadPanelBar

The animation is enabled by setting the **telerik:AnimationManager.IsAnimationEnabled** property to **True**.

#### **[XAML] Example 1: Enable expand\collapse animation**
```XAML
	<telerik:RadPanelBar telerik:AnimationManager.IsAnimationEnabled="True">
```

## Change Animation Direction

The animation direction is controlled by the **Direction** property of the **PanelBarExpandCollapseAnimation** class and it is either **In** or **Out**.

#### **[XAML] Example 2: Set expand\collapse directions**

```XAML
	<telerik:RadPanelBar xmlns:animationNavigation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls.Navigation"> 
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

#### **[XAML] Example 3: Change animation speed**

```XAML
	<telerik:RadPanelBar xmlns:animationNavigation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls.Navigation"> 
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<animationNavigation:PanelBarExpandCollapseAnimation AnimationName="Expand" Direction="In" SpeedRatio="0.25"/>
				<animationNavigation:PanelBarExpandCollapseAnimation AnimationName="Collapse" Direction="Out" SpeedRatio="0.25"/>
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadPanelBar>
```

The **SpeedRatio** property controls the duration. A value of 0.25 means that the animation will play a quarter (25%) of the default animation duration (for example, 15 of 60 seconds). A value of 1, means that the default time will be used. A value of 1.33 means that the animation will be played 33% faster than the default time.
