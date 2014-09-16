---
title: MaskedInputExtensions
page_title: MaskedInputExtensions
description: MaskedInputExtensions
slug: radmaskedinput-features-extensions
tags: maskedinputextensions
publish: True
position: 10
---

# MaskedInputExtensions



The __MaskedInputExtensions__ class allows you to further customize the __MaskedInput__ controls controlled input.
      

## Control the Minimum and Maximum Value

* The __MaskedInputExtensions.Maximum__ property allows you to define the maximum value that can be entered in the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__
              controls.
            

#### __XAML__

{{region radmaskedinput-features-extensions-0}}
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
	    <telerik:RadMaskedNumericInput maskedInput:MaskedInputExtensions.Maximum="1000" />
	</UserControl>
	{{endregion}}



* The __MaskedInputExtensions.Minimum__ property allows you to define the minimum value that can be entered in the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls.You can use it to restrict the user input to positive numbers only.
            

#### __XAML__

{{region radmaskedinput-features-extensions-1}}
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



## Control the Minimum and Maximum Length of the RadMaskedTextInput Input

* The __MaskedInputExtensions.MaxTextLength__ property allows you to define the maximum length of the input entered in the __RadMaskedTextInput__ control.
            

#### __XAML__

{{region radmaskedinput-features-extensions-2}}
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
	    <telerik:RadMaskedTextInput HorizontalAlignment="Center" 
	                                VerticalAlignment="Top"
	                                maskedInput:MaskedInputExtensions.MaxTextLength="8"
	                                Value="sample text" />
	</UserControl>
	{{endregion}}

![radmaskedinput-features-extensions-max Length](images/radmaskedinput_features_extensions_maxLength.png)

* The __MaskedInputExtensions.MinTextLength__ property allows you to define the minimum length of the input entered in the __RadMaskedTextInput__ control.
            

#### __XAML__

{{region radmaskedinput-features-extensions-3}}
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
	    <telerik:RadMaskedTextInput HorizontalAlignment="Center" 
	                                VerticalAlignment="Top"
	                                maskedInput:MaskedInputExtensions.MinTextLength="3"
	                                Value="sample text" />
	</UserControl>
	{{endregion}}



## Use the Culture settings to Configure the Number of Digits after the Decimal Symbol

The __MaskedInputExtensions.UseCultureDigits__ property allows you to configure the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls whether to use the __Culture__ settings to define the number of digits that should be displayed after the decimal symbol.
        

If you set the __MaskedInputExtensions.UseCultureDigits__ property to __True__, the number of digits displayed after the decimal symbol will depend on the culture settings.
        

#### __XAML__

{{region radmaskedinput-features-extensions-4}}
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
	<telerik:RadMaskedNumericInput maskedInput:MaskedInputExtensions.UseCultureDigits="True" />
	</UserControl>
	{{endregion}}



>Please keep in mind that when you set the __RadMaskedInputExtensions.UseCultureDigits__ property to __True__, if you want to define a __Mask__ for the control, it has to be set after the __.UseCultureDigits__ property in the definition of the __RadMaskedInput__ control.
          

## Define the SelectionStart when the Sign of the Value is Changed

When you change the sign of a value entered in the __RadMaskedNumericInput__ and/or the __RadMaskedCurrencyInput__ control you may need to move the cursor at the beginning of the control. You can implement such a scenario using the  __RadMaskedInputExtensions.SelectionStartOnSignChanged__ property.
        

It is an enumeration of type __SelectionStartOnSignChanged__ that exposes the following values:
        

* __Beginning__ - when the sign of the value is changed, the caret is moved at the beggining of the control.
            

* __Unchanged__ - when the sign of the value is changed, the caret isn't moved. This is the default behavior of the __RadMaskedNumericInput__ and __RadMaskedCurrencyInput__ controls.
            

#### __XAML__

{{region radmaskedinput-features-extensions-5}}
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
	    <StackPanel Background="White">
	        <telerik:RadMaskedNumericInput maskedInput:MaskedInputExtensions.SelectionStartOnSignChanged="Beginning" />
	        <telerik:RadMaskedNumericInput maskedInput:MaskedInputExtensions.SelectionStartOnSignChanged="Unchanged" />
	    </StackPanel>
	</UserControl>
	{{endregion}}



## Allow minus sign on zero value

The __RadMaskedInputExtensions__ expose an __AllowMinusOnZeroValues__ attached property. It controls whether the minus sign ("-") in front of zero (0 or 0.0) Value can be visualized. If you set it to __False__ users will not be allowed to enter minus when the Value of the control equals zero.
        

The major difference that this property makes is when you initially have a negative number entered and you change it to zero. When the __AllowMinusOnZeroValues__ is set to __False__ the minus sign will not be preserved - otherwise the minus will remain.
        

>The default value of the property is __True__.
          

## Tab navigation

The keyboard navigation of the RadMaskedInput suite of controls can be controlled by three properties: the native __IsTabStop__, the __SectionsNavigationMode__ and the attached __IsEditorTabStop__ properties. They can be set like this:
        

#### __xaml__

{{region radmaskedinput-features-keyboard-mouse_1}}
	<UserControl x:Class="MaskedInput_SL.MainPage"
	            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	            xmlns:maskedInput="clr-namespace:Telerik.Windows.Controls.MaskedInput;assembly=Telerik.Windows.Controls.Input"
	            xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	<StackPanel>
	    <telerik:RadMaskedTextInput SectionsNavigationMode="None" />
	    <telerik:RadMaskedTextInput IsTabStop="False"
	                                SectionsNavigationMode="None"
	                                maskedInput:MaskedInputExtensions.IsEditorTabStop="False" />
	    <telerik:RadMaskedTextInput SectionsNavigationMode="None" />
	</StackPanel>
	</UserControl>
	{{endregion}}



More information about the keyboard navigation can be found [here]({%slug radmaskedinput-features-keyboard-mouse%}).
        

# See Also

 * [Common Features]({%slug radmaskedinput-features-common%})

 * [Keyboard navigation]({%slug radmaskedinput-features-keyboard-mouse%})

 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})

 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})

 * [MaskedTextInput]({%slug radmaskedinput-features-controls-text%})

 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})
