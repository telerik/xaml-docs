---
title: Toggle Button
page_title: Toggle Button
description: Check our &quot;Toggle Button&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-features-toggle-button
tags: toggle,button
published: True
position: 4
---

# {{ site.framework_name }} RadButtons Toggle Button

__RadToggleButton__ inherits from the native __ToggleButton__ control and implements the [ICommandSource](https://msdn.microsoft.com/en-us/library/system.windows.input.icommand(v=vs.110).aspx) interface. Because of the inheritance, it has all of the features of the native __ToggleButton__ control. The __ICommandSource__ implementation allows you to attach commands to the button, which will get executed when it gets clicked.	  

>tip You can see how to use ICommand with a button in the [Commands]({%slug radbuttons-features-commands%}) topic.	  

#### __Figure 1: Toggle button__
![{{ site.framework_name }} RadButtons Toggle button](images/radbuttons-features-toggle-button-0.png)

## Defining RadToggleButton

You can instantiate __RadToggleButton__ in both XAML and code as shown in Examples 1 and 2.

#### __[XAML] Example 1: Defining a button in XAML__
{{region xaml-radbuttons-features-toggle-button_0}}
	<telerik:RadToggleButton Content="Toggle Me!" />
{{endregion}}

#### __[C#] Example 2: Defining a button in code__
{{region cs-radbuttons-features-toggle-button_1}}
	RadToggleButton radToggleButton = new RadToggleButton() { Content = "Toggle Me!" };
{{endregion}}

#### __[VB.NET] Example 2: Defining a button in code__
{{region vb-radbuttons-features-toggle-button_2}}
	Dim radToggleButton As New RadToggleButton() With { _
	    .Content = "Toggle Me!" _
	}
{{endregion}}

## Enable Three State Mode

To make __RadToggleButton__ to go into a three state mode you can just set its __IsThreeState__ property to __True__.

#### __[XAML] Example 5: Enabling the three-state mode__
{{region xaml-radbuttons-features-toggle-button_6}}
	<telerik:RadToggleButton IsThreeState="True" />
{{endregion}}

## Toggle Events

The button provides a set of events that are fired when you toggle it. 

* __Checked__: This event is fired when the button is toggled on.
* __Unchecked__: This event is fired when the button is toggled off.
* __Activate__: This event is fired when the button is toggled on or off.

>tip As any other button, RadToggleButton exposes a __Click__ event, too. Additionally, the control has __PreviewClick__ event.

The toggle state of the button can be manually controlled via its __IsChecked__ property.

Here is an example of handling the __Checked__ event of a button.

#### __[XAML] Example 3: Subscribing to the Checked event__
{{region xaml-radbuttons-features-toggle-button_3}}
	<telerik:RadToggleButton Content="Toggle Me!" Checked="RadToggleButton_Checked" />
{{endregion}}

#### __[C#] Example 4: Defining a Checked event handler__
{{region cs-radbuttons-features-toggle-button_4}}
	private void RadToggleButton_Checked(object sender, RoutedEventArgs e)
	{
	    //implement your logic here
	}
{{endregion}}

#### __[VB.NET] Example 4: Defining a Checked event handler__
{{region vb-radbuttons-features-toggle-button_5}}
	Private Sub RadToggleButton_Checked(sender As Object, e As RoutedEventArgs)
	    'implement your logic here'
	End Sub
{{endregion}}

## Customizing RadToggleButton

* __IsBackgroundVisible__: This property controls the visibility of the background and the border of the button when in normal state.
	#### __Figure 2: Toggle button with hidden background__	![{{ site.framework_name }} RadButtons Toggle button with hidden background](images/radbuttons-features-toggle-button-1.png)

* __CornerRadius__: This property controls the corner radius of the button.
	#### __Figure 3: Toggle button with its CornerRadius set to 15__	![{{ site.framework_name }} RadButtons Toggle button with its CornerRadius set to 15](images/radbuttons-features-toggle-button-2.png)

## See Also 
 * [Button]({%slug radbuttons-features-button%})
 * [Radio Button]({%slug radbutton-features-radio-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Events]({%slug radbuttons-events%})
 * [Appearance]({%slug radbuttons-features-appearance%})
 * {% if site.site_name == 'Silverlight' %}[RadToggleButton API](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_radtogglebutton.html){% endif %}{% if site.site_name == 'WPF' %}[RadToggleButton API](http://www.telerik.com/help/wpf/t_telerik_windows_controls_radtogglebutton.html){% endif %}.
