---
title: Customizing CartesianChart Series
page_title: Customizing CartesianChart Series
description: Customizing CartesianChart Series
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
	
## Customizing Data Points Using DefaultVisualStyle

The different chart series use different visual elements to display their data points - a bar, an ellipse, etc. You can apply a custom style for those elements via the __DefaultVisualStyle__ property. The property accepts a value of type __Style__ which targets the visual element of the corresponding series. There is an additional __DefaultVisualStyleSelector__ property which can be used to apply different style for the different data point visuals in a series.

#### __[XAML] Example 1: Setting DefaultVisualStyle of BarSeries__
{{region radchartview-customizing-cartesianchart-series26}}
    <telerik:BarSeries>
		<telerik:BarSeries.DefaultVisualStyle>
			<Style TargetType="Border">
				<Setter Property="Background" Value="#F47748" />
			</Style>
		</telerik:BarSeries.DefaultVisualStyle>
    </telerik:BarSeries>
{{endregion}}

![](images/radchartview-styles-and-templates-customize-cartesianseries-1.png)

Since Q1 2016, all Cartesian series (excluding RangeSeries) are rendering default visuals using the DefaultVisualStyle property. So, you can use it also with line and area series to display their data point visuals which don't exist by default. Note that when using line or area series you will need to set also the size of the visual. Otherwise it won't be displayed.

#### __[XAML] Example 2: Setting DefaultVisualStyle of LineSeries__
{{region radchartview-customizing-cartesianchart-series27}}
    <telerik:LineSeries>
      <telerik:LineSeries.DefaultVisualStyle>
		<Style TargetType="Path">
			<Setter Property="Width" Value="10" />
			<Setter Property="Height" Value="10" />
			<Setter Property="Fill" Value="#FF5AC3" />
		</Style>
      </telerik:LineSeries.DefaultVisualStyle>
    </telerik:LineSeries>
{{endregion}}

![](images/radchartview-styles-and-templates-customize-cartesianseries-0.png)
	
> When using a [Palette]({%slug radchartview-features-palettes-introduction%}) the series' default visual will ignore the color defined in the DefaultVisualStyle and it will use the one provided by the palette.

## Customizing Data Points Using PointTemplate

All series supported by the __RadCartesianChart__ expose a __PointTemplate__ property. It is of type __DataTemplate__ and gets or sets the template that describes the visual representation of the data points in a series. There is an additiona __PointTemplateSelector__ property which can be used to apply different visuals for the different data points in a series. 

>tip Using PointTemplate is recommended only when the __DefaultVisualStyle__ cannot be used. 
   
#### __[XAML] Example 3: Setting PointTemplate__
{{region radchartview-customizing-cartesianchart-series25}}
    <telerik:PointSeries>
      <telerik:PointSeries.PointTemplate>
          <DataTemplate>
              <Ellipse Height="5" Width="11" Fill="Blue"/>
          </DataTemplate>
      </telerik:PointSeries.PointTemplate>
    </telerik:PointSeries>
{{endregion}}

![](images/radchartview-custom-point-template.png)
	
## Customizing Point Series

### PointSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __PointSeries__. Your custom style should target the native __Path__ component. 
            
#### __[XAML] Example 4: Setting PointSeries DefaultVisualStyle__  
{{region radchartview-customizing-cartesianchart-series1}}
	<telerik:PointSeries.DefaultVisualStyle>
		<Style TargetType="Path">
			  <Setter Property="Fill" Value="YellowGreen"/>
			  <Setter Property="Stroke" Value="Red"/>
			  <Setter Property="StrokeThickness" Value="1"/>
		</Style>
	</telerik:PointSeries.DefaultVisualStyle>  
{{endregion}}

>tip Since __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-pointseries-defaultvisualstyle](images/radchartview-styles-and-templates-pointseries-defaultvisualstyle.png)

### ScatterPointSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterPointSeries__. Your custom style should target the native __Path__ component.

#### __[XAML] Example 5: Setting ScatterPointSeries DefaultVisualStyle__  
{{region radchartview-customizing-cartesianchart-series2}}	    
    <telerik:ScatterPointSeries.DefaultVisualStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Green"/>
            <Setter Property="Fill" Value="Orange"/>
            <Setter Property="StrokeThickness" Value="2"/>
        </Style>
    </telerik:ScatterPointSeries.DefaultVisualStyle>  
{{endregion}}

