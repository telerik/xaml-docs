---
title: Charts
page_title: Charts
description: Check our &quot;Charts&quot; documentation article for the RadSpreadsheet {{ site.framework_name }} control.
slug: radspreadsheet-ui-charts
tags: charts
published: True
position: 0
---

# {{ site.framework_name }} RadSpreadsheet Charts


The charts enable you to summarize the data in your spreadsheet document and make it easily readable and understandable. With RadSpreadsheet you can show charts as well as add, remove and manipulate chart objects in your spreadsheet documents.

## Using Charts in Your Application

>important To visualize a chart, RadSpreadsheet uses [RadChartView]({%slug radchartview-overview%}), so you must add a reference to **Telerik.Windows.Controls.Chart.dll**.

RadSpreadsheet enables you working with charts through its UI. You can add a chart through the Insert Chart dialog  which can be opened from the Insert tab of [RadSpreadsheetRibbon]({%slug radspreadsheet-getting-started-spreadsheet-ui%}). The dialog shows all of the available types of charts along with a preview of how the chart would look like when filled with the selected data.

>noteTo be able to see the charts, you must select at least two consecutive cells, otherwise you will get an error message. In case the selected cells don't contain any values, the charts will be shown empty. 

#### Figure 1: Insert Chart dialog
![{{ site.framework_name }} RadSpreadsheet Insert Chart dialog](images/Features-Charts_15.png)

## Supported Chart Types

### Column Charts

Column/bar charts are used to display values as sets of vertical columns, grouped by category. The length of the bars is proportional to the values that they represent. With this type of charts you can easily compare values in different categories. 


| Clustered column        | Stacked column | 100% stacked column |
| ----------------------- |:--------------:| -------------------:|
| ![{{ site.framework_name }} RadSpreadsheet Clustered Column](images/Features-Charts_1.png) | ![{{ site.framework_name }} RadSpreadsheet Stacked Column](images/Features-Charts_2.png) | ![{{ site.framework_name }} RadSpreadsheet 100% Stacked Column](images/Features-Charts_3.png)|


### Bar Charts

Bar charts are analogical to the column charts, except the orientation of the bars. These charts use horizontal bars instead of vertical columns to display the values and their categories.


| Clustered bar           | Stacked bar    | 100% stacked bar    |
| ----------------------- |:--------------:| -------------------:|
| ![{{ site.framework_name }} RadSpreadsheet Clustered Bar](images/Features-Charts_4.png) | ![{{ site.framework_name }} RadSpreadsheet Stacked Bar](images/Features-Charts_5.png) | ![{{ site.framework_name }} RadSpreadsheet 100% Stacked Bar](images/Features-Charts_6.png)|



### Line Charts

The line chart shows the category data distributed on the horizontal axis and all the values are distributed along the vertical axis. With this type of charts you can visualize continuous data over time on an evenly scaled axis. It is pretty helpful when you need to show trends in data at equal intervals, like months, years, or other periods.


| Line                    | Stacked line   | 100% stacked line   |
| ----------------------- |:--------------:| -------------------:|
| ![{{ site.framework_name }} RadSpreadsheet Line](images/Features-Charts_7.png) | ![{{ site.framework_name }} RadSpreadsheet Stacked Line](images/Features-Charts_8.png) | ![{{ site.framework_name }} RadSpreadsheet 100% Stacked Line](images/Features-Charts_9.png)|

| Line with Markers       | Stacked line with Markers| 100% stacked line with Markers|
| ----------------------- |:------------------------:| :----------------------------:
| ![{{ site.framework_name }} RadSpreadsheet Line with Markers](images/Features-Charts_16.png) | ![{{ site.framework_name }} RadSpreadsheet Stacked Line with Markers](images/Features-Charts_17.png) | ![{{ site.framework_name }} RadSpreadsheet 100% Stacked Line with Markers](images/Features-Charts_18.png)|

### Scatter and Bubble Charts

Scatter and bubble charts provide you with a convenient way to display a lot of related data in a single chart. In scatter charts, the x-axis displays one numeric field and the y-axis displays another. This type of plotting the data makes it easy to see the relationship between the two values for all the items in the chart.

In a bubble chart, a third numeric field determines the size of the data points represented as bubbles.

| Scatter     |Scatter with Smooth Lines | Scatter with Smooth Lines and Markers | 
| ----------- |:------------------------ |:--------------------------------------| 
| ![{{ site.framework_name }} RadSpreadsheet Scatter](images/Features-Charts_20.png) | ![{{ site.framework_name }} RadSpreadsheet Scatter with Smooth Lines](images/Features-Charts_22.png) | ![{{ site.framework_name }} RadSpreadsheet Scatter with Smooth Lines and Markers](images/Features-Charts_21.png) |
| Scatter with Straight Lines     |Scatter with Straight Lines and Markers | Bubble | 
| ![{{ site.framework_name }} RadSpreadsheet Scatter with Straight Lines](images/Features-Charts_24.png) | ![{{ site.framework_name }} RadSpreadsheet Scatter with Straight Lines and Markers](images/Features-Charts_23.png) | ![{{ site.framework_name }} RadSpreadsheet Bubble](images/Features-Charts_19.png) |




### Pie and Doughnut Charts
	
Pie charts are useful for comparing the values of different points in a single series. The data points in a pie chart are shown as a percentage of the whole pie. The doughnut chart is identical to the pie. However, it can contain more than a single series and can be visualized with a hole in the middle of the shape.


| Pie         | Doughnut  | 
| ----------- |:----------| 
| ![{{ site.framework_name }} RadSpreadsheet Pie](images/Features-Charts_10.png) | ![{{ site.framework_name }} RadSpreadsheet Doughnut](images/Features-Charts_11.png) |



### Area Charts

Area charts can be used to plot change over time and draw attention to the total value across a trend. Since the area chart shows the sum of the plotted values as well, it visualized how the different parts contribute to the end result of the data.

| Clustered area          | Stacked area   | 100% stacked area   |
| ----------------------- |:--------------:| -------------------:|
| ![{{ site.framework_name }} RadSpreadsheet Clustered Area](images/Features-Charts_12.png) | ![{{ site.framework_name }} RadSpreadsheet Stacked Area](images/Features-Charts_13.png) | ![{{ site.framework_name }} RadSpreadsheet 100% Stacked Area](images/Features-Charts_14.png)|


## Manipulating Charts in Code

You can work with charts programmatically as well. For more information about the available API, refer to the documentation of the library used as a model of RadSpreadsheet - RadSpreadProcessing: [Charts API](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/charts/overview).

## Exporting Charts to PDF

To export a chart element to PDF, you will need to implement an additional renderer which can draw the chart in the PDF document. For more details on how you can implement this renderer, refer to the [Export Chart to PDF](https://docs.telerik.com/devtools/document-processing/libraries/radspreadprocessing/features/charts/pdf-export.html) topic for RadSpreadProcessing and the [Export Chart SDK example](https://github.com/telerik/document-processing-sdk/tree/master/SpreadProcessing/ExportChart).