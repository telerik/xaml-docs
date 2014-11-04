---
title: Backwards Compatibility
page_title: Backwards Compatibility
description: Backwards Compatibility
slug: radcolorpicker-changes-backward-compatibility
tags: backwards,compatibility
published: True
position: 1
---

# Backwards Compatibility



## Telerik RadColorPicker for SilverlightWPF Q2 2014

__Public Properties removed in Q2:__

* ExpanderButtonStyle

* ColorButtonStyle

## Telerik RadColorPicker for SilverlightWPF Q2 2012

__Public Properties removed in Q2:__

* IsMouseOver

* IsSelected __Public Properties marked as "OBSOLETE" in Q2:__

* ExpanderButtonStyle

* ColorButtonStyle __Changes in Events in Q2__ :

* Click is now RoutedEvent with RoutedEventHandler.

* DropDownClosed is now RoutedEvent with RadRoutedEventHandler.

* DropDownOpened is now RoutedEvent with RadRoutedEventHandler.

* DropDownOpening added which is RoutedEvent with RadRoutedEventHandler __How To Upgrade Your Custom Styles in Q2__

Since the __ExpanderButtonStyle__ and __ColorButtonStyle__ are marked "__Obsolete__" they will be removed in one of our future releases. You can re-organize your project to use the new SplitButtonStyle property and this way the deletion of this properties won't break your application.For example, if you used to have Styles organized like so:

#### XAML
    <Style x:Name="colorButtonStyle" TargetType="Button" >
     ...
    </Style>
    <Style x:Key="expanderButtonStyle" TargetType="ToggleButton" >
    ...
    </Style>
    <telerik:RadColorPicker 
            ColorButtonStyle="{StaticResource colorButtonStyle}"
            ExpanderButtonStyle="{StaticResource expanderButtonStyle}" />
            
            
Now you can re-factor them in the following way:
        	
#### XAML
	<Style x:Name="splitButtonStyle" TargetType="telerik:RadSplitButton">
        <Setter Property="ButtonPartStyle" Value="{StaticResource colorButtonStyle}" />
        <Setter Property="TogglePartStyle" Value="{StaticResource expanderButtonStyle}" />
        ...
	</Style>
	<telerik:RadColorPicker SplitButtonStyle="{StaticResource splitButtonStyle}" />