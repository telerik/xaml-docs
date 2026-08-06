---
title: Smart Labels
page_title: Smart Labels
description: Check our &quot;Smart Labels&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-smart-labels
tags: smart,labels
published: True
position: 1
---

# Smart Labels

Since the official __Q1 2014__ release all series exposed by the __RadCartesianChart__ and the __RadPieChart__ controls support smart labels. The term "smart labels" refers to labels positioned in such a way that they do not overlap one another. This positioning strategy is helpful when the series has large number of data points with visualized labels. You can take advantage of this functionality through the __SmartLabelsStrategy__ property of the charting components. It is of type __ChartSmartLabelsStrategyBase__ and gets or sets the object that controls the positioning of the labels.      

## Using Smart Labels in RadCartesianChart

In order to enable a smart label strategy in a __RadCartesianChart__ you can utilize the __ChartSmartLabelsStrategy__.



```XAML
     <telerik:RadCartesianChart.SmartLabelsStrategy>
          <telerik:ChartSmartLabelsStrategy />
      </telerik:RadCartesianChart.SmartLabelsStrategy>
```

Let's say that you have line series with large number of data points and visualized labels![Telerik UI for WPF RadChartView line series with overlapping labels before smart labels are enabled](images/radchartview-disabled-smart-labels.png)

As you can see the labels are hard to read in such cases. The smart label strategy is designed to improve the readability of the labels. Once enabled, the labels will be rearranged so that each label is clearly visible.

![Telerik UI for WPF RadChartView line series with rearranged labels after smart labels are enabled](images/radchartview-enabled-smart-labels.png)

You can find this feature demonstrated in our {% if site.site_name == 'Silverlight' %}online [SmartLabels](https://demos.telerik.com/silverlight/#ChartView/SmartLabels) demo{% endif %}{% if site.site_name == 'WPF' %}[WPFdemos](https://demos.telerik.com/wpf/) ChartView -> SmartLabels example{% endif %}.        

## Using Smart Labels in RadPieChart

In order to enable a smart label strategy in a __RadPieChart__ you can utilize the __PieChartSmartLabelsStrategy__.



```XAML
    <telerik:RadPieChart.SmartLabelsStrategy>
      <telerik:PieChartSmartLabelsStrategy/>
    </telerik:RadPieChart.SmartLabelsStrategy>
```

Let's say that you have __PieSeries__ with small slices and visualized labels

![Telerik UI for WPF RadPieChart with overlapping labels before smart labels are enabled](images/radchartview-features-smart-labels-disabled.png)

This smart labels strategy exposes the __DisplayMode__ property. It is an enumeration of type __PieChartLabelsDisplayMode__ and adjusts the positioning algorithm of the labels. It provides the following members:

* __Basic__ - this is the default value and it positions the labels inside the __PieSeries__ so that they do not overlap one another.
  ![Telerik UI for WPF RadPieChart smart labels positioned inside pie slices with Basic display mode](images/radchartview-features-smart-labels-Basic.png)

* __Outside__ - this value positions the labels outside the slices.
  ![Telerik UI for WPF RadPieChart smart labels positioned outside pie slices](images/radchartview-features-smart-labels-outside.png)

* __Spider__ - this value positions the labels outside the slices and aligns them by the first symbol of the labels.
  ![Telerik UI for WPF RadPieChart smart labels aligned by their first character with Spider display mode](images/radchartview-features-smart-labels-spider.png)

* __SpiderAlignedOutwards__ - this value positions the labels outside the slices and aligns them by the last symbol of the labels.
  ![Telerik UI for WPF RadPieChart smart labels aligned by their last character with SpiderAlignedOutwards display mode](images/radchartview-features-smart-labels-spider-outside.png)

* __SpiderUnaligned__ - this value positions the labels outside the slices and does not align them.
  ![Telerik UI for WPF RadPieChart unaligned smart labels positioned outside pie slices](images/radchartview-features-smart-labels-unaligned.png)

>important In order to visualize the connections between the labels and the corresponding data points, you can take advantage of the __LabelConnectorsSettings__ property of the chart series. 
