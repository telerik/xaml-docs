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



The __RadToggleButton__ control inherits from the __ToggleButton__ control and implements the __ICommandSource__ interface. Because of the inheritance it has all of the features that the standard __ToggleButton__ control has. The __ICommandSource__ implementation allows you to attach commands to the button, which will get executed when it gets clicked.
	  

To learn more about the members of the __RadToggleButton__ class you can read
		{% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_radtogglebutton.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_radtogglebutton.html){% endif %}.
		To learn how to use it with commands you should read the [Commands]({%slug radbuttons-features-commands%}) topic.
	  

## Instantiating RadToggleButton

You can instantiate your __RadToggleButton__ in both XAML and code. Here is an example:
		

>


			  The __RadToggleButton__ control is located in the __Telerik.Windows.Controls.dll__
			  and in order to use it in your project you have to add a reference to the assembly.
			  {% if site.site_name == 'WPF' %}
				You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
			  {% endif %}{% if site.site_name == 'Silverlight' %}
				You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
			  {% endif %}


			  Then in XAML you have to declare the namespace:
			  __xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"__

#### __XAML__

{{region radbuttons-features-toggle-button_0}}
	<telerik:RadToggleButton Content="Toggle Me!" />
	{{endregion}}



#### __C#__

{{region radbuttons-features-toggle-button_1}}
	RadToggleButton radToggleButton = new RadToggleButton();
	{{endregion}}



#### __VB.NET__

{{region radbuttons-features-toggle-button_2}}
	Dim radToggleButton As New RadToggleButton()
	{{endregion}}



## Handling the Button Checked Event


		  To execute some logic when the __RadToggleButton__ gets toggled, you have to handle the __Checked__ event:
		

>tip
		  As any other button the __RadToggleButton__ exposes a __Click__ event, too.
		


		  Here is an example of handling the __Checked__event of a button.
		

#### __XAML__

{{region radbuttons-features-toggle-button_3}}
	<telerik:RadToggleButton Content="Toggle Me!" Checked="RadToggleButton_Checked" />
	{{endregion}}



#### __C#__

{{region radbuttons-features-toggle-button_4}}
	private void RadToggleButton_Checked( object sender, RoutedEventArgs e )
	{
	    //implement your logic here
	}
	{{endregion}}



#### __VB.NET__

{{region radbuttons-features-toggle-button_5}}
	Private Sub RadToggleButton_Checked(sender As Object, e As RoutedEventArgs)
	 'implement your logic here
	End Sub
	{{endregion}}



## Three State RadToggleButton


		  To make the __RadToggleButton__ go into a three state mode you just have to set its __IsThreeState__ property to __True__. Here is an example:
		

#### __XAML__

{{region radbuttons-features-toggle-button_6}}
	<telerik:RadToggleButton IsThreeState="True" />
	{{endregion}}



## Customizing the RadToggleButton

* __IsBackgroundVisible__ - this property controls the visibility of the background and the border of the __RadToggleButton__control in normal state
		  

* __CornerRadius -__this property controls the __CornerRadius__ of the __RadToggleButton__control
		  

# See Also

 * [Button]({%slug radbuttons-features-button%})

 * [Radio Button]({%slug radbutton-features-radio-button%})

 * [Commands]({%slug radbuttons-features-commands%})

 * [Appearance]({%slug radbuttons-features-appearance%})
