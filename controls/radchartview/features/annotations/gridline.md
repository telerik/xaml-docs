---
title: GridLine Annotations
page_title: GridLine Annotations
description: GridLine Annotations
slug: radchartview-annotations-gridline
tags: gridline,annotations
publish: True
position: 2
---

# GridLine Annotations



GridLine annotations are lines or circles that cross the chart grid at location 
        on the axis, specified by their __Value__ property.
    

## Cartesian GridLine Annotation

In the case of the CartesianChart, the GridLine represents a vertical or horizontal line 
          that crosses the entire plot area.
        

Here is what __CartesianGridLineAnnotation__ looks like:
        

#### __XAML__

{{region radchartview_annotations_gridline_0}}
	<telerik:CartesianGridLineAnnotation Value="6" Stroke="Red" StrokeThickness="1" Axis="{Binding ElementName=verticalAxis}"/>
	<telerik:CartesianGridLineAnnotation Value="2.8" Stroke="Blue" StrokeThickness="1" Axis="{Binding ElementName=horizontalAxis}"/>
	{{endregion}}

![Rad Chart View-annotations-cartesian-gridline](images/RadChartView-annotations-cartesian-gridline.png)

## Polar Axis GridLine Annotation

Polar Axis GridLines represent concentric circles that cross the polar axis at the 
          corresponding __Value__.
        

Here is what __PolarAxisGridLineAnnotation__ looks like:
        

#### __XAML__

{{region radchartview_annotations_gridline_1}}
	<telerik:PolarAxisGridLineAnnotation Value="2" Stroke="Red"/>
	<telerik:PolarAxisGridLineAnnotation Value="7" Stroke="LightGreen"/>
	<telerik:PolarAxisGridLineAnnotation Value="8" Stroke="LightBlue"/>
	{{endregion}}

![Rad Chart View-annotations-polar-gridline](images/RadChartView-annotations-polar-gridline.png)

## Radial Axis GridLine Annotation

Radial Axis GridLines basically represent the radius of the PolarChart.
        

Here is what __RadialAxisGridLineAnnotation__ looks like:
        

#### __XAML__

{{region radchartview_annotations_gridline_2}}
	<telerik:RadialAxisGridLineAnnotation Value="30" Stroke="Red"/>
	<telerik:RadialAxisGridLineAnnotation Value="60" Stroke="LightGreen"/>
	<telerik:RadialAxisGridLineAnnotation Value="90" Stroke="LightBlue"/>
	{{endregion}}

![Rad Chart View-annotations-radial-gridline](images/RadChartView-annotations-radial-gridline.png)

## Properties

Common:
        

* __DashArray__

* __Stroke__

* __StrokeThickness__

Cartesian:
        

* __Axis__The Cartesian GridLine Annotation needs to be associated with horizontal or vertical axis explicitly.
            

* __Value__ (of type object)
            The place on the associated axis where the annotation crosses it.
            *When the associated axis is numerical (Linear or Logarithmic) a numeric value is expected and
              when it is a CategoricalAxis - a category.
            

* __Label__The string that is displayed in the label.
            

* __LabelDefinition__Defines the position of the annotation label, check the
              [Annotation Labels]({%slug radchartview-annotations-labels%}) 
              help topic for more details.
            

Polar:
        

* __Value__ (of type double)
            Specifies the location on the polar axis (the radius), where the grid line will cross.
            

Radial:
        

* __Value__ (of type object)
            Specifies the location on the radial axis, where the grid line will cross.
            *When the radial axis is NumericRadialAxis a numeric value is expected and when it is a CategoricalRadialAxis - a category.
            

# See Also
