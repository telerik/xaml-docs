---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radgauge-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadGauge__.

## List of all RadGauge SDK examples:{% if site.site_name == 'WPF' %}

* __Creating linear gauge__ - One of the gauges you can create with the RadGauge control, is a linear gauge. It is represented by a rectangular container with a linear scale in it. Additionally it can display various indicators that point to a certain value off the scale. This example will guide you in creating a trivial linear gauge.

* __Creating numeric gauge__ - One of the gauges you can create with the RadGauge control, is a numeric gauge. It is represented by a container with a numerical scale in it. The numerical scale uses a numerical indicator to display the desired value. This example will guide you in creating a trivial numeric gauge.

* __Creating radial gauge__ - One of the gauges you can create with the RadGauge control, is a radial gauge. It is represented by a circle container with a scale in it. Additionally it can display various indicators that point to a certain value off the scale. This example will guide you in creating a trivial radial gauge.

* __Data binding__ - The RadGauge control allows you to bind it to a set of values, which to be displayed consecutive one after another. This feature is implemented via the indicator of the scale and its ValueSource property. It is of type IEnumerable and accepts the set of values you want to display. 

* __Gauge range appearance__ - To control the appearance of a range you can use the following properties:   - Background - specifies the fill color for the range.   - Stroke - specifies the stroke color for the range.   - StrokeThickness - specifies the thickness of the range's stroke.

* __Gauge range indicator background__ - You can specify an appearance for the scale's indicator, when it enters inside the range. This is done by using the following of the range object's properties:   - IndicatorBackground   - IndicatorColorMixSensitivity To modify the appearance of the indicator via the range, the indicator should be in Use Range Color mode.

* __Gauge range indicator color mix sensitivity__ - The IndicatorColorMixSensitivity property is used to colorize bar indicator. This feature is typical for the Bar Indicators. This property is applicable when RangeColorMode property of the indicator is set to MixedColor (works for both radial and linear scales), HorizontalGradient or VerticalGradient (work for linear scale only). The IndicatorColorMixSensitivity property indicates how the colors of two ranges (previous and current) are mixed to create the background of the indicator. Its value can be a double between 0 and 1. For example, if the BarIndicator has its RangeColorMode set to MixedColor and range's IndicatorColorMixSensitivity property is set to 0.5 then the bar indicator will use mixed color from both current and previous ranges. The mixed color will be used when indicator takes a value from the range start and up to the half of it. This example demonstrates how the indicator changes its background in this case.

* __Gauge range labels appearance__ - The appearance of the labels in the range can be controlled via the following properties:    - LabelForeground - specifies the foreground color for the labels that belong to the range. 	 To modify the appearance of the labels via the range, they should be in Use Range Color mode.

* __Gauge range max and min value__ - Each range should have a start and and end points. They are defined via the Min and Max properties, where their values represent values from the scale. Typically each range should be colored in a specific color. To set the desired color to the range use its Background property.

* __Gauge range ticks appearance__ - The appearance of the ticks in the range can be controlled via the following properties:    - TickBackground - specifies the fill color for the ticks that belong to the range. To modify the appearance of the ticks via the range, they should be in Use Range Color mode.

* __Gauge range width__ - You can control the width of a range at its start and at its end point. This is done via the StartWidth and the EndWidth properties of the range.

* __Groups__ - The gauge control allows creation of the indicator and range groups. To create range group we should add GaugeRangeGroup element to the ranges of the scale object.

* __How to create compass__ - This example will demonstrate how to customize a Radial Gauge to create compass.

* __How to create thermometer__ - In this tutorial we will show how the thermometer like gauge can be created using RadGauge control.

* __Indicators bar indicator__ - The Linear and the RadialBars derive from the BarIndicator class. Because of that they provide some common functionality. This example will focus on the common features between these indicators.

* __Indicators basics animating__ - When the value of the indicator gets changed, it will get positioned on the appropriate place on the scale. By default the indicator will directly go to the respective position, but you are able to make this transition smoother by animating it. To do it, just enable the indicators animation by setting the IsAnimated property to True and set the Duration property to the desired value.

* __Indicators basics refreshing__ - To implement this feature you have to use the RefreshRate and RefreshMode properties. The first one represents the interval of time between two updates. It is of type TimeSpan. The second one specifies the way the final value gets calculated. You can choose between the following:   - None(default) - disables refreshing.   - Average - displays the average of the values, that occurred in the interval.   - Max - displays the greatest from the values, that occured in the interval.   - Min - display the smallest of the values, that occured in the interval.

