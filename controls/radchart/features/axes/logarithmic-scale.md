---
title: Logarithmic Scale
page_title: Logarithmic Scale
description: Check our &quot;Logarithmic Scale&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-axes-logarithmic-scale
tags: logarithmic,scale
published: True
position: 5
---

# {{ site.framework_name }} RadChart Logarithmic Scale



## 

If you have a very large range of values on the Y-Axis, the points with the smallest values may not be easily visible. This is because the scale for the Y-Axis will be linear. In this case you can scale the Y-Axis logarithmically, so there is enough space for each value. The logarithmic scaling is calculated automatically, you just have to set the __IsLogarithmic__ property of the __YAxis__ to __True__.

Here is an example of a __RadChart__ that visualizes the following values - 10, 100, 1000, 10000, 100000, 1000000.

#### __XAML__

{{region xaml-radchart-features-axes-logarithmic-scale_0}}
	<telerik:RadChart x:Name="radChart" />
{{endregion}}



#### __C#__

{{region cs-radchart-features-axes-logarithmic-scale_1}}
	this.radChart.ItemsSource = new int[] { 10, 100, 1000, 10000, 100000, 1000000 };
{{endregion}}



#### __VB.NET__

{{region vb-radchart-features-axes-logarithmic-scale_2}}
	Me.radChart.ItemsSource = New Integer() {10, 100, 1000, 10000, 100000, 1000000}
{{endregion}}

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Logarithmic_Scale_01.png)

Here is the same __RadChart__, but this time with logarithmic Y-Axis.

#### __XAML__

{{region xaml-radchart-features-axes-logarithmic-scale_3}}
	<telerik:RadChart>
	    <telerik:RadChart.DefaultView>
	        <telerik:ChartDefaultView>
	            <telerik:ChartDefaultView.ChartArea>
	                <telerik:ChartArea>
	                    <telerik:ChartArea.AxisY>
	                        <telerik:AxisY IsLogarithmic="True" />
	                    </telerik:ChartArea.AxisY>
	                </telerik:ChartArea>
	            </telerik:ChartDefaultView.ChartArea>
	        </telerik:ChartDefaultView>
	    </telerik:RadChart.DefaultView>
	</telerik:RadChart>
{{endregion}}



#### __C#__

{{region cs-radchart-features-axes-logarithmic-scale_4}}
	this.radChart.DefaultView.ChartArea.AxisY.IsLogarithmic = true;
{{endregion}}



#### __VB.NET__

{{region vb-radchart-features-axes-logarithmic-scale_5}}
	Me.radChart.DefaultView.ChartArea.AxisY.IsLogarithmic = True
{{endregion}}



>tipYou can use the __LogarithmBase__ property of the __AxisY__ to modify the base on which the logarithmic function for the axis is calculated.

![{{ site.framework_name }} RadChart  ](images/RadChart_Features_Axes_Logarithmic_Scale_02.png)
