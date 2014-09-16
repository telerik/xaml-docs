---
title: Overview
page_title: Overview
description: Overview
slug: radwatermarktextbox-overview
tags: overview
publish: True
position: 0
---

# Overview



{% if site.site_name == 'Silverlight' %}![radwatermarktextbox SL](images/radwatermarktextbox_SL.png){% endif %}{% if site.site_name == 'WPF' %}![radwatermarktextbox WPF](images/radwatermarktextbox_WPF.png){% endif %}

__RadWatermarkTextBox__ control represents a TextBox that shows a 
      different content when empty and not focus. The most important properties of the __RadWatermarkTextBox__ control are:
      

* __WatermarkContent__ - gets or sets the content to be shown when the TextBox is empty and not focused.

* __WatermarkTemplate__ - gets or sets the template for presenting the content, shown when the TextBox is empty and not focused.

* __CurrentText__ - gets or sets the text of the TextBox. This property is meant to be used for TwoWay binding in order to be updated on each change of the text and not when the focus is lost.

* __IsWatermarkVisible__ - a read-only property indicating whether the Watermark is visible or not.

* __SelectionOnFocus__ - specifies the modification over the selection when the control receives focus. The values for this properties are predefined in the __SelectionOnFocus__ enumeration, which exposes the following fields:
         

* __Unchanged__- selection will not be modified.

* __SelectAll__- the whole text will be selected.

* __CaretToBeginning__- the caret will be moved at the start of the text.

* __CaretToEnd__- the caret will be moved at the end of the text.

>tipThe __RadWatermarkTextBox__ control is part of the __Telerik.Windows.Controls.dll__ assembly.

## Using the WatermarkContent Property

In scenarios, where you want to show custom content, when an empty string is entered, you need to use the __WatermarkContent__property.

In the following example, the user is asked to enter four digits:

#### __XAML__

{{region radwatermarktextbox-overview_0}}
	        <telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox" WatermarkContent="Please Enter Four Digits:" />
	{{endregion}}



![radwatermarktextbox overview 010](images/radwatermarktextbox_overview_010.png)

The __WatermarkContent__property is of type object. Which means that you can set anything you want. For example:

#### __XAML__

{{region radwatermarktextbox-overview_1}}
	        <telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox">
	            <telerik:RadWatermarkTextBox.WatermarkContent>
	                <StackPanel Orientation="Horizontal">
	                    <Image Source="/Silverlight.Help.RadMaskedTextBox;component/Images/EURFlag.png" />
	                    <TextBlock Margin="3,0,0,0" Text="Please Enter Four Digits" />
	                </StackPanel>
	            </telerik:RadWatermarkTextBox.WatermarkContent>
	        </telerik:RadWatermarkTextBox>
	{{endregion}}



![radwatermarktextbox overview 020](images/radwatermarktextbox_overview_020.png)

## Using WatermarkTemplate Property

Similarly, you can use the __WatermarkTemplate__ property for the same sort of scenarios. Note that in this case you should define a new __DataTemplate__ for the __WatermarkTemplate__ property.

#### __XAML__

{{region radwatermarktextbox-overview_2}}
	        <telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox">
	            <telerik:RadWatermarkTextBox.WatermarkTemplate>
	                <DataTemplate>
	                    <StackPanel Orientation="Horizontal">
	                        <Image Source="/Silverlight.Help.RadMaskedTextBox;component/Images/EURFlag.png" />
	                        <TextBlock Margin="3,0,0,0" Text="Please Enter Four Digits" />
	                    </StackPanel>
	                </DataTemplate>
	            </telerik:RadWatermarkTextBox.WatermarkTemplate>
	        </telerik:RadWatermarkTextBox>
	{{endregion}}



![radwatermarktextbox overview 030](images/radwatermarktextbox_overview_030.png)

## Setting the SelectionOnFocus Property

The __SelectionOnFocus__ property of __RadWatermarkTextBox__ allows you to specify what will happen with the cursor when the control gets focus. In the following example the __SelectionOnFocus__ property is set to __SelectAll__. Once the __RadWatermarkTextBox__ gets focused, it will select its whole text.

#### __XAML__

{{region radwatermarktextbox-overview_3}}
	        <telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox" 
	                                     SelectionOnFocus="SelectAll"
	                                     WatermarkContent="Please Enter Four Digits:" />
	{{endregion}}


