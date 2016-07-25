---
title: MaskedTextInput
page_title: MaskedTextInput
description: MaskedTextInput
slug: radmaskedinput-features-controls-text
tags: maskedtextinput
published: True
position: 2
---

# MaskedTextInput

The __RadMaskedTextInput__ represents the basic control that can be used to restrict the input of text values.

{% if site.site_name == 'Silverlight' %}
>In order to use the __RadMaskedTextInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__  

>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
{% endif %}

{% if site.site_name == 'WPF' %} 
>In order to use the __RadMaskedTextInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__
>	- __Telerik.Windows.Data__  

>You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
{% endif %}

Here is a simple definition of a __RadMaskedTextInput__ control:

#### __[XAML] Example 1: Define RadMaskedTextInput in XAML__
{{region xaml-radmaskedinput-features-controls-text_0}}
	<telerik:RadMaskedTextInput x:Name="radMaskedTextInput" 
	                            Width="200"
	                            Margin="20 20 20 10"
	                            EmptyContent="Enter digits"
	                            InputBehavior="Replace"
	                            Mask="a20"
	                            SelectionOnFocus="SelectAll"
	                            TextMode="PlainText"
	                            UpdateValueEvent="LostFocus"
	                            Value="Sample Text" />
{{endregion}}

![](images/radmaskedinput_textinput_default.png)

You can further restrict the user input by setting the __FormatString__ property. 		

#### __[XAML] Example 2: Setting the FormatString property__
{{region xaml-radmaskedinput-features-controls-text_1}}
	<telerik:RadMaskedTextInput HorizontalAlignment="Center"
	                            Value="Adam"
	                            FormatString="{}UserName: {0} NickName: {0}"
	                            Mask="a4" />
{{endregion}}

![](images/radmaskedinput_textinput_format_string_focused.png)

![](images/radmaskedinput_textinput_format_string.png)

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})
 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})
 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})
 * [Common Features]({%slug radmaskedinput-features-common%})