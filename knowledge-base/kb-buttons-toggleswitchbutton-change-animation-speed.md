---
title: Change the Animation Speed of RadToggleSwitchButton
description: How to change the switch animation speed of RadToggleSwitchButton by modifying the AnimationSelector.
type: how-to
page_title: Modify the SpeedRatio of the Default Switch Animation of ToggleSwitchButton
slug: kb-buttons-toggleswitchbutton-change-animation-speed
position: 0
tags: animation,speed,switch,toggle,ratio,selector
ticketid: 1558934
res_type: kb
---

## Environment

<table>
	<tr>
		<td>Product Version</td>
		<td>2022.3.1109</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadButtons for WPF</td>
	</tr>
</table>

## Description

How to change the switch animation speed of `RadToggleSwitchButton` by modifying the `AnimationSelector`.

## Solution

To cange the animation speed, you can set the `SpeedRatio` property of the associated `AnimationSelector` attached to the control. To do this in XAML, you need to replace the default selector with a custom one.


```XAML
	<Application.Resources>
		<!--BasedOn is needed for NoXaml binaries only-->
		<Style TargetType="telerik:RadToggleSwitchButton" BasedOn="{StaticResource RadToggleSwitchButtonStyle}">
			<Setter Property="telerik:AnimationManager.AnimationSelector">
				<Setter.Value>
					<telerik:AnimationSelector>
						<telerik:AnimationGroup AnimationName="CheckedAnimation">
							<telerik:MoveAnimation TargetElementName="PART_Thumb" Duration="0:0:0.4" SpeedRatio="2.0">
								<telerik:MoveAnimation.Easing>
									<QuadraticEase EasingMode="EaseInOut" />
								</telerik:MoveAnimation.Easing>
							</telerik:MoveAnimation>
							<telerik:FadeAnimation TargetElementName="UncheckedTrackBackground" Direction="Out" Duration="0:0:0.4" SpeedRatio="2.0"/>
							<telerik:FadeAnimation TargetElementName="TrackBackground" Direction="In" Duration="0:0:0.4" SpeedRatio="2.0"/>
						</telerik:AnimationGroup>
						<telerik:AnimationGroup AnimationName="UncheckedAnimation">
							<telerik:MoveAnimation TargetElementName="PART_Thumb" Duration="0:0:0.4" SpeedRatio="2.0">
								<telerik:MoveAnimation.Easing>
									<QuadraticEase EasingMode="EaseInOut" />
								</telerik:MoveAnimation.Easing>
							</telerik:MoveAnimation>
							<telerik:FadeAnimation TargetElementName="TrackBackground" Direction="Out" Duration="0:0:0.4" SpeedRatio="2.0"/>
							<telerik:FadeAnimation TargetElementName="UncheckedTrackBackground" Direction="In" Duration="0:0:0.4" SpeedRatio="2.0"/>
						</telerik:AnimationGroup>
						<telerik:AnimationGroup AnimationName="IsThreeStateUncheckedAnimation">
							<telerik:MoveAnimation TargetElementName="PART_Thumb" Duration="0:0:0.4" SpeedRatio="2.0">
								<telerik:MoveAnimation.Easing>
									<QuadraticEase EasingMode="EaseInOut" />
								</telerik:MoveAnimation.Easing>
							</telerik:MoveAnimation>
						</telerik:AnimationGroup>
						<telerik:AnimationGroup AnimationName="IndeterminateAnimation">
							<telerik:MoveAnimation TargetElementName="PART_Thumb" Duration="0:0:0.4" SpeedRatio="2.0">
								<telerik:MoveAnimation.Easing>
									<QuadraticEase EasingMode="EaseInOut" />
								</telerik:MoveAnimation.Easing>
							</telerik:MoveAnimation>
							<telerik:FadeAnimation TargetElementName="TrackBackground" Direction="Out" Duration="0:0:0.4" SpeedRatio="2.0"/>
							<telerik:FadeAnimation TargetElementName="UncheckedTrackBackground" Direction="In" Duration="0:0:0.4" SpeedRatio="2.0"/>
						</telerik:AnimationGroup>
					</telerik:AnimationSelector>
				</Setter.Value>
			</Setter>
		</Style>
	<Application.Resources>
```

An alternative solution is to subscribe to the `Loaded` event of each `RadToggleSwitchButton` in the view and set the `SpeedRatio` in code-behind.


```C#
	private void RadToggleSwitch_Loaded(object sender, RoutedEventArgs e)
	{
		AnimationSelector animationSelector = AnimationManager.GetAnimationSelector(sender as RadToggleSwitchButton) as AnimationSelector;
		foreach (RadAnimation animation in animationSelector.Animations)
		{
			animation.SpeedRatio = 2.0;
		}
	}
```
