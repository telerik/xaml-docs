---
title: Ribbon RadioButton
page_title: Ribbon RadioButton
description: Ribbon RadioButton
slug: radribbonview-radio-button
tags: ribbon,radiobutton
published: True
position: 3
---

# Ribbon RadioButton



The __RadRibbonRadioButton__ represents an extension of the __RadRadioButton__. It provides an easier interaction with the __RadRibbonView__ control. What is special about the __RadRibbonRadioButton__ is that it has two states - checked and unchecked. To switch between these states just click on it. Adding several __RadRibbonRadioButtons__ to a __RadRibbonGroup__ allows you to have only one checked at a time.
			

>Note that ones the button has been checked, it stays in the checked state unless another radio button in the same __RadRibbonGroup__ is clicked. If the button is used alone, it can be unchecked after it has been selected once.
				

>tipTo learn more about the __RadRibbonRadioButton__ control read its documentation.
			

Here is a sample definition of a __RadRibbonRadioButton__:
			

#### __XAML__

{{region radribbonview-radio-button_0}}
	<telerik:RadRibbonRadioButton CollapseToMedium="Never" 
	                              CollapseToSmall="WhenGroupIsMedium"
	                              IsAutoSize="True"
	                              LargeImage="Icons/32/Equation.png"
	                              Size="Large"
	                              SmallImage="Icons/16/Equation.png"
	                              Text="Equation" />
	{{endregion}}


			

This button has its initial size set to __Large__ and its text label set to __"Equation"__. As the __IsAutoSize__ property is set to __True__, the button will change its size depending on the __RadRibbonGroup's__ size. The button will also never collapse to its __Medium__ size and will collapse to its __Small__ size when the __RadRibbonGroup__ collapses to __Medium__.
![](images/RibbonView_Buttons_RadioButton.png)

Here is an example of a __RadRibbonGroup__ that contains two __RadRibbonRadioButtons__.
			

#### __XAML__

{{region radribbonview-radio-button_1}}
	<telerik:RadRibbonGroup DialogLauncherVisibility="Visible" Header="Home Group">
	    <telerik:RadRibbonRadioButton CollapseToMedium="Never" 
	                                  CollapseToSmall="WhenGroupIsMedium"
	                                  IsAutoSize="True"
	                                  LargeImage="Icons/32/PageBreak.png"
	                                  Size="Large"
	                                  SmallImage="Icons/16/PageBreak.png"
	                                  Text="Equation" />
	    <telerik:RadRibbonRadioButton CollapseToMedium="Never" 
	                                  CollapseToSmall="WhenGroupIsMedium"
	                                  IsAutoSize="True"
	                                  LargeImage="Icons/32/Footer.png"
	                                  Size="Large"
	                                  SmallImage="Icons/16/Footer.png"
	                                  Text="Symbol" />
	</telerik:RadRibbonGroup>
	{{endregion}}

![](images/RibbonView_Buttons_RadioButtonsGroup.png)

## Handling Changes in the Button's Checked State

Besides the __Click__ event, the __RadRibbonRadioButton__ control exposes two additional events - __Checked__ and __Unchecked.__ They are meant to notify for changes in the checked state of the radio button.
				

#### __XAML__

{{region radribbonview-radio-button_2}}
	<telerik:RadRibbonToggleButton Checked="RadRibbonToggleButton_Checked"
	                               CollapseToMedium="Never"
	                               CollapseToSmall="WhenGroupIsMedium"
	                               IsAutoSize="True"
	                               LargeImage="Icons/32/Equation.png"
	                               Size="Large"
	                               SmallImage="Icons/16/Equation.png"
	                               Text="Symbol"
	                               Unchecked="RadRibbonToggleButton_Unchecked" />
	{{endregion}}



#### __C#__

{{region radribbonview-radio-button_3}}
	private void RadRibbonToggleButton_Checked(object sender, RoutedEventArgs e)
	{
	}
	private void RadRibbonToggleButton_Unchecked(object sender, RoutedEventArgs e)
	{
	}
	{{endregion}}



#### __VB.NET__

{{region radribbonview-radio-button_4}}
	Private Sub RadRibbonToggleButton_Checked(sender As Object, e As RoutedEventArgs)
	End Sub
	
	Private Sub RadRibbonToggleButton_Unchecked(sender As Object, e As RoutedEventArgs)
	End Sub
	{{endregion}}




# See Also

 * [Styling the RadRibbonRadioButton]({%slug radribbonview-styling-ribbonradiobutton%})