* __Indicators basics size__ - To manipulate the indicator's size, simply use the RelativeHeight and RelativeWidth attached properties. 

* __Indicators basics snappings__ - The Snapping feature allows the gauge to display values only for a fixed positions or values which match a specific interval. An example for snapping is the following scenario - you are interested to point values 5 and 10 on the gauge, and want all the values between 5 and 10 to be shown as the closest from these two (i.e. 6 will be shown as 5 and 9 will be shown as 10). 

* __Indicators basics using range color__ - If you use ranges in your scale, you can make the indicator consitent with their color. This way, when the indicator enters into a specific range, it will take the color defined for it by the range.

* __Indicators marker__ - The Marker is one of the indicator types that the RadGauge control introduces. It directly inherits the InteractiveIndicator class and doesn't introduce any specific features.

* __Indicators needle__ - The needle is one of the indicator types, that the RadGauge control introduces. It inherits the InteractiveIndicator class and introduces some specific features.

* __Indicators state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. It gets colored in the same color as the range to which the indicator's value belong.

* __Labels appearance__ - The RadialScale and LinearScale objects which inherit the GraphicScale class provide you with two ways of modifying the labels' appearance:   - Modifying Label's Foreground   - Specifying a LabelTemplate

* __Labels format__ - In order to allow you to format the value, that the labels display, The GraphicScale class exposes a LabelFormat property. It allows you to specify a format string for the value displayed in the label.

* __Labels location__ - The GraphicScale class exposes a LabelLocation property, which allows you to specify the location of the labels towards the scale. This property is an enumeration of type ScaleObjectLocation.

* __Labels offset__ - Besides using the LabelLocation property, you can also use the LabelOffset one, in order to apply an offset to the labels in order to fine position them.

* __Labels specifying label template__ - One way of specifying the appearance of the label is by defining an entire LabelTemplate for it, which will get applied to each of the labels. 

* __Linear RadialScales basics interactivity__ - The Interactivity feature allows the user to interact with the scale. Enabling the feature will allow them to drag the marker along the scale.

* __Linear radial scales basics reversed scale__ - The scales allow you to reverse the direction, in which they display their values. To do it just set the IsReversed property to False.

* __Linear radial scales basics scale offsets__ - The scales display values depending on their Min and Max properties. However there are cases, in which you might want to modify the value of the first or the last tick of the scale. For example if you have a scale with minimum value of 0.95 and maximum value of 20.8, but you want to show the ticks for integer values only (from 1 to 20 only), you can use the StartTickOffset and the EndTickOffset properties of the scale to adjust the fist and the last tick's values.

* __Linear radial scales basics scale width__ - You are allowed to specify the width of the scale at its beginning and at its end. For this purpose the GraphicScale class exposes the StartWidth and EndWidth properties.

* __Linear radial scales linear scale orientation__ - The LinearScale control can have either a horizontal or vertical orientation. The orientation could be defined using the appropriate container: the RadVerticalLinearGauge for vertical scale and the RadHorizontalLinearGauge for horizontal scale respectively.

* __Linear radial scales linear scale placement__ - The LinearScale exposes the RelativeX and RelativeY properties, which allows you to position the scale towards its container. The values of these two properties are relative to the height and respectively to the width of the scale's container.

* __Linear radial scales linear scale relative size__ - The Relative Size feature allows you to specify the size of the scale towards its container. This can be done by using the RelativeHeight and RelativeWidth property of the LinearScale. 

* __Linear Radial Scales Rotation Mode__ - The RadialScale control allows you to specify the way the labels get rotated around the scale. This is done by using the LabelRotationMode enumeration property. It can have one of the following values:   - Auto (default) - specifies that the labels get automatically rotated depending on their position on the scale.  - None - specifies that the labels won't get rotated.  - SurroundIn - specifies that the labels surround the radial scale with character’s base line directed towards the center of the scale.  - SurroundOut - specifies that the labels surround the radial scale with character’s base line directed backwards the center of the scale. 

* __Linear radial scales radial scale multiplier__ - The Multiplier property of the Radial Scale allows applying a multiplier to the scale range and to the current value of each element which is displayed on the scale.

* __Linear radial scales radial scale radius__ - You can specify the radius of the RadialScale via the Radius property.

* __Linear radial scales radial scale scale center__ - The RadialScale allows you to specify towards which point in its parent container it should get centered. This is done by using the Center property of the control. It represents a point which value is relative towards the cell size of the scale. For example, if you want to position the scale in the center of the parent container, you have to set the Center property to 0.5, 0.5 (this is the default value). This is an example where the center of the scale is 0.3, 0.3.

