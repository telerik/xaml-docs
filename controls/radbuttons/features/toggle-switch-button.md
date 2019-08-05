---
title: Toggle Switch Button
page_title: Toggle Switch Button
description: Toggle Switch Button
slug: radbuttons-features-toggle-switch-button
tags: toggle,button,switch
published: True
position: 4
---

# Toggle Switch Button

__RadToggleSwitchButton__ inherits from our __RadToggleButton__ control which implements the [ICommandSource](https://msdn.microsoft.com/en-us/library/system.windows.input.icommand(v=vs.110).aspx) interface. Because of the inheritance, it has all of the features of the __RadToggleButton__ control. The __ICommandSource__ implementation allows you to attach commands to the button, which will get executed when it gets clicked.	  

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

Create image after fix.
 
## Enable Three-State Mode

To make __RadToggleSwitchButton__ to go into a three-state mode you can just set its __IsThreeState__ property to __True__.

#### __[XAML] Example 5: Enabling the three-state mode__
{{region xaml-radbuttons-features-toggle-switch-button_6}}
	<telerik:RadToggleSwitchButton IsThreeState="True" ContentPosition="Both" CheckedContent="ON" UncheckedContent="OFF" />
{{endregion}}

## Toggle Events

The button provides a set of events that are fired when you toggle it. 

* __Checked__: This event is fired when the button is switched on.
* __Unchecked__: This event is fired when the button is switched off.
* __Activate__: This event is fired when the button is switch on or off.

>tip As any other button, RadToggleSwitchButton exposes a __Click__ event, too. Additionally, the control has __PreviewClick__ event.

The toggle state of the button can be manually controlled via its __IsChecked__ property.

Here is an example of handling the __Checked__ event of a button.

#### __[XAML] Example 3: Subscribing to the Checked event__
{{region xaml-radbuttons-features-toggle-button_3}}
	<telerik:RadToggleSwitchButton ContentPosition="Both" CheckedContent="ON" UncheckedContent="OFF" Checked="RadToggleSwitchButton_Checked" />
{{endregion}}

#### __[C#] Example 4: Defining a Checked event handler__
{{region cs-radbuttons-features-toggle-button_4}}
	private void RadToggleSwitchButton_Checked(object sender, RoutedEventArgs e)
	{
	    //implement your logic here
	}
{{endregion}}

#### __[VB.NET] Example 4: Defining a Checked event handler__
{{region vb-radbuttons-features-toggle-button_5}}
	Private Sub RadToggleSwitchButton_Checked(sender As Object, e As RoutedEventArgs)
	    'implement your logic here'
	End Sub
{{endregion}}

## RadToggleSwitchButton Properties

* __CheckedContent__: This property controls the check content of the button.
* __UncheckedContent__: This property controls the uncheck content of the button.
* __TrackHeight__: This property controls the height of the track.
* __TrackWidth__: This property controls the width of the track.
* __ThumbHeight__: This property controls the height of the thumb.
* __ThumbWidth__: This property controls the width of the thumb.

## See Also 
 * [Button]({%slug radbuttons-features-button%})
 * [Radio Button]({%slug radbutton-features-radio-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Events]({%slug radbuttons-events%})
 * [Appearance]({%slug radbuttons-features-appearance%})
 * {% if site.site_name == 'Silverlight' %}[RadToggleButton API](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_radtogglebutton.html){% endif %}{% if site.site_name == 'WPF' %}[RadToggleButton API](http://www.telerik.com/help/wpf/t_telerik_windows_controls_radtogglebutton.html){% endif %}.
