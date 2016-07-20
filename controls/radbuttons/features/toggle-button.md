---
title: Toggle Button
page_title: Toggle Button
description: Toggle Button
slug: radbuttons-features-toggle-button
tags: toggle,button
published: True
position: 4
---

# Toggle Button

__RadToggleButton__ inherits from the native __ToggleButton__ control and implements the [ICommandSource](https://msdn.microsoft.com/en-us/library/system.windows.input.icommand(v=vs.110).aspx) interface. Because of the inheritance, it has all of the features of the native __ToggleButton__ control has. The __ICommandSource__ implementation allows you to attach commands to the button, which will get executed when it gets clicked.	  

>tip To learn more about the members of the RadToggleButton class you can read {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_radtogglebutton.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/t_telerik_windows_controls_radtogglebutton.html){% endif %}.

>tip You can see how to use ICommand with a button in the [Commands]({%slug radbuttons-features-commands%}) topic.	  

## Instantiating RadToggleButton

You can instantiate __RadToggleButton__ in both XAML and code. Here is an example:		

> RadToggleButton is located in the __Telerik.Windows.Controls.dll__ and in order to use it in your project you have to add a reference to the assembly.{% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}
>Then in XAML you have to declare the namespace: `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __[XAML] Example 1: Definig a button in XAML__
{{region xaml-radbuttons-features-toggle-button_0}}
	<telerik:RadToggleButton Content="Toggle Me!" />
{{endregion}}

#### __[C#] Example 2: Definig a button in code__
{{region cs-radbuttons-features-toggle-button_1}}
	RadToggleButton radToggleButton = new RadToggleButton();
{{endregion}}

#### __[VB.NET] Example 2: Definig a button in code__
{{region vb-radbuttons-features-toggle-button_2}}
	Dim radToggleButton As New RadToggleButton()
{{endregion}}

## Handling the Button Checked Event

To execute some logic when __RadToggleButton__ gets toggled, you have to handle the __Checked__ event.

>tip As any other button __RadToggleButton__ exposes a __Click__ event, too.

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

>important RadToggleButton also exposes Unchecked event that is called when the button is unchecked. The same handling (as with the Checked event) applies for the Unchecked event.

## Three State RadToggleButton

To make __RadToggleButton__ to go into a three state mode you just have to set its __IsThreeState__ property to __True__. Here is an example:		

#### __[XAML] Example 5: Enabling the three-state mode__
{{region xaml-radbuttons-features-toggle-button_6}}
	<telerik:RadToggleButton IsThreeState="True" />
{{endregion}}

## Customizing RadToggleButton

* __IsBackgroundVisible__: this property controls the visibility of the background and the border of __RadToggleButton__ in normal state

* __CornerRadius__: this property controls the __CornerRadius__ of __RadToggleButton__ 		  

## See Also
 * [Button]({%slug radbuttons-features-button%})
 * [Radio Button]({%slug radbutton-features-radio-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Appearance]({%slug radbuttons-features-appearance%})