* __Linear radial scales radial scale start angle__ - The StartAngle property of the Graphic Scale allows you to specify the angle from which the drawing of the scale should start. The default value is at 7 o'clock and a start angle of 0 will make the scale start at 3 o'clock. The value of the angle grows clockwise.

* __Linear radial scales radial scale sweep angle__ - The sweep angle represents the amount of the scale that is used to display ticks. By default there is space between the first and the last value of the scale. If you want to specify the sweep angle use the SweepAngle property. For example a value of 360 will make the scale to form a complete circle and the first and the last value will overlap each other. A value of 180 will uake the scale use only half of the circle to display the values.

* __Linear scale bar indicator__ - The Bar indicator is a colored bar that is drawn around scale bar. One of ends of this bar points to the scale value. To add bar indicator to the scale you have to include LinearBar element to the list of the scale indicators.

* __Linear scale interactivity__ - Scale interactivity refers to the ability for the end-user to interact with the scale object. This ability is governed by the Boolean IsInteractive property. When this Boolean value is set to True, the end-user can click on the scale or drag the indicator along the values of its scale.

* __Linear scale labels__ - Tick labels are shown for the major tick marks. You can set the label location around the scale bar, the font properties (like family, size and foreground), the format of the label, or even change the whole control template for a label. To change the location of the tick mark label you should use the LabelLocation property of the scale element in XAML.

* __Linear scale marker__ - The Marker is a scale indicator that points to a value along a scale. It is a small shape that can be located around the scale bar. To add marker to the scale you have to include Marker element to the list of the scale indicators.

* __Linear scale numeric indicator__ - This topic is intended to show you how to use Numeric Indicator with Linear Scale. To add numeric indicator to the scale you have to include NumericIndicator element to the list of the scale indicators.

* __Linear scale overview__ - LinearScale is used to control the overall layout of tick marks, tick labels, indicators, and ranges, as well render an optional scale bar.

* __Linear scale state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. If state indicator's value put into one of the scale ranges then shape is filled with brush of this range. To add state indicator to the scale you have to include StateIndicator element to the list of scale indicators.

* __Linear scale tick marks__ - Tick marks allow displaying of the value intervals along the gauge scale. There are 3 types of the tick marks:   - Major - specify the primary value intervals. MajorTicks scale's property specifies the number of the value intervals along the whole length of the scale bar. Major tick marks can have labels. You can specify the common properties and the appearance of the major tick mark using MajorTick property of the scale.   - Middle - specify the secondary value intervals. MiddleTicks scale's property specifies the number of the secondary value intervals inside the primary value interval. Middle tick marks can't have labels. You can specify the common properties and the appearance of the middle tick mark using MiddleTick property of the scale.   - Minor - specify the third level of the value intervals. MinorTicks scale's property specifies the number of the third level value intervals inside the secondary value interval. Minor tick marks can't have labels. You can specify the common properties and the appearance of the minor tick mark using MinorTick property of the scale.

* __Linear scale tick marks custom tick marks__ - The RadGauge control provides very flexible standard tick marks and labels, but sometimes it is necessary to show additional elements in particular scale position. This can be achievied by using custom elements which can be placed at a specific value (shown at value 0,75 and 100 in the image below) by setting the Value property. Just like the major and minor tick marks, the look of the custom tick marks can be fully customized.

* __Numeric indicator corner radius__ - The CornerRadius property allows you to specify the radius of the indicator's corners.

* __Numeric indicator display value format__ - The Format property allows you to specify a format string for the indicator's value. When formatting you might have to add or remove some number positions.

* __Numeric indicator number positions__ - By default the Numeric Indicator won't display its values. You have to define the number positions to display the value's digits. This can be done by adding a number position objects to the Positions collection of the NumericIndicator. You can use the following types of number position:   - SevenSegsNumberPosition - the digit get displayed via 7 rectangular segments.   - HexagonalNumberPosition - the digit get displayed via 7 hexagonal segments.   - FontNumberPosition - the digit is displayed as characters. In this case the values of the various font properties, like FontFamily, FontSize, FontWeight etc., get applied. The font properties can be set to the indicator itself. In this case they will get applied to all of the FontNumberPosition controls in it. You can apply it directly to the FontNumberPosition control as well, in order to have different appearance for each position.

* __Numeric indicator placement__ - The ScaleObject.RelativeX and ScaleObject.RelativeY attachable properties allow you to position the NumericIndicator towards the scale's container. The values of these two properties are relative to the respective height and width of the scale's container. 

