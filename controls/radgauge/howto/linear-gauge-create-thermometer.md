---
title: Create Thermometer
page_title: Create Thermometer
description: Check our &quot;Create Thermometer&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: linear-gauge-create-thermometer
tags: create,thermometer
published: True
position: 0
---

# Create Thermometer

In this tutorial we will show how the thermometer like gauge can be created using RadGauge control.

>This example is made with the Windows8 theme. You can take a look at the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article to see how to set different theme than the default one.

To create thermometer we will use __RadVerticalLinearGauge__ with 2 scales: one for Celsius and one for Fahrenheit scale. We will start Celsius scale at -30 degree and end it at the 40 degree. Degrees in the Fahrenheit scale correspond to the degrees in the Celsius scale by following formula:

__Fahrenheit Degree = (Celsius Degree * 9) / 5 - 32__

To get Fahrenheit scale show correspondent temperature we should start it at the -22 degree and end it at the 104 degree. To force Fahrenheit scale show "fine" labels like 20, 40, 60 we will shift start and end tick marks of this scale.

At the beginning we should add simple linear gauge with single scale. Since we would like to show Celsius labels at the left of scale bar and Fahrenheit labels at the right we'll add a TextBlock as custom item.

__Example 1: Define the Celsius VerticalLinearScale__
<snippet id='radgauge-howto-linear-gauge-create-thermometer-example_1_define_the_celsius_verticallinearscale-xaml' />


We'll need a unified look for our Celsius and Fahrenheit labels and scales:

__Example 2: Setting the Celsius and Fahrenheit labels and scales__
<snippet id='radgauge-howto-linear-gauge-create-thermometer-example_2_setting_the_celsius_and_fahrenheit_labels_and_scales-xaml' />


We'll add two Custom Items (for the thermometer bulb) that should give our gauge a look of thermometer:

__Example 3: Setting the CustomItems property__
<snippet id='radgauge-howto-linear-gauge-create-thermometer-example_3_setting_the_customitems_property-xaml' />


Now our scale looks as following:

![{{ site.framework_name }} RadGauge Thermometer](images/CelsiusAndFahrenheit.png)

The next step is to add the second Fahrenheit linear scale and a linear bar indicator. 

__Example 4: Define the Fahrenheit VerticalLinearScale__
<snippet id='radgauge-howto-linear-gauge-create-thermometer-example_4_define_the_fahrenheit_verticallinearscale-xaml' />


The final step is to combine the two __VerticalLinearScale (Celsius and Fahrenheit)__ elements. The final code should look like in __Example 5__.
 
__Example 5: Final code__
<snippet id='radgauge-howto-linear-gauge-create-thermometer-example_5_final_code-xaml' />


Voilà! The thermometer gauge with all styles applied should look like the following: 

![{{ site.framework_name }} RadGauge Thermometer Celsius and Fahrenheit](images/Thermometer.png)

## See also
* [Create Compass]({%slug chart-customize-radialgauge-layout%})