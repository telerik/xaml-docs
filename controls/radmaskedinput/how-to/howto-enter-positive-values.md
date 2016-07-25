---
title: How to Enter Only Positive Numbers
page_title: How to Enter Only Positive Numbers
description: How to Enter Only Positive Numbers
slug: radmaskedinput-howto-enter-positive-values
tags: how,to,enter,only,positive,numbers
published: True
position: 2
---

# How to Enter Only Positive Numbers

You can control the values entered in the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls to allow only positive input.

You can use the __MaskedInputExtensions.Minimum__ attached property to define 0 as the minimum value that can be entered in the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls. This way you will restrict the user to only entering positive values in the controls.

#### __[XAML] Example 1:  Setting the MaskedInputExtensions.Minimum attached property__
{{region xaml-radmaskedinput-howto-enter-positive-numbers-0}}
	<UserControl x:Class="MaskedInputSample.MainPage" 
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	             xmlns:maskedInput="clr-namespace:Telerik.Windows.Controls.MaskedInput;assembly=Telerik.Windows.Controls.Input"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             d:DesignHeight="300"
	             d:DesignWidth="400"
	             mc:Ignorable="d">
	    <telerik:RadMaskedNumericInput maskedInput:MaskedInputExtensions.Minimum="0" />
	</UserControl>
{{endregion}}

You can find more information about the __MaskedInputExtensions__ class properties in the [MaskedInputExtensions]({%slug radmaskedinput-features-extensions%}) article.

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [Common Features]({%slug radmaskedinput-features-common%})
 * [How to Define Consecutive Input]({%slug radmaskedinput-howto-allow-skip-placeholders%})
 * [How to Remove the Thousands Separator]({%slug radmaskedinput-howto-number-groups-separator%})