* __Numeric indicator size__ - To manipulate the indicator's size, simply use the ScaleObject.RelativeHeight and ScaleObject.RelativeWidth attachable properties. As the names suggest, their value are relative to the cell size of the scale. The cell size of the scale is determined by the size of the container it is placed in. For the radial scales it is equal to the radius of the container. However, when placed inside a LinearScale or inside a NumericScale, then the ScaleObject.RelativeHeight value is relative to the height and the ScaleObject.RelativeWidth to the width of the scale's container.

* __Numeric scale__ - The NumericScale control allows you to display a scale of numeric form. The numeric scales are used for displaying digits. An example for a numerical scale is the digital clock's display.

* __Numeric scale numeric indicator__ - The Numeric Indicator is an indicator that displays its Value property as a digital indicator device. The appearance of characters in the numeric indicator could be specified with a set of different NumericIndicator.Positions like "HexagonalNumberPosition", "SevenSegsNumberPosition", "GraphicNumberPosition" and etc.

* __Numeric scale overview__ - The NumericScale is a container to display numeric and/or state indicator when no other scales (radial or linear) are necessary.

* __Numeric scale state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. If the state indicator's value puts into one of the scale ranges then shape is filled with brush of this range. To add a state indicator to the scale you have to include the StateIndicator element to the NumericScale.Indicators.

* __Radial scale bar indicator appearance__ - There are several ways how you can change color of the bar indicator. By default you set it using "Background" property. But sometimes it is useful to change color of the bar indicator according to the value it points to. RadGauge supports this feature for the bar indicators. You can configure bar indicator to use the color of the range which contains indicator's value.

* __Radial scale bar indicator layout__ - You can set location of the Bar indicator relative to a scale bar using telerik:ScaleObject.Location property.

* __Radial scale interactivity__ - Scale interactivity refers to the ability for the end-user to interact with the scale object. This ability is governed by the Boolean IsInteractive property. When this Boolean value is set to True, the end-user can click on the scale or drag the indicator along the values of its scale.

* __Radial scale labels__ - Tick labels are shown for major tick marks. You can set label location around scale bar, font properties (like family, size and foreground), format of the label, or even change whole control template for label. 

* __Radial scale marker__ - The Marker is a scale indicator that points to a value along a scale. It is a small shape that can be located around the scale bar. To add marker to the scale you have to include Marker element to the list of scale indicators.

* __Radial scale numeric indicator__ - Numeric Indicator is an indicator that displays its Value property as digital indicator device.

* __Radial scale overview__ - 

* __Radial scale quadrant style gauge__ - This example demonstrates the 4 kinds of quadrant-style gauges supported by RadGauge.

* __Radial scale semi circle gauge__ - This example demonstrates the 4 kinds of semi-circle gauges supported by RadGauge.

* __Radial scale state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. If state indicator's value put into one of the scale ranges then shape is filled with brush of this range. To add state indicator to the scale you have to include StateIndicator element to the list of scale indicators.

* __Radial scale tick marks__ - Tick marks allow displaying value intervals along the gauge scale. There are 3 types of the tick marks:   - Major - specify primary value intervals. MajorTicks or MajorTickStep property of the scale specifies the number of the value intervals along the entire length of the scale bar. Major tick marks can have a label. You can specify common properties and appearance for the major tick marks using MajorTick property of the scale.   - Middle - specify secondary value intervals. MiddleTicks property of the scale specifies the number of the secondary value intervals inside the primary value interval. Middle tick marks can't have labels. You can specify common properties and appearance of the middle tick mark using MiddleTick property of the scale.   - Minor - specify third level of the value intervals. MinorTicks scale's property specifies number of the third level value intervals inside the secondary value interval. Minor tick marks can't have labels. You can specify common properties and appearance of the minor tick mark using MinorTick property of the scale.

* __Ticks appearance__ - The TickProperties objects provide you with two ways of modifying the ticks' appearance:   - Modifying Tick's Background   - Specifying a DataTemplate

* __Ticks data template__ - One way for specifying the appearance of the tick is by defining an entire DataTemplate for it, which will get applied to each of the ticks of the respective type. There you can define the visual appearance of the tick as you desire and bind the used elements to the data context of the template where needed. 

* __Ticks location__ - The TickProperties class exposes a Location property, which allows you to specify the location of the ticks towards the scale.

* __Ticks size__ - To specify the size of all major ticks you should use the MajorTickRelativeWidth and MajorTickRelativeHeight properties of the respective Scale object. You can use the MinorTickRelativeWidth and MinorTickRelativeHeight properties to change the size of the minor ticks or the MiddleTickRelativeWidth and MiddleTickRelativeHeight properties to change the size of the middle ticks respectively. The tick's size is relative to the cell size of the scale.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Creating linear gauge__ - One of the gauges you can create with the RadGauge control, is a linear gauge. It is represented by a rectangular container with a linear scale in it. Additionally it can display various indicators that point to a certain value off the scale. This example will guide you in creating a trivial linear gauge.

