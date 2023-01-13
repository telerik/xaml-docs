---
title: MaskedTextInput
page_title: MaskedTextInput
description: RadMaskedTextInput represents a control that can be used to restrict the input of text values.
slug: radmaskedinput-features-controls-text
tags: maskedtextinput
published: True
position: 2
---

# MaskedTextInput

__RadMaskedTextInput__ represents a control that can be used to restrict the input of text values.

{% if site.site_name == 'Silverlight' %}
>In order to use the __RadMaskedCurrencyInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__  

>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
{% endif %}

{% if site.site_name == 'WPF' %} 
>In order to use the __RadMaskedTextInput__ control in your projects you have to add references to the following assemblies:
>	- __Telerik.Windows.Controls__
>	- __Telerik.Windows.Controls.Input__
>	- __Telerik.Windows.Data__  

>You can find more info [here](https://docs.telerik.com/devtools/wpf/common-information/installation-installing-dependencies-wpf).
{% endif %}

## Declaratively defined MaskedTextInput

The following example shows how to define the control and set few of its properties.

#### __[XAML] Example 1: Define RadMaskedTextInput in XAML__
{{region xaml-radmaskedinput-features-controls-text_0}}
	<telerik:RadMaskedTextInput EmptyContent="Enter digits"
	                            InputBehavior="Replace"
	                            Mask="a20"
	                            SelectionOnFocus="SelectAll"
	                            TextMode="PlainText"
	                            UpdateValueEvent="LostFocus"
	                            Value="Sample Text" />
{{endregion}}

#### Figure 2: RadMaskedTextInput example
![{{ site.framework_name }} RadMaskedInput RadMaskedTextInput example](images/radmaskedinput_textinput_default.png)

## Data Binding

RadMaskedTextInput's __Value__ property is of type __string__ and you have to bind it to ViewModel's property of type __string__. 

>important Binding to __object__ is not support and may result in unpredictable behavior.

#### __[XAML] Example 2: Define the view model__
{{region radmaskedinput-features-controls-text_1}}
	public class ViewModel : ViewModelBase
    {
        private string text;

        public ViewModel()
        {
            this.Text = "Sample Text";
        }

        public string Text
        {
            get { return this.text; }
            set
            {
                if (this.text != value)
                {
                    this.text = value;
                    this.OnPropertyChanged("Text");
                }
            }
        }
    }
{{endregion}}

#### __[C#] Example 3: Binding the Value property__
{{region radmaskedinput-features-controls-text_2}}
	<telerik:RadMaskedTextInput EmptyContent="Enter digits"
	                            InputBehavior="Replace"
	                            Mask="a20"
	                            SelectionOnFocus="SelectAll"
	                            TextMode="PlainText"
	                            UpdateValueEvent="LostFocus"
	                            Value="{Binding Text}" />
{{endregion}}

## Setting the Value Mode

The value mode allows you to set the behavior of the Value property in a mask scenario (when the Mask property is set). By default the Value property holds the characters without including the placeholders and the literals defined in the mask. You can alter this and allow the value to hold also literal and placeholders by setting the __ValueMode__ property of the control.

Read more about this in the [Value Mode]({%slug radmaskedinput-features-value-mode%}) article.

## FormatString

You can format the entered value using the __FormatString__ property of the RadMaskedTextInput control. The property works with the standard .NET string formats. The format will be applied only when the control is unfocused.

#### __[XAML] Example 4: Setting the FormatString property__
{{region xaml-radmaskedinput-features-controls-text_3}}
	<telerik:RadMaskedTextInput Value="Adam"
								Mask="a4" 
	                            FormatString="{}UserName: {0} NickName: {0}"/>
{{endregion}}

#### Figure 2: Showing the text value when the control is focused
![{{ site.framework_name }} RadMaskedInput Showing the text value when the control is focused](images/radmaskedinput_textinput_format_string_focused.png)

#### Figure 3: Showing the text value when the control is unfocused
![{{ site.framework_name }} RadMaskedInput Showing the text value when the control is unfocused](images/radmaskedinput_textinput_format_string.png)


## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})
 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})
 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})
 * [Common Features]({%slug radmaskedinput-features-common%})
