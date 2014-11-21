---
title: Distance and Scale
page_title: Distance and Scale
description: Distance and Scale
slug: radmap-features-dsitance-and-scale
tags: distance,and,scale
published: True
position: 6
---

# Distance and Scale



## 

The __RadMap__ uses two measure units for distance - mile and kilometer. The measure units are need for the placement of the __MapShapes__, as their width and height are measured in the selected unit. To choose the most suitable unit you have to set the __DistanceUnit__ property of the __RadMap__.
        

>The default value is __Kilometer__.
          

#### __XAML__

{{region radmap-features-dsitance-and-scale_0}}
	<telerik:RadMap x:Name="radMap"
	                DistanceUnit="Mile" />
	{{endregion}}



The __DistanceUnit__ also affects the __Scale__ control displayed at the lower right corner of the __RadMap__.
        

If you want to hide it, you just have to set the __ScaleVisibility__ property to __False__.
        

#### __XAML__

{{region radmap-features-dsitance-and-scale_1}}
	<telerik:RadMap x:Name="radMap"
	                ScaleVisibility="Collapsed" />
	{{endregion}}



The UI control is represented by the __MapScale__ control. You are able to use it outside the __RadMap__ and place it somewhere around it. In this case you have to either hide the original one by using the __ScaleVisibility__ property of the __RadMap__ or the __UseDefaultLayout__ one.
        

>tipSetting the __UseDefaultLayout__ property to __False__ will hide all of the UI controls inside the __RadMap__. To learn more read [here]({%slug radmap-features-default-layout%}).
        

In order to use the __MapScale__ outside the __RadMap__ you have to set its __MapControl__ property to the respective __RadMap__ instance. Additionally you can modify its appearance. 

Here is an example:
        

>Note that when using an outside __MapScale__ control, it's the value of the __DistanceUnit__ property of this control that will be counted, not the one of the __RadMap's__ __DistanceUnit__ property.
          

#### __XAML__

{{region radmap-features-dsitance-and-scale_2}}
	<StackPanel>
	    <telerik:MapScale MapControl="{Binding ElementName=radMap}"
	                        ScaleLabelBackground="Orange"
	                        ScaleLabelBorderBrush="DarkRed"
	                        BorderBrush="DarkRed"
	                        Background="Orange"
	                        Foreground="DarkRed"
	                        HorizontalAlignment="Right"
	                        Margin="10"
	                        DistanceUnit="Kilometer" />
	    <telerik:RadMap x:Name="radMap"
	                    Width="600"
	                    Height="480"
	                    ScaleVisibility="Collapsed" />
	</StackPanel>
	{{endregion}}



Here is a snapshot of the result.

![](images/RadMap_Features_DistancAndScale_01.png)

# See Also

 * [Navigation]({%slug radmap-features-navigation%})

 * [Click Modes]({%slug radmap-features-click-modes%})

 * [Zoom Modes]({%slug radmap-features-zoom-modes%})

 * [Mouse Location]({%slug radmap-features-mouse-location%})

 * [Default Layout]({%slug radmap-features-default-layout%})
