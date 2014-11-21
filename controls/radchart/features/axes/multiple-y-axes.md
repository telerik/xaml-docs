---
title: Multiple Y axes
page_title: Multiple Y axes
description: Multiple Y axes
slug: radchart-features-axes-multiple-y-axes
tags: multiple,y,axes
published: True
position: 3
---

# Multiple Y axes



## 

__RadChart__ supports multiple __Y axes__. It may be required when series of a different scale should be presented on the same graph. The only thing you have to do is to specify which axis to be used for each series definition.

To add more __Y axes__ to a [ChartArea]({%slug radchart-features-chart-area%}), use __ChartArea.AdditionalYAxes__ collection. Just create a new instance of __AxisY__, set a name using __AxisY.AxisName__ property and add it to the collection. Add as many __Y axes__ as you need. __RadChart__ will arrange them one after the other. See [Axes Overview]({%slug radchart-features-axes-overview%}) and [Y-Axis]({%slug radchart-features-axes-y-axis%}) for more information.

Now, having the required number of additional __Y-Axis__, you have to link each data series to the appropriate __Y-Axis__. To do that, simply use the __ISeriesDefinition.AxisName__ property and set the name of the __Y-Axis__. If you leave this property empty, __RadChart__ will use the default __Y-Axis__.

The following example demonstrates how to add another __Y-Axis__ and link it to a series definition. In this example, [SeriesMapping/ItemMappingis]({%slug radchart-populating-with-data-data-binding-support-overview%}) is used to bind the data:

* First, a new __AxisY__ is added to __ChartArea.AdditionalYAxes__ with __AxisY.AxisName__ set to "AxisY_South". 


* Second, two series mappings are defined with __CollectionIndex__ set to 0 and 1. See [Data Binding to Many Chart Areas]({%slug radchart-populating-with-data-data-binding-to-many-chart-areas%}) for more information. 


* Third, for the second series mapping, __SeriesMapping.SeriesDefinition.AxisName__ is set to the name of the additionally added Y axis - "AxisY_South".

#### __XAML__

{{region radchart-features-axes-multiple-y-axes_0}}
	<telerikChart:RadChart x:Name="radChart">
	    <telerikChart:RadChart.SeriesMappings>
	        <telerikCharting:SeriesMapping CollectionIndex="0" LegendLabel="North [MW]">
	            <telerikCharting:SeriesMapping.SeriesDefinition>
	                <telerikCharting:BarSeriesDefinition ShowItemLabels="False" />
	            </telerikCharting:SeriesMapping.SeriesDefinition>
	
	            <telerikCharting:SeriesMapping.ItemMappings>
	                <telerikCharting:ItemMapping FieldName="Value" DataPointMember="YValue"/>
	            </telerikCharting:SeriesMapping.ItemMappings>
	        </telerikCharting:SeriesMapping>
	        <telerikCharting:SeriesMapping CollectionIndex="1" LegendLabel="South [kW]">
	            <telerikCharting:SeriesMapping.SeriesDefinition>
	                <telerikCharting:BarSeriesDefinition ShowItemLabels="False" AxisName="AxisY_South" />
	            </telerikCharting:SeriesMapping.SeriesDefinition>
	            <telerikCharting:SeriesMapping.ItemMappings>
	                <telerikCharting:ItemMapping FieldName="Value" DataPointMember="YValue"/>
	            </telerikCharting:SeriesMapping.ItemMappings>
	        </telerikCharting:SeriesMapping>
	    </telerikChart:RadChart.SeriesMappings>
	    <telerikChart:RadChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            ....
	            <telerikCharting:ChartDefaultView.ChartArea>
	                <telerikCharting:ChartArea LegendName="chartLegend">
	                    <telerikCharting:ChartArea.AxisX>
	                        <telerikCharting:AxisX AutoRange="True">
	                        </telerikCharting:AxisX>
	                    </telerikCharting:ChartArea.AxisX>
	                    <telerikCharting:ChartArea.AxisY>
	                        <telerikCharting:AxisY Title="Megawatt [MW]">
	                        </telerikCharting:AxisY>
	                    </telerikCharting:ChartArea.AxisY>
	
	                    <telerikCharting:ChartArea.AdditionalYAxes>
	                        <telerikCharting:AxisY Title="Kilowatt [kW]" AxisName="AxisY_South">
	                        </telerikCharting:AxisY>
	                    </telerikCharting:ChartArea.AdditionalYAxes>
	                </telerikCharting:ChartArea>
	            </telerikCharting:ChartDefaultView.ChartArea>
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:RadChart.DefaultView>
	</telerikChart:RadChart>
	{{endregion}}