>tip Since __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-scatterpointseries-defaultvisualstyle](images/radchartview-styles-and-templates-scatterpointseries-defaultvisualstyle.png)

## Customizing Line Series

> Since R1 2016 the chart's line series have default visual elements for their data points. This means that you can use the __DefaultVisualStyle__ property to customize the data points visuals. 

### LineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __LineSeries__. Your custom style should target the native __Path__ component.

#### __[XAML] Example 6: Setting LineSeries StrokeShapeStyle__  
{{region radchartview-customizing-cartesianchart-series3}}
	
    <telerik:LineSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:LineSeries.StrokeShapeStyle>
  
{{endregion}}

![radchartview-styles-and-templates-Line Series-Stroke Shape Style](images/radchartview-styles-and-templates-LineSeries-StrokeShapeStyle.png)

### SplineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __SplineSeries__. Your custom style should target the native __Path__ component. 
            
#### __[XAML] Example 7: Setting SplineSeries StrokeShapeStyle__  
{{region radchartview-customizing-cartesianchart-series4}}
	
    <telerik:SplineSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:SplineSeries.StrokeShapeStyle>	
	  
{{endregion}}

![radchartview-styles-and-templates-Spline Series-Stroke Shape Style](images/radchartview-styles-and-templates-SplineSeries-StrokeShapeStyle.png)

### StepLineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __StepLineSeries__. Your custom style should target the native __Path__ component. 
            
#### __[XAML] Example 8: Setting StepLineSeries StrokeShapeStyle__  
{{region radchartview-customizing-cartesianchart-series5}}
    
    <telerik:StepLineSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:StepLineSeries.StrokeShapeStyle>		  
    
{{endregion}}

![radchartview-styles-and-templates-Step Line Series-Stroke Shape Style](images/radchartview-styles-and-templates-StepLineSeries-StrokeShapeStyle.png)

### ScatterLineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterLineSeries__. Your custom style should target the native __Path__ component. 
            
#### __[XAML] Example 9: Setting ScatterLineSeries StrokeShapeStyle__  
{{region radchartview-customizing-cartesianchart-series6}}

    <telerik:ScatterLineSeries.StrokeShapeStyle>
      <Style TargetType="Path">
          <Setter Property="Stroke" Value="Red"/>
          <Setter Property="StrokeDashArray" Value="10 5"/>
          <Setter Property="StrokeThickness" Value="3"/>
      </Style>
    </telerik:ScatterLineSeries.StrokeShapeStyle>

{{endregion}}

![radchartview-styles-and-templates-Scatter Line Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterLineSeries-StrokeShapeStyle.png)

### ScatterSplineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterSplineSeries__. Your custom style should target the native __Path__ component. 
            
#### __[XAML] Example 10: Setting ScatterSplineSeries StrokeShapeStyle__  
{{region radchartview-customizing-cartesianchart-series7}}
    
    <telerik:ScatterSplineSeries.StrokeShapeStyle>
      <Style TargetType="Path">
          <Setter Property="Stroke" Value="Red"/>
          <Setter Property="StrokeDashArray" Value="10 5"/>
          <Setter Property="StrokeThickness" Value="3"/>
      </Style>
    </telerik:ScatterSplineSeries.StrokeShapeStyle>

{{endregion}}

![radchartview-styles-and-templates-Scatter Spline Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterSplineSeries-StrokeShapeStyle.png)

## Customizing Area Series

### AreaSeries

