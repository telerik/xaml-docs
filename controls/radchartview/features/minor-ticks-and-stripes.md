---
title: Minor Ticks and Stripes
page_title: Minor Ticks and Stripes
description: Display minor ticks and stripes in RadChartView.
slug: radchartview-minor-ticks-and-stripes
tags: minor, ticks, stripes
published: True
position: 3
---

# Minor Ticks and Stripes

As of **R2 2022** the RadChartView control allows you to display **minor ticks and stripes** in addition to the major ticks and stripes.

## Minor Ticks

The minor ticks functionality is supported by the following types of axes:

* `NumericalAxis` (`LinearAxis` and `LogarithmicAxis`)
* `DateTimeContinuousAxis`
* `PolarAxis`
* `NumericRadialAxis`

The visibility and appearance of the minor ticks can be controlled via the following properties of these axes:

* `MinorTicksPerMajor`&mdash;The number of minor ticks per major interval.
* `MinorTickLength`&mdash;The length of the minor tick.
* `MinorTickOffset`&mdash;Index-based offset of the first tick to be displayed.
* `MinorTickTemplate`&mdash;The template that defines the appearance of all minor ticks present on the axis.
* `MinorTickStyle`&mdash;The style for each `Rectangle` instance created to represent a minor tick when no `MinorTickTemplate` is specified.

__Cartesian Chart with customized minor ticks__
```XAML
    <telerik:RadCartesianChart>
        <telerik:RadCartesianChart.HorizontalAxis>
            <telerik:LinearAxis Maximum="100"
                                DesiredTickCount="10" 
                                MinorTicksPerMajor="3"
                                MinorTickLength="10">
                <telerik:LinearAxis.MinorTickStyle>
                    <Style TargetType="Rectangle">
                        <Setter Property="Fill" Value="Blue" />
                    </Style>
                </telerik:LinearAxis.MinorTickStyle>
            </telerik:LinearAxis>
        </telerik:RadCartesianChart.HorizontalAxis>
        <telerik:RadCartesianChart.VerticalAxis>
            <telerik:LinearAxis Maximum="100" />
        </telerik:RadCartesianChart.VerticalAxis>
        <telerik:RadCartesianChart.Series>
            <telerik:ScatterPointSeries>
                <telerik:ScatterPointSeries.DataPoints>
                    <!-- ... -->
                </telerik:ScatterPointSeries.DataPoints>
            </telerik:ScatterPointSeries>
        </telerik:RadCartesianChart.Series>
    </telerik:RadCartesianChart>
```

![Cartesian Chart with customized minor ticks](images/radchartview-minor-ticks-and-stripes-0.png)

## Stripes

