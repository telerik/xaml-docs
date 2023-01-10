---
title: NoData Control
page_title: NoData Control
description: Check our &quot;NoData Control&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-no-data-control
tags: nodata,control
published: True
position: 16
---

# {{ site.framework_name }} RadChart NoData Control



## 

When __RadChart__ has no data to display, then a text message is shown in each __ChartArea__. The default message is __"No Data Series"__. If you want to display a different message, use the __ChartArea.NoDataString__ property and set the desired text.
        

If you don't want to use __No Data__ message, just set __ChartArea.IsNoDataMessageEnabled__ to __False__ (which, by default is set to __True__). In this case, the message and the border will be hidden.

#### __XAML__

{{region xaml-radchart-features-no-data-control_0}}
	<telerik:ChartArea NoDataString="Custom 'No Data' message" />
{{endregion}}



#### __C#__

{{region cs-radchart-features-no-data-control_1}}
	this.radChart.DefaultView.ChartArea.NoDataString = "Custom 'No Data' message";
{{endregion}}



#### __VB.NET__

{{region vb-radchart-features-no-data-control_2}}
	Me.telerikChart.DefaultView.ChartArea.NoDataString = "Custom 'No Data' message"
{{endregion}}



On the image below you can see the custom message displayed.

![{{ site.framework_name }} RadChart No Data Content](images/RadChart_Features_NoDataControl_01.png)

If you need further customizations, check [Styling the No Data Control]({%slug radchart-styling-and-appearance-styling-no-data-control%}).

## See Also

 * [Styling the No Data Control]({%slug radchart-styling-and-appearance-styling-no-data-control%})

 * [Chart Area]({%slug radchart-features-chart-area%})
