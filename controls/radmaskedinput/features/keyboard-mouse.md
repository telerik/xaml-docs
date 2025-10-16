---
title: Keyboard and Mouse Support
page_title: Keyboard and Mouse Support
description: Check our &quot;Keyboard and Mouse Support&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-features-keyboard-mouse
tags: keyboard,and,mouse,support
published: True
position: 7
---

# Keyboard and Mouse Support

In addition to the standard keyboard input, __RadMaskedInput__ controls deliver the convenience of desktop applications with support for arrow-key navigation:      

* Left/Right arrows - move the cursor one position to the left/right.

* Up/down arrows in the __RadMaskedInput__ controls - spin value one step up/down.          

* Mouse wheel support in the [RadMaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%}), [RadMaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%}), [RadMaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%}) and [RadMaskedTextInput]({%slug radmaskedinput-features-controls-text%})  controls  - spin value one step up/down.          

##  Spin Behavior

The spin behavior in the __RadMaskedInput__ controls could be controlled by setting the __SpinMode__ property.

The __SpinMode__ property is enumeration that exposed the following values:        

* __Position__ - spins the position affecting only the value on that position. For example if you spin up the last position of the following numeric value in a __RadMaskedNumericInput__ - 999, the result will be 990            

* __PositionAndValue__ - spins the position affecting the value of the RadMaskedInput control. For example if you spin up the last position of the following numeric value in a __RadMaskedNumericInput__ - 999, the result will be 1000            

* __None__ - disables the spin behavior            

__Example 1: Setting the SpinMode property__
```XAML
	<telerik:RadMaskedCurrencyInput Margin="0,5,0,10" 
	                                Culture="bg-BG"
	                                Mask="c4"
	                                SpinMode="PositionAndValue"/>
```

>The __SpinMode__ property is set by default as follows:
>	- In __RadMaskedTextInput__ control __SpinMode__ = "__None__"
>	- In __RadMaskedCurrencyInput__ control __SpinMode__ = "__PositionAndValue__"
>	- In __RadMaskedNumericInput__ control __SpinMode__ = "__PositionAndValue__"
>	- In __RadMaskedDateTimeInput__ control __SpinMode__ = "__Position__"              

## Sections Tab Navigation

In order to take full advantage of this feature you can set the __SectionsNavigationMode__ property. It is an enumeration of type __SectionsNavigationMode__ and it exposes the following values:       

* __Once__ (default) -  if you set the __SectionsNavigationMode__ to __Once__, you will be able to __Tab__ through all sections of the __RadMaskedInput__ control until reaching the end and tabbing to the next control            

* __None__ - if you set the __SectionsNavigationMode__ to __None__, you won't be able to tab through the __RadMaskedInput__ control's sections            

* __Cycle__ -  if you set the __SectionsNavigationMode__ to __Cycle__, the __Tab__ key will only cycle through the __RadMaskedInput__ control's sections            

If, however, you want to control the __Tab__ navigation in a __RadMaskedInput__ control as a whole without tabbing through the masked input sections, then you can set the __SectionsNavigationMode__ to __None__.        

Below you can find further explanations about the tab navigation between several controls.        

## Overall Tab Navigation

Once you turn off the sections tab navigation, you can set up the following properties to control the overall tab navigation within a __RadMaskedInput__ control:        

* __IsTabStop__ - All __RadMaskedInput__ controls derive from the native __Control__ class and therefore they all expose an {% if site.site_name == 'Silverlight' %}[IsTabStop](http://msdn.microsoft.com/en-us/library/system.windows.controls.control.istabstop(v=vs.95).aspx){% endif %}{% if site.site_name == 'WPF' %}[IsTabStop](http://msdn.microsoft.com/en-us/library/system.windows.controls.control.istabstop(v=vs.110).aspx){% endif %} property. However, when using this property you need to consider the fact that our controls actually are constructed of two native __TextBoxes__ which are placed one over another in their default template. One of them is used to visualize the content of the control when it is not focused. Also, that __TextBox__ can not receive the focus (its __IsTabStop__ property set to __False__). The other __TextBox__ component (called for short *"EditorTextBox"*) is visualized (and focused) when users try to change the __Value__ of the __RadMaskedInput__ control. Hence, if the native __IsTabStop__ property of the __RadMaskedInput__ control is set to __False__ the control itself will be restricted to receive focus. Please note that users will still be allowed to change the content of the control, since the EditorTextBox will be able to receive the focus.            

* __MaskedInputExtensions.IsEditorTabStop__ - this property is introduced in the __Q3 2013__ release and it controls whether the *EditorTextBox* is allowed to receive the focus.            

The following snippet demonstrates how both properties can be used to restrict the second __RadMaskedInput__ control from receiving focus. Note that with the following implementation only one __Tab__ (or __Shift + Tab__) key stroke is needed to move the focus form the first control to the third one (or vice versa):        

__Example 2: Setting the IsTabStop and IsEditorTabStop properties__
```XAML
	<UserControl 
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
```

>The explanations are true when the __SectionsNavigationMode__ property is set to __None__.          

The following table represents all possible combinations between the two properties and the number of the necessary __Tab__ (or __Shift + Tab__) key strokes to focus different controls:
        
|IsEditorTabStop|IsTabStop|Next control|The RadMaskedInput control|
|---------------|---------|------------|--------------------------|
|True (default)|False (default)|2|1|
|FALSE|FALSE|1|-|
|TRUE|TRUE|3|2|
|FALSE|TRUE|2|-|

Basically, the __IsEditorTabStop__ property controls the focus of *EditorTextBox* and the native __IsTabStop__ property controls the focus of the __RadMaskedInput__ control itself.        

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [Common Features]({%slug radmaskedinput-features-common%})
 * [Globalization Support]({%slug radmaskedinput-features-globalization%})