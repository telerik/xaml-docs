---
title: Toggle Switch Button
page_title: Toggle Switch Button
description: Check our "Toggle Switch Button" documentation article for the RadButtons WPF control.
slug: radbuttons-features-toggle-switch-button
tags: toggle,button,switch
published: True
position: 4
---

# Toggle Switch Button

__RadToggleSwitchButton__ is a control design to display two exclusive choices. The control is represented by a track in which the thumb is smoothly sliding left and right. The two states content can be customized along with their position. The button derives from our __RadToggleButton__ control. Because of the inheritance, it has all of the features of the __RadToggleButton__ control. 

>tip You can see how to use ICommand with a button in the [Commands]({%slug radbuttons-features-commands%}) topic.	  

#### __Figure 1: Toggle Switch Button__
![](images/radbuttons-features-toggle-switch-button-0.png)

## Defining RadToggleSwitchButton

You can instantiate __RadToggleSwitchButton__ in both XAML and code as shown in Examples 1 and 2.

#### __[XAML] Example 1: Defining a toggle switch button in XAML__
{{region xaml-radbuttons-features-toggle-switch-button_0}}
	<telerik:RadToggleSwitchButton ContentPosition="Both" CheckedContent="ON" UncheckedContent="OFF" />
{{endregion}}

#### __[C#] Example 2: Defining a toggle switch button in code__
{{region cs-radbuttons-features-toggle-switch-button_1}}
	RadToggleSwitchButton radToggleSwitchButton = new RadToggleSwitchButton() { CheckedContent = "ON", UncheckedContent = "OFF" };
{{endregion}}

#### __[VB.NET] Example 2: Defining a toggle switch button in code__
{{region vb-radbuttons-features-toggle-switch-button_2}}
	Dim radToggleSwitchButton As New RadToggleSwitchButton() With { 
	    .CheckedContent = "ON" 
		.UncheckedContent = "OFF"
	}
{{endregion}}

## Content Position

The RadToggleSwitchButton allows you to control the position of its CheckedContent and UncheckedContent. You can do that using its __ContentPosition__ property. This property is an enumeration of type __SwitchButtonContentPosition__ and exposes the following values.

* __Both__	
* __Right (default)__
* __Left__ 

#### __Figure 2: ContentPosition property__
![](images/radbuttons-features-toggle-switch-button-1.png)
 
## Enable Three-State Mode

To make __RadToggleSwitchButton__ to go into a three-state mode you can just set its __IsThreeState__ property to __True__.

#### __[XAML] Example 3: Enabling the three-state mode__
{{region xaml-radbuttons-features-toggle-switch-button_6}}
	<telerik:RadToggleSwitchButton IsThreeState="True" ContentPosition="Both" CheckedContent="ON" UncheckedContent="OFF" />
{{endregion}}

## RadToggleSwitchButton Properties

The ToggleSwitchButton expose several properties which can be used to customized its appearance.

### __CheckedContent__ and __UncheckedContent__

Nevertheless the RadToggleSwitchButton derives from RadToggleButton, the Content property here is not respected. Two new properties are created. These properties set the check and uncheck content state of the ToggleSwitchButton. Their position depends on the __ContentPosition__ property.

#### __[XAML] Example 4: Setting Check/UncheckContent property__
{{region xaml-radbuttons-features-toggle-switch-button_6}}
	<telerik:RadToggleSwitchButton CheckedContent="Red" UncheckedContent="Green" />
{{endregion}}

### __TrackHeight__ and __TrackWidth__

These properties customize the size of the ToggleSwitchButton track.

#### __[XAML] Example 5: Setting Check/UncheckContent property__
{{region xaml-radbuttons-features-toggle-switch-button_6}}
	<telerik:RadToggleSwitchButton UncheckedContent="Red" CheckedContent="Green" ContentPosition="Both" TrackHeight="30" TrackWidth="90" />
{{endregion}}

#### __Figure 3: Change Track Height/Width__
![](images/radbuttons-features-toggle-switch-button-2.png)

### __ThumbHeight__ and __ThumbWidth__

These properties customize the size of the ToggleSwitchButton track.

#### __[XAML] Example 6: Setting Thumb Height/Width property__
{{region xaml-radbuttons-features-toggle-switch-button_6}}
	<telerik:RadToggleSwitchButton UncheckedContent="Red" CheckedContent="Green" ContentPosition="Both" TrackHeight="30" TrackWidth="90" ThumbHeight="15" ThumbWidth="50"/>
{{endregion}}

#### __Figure 4: Change Thumb Height/Width__
![](images/radbuttons-features-toggle-switch-button-3.png)

## See Also 
 * [Button]({%slug radbuttons-features-button%})
 * [Radio Button]({%slug radbutton-features-radio-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Events]({%slug radbuttons-events%})
 * [Appearance]({%slug radbuttons-features-appearance%})
 * {% if site.site_name == 'Silverlight' %}[RadToggleButton API](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_radtogglebutton.html){% endif %}{% if site.site_name == 'WPF' %}[RadToggleButton API](http://www.telerik.com/help/wpf/t_telerik_windows_controls_radtogglebutton.html){% endif %}.
