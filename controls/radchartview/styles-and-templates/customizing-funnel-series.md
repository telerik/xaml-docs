---
title: Customizing FunnelChart Series
page_title: Customizing FunnelChart Series
description: Check our &quot;Customizing FunnelChart Series&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-styles-and-templates-customizing-funnelchart-series
tags: customizing,funnelchart,series
published: True
position: 2
---

# Customizing FunnelChart Series

This article demonstrates how you can change the default look of the __RadFunnelChart__ series.
      
## Customizing Funnel Series

### DefaultSegmentStyle

This series expose the __DefaultSegmentStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __FunnelSeries__. Your custom style should target the native __Path__ component. You can set the property like this:

__Example 1: Setting DefaultSegmentStyle property in XAML__
```XAML
	<telerik:FunnelSeries.DefaultSegmentStyle>
		<Style TargetType="Path">
			<Setter Property="Fill" Value="YellowGreen"/>
		</Style>
	</telerik:FunnelSeries.DefaultSegmentStyle>
```

#### __Figure 1: DefaultSegmentStyle property set__
![radchartview-styles-and-templates-funnel-series-defaultsegmentstyle](images/radchartview-styles-and-templates-funnelseries-defaultsegmentstyle.png)

### SegmentStyles

This series also expose the __SegmentStyles__ property. It is of type __ObservableCollection<Style>__ and gets or sets a collection of styles that will be consecutively applied on all slices of the __FunnelSeries__. This means that if you have more segments than Styles defined, the RadFunnelChart will repeatedly apply the collection so that the number of the applied styles equals the number of the segments. You can define the collection in XAML like this:
            
__Example 2: Setting SegmentStyles property in XAML__
```XAML	
    <telerik:FunnelSeries.SegmentStyles>
		<Style TargetType="Path">
			<Setter Property="Fill" Value="YellowGreen"/>
		</Style>
		<Style TargetType="Path">
			<Setter Property="Fill" Value="Orange"/>
		</Style>
		<Style TargetType="Path">
			<Setter Property="Fill" Value="Red"/>
		</Style>
		<Style TargetType="Path">
			<Setter Property="Fill" Value="Yellow"/>
		</Style>
		<Style TargetType="Path">
			<Setter Property="Fill" Value="Green"/>
		</Style>
	</telerik:FunnelSeries.SegmentStyles>
```

#### __Figure 2: SegmentStyles property set__
![radchartview-styles-and-templates-funnelseries-segmentstyles](images/radchartview-styles-and-templates-funnelseries-segmentstyles.png)

## See Also
 * [Customizing CartesianChart Series]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%})
 * [Customizing PolarChart Series]({%slug radchartview-styles-and-templates-customizing-polarchart-series%})
