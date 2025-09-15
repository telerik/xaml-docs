---
title: Basics
page_title: Basics
description: Check our &quot;Basics&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-features-linear-and-radial-scales-basics
tags: basics
published: True
position: 0
---

# Basics

The __GraphicScale__ class is used as a base class for the LinearScale and the RadialScale classes. It provides common functionality for both scales. This topic will explain the major features of the GraphicScale class.

>The __ScaleBase__ class cannot be used on its own as a scale. You should use either the [Radial]({%slug radgauge-features-radial-scale%}) or [Linear Scales]({%slug radgauge-features-scales-linear-scale%}).

## Scale Offsets

The scales display values depending on their __Min__ and __Max__ properties. However there are cases, in which you might want to modify the value of the first or the last tick of the scale. For example, if you have a scale with a minimum value of __0.95__ and a maximum value of __20.8__, but you want to show the ticks for integer values only (from 1 to 20 only), you can use the __StartTickOffset__ and the __EndTickOffset__ properties of the scale to adjust the fist and the last tick's values. __Example 1__ demonstrates this approach.

__Example 1: Set StartTickOffset and EndTickOffset__
```XAML
	<telerik:RadVerticalLinearGauge Width="102" Height="210" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale Min="0.95" Max="20.8"
	                         EndTickOffset="-0.8"
	                         StartTickOffset="0.05"
	                         RelativeY="0"
	                         RelativeHeight="1"
	                         Fill="#FFD6D4D4"
	                         StartWidth="0.06"
	                         EndWidth="0.06"
	                         MajorTickOffset="0.03*" MinorTickOffset="0.03*"
	                         LabelOffset="0.13*"
	                         MajorTickRelativeHeight="0.003*" MinorTickRelativeHeight="0.003*"
	                         MiddleTicks="1" MinorTicks="3"/>
	</telerik:RadVerticalLinearGauge>
```

#### __Figure 1: Result from Example 1__
![VerticalLinearScale with StartTickOffset and EndTickOffset](images/RadGauge_Features_BaseScale_01.png)

## Scale Width

You are allowed to specify the width of the scale at its beginning and at its end. For this purpose the GraphicScale class exposes the __StartWidth__ and __EndWidth__ properties. Their value is relative to the cell size of the scale. In the case of the linear scale, this means to the width of the scale's container. __Example 2__ demonstrates how you can set those properties.

>tip To learn more about the cell size term, read the [Relative Measurements]({%slug radgauge-features-relative-measurements%}) topic.

__Example 2: Set StartWidth and EndWidth properties__
```XAML
	<telerik:RadVerticalLinearGauge Width="102" Height="210" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale Min="0" Max="20"
	                         RelativeY="0"
	                         RelativeHeight="1"
	                         StartWidth="0.02" EndWidth="0.08"
	                         Fill="#FFD6D4D4"
	                         Stroke="#FFD6D4D4"
	                         MajorTickOffset="0.03*" MinorTickOffset="0.03*"
	                         LabelOffset="0.13*"
	                         MajorTickRelativeHeight="0.003*" MinorTickRelativeHeight="0.003*"
	                         MiddleTicks="1" MinorTicks="3"/>
	</telerik:RadVerticalLinearGauge>
```

#### __Figure 2: Result from Example 2__
![VerticalLinearScale with StartWidth and EndWidth](images/RadGauge_Features_BaseScale_02.png)

## Interactivity

The __Interactivity__ feature allows the user to interact with the scale. Enabling the feature will allow one to drag the marker along the scale. By default this feature is turned off. In order to toggle it use the __IsInteractive__ property of the scale. This is demonstrated in __Example 3__.

__Example 3: Enablе the interactivity of a scale__
```XAML
	<telerik:RadVerticalLinearGauge x:Name="linearGauge" telerik:StyleManager.Theme="Windows8"
	                        Width="102" Height="210">
	    <telerik:VerticalLinearScale x:Name="linearScale"
	                            Min="1"
	                            Max="12"
	                            IsInteractive="True">
	        <telerik:Marker Value="1" />
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
```

## Logarithmic Scale

Both radial and linear scales have a Distribution property which specifies the value distribution along the scale (linear, logarithmic, exponential and etc.). This property is defined in the GraphicScale class and is of type [__IValueDistribution__](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.gauge.ivaluedistribution). This interface converts real scale value (given as value between Min and Max property of the scale) to the relative value (value in the [0...1] interval) which represents relative position of the value along the scale and vice versa. It is also possible to calculate the value for the tick mark using its index and the total number of ticks. Currently there are 3 basic implementations of this interface:

* __Regular__: The default distribution which is represented by a linear function. Check __Example 3__.

