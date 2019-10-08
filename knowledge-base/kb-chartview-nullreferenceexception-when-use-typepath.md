---
title: NullReferenceException When Using TypePath of CategoricalSeriesDescriptor
page_title: Error If TypePath Property is Used with Chart SeriesDescriptor
description: Null Reference Exception occurs when TypePath of RadCartesianChart series descriptor is set
type: how-to
slug: kb-chartview-nullreferenceexception-when-use-typepath
position: 0
tags: descriptor, path
ticketid: 1412001
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.510</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>Progress® Telerik® UI for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

Null Reference Exception occurs when TypePath of RadCartesianChart series descriptor is set.

This reproduces only if the Telerik.Windows.Controls.Charting dll is referenced.

## Solution

This happens when the TypePath property points to a value that holds a type of Telerik.Windows.Controls.Charting.LineSeries (or any other series type), instead of Telerik.Windows.Controls.Chart.LineSeries as expected by the descriptor.

To resolve this use one of the following two solutions.

* When setting the type of the series, use also its namespace or add a `using` directive that points to Telerik.Windows.Controls.ChartView namespace.

* Or remove the reference to the Telerik.Windows.Controls.Charting dll. It hosts the old RadChart controls.
