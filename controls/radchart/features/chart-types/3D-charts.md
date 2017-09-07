---
title: 3D Charts
page_title: 3D Charts
description: 3D Charts
slug: radchart-features-chart-types-3d-charts
tags: 3d,charts
published: True
position: 1
---

# 3D Charts



## 

__RadChart__ offers {% if site.site_name == 'Silverlight' %}10{% endif %}{% if site.site_name == 'WPF' %}18{% endif %} 3D chart types: 


* Bar 3D
![](images/RadChart_types_bar3d_silverlight_thumb.png)
As Bar charts do, the Bar3D charts graphically display values in vertical and horizontal bars across categories. Bar3D charts are useful for comparing multiple series of data (i.e. providing snapshots of data at particular points in time).

* Stacked Bar 3D
![](images/RadChart_types_stackedbar3d_silverlight_thumb.png)
As StackedBar charts, the StackedBar3D are used to compare contributions of values to a total across categories. Use the StackedBar3D chart when you need visibility to the combined values for each category.

* Stacked Bar 100% 3D
![](images/RadChart_types_stackedbar1003d_silverlight_thumb.png)
As Stacked Bar 100% charts, Stacked Bar 100% 3D shows the combined contribution of values as percentages where the combined total for each category is 100 percent. Use when the relationship between values in a category is more significant than the amounts.

* Pie 3D
![](images/RadChart_types_pie3d_silverlight_thumb.png)
The Pie3D chart shows slices representing fractional parts of a whole. When you need to display the contribution of fractional parts to a whole.

* Doughnut 3D
![](images/RadChart_types_doughnut3d_silverlight_thumb.png)
Same as Pie3D chart, but leaving the center empty (for additional Pie3D/Doughnut3D series). When you need to display the contribution of fractional parts to a whole.

* Line 3D
![](images/RadChart_types_line3d_silverlight_thumb.png)
Line3D chart type displays a set of data points connected by a line in a 3D scene. A common use for the line chart is to show trends over a period of time. 

* Area 3D
![](images/RadChart_types_area3d_silverlight_thumb.png)
The Area 3D chart consists of a series of data points joined by a line where the area below the line is filled. Area charts are appropriate for visualizing data that fluctuates over a period of time and can be useful for emphasizing trends.

* Stacked Area 3D
![](images/RadChart_types_stackedarea3d_silverlight_thumb.png)
The Stacked Area 3D chart is a variation of the Area 3D chart that displays trends of the contribution of each value over time (or across categories). The areas are stacked so that each series adjoins but does not overlap the preceding series. Stacked Area charts are appropriate for visualizing data that fluctuates over a period of time and can be useful for emphasizing trends.

* Stacked Area 100% 3D
![](images/RadChart_types_stackedarea1003d_silverlight_thumb.png)
The Stacked Area 100% 3D charts are a variation of the Stacked Area charts that present values for trends as percentages, totaling to 100% for each category. Use this chart type to visualize data that fluctuates over a period of time and where the relationship between the values in a category is more significant than the amounts. 

* Stacked Line 3D
![](images/RadChart_types_stackedline3d_silverlight_thumb.png)
The Stacked Line 3D chart is a variation of the Stacked Line chart that displays a set of data points connected by a line, but the lines are stacked so that each series adjoins but does not overlap the preceding series. Use this chart type when you need visibility to the combined values of two or more series.

* Funnel 
{% if site.site_name == 'WPF' %} ![Funnel 3D](images/RadChart_types_funnel_wpf_thumb.png){% endif %} 
The Funnel chart renders data from a single series, where items are stacked on top of each other. The height of the items represent their contribution to the whole. When you need to display the contribution of fractional parts to a whole.

* Pyramid 
{% if site.site_name == 'WPF' %} ![Pyramid](images/RadChart_types_pyramid_wpf_thumb.png){% endif %} 
The Pyramid chart renders data from a single series, where items are stacked on top of each other. The height of the items represent their contribution to the whole.</td><td>When you need to display the contribution of fractional parts to a whole.

* Spline 3D 
{% if site.site_name == 'WPF' %} ![Spline 3D](images/RadChart_types_spline3d_wpf_thumb.png){% endif %} 
Spline 3D charts allow you to take a limited set of known data points and approximate intervening values. The Spline 3D chart is often used for data modelling by taking a limited number of data points and interpolating or estimating the intervening values.

*Spline Area 3D 
{% if site.site_name == 'WPF' %} ![](images/RadChart_types_splinearea3d_wpf_thumb.png){% endif %}
The Spline Area 3D chart type defines one or more spline curves and fills in the space defined by the spline in the 3D scene. Can be used for data modelling. It takes a limited number of data points and interpolates the intervening values. This chart type also emphasizes the area between the spline curve and a mid-point of the spline.

* Stacked Spline 3D
![](images/RadChart_types_stackedspline3d_wpf_thumb.png)
The Stacked Spline 3D chart is a variation of the Stacked Spline chart. The areas are stacked so that each series adjoins but does not overlap the preceding series. Use the Stacked Spline when you need to show the correlation between two or more series of data visualized as splines.

* Stacked Spline Area 3D
![](images/RadChart_types_stackedsplinearea3d_wpf_thumb.png)
The Stacked Spline Area 3D chart is a variation of the Spline Area 3D chart that displays trends of the contribution of each value over time (or across categories). The areas are stacked so that each series adjoins but does not overlap the preceding series. Can be used for data modelling. It takes a limited number of data points and interpolates the intervening values. This chart type allows the entire surface area for all sequences to be displayed at one time.

* Stacked Spline Area 100% 3D 
{% if site.site_name == 'WPF' %} ![](images/RadChart_types_stackedsplinearea1003d_wpf_thumb.png)
The Stacked Spline Area 100% 3D charts are a variation of the Spline Area 3D chart. The areas are stacked so that each series adjoins but does not overlap the preceding series and where the combined total for each category is 100 percent.{% endif %} Can be used for data modelling. It takes a limited number of data points and interpolates the intervening values. This chart type allows the entire surface area for all sequences to be displayed at onece. Use this chart type when the relationship between values in a category is more significant than the amounts.

* Bubble3D 
{% if site.site_name == 'WPF' %} ![](images/RadChart_types_bubble3d_wpf_thumb.png)
The Bubble3D chart shows correlations between sets of values. The bubble size is used to convey larger values. The Bubble3D chart is often used for scientific data modeling or financial data.{% endif %}



## See Also

 * [2D Charts]({%slug radchart-features-chart-types-2d-charts%})

 * [Create Data Bound Chart]({%slug radchart-getting-started-create-data-bound-chart%})

 * [Create a Line Chart with Static Data]({%slug radchart-getting-started-create-a-line-chart-with-static-data%})
