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
      

## Customizing Point Series

### PointSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __PointSeries__. Your custom style should target the native __Path__ component. You can set the property like this:
            
#### XAML

{{region radchartview-customizing-cartesianchart-series}}

    <telerik:PointSeries.DefaultVisualStyle>
        <Style TargetType="Path">
              <Setter Property="Fill" Value="YellowGreen"/>
              <Setter Property="Stroke" Value="Red"/>
              <Setter Property="StrokeThickness" Value="1"/>
        </Style>
    </telerik:PointSeries.DefaultVisualStyle>
  
{{endregion}}


>tipSince __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-pointseries-defaultvisualstyle](images/radchartview-styles-and-templates-pointseries-defaultvisualstyle.png)

### ScatterPointSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterPointSeries__. Your custom style should target the native __Path__ component. You can set the property like this:

#### XAML

{{region radchartview-customizing-cartesianchart-series2}}	
    
    <telerik:ScatterPointSeries.DefaultVisualStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Green"/>
            <Setter Property="Fill" Value="Orange"/>
            <Setter Property="StrokeThickness" Value="2"/>
        </Style>
    </telerik:ScatterPointSeries.DefaultVisualStyle>
  
{{endregion}}


>tipSince __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-scatterpointseries-defaultvisualstyle](images/radchartview-styles-and-templates-scatterpointseries-defaultvisualstyle.png)

## Customizing Line Series

### LineSeries

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __LineSeries__. Your custom style should target the native __Path__ component. You can set the property like this:
            
#### XAML

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

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __SplineSeries__. Your custom style should target the native __Path__ component. You can set the property like this:
            
#### XAML

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

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __StepLineSeries__. Your custom style should target the native __Path__ component. You can set the property like this:
            
#### XAML

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

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterLineSeries__. Your custom style should target the native __Path__ component. You can set the property like this:
            
#### XAML

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

This series expose the __StrokeShapeStyle__ property. It is of type __Style__ and determines the appearance of the [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) element used to visualize the __ScatterSplineSeries__. Your custom style should target the native __Path__ component. You can set the property like this:
            
#### XAML

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
                
#### XAML

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
                
#### XAML
{{region radchartview-customizing-cartesianchart-series9}}
    <telerik:AreaSeries.AreaShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Fill" Value="Bisque"/>
        </Style>
    </telerik:AreaSeries.AreaShapeStyle>		  
{{endregion}}

![radchartview-styles-and-templates-Area Series-Area Shape Style](images/radchartview-styles-and-templates-AreaSeries-AreaShapeStyle.png)

### StepAreaSeries

This series expose the following styling properties:
            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component.
                
#### XAML

{{region radchartview-customizing-cartesianchart-series10}}

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
                
#### XAML

{{region radchartview-customizing-cartesianchart-series11}}

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
                
#### XAML

{{region radchartview-customizing-cartesianchart-series12}}

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
                
#### XAML

{{region radchartview-customizing-cartesianchart-series13}}

    <telerik:SplineAreaSeries.AreaShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Fill" Value="Bisque"/>
        </Style>
    </telerik:SplineAreaSeries.AreaShapeStyle>		  

{{endregion}}

![radchartview-styles-and-templates-Spline Area Series-Area Shape Style](images/radchartview-styles-and-templates-SplineAreaSeries-AreaShapeStyle.png)

### ScatterAreaSeries

This series expose the following styling properties:
            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component. You can set the property in XAML like this:
                
#### XAML

{{region radchartview-customizing-cartesianchart-series14}}

     <telerik:ScatterAreaSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:ScatterAreaSeries.StrokeShapeStyle>

{{endregion}}

