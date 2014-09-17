---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radmaskedinput-getting-started
tags: getting,started
published: True
position: 4
---

# Getting Started



The __RadMaskedInput__ controls use a mask to distinguish between proper and improper user input. The __RadMaskedInput__ controls are enhanced TextBox controls that support a declarative syntax for accepting or rejecting user input. Using the __Mask__ property, you can specify the following input without writing any custom validation logic in your application:
			

* Required input characters. 

* Optional input characters. 

* 
					The type of input expected at a given position in the mask; for example, a digit, or an alphabetic or alphanumeric character.
				

* 
					Mask literals, or characters that should appear directly in the __RadMaskedInput__ control; for example, the hyphens (-) in a phone number, or the currency symbol in a price.
				

When a __RadMaskedInput__ control is displayed at run time, it represents the mask as a series of prompt characters and optional literal characters. Each editable mask position, representing a required or optional input, is shown with a single placeholder character. For example, the number sign (#) is used as a placeholder for a numeric character input. You can use the [Placeholder]({%slug radmaskedinput-features-placeholder%}) property to specify a custom placeholder character. The [EmptyContent]({%slug radmaskedinput-features-watermark%}) property could be used to determine what will be displayed when the user specifies a null value and the control loses its focus.
			

As the user types input into a __RadMaskedInput__ control, valid input characters replace their respective placeholder characters in a sequential fashion. If the user types an invalid input character, no replacement occurs. You can provide your own custom error by handling the __ValueChanging__ or/and __ValueChanged__ events.
			

You can use the __Value__ property, to get the user input without the formatted characters. The __Text__ property will always retreive the user's input formatted according to the __Mask__ and the __TextMode__ property.
			

Masks do not necessarily guarantee that a user's input will represent a valid value for a given type; for example, -9 could be entered for an age in years. You can verify that a user's input represents a valid value by taking advantage of the __RadMaskedInput__ controls' built in support for Silverlight [Validation]({%slug radmaskedinput-features-validation%}).
			

## RadMaskedInput Controls

There are four __RadMaskedInput__ controls that you can use in order to further specify how masks should be interpreted:
				

* __[RadMaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})__ - the control is used to display numeric values. This is why its __Value__ property is of type __double?__.
					

* __[RadMaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})__ - the control is used to display culture-aware currency values. This is why its __Value__ property is of type __decimal?__.
					

* __[RadMaskedTextInput]({%slug radmaskedinput-features-controls-text%})__ - the control is used to display text characters. This is why its __Value__ property is of type __string__.
					

* __[RadMaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})__ - the control is used to display __DateTime__ values. This is why its __Value__ property is of type __System.DateTime?__.
					

## Declare RadMaskedInput controls{% if site.site_name == 'Silverlight' %}

>


								In order to use the __RadMaskedInput__ controls in your projects you have to add references to the following assemblies:
							

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.Input__


								You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
							{% endif %}{% if site.site_name == 'WPF' %}

>




								In order to use the __RadMaskedInput__ controls in your projects you have to add references to the following assemblies:
							

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.Input__

* __Telerik.Windows.Data__


								You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
							{% endif %}


					After adding references to the aforementioned dlls, you can declare a new __RadMaskedInput__ control as any normal {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} control.
				

#### __XAML__

{{region radmaskedinput-getting-started_0}}
	<UserControl .....
	            xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	   <StackPanel x:Name="LayoutRoot"
	         Background="White"> 
	       <telerik:RadMaskedTextInput x:Name="radMaskedTextInput" />
	       <telerik:RadMaskedCurrencyInput x:Name="radMaskedCurrencyInput" />
	       <telerik:RadMaskedDateTimeInput x:Name="radMaskedDateTimeInput" /> 
	       <telerik:RadMaskedNumericInput x:Name="radMaskedNumericInput" /> 
	   </StackPanel>
	</UserControl>
	{{endregion}}





## Set the Mask Property


				  Although each __RadMaskedInput__ component is designed to work with specific type of input, you can further restrict the entered value through the __Mask__ property. 
				

* __Mask__ - gets or sets a string of characters that constrain user input. The __Mask__ property may contain literals and special mask characters. You can use the back slash (\) character to escape any special mask characters so that they are displayed as literals.
					


					The following code example initializes the __RadMaskedDateTimeInput__ to accept a date in a long date format.
				

#### __XAML__

{{region radmaskedinput-getting-started_1}}
	<telerik:RadMaskedDateTimeInput x:Name="radMaskedDateTimeInput" Mask="D"/>
	{{endregion}}



## Change the Default Placeholder Character


					The __Placeholder__ property represents the character displayed in any blank space defined by a __Mask__ character. By default the character is an underscore (_).
				

#### __XAML__

{{region radmaskedinput-getting-started_2}}
	<telerik:RadMaskedCurrencyInput x:Name="radMaskedCurrencyInput" Placeholder="$" />
	{{endregion}}





## Change the Culture


					The __Culture__ property allows you to set the current language and culture from a drop-down list at design-time or to assign a new __CultureInfo__ instance at run-time.
				


					The following code example initializes the __RadMaskedDateTimeInput__ to accept a Bulgarian date in a long date format.
				

#### __XAML__

{{region radmaskedinput-getting-started_3}}
	<telerik:RadMaskedDateTimeInput x:Name="radMaskedDateTimeInput"
	                                Mask="D"
	                                Culture="bg-BG" />
	{{endregion}}



![](images/RadMaskedInput_getting_started_culture_datetime.png)

>tip


						For more information check out the following [Globalization Support]({%slug radmaskedinput-features-globalization%}) topic.
					

## Set Watermark


					You can set a watermark content to the __RadMaskedInput__controls____by using the __EmptyContent__ and the __EmptyContentTemplate__ properties. When the __Value__ of a __RadMaskedTextInput__ control is null or empty the __EmptyContent__ will be displayed.
				

#### __XAML__

{{region radmaskedinput-getting-started_4}}
	<telerik:RadMaskedTextInput Mask="####" EmptyContent="Please Enter Four Digits" />
	{{endregion}}



# See Also

 * [RadMaskedInput Controls Overview]({%slug radmaskedinput-overview%})

 * [Events Overview]({%slug radmaskedinput-events-overview%})

 * [Common Features]({%slug radmaskedinput-features-common%})

 * [MaskTokens]({%slug radmaskedinput-features-mask-tokens%})

 * [Template Structure]({%slug radmaskedinput-styles-templates-template-structure%})
