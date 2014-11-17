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



## 

The __RadMaskedTextInput__ represents the basic control that can be used to restrict the input of currency values.

>{% if site.site_name == 'Silverlight' %}In order to use the __RadMaskedCurrencyInput__ control in your projects you have to add references to the following assemblies:<br/>* __Telerik.Windows.Controls__<br/>* __Telerik.Windows.Controls.Input__<br/>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}{% if site.site_name == 'WPF' %} In order to use the __RadMaskedCurrencyInput__ control in your projects you have to add references tothe following assemblies:<br/>* __Telerik.Windows.Controls__<br/>* __Telerik.Windows.Controls.Input__<br/>* __Telerik.Windows.Data__<br/>You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}

Here is a simple definition of a __RadMaskedTextInput__ control:

#### __XAML__

{{region radmaskedinput-features-controls-text_0}}
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
		

#### __XAML__

{{region radmaskedinput-features-controls-text_1}}
	<telerik:RadMaskedTextInput HorizontalAlignment="Center"
	                            Value="Adam"
	                            FormatString="{}UserName: {0} NickName: {0}"
	                            Mask="a4" />
	{{endregion}}



![](images/radmaskedinput_textinput_format_string_focused.png)

![](images/radmaskedinput_textinput_format_string.png)

# See Also

 * [Getting Started]({%slug radmaskedinput-getting-started%})

 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})

 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})

 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})

 * [Common Features]({%slug radmaskedinput-features-common%})
