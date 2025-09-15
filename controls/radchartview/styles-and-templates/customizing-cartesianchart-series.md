---
title: Customizing CartesianChart Series
page_title: Customizing CartesianChart Series
description: Check our &quot;Customizing CartesianChart Series&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-styles-and-templates-customizing-cartesianchart-series
tags: customizing,cartesianchart,series
published: True
position: 0
---

# Customizing CartesianChart Series

This article demonstrates how you can change the default look of the __RadCartesianChart__ series.      

* [Customizing Data Points Using DefaultVisualStyle](#customizing-data-points-using-defaultvisualstyle)
* [Customizing Data Points Using PointTemplate](#customizing-data-points-using-pointtemplate)
<br />
* [Customizing Point Series](#customizing-point-series)
	* [PointSeries](#pointseries)
	* [ScatterPointSeries](#scatterpointseries)
* [Customizing Line Series](#customizing-line-series)
	* [LineSeries](#lineseries)
	* [SplineSeries](#splineseries)
	* [StepLineSeries](#steplineseries)
	* [ScatterLineSeries](#scatterlineseries)
	* [ScatterSplineSeries](#scattersplineseries)
* [Customizing Area Series](#customizing-area-series)
	* [AreaSeries](#lineseries)
	* [RangeSeries](#rangeseries)
	* [StepAreaSeries](#stepareaseries)
	* [SplineAreaSeries](#splineareaseries)
	* [ScatterAreaSeries](#scatterareaseries)
	* [ScatterSplineAreaSeries](#scattersplineareaseries)
* [Customizing Bar Series](#customizing-bar-series)      
 	* [BarSeries](#barseries)
	* [RangeBarSeries](#rangebarseries)
* [Customizing Financial Series](#customizing-financial-series)
	* [OhlcSeries](#ohlcseries)
	* [CandlestickSeries](#candlestickseries)	
* [BoxPlotSeries](#customizing-box-plot-series)	
* [ErrorBarSeries](#customizing-error-bar-series)	
	
## Customizing Data Points Using DefaultVisualStyle

The different chart series use different visual elements to display their data points - a bar, an ellipse, etc. You can apply a custom style for those elements via the __DefaultVisualStyle__ property. The property accepts a value of type __Style__ which targets the visual element of the corresponding series. There is an additional __DefaultVisualStyleSelector__ property which can be used to apply different style for the different data point visuals in a series. The selector property is of type [StyleSelector](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.styleselector?redirectedfrom=MSDN&view=net-5.0).

__Setting DefaultVisualStyle of BarSeries__
```XAML
    <telerik:BarSeries>
		<telerik:BarSeries.DefaultVisualStyle>
			<Style TargetType="Border">
				<Setter Property="Background" Value="#F47748" />
			</Style>
		</telerik:BarSeries.DefaultVisualStyle>
    </telerik:BarSeries>
```

![{{ site.framework_name }} RadChartView ](images/radchartview-styles-and-templates-customize-cartesianseries-1.png)

Since Q1 2016, all Cartesian series (excluding RangeSeries) are rendering default visuals using the DefaultVisualStyle property. So, you can use it also with line and area series to display their data point visuals which don't exist by default. Note that when using line or area series you will need to set also the size of the visual. Otherwise it won't be displayed.

__Setting DefaultVisualStyle of LineSeries__
```XAML
    <telerik:LineSeries>
      <telerik:LineSeries.DefaultVisualStyle>
		<Style TargetType="Path">
			<Setter Property="Width" Value="10" />
			<Setter Property="Height" Value="10" />
			<Setter Property="Fill" Value="#FF5AC3" />
		</Style>
      </telerik:LineSeries.DefaultVisualStyle>
    </telerik:LineSeries>
```

![{{ site.framework_name }} RadChartView ](images/radchartview-styles-and-templates-customize-cartesianseries-0.png)
	
> When using a [Palette]({%slug radchartview-features-palettes-introduction%}) the series' default visual will ignore the color defined in the DefaultVisualStyle and it will use the one provided by the palette.

## Customizing Data Points Using PointTemplate

All series supported by the __RadCartesianChart__ expose a __PointTemplate__ property. It is of type __DataTemplate__ and gets or sets the template that describes the visual representation of the data points in a series. There is an additiona __PointTemplateSelector__ property which can be used to apply different visuals for the different data points in a series. The selector property is of type [DataTemplateSelector](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.datatemplateselector?view=net-5.0).

>tip Using PointTemplate is recommended only when the __DefaultVisualStyle__ cannot be used. 
   
__Setting PointTemplate__
```XAML
    <telerik:PointSeries>
      <telerik:PointSeries.PointTemplate>
          <DataTemplate>
              <Ellipse Height="5" Width="11" Fill="Blue"/>
          </DataTemplate>
      </telerik:PointSeries.PointTemplate>
    </telerik:PointSeries>
```

![{{ site.framework_name }} RadChartView ](images/radchartview-custom-point-template.png)
	
## Customizing Point Series

### PointSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __PointSeries__. Your custom style should target the native __Path__ component. 
            
__Setting PointSeries DefaultVisualStyle__  
```XAML
	<telerik:PointSeries.DefaultVisualStyle>
		<Style TargetType="Path">
			  <Setter Property="Fill" Value="YellowGreen"/>
			  <Setter Property="Stroke" Value="Red"/>
			  <Setter Property="StrokeThickness" Value="1"/>
		</Style>
	</telerik:PointSeries.DefaultVisualStyle>  
```

![radchartview-styles-and-templates-pointseries-defaultvisualstyle](images/radchartview-styles-and-templates-pointseries-defaultvisualstyle.png)

### ScatterPointSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterPointSeries__. Your custom style should target the native __Path__ component.

__Setting ScatterPointSeries DefaultVisualStyle__  
```XAML	    
    <telerik:ScatterPointSeries.DefaultVisualStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Green"/>
            <Setter Property="Fill" Value="Orange"/>
            <Setter Property="StrokeThickness" Value="2"/>
        </Style>
    </telerik:ScatterPointSeries.DefaultVisualStyle>  
```

![radchartview-styles-and-templates-scatterpointseries-defaultvisualstyle](images/radchartview-styles-and-templates-scatterpointseries-defaultvisualstyle.png)

## Customizing Line Series

> Since R1 2016 the chart's line series have default visual elements for their data points. This means that you can use the __DefaultVisualStyle__ property to customize the data points visuals. 

### LineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __LineSeries__. Your custom style should target the native __Path__ component.

__Setting LineSeries StrokeShapeStyle__  
```XAML	
    <telerik:LineSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
	</telerik:LineSeries.StrokeShapeStyle>  
```

![radchartview-styles-and-templates-Line Series-Stroke Shape Style](images/radchartview-styles-and-templates-LineSeries-StrokeShapeStyle.png)

### SplineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __SplineSeries__. Your custom style should target the native __Path__ component. 
            
__Setting SplineSeries StrokeShapeStyle__  
```XAML	
    <telerik:SplineSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:SplineSeries.StrokeShapeStyle>
```

![radchartview-styles-and-templates-Spline Series-Stroke Shape Style](images/radchartview-styles-and-templates-SplineSeries-StrokeShapeStyle.png)

### StepLineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __StepLineSeries__. Your custom style should target the native __Path__ component. 
            
__Setting StepLineSeries StrokeShapeStyle__  
```XAML    
    <telerik:StepLineSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:StepLineSeries.StrokeShapeStyle>
```

![radchartview-styles-and-templates-Step Line Series-Stroke Shape Style](images/radchartview-styles-and-templates-StepLineSeries-StrokeShapeStyle.png)

### ScatterLineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterLineSeries__. Your custom style should target the native __Path__ component. 
            
__Setting ScatterLineSeries StrokeShapeStyle__  
```XAML
    <telerik:ScatterLineSeries.StrokeShapeStyle>
      <Style TargetType="Path">
          <Setter Property="Stroke" Value="Red"/>
          <Setter Property="StrokeDashArray" Value="10 5"/>
          <Setter Property="StrokeThickness" Value="3"/>
      </Style>
    </telerik:ScatterLineSeries.StrokeShapeStyle>
```

![radchartview-styles-and-templates-Scatter Line Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterLineSeries-StrokeShapeStyle.png)

### ScatterSplineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterSplineSeries__. Your custom style should target the native __Path__ component. 
            
__Setting ScatterSplineSeries StrokeShapeStyle__  
```XAML    
    <telerik:ScatterSplineSeries.StrokeShapeStyle>
		<Style TargetType="Path">
		  <Setter Property="Stroke" Value="Red"/>
		  <Setter Property="StrokeDashArray" Value="10 5"/>
		  <Setter Property="StrokeThickness" Value="3"/>
		</Style>
    </telerik:ScatterSplineSeries.StrokeShapeStyle>
```

![radchartview-styles-and-templates-Scatter Spline Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterSplineSeries-StrokeShapeStyle.png)

## Customizing Area Series

### AreaSeries

This series expose the following styling properties:            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting AreaSeries StrokeShapeStyle__  
	```XAML
		<telerik:AreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:AreaSeries.StrokeShapeStyle>

	```

	![radchartview-styles-and-templates-Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-AreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
   
	__Setting AreaSeries AreaShapeStyle__  
	```XAML
		<telerik:AreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:AreaSeries.AreaShapeStyle>		  
	```

	![radchartview-styles-and-templates-Area Series-Area Shape Style](images/radchartview-styles-and-templates-AreaSeries-AreaShapeStyle.png)

### RangeSeries

This series expose the following styling properties:

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.

	__Setting RangeSeries StrokeShapeStyle__  
	```XAML
		<telerik:RangeSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:RangeSeries.StrokeShapeStyle>
	```

	![radchartview-styles-and-templates-Area Series-Range Area Shape Style](images/radchartview-styles-and-templates-RangeAreaSeries-StrokeShapeStyle.png)
	
* __StrokeMode__ - it is Enumeration type and determines how the RangeSeries area outline should be painted or not. By default is set to __LowAndHighPoints__. 

	__Setting RangeSeries StrokeShapeStyle__  
	```XAML
		<telerik:RangeSeries  StrokeMode="HighPoints" >
			<telerik:RangeSeries.StrokeShapeStyle>
				<Style TargetType="Path">
					<Setter Property="Stroke" Value="Red"/>
					<Setter Property="StrokeDashArray" Value="10 5"/>
					<Setter Property="StrokeThickness" Value="3"/>
				</Style>
			</telerik:RangeSeries.StrokeShapeStyle>
		</telerik:RangeSeries>	  
	```
	
	![radchartview-styles-and-templates-Area Series-Range Area Shape Style](images/radchartview-styles-and-templates-RangeAreaSeries-StrokeMode.png)
	
* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.

	__Setting RangeSeries AreaShapeStyle__   
	```XAML
		<telerik:RangeSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:RangeSeries.AreaShapeStyle>		  
	```

	![radchartview-styles-and-templates-Area Series-Range Area Shape Style](images/radchartview-styles-and-templates-RangeAreaSeries-AreaShapeStyle.png)
	
>tipRangeSeries expose several additional properties you can use to style its appearance: __Stroke__, __StrokeThickness__, __Fill__, __DashArray__.

### StepAreaSeries

This series expose the following styling properties:            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting StepAreaSeries StrokeShapeStyle__   
	```XAML
		<telerik:StepAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:StepAreaSeries.StrokeShapeStyle>
	```

	![radchartview-styles-and-templates-Step Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-StepAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting StepAreaSeries AreaShapeStyle__   
	```XAML
		<telerik:StepAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:StepAreaSeries.AreaShapeStyle>
	```

	![radchartview-styles-and-templates-Step Area Series-Area Shape Style](images/radchartview-styles-and-templates-StepAreaSeries-AreaShapeStyle.png)

### SplineAreaSeries

This series expose the following styling properties:
            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting SplineAreaSeries StrokeShapeStyle__   
	```XAML
		<telerik:SplineAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:SplineAreaSeries.StrokeShapeStyle>
	```

	![radchartview-styles-and-templates-Spline Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-SplineAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting SplineAreaSeries AreaShapeStyle__   
	```XAML
		<telerik:SplineAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:SplineAreaSeries.AreaShapeStyle>
	```

	![radchartview-styles-and-templates-Spline Area Series-Area Shape Style](images/radchartview-styles-and-templates-SplineAreaSeries-AreaShapeStyle.png)

### ScatterAreaSeries

This series expose the following styling properties:            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
					
	__Setting ScatterAreaSeries StrokeShapeStyle__   
	```XAML
		 <telerik:ScatterAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:ScatterAreaSeries.StrokeShapeStyle>
	```

	![radchartview-styles-and-templates-Scatter Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting ScatterAreaSeries AreaShapeStyle__   
	```XAML
		<telerik:ScatterAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:ScatterAreaSeries.AreaShapeStyle>
	```

	![radchartview-styles-and-templates-Scatter Area Series-Area Shape Style](images/radchartview-styles-and-templates-ScatterAreaSeries-AreaShapeStyle.png)

### ScatterSplineAreaSeries

This series expose the following styling properties:       

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component. 
                
	__Setting ScatterSplineAreaSeries StrokeShapeStyle__   
	```XAML
		<telerik:ScatterSplineAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:ScatterSplineAreaSeries.StrokeShapeStyle>
	```

	![radchartview-styles-and-templates-Scatter Spline Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterSplineAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	__Setting ScatterSplineAreaSeries AreaShapeStyle__   
	```XAML
		<telerik:ScatterSplineAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:ScatterSplineAreaSeries.AreaShapeStyle>
	```

	![radchartview-styles-and-templates-Scatter Spline Area Series-Area Shape Style](images/radchartview-styles-and-templates-ScatterSplineAreaSeries-AreaShapeStyle.png)

## Customizing Bar Series

### BarSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component. 
            
__Setting BarSeries DefaultVisualStyle__   
```XAML
    <telerik:BarSeries.DefaultVisualStyle>
		<Style TargetType="Border">
			<Setter Property="Background" Value="YellowGreen"/>
			<Setter Property="BorderBrush" Value="Red"/>
			<Setter Property="BorderThickness" Value="2"/>
		</Style>
    </telerik:BarSeries.DefaultVisualStyle>
```

![radchartview-styles-and-templates-Bar Series-defaultvisualstyle](images/radchartview-styles-and-templates-BarSeries-defaultvisualstyle.png)

### RangeBarSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component.

__Setting RangeBarSeries DefaultVisualStyle__   
```XAML
    <telerik:RangeBarSeries.DefaultVisualStyle>
      <Style TargetType="Border">
          <Setter Property="Background" Value="YellowGreen"/>
          <Setter Property="BorderBrush" Value="Red"/>
          <Setter Property="BorderThickness" Value="2"/>
      </Style>
    </telerik:RangeBarSeries.DefaultVisualStyle>
```

![radchartview-styles-and-templates-Range Bar Series-defaultvisualstyle](images/radchartview-styles-and-templates-RangeBarSeries-defaultvisualstyle.png)

### ScatterRangeBarSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component.

__Setting ScatterRangeBarSeries DefaultVisualStyle__   
```XAML
    <telerik:ScatterRangeBarSeries.DefaultVisualStyle>
      <Style TargetType="Border">
          <Setter Property="Background" Value="#B4FF8080"/>
          <Setter Property="BorderBrush" Value="Black"/>
          <Setter Property="BorderThickness" Value="1"/>
      </Style>
    </telerik:ScatterRangeBarSeries.DefaultVisualStyle>
```

![radchartview-styles-and-templates-Range Bar Series-defaultvisualstyle](images/radchartview-styles-and-templates-ScatterRangeBarSeries-defaultvisualstyle.png)

## Customizing Financial Series

### OhlcSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native {% if site.site_name == 'WPF' %}[OhlcStick](http://www.telerik.com/help/wpf/t_telerik_windows_controls_chartview_ohlcstick.html){% else %}[OhlcStick](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_chartview_ohlcstick.html){% endif %} component. 
            
__Setting OhlcSeries DefaultVisualStyle__   
```XAML
    <telerik:OhlcSeries.DefaultVisualStyle>
      <Style TargetType="telerikChartView:OhlcStick">
          <Setter Property="MinHeight" Value="1"/>
          <Setter Property="StrokeThickness" Value="1"/>
          <Setter Property="UpStroke" Value="GreenYellow"/>
          <Setter Property="DownStroke" Value="Red"/>
      </Style>
    </telerik:OhlcSeries.DefaultVisualStyle>
```

![radchartview-styles-and-templates-Ohlc Series-defaultvisualstyle](images/radchartview-styles-and-templates-OhlcSeries-defaultvisualstyle.png)

### CandlestickSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native {% if site.site_name == 'WPF' %}[Candlestick](http://www.telerik.com/help/wpf/t_telerik_windows_controls_charting_candlestick.html){% else %}[Candlestick](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_charting_candlestick.html){% endif %} component.            

__Setting CandlestickSeries DefaultVisualStyle__   
```XAML
    <telerik:CandlestickSeries.DefaultVisualStyle>
        <Style TargetType="telerikChartView:Candlestick">
            <Setter Property="MinHeight" Value="1"/>
            <Setter Property="StrokeThickness" Value="1"/>
            <Setter Property="UpStroke" Value="GreenYellow"/>
            <Setter Property="DownStroke" Value="Red"/>
        </Style>
    </telerik:CandlestickSeries.DefaultVisualStyle>
```

![radchartview-styles-and-templates-Candlestick Series-defaultvisualstyle](images/radchartview-styles-and-templates-CandlestickSeries-defaultvisualstyle.png)

## Customizing Box Plot Series

The BoxPlotSeries exposes a __DefaultVisualStyle__ property that allows you to customize the visual elements representing the data points. The property accepts a Style targeting the __BoxPlotShape__ element. The style can be used to change the stroke and fill of the visual element.

__Setting BoxPlotSeries DefaultVisualStyle__   
```XAML
	<telerik:BoxPlotSeries.DefaultVisualStyle>
		<Style TargetType="telerik:BoxPlotShape">
			<Setter Property="Fill" Value="#222DA68D" />
			<Setter Property="Stroke" Value="#2DA68D" />
			<Setter Property="StrokeThickness" Value="1" />
		</Style>
	</telerik:BoxPlotSeries.DefaultVisualStyle>
```

![radchartview-styles-and-templates-boxplot Series-defaultvisualstyle](images/radchartview-styles-and-templates-boxplotseries-defaultvisualstyle.png)

## Customizing Error Bar Series

The ErrorBarSeries exposes a __DefaultVisualStyle__ property that allows you to customize the visual elements representing the data points. The property accepts a Style targeting the __ErrorBarShape__ element. The style can be used to change the colors of the visual and also its caps size, marker visibility, and marker size.

__Setting ErrorBarSeries DefaultVisualStyle__   
```XAML
	<telerik:ErrorBarSeries.DefaultVisualStyle>
		<Style TargetType="telerik:ErrorBarShape">
			<Setter Property="Fill" Value="#2DA68D" />
			<Setter Property="Stroke" Value="#2DA68D" />
			<Setter Property="StrokeThickness" Value="2" />
			<Setter Property="ShowMarker" Value="True"/>
			<Setter Property="CapLength" Value="0.5" />
			<Setter Property="MarkerSize" Value="25, 25"/>
		</Style>
	</telerik:ErrorBarSeries.DefaultVisualStyle>
```

The `CapLength` property controls the size of the caps shown at both ends of the error bar. The property works with relative units between 0 and 1. 

The `MarkerSize` property determines the size of the marker. The property works with absolute value, which means that the marker has fixed size. If the `MarkerSize` is set to `null`, the marker will resize according to the cap length.

![radchartview-styles-and-templates-errorbarseries Series-defaultvisualstyle](images/radchartview-styles-and-templates-errorbarseries-defaultvisualstyle.png)

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Customizing PolarChart Series]({%slug radchartview-styles-and-templates-customizing-polarchart-series%})
 * [Customizing PieChart Series]({%slug radchartview-styles-and-templates-customizing-piechart-series%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
