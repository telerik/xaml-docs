---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtimebar-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadTimeBar__.

## Assembly References

In order to use __RadTimeBar__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining the Control

Defining the control requires setting several vital properties. Those are __PeriodStart__, __PeriodEnd__ and __Intervals__.

#### __[XAML] Example 1: Adding RadTimeBar in XAML__
{{region radtimebar-getting-started-0}}
	<telerik:RadTimeBar PeriodStart="1-Jan-2019 12:00:00 AM" 
						PeriodEnd="31-Dec-2019 11:59:59 PM">
		<telerik:RadTimeBar.Intervals>
			<telerik:YearInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeBar.Intervals>
	</telerik:RadTimeBar>
{{endregion}}

#### __[C#] Example 2: Adding RadTimeBar in code__
{{region radtimebar-getting-started-1}}	
	RadTimeBar timeBar = new RadTimeBar();
	timeBar.BeginInit();
	timeBar.PeriodStart =  new DateTime(2019, 1, 1, 12, 0, 0);
	timeBar.PeriodEnd = new DateTime(2019, 12, 31, 23, 59, 59);
	timeBar.Intervals.Add(new YearInterval());
	timeBar.Intervals.Add(new MonthInterval());
	timeBar.Intervals.Add(new WeekInterval());
	timeBar.Intervals.Add(new DayInterval());
	timeBar.EndInit();
{{endregion}}

#### __[VB.NET] Example 2: Adding RadTimeBar in code__
{{region radtimebar-getting-started-2}}	
	Dim timeBar As RadTimeBar = New RadTimeBar()
    timeBar.BeginInit()
    timeBar.PeriodStart = New DateTime(2019, 1, 1, 12, 0, 0)
    timeBar.PeriodEnd = New DateTime(2019, 12, 31, 23, 59, 59)
    timeBar.Intervals.Add(New YearInterval())
    timeBar.Intervals.Add(New MonthInterval())
    timeBar.Intervals.Add(New WeekInterval())
    timeBar.Intervals.Add(New DayInterval())
    timeBar.EndInit()
{{endregion}}

#### __Figure 1: RadTimeBar__
![](images/radtimebar-getting-started-0.png)

## Setting the Visible Period

The visible period defines what portion of the period to be brought into the viewport. This can be also looked as zooming. The visible period is defined via the __VisiblePeriodStart__ and __VisiblePeriodEnd__ properties.

#### __[XAML] Example 3: Setting the visible period in XAML__
{{region radtimebar-getting-started-3}}
	<telerik:RadTimeBar PeriodStart="1-Jan-2019 12:00:00 AM" 
						PeriodEnd="31-Dec-2019 11:59:59 PM"
						
						VisiblePeriodStart="14-March-2019 12:00:00 AM" 
						VisiblePeriodEnd="11-Nov-2019 11:59:59 PM">
		<telerik:RadTimeBar.Intervals>
			<telerik:YearInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeBar.Intervals>
	</telerik:RadTimeBar>
{{endregion}}

#### __[C#] Example 4: Setting the visible period in code__
{{region radtimebar-getting-started-4}}
	RadTimeBar timeBar = new RadTimeBar();
	timeBar.BeginInit();
	timeBar.PeriodStart = new DateTime(2019, 1, 1, 12, 0, 0);
	timeBar.PeriodEnd = new DateTime(2019, 12, 31, 23, 59, 59);
	timeBar.VisiblePeriodStart = new DateTime(2019, 3, 14, 23, 59, 59);
	timeBar.VisiblePeriodEnd = new DateTime(2019, 11, 11, 12, 0, 0);
	timeBar.Intervals.Add(new YearInterval());
	timeBar.Intervals.Add(new MonthInterval());
	timeBar.Intervals.Add(new WeekInterval());
	timeBar.Intervals.Add(new DayInterval());
	timeBar.EndInit();
{{endregion}}

#### __[VB.NET] Example 4: Setting the visible period in code__
{{region radtimebar-getting-started-5}}
	Dim timeBar As RadTimeBar = New RadTimeBar()
    timeBar.BeginInit()
    timeBar.PeriodStart = New DateTime(2019, 1, 1, 12, 0, 0)
    timeBar.PeriodEnd = New DateTime(2019, 12, 31, 23, 59, 59)
    timeBar.VisiblePeriodStart = New DateTime(2019, 3, 14, 23, 59, 59)
    timeBar.VisiblePeriodEnd = New DateTime(2019, 11, 11, 12, 0, 0)
    timeBar.Intervals.Add(New YearInterval())
    timeBar.Intervals.Add(New MonthInterval())
    timeBar.Intervals.Add(New WeekInterval())
    timeBar.Intervals.Add(New DayInterval())
    timeBar.EndInit()
{{endregion}}

