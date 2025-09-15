---
title: Y-Axis
page_title: Y-Axis
description: Check our &quot;Y-Axis&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-axes-y-axis
tags: y-axis
published: True
position: 2
---

# Y-Axis



## 

This topic covers only the properties that are specific to the __Y-axis__. If you want to learn more about the properties that are common to both X and Y axes take a look at the [Axes Overview]({%slug radchart-features-axes-overview%}) topic.

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Y_Axis_01.png)

Besides the common properties, __Y-axis__ has some specific properties, explained in the list below:

* __MinorTickPointMultiplier__- specifies the number of minor ticks per major tick, i.e the number of the minor ticks between two major ticks. 


* __MinorTicksVisibility__- specifies whether the minor tick marks on the axis should be visible. 


* __MinorGridLinesVisibility__- specifies whether the minor axis grid lines should be visible. See [Striplines and Gridlines]({%slug radchart-features-axes-striplines-and-gridlines%}). 


* __ExtendDirection__- specifies the direction in which the axis range should be extended.

__AxisY.ExtendDirection__ is of type __AxisExtendDirection__ and has the following options:

* __Up__ - when selected, the upper end of the axis will be extended. 


* __Down__ - when selected, the lower end of the axis will be extended. 


* __Both__ - when selected, the upper and the lower end of the axis will be extended. 


* __Smart__ - when selected, the upper and the lower end of the axis will be extended unless 0 is set to __MinValue__ or __MaxValue__. In this case the axis will not be extended in the respective direction. 


* __None__ - when selected, the axis will not be extended.

In the example below you can see how changing the __ExtensionDirection__ properties reflects the charts. Also, notice the result when __MinorTickPointMultiplier__ is set to 5.

#### __XAML__

```XAML
	<telerik:RadChart x:Name="radChart">
	    <telerik:RadChart.DefaultView>
	        <telerik:ChartDefaultView>
	            <telerik:ChartDefaultView.ChartArea>
	                <telerik:ChartArea>
	                    <telerik:ChartArea.AxisY>
	                        <telerik:AxisY Title="Ampere [A]"
	                                       DefaultLabelFormat="0"
	                                       ExtendDirection="Down"
	                                       MinorTickPointMultiplier="5"
	                                       MinorTicksVisibility="Visible" />
	                    </telerik:ChartArea.AxisY>
	                </telerik:ChartArea>
	            </telerik:ChartDefaultView.ChartArea>
	        </telerik:ChartDefaultView>
	    </telerik:RadChart.DefaultView>
	</telerik:RadChart>
```



#### __C#__

```C#
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	//....
	radChart.DefaultView.ChartArea.AxisY.MinorTicksVisibility = Visibility.Visible;
	radChart.DefaultView.ChartArea.AxisY.MinorTickPointMultiplier = 5;
	radChart.DefaultView.ChartArea.AxisY.ExtendDirection = AxisExtendDirection.Down;
	radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "0";
	radChart.DefaultView.ChartArea.AxisY.Title="Ampere [A]";
	//....
```



#### __VB.NET__

```VB.NET
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	'....'
	radChart.DefaultView.ChartArea.AxisY.MinorTicksVisibility = Visibility.Visible
	radChart.DefaultView.ChartArea.AxisY.MinorTickPointMultiplier = 5
	radChart.DefaultView.ChartArea.AxisY.ExtendDirection = AxisExtendDirection.Down
	radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "0"
	radChart.DefaultView.ChartArea.AxisY.Title = "Ampere [A]"
	'....'
```



And here is a snapshot of the result. You can see how the Y-axis ticks are placed - there are four minor ticks between each 2 major ones. Moreover the visualization of the chart varies depending on the value specified for the __ExtendDirection__.

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Y_Axis_02.png)

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Y_Axis_03.png)

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Y_Axis_04.png)

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Y_Axis_05.png)

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Y_Axis_06.png)

## See Also

 * [Axes Overview]({%slug radchart-features-axes-overview%})

 * [X-Axis]({%slug radchart-features-axes-x-axis%})

 * [Striplines and Gridlines]({%slug radchart-features-axes-striplines-and-gridlines%})

 * [Styling the Axes Overview]({%slug radchart-styling-and-appearance-styling-axes-overview%})
