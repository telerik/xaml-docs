---
title: Button
page_title: Button
description: Button
slug: radbuttons-features-button
tags: button
published: True
position: 0
---

# Button

The __RadButton__ control inherits from the __Button__ control and implements the __ICommandSource__ interface. Because of the inheritance it has all of the features that the standard __Button__ control has. Moreover, the __ICommandSource__ implementation allows you to attach commands to the button, which will get executed when it gets clicked.	  

To learn more about the members of the __RadButton__ class, you can read {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_radbutton.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_radbutton.html){% endif %}.

To learn how to use it with commands you should read the [Commands]({%slug radbuttons-features-commands%}) topic.	  

## Instantiating RadButton

You can instantiate your __RadButton__ in both XAML and code. Here is an example:		

> The __RadButton__ control is located in the __Telerik.Windows.Controls.dll__ and in order to use it in your project you have to add a reference to the assembly. {% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %} <br/> Then in XAML you have to declare the namespace: `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __XAML__
{{region radbuttons-features-button_0}}
	<telerik:RadButton Content="Click Me!" />
{{endregion}}

#### __C#__
{{region radbuttons-features-button_1}}
	RadButton radButton = new RadButton(){Content = "Click Me!"};
{{endregion}}

#### __VB.NET__
{{region radbuttons-features-button_2}}
	Dim _radButton As New RadButton() With {.Content = "Click Me!"}
{{endregion}}

## Handling the Button Click

If you want to implement custom logic to be executed when the button is clicked, you can either:

* handle the __Click__ event.		  

or

* use __Commands__.		  

>tip You can see how to use commands in the [Commands]({%slug radbuttons-features-commands%}) article.
		
Here is an example of handling the __Click__ event of a button.		

#### __XAML__
{{region radbuttons-features-button_3}}
	<telerik:RadButton Content="Click Me!" Click="RadButton_Click" />
{{endregion}}

#### __C#__
{{region radbuttons-features-button_4}}
	private void RadButton_Click( object sender, RoutedEventArgs e )
	{
	    //implement your logic here
	}
{{endregion}}


#### __VB.NET__

{{region radbuttons-features-button_5}}
	Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
	 'implement your logic here'
	End Sub
{{endregion}}

## Customizing the RadButton

* __IsBackgroundVisible__ - this property is of type bool and it controls the visibility of the background and the border of the __RadButton__ control in normal state		  

* __CornerRadius__ - this property is of type __CornerRadius__ and it controls the __CornerRadius__ of the __RadButton__ control		  

# See Also
 * [DropDown Button]({%slug radbuttons-features-dropdown-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Appearance]({%slug radbuttons-features-appearance%})
 * [Toggle Button]({%slug radbuttons-features-toggle-button%})