* __Creating numeric gauge__ - One of the gauges you can create with the RadGauge control, is a numeric gauge. It is represented by a container with a numerical scale in it. The numerical scale uses a numerical indicator to display the desired value. This example will guide you in creating a trivial numeric gauge.

* __Creating radial gauge__ - One of the gauges you can create with the RadGauge control, is a radial gauge. It is represented by a circle container with a scale in it. Additionally it can display various indicators that point to a certain value off the scale. This example will guide you in creating a trivial radial gauge.

* __Data binding__ - The RadGauge control allows you to bind it to a set of values, which to be displayed consecutive one after another. This feature is implemented via the indicator of the scale and its ValueSource property. It is of type IEnumerable and accepts the set of values you want to display. 

* __Gauge range appearance__ - To control the appearance of a range you can use the following properties:   - Background - specifies the fill color for the range.   - Stroke - specifies the stroke color for the range.   - StrokeThickness - specifies the thickness of the range's stroke.

* __Gauge range indicator background__ - You can specify an appearance for the scale's indicator, when it enters inside the range. This is done by using the following of the range object's properties:   - IndicatorBackground   - IndicatorColorMixSensitivity To modify the appearance of the indicator via the range, the indicator should be in Use Range Color mode.

* __Gauge range indicator color mix sensitivity__ - The IndicatorColorMixSensitivity property is used to colorize bar indicator. This feature is typical for the Bar Indicators. This property is applicable when RangeColorMode property of the indicator is set to MixedColor (works for both radial and linear scales), HorizontalGradient or VerticalGradient (work for linear scale only). The IndicatorColorMixSensitivity property indicates how the colors of two ranges (previous and current) are mixed to create the background of the indicator. Its value can be a double between 0 and 1. For example, if the BarIndicator has its RangeColorMode set to MixedColor and range's IndicatorColorMixSensitivity property is set to 0.5 then the bar indicator will use mixed color from both current and previous ranges. The mixed color will be used when indicator takes a value from the range start and up to the half of it. This example demonstrates how the indicator changes its background in this case.

* __Gauge range labels appearance__ - The appearance of the labels in the range can be controlled via the following properties:    - LabelForeground - specifies the foreground color for the labels that belong to the range. 	 To modify the appearance of the labels via the range, they should be in Use Range Color mode.

* __Gauge range max and min value__ - Each range should have a start and and end points. They are defined via the Min and Max properties, where their values represent values from the scale. Typically each range should be colored in a specific color. To set the desired color to the range use its Background property.

* __Gauge range ticks appearance__ - The appearance of the ticks in the range can be controlled via the following properties:    - TickBackground - specifies the fill color for the ticks that belong to the range. To modify the appearance of the ticks via the range, they should be in Use Range Color mode.

* __Gauge range width__ - You can control the width of a range at its start and at its end point. This is done via the StartWidth and the EndWidth properties of the range.

* __Groups__ - The gauge control allows creation of the indicator and range groups. To create range group we should add GaugeRangeGroup element to the ranges of the scale object.

* __How to create compass__ - This example will demonstrate how to customize a Radial Gauge to create compass.

* __How to create thermometer__ - In this tutorial we will show how the thermometer like gauge can be created using RadGauge control.

* __Indicators bar indicator__ - The Linear and the RadialBars derive from the BarIndicator class. Because of that they provide some common functionality. This example will focus on the common features between these indicators.

* __Indicators basics animating__ - When the value of the indicator gets changed, it will get positioned on the appropriate place on the scale. By default the indicator will directly go to the respective position, but you are able to make this transition smoother by animating it. To do it, just enable the indicators animation by setting the IsAnimated property to True and set the Duration property to the desired value.

* __Indicators basics refreshing__ - To implement this feature you have to use the RefreshRate and RefreshMode properties. The first one represents the interval of time between two updates. It is of type TimeSpan. The second one specifies the way the final value gets calculated. You can choose between the following:   - None(default) - disables refreshing.   - Average - displays the average of the values, that occurred in the interval.   - Max - displays the greatest from the values, that occured in the interval.   - Min - display the smallest of the values, that occured in the interval.

* __Indicators basics size__ - To manipulate the indicator's size, simply use the RelativeHeight and RelativeWidth attached properties. 

