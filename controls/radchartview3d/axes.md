---
title: Axes
page_title: Axes
description: Axes
slug: radchartview3d-axes
tags: axes, 3d, chartview, linearaxis3d, categoricalaxis3d
published: True
position: 3
---

# Axes

The 3D space in the __RadCartesianChart3D__ control is defined by three axes, one for each dimension – X, Y and Z. Currently, there are a couple of axis types that can be used with the 3D chart - __LinearAxis3D__ and __CategoricalAxis3D__. 

#### __Figure 1: Axes__
![](images/radchartview-3d-axes-0.png)

## Common Features

The linear and categorical 3D axes share some common features which you can find listed below.
* __Labels visibility__: You can control the visibility of the axis labels using the __ShowLabels__ bool property.
		
	#### __[XAML] Example 1: Setting the labels visibility__
	{{region xaml-radchartview-3d-axes-0}}
		<telerik:LinearAxis3D ShowLabels="False"/>
	{{endregion}}
	
	#### __Figure 2: The labels of all axes are hidden__
	![](images/radchartview-3d-axes-1.png)

* __Label interval__: You can set the interval between the visible labels of the axis using the __LabelInterval__ property. This allows you to display labels only at a specific step. 

	#### __[XAML] Example 2: Setting the label interval__
	{{region xaml-radchartview-3d-axes-1}}
		<telerik:LinearAxis3D LabelInterval="2" />
	{{endregion}}

	#### __Figure 3: Label interval__
	![](images/radchartview-3d-axes-2.png)
 
* __Label style__: You can define a custom style for the axis labels using the __LabelStyle__ property. The property accepts an object of type Style that targets a __TextBlock__ element.

	#### __[XAML] Example 3: Setting the label style__
	{{region xaml-radchartview-3d-axes-2}}
		<telerik:LinearAxis3D>
		  <telerik:LinearAxis3D.LabelStyle>
			 <Style TargetType="TextBlock">
					<Setter Property="Foreground" Value="#CA5100" />
				   <Setter Property="FontWeight" Value="Bold" />
			   </Style>
		   </telerik:LinearAxis3D.LabelStyle>
		</telerik:LinearAxis3D>
	{{endregion}}	

	#### __Figure 4: Label style__
	![](images/radchartview-3d-axes-3.png)	
 
* __Label template__: You can create a __DataTemplate__ that defines the appearance of the axis labels and set it to the __LabelTemplate__ property of the axis.

	#### __[XAML] Example 4: Setting the label template__
	{{region xaml-radchartview-3d-axes-3}}
		<telerik:LinearAxis3D>                    
			<telerik:LinearAxis3D.LabelTemplate>
				<DataTemplate>
					<Grid Margin="2">
						<Rectangle Fill="#2DB245" Width="16" Height="16" />
						<TextBlock Text="{Binding}" Foreground="White" TextAlignment="Center"/>
					</Grid>
				</DataTemplate>
			</telerik:LinearAxis3D.LabelTemplate>
		</telerik:LinearAxis3D>
	{{endregion}}		 	

	#### __Figure 5: Label template__
	![](images/radchartview-3d-axes-4.png)
 
* __Ticks length__: You can define the length of the axis ticks using the __MajorTickLength__ property.

	#### __[XAML] Example 5: Setting the label template__
	{{region xaml-radchartview-3d-axes-4}}
		<telerik:LinearAxis3D MajorTickLength="15">
	{{endregion}}
	
	#### __Figure 6: Tick length__
	![](images/radchartview-3d-axes-5.png)
	 
* __Plot mode__: You can set the strategy for positioning the data points along the axis using the __PlotMode__ property of the axis. 
	
	#### __[XAML] Example 6: Setting the plot mode__
	{{region xaml-radchartview-3d-axes-5}}
		<telerik:CategoricalAxis3D PlotMode="BetweenTicks">
	{{endregion}}
	
	The PlotMode property can have the following values:
	
	* __BetweenTicks__: The data points are plotted between each two adjacent ticks.		
	* __OnTicks__: The data points are plotted over each tick.	
	* __OnTicksPadded__: The data points are plotted over each tick with half a step applied on both ends of the axis.
	
	#### __Figure 7: Plot modes__
	![](images/radchartview-3d-axes-6.png)

