---
title: Toggle Button
page_title: Toggle Button
description: Check our &quot;Toggle Button&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-features-toggle-button
tags: toggle,button
published: True
position: 4
---

# Toggle Button

__RadToggleButton__ inherits from the native __ToggleButton__ control and implements the [ICommandSource](https://msdn.microsoft.com/en-us/library/system.windows.input.icommand(v=vs.110).aspx) interface. Because of the inheritance, it has all of the features of the native __ToggleButton__ control. The __ICommandSource__ implementation allows you to attach commands to the button, which will get executed when it gets clicked.	  

>tip You can see how to use ICommand with a button in the [Commands]({%slug radbuttons-features-commands%}) topic.	  

#### __Figure 1: Toggle button__
![{{ site.framework_name }} RadButtons Toggle button](images/radbuttons-features-toggle-button-0.png)

## Defining RadToggleButton

You can instantiate __RadToggleButton__ in both XAML and code as shown in Examples 1 and 2.

__Example 1: Defining a button in XAML__
<snippet id='radbuttons-features-toggle-button-example_1_defining_a_button_in_xaml-xaml' />

__Example 2: Defining a button in code__
<snippet id='radbuttons-features-toggle-button-example_2_defining_a_button_in_code-cs' />
<snippet id='radbuttons-features-toggle-button-example_2_defining_a_button_in_code-vb' />


## Enable Three State Mode

To make __RadToggleButton__ to go into a three state mode you can just set its __IsThreeState__ property to __True__.

__Example 5: Enabling the three-state mode__
<snippet id='radbuttons-features-toggle-button-example_5_enabling_the_three_state_mode-xaml' />

## Toggle Events

The button provides a set of events that are fired when you toggle it. 

* __Checked__: This event is fired when the button is toggled on.
* __Unchecked__: This event is fired when the button is toggled off.
* __Activate__: This event is fired when the button is toggled on or off.

>tip As any other button, RadToggleButton exposes a __Click__ event, too. Additionally, the control has __PreviewClick__ event.

The toggle state of the button can be manually controlled via its __IsChecked__ property.

Here is an example of handling the __Checked__ event of a button.

__Example 3: Subscribing to the Checked event__
<snippet id='radbuttons-features-toggle-button-example_3_subscribing_to_the_checked_event-xaml' />

__Example 4: Defining a Checked event handler__
<snippet id='radbuttons-features-toggle-button-example_4_defining_a_checked_event_handler-cs' />
<snippet id='radbuttons-features-toggle-button-example_4_defining_a_checked_event_handler-vb' />


## Customizing RadToggleButton

* __IsBackgroundVisible__: This property controls the visibility of the background and the border of the button when in normal state.
	#### __Figure 2: Toggle button with hidden background__
	![{{ site.framework_name }} RadButtons Toggle button with hidden background](images/radbuttons-features-toggle-button-1.png)

* __CornerRadius__: This property controls the corner radius of the button.
	#### __Figure 3: Toggle button with its CornerRadius set to 15__
	![{{ site.framework_name }} RadButtons Toggle button with its CornerRadius set to 15](images/radbuttons-features-toggle-button-2.png)

## See Also 
 * [Button]({%slug radbuttons-features-button%})
 * [Radio Button]({%slug radbutton-features-radio-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Events]({%slug radbuttons-events%})  