This series expose the following styling properties:
            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 11: Setting AreaSeries StrokeShapeStyle__  
	{{region radchartview-customizing-cartesianchart-series8}}

		<telerik:AreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:AreaSeries.StrokeShapeStyle>

	{{endregion}}

	![radchartview-styles-and-templates-Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-AreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
   
	#### __[XAML] Example 12: Setting AreaSeries AreaShapeStyle__  
	{{region radchartview-customizing-cartesianchart-series9}}
		<telerik:AreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:AreaSeries.AreaShapeStyle>		  
	{{endregion}}

	![radchartview-styles-and-templates-Area Series-Area Shape Style](images/radchartview-styles-and-templates-AreaSeries-AreaShapeStyle.png)

### RangeSeries

This series expose the following styling properties:

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.

	#### __[XAML] Example 13: Setting RangeSeries StrokeShapeStyle__  
	{{region radchartview-customizing-cartesianchart-series10}}
		<telerik:RangeSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:RangeSeries.StrokeShapeStyle>
	{{endregion}}

	![radchartview-styles-and-templates-Area Series-Range Area Shape Style](images/radchartview-styles-and-templates-RangeAreaSeries-StrokeShapeStyle.png)
	
* __StrokeMode__ - it is Enumeration type and determines how the RangeSeries area outline should be painted or not. By default is set to __LowAndHighPoints__. 

	#### __[XAML] Example 14: Setting RangeSeries StrokeShapeStyle__  
	{{region radchartview-customizing-cartesianchart-series11}}
		<telerik:RangeSeries  StrokeMode="HighPoints" >
			<telerik:RangeSeries.StrokeShapeStyle>
				<Style TargetType="Path">
					<Setter Property="Stroke" Value="Red"/>
					<Setter Property="StrokeDashArray" Value="10 5"/>
					<Setter Property="StrokeThickness" Value="3"/>
				</Style>
			</telerik:RangeSeries.StrokeShapeStyle>
		</telerik:RangeSeries>	  
	{{endregion}}
	
	![radchartview-styles-and-templates-Area Series-Range Area Shape Style](images/radchartview-styles-and-templates-RangeAreaSeries-StrokeMode.png)
	
* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.

	#### __[XAML] Example 15: Setting RangeSeries AreaShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series12}}
		<telerik:RangeSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:RangeSeries.AreaShapeStyle>		  
	{{endregion}}

	![radchartview-styles-and-templates-Area Series-Range Area Shape Style](images/radchartview-styles-and-templates-RangeAreaSeries-AreaShapeStyle.png)
	
>tipRangeSeries expose several additional properties you can use to style its appearance: __Stroke__, __StrokeThickness__, __Fill__, __DashArray__.

### StepAreaSeries

This series expose the following styling properties:            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 16: Setting StepAreaSeries StrokeShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series13}}

		<telerik:StepAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:StepAreaSeries.StrokeShapeStyle>

	{{endregion}}

	![radchartview-styles-and-templates-Step Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-StepAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 17: Setting StepAreaSeries AreaShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series14}}

		<telerik:StepAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:StepAreaSeries.AreaShapeStyle>		

	{{endregion}}

	![radchartview-styles-and-templates-Step Area Series-Area Shape Style](images/radchartview-styles-and-templates-StepAreaSeries-AreaShapeStyle.png)

### SplineAreaSeries

This series expose the following styling properties:
            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 18: Setting SplineAreaSeries StrokeShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series15}}

		<telerik:SplineAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:SplineAreaSeries.StrokeShapeStyle>		  

	{{endregion}}

	![radchartview-styles-and-templates-Spline Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-SplineAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 19: Setting SplineAreaSeries AreaShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series16}}

		<telerik:SplineAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:SplineAreaSeries.AreaShapeStyle>		  

	{{endregion}}

	![radchartview-styles-and-templates-Spline Area Series-Area Shape Style](images/radchartview-styles-and-templates-SplineAreaSeries-AreaShapeStyle.png)

### ScatterAreaSeries

This series expose the following styling properties:            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
					
	#### __[XAML] Example 20: Setting ScatterAreaSeries StrokeShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series17}}

		 <telerik:ScatterAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:ScatterAreaSeries.StrokeShapeStyle>

	{{endregion}}

	![radchartview-styles-and-templates-Scatter Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 21: Setting ScatterAreaSeries AreaShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series18}}

		<telerik:ScatterAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:ScatterAreaSeries.AreaShapeStyle>

	{{endregion}}

	![radchartview-styles-and-templates-Scatter Area Series-Area Shape Style](images/radchartview-styles-and-templates-ScatterAreaSeries-AreaShapeStyle.png)

### ScatterSplineAreaSeries

