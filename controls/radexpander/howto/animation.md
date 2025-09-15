---
title: Customize Expander Animation
page_title: Customize Expander Animation
description: This article shows how to disable or enable and also customize the RadExpander default expand/collapse animations.
slug: radexpander-howto-animation
tags: expander,animation
published: True
position: 1
---

# Expander Animation

The RadExpander control has an animation enabled by default. 

To disable or enable the animation, set the __AnimationManager.IsAnimationEnabled__ attached property on RadExpander. 

__Example 1: Disabling animation in XAML__
```XAML
	<telerik:RadExpander telerik:AnimationManager.IsAnimationEnabled="False" />
```

__Example 2: Disabling animation in code__
```C#        
	AnimationManager.SetIsAnimationEnabled(this.radExpander, false);
```
```VB.NET    
	AnimationManager.SetIsAnimationEnabled(Me.radExpander, False)            
```

## Customize Animations

To customize RadExpander animations, use the __AnimationManager.AnimationSelector__ property. The supported animation class is __ExpanderExpandCollapseAnimation__ which exposes few properties to customize the animation.

* __Direction__: An enumeration property of type __AnimationDirection__ which specifies the direction of the animation.
* __TargetElementName__: A property of type __string__ that gets or sets the name of the element that should be animated.
* __AnimationName__: A property of type __string__ that gets or sets the name of the animation. For example:
	* __ExpandDirection is set to Up or Down:__ To modify the animation the AnimationName needs to be set to __Expand or Collapse__.
	* __ExpandDirection is set to Right or Left:__ To modify the animation the AnimationName needs to be set to __ExpandHorizontal or CollapseHorizontal__.
* __SpeedRatio__: A property of type __double__ that gets or sets the speed of the animation.

__Example 3: Modify the animations when ExpandDirection is Up or Down__
```XAML
	<telerik:RadExpander>
		<telerik:RadExpander.Content>
			<Grid>
				<Grid.RowDefinitions>
					<RowDefinition Height="20"/>
					<RowDefinition Height="20"/>
					<RowDefinition Height="20"/>
				</Grid.RowDefinitions>
				<TextBox Grid.Row="0">My content</TextBox>
				<TextBox Grid.Row="1">My content</TextBox>
				<TextBox Grid.Row="2">My content</TextBox>
			</Grid>
		</telerik:RadExpander.Content>
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<telerik:ExpanderExpandCollapseAnimation AnimationName="Expand" 
														 Direction="In"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
				<telerik:ExpanderExpandCollapseAnimation AnimationName="Collapse" 
														 Direction="Out"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadExpander>
```

__Example 4: Modify the animations when ExpandDirection is Right or Left__
```XAML
	<telerik:RadExpander ExpandDirection="Left">
		<telerik:RadExpander.Content >
				<Grid>
					<Grid.RowDefinitions>
						<RowDefinition Height="20"/>
						<RowDefinition Height="20"/>
						<RowDefinition Height="20"/>
					</Grid.RowDefinitions>
					<TextBox Grid.Row="0">My content</TextBox>
					<TextBox Grid.Row="1">My content</TextBox>
					<TextBox Grid.Row="2">My content</TextBox>
				</Grid>
		</telerik:RadExpander.Content>
		<telerik:AnimationManager.AnimationSelector>
			<telerik:AnimationSelector>
				<telerik:ExpanderExpandCollapseAnimation AnimationName="ExpandHorizontal" 
														 Direction="In"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
				<telerik:ExpanderExpandCollapseAnimation AnimationName="CollapseHorizontal" 
														 Direction="Out"
														 SpeedRatio="0.2"
														 TargetElementName="Content" />
			</telerik:AnimationSelector>
		</telerik:AnimationManager.AnimationSelector>
	</telerik:RadExpander>
```

## See Also
* [Getting Started]({%slug expander-getting-started%})
* [Expand Direction]({%slug radexpander-features-expand_direction%})