#### __Figure 2: RadTimeBar with visible period set__
![](images/radtimebar-getting-started-1.png)

## Selecting an Interval

To select an interval you can set the RadTimeBar's __SelectionStart__ and __SelectionEnd__ properties.

#### __[XAML] Example 5: Setting the selection in XAML__
{{region radtimebar-getting-started-6}}
	<telerik:RadTimeBar PeriodStart="1-Jan-2019 12:00:00 AM" 
						PeriodEnd="31-Dec-2019 11:59:59 PM"						
						VisiblePeriodStart="14-March-2019 12:00:00 AM" 
						VisiblePeriodEnd="11-Nov-2019 11:59:59 PM"
						SelectionStart="1-Jun-2019 12:00:00 AM" 
						SelectionEnd="25-Aug-2019 11:59:59 PM">
		<telerik:RadTimeBar.Intervals>
			<telerik:YearInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeBar.Intervals>
	</telerik:RadTimeBar>
{{endregion}}

#### __[C#] Example 6: Setting the selection in code__
{{region radtimebar-getting-started-7}}
	RadTimeBar timeBar = new RadTimeBar();
	timeBar.BeginInit();
	timeBar.PeriodStart = new DateTime(2019, 1, 1, 12, 0, 0);
	timeBar.PeriodEnd = new DateTime(2019, 12, 31, 23, 59, 59);
	timeBar.VisiblePeriodStart = new DateTime(2019, 3, 14, 12, 0, 0);
	timeBar.VisiblePeriodEnd = new DateTime(2019, 11, 11, 23, 59, 59);
	timeBar.SelectionStart = new DateTime(2019, 6, 1, 12, 0, 0);
	timeBar.SelectionEnd = new DateTime(2019, 8, 25, 23, 59, 59);
	timeBar.Intervals.Add(new YearInterval());
	timeBar.Intervals.Add(new MonthInterval());
	timeBar.Intervals.Add(new WeekInterval());
	timeBar.Intervals.Add(new DayInterval());
	timeBar.EndInit();
{{endregion}}

#### __[VB.NET] Example 6: Setting the selection in code__
{{region radtimebar-getting-started-8}}
	Dim timeBar As RadTimeBar = New RadTimeBar()
    timeBar.BeginInit()
    timeBar.PeriodStart = New DateTime(2019, 1, 1, 12, 0, 0)
    timeBar.PeriodEnd = New DateTime(2019, 12, 31, 23, 59, 59)
    timeBar.VisiblePeriodStart = New DateTime(2019, 3, 14, 12, 0, 0)
    timeBar.VisiblePeriodEnd = New DateTime(2019, 11, 11, 23, 59, 59)
    timeBar.SelectionStart = New DateTime(2019, 6, 1, 12, 0, 0)
    timeBar.SelectionEnd = New DateTime(2019, 8, 25, 23, 59, 59)
    timeBar.Intervals.Add(New YearInterval())
    timeBar.Intervals.Add(New MonthInterval())
    timeBar.Intervals.Add(New WeekInterval())
    timeBar.Intervals.Add(New DayInterval())
    timeBar.EndInit()
{{endregion}}

#### __Figure 3: RadTimeBar with selection defined__
![](images/radtimebar-getting-started-2.png)

## Hosting Another Control

The RadTimeBar component allows you to host another control in it, thus enchancing the visualization. The most common scenario is hosting a RadSparkline control.

The following example demonstrates how to populate a simple RadLinearSparkline with data and host it in RadTimeBar. Read more about the RadSparkline controls in its [help documentation]({%slug radsparkline_overview%}).

#### __[XAML] Example 7: Hosting RadSparkline in RadTimeBar in XAML__
{{region radtimebar-getting-started-9}}
	<telerik:RadTimeBar PeriodStart="1-Jan-2019 12:00:00 AM" 
						PeriodEnd="31-Dec-2019 11:59:59 PM"						
						VisiblePeriodStart="14-March-2019 12:00:00 AM" 
						VisiblePeriodEnd="11-Nov-2019 11:59:59 PM"
						SelectionStart="1-Jun-2019 12:00:00 AM" 
						SelectionEnd="25-Aug-2019 11:59:59 PM">
		<telerik:RadTimeBar.Intervals>
			<telerik:YearInterval />
			<telerik:MonthInterval />
			<telerik:WeekInterval />
			<telerik:DayInterval />
		</telerik:RadTimeBar.Intervals>
		<telerik:RadTimeBar.Content>
			<telerik:RadLinearSparkline x:Name="sparkline"/>
		</telerik:RadTimeBar.Content>
	</telerik:RadTimeBar>
{{endregion}}

