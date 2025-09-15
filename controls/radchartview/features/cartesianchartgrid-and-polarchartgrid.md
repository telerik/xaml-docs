---
title: Chart Grid
page_title: Chart Grid
description: Show grid lines ands stripes in RadChartView using CartesianChartGrid and PolarChartGrid.
slug: radchartview-cartesianchartgrid-and-polarchartgrid
tags: cartesianchartgrid,and,polarchartgrid
published: True
position: 3
---

# Chart Grid

In order to improve the readiness of the chart you may want to add grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes for better readability. Depending on the chart that you use (RadCartesianChart or RadPolarChart) there are two types: __CartesianChartGrid__ and __PolarChartGrid__ that you can play with to add a decoration over the plot area.

![Rad Chart View grid overview](images/radchartview-features-grid-13.png)

## CartesianChartGrid

CartesianChartGrid shows horizontal and vertical lines and strips crossing the chart's plot area. The lines are snapped on the ticks of the axes and the strips is the area between the lines.

The grid allows you to customize its lines and strips via several properties. To use it, set the __Grid__ property of RadCartesianChart to a new instance of __CartesianChartGrid__.

To __display any lines__ in the grid, set the __MajorLinesVisibility__ property. This is an enumeration that allows you to tell which lines to be displayed - vertical (__X__), horizontal (__Y__), both (__XY__) or __None__.

__Example 1: Setting up the grid__
```XAML
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis />
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:LineSeries>
			<telerik:LineSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="A" Value="20" />
				<telerik:CategoricalDataPoint Category="B" Value="40" />
				<telerik:CategoricalDataPoint Category="C" Value="35" />
				<telerik:CategoricalDataPoint Category="D" Value="40" />
				<telerik:CategoricalDataPoint Category="E" Value="30" />
				<telerik:CategoricalDataPoint Category="F" Value="50" />
			</telerik:LineSeries.DataPoints>
		</telerik:LineSeries>
		<telerik:RadCartesianChart.Grid>
			<telerik:CartesianChartGrid MajorLinesVisibility="XY" />
		</telerik:RadCartesianChart.Grid>
	</telerik:RadCartesianChart>
```

#### Figure 1: Grid lines example
![Rad Chart View-chart majorlines](images/radchartview-features-grid-0.png)

To __display the strip lines__, set the __StripLinesVisibility__ property. This is an enumeration that allows you to tell which strips to be displayed - vertical (__X__), horizontal (__Y__), both (__XY__) or __None__.

__Example 2: Enabling strip lines__
```XAML	
	<telerik:RadCartesianChart.Grid>
		<telerik:CartesianChartGrid MajorLinesVisibility="XY" StripLinesVisibility="XY" />
	</telerik:RadCartesianChart.Grid>
```

#### Figure 2: Strip lines example
![Rad Chart View-chart strip lines](images/radchartview-features-grid-1.png)

To __show dashed lines__, set the __MajorXLineDashArray__ and __MajorYLineDashArray__ properties. 

__Example 3: Dashing the grid lines__
```XAML	
	<telerik:RadCartesianChart.Grid>
		<telerik:CartesianChartGrid MajorXLineDashArray="5 5" MajorYLineDashArray="5 5" MajorLinesVisibility="XY" />
	</telerik:RadCartesianChart.Grid>
```

#### Figure 3: Dash array example
![Rad Chart View-chart dash array](images/radchartview-features-grid-2.png)

To __define an interval for the grid lines__ to appear, set the __MajorXLineInterval__ and __MajorYLineInterval__ properties.

__Example 4: Setting line interval__
```XAML	
	<telerik:RadCartesianChart.Grid>
		<telerik:CartesianChartGrid MajorXLineInterval="2" MajorYLineInterval="3" MajorLinesVisibility="XY" />
	</telerik:RadCartesianChart.Grid>
```

#### Figure 4: Line interval example
![Rad Chart View-chart lines interval](images/radchartview-features-grid-3.png)

To __change the appearance of the grid lines__, set the __MajorXLineStyle__ and __MajorYLineStyle__ properties.

__Example 5: Styling the grid lines__
```XAML	
	<telerik:RadCartesianChart.Grid>
		<telerik:CartesianChartGrid MajorLinesVisibility="XY">
			<telerik:CartesianChartGrid.MajorXLineStyle>
				<Style TargetType="Line">
					<Setter Property="Stroke" Value="#FFCE44" />
				</Style>
			</telerik:CartesianChartGrid.MajorXLineStyle>
			<telerik:CartesianChartGrid.MajorYLineStyle>
				<Style TargetType="Line">
					<Setter Property="Stroke" Value="#DD5145" />
				</Style>
			</telerik:CartesianChartGrid.MajorYLineStyle>
		</telerik:CartesianChartGrid>
	</telerik:RadCartesianChart.Grid>
```

