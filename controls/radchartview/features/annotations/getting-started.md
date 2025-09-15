---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-annotations-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started



Both RadCartesianChart and RadPolarChart contain an __Annotations__ collection which holds all the annotations plotted against the chart.
      

>The RadChartView will visualize annotations only if it populated with data.
        

## Adding Cartesian Annotations

When adding GridLine or PlotBand annotations to RadCartesianChart, you have to explicitly set their __Axis__ property to either the vertical or the horizontal axis. That way the annotation knows what its orientation is, and also, the exact coordinates on which it has to be rendered.
        

#### __XAML__

```XAML
	<telerik:RadCartesianChart x:Name="cartesianChart">
	            
	    <telerik:RadCartesianChart.Annotations>
	        <telerik:CartesianGridLineAnnotation Axis="{Binding ElementName=verticalAxis}" 
	                                                Value="6" Stroke="Red" StrokeThickness="1"/>
	        <telerik:CartesianGridLineAnnotation Axis="{Binding ElementName=horizontalAxis}" 
	                                                Value="2.8" Stroke="Blue" StrokeThickness="1"/>
	    </telerik:RadCartesianChart.Annotations>
	            
	    <telerik:RadCartesianChart.VerticalAxis>
	        <telerik:LinearAxis x:Name="verticalAxis"/>
	    </telerik:RadCartesianChart.VerticalAxis>
	            
	    <telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:LinearAxis x:Name="horizontalAxis"/>
	    </telerik:RadCartesianChart.HorizontalAxis>
	</telerik:RadCartesianChart>	
	```



#### __C#__

```C#
	cartesianChart.Annotations.Add(
	    new CartesianGridLineAnnotation 
	    { 
	        Axis = cartesianChart.VerticalAxis, 
	        Value = 6, Stroke = new SolidColorBrush(Colors.Red), 
	        StrokeThickness = 1
	    });
	cartesianChart.Annotations.Add(
	    new CartesianGridLineAnnotation 
	    { 
	        Axis = cartesianChart.HorizontalAxis, 
	        Value = 2.8, Stroke = new SolidColorBrush(Colors.Blue), 
	        StrokeThickness = 1
	    });
	```



#### __VB.NET__

```VB.NET
	cartesianChart.Annotations.Add(New CartesianGridLineAnnotation() With { _
		.Axis = cartesianChart.VerticalAxis, _
		.Value = 6, _
		.Stroke = New SolidColorBrush(Colors.Red), _
		.StrokeThickness = 1 _
	})
	cartesianChart.Annotations.Add(New CartesianGridLineAnnotation() With { _
		.Axis = cartesianChart.HorizontalAxis, _
		.Value = 2.8, _
		.Stroke = New SolidColorBrush(Colors.Blue), _
		.StrokeThickness = 1 _
	})
	```



## Adding Polar Annotations

When adding GridLine or PlotBand annotations to RadPolarChart, you do not need to set their axis association as it is implicitly resolved by their respective type. For example, PolarAxisGridLineAnnotation is implicitly associated with the polar axis, while RadialAxisPlotBandAnnotation is implicitly associated with the radial axis.
        

#### __XAML__

```XAML
	<telerik:RadPolarChart>
	            
	    <telerik:RadPolarChart.Annotations>
	        <telerik:PolarAxisGridLineAnnotation Value="2" Stroke="Red"/>
	        <telerik:PolarAxisGridLineAnnotation Value="7" Stroke="LightGreen"/>
	        <telerik:PolarAxisGridLineAnnotation Value="8" Stroke="LightBlue"/>
	    </telerik:RadPolarChart.Annotations>
	            
	    <telerik:RadPolarChart.RadialAxis>
	        <telerik:NumericRadialAxis/>
	    </telerik:RadPolarChart.RadialAxis>
	            
	    <telerik:RadPolarChart.PolarAxis>
	        <telerik:PolarAxis/>
	    </telerik:RadPolarChart.PolarAxis>
	            
	</telerik:RadPolarChart>
	```



#### __C#__

```C#
	polarChart.Annotations.Add(
	    new PolarAxisGridLineAnnotation { Value = 2, Stroke = new SolidColorBrush(Colors.Red) });
	polarChart.Annotations.Add(
	    new PolarAxisGridLineAnnotation { Value = 7, Stroke = new SolidColorBrush(Colors.LightGreen) });
	polarChart.Annotations.Add(
	    new PolarAxisGridLineAnnotation { Value = 8, Stroke = new SolidColorBrush(Colors.LightBlue) });
	```



#### __VB.NET__

```VB.NET
	polarChart.Annotations.Add(New PolarAxisGridLineAnnotation() With { _
		.Value = 2, _
		.Stroke = New SolidColorBrush(Colors.Red) _
	})
	polarChart.Annotations.Add(New PolarAxisGridLineAnnotation() With { _
		.Value = 7, _
		.Stroke = New SolidColorBrush(Colors.LightGreen) _
	})
	polarChart.Annotations.Add(New PolarAxisGridLineAnnotation() With { _
		.Value = 8, _
		.Stroke = New SolidColorBrush(Colors.LightBlue) _
	})
	```

