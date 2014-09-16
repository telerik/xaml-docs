---
title: Watermark
page_title: Watermark
description: Watermark
slug: radmaskedinput-features-watermark
tags: watermark
published: True
position: 8
---

# Watermark



You can set a watermark content to a __RadMaskedTextInput__ control by using the __EmptyContent__ and __EmptyContentTemplate__ properties. When the __Value__ of a __RadMaskedTextInput__ control is null or empty the __EmptyContent__ will be displayed.
			

## Using EmptyContent Property

In scenarios, where you want to show custom content, when an empty string is entered, you need to use the __EmptyContent__ property.
				

In the following example, the user is asked to enter four digits:

#### __XAML__

{{region radmaskedinput-features-watermark_0}}
	<telerik:RadMaskedTextInput Mask="####" />
	{{endregion}}



When an empty string is entered, then the default __Placeholder__(the character used to represent the absence of user input in a __RadMaskedInput__ control)____will be displayed.
				

![](images/RadMaskedTextBox_Features_Watermark_Default.png)

If the __EmptyContent__ property is set, then it will be displayed when an empty string is entered.
				

#### __XAML__

{{region radmaskedinput-features-watermark_1}}
	<telerik:RadMaskedTextInput Mask="####" EmptyContent="Please Enter Four Digits" />
	{{endregion}}



![](images/RadMaskedTextBox_Features_Watermark_Customized.png)

The __EmptyContent__ property is of type object. Which means that you can set anything you want. For example:
				

#### __XAML__

{{region radmaskedinput-features-watermark_2}}
	<telerik:RadMaskedTextInput Mask="####">
	    <telerik:RadMaskedTextInput.EmptyContent>
	        <telerik:RadWatermarkTextBox Margin="3,0,0,0" BorderBrush="Transparent">
	            <telerik:RadWatermarkTextBox.WatermarkTemplate>
	                <DataTemplate>
	                    <StackPanel Orientation="Horizontal">
	                        <Image Source="/Example;component/Images/EURFlag.png" />
	                        <TextBlock Margin="3,0,0,0" Text="Please Enter Four Digits" />
	                    </StackPanel>
	                </DataTemplate>
	            </telerik:RadWatermarkTextBox.WatermarkTemplate>
	        </telerik:RadWatermarkTextBox>
	    </telerik:RadMaskedTextInput.EmptyContent>
	</telerik:RadMaskedTextInput>
	{{endregion}}



![](images/RadMaskedTextBox_Features_Watermark_WatermarkTextBox_Default.png)

## Using EmptyContentTemplate Property

Similarly, you can use the __EmptyContentTemplate__ property for the same sort of scenarios. Note that in this case you should define a new __DataTemplate__ for the __EmptyContentTemplate__ property.
				

#### __XAML__

{{region radmaskedinput-features-watermark_3}}
	<telerik:RadMaskedTextInput Mask="####">
	    <telerik:RadMaskedTextInput.EmptyContentTemplate>
	        <DataTemplate>
	            <telerik:RadWatermarkTextBox Margin="3,0,0,0" BorderBrush="Transparent">
	                <telerik:RadWatermarkTextBox.WatermarkTemplate>
	                    <DataTemplate>
	                        <StackPanel Orientation="Horizontal">
	                                    <Image Source="/Example;component/Images/EURFlag.png" />
	                            <TextBlock Margin="3,0,0,0"
	                                        Text="Please Enter Four Digits" />
	                        </StackPanel>
	                    </DataTemplate>
	                </telerik:RadWatermarkTextBox.WatermarkTemplate>
	            </telerik:RadWatermarkTextBox>
	        </DataTemplate>
	    </telerik:RadMaskedTextInput.EmptyContentTemplate>
	</telerik:RadMaskedTextInput>
	{{endregion}}



![](images/RadMaskedTextBox_Features_Watermark_WatermarkTextBox_Customized.png)

>tip
					You can see a live demo demonstrating the __EmptyContent__property [here](http://demos.telerik.com/silverlight/#MaskedInput/MaskedTextInput).
				

>tip
					For more information about the __RadWatermarkTextBox__ control, check out the
					{% if site.site_name == 'Silverlight' %}[RadWatermarkTextBox Overview](http://www.telerik.com/help/silverlight/radwatermarktextbox-overview.html){% endif %}{% if site.site_name == 'WPF' %}[RadWatermarkTextBox Overview](http://www.telerik.com/help/wpf/radwatermarktextbox-overview.html){% endif %} topic.
				

# See Also

 * [Getting Started]({%slug radmaskedinput-getting-started%})

 * [Common Features]({%slug radmaskedinput-features-common%})