* __Range logarithmic__: The distribution which maps a logarithmic function on any value range (i.e. tick marks have close values at the beginning of the range and wide distance at the end of range). It corresponds to the IsLogarithmic mode in the old implementation.  Check __Example 4__.

* __Classic logarithmic__: The distribution which is represented by a logarithmic function. It represents the classic meaning of the logarithmic scale. In contrast to the range logarithmic distribution it can’t be used on an arbitrary value range, but on positive numbers only. Check __Example 5__.

>tip The default value for the __LogarithmicBase__ property of the logarithmic distributions is __10__.

__Example 3: RadialScale with RegularDistribution__
```XAML
	<telerik:RadRadialGauge>
		<telerik:RadialScale Min="1" Max="100">
			<telerik:RadialScale.Distribution>
				<telerik:RegularDistribution />
			</telerik:RadialScale.Distribution>
		</telerik:RadialScale>
	</telerik:RadRadialGauge>
```

__Example 4: RadialScale with RangeLogarithmicDistribution__
```XAML
	<telerik:RadRadialGauge>
		<telerik:RadialScale Min="-10" Max="100">
			<telerik:RadialScale.Distribution>
				<telerik:RangeLogarithmicDistribution />
			</telerik:RadialScale.Distribution>
		</telerik:RadialScale>
	</telerik:RadRadialGauge>
```

__Example 5: RadialScale with ClassicLogarithmicDistribution__
```XAML
	<telerik:RadRadialGauge>
		<telerik:RadialScale Min="1" Max="100">
			<telerik:RadialScale.Distribution>
				<telerik:ClassicLogarithmicDistribution />
			</telerik:RadialScale.Distribution>
		</telerik:RadialScale>
	</telerik:RadRadialGauge>
```

#### __Figure 3: Results from Examples 3,4,5 respectively__
![RadialScales with different distributions](images/RadGauge_Features_BaseScale_03.png)

## Reversed Scale

The scales allow you to reverse the direction, in which it displays its values. To do it, just set the __IsReversed__ property to __True__ as demonstrated in __Example 6__.

__Example 6: Create reversed scale__
```XAML
	<telerik:RadVerticalLinearGauge x:Name="linearGauge" telerik:StyleManager.Theme="Windows8"
	                        Width="102" Height="210">
	    <telerik:VerticalLinearScale x:Name="linearScale"
	                            Min="1"
	                            Max="12"
	                            IsReversed="True">
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
```

#### __Figure 4: Result from Example 6__
![Gauge with reversed scale](images/RadGauge_Features_BaseScale_04.png)

## Show First and Last Label

You can specify the scale to either display or not its last and first labels. Their visibility is controlled by the __ShowLastLabel__ and __ShowFirstLabel__ properties. This can be very useful when one of these labels is overlapping the labels next to it. __Example 7__ demonstrates how you can utilize those properties.

>The __ShowLastLabel__ value is applied only, when the ticks of the scale are defined via the __MajorTickStep__ property.

__Example 7: Set ShowFirstLabel and ShowLastLabel__
```XAML
	<telerik:RadVerticalLinearGauge x:Name="linearGauge" telerik:StyleManager.Theme="Windows8"
	                        Width="102" Height="210">
	    <telerik:VerticalLinearScale x:Name="linearScale"
	                            Min="1"
	                            Max="12"
	                            ShowFirstLabel="True"
	                            ShowLastLabel="False"
	                            MajorTickStep="2">
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
```

#### __Figure 5: Result from Example 7__
![Scale without last label](images/RadGauge_Features_BaseScale_05.png)

## Ranges

The __RadGauge__ control allows you to define ranges for your scales. The range is used for wrapping a specific section of the scale, that meets a condition. To allow you to use ranges with the different types of scales, the __RadGauge__ control provides you with a scale specific range objects. To learn more about working with ranges, read the [Ranges]({%slug radgauge-features-ranges-gauge-range%}) section of the documentation.

## Labels

The __GraphicScale__ class allows you to modify and configure the labels displayed next to the ticks of the scales. This is done by using the set of the __Label*__ properties (i.e. *LabelLocation*, *LabelOffset*, *LabelTemplate* and so on) of the scale. To learn more about configuring the labels, read the [Labels]({%slug radgauge-features-labels-basics%}) section of the documentation.

## Ticks

The __GraphicScale__ class exposes three sets of properties - __MajorTick*__, __MiddleTick*__, __MinorTick*__. They are used to configure the displaying of the different tick types on the scale. To learn more about configuring the ticks read the [Ticks]({%slug radgauge-features-ticks-basics%}) section of the documentation.

## See also

* [Radial Scale]({%slug radgauge-features-radial-scale%})
* [Linear Scale]({%slug radgauge-features-scales-linear-scale%})
