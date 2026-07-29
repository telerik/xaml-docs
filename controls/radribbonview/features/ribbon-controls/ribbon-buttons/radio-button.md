---
title: Ribbon RadioButton
page_title: Ribbon RadioButton
description: Check our &quot;Ribbon RadioButton&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-radio-button
tags: ribbon,radiobutton
published: True
position: 3
---

# Ribbon RadioButton

The __RadRibbonRadioButton__ represents an extension of the __RadRadioButton__. It provides an easier interaction with the __RadRibbonView__ control. What is special about the __RadRibbonRadioButton__ is that it has two states - checked and unchecked. To switch between these states just click on it. Adding several __RadRibbonRadioButtons__ to a __RadRibbonGroup__ allows you to have only one checked at a time.			

>Note that ones the button has been checked, it stays in the checked state unless another radio button in the same __RadRibbonGroup__ is clicked. If the button is used alone, it can be unchecked after it has been selected once.				

>tip To learn more about the __RadRibbonRadioButton__ control read its documentation.			

Here is a sample definition of a __RadRibbonRadioButton__:			


<snippet id='radribbonview-features-ribbon-controls-ribbon-buttons-radio-button-block_1-xaml' />

>tip As all buttons in the RadRibbonView's set slightly expose the same functionality, take a look at the [Overview]({%slug radribbonview-buttons-overview%}) topic.

This button has its initial size set to __Large__ and its text label set to __"Equation"__. As the __IsAutoSize__ property is set to __True__, the button will change its size depending on the __RadRibbonGroup's__ size. The button will also never collapse to its __Medium__ size and will collapse to its __Small__ size when the __RadRibbonGroup__ collapses to __Medium__.
![{{ site.framework_name }} RadRibbonView Large Radio Button](images/RibbonView_Buttons_RadioButton.png)

Here is an example of a __RadRibbonGroup__ that contains two __RadRibbonRadioButtons__.			


<snippet id='radribbonview-features-ribbon-controls-ribbon-buttons-radio-button-block_2-xaml' />

![{{ site.framework_name }} RadRibbonView Ribbon Group with Two Radio Buttons](images/RibbonView_Buttons_RadioButtonsGroup.png)

## Handling Changes in the Button's Checked State

Besides the __Click__ event, the __RadRibbonRadioButton__ control exposes two additional events - __Checked__ and __Unchecked.__ They are meant to notify for changes in the checked state of the radio button.				


<snippet id='radribbonview-features-ribbon-controls-ribbon-buttons-radio-button-block_3-xaml' />


<snippet id='radribbonview-features-ribbon-controls-ribbon-buttons-radio-button-block_4-cs' />
<snippet id='radribbonview-features-ribbon-controls-ribbon-buttons-radio-button-block_5-vb' />

## See Also
 * [Styling the RadRibbonRadioButton]({%slug radribbonview-styling-ribbonradiobutton%})