In addition to the new minor tick functionality, both the [CartesianChartGrid]({%slug radchartview-cartesianchartgrid-and-polarchartgrid%}#cartesianchartgrid) and [PolarChartGrid]({%slug radchartview-cartesianchartgrid-and-polarchartgrid%}#polarchartgrid) now expose properties to control the visibility and appearance of the minor grid and strip lines.

### CartesianChartGrid

The CartesianChartGrid provides the following properties for customization of the grid and strip lines:

* `MinorLinesVisibility`&mdash;The visibility of minor grid lines. A value of type `GridLineVisibility` which can be either `None`, `X`, `Y` or `XY`.
* `MinorStripLinesVisibility`&mdash;The visibility of the grid's stripes. A value of type `GridLineVisibility` which can be either `None`, `X`, `Y` or `XY`.
* `MinorXLineStyle`&mdash;The style that defines the appearance of the minor lines along the X-axis.
* `MinorYLineStyle`&mdash;The style that defines the appearance of the minor lines along the Y-axis.
* `MinorXLineDashArray`&mdash;The dash array used to define each minor X-line StrokeDashArray
* `MinorYLineDashArray`&mdash;The dash array used to define each minor X-line StrokeDashArray

__Cartesian Chart with customized CartesianChartGrid__
```XAML
    <telerik:RadCartesianChart>
        <telerik:RadCartesianChart.Grid>
            <telerik:CartesianChartGrid MajorLinesVisibility="None"
                                MinorLinesVisibility="X"
                                StripLinesVisibility="None"
                                MinorStripLinesVisibility="X"
                                MinorXLineDashArray="6 3">
                <telerik:CartesianChartGrid.MinorXLineStyle>
                    <Style TargetType="Line">
                        <Setter Property="Stroke" Value="Blue" />
                    </Style>
                </telerik:CartesianChartGrid.MinorXLineStyle>
            </telerik:CartesianChartGrid>
        </telerik:RadCartesianChart.Grid>
        <!-- Axes defined in previous example -->
    </telerik:RadCartesianChart>
```

![Cartesian Chart with customized CartesianChartGrid](images/radchartview-minor-ticks-and-stripes-1.png)

### PolarChartGrid

The PolarChartGrid provides the following properties for customization of the grid and strip lines:

* `MinorGridLineVisibility`&mdash;The visibility of minor grid lines. A value of type `PolarGridLineVisibility` which can be either `None`, `Radial`, `Polar` or `Both`.
* `MinorStripesVisibility`&mdash;The visibility of the grid's stripes. A value of type `PolarGridLineVisibility` which can be either `None`, `Radial`, `Polar` or `Both`.
* `MinorPolarLineStyle`&mdash;The style that defines the appearance of the minor polar (radius) lines within the grid.
* `MinorPolarLineDashArray`&mdash;The `DoubleCollection` that defines the pattern of the minor polar (radius) lines within the grid.
* `MinorRadialLineStyle`&mdash;The style that defines the appearance of the minor radial (angle) lines within the grid.
* `MinorRadialDashArray`&mdash;The `DoubleCollection` that defines the pattern of the minor radial (angle) lines within the grid.

__Polar Chart with customized PolarChartGrid__
```XAML
    <telerik:RadPolarChart Palette="Windows8">
        <telerik:RadPolarChart.PolarAxis>
            <telerik:PolarAxis MinorTicksPerMajor="1" />
        </telerik:RadPolarChart.PolarAxis>
        <telerik:RadPolarChart.RadialAxis>
            <telerik:NumericRadialAxis MinorTicksPerMajor="2" />
        </telerik:RadPolarChart.RadialAxis>
        <telerik:RadPolarChart.Series>
            <telerik:PolarLineSeries>
                <telerik:PolarLineSeries.DataPoints>
                    <!-- ... -->
                </telerik:PolarLineSeries.DataPoints>
            </telerik:PolarLineSeries>
        </telerik:RadPolarChart.Series>
        <telerik:RadPolarChart.Grid>
            <telerik:PolarChartGrid GridLineVisibility="Both"
                                    MinorGridLineVisibility="Both"
                                    MinorStripesVisibility="Radial"
                                    MinorRadialDashArray="2 1"
                                    MinorPolarLineDashArray="6 3">
                <telerik:PolarChartGrid.MinorPolarLineStyle>
                    <Style TargetType="Line">
                        <Setter Property="Stroke" Value="Blue" />
                    </Style>
                </telerik:PolarChartGrid.MinorPolarLineStyle>
                <telerik:PolarChartGrid.MinorRadialLineStyle>
                    <Style TargetType="Ellipse">
                        <Setter Property="Stroke" Value="Red" />
                    </Style>
                </telerik:PolarChartGrid.MinorRadialLineStyle>
            </telerik:PolarChartGrid>
        </telerik:RadPolarChart.Grid>
    </telerik:RadPolarChart>
```

![Polar Chart with customized PolarChartGrid](images/radchartview-minor-ticks-and-stripes-2.png)

## See Also
* [Chart Grid]({%slug radchartview-cartesianchartgrid-and-polarchartgrid%})
* [Axis]({%slug radchartview-axes-axis%})
