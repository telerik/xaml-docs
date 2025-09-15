---
title: Create a TimeBar control in Code-behind
page_title: Create a TimeBar control in Code-behind
description: Check our &quot;Create a TimeBar control in Code-behind&quot; documentation article for the RadTimeBar {{ site.framework_name }} control.
slug: radtimebar-create-a-timebar-control-in-code-behind
tags: create,a,timebar,control,in,code-behind
published: True
position: 0
---

# Create a TimeBar control in Code-behind

RadTimeBar supports lightweight batch initialization through the [ISupportInitialize](http://msdn.microsoft.com/en-us/library/system.componentmodel.isupportinitialize.aspx) interface. You can use the methods of this interface in code behind to create and initialize a time bar before adding it in the visual tree. Here is an example:

1. Create *[RadAreaSparkLine](http://www.telerik.com/help/silverlight/radsparkline_overview.html)* to use it as Content for the TimeBar control:

	>tip You can use *RadChart*, *RadSparkline* or any other custom control as Content for the RadTimeBar.

	#### __C#__

	```C#
		InitializeComponent();
		RadAreaSparkline sparkline = new RadAreaSparkline();
		Random r = new Random();
		List<int> data = new List<int>();
		for (DateTime currentDate = DateTime.Today; currentDate < DateTime.Today.AddDays(100);
		   currentDate = currentDate.AddDays(1))
		   {
			 data.Add(r.Next(0, 60));
		   }
		sparkline.ItemsSource = data;
		```



	#### __VB.NET__

	```VB.NET
		InitializeComponent()
		
		Dim sparkline As New RadAreaSparkline()
		
		Dim r As New Random()
		
		Dim data As New List(Of Integer)()
		
		Dim currentDate As Date = Date.Today
		Do While currentDate < Date.Today.AddDays(100)
		
		  data.Add(r.Next(0, 60))
		
		  currentDate = currentDate.AddDays(1)
		Loop
		
		sparkline.ItemsSource = data
		```

2. Create new TimeBar and add the SparkLine as Content. 

	#### __C#__
	```C#
		RadTimeBar timebar = new RadTimeBar();
		   timebar.BeginInit();
		   timebar.Width = 950;
		   timebar.Height = 250;
		   timebar.PeriodStart = new DateTime(2010, 1, 1);
		   timebar.PeriodEnd = new DateTime(2012, 1, 1);
		   timebar.VisiblePeriodStart = new DateTime(2010, 2, 14);
		   timebar.VisiblePeriodEnd = new DateTime(2011, 6, 2);
		   timebar.SelectionStart = new DateTime(2010, 5, 14);
		   timebar.SelectionEnd = new DateTime(2010, 6, 14);
		   timebar.Intervals.Add(new MonthInterval());
		   timebar.Intervals.Add(new WeekInterval());
		   timebar.Intervals.Add(new DayInterval());
		   timebar.EndInit();
		   timebar.Content = sparkline;
		   this.Content = timebar;
		```
		
	#### __VB.NET__
	```VB.NET
		Dim timebar As New RadTimeBar()
		   timebar.BeginInit()
		   timebar.Width = 950
		   timebar.Height = 250
		   timebar.PeriodStart = New Date(2010, 1, 1)
		   timebar.PeriodEnd = New Date(2012, 1, 1)
		   timebar.VisiblePeriodStart = New Date(2010, 2, 14)
		   timebar.VisiblePeriodEnd = New Date(2011, 6, 2)
		   timebar.SelectionStart = New Date(2010, 5, 14)
		   timebar.SelectionEnd = New Date(2010, 6, 14)
		   timebar.Intervals.Add(New MonthInterval())
		   timebar.Intervals.Add(New WeekInterval())
		   timebar.Intervals.Add(New DayInterval())
		   timebar.EndInit()
		   timebar.Content = sparkline
		   Me.Content = timebar
		```

The result:         
![{{ site.framework_name }} RadTimeBar Created in Code-Behind](images/radtimeBar_create_programmatically.PNG)