* __Indicators basics snapping__ - The Snapping feature allows the gauge to display values only for a fixed positions or values which match a specific interval. An example for snapping is the following scenario - you are interested to point values 5 and 10 on the gauge, and want all the values between 5 and 10 to be shown as the closest from these two (i.e. 6 will be shown as 5 and 9 will be shown as 10). 

* __Indicators basics using range color__ - If you use ranges in your scale, you can make the indicator consitent with their color. This way, when the indicator enters into a specific range, it will take the color defined for it by the range.

* __Indicators marker__ - The Marker is one of the indicator types that the RadGauge control introduces. It directly inherits the InteractiveIndicator class and doesn't introduce any specific features.

* __Indicators needle__ - The needle is one of the indicator types, that the RadGauge control introduces. It inherits the InteractiveIndicator class and introduces some specific features.

* __Indicators state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. It gets colored in the same color as the range to which the indicator's value belong.

* __Labels appearance__ - The RadialScale and LinearScale objects which inherit the GraphicScale class provide you with two ways of modifying the labels' appearance:   - Modifying Label's Foreground   - Specifying a LabelTemplate

* __Labels format__ - In order to allow you to format the value, that the labels display, The GraphicScale class exposes a LabelFormat property. It allows you to specify a format string for the value displayed in the label.

* __Labels location__ - The GraphicScale class exposes a LabelLocation property, which allows you to specify the location of the labels towards the scale. This property is an enumeration of type ScaleObjectLocation.

* __Labels offset__ - Besides using the LabelLocation property, you can also use the LabelOffset one, in order to apply an offset to the labels in order to fine position them.

* __Labels specifying label template__ - One way of specifying the appearance of the label is by defining an entire LabelTemplate for it, which will get applied to each of the labels. 

* __Linear RadialScale radius__ - You can specify the radius of the RadialScale via the Radius property.

* __Linear RadialScales basics interactivity__ - The Interactivity feature allows the user to interact with the scale. Enabling the feature will allow them to drag the marker along the scale.

* __Linear radial scales basics reversed scale__ - The scales allow you to reverse the direction, in which they display their values. To do it just set the IsReversed property to False.

* __Linear radial scales basics scale offsets__ - The scales display values depending on their Min and Max properties. However there are cases, in which you might want to modify the value of the first or the last tick of the scale. For example if you have a scale with minimum value of 0.95 and maximum value of 20.8, but you want to show the ticks for integer values only (from 1 to 20 only), you can use the StartTickOffset and the EndTickOffset properties of the scale to adjust the fist and the last tick's values.

* __Linear radial scales basics scale width__ - You are allowed to specify the width of the scale at its beginning and at its end. For this purpose the GraphicScale class exposes the StartWidth and EndWidth properties.

* __Linear radial scales linear scale orientation__ - The LinearScale control can have either a horizontal or vertical orientation. The orientation could be defined using the appropriate container: the RadVerticalLinearGauge for vertical scale and the RadHorizontalLinearGauge for horizontal scale respectively.

* __Linear radial scales linear scale placement__ - The LinearScale exposes the RelativeX and RelativeY properties, which allows you to position the scale towards its container. The values of these two properties are relative to the height and respectively to the width of the scale's container.

* __Linear radial scales linear scale relative size__ - The Relative Size feature allows you to specify the size of the scale towards its container. This can be done by using the RelativeHeight and RelativeWidth property of the LinearScale. 

* __Linear radial scales radial scale label rotation mode__ - The RadialScale control allows you to specify the way the labels get rotated around the scale. This is done by using the LabelRotationMode enumeration property. It can have one of the following values:   - Auto (default) - specifies that the labels get automatically rotated depending on their position on the scale.   - None - specifies that the labels won't get rotated.   - SurroundIn - specifies that the labels surround the radial scale with character’s base line directed towards the center of the scale.   - SurroundOut - specifies that the labels surround the radial scale with character’s base line directed backwards the center of the scale. 

* __Linear radial scales radial scale multiplier__ - The Multiplier property of the Radial Scale allows applying a multiplier to the scale range and to the current value of each element which is displayed on the scale.

* __Linear radial scales radial scale scale center__ - The RadialScale allows you to specify towards which point in its parent container it should get centered. This is done by using the Center property of the control. It represents a point which value is relative towards the cell size of the scale. For example, if you want to position the scale in the center of the parent container, you have to set the Center property to 0.5, 0.5 (this is the default value). This is an example where the center of the scale is 0.3, 0.3.

* __Linear radial scales radial scale start angle__ - The StartAngle property of the Graphic Scale allows you to specify the angle from which the drawing of the scale should start. The default value is at 7 o'clock and a start angle of 0 will make the scale start at 3 o'clock. The value of the angle grows clockwise.