* __Title__: The __Title__ property allows you to display a heading positioned next to the axis. To customize the title appearance you can use the __TitleTemplate__ property.

	#### __[XAML] Example 7: Setting the axis title__
	{{region xaml-radchartview-3d-axes-6}}	
		<telerik:CategoricalAxis3D Title=”Axis title">
	{{endregion}}		 

	#### __Figure 8: Axis title__
	![](images/radchartview-3d-axes-7.png)	
	
	#### __[XAML] Example 8: Setting the axis title template__
	{{region xaml-radchartview-3d-axes-7}}	
		<telerik:LinearAxis3D Title="Axis title">
			<telerik:LinearAxis3D.TitleTemplate>
				<DataTemplate>
					<TextBlock Text="{Binding}" Background="#2DB245" Foreground="White" Padding="3"  />
				</DataTemplate>
			</telerik:CategoricalAxis3D.TitleTemplate>
		</telerik:CategoricalAxis3D>
	{{endregion}}		 

	#### __Figure 9: Axis title template__
	![](images/radchartview-3d-axes-8.png)	

* __Smart labels__: You can avoid labels overlapping with the smart labels strategy of the axis. To enable this feature you can use the __SmartLabelsMode__ property. 

	#### __[XAML] Example 9: Enabling the axis smart labels__
	{{region xaml-radchartview-3d-axes-8}}	
		<telerik:CategoricalAxis3D SmartLabelsMode="SmartStep">
	{{endregion}}
	
	#### __Figure 10: Smart labels mode__
	![](images/radchartview-3d-axes-9.png)
	
## LinearAxis3D

This type of axis has a notion of range and it can be used to plot numeric data. You can find the axis specific features listed below.

* __Desired tick count__: You can use the __DesiredTickCount__ property of the axis to set the number of the desired ticks that will be displayed on the axis. Note that the property doesn’t set a fixed number of ticks, but it defines the preferred count and the chart tries to calculate them accordingly.

	#### __[XAML] Example 10: Setting the desired tick count__
	{{region xaml-radchartview-3d-axes-9}}	
		<telerik:LinearAxis3D DesiredTickCount="3" />
	{{endregion}}		

* __Manual range__: You can use the __Minimum__ and __Maximum__ properties of the axis to set the range manually. To control the step between the ticks you can use the __MajorStep__ property.

	#### __[XAML] Example 11: Setting manual range__
	{{region xaml-radchartview-3d-axes-10}}	
		<telerik:LinearAxis3D Minimum=”0” Maximum=”10” MajorStep="2.5" />
	{{endregion}}
	
	#### __Figure 11: Manual range__
	![](images/radchartview-3d-axes-10.png)

* __Tick origin__: The axis tick positions are determined by the __MajorStep__ and the __TickOrigin__ properties. The ticks will be generated in a way so that a tick is positioned at the given TickOrigin. 

	#### __[XAML] Example 12: Setting the axis title__
	{{region xaml-radchartview-3d-axes-11}}	
		<telerik:LinearAxis3D Minimum="0" Maximum="10" MajorStep="2.5" TickOrigin="5"/>
	{{endregion}}
		
	#### __Figure 12: Tick origin__
	![](images/radchartview-3d-axes-11.png)	

* __Label format__: You can use the LabelFormat property to format the values of the axis labels.

	#### __[XAML] Example 13: Setting the axis title__
	{{region xaml-radchartview-3d-axes-12}}	
		<telerik:LinearAxis3D LabelFormat="P0"/>
	{{endregion}}
	
	#### __Figure 13: Label format__
	![](images/radchartview-3d-axes-12.png)	

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [PointSeries3D]({%slug radchartview3d-pointseries3d%})
* [BarSeries3D]({%slug radchartview3d-barseries3d%})
* [SurfaceSeries3D]({%slug radchartview3d-surfaceseries3d%})

