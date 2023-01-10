---
title: Customize Expander Animation
page_title: Customize Expander Animation
description: This article shows how to disable or enable and also customize the RadExpander default expand/collapse animations.
slug: radexpander-howto-animation
tags: expander,animation
published: True
position: 1
---

# {{ site.framework_name }} RadExpander Expander Animation

The RadExpander control has an animation enabled by default. 

To disable or enable the animation, set the __AnimationManager.IsAnimationEnabled__ attached property on RadExpander. 

#### __[XAML] Example 1: Disabling animation in XAML__
{{region radexpander-howto-animation_0}}
	<telerik:RadExpander telerik:AnimationManager.IsAnimationEnabled="False" />
{{endregion}}

#### __[C#] Example 2: Disabling animation in code__
{{region radexpander-howto-animation_1}}        
	AnimationManager.SetIsAnimationEnabled(this.radExpander, false);
{{endregion}}

#### __[VB.NET] Example 2: Disabling animation in code__
{{region radexpander-howto-animation_2}}    
	AnimationManager.SetIsAnimationEnabled(Me.radExpander, False)            
{{endregion}}

## Customize Animations

To customize RadExpander animations, use the __AnimationManager.AnimationSelector__ property. The supported animation class is __ExpanderExpandCollapseAnimation__ which exposes few properties to customize the animation.

* __Direction__: An enumeration property of type __AnimationDirection__ which specifies the direction of the animation.
* __TargetElementName__: A property of type __string__ that gets or sets the name of the element that should be animated.
* __AnimationName__: A property of type __string__ that gets or sets the name of the animation. For example:
	* __ExpandDirection is set to Up or Down:__ To modify the animation the AnimationName needs to be set to __Expand or Collapse__.
	* __ExpandDirection is set to Right or Left:__ To modify the animation the AnimationName needs to be set to __ExpandHorizontal or CollapseHorizontal__.
* __SpeedRatio__: A property of type __double__ that gets or sets the speed of the animation.

#### __[XAML] Example 3: Modify the animations when ExpandDirection is Up or Down__
{{region radexpander-howto-animation_3}}
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
{{endregion}}

#### __[XAML] Example 4: Modify the animations when ExpandDirection is Right or Left__
{{region radexpander-howto-animation_4}}
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
{{endregion}}

## See Also
* [Getting Started]({%slug expander-getting-started%})
* [Expand Direction]({%slug radexpander-features-expand_direction%})
