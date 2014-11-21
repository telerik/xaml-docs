---
title: Palette Entry
page_title: Palette Entry
description: Palette Entry
slug: radchartview-features-palettes-paletteentry
tags: palette,entry
published: True
position: 2
---

# Palette Entry

Each palette contains PaletteEntries which expose the following properties:        

* Fill
* Stroke
* AdditionalFill
* AdditionalStroke

__Fill__ and __Stroke__ are the most commonly used properties which affect most of the series in __RadChartView__. The other two are more specific and are not relevant for all types of series. In the OhlcSeries the properties __Open__ and __Close__ define two types of sticks, depending on which of these properties has a bigger value. One of these types takes its color from __Stroke__ and the other - from __AdditionalStroke__. Similarly the __AdditionalFill__ property affects the CandlestickSeries.        

Here is an example of how to use the __AdditionalFill__ and __AdditionalStroke__ properties in CandlestickSeries:        

#### __XAML__

{{region radchartview-palettes-paletteentry_0}}
	<telerik:RadCartesianChart >
	    <telerik:RadCartesianChart.Palette>
	        <telerik:ChartPalette>
	            <telerik:ChartPalette.GlobalEntries>
	                <telerik:PaletteEntry Fill="#FF1FAFD3" Stroke="#FF1FAFD3" AdditionalFill="#FF01FFFF" AdditionalStroke="#0055BF"/>
	                <telerik:PaletteEntry Fill="#FFC32E0A" Stroke="#FFC32E0A" AdditionalFill="#FFE85F2E" AdditionalStroke="#7D1A00"/>
	            </telerik:ChartPalette.GlobalEntries>
	        </telerik:ChartPalette>
	    </telerik:RadCartesianChart.Palette>
	
	    <telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:CategoricalAxis/>
	    </telerik:RadCartesianChart.HorizontalAxis>
	    <telerik:RadCartesianChart.VerticalAxis>
	        <telerik:LinearAxis/>
	    </telerik:RadCartesianChart.VerticalAxis>
	
	    <telerik:CandlestickSeries>
	        <telerik:CandlestickSeries.DataPoints>
	            <telerik:OhlcDataPoint Category="Mon" Open="9" High="10" Low="7" Close="8"/>
	            <telerik:OhlcDataPoint Category="Tue" Open="8.5" High="11" Low="8" Close="10"/>
	            <telerik:OhlcDataPoint Category="Wed" Open="9" High="10" Low="7" Close="8"/>
	            <telerik:OhlcDataPoint Category="Thu" Open="8" High="11" Low="8" Close="10"/>
	            <telerik:OhlcDataPoint Category="Fri" Open="8" High="9.5" Low="7.5" Close="8.5"/>
	        </telerik:CandlestickSeries.DataPoints>
	    </telerik:CandlestickSeries>
	
	    <telerik:CandlestickSeries>
	        <telerik:CandlestickSeries.DataPoints>
	            <telerik:OhlcDataPoint Category="Mon" Low="1" High="5" Open="2" Close="4"/>
	            <telerik:OhlcDataPoint Category="Tue" Low="3" High="7" Open="6" Close="4"/>
	            <telerik:OhlcDataPoint Category="Wed" Low="3" High="6" Open="4" Close="5"/>
	            <telerik:OhlcDataPoint Category="Thu" Low="3" High="7" Open="6" Close="4.5"/>
	            <telerik:OhlcDataPoint Category="Fri" Low="3" High="7" Open="5.5" Close="4"/>
	        </telerik:CandlestickSeries.DataPoints>
	    </telerik:CandlestickSeries>
	
	</telerik:RadCartesianChart>
{{endregion}}

Here is a snapshot of the example:
![Rad Chart View-palettes-paletteentry-0](images/RadChartView-palettes-paletteentry-0.png)