![radchartview-styles-and-templates-Scatter Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component. You can set the property in XAML like this:
                
#### XAML

{{region radchartview-customizing-cartesianchart-series15}}

    <telerik:ScatterAreaSeries.AreaShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Fill" Value="Bisque"/>
        </Style>
    </telerik:ScatterAreaSeries.AreaShapeStyle>

{{endregion}}

![radchartview-styles-and-templates-Scatter Area Series-Area Shape Style](images/radchartview-styles-and-templates-ScatterAreaSeries-AreaShapeStyle.png)

### ScatterSplineAreaSeries

This series expose the following styling properties:
            

* __StrokeShapeStyle__ - it is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component. You can set the property in XAML like this:
                
#### XAML

{{region radchartview-customizing-cartesianchart-series16}}

    <telerik:ScatterSplineAreaSeries.StrokeShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="10 5"/>
            <Setter Property="StrokeThickness" Value="3"/>
        </Style>
    </telerik:ScatterSplineAreaSeries.StrokeShapeStyle>

{{endregion}}

![radchartview-styles-and-templates-Scatter Spline Area Series-Stroke Shape Style](images/radchartview-styles-and-templates-ScatterSplineAreaSeries-StrokeShapeStyle.png)

* __AreaShapeStyle__ - it is of type __Style__ and determines the appearance of the area, locked between the axis and the line. Your custom style should target the native [Path](http://msdn.microsoft.com/en-us/library/system.windows.shapes.path(v=vs.110).aspx) component. You can set the property in XAML like this:
                
#### XAML

{{region radchartview-customizing-cartesianchart-series17}}

    <telerik:ScatterSplineAreaSeries.AreaShapeStyle>
        <Style TargetType="Path">
            <Setter Property="Fill" Value="Bisque"/>
        </Style>
    </telerik:ScatterSplineAreaSeries.AreaShapeStyle>

{{endregion}}

![radchartview-styles-and-templates-Scatter Spline Area Series-Area Shape Style](images/radchartview-styles-and-templates-ScatterSplineAreaSeries-AreaShapeStyle.png)

## Customizing Bar Series

### BarSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component. You can set the property in XAML like this:
            
#### XAML

{{region radchartview-customizing-cartesianchart-series18}}

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

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native [Border](http://msdn.microsoft.com/en-us/library/system.windows.controls.border(v=vs.110).aspx) component. You can set the property in XAML like this:
#### XAML
{{region radchartview-customizing-cartesianchart-series}}
    <telerik:RangeBarSeries.DefaultVisualStyle>
      <Style TargetType="Border">
          <Setter Property="Background" Value="YellowGreen"/>
          <Setter Property="BorderBrush" Value="Red"/>
          <Setter Property="BorderThickness" Value="2"/>
      </Style>
    </telerik:RangeBarSeries.DefaultVisualStyle>
{{endregion}}


>tipSince __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-Range Bar Series-defaultvisualstyle](images/radchartview-styles-and-templates-RangeBarSeries-defaultvisualstyle.png)

## Customizing Financial Series

### OhlcSeries

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native {% if site.site_name == 'WPF' %}[OhlcStick](http://www.telerik.com/help/wpf/t_telerik_windows_controls_chartview_ohlcstick.html){% endif %}{% if site.site_name == 'Silverlight' %}[OhlcStick](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_chartview_ohlcstick.html){% endif %} component. You can set the property in XAML like this:
            
#### XAML

{{region radchartview-customizing-cartesianchart-series}}

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

This series expose the __DefaultVisualStyle__ property. It is of type __Style__ and determines the appearance of the series. Your custom style should target the native {% if site.site_name == 'WPF' %}[Candlestick](http://www.telerik.com/help/wpf/t_telerik_windows_controls_charting_candlestick.html){% endif %}{% if site.site_name == 'Silverlight' %}[Candlestick](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_charting_candlestick.html){% endif %} component. You can set the property in XAML like this:
            

#### XAML

{{region radchartview-customizing-cartesianchart-series}}
    <telerik:CandlestickSeries.DefaultVisualStyle>
        <Style TargetType="telerikChartView:Candlestick">
            <Setter Property="MinHeight" Value="1"/>
            <Setter Property="StrokeThickness" Value="1"/>
            <Setter Property="UpStroke" Value="GreenYellow"/>
            <Setter Property="DownStroke" Value="Red"/>
        </Style>
    </telerik:CandlestickSeries.DefaultVisualStyle>
{{endregion}}

>tipSince __Q1 2014__ all series exposing the __DefaultVisualStyle__ property, also expose the __DefaultVisualStyleSelector__ property. It is of type [StyleSelector](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector(v=vs.110).aspx) and gets or sets custom style-selection logic for a style that can be applied to each generated element.

![radchartview-styles-and-templates-Candlestick Series-defaultvisualstyle](images/radchartview-styles-and-templates-CandlestickSeries-defaultvisualstyle.png)

## Customizing  DataPoints DataTemplate

All series supported by the __RadCartesianChart__ expose a __PointTemplate__ property.
        

>tipThis property should be used only when the __DefaultVisualStyle__ cannot be used.
          

It is of type __DataTemplate__ and gets or sets the template that describes the visual representation of the __DataPoints__ in a series. You can set the property in XAML like this:
        
#### XAML

{{region radchartview-customizing-cartesianchart-series}}

    <telerik:PointSeries>
      <telerik:PointSeries.PointTemplate>
          <DataTemplate>
              <Ellipse Height="5" Width="11" Fill="Blue"/>
          </DataTemplate>
      </telerik:PointSeries.PointTemplate>
    </telerik:PointSeries>

{{endregion}}


The above definition will change the default visualization of the DataPoint visuals like this:

![radchartview-custom-point-template](images/radchartview-custom-point-template.png)

# See Also

 * [Customizing PolarChart Series]({%slug radchartview-styles-and-templates-customizing-polarchart-series%})

 * [Customizing PieChart Series]({%slug radchartview-styles-and-templates-customizing-piechart-series%})