#### __C#__

{{region radchart-features-axes-multiple-y-axes_1}}
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	....
	radChart.DefaultView.ChartArea.AxisY.Title = "Megawatt [MW]";
	AxisY axisY = new AxisY();
	axisY.AxisName = "AxisY_South";
	axisY.Title = "Kilowatt [kW]";
	radChart.DefaultView.ChartArea.AdditionalYAxes.Add( axisY );
	....
	//Series mapping for the collection with index 0
	SeriesMapping seriesMapping = new SeriesMapping();
	seriesMapping.CollectionIndex = 0;
	seriesMapping.LegendLabel = "North [MW]";
	seriesMapping.SeriesDefinition = new BarSeriesDefinition();
	seriesMapping.SeriesDefinition.ShowItemLabels = false;
	seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
	radChart.SeriesMappings.Add( seriesMapping );
	//Series mapping for the collection with index 1
	seriesMapping = new SeriesMapping();
	seriesMapping.CollectionIndex = 1;
	seriesMapping.LegendLabel = "South [kW]";
	seriesMapping.SeriesDefinition = new BarSeriesDefinition();
	seriesMapping.SeriesDefinition.AxisName = "AxisY_South";
	seriesMapping.SeriesDefinition.ShowItemLabels = false;
	seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
	radChart.SeriesMappings.Add( seriesMapping );
	radChart.ItemsSource = this.DataContext;
	{{endregion}}



#### __VB.NET__

{{region radchart-features-axes-multiple-y-axes_2}}
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	....
	radChart.DefaultView.ChartArea.AxisY.Title = "Megawatt [MW]"
	Dim axisY As New AxisY()
	axisY.AxisName = "AxisY_South"
	axisY.Title = "Kilowatt [kW]"
	radChart.DefaultView.ChartArea.AdditionalYAxes.Add(axisY)
	....
	'Series mapping for the collection with index 0'
	Dim seriesMapping As New SeriesMapping()
	seriesMapping.CollectionIndex = 0
	seriesMapping.LegendLabel = "North [MW]"
	seriesMapping.SeriesDefinition = New BarSeriesDefinition()
	seriesMapping.SeriesDefinition.ShowItemLabels = False
	seriesMapping.ItemMappings.Add(New ItemMapping("Value", DataPointMember.YValue))
	radChart.SeriesMappings.Add(seriesMapping)
	'Series mapping for the collection with index 1'
	seriesMapping = New SeriesMapping()
	seriesMapping.CollectionIndex = 1
	seriesMapping.LegendLabel = "South [kW]"
	seriesMapping.SeriesDefinition = New BarSeriesDefinition()
	seriesMapping.SeriesDefinition.AxisName = "AxisY_South"
	seriesMapping.SeriesDefinition.ShowItemLabels = False
	seriesMapping.ItemMappings.Add(New ItemMapping("Value", DataPointMember.YValue))
	radChart.SeriesMappings.Add(seriesMapping)
	radChart.ItemsSource = Me.DataContext
	{{endregion}}



As you can see on the snapshot below, the chart contains two series - one for the energy consumption for the northern part of a country and another one for the southern part. The first one is bound to the default __Y-Axis__ and its scale is in Megawatt. The second one is linked to the additionally added __Y-axis__ and the data is in Kilowatts:

![](images/RadChart_Features_Axes_MultipleYAxes_20.png)

# See Also

 * [Axes Overview]({%slug radchart-features-axes-overview%})

 * [Y-Axis]({%slug radchart-features-axes-y-axis%})

 * [Styling the Axes Overview]({%slug radchart-styling-and-appearance-styling-axes-overview%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})
