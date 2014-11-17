---
title: Chart Title
page_title: Chart Title
description: Chart Title
slug: radchart-features-chart-title
tags: chart,title
published: True
position: 11
---

# Chart Title

The __ChartTitle__ is a content control placed at the top of each chart control. It is used to display any title information regarding the visualized chart.
 
![](images/RadChart_Features_ChartTitle_01.png)

You can specify the content of the default __ChartTitle__ control from XAML or code-behind, like this:

#### __XAML__

{{region radchart-features-chart-title_0}}
	<telerikChart:RadChart x:Name="radChart">
	    <telerikChart:RadChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            <telerikCharting:ChartDefaultView.ChartTitle>

	                <telerikCharting:ChartTitle Content="Monthly Sales for 2009" HorizontalAlignment="Center"/>

	            </telerikCharting:ChartDefaultView.ChartTitle>
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:RadChart.DefaultView>
	</telerikChart:RadChart>
	{{endregion}}

#### __C#__

{{region radchart-features-chart-title_1}}
	radChart.DefaultView.ChartTitle.Content = "Monthly Sales for 2009";
	{{endregion}}

#### __VB.NET__

{{region radchart-features-chart-title_2}}
	radChart.DefaultView.ChartTitle.Content = "Monthly Sales for 2009"
	{{endregion}}

Since __ChartTitle__ is a content control, you can set as its content not only textual data but also any other type of controls. The following example demonstrates how to create custom chart title with __TextBlock__ in a __Border__ control.

#### __XAML__

{{region radchart-features-chart-title_3}}
	<telerikChart:RadChart>
	    <telerikChart:RadChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            <telerikCharting:ChartDefaultView.ChartTitle>

	                <telerikCharting:ChartTitle HorizontalAlignment="Center">
	                    <Border BorderBrush="LightBlue" CornerRadius="5" BorderThickness="2">
	                        <TextBlock Text="Monthly Sales for 2009" />
	                    </Border>
	                </telerikCharting:ChartTitle>

	            </telerikCharting:ChartDefaultView.ChartTitle>
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:RadChart.DefaultView>
	</telerikChart:RadChart>
	{{endregion}}

#### __C#__

{{region radchart-features-chart-title_4}}
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	....
	Border border = new Border();
	border.BorderThickness = new Thickness( 2 );
	border.CornerRadius = new CornerRadius( 5 );
	border.BorderBrush = new SolidColorBrush( Color.FromArgb( 255, 173, 216, 230 ) );
	border.Child = new TextBlock(){ Text = "Monthly Sales for 2009" };
	radChart.DefaultView.ChartTitle.Content = border;
	{{endregion}}

#### __VB.NET__

{{region radchart-features-chart-title_5}}
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	....
	Dim border As New Border()
	border.BorderThickness = New Thickness( 2 )
	border.CornerRadius = New CornerRadius( 5 )
	border.BorderBrush = New SolidColorBrush(Color.FromArgb( 255, 173, 216, 230 ))
	border.Child = New TextBlock()
	'Set the content of the ChartTitle
	radChart.DefaultView.ChartTitle.Content = border
	{{endregion}}



And here is the final result:
 
![](images/RadChart_Features_ChartTitle_02.png)

If you want to learn more about styling the __ChartTitle__ take a look at the [Customizing Title]({%slug radchart-styling-and-appearance-styling-chart-title%}) topic.

# See Also

 * [Styling the Chart Title]({%slug radchart-styling-and-appearance-styling-chart-title%})

 * [RadChart Visual Structure]({%slug radchart-general-information-visual-structure%})

 * [Chart Area]({%slug radchart-features-chart-area%})

 * [Chart Legend]({%slug radchart-features-chart-legend%})

 * [DefaultView]({%slug radchart-features-default-view%})