#### __[C#] Example 8: Hosting RadSparkline in RadTimeBar in code__
{{region radtimebar-getting-started-10}}
	this.timeBar = new RadTimeBar();
	timeBar.BeginInit();
	timeBar.PeriodStart = new DateTime(2019, 1, 1, 12, 0, 0);
	timeBar.PeriodEnd = new DateTime(2019, 12, 31, 23, 59, 59);
	timeBar.VisiblePeriodStart = new DateTime(2019, 3, 14, 12, 0, 0);
	timeBar.VisiblePeriodEnd = new DateTime(2019, 11, 11, 23, 59, 59);
	timeBar.SelectionStart = new DateTime(2019, 6, 1, 12, 0, 0);
	timeBar.SelectionEnd = new DateTime(2019, 8, 25, 23, 59, 59);
	timeBar.Intervals.Add(new YearInterval());
	timeBar.Intervals.Add(new MonthInterval());
	timeBar.Intervals.Add(new WeekInterval());
	timeBar.Intervals.Add(new DayInterval());
	timeBar.EndInit();            
	timeBar.Content = new RadLinearSparkline();
{{endregion}}

#### __[VB.NET] Example 8: Hosting RadSparkline in RadTimeBar in code__
{{region radtimebar-getting-started-11}}	
	Dim timeBar As RadTimeBar = New RadTimeBar()
	timeBar.BeginInit()
	timeBar.PeriodStart = New DateTime(2019, 1, 1, 12, 0, 0)
	timeBar.PeriodEnd = New DateTime(2019, 12, 31, 23, 59, 59)
	timeBar.VisiblePeriodStart = New DateTime(2019, 3, 14, 12, 0, 0)
	timeBar.VisiblePeriodEnd = New DateTime(2019, 11, 11, 23, 59, 59)
	timeBar.SelectionStart = New DateTime(2019, 6, 1, 12, 0, 0)
	timeBar.SelectionEnd = New DateTime(2019, 8, 25, 23, 59, 59)
	timeBar.Intervals.Add(New YearInterval())
	timeBar.Intervals.Add(New MonthInterval())
	timeBar.Intervals.Add(New WeekInterval())
	timeBar.Intervals.Add(New DayInterval())
	timeBar.EndInit()
	timeBar.Content = New RadLinearSparkline()
{{endregion}}

#### __[C#] Example 9: Setting up the ItemsSource of the sparkline control__
{{region radtimebar-getting-started-12}}
	private static Random r = new Random();
	
	private void SetupSparkLineSource()
	{
		List<int> data = new List<int>();
		DateTime startDate = new DateTime(2019, 1, 1, 12, 0, 0);
		DateTime endDate = new DateTime(2019, 12, 31, 23, 59, 59);
		for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(15))
		{
			data.Add(r.Next(0, 60));
		}
		this.sparkline.ItemsSource = data;
	}
{{endregion}}

#### __[VB.NET] Example 9: Setting up the ItemsSource of the sparkline control__
{{region radtimebar-getting-started-13}}
	Private Shared r As Random = New Random()
    Private Sub SetupSparkLineSource()
        Dim data As List(Of Integer) = New List(Of Integer)()
        Dim startDate As DateTime = New DateTime(2019, 1, 1, 12, 0, 0)
        Dim endDate As DateTime = New DateTime(2019, 12, 31, 23, 59, 59)
        Dim currentDate As DateTime = startDate

        While currentDate <= endDate
            data.Add(r.[Next](0, 60))
            currentDate = currentDate.AddDays(15)
        End While

        Me.sparkline.ItemsSource = data
    End Sub
{{endregion}}

#### __Figure 4: RadTimeBar and RadSparkline__
![](images/radtimebar-getting-started-3.png)

## See Also  
* [Properties]({%slug radtimebar-properties%})
* [SDK Examples]({%slug radtimebar-sdk-examples%})
* [MVVM Support]({%slug radtimebar-mvvm-support%})