#### Figure 5: Grid lines with custom colors
![Rad Chart View-chart line styles](images/radchartview-features-grid-4.png)

> Setting __StrokeDashArray__ via the Line's Style is not supported. Use the __MajorXLineDashArray__ and __MajorYLineDashArray__ properties of CartesianChartGrid instead. 

To __change the colors of the strip lines__, set the __XStripeBrushes__ and __YStripeBrushes__ properties.

__Example 6: Coloring the strip lines__
```XAML	
	<telerik:RadCartesianChart.Grid>
		<telerik:CartesianChartGrid StripLinesVisibility="XY">
			<telerik:CartesianChartGrid.XStripeBrushes>
				<SolidColorBrush Color="Transparent" />
				<SolidColorBrush Color="Yellow" Opacity="0.2"/>
			</telerik:CartesianChartGrid.XStripeBrushes>
			<telerik:CartesianChartGrid.YStripeBrushes>
				<SolidColorBrush Color="Red" Opacity="0.2"/>
				<SolidColorBrush Color="Green" Opacity="0.2" />
				<SolidColorBrush Color="Transparent" />
			</telerik:CartesianChartGrid.YStripeBrushes>                   
		</telerik:CartesianChartGrid>
	</telerik:RadCartesianChart.Grid>
```

#### Figure 6: Strip lines with custom colors
![Rad Chart View-chart strip line colors](images/radchartview-features-grid-5.png)

The X brushes are drawn from left to right. And the Y brushes from bottom to top.

> Keep in mind that the horizontal (Y) strip lines are drawn over the vertical (X) strip lines.

To __change the render mode of the grid lines__, set the __MajorXLinesRenderMode__ and __MajorYLinesRenderMode__. This is an enumeration of type __GridLineRenderMode__ and it controls what lines will get rendered. 

__Example 7: Setting the grid lines render mode__
```XAML	
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis Visibility="Collapsed"/>
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis />
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:LineSeries>
			<telerik:LineSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="A" Value="20" />
				<telerik:CategoricalDataPoint Category="B" Value="40" />
				<telerik:CategoricalDataPoint Category="C" Value="35" />
				<telerik:CategoricalDataPoint Category="D" Value="40" />
				<telerik:CategoricalDataPoint Category="E" Value="30" />
				<telerik:CategoricalDataPoint Category="F" Value="50" />
			</telerik:LineSeries.DataPoints>
		</telerik:LineSeries>
		<telerik:RadCartesianChart.Grid>
			<telerik:CartesianChartGrid MajorLinesVisibility="X" MajorXLinesRenderMode="Inner">
				<telerik:CartesianChartGrid.MajorXLineStyle>
					<Style TargetType="Line">
						<Setter Property="Stroke" Value="Black" />
					</Style>
				</telerik:CartesianChartGrid.MajorXLineStyle>
			</telerik:CartesianChartGrid>
		</telerik:RadCartesianChart.Grid>
	</telerik:RadCartesianChart>
```

The render mode properties allow the following values.

* __First__: Only the first line is drawn.

	![Rad Chart View-chart first line](images/radchartview-features-grid-6.png)

* __Inner__: All lines, except the first and last, are drawn.

	![Rad Chart View-chart inner line](images/radchartview-features-grid-7.png)

* __FirstAndInner__: All lines, except the last, are rendered.

	![Rad Chart View-chart first and inner line](images/radchartview-features-grid-8.png)

* __Last__: Only the last line is rendered.

	![Rad Chart View-chart last line](images/radchartview-features-grid-9.png)
	
* __FirstAndLast__: Only the first and the last lines are rendered.

	![Rad Chart View-chart first and last line](images/radchartview-features-grid-10.png)

* __InnerAndLast__: All lines, except the first, are rendered.

	![Rad Chart View-chart inner and last line](images/radchartview-features-grid-11.png)

* __All__: All lines are rendered. This is the __default__ value.

	![Rad Chart View-chart all lines](images/radchartview-features-grid-12.png)

### PolarChartGrid

PolarChartGrid shows polar and radial lines and stripes drawn over the chart's plot area. The lines are snapped on the ticks of the axes and the stripes is the area between the lines.

The grid allows you to customize its lines and strips via several properties. To use it, set the __Grid__ property of RadPolarChart to a new instance of __PolarChartGrid__.

To __display the lines__ in the grid, set the __GridLineVisibility__ property. This is an enumeration that allows you to tell which lines to be displayed - __Polar__, __Radial__, __Both__ or __None__.