* __Linear radial scales sweep angle__ - The sweep angle represents the amount of the scale that is used to display ticks. By default there is space between the first and the last value of the scale. If you want to specify the sweep angle use the SweepAngle property. For example a value of 360 will make the scale to form a complete circle and the first and the last value will overlap each other. A value of 180 will uake the scale use only half of the circle to display the values.

* __Linear scale bar indicator__ - The Bar indicator is a colored bar that is drawn around scale bar. One of ends of this bar points to the scale value. To add bar indicator to the scale you have to include LinearBar element to the list of the scale indicators.

* __Linear scale interactivity__ - Scale interactivity refers to the ability for the end-user to interact with the scale object. This ability is governed by the Boolean IsInteractive property. When this Boolean value is set to True, the end-user can click on the scale or drag the indicator along the values of its scale.

* __Linear scale labels__ - Tick labels are shown for the major tick marks. You can set the label location around the scale bar, the font properties (like family, size and foreground), the format of the label, or even change the whole control template for a label. To change the location of the tick mark label you should use the LabelLocation property of the scale element in XAML.

* __Linear scale marker__ - The Marker is a scale indicator that points to a value along a scale. It is a small shape that can be located around the scale bar. To add marker to the scale you have to include Marker element to the list of the scale indicators.

* __Linear scale numeric indicator__ - This topic is intended to show you how to use Numeric Indicator with Linear Scale. To add numeric indicator to the scale you have to include NumericIndicator element to the list of the scale indicators.

* __Linear scale overview__ - LinearScale is used to control the overall layout of tick marks, tick labels, indicators, and ranges, as well render an optional scale bar.

* __Linear scale state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. If state indicator's value put into one of the scale ranges then shape is filled with brush of this range. To add state indicator to the scale you have to include StateIndicator element to the list of scale indicators.

* __Linear scale tick marks__ - Tick marks allow displaying of the value intervals along the gauge scale. There are 3 types of the tick marks:   - Major - specify the primary value intervals. MajorTicks scale's property specifies the number of the value intervals along the whole length of the scale bar. Major tick marks can have labels. You can specify the common properties and the appearance of the major tick mark using MajorTick property of the scale.   - Middle - specify the secondary value intervals. MiddleTicks scale's property specifies the number of the secondary value intervals inside the primary value interval. Middle tick marks can't have labels. You can specify the common properties and the appearance of the middle tick mark using MiddleTick property of the scale.   - Minor - specify the third level of the value intervals. MinorTicks scale's property specifies the number of the third level value intervals inside the secondary value interval. Minor tick marks can't have labels. You can specify the common properties and the appearance of the minor tick mark using MinorTick property of the scale.

* __Linear scale tick marks custom tick marks__ - The RadGauge control provides very flexible standard tick marks and labels, but sometimes it is necessary to show additional elements in particular scale position. This can be achievied by using custom elements which can be placed at a specific value (shown at value 0,75 and 100 in the image below) by setting the Value property. Just like the major and minor tick marks, the look of the custom tick marks can be fully customized.

* __Numeric indicator corner radius__ - The CornerRadius property allows you to specify the radius of the indicator's corners.

* __Numeric indicator display value format__ - The Format property allows you to specify a format string for the indicator's value. When formatting you might have to add or remove some number positions.

* __Numeric indicator number positions__ - By default the Numeric Indicator won't display its values. You have to define the number positions to display the value's digits. This can be done by adding a number position objects to the Positions collection of the NumericIndicator. You can use the following types of number position:   - SevenSegsNumberPosition - the digit get displayed via 7 rectangular segments.   - HexagonalNumberPosition - the digit get displayed via 7 hexagonal segments.   - FontNumberPosition - the digit is displayed as characters. In this case the values of the various font properties, like FontFamily, FontSize, FontWeight etc., get applied. The font properties can be set to the indicator itself. In this case they will get applied to all of the FontNumberPosition controls in it. You can apply it directly to the FontNumberPosition control as well, in order to have different appearance for each position.

* __Numeric indicator placement__ - The ScaleObject.RelativeX and ScaleObject.RelativeY attachable properties allow you to position the NumericIndicator towards the scale's container. The values of these two properties are relative to the respective height and width of the scale's container. 

