---
title: Working with Selection
page_title: Working with Selection
description: Working with Selection
slug: radmaskedinput-features-selection
tags: working,with,selection
published: True
position: 3
---

# Working with Selection



The purpose of this tutorial is to walk you through the common task of configuring __RadMaskedInput__ control for working with selection. The following "selection" features will be demonstrated:
			

* [SelectionOnFocus](#selectiononfocus)

* [SelectionLength and SelectionStart](#selectionlength-and-selectionstart)

## SelectionOnFocus

The __SelectionOnFocus__ property of the __RadMaskedInput__ controls allows you to specify what will happen with the cursor when the control gets focus. The values for the __SelectionOnFocus__ property are predefined in the __SelectionOnFocus__ enumeration. It exposes the following members:
				

* __SelectAll__ - once a __RadMaskedInput__ control is focused, it will select its whole text. 
						

#### __XAML__

{{region radmaskedinput-features-selection_0}}
	<telerik:RadMaskedTextInput Mask="###-###-###" SelectionOnFocus="SelectAll" />
	{{endregion}}



* __CaretToBeginning__ - once a __RadMaskedInput__ control is focused, the cursor will be positioned at its beginning.
						

#### __XAML__

{{region radmaskedinput-features-selection_1}}
	<telerik:RadMaskedTextInput Mask="###-###-###" SelectionOnFocus="CaretToBeginning" />
	{{endregion}}



* __CaretToEnd__ - once a __RadMaskedInput__ control is focused, the cursor will be positioned at its end.
						

#### __XAML__

{{region radmaskedinput-features-selection_2}}
	<telerik:RadMaskedTextInput Mask="###-###-###" SelectionOnFocus="CaretToEnd" />
	{{endregion}}



* __Unchanged__ - when a __RadMaskedInput__ control is focused, the position of the cursor won't be changed. This is the __default value__ for the __SelectionOnFocus__ property.
					

* __Default__ - when a __RadMaskedInput__ control is focused, the __SelectionOnFocus__ behavior depends on the type of the control. In the __RadMaskedDateTimeInput__ and __RadMaskedTextInput__ the __Default__ __SelectionOnFocus__ behavior won't change the position of the curser (the __Unchanged SelectionOnFocus__ behavior is applied). In the __RadMaskedNumericInput__ and the __RadMaskedCurrencyInput__ controls the __Default SelectionOnFocus__ behavior will place the curser before the decimal point.
					

* __DefaultSelectAll__ - this property changes the __SelectionOnFocus__ behavior of the control depending on the source of the focus. If a __MaskedInputControl__ is focused on mouse click, the __Default__ __SelectionOnFocus__ behavior will be used. If, on the other hand, a __MaskedInputControl__ is focused using the __Tab__ key, the __SelectAll__ __SelectionOnFocus__ behavior will be used.
					

## SelectionLength and SelectionStart

The __SelectionStart__ property gets or sets the starting point of the selected text in the __RadMaskedInput__, while the __SelectionLength__ gets or sets the number of characters selected in the __RadMaskedInput__. Both of the properties could be used in a combination with the __GotFocus__ event, like in the example below:
				

#### __XAML__

{{region radmaskedinput-features-selection_3}}
    <telerik:RadMaskedTextInput Mask="###-###-###" x:Name="radMaskedTextInput" GotFocus="radMaskedTextInput_GotFocus"/>
	{{endregion}}



#### __C#__

{{region radmaskedinput-features-selection_4}}
	private void radMaskedTextInput_GotFocus( object sender, RoutedEventArgs e )
	{
	   radMaskedTextInput.SelectionStart = 2;
	   radMaskedTextInput.SelectionLength = 2;
	}
	{{endregion}}



#### __VB.NET__

{{region radmaskedinput-features-selection_5}}
	Private Sub radMaskedTextInput_GotFocus(sender As Object, e As RoutedEventArgs)
	 radMaskedTextInput.SelectionStart = 2
	 radMaskedTextInput.SelectionLength = 2
	End Sub
	{{endregion}}



![](images/RadMaskedTextBox_Features_Selection_010.png)

# See Also

 * [UpdateValueEvent]({%slug radmaskedinput-features-update-value%})

 * [MaskTokens]({%slug radmaskedinput-features-mask-tokens%})

 * [Common Features]({%slug radmaskedinput-features-common%})
