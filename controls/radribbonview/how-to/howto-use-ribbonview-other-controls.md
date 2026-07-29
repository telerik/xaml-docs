---
title: Use RadRibbonView with Other controls
page_title: Use RadRibbonView with Other controls
description: Check our &quot;Use RadRibbonView with Other controls&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-use-ribbonview-other-controls
tags: use,radribbonview,with,other,controls
published: True
position: 10
---

# Use RadRibbonView with Other controls

## Use RadRibbonView with RadCalendar	  

The purpose of this tutorial is to show you how to integrate a __RadCalendar__ with a __RadRibbonView__. The solution is to set the __RadCalendar__ as a drop down content of a __RadRibbonSplitButton__. The next example demonstrates how to do that.		


<snippet id='radribbonview-how-to-howto-use-ribbonview-other-controls-block_1-xaml' />

Here is the result:
![Rad Ribbon View How To Use Rad Calendar 01](images/RadRibbonView_HowTo_Use_RadCalendar_01.png)

## Use RadRibbonView with DataPicker	  

Except the controls associated with the __RadRibbonView__, like RadRibbonButton, RadRibbonGallery, RadRibbonComboBox, you can place other controls in the __RadRibbonGroups__. Here is an example of adding a __RadDatePicker__ control inside a __RadRibbonGroup__.		


<snippet id='radribbonview-how-to-howto-use-ribbonview-other-controls-block_2-xaml' />

The result is the following:
![Rad Ribbon View How To Use Rad Calendar 02](images/RadRibbonView_HowTo_Use_RadCalendar_02.png)

## Integrate a RadColorPicker Directly Into a Ribbon Group	  

The next example demonstrates how to integrate a __RadColorPicker__ directly into a __Ribbon Group__.		


<snippet id='radribbonview-how-to-howto-use-ribbonview-other-controls-block_3-xaml' />

And the result is:
![Rad Ribbon View How To Use Color Picker 01](images/RadRibbonView_HowTo_Use_ColorPicker_01.png)

## Integrate a RadColorSelector as a Part of a RadRibbonDropDownButton	  

Integrating a __RadColorSelector__ with a __RadRibbonDropDownButton__ is a simple task. See the next code-snippet.		


<snippet id='radribbonview-how-to-howto-use-ribbonview-other-controls-block_4-xaml' />

The __RadColorSelector__ is set as a __DropDownContent__ of the __RadRibbonDropDownButton__.
![Rad Ribbon View How To Use Color Picker 02](images/RadRibbonView_HowTo_Use_ColorPicker_02.png)