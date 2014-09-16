---
title: NoData Control
page_title: NoData Control
description: NoData Control
slug: radchart-features-no-data-control
tags: nodata,control
publish: True
position: 16
---

# NoData Control



## 

When __RadChart__ has no data to display, then a text message is shown in each __ChartArea__. The default message is __"No Data Series"__. If you want to display a different message, use the __ChartArea.NoDataString__ property and set the desired text.
        

If you don't want to use __No Data__ message, just set __ChartArea.IsNoDataMessageEnabled__ to __False__ (which, by default is set to __True__). In this case, the message and the border will be hidden.

#### __XAML__

{{region radchart-features-no-data-control_0}}
	<telerikCharting:ChartArea NoDataString="Custom 'No Data' message">
	{{endregion}}



#### __C#__

{{region radchart-features-no-data-control_1}}
	this.telerikChart.DefaultView.ChartArea.NoDataString = "Custom 'No Data' message";
	{{endregion}}



#### __VB.NET__

{{region radchart-features-no-data-control_2}}
	Me.telerikChart.DefaultView.ChartArea.NoDataString = "Custom 'No Data' message"
	{{endregion}}



On the image below you can see the custom message displayed.




         
      ![](images/RadChart_Features_NoDataControl_01.png)

If you need further customizations, check [Styling the No Data Control]({%slug radchart-styling-and-appearance-styling-no-data-control%}).

# See Also

 * [Styling the No Data Control]({%slug radchart-styling-and-appearance-styling-no-data-control%})

 * [Chart Area]({%slug radchart-features-chart-area%})
