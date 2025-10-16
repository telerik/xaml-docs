---
title: Qualitative Scale
page_title: Qualitative Scale
description: This article describes the properties exposed by the RadBulletGraph controls for adjusting the qualitative scale.
slug: radbulletgraph-features-qualitative-scale
tags: properties, scale
published: True
position: 2
---

# Qualitative Scale

This article describes the properties exposed by the control for adjusting the qualitative scale.

## Setting Manual Range

The scale of the bulletgraph control auto calculates its range by default. To manually set the range of the scale use set the __AutoRange__ property of the bulletgraph control to False and the __Minimum__ and __Maximum__ properties.

To control the interval between the ticks on the scale use the __Step__ property.

__Example 1: Setting the scale range manually__
```XAML
	<telerik:RadHorizontalBulletGraph AutoRange="False"
									  Minimum="0"
									  Maximum="120"
									  Step="10" 
									  
									  FeaturedMeasure="50" 
									  ComparativeMeasure="72" 
									  ProjectedValue="81"/>
```

#### Figure 1: Setting the scale range between 0 and 120
![radbulletgraph-qualitative-scale-0.png](images/radbulletgraph-qualitative-scale-0.png)

## Hiding the Scale

To hide the scale's ticks and labels, set the __QuantitativeScaleVisibility__ property.

__Example 2: Hiding the scale__
```XAML
	<telerik:RadHorizontalBulletGraph FeaturedMeasure="50" 
                                      ComparativeMeasure="72" 
                                      ProjectedValue="81" 
									  
                                      QuantitativeScaleVisibility="Hidden"/>
```

#### Figure 2: BulletGraph with hidden scale
![radbulletgraph-qualitative-scale-1.png](images/radbulletgraph-qualitative-scale-1.png)
	
{% if site.site_name == 'WPF' %}
> Setting the visibility to Hidden and Collapsed leads to different visual results. When Collapsed, the control won't allocate the space for the scale, therefore the bar will be more wide. When the visibility is set to Hidden, the control will reserve space for the scale, therefore the bar won't stretch in all available space.
{% endif %}

## Formating the Labels

To format the tick labels displayed under the scale, use the __TextFormatString__ property. The property allows you to set any of the [standart numeric string format strings](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings).

__Example 3: Using currency format__
```XAML
	<telerik:RadHorizontalBulletGraph FeaturedMeasure="50" 
									  ComparativeMeasure="72" 
									  ProjectedValue="81"
									  
									  TextFormatString="{}{0:C0}" />
```

#### Figure 3: Labels formatted using currency format
![radbulletgraph-qualitative-scale-2.png](images/radbulletgraph-qualitative-scale-2.png)
	
## Inversing the Scale 
	
To inverse the scale you can set the __FlowDirection__ property of the control. 

__Example 4: Setting FlowDirection__
```XAML
	<telerik:RadHorizontalBulletGraph FeaturedMeasure="40" 
									ComparativeMeasure="65"                                           
									ProjectedValue="60"
                                    
									FlowDirection="RightToLeft">
		<telerik:RadHorizontalBulletGraph.QualitativeRanges>
			<telerik:QualitativeRange Brush="#A8A8A8" Value="30" />
			<telerik:QualitativeRange Brush="#C6C8C8" Value="70" />
			<telerik:QualitativeRange Brush="#E8E8E8" Value="100"/>
		</telerik:RadHorizontalBulletGraph.QualitativeRanges>
	</telerik:RadHorizontalBulletGraph>
```

#### Figure 4: Inversed scale
![radbulletgraph-qualitative-scale-2.png](images/radbulletgraph-qualitative-scale-3.png)
	
## See Also  
* [Getting Started]({%slug radbulletgraph-getting-started%})
* [Qualitative Ranges]({%slug radbulletgraph-features-qualitative-ranges%})
* [Measures]({%slug radbulletgraph-features-measures%})
