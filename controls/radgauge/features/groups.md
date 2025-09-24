---
title: Groups
page_title: Groups
description: Check our &quot;Groups&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-features-groups
tags: groups
published: True
position: 8
---

# Groups

There are common scenarios when 1 scale can have few group of ranges (some electric measurement devices, for example) and few groups of indicators, which change its appearance depending on the group of ranges it works with. For example, sound volume indicator on the sound amplifier. The scale have 1 range group with green, yellow and red segments which indicate sound volume, and 1 range group with transparent and red ranges which serves as overload indicator (it turns on when sound volume is close to the end of the scale). The first range list has 4 bar indicators which show sound volume for 4 channels, the second range list - 4 state indicators which show overload status for 4 channels. In this case we need 2 range groups and 2 indicator groups.     

The gauge control allows creation of the indicator and range groups. To create range group we should add __GaugeRangeGroup__ element to the ranges of the scale object. To create indicators group we should add __IndicatorGroup__ element to the indicators of the scale object. We can specify which group of ranges will be used by group of indicators. To do it we should use the __Ranges__ property of the __IndicatorsGroup__ element. The following XAML creates gauge which implements the functionality described above:      


```XAML
	<telerik:RadVerticalLinearGauge telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale RelativeX="0.25" 
	                         StartWidth="0.05" 
	                         EndWidth="0.05"
	                         Fill="Transparent"
	                         IsInteractive="True">
	        <telerik:VerticalLinearScale.Ranges>
	            <telerik:GaugeRange Min="0" Max="55"
	                                IndicatorBackground="#7F767676" />
	            <telerik:GaugeRange Min="55" Max="85"
	                                IndicatorBackground="#BF767676" />
	            <telerik:GaugeRange Min="85" Max="100"
	                                IndicatorBackground="#FF767676" />
	            <telerik:GaugeRangeGroup x:Name="overloadGroup">
	                <telerik:GaugeRange Min="0" Max="80"
	                                    IndicatorBackground="#FF3AC015" />
	                <telerik:GaugeRange Min="80" Max="100"
	                                    IndicatorBackground="#FFE50000" />
	            </telerik:GaugeRangeGroup>
	        </telerik:VerticalLinearScale.Ranges>
	        <telerik:VerticalLinearScale.Indicators>
	            <telerik:BarIndicator Name="leftFront"
	                                  StartWidth="0.04"
	                                  telerik:ScaleObject.Location="CenterInside"
	                                  telerik:ScaleObject.Offset="0.01*"
	                                  UseRangeColor="True" 
	                                  RangeColorMode="ProportionalBrush"
	                                  Value="100" />
	            <telerik:BarIndicator Name="rightFront"
	                                  StartWidth="0.04"
	                                  telerik:ScaleObject.Location="CenterInside"
	                                  telerik:ScaleObject.Offset="0.11*"
	                                  UseRangeColor="True"
	                                  RangeColorMode="ProportionalBrush"
	                                  Value="95" />
	            <telerik:BarIndicator Name="leftRear"
	                                  StartWidth="0.04"
	                                  telerik:ScaleObject.Location="CenterInside"
	                                  telerik:ScaleObject.Offset="0.21*"
	                                  UseRangeColor="True"
	                                  RangeColorMode="ProportionalBrush"
	                                  Value="75" />
	            <telerik:BarIndicator Name="rightRear"
	                                  StartWidth="0.04"
	                                  telerik:ScaleObject.Location="CenterInside"
	                                  telerik:ScaleObject.Offset="0.31*"
	                                  UseRangeColor="True"
	                                  RangeColorMode="ProportionalBrush"
	                                  Value="50" />
	            <telerik:IndicatorGroup Ranges="{Binding ElementName=overloadGroup}">
	                <telerik:StateIndicator Name="leftFrontOverload"
	                                        telerik:ScaleObject.RelativeX="0.28"
	                                        telerik:ScaleObject.RelativeY="0.05"
	                                        telerik:ScaleObject.RelativeWidth="0.05*"
	                                        telerik:ScaleObject.RelativeHeight="0.05*"
	                                        UseRangeColor="True"
	                                        Value="{Binding ElementName=leftFront,Path=Value}"/>
	                <telerik:StateIndicator Name="rightFrontOverload"
	                                        telerik:ScaleObject.RelativeX="0.38"
	                                        telerik:ScaleObject.RelativeY="0.05"
	                                        telerik:ScaleObject.RelativeWidth="0.05*"
	                                        telerik:ScaleObject.RelativeHeight="0.05*"
	                                        UseRangeColor="True"
	                                        Value="{Binding ElementName=rightFront,Path=Value}"/>
	                <telerik:StateIndicator Name="leftRearOverload"
	                                        telerik:ScaleObject.RelativeX="0.48"
	                                        telerik:ScaleObject.RelativeY="0.05"
	                                        telerik:ScaleObject.RelativeWidth="0.05*"
	                                        telerik:ScaleObject.RelativeHeight="0.05*"
	                                        UseRangeColor="True"
	                                        Value="{Binding ElementName=leftRear,Path=Value}"/>
	                <telerik:StateIndicator Name="rightRearOverload"
	                                        telerik:ScaleObject.RelativeX="0.58"
	                                        telerik:ScaleObject.RelativeY="0.05"
	                                        telerik:ScaleObject.RelativeWidth="0.05*"
	                                        telerik:ScaleObject.RelativeHeight="0.05*"
	                                        UseRangeColor="True"
	                                        Value="{Binding ElementName=rightRear,Path=Value}"/>
	            </telerik:IndicatorGroup>
	        </telerik:VerticalLinearScale.Indicators>
	    </telerik:VerticalLinearScale>
	    <telerik:VerticalLinearScale RelativeX="0.63" 
	                         StartWidth="0.01" 
	                         EndWidth="0.01"
	                         LabelLocation="Inside"
	                         MajorTickLocation="Inside"
	                         MiddleTickLocation="Inside"
	                         MinorTickLocation="Inside"
	                         Fill="Transparent" />
	</telerik:RadVerticalLinearGauge>
```