__Example 8: Setting up the polar grid__
```XAML
	<telerik:RadPolarChart>
		<telerik:RadPolarChart.RadialAxis>
			<telerik:CategoricalRadialAxis />
		</telerik:RadPolarChart.RadialAxis>
		<telerik:RadPolarChart.PolarAxis>
			<telerik:PolarAxis Minimum="0" Maximum="5" />
		</telerik:RadPolarChart.PolarAxis>
		<telerik:RadarLineSeries>
			<telerik:RadarLineSeries.DataPoints>
				<telerik:CategoricalDataPoint Category="A" Value="3.2" />
				<telerik:CategoricalDataPoint Category="B" Value="3.6" />
				<telerik:CategoricalDataPoint Category="C" Value="3.8" />
				<telerik:CategoricalDataPoint Category="D" Value="4.5" />
				<telerik:CategoricalDataPoint Category="E" Value="3.5" />
				<telerik:CategoricalDataPoint Category="F" Value="3.6" />
			</telerik:RadarLineSeries.DataPoints>             
		</telerik:RadarLineSeries>            
		<telerik:RadPolarChart.Grid>
			<telerik:PolarChartGrid GridLineVisibility="Both" />  
		</telerik:RadPolarChart.Grid>
	</telerik:RadPolarChart>
```

#### Figure 7: Polar grid lines example
![Rad Chart View-chart polar grid lines](images/radchartview-features-grid-14.png)

To __display the strip lines__, set the __StripesVisibility__ property. This is an enumeration that allows you to tell which strips to be displayed - __Polar__, __Radial__, __Both__ or __None__.

__Example 9: Enabling polar strip lines__
```XAML	
	 <telerik:RadPolarChart.Grid>
		<telerik:PolarChartGrid StripesVisibility="Radial"/>
	</telerik:RadPolarChart.Grid>
```

#### Figure 8: Polar strip lines example
![Rad Chart View-chart polar strip lines](images/radchartview-features-grid-15.png)

To __show dashed lines__, set the __PolarLineDashArray__ and __RadialLineDashArray__ properties. 

__Example 10: Dashing the polar grid lines__
```XAML	
	 <telerik:RadPolarChart.Grid>
		<telerik:PolarChartGrid GridLineVisibility="Both" PolarLineDashArray="4 4" RadialLineDashArray="10 5"/>
	</telerik:RadPolarChart.Grid>
```

#### Figure 9: Dash array for the polar and radial grid lines example
![Rad Chart View-chart dash array](images/radchartview-features-grid-16.png)

To __change the appearance of the polar grid lines__, set the __RadialLineStyle__ and __PolarLineStyle__ properties.

__Example 11: Styling the polar grid lines__
```XAML	
	<telerik:RadPolarChart.Grid>
		<telerik:PolarChartGrid GridLineVisibility="Both">
			<telerik:PolarChartGrid.PolarLineStyle>
				<Style TargetType="Line">
					<Setter Property="Stroke" Value="OrangeRed" />
					<Setter Property="StrokeThickness" Value="3" />
				</Style>
			</telerik:PolarChartGrid.PolarLineStyle>
			<telerik:PolarChartGrid.RadialLineStyle>
				<Style TargetType="Ellipse">
					<Setter Property="Stroke" Value="OliveDrab" />
				</Style>
			</telerik:PolarChartGrid.RadialLineStyle>
		</telerik:PolarChartGrid>								
	</telerik:RadPolarChart.Grid>
```

#### Figure 10: Polar grid lines with custom colors and thickness
![Rad Chart View-chart polar line styles](images/radchartview-features-grid-17.png)

> Setting __StrokeDashArray__ via the Line or Ellipse's Style is not supported. Use the __PolarLineDashArray__ and __RadialLineDashArray__ properties of PolarChartGrid instead.

To __change the colors of the polar strip lines__, set the __PolarStripeBrushes__ and __RadialStripeBrushes__ properties.

__Example 12: Coloring the strip lines__
```XAML	
	<telerik:RadPolarChart.Grid>
		<telerik:PolarChartGrid GridLineVisibility="Both" StripesVisibility="Both">
			<telerik:PolarChartGrid.PolarStripeBrushes>
				<SolidColorBrush Color="OrangeRed" Opacity="0.4" />
				<SolidColorBrush Color="YellowGreen" Opacity="0.4" />                       
			</telerik:PolarChartGrid.PolarStripeBrushes>
			<telerik:PolarChartGrid.RadialStripeBrushes>
				<SolidColorBrush Color="DarkOliveGreen"  />
				<SolidColorBrush Color="YellowGreen" />
			</telerik:PolarChartGrid.RadialStripeBrushes>
		</telerik:PolarChartGrid>									
	</telerik:RadPolarChart.Grid>
```

#### Figure 11: Strip lines with custom colors
![Rad Chart View-chart strip line colors](images/radchartview-features-grid-18.png)

The radial strip lines are drawn from outside to inside. And the polar lines are drawn counter clockwise. 

> Keep in mind that the polar strip lines are drawn over the radial strip lines.
