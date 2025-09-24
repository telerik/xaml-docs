---
title: Styling
page_title: Styling
description: Check our &quot;Styling&quot; documentation article for the RadTimePicker {{ site.framework_name }} control.
slug: radtimepicker-styling
tags: styling
published: False
position: 2
---

# Styling

RadTimePicker allows you to customize its appearance by using Styles.This example shows how different styles can be applied to time picker toggle button to build a custom appearance. You have to set TimePicker __IconButtonStyle__ property in order to have custom appearance.

In the next example you can see two custom toggle buttons styles and how TimePicker can looks in different way.

![{{ site.framework_name }} RadTimePicker Custom Toggle Button Style](images/ToggleButtons.jpg)



```XAML
	<Style x:Key="TimePickerToggleButtonStyle" TargetType="ToggleButton">
	    <Setter Property="Template">
	        <Setter.Value>
	            <ControlTemplate TargetType="ToggleButton">
	                <Grid >
	                    <VisualStateManager.VisualStateGroups>
	                        <VisualStateGroup x:Name="CommonStates">
	                            <VisualState x:Name="Normal" />
	                            <VisualState x:Name="MouseOver">
	                                <Storyboard>
	                                    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Arrow"
	                                                                   Storyboard.TargetProperty="Fill">
	                                        <DiscreteObjectKeyFrame KeyTime="0">
	                                            <DiscreteObjectKeyFrame.Value>
	                                                <SolidColorBrush Color="Blue" />
	                                            </DiscreteObjectKeyFrame.Value>
	                                        </DiscreteObjectKeyFrame>
	                                    </ObjectAnimationUsingKeyFrames>
	                                </Storyboard>
	                            </VisualState>
	                            <VisualState x:Name="Pressed">
	                                <Storyboard>
	                                    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Arrow"
	                                                                   Storyboard.TargetProperty="Fill">
	                                        <DiscreteObjectKeyFrame KeyTime="0">
	                                            <DiscreteObjectKeyFrame.Value>
	                                                <SolidColorBrush Color="Blue" />
	                                            </DiscreteObjectKeyFrame.Value>
	                                        </DiscreteObjectKeyFrame>
	                                    </ObjectAnimationUsingKeyFrames>
	                                </Storyboard>
	                            </VisualState>
	                            <VisualState x:Name="Disabled" />
	                        </VisualStateGroup>
	                        <VisualStateGroup x:Name="CheckStates">
	                            <VisualState x:Name="Unhecked"/>
	                            <VisualState x:Name="Checked">
	                                <Storyboard>
	                                    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Arrow"
	                                                                   Storyboard.TargetProperty="Fill">
	                                        <DiscreteObjectKeyFrame KeyTime="0">
	                                            <DiscreteObjectKeyFrame.Value>
	                                                <SolidColorBrush Color="Blue" />
	                                            </DiscreteObjectKeyFrame.Value>
	                                        </DiscreteObjectKeyFrame>
	                                    </ObjectAnimationUsingKeyFrames>
	                                </Storyboard>
	                            </VisualState>
	                        </VisualStateGroup>
	                        <VisualStateGroup x:Name="FocusStates">
	                            <VisualState x:Name="Unfocused" />
	                            <VisualState x:Name="Focused">
	                                <Storyboard>
	                                    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Arrow"
	                                                                   Storyboard.TargetProperty="Fill">
	                                        <DiscreteObjectKeyFrame KeyTime="0">
	                                            <DiscreteObjectKeyFrame.Value>
	                                                <SolidColorBrush Color="Blue" />
	                                            </DiscreteObjectKeyFrame.Value>
	                                        </DiscreteObjectKeyFrame>
	                                    </ObjectAnimationUsingKeyFrames>
	                                </Storyboard>
	                            </VisualState>
	                        </VisualStateGroup>
	                    </VisualStateManager.VisualStateGroups>
	                    <Border Background="#00FFFFFF"
	                            Margin="-20,0,20,0"
	                            CornerRadius="2,2,2,2"
	                            x:Name="Chrome" />
	                    <Path x:Name="Arrow" 
	                          Width="5"
	                          Height="9"
	                          Margin="-40,1,3,0"
	                          Data="F1 M -2.54313e-006,-12L 1.33333,-12L 1.33333,
	                            -10.6667L 2.66667,-10.6667L 2.66667,-9.3334L 4,
	                            -9.3334L 4,-8.00001L 5.33333,-8.00001L 5.33333,
	                            -6.66667L 6.66667,-6.66667L 6.66667,-5.33334L 5.33333,
	                            -5.33334L 5.33333,-4.00001L 4,-4.00001L 4,-2.66673L 2.66667,
	                            -2.66673L 2.66667,-1.33341L 1.33333,-1.33341L 1.33333,
	                           0L -2.54313e-006,0L -2.54313e-006,-12 Z "
	                           Fill="#000000"
	                           RenderTransformOrigin="0.5,0.5"
	                           Stretch="Fill">
	                        <Path.RenderTransform>
	                            <TransformGroup>
	                                <RotateTransform Angle="90" />
	                            </TransformGroup>
	                        </Path.RenderTransform>
	                    </Path>
	                </Grid>
	            </ControlTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
```

And here you can see how to set TimePicker IconButtonStyle:



```XAML
	<telerik:RadTimePicker />
```