This series expose the following styling properties:       

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component. 
                
	#### __[XAML] Example 22: Setting ScatterSplineAreaSeries StrokeShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series19}}

		<telerik:ScatterSplineAreaSeries.StrokeShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Stroke" Value="Red"/>
				<Setter Property="StrokeDashArray" Value="10 5"/>
				<Setter Property="StrokeThickness" Value="3"/>
			</Style>
		</telerik:ScatterSplineAreaSeries.StrokeShapeStyle>

	{{endregion}}

	![radchartview-styles-and-templates-Scatter Spline Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterSplineAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
	#### __[XAML] Example 23: Setting ScatterSplineAreaSeries AreaShapeStyle__   
	{{region radchartview-customizing-cartesianchart-series20}}

		<telerik:ScatterSplineAreaSeries.AreaShapeStyle>
			<Style TargetType="Path">
				<Setter Property="Fill" Value="Bisque"/>
			</Style>
		</telerik:ScatterSplineAreaSeries.AreaShapeStyle>

	{{endregion}}

	![radchartview-styles-and-templates-Scatter Spline Area Series-Area Shape Style](images/radchartview-styles-and-templates-ScatterSplineAreaSeries-AreaShapeStyle.png)

## Customizing Bar Series

### BarSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component. 
            
#### __[XAML] Example 24: Setting BarSeries DefaultVisualStyle__   

{{region radchartview-customizing-cartesianchart-series21}}

    <telerik:BarSeries.DefaultVisualStyle>
      <Style TargetType="Border">
          <Setter Property="Background" Value="YellowGreen"/>
          <Setter Property="BorderBrush" Value="Red"/>
          <Setter Property="BorderThickness" Value="2"/>
      </Style>
    </telerik:BarSeries.DefaultVisualStyle>

{{endregion}}

>tipSince __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-Bar Series-defaultvisualstyle](images/radchartview-styles-and-templates-BarSeries-defaultvisualstyle.png)

### RangeBarSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component.

#### __[XAML] Example 25: Setting RangeBarSeries DefaultVisualStyle__   
{{region radchartview-customizing-cartesianchart-series22}}
    <telerik:RangeBarSeries.DefaultVisualStyle>
      <Style TargetType="Border">
          <Setter Property="Background" Value="YellowGreen"/>
          <Setter Property="BorderBrush" Value="Red"/>
          <Setter Property="BorderThickness" Value="2"/>
      </Style>
    </telerik:RangeBarSeries.DefaultVisualStyle>
{{endregion}}

>tip Since __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-Range Bar Series-defaultvisualstyle](images/radchartview-styles-and-templates-RangeBarSeries-defaultvisualstyle.png)

## Customizing Financial Series

### OhlcSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native {% if site.site_name == 'WPF' %}[OhlcStick](http://www.telerik.com/help/wpf/t_telerik_windows_controls_chartview_ohlcstick.html){% endif %}{% if site.site_name == 'Silverlight' %}[OhlcStick](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_chartview_ohlcstick.html){% endif %} component. 
            
#### __[XAML] Example 26: Setting OhlcSeries DefaultVisualStyle__   
{{region radchartview-customizing-cartesianchart-series23}}
    <telerik:OhlcSeries.DefaultVisualStyle>
      <Style TargetType="telerikChartView:OhlcStick">
          <Setter Property="MinHeight" Value="1"/>
          <Setter Property="StrokeThickness" Value="1"/>
          <Setter Property="UpStroke" Value="GreenYellow"/>
          <Setter Property="DownStroke" Value="Red"/>
      </Style>
    </telerik:OhlcSeries.DefaultVisualStyle>
{{endregion}}

>tipSince __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-Ohlc Series-defaultvisualstyle](images/radchartview-styles-and-templates-OhlcSeries-defaultvisualstyle.png)

### CandlestickSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native {% if site.site_name == 'WPF' %}[Candlestick](http://www.telerik.com/help/wpf/t_telerik_windows_controls_charting_candlestick.html){% endif %}{% if site.site_name == 'Silverlight' %}[Candlestick](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_charting_candlestick.html){% endif %} component.            

#### __[XAML] Example 27: Setting CandlestickSeries DefaultVisualStyle__   
{{region radchartview-customizing-cartesianchart-series24}}
    <telerik:CandlestickSeries.DefaultVisualStyle>
        <Style TargetType="telerikChartView:Candlestick">
            <Setter Property="MinHeight" Value="1"/>
            <Setter Property="StrokeThickness" Value="1"/>
            <Setter Property="UpStroke" Value="GreenYellow"/>
            <Setter Property="DownStroke" Value="Red"/>
        </Style>
    </telerik:CandlestickSeries.DefaultVisualStyle>
{{endregion}}

>tip Since __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-Candlestick Series-defaultvisualstyle](images/radchartview-styles-and-templates-CandlestickSeries-defaultvisualstyle.png)

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Customizing PolarChart Series]({%slug radchartview-styles-and-templates-customizing-polarchart-series%})
 * [Customizing PieChart Series]({%slug radchartview-styles-and-templates-customizing-piechart-series%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