* __Numeric indicator size__ - To manipulate the indicator's size, simply use the ScaleObject.RelativeHeight and ScaleObject.RelativeWidth attachable properties. As the names suggest, their value are relative to the cell size of the scale. The cell size of the scale is determined by the size of the container it is placed in. For the radial scales it is equal to the radius of the container. However, when placed inside a LinearScale or inside a NumericScale, then the ScaleObject.RelativeHeight value is relative to the height and the ScaleObject.RelativeWidth to the width of the scale's container.

* __Numeric scale__ - The NumericScale control allows you to display a scale of numeric form. The numeric scales are used for displaying digits. An example for a numerical scale is the digital clock's display.

* __Numeric scale numeric indicator__ - The Numeric Indicator is an indicator that displays its Value property as a digital indicator device. The appearance of characters in the numeric indicator could be specified with a set of different NumericIndicator.Positions like "HexagonalNumberPosition", "SevenSegsNumberPosition", "GraphicNumberPosition" and etc.

* __Numeric scale overview__ - The NumericScale is a container to display numeric and/or state indicator when no other scales (radial or linear) are necessary.

* __Numeric scale state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. If the state indicator's value puts into one of the scale ranges then shape is filled with brush of this range. To add a state indicator to the scale you have to include the StateIndicator element to the NumericScale.Indicators.

* __Radial scale bar indicator appearance__ - There are several ways how you can change color of the bar indicator. By default you set it using "Background" property. But sometimes it is useful to change color of the bar indicator according to the value it points to. RadGauge supports this feature for the bar indicators. You can configure bar indicator to use the color of the range which contains indicator's value.

* __Radial scale bar indicator layout__ - You can set location of the Bar indicator relative to a scale bar using telerik:ScaleObject.Location property.

* __Radial scale interactivity__ - Scale interactivity refers to the ability for the end-user to interact with the scale object. This ability is governed by the Boolean IsInteractive property. When this Boolean value is set to True, the end-user can click on the scale or drag the indicator along the values of its scale.

* __Radial scale labels__ - Tick labels are shown for major tick marks. You can set label location around scale bar, font properties (like family, size and foreground), format of the label, or even change whole control template for label. 

* __Radial scale marker__ - The Marker is a scale indicator that points to a value along a scale. It is a small shape that can be located around the scale bar. To add marker to the scale you have to include Marker element to the list of scale indicators.

* __Radial scale numeric indicator__ - Numeric Indicator is an indicator that displays its Value property as digital indicator device.

* __Radial scale overview__ - 

* __Radial scale quadrant style gauge__ - This example demonstrates the 4 kinds of quadrant-style gauges supported by RadGauge.

* __Radial scale semi circle gauge__ - This example demonstrates the 4 kinds of semi-circle gauges supported by RadGauge.

* __Radial scale state indicator__ - The State Indicator is a shape with arbitrary size located anywhere in the scale. If state indicator's value put into one of the scale ranges then shape is filled with brush of this range. To add state indicator to the scale you have to include StateIndicator element to the list of scale indicators.

* __Radial scale tick marks__ - Tick marks allow displaying value intervals along the gauge scale. There are 3 types of the tick marks:   - Major - specify primary value intervals. MajorTicks or MajorTickStep property of the scale specifies the number of the value intervals along the entire length of the scale bar. Major tick marks can have a label. You can specify common properties and appearance for the major tick marks using MajorTick property of the scale.   - Middle - specify secondary value intervals. MiddleTicks property of the scale specifies the number of the secondary value intervals inside the primary value interval. Middle tick marks can't have labels. You can specify common properties and appearance of the middle tick mark using MiddleTick property of the scale.   - Minor - specify third level of the value intervals. MinorTicks scale's property specifies number of the third level value intervals inside the secondary value interval. Minor tick marks can't have labels. You can specify common properties and appearance of the minor tick mark using MinorTick property of the scale.

* __Ticks appearance__ - The TickProperties objects provide you with two ways of modifying the ticks' appearance:   - Modifying Tick's Background   - Specifying a DataTemplate

* __Ticks data template__ - One way for specifying the appearance of the tick is by defining an entire DataTemplate for it, which will get applied to each of the ticks of the respective type. There you can define the visual appearance of the tick as you desire and bind the used elements to the data context of the template where needed. 

* __Ticks location__ - The TickProperties class exposes a Location property, which allows you to specify the location of the ticks towards the scale.

* __Ticks size__ - To specify the size of all major ticks you should use the MajorTickRelativeWidth and MajorTickRelativeHeight properties of the respective Scale object. You can use the MinorTickRelativeWidth and MinorTickRelativeHeight properties to change the size of the minor ticks or the MiddleTickRelativeWidth and MiddleTickRelativeHeight properties to change the size of the middle ticks respectively. The tick's size is relative to the cell size of the scale.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).
