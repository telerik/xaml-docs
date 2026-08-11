---
title: Conversion API
page_title: Conversion API
description: Check our &quot;Conversion API&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-conversion
tags: conversion,api
published: True
position: 4
---

# Conversion API

The conversion API that the ChartView provides, allows the conversion of a position on the screen (for example the position of the mouse) to ChartView coordinates.
      

## Using the conversion API

Both RadCartesianChart and RadPolarChart provide a __ConvertPointToData__ method. This method takes a System.Windows.Point as an argument (position on the screen) and returns an object of type DataTuple.
        

The DataTuple class has two properties: FirstValue and SecondValue, both of type object. In the context of RadCartesianChart they represent the coordinates on the Horizontal and the Vertical axes and in the context of RadPolarChart - the coordinates on the Polar and the Radial axes.
        

Here is a RadCartesianChart example:

<snippet id='radchartview-features-conversion-block_1-cs' />

<snippet id='radchartview-features-conversion-block_1-vb' />


The RadCartesianChart provides an overloaded version of the __ConvertPointToData__ method, which besides a System.Windows.Point, takes a two other arguments - references to a Horizontal and a Vertical axes. This allows the user to get information relative to the specified axes (often different then the default ones), enabling the use of additional axes.
        
