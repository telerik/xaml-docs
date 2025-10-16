---
title: Creating Custom Palettes
page_title: Creating Custom Palettes
description: Check our &quot;Creating Custom palettes&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-palettes-custom-palettes
tags: creating,custom,palettes
published: True
position: 1
---

# Creating Custom Palettes

Here you can learn how you can create your own chart palette.
      

## Global Entries vs. Series Entries

You can create a custom palette by instantiating an object of type __ChartPalette__. There are two collections which we can use to set the colors in our palette. The first is the __GlobalEntries__ and the other is __SeriesEntries__. The GlobalEntries is a collection of PaletteEntries, which will be used for all types of chart series. The SeriesEntries allows us to specify different collections of PaletteEntries for each type of chart series. For example, if we want to have one behavior for the pie series and another for the bar series, here is how we can achieve it:

```XAML
	<UserControl.Resources>
	    <telerik:ChartPalette x:Key="customPalette">
	        <telerik:ChartPalette.SeriesEntries>
	                
	            <telerik:PaletteEntryCollection SeriesFamily="Pie">
	                <telerik:PaletteEntry Fill="#FF1FAFD3" Stroke="White"/>
	                <telerik:PaletteEntry Fill="#FFC32E0A" Stroke="White"/>
	                <telerik:PaletteEntry Fill="#FFFA6F5E" Stroke="White"/>
	            </telerik:PaletteEntryCollection>
	            <telerik:PaletteEntryCollection SeriesFamily="Bar">
	                <telerik:PaletteEntry Fill="#FF006968" Stroke="White"/>
	                <telerik:PaletteEntry Fill="#FF7A6CC4" Stroke="White"/>
	                <telerik:PaletteEntry Fill="#FF1FAFD3" Stroke="White"/>
	            </telerik:PaletteEntryCollection>
	        </telerik:ChartPalette.SeriesEntries>
	
	        <telerik:ChartPalette.GlobalEntries>
	            <telerik:PaletteEntry Fill="#FF21B573" Stroke="White" />
	            <telerik:PaletteEntry Fill="#FF88CA2A" Stroke="White" />
	            <telerik:PaletteEntry Fill="#FFFF921E" Stroke="White" />
	        </telerik:ChartPalette.GlobalEntries>
	            
	    </telerik:ChartPalette>
	</UserControl.Resources>
```

Notice the __SeriesFamily__ property, which is available for the collections in the SeriesEntries. If we have this palette in a chart, the first collection will be used for the pie series, the second - for the bar series and for all other types of series - the __GlobalEntries__ collection.

>Note that defining GlobalEntries or SeriesEntries is not mandatory - you can use either one of the two or you can combine them as in the current example.          

```XAML
	<Grid>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="1\*"/>
	        <ColumnDefinition Width="2\*"/>
	    </Grid.ColumnDefinitions>
	
	    <telerik:RadPieChart Palette="{StaticResource customPalette}" Grid.Column="0">
	        <telerik:RadPieChart.Behaviors>
	            <telerik:ChartSelectionBehavior/>
	        </telerik:RadPieChart.Behaviors>
	        <telerik:PieSeries>
	            <telerik:PieSeries.DataPoints>
	                <telerik:PieDataPoint Value="9" />
	                <telerik:PieDataPoint Value="3" />
	                <telerik:PieDataPoint Value="3" />
	            </telerik:PieSeries.DataPoints>
	        </telerik:PieSeries>
	    </telerik:RadPieChart>
	
	    <telerik:RadCartesianChart Palette="{StaticResource customPalette}" Grid.Column="1">
	        <telerik:RadCartesianChart.HorizontalAxis>
	            <telerik:CategoricalAxis/>
	        </telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:RadCartesianChart.VerticalAxis>
	            <telerik:LinearAxis/>
	        </telerik:RadCartesianChart.VerticalAxis>
	        <telerik:AreaSeries CombineMode="Stack">
	            <telerik:AreaSeries.DataPoints>
	                <telerik:CategoricalDataPoint Value="3"/>
	                <telerik:CategoricalDataPoint Value="1"/>
	                <telerik:CategoricalDataPoint Value="2"/>
	                <telerik:CategoricalDataPoint Value="5"/>
	                <telerik:CategoricalDataPoint Value="6"/>
	            </telerik:AreaSeries.DataPoints>
	        </telerik:AreaSeries>
	        <telerik:AreaSeries CombineMode="Stack">
	            <telerik:AreaSeries.DataPoints>
	                <telerik:CategoricalDataPoint Value="5"/>
	                <telerik:CategoricalDataPoint Value="3"/>
	                <telerik:CategoricalDataPoint Value="4"/>
	                <telerik:CategoricalDataPoint Value="2"/>
	                <telerik:CategoricalDataPoint Value="3"/>
	            </telerik:AreaSeries.DataPoints>
	        </telerik:AreaSeries>
	        <telerik:AreaSeries CombineMode="Stack">
	            <telerik:AreaSeries.DataPoints>
	                <telerik:CategoricalDataPoint Value="2"/>
	                <telerik:CategoricalDataPoint Value="5"/>
	                <telerik:CategoricalDataPoint Value="4"/>
	                <telerik:CategoricalDataPoint Value="5"/>
	                <telerik:CategoricalDataPoint Value="3"/>
	            </telerik:AreaSeries.DataPoints>
	        </telerik:AreaSeries>
	    </telerik:RadCartesianChart>
	</Grid>
```

__Example showing the custom palette__  

![Rad Chart View-palettes-custom-palettes-0](images/RadChartView-palettes-custom-palettes-0.png)

In the above example there two charts - a Pie chart and a Cartesian chart. The PieSeries of the Pie chart are using the colors from the __PaletteEntryCollection__  with __SeriesFamily__ set to "Pie". Since we did not set a specific __PaletteEntryCollection__ for the area series of the second chart, they use the colors from the __GlobalEntries__ collection.
        

