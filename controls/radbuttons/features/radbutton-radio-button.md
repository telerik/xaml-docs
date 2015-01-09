---
title: Radio Button
page_title: Radio Button
description: Radio Button
slug: radbutton-features-radio-button
tags: radio,button
published: True
position: 2
---

# Radio Button

The __RadRadioButton__ control inherits from the __RadioButton__ control and implements the __ICommandSource__ interface. Because of the inheritance it has all of the features that the standard __RadioButton__ control has. The __ICommandSource__ implementation allows you to attach commands to the button, that will be executed when the __RadRadioButton__ is clicked.	  

>tip To learn more about the members of the __RadRadioButton__ class you can read {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_radradiobutton.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_radradiobutton.html){% endif %}.

>tip You can see how to use an ICommand with a button in the [Commands]({%slug radbuttons-features-commands%}) topic.	  

## Instantiating RadButton

You can instantiate your __RadRadioButton__ in both XAML and code. Here is an example:
		

>The __RadRadioButton__ control is located in the __Telerik.Windows.Controls.dll__ and in order to use it in your project you have to add a reference to the assembly. {% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %} 
> Then in XAML you have to declare the namespace: `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __XAML__
{{region radbutton-features-radio-button_0}}
	<telerik:RadRadioButton Content="Radio Item" />
{{endregion}}

#### __C#__
{{region radbutton-features-radio-button_1}}
	RadRadioButton radRadioButton = new RadRadioButton(){Content = "Radio Item"};
{{endregion}}

#### __VB.NET__
{{region radbutton-features-radio-button_2}}
	Dim radRadioButton As New RadRadioButton()With {.Content = "Radio Item"}
{{endregion}}

## Handling the Button Checked Event

To execute some logic when the __RadRadioButton__ gets checked, you have to handle the __Checked__ event.	

>tip As any other button the __RadRadioButton__ exposes a __Click__ event as well.		

Here is an example of handling the __Checked__ event of a button.		

#### __XAML__
{{region radbutton-features-radio-button_3}}
	<telerik:RadRadioButton Content="Radio Item" Checked="RadRadioButton_Checked" />
{{endregion}}

#### __C#__
{{region radbutton-features-radio-button_4}}
	private void RadRadioButton_Checked( object sender, RoutedEventArgs e )
	{
	    //implement your logic here
	}
{{endregion}}

#### __VB.NET__
{{region radbutton-features-radio-button_5}}
	Private Sub RadRadioButton_Checked(sender As Object, e As RoutedEventArgs)
	 'implement your logic here'
	End Sub
{{endregion}}

>important The RadRadioButton also exposes Unchecked event that is called when the button is unchecked. The same handling (as with the Checked event) applies for the Unchecked event.

## Grouping RadRadioButtons

 By grouping the __RadRadioButtons__ the user will be allowed to check only one button in the group. In order to group several __RadRadioButtons__ you just have to place them in the same layout panel. Here is an example:		

#### __XAML__
{{region radbutton-features-radio-button_6}}
	<StackPanel>
	    <telerik:RadRadioButton Content="Item 1.1" />
	    <telerik:RadRadioButton Content="Item 1.2" />
	</StackPanel>
	<StackPanel>
	    <telerik:RadRadioButton Content="Item 2.1" />
	    <telerik:RadRadioButton Content="Item 2.2" />
	</StackPanel>
{{endregion}}

The above code creates two groups of __RadRadioButtons__.		

## Customizing the RadRadioButton

* __IsBackgroundVisible__ - this property is of type bool and it controls the visibility of the background and the border of the __RadRadioButton__ control in normal state		  

# See Also
 * [Button]({%slug radbuttons-features-button%})
 * [Toggle Button]({%slug radbuttons-features-toggle-button%})
 * [Commands]({%slug radbuttons-features-commands%})
 * [Appearance]({%slug radbuttons-features-appearance%})