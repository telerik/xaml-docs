---
title: Chart Point-marks
page_title: Chart Point-marks
description: Check our &quot;Chart Point-marks&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-chart-point-marks
tags: chart,point-marks
published: True
position: 15
---

# Chart Point-marks


Most of the charts show a point mark for each data point. __RadChart__ allows you to configure the appearance of these point marks by changing their shape and colors. To do that, you have to use __ISeriesDefinition.Appearance.PointMark__ property which is of type __PointMarkAppearanceSettings__ where you can change the __Fill__, __Shape__, __Stroke__ and __StrokeTickness__ properties of the point marks.

__RadChart__ supports eight predefined shapes that you can use to customize the appearance of the point marks for certain series like __Line__, __Spline__, __Area__, etc. The shapes are members of the __Telerik.Windows.Controls.Charting.MarkerShape__ enumeration:

* __Circle__ (default) 
![{{ site.framework_name }} RadChart Circle Point Mark](images/RadChart_Features_ChartPointMarks_010.png)

* __Diamond__
![{{ site.framework_name }} RadChart Diamond Point Mark](images/RadChart_Features_ChartPointMarks_020.png)

* __Hexagon__
![{{ site.framework_name }} RadChart Hexagon Point Mark](images/RadChart_Features_ChartPointMarks_030.png)

* __Square__
![{{ site.framework_name }} RadChart Square Point Mark](images/RadChart_Features_ChartPointMarks_040.png)

* __SquareRounded__
![{{ site.framework_name }} RadChart SquareRounded Point Mark](images/RadChart_Features_ChartPointMarks_050.png)

* __StarEightRay__
![{{ site.framework_name }} RadChart StarEightRay Point Mark](images/RadChart_Features_ChartPointMarks_060.png)

* __StarFiveRay__
![{{ site.framework_name }} RadChart StarFiveRay Point Mark](images/RadChart_Features_ChartPointMarks_070.png)

* __Triangle__
![{{ site.framework_name }} RadChart Triangle Point Mark](images/RadChart_Features_ChartPointMarks_080.png)


To learn more about customizing the point marks read the [Styling the Point Marks]({%slug radchart-styling-and-appearance-styling-point-marks%}) topic. In case the provided customizations are not enough, you can completely re-template the point mark. See [here]({%slug radchart-templating-point-marks%}) for more information.

## See Also

 * [Styling the Point Marks]({%slug radchart-styling-and-appearance-styling-point-marks%})

 * [Chart Area]({%slug radchart-features-chart-area%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})