Here is a snapshot of the result:

![Rad Gauge radgauge features groups 01](images/RadGauge_radgauge_features_groups_01.png)

In this example the ranges itself are invisible. In the case when we need to have different groups of ranges visible at the same time we can use __Location__ and __Offset__ properties of the __GaugeRangeGroup__ object to specify position of the ranges. For example:        


```XAML
    <telerik:RadRadialGauge telerik:StyleManager.Theme="Windows8">
        <telerik:RadialScale Radius="0.99"
                             RangeLocation="Outside">
            <telerik:RadialScale.Ranges>
                <telerik:GaugeRange Min="0" Max="50"
                                    StartWidth="0.01" 
                                    Background="#FF3AC015"
                                    IndicatorBackground="#FF3AC015"
                                    IndicatorColorMixSensitivity="2" />
                <telerik:GaugeRange Min="50" Max="80"
                                    StartWidth="0.01" 
                                    Background="#FFD9ED27"
                                    IndicatorBackground="#FFD9ED27"
                                    IndicatorColorMixSensitivity="2" />
                <telerik:GaugeRange Min="80" Max="100"
                                    StartWidth="0.01" 
                                    Background="#FFE50000"
                                    IndicatorBackground="#FFE50000"
                                    IndicatorColorMixSensitivity="2"/>
                <telerik:GaugeRangeGroup x:Name="overload" 
                                         Location="Inside">
                    <telerik:GaugeRange Min="0" Max="50"
                                        StartWidth="0.01"
                                        Background="#FF767676"
                                        IndicatorBackground="#FF767676" />
                    <telerik:GaugeRange Min="50" Max="100"
                                        StartWidth="0.01"
                                        Background="#FFD6D4D4"
                                        IndicatorBackground="#FFD6D4D4" />
                </telerik:GaugeRangeGroup>
            </telerik:RadialScale.Ranges>
            <telerik:RadialScale.Indicators>
                <telerik:Marker telerik:ScaleObject.Location="OverOutside"
                                UseRangeColor="True"
                                Value="85" />
                <telerik:IndicatorGroup Ranges="{Binding ElementName=overload}">
                    <telerik:Marker telerik:ScaleObject.Location="OverOutside"
                                    UseRangeColor="True"
                                    Value="20" />
                </telerik:IndicatorGroup>
            </telerik:RadialScale.Indicators>
        </telerik:RadialScale>
    </telerik:RadRadialGauge>
```

![Rad Gauge radgauge features groups 02](images/RadGauge_radgauge_features_groups_02.png)