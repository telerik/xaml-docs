---
title: MaskedDateTimeInput
page_title: MaskedDateTimeInput
description: MaskedDateTimeInput
slug: radmaskedinput-features-controls-datetime
tags: maskeddatetimeinput
published: True
position: 3
---

# MaskedDateTimeInput

The __RadMaskedDateTimeInput__ represents the basic control that can be used to restrict the input of DateTime values.

{% if site.site_name == 'Silverlight' %}
>In order to use the __RadMaskedDateTimeInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__  

>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
{% endif %}

{% if site.site_name == 'WPF' %} 
>In order to use the __RadMaskedDateTimeInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__
>	- __Telerik.Windows.Data__  

>You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
{% endif %}

Here is a simple definition of a __RadMaskedDateTimeInput__ control:

#### __XAML__
{{region radmaskedinput-features-controls-datetime_0}}
	<telerik:RadMaskedDateTimeInput x:Name="radMaskedDateTimeInput" 
	                                Width="200"
	                                Margin="20 20 20 10"
	                                Culture="en-US"
	                                EmptyContent="Enter digits"
	                                InputBehavior="Replace"
	                                Mask="dd-MM-yyyy"
	                                SelectionOnFocus="SelectAll"
	                                TextMode="PlainText"
	                                UpdateValueEvent="LostFocus" />
{{endregion}}

![](images/radmaskedinput_datetimeinput_default.png)

You can further restrict the user input by setting the __FormatString__ property.

#### __XAML__
{{region radmaskedinput-features-controls-datetime_1}}
	<telerik:RadMaskedDateTimeInput x:Name="radMaskedDateTimeInput"                       
	                                HorizontalAlignment="Center"
	                                Culture="en-US"
	                                FormatString="{}Day: {0:dd}, Month: {0:MM}, Year: {0:yyyy}"
	                                InputBehavior="Replace"
	                                Mask="dd-MM-yyyy"
	                                SelectionOnFocus="SelectAll"
	                                TextMode="PlainText"
	                                UpdateValueEvent="LostFocus" />
{{endregion}}

![](images/radmaskedinput_datetimeinput_format_string.png)

# See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})
 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})
 * [MaskedTextInput]({%slug radmaskedinput-features-controls-text%})
 * [Common Features]({%slug radmaskedinput-features-common%})