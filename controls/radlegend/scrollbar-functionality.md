---
title: ScrollBar Functionality
page_title: ScrollBar Functionality
description: Check our &quot;ScrollBar Functionality&quot; documentation article for the RadLegend {{ site.framework_name }} control.
slug: radlegend-scrollbar-functionality
tags: scrollbar,functionality
published: True
position: 4
---

# ScrollBar Functionality

In this article you can find how to add scroll bar functionality to the control.

By default the RadLegend uses a StackPanel with Vertical orientation to lay out the legend items. Sometimes it is necessary to show many items in the legend and when there is not enough space some items will not be visible. One option to avoid this is to use a ScrollViewer to wrap the RadLegend in:        


```XAML
	<ScrollViewer VerticalScrollBarVisibility="Auto" Width="130" Height="350">
	    <telerik:RadLegend>
	        <telerik:RadLegend.Items>
	            <telerik:LegendItemCollection>
	                <telerik:LegendItem MarkerFill="#FF55AA33" MarkerStroke="Black" Title="Legend item 1" />
	                <telerik:LegendItem MarkerFill="#FFCC3399" MarkerStroke="Black" Title="Legend item 2" />
	                <telerik:LegendItem MarkerFill="#FF5511BB" MarkerStroke="Black" Title="Legend item 3" />
	                <telerik:LegendItem MarkerFill="#FF55AA33" MarkerStroke="Black" Title="Legend item 4" />
	                <telerik:LegendItem MarkerFill="#FFCC3399" MarkerStroke="Black" Title="Legend item 5" />
	                <telerik:LegendItem MarkerFill="#FF5511BB" MarkerStroke="Black" Title="Legend item 6" />
	                <telerik:LegendItem MarkerFill="#FF55AA33" MarkerStroke="Black" Title="Legend item 7" />
	                <telerik:LegendItem MarkerFill="#FFCC3399" MarkerStroke="Black" Title="Legend item 8" />
	                <telerik:LegendItem MarkerFill="#FF5511BB" MarkerStroke="Black" Title="Legend item 9" />
	                <telerik:LegendItem MarkerFill="#FF55AA33" MarkerStroke="Black" Title="Legend item 10" />
	                <telerik:LegendItem MarkerFill="#FFCC3399" MarkerStroke="Black" Title="Legend item 11" />
	                <telerik:LegendItem MarkerFill="#FF5511BB" MarkerStroke="Black" Title="Legend item 12" />
	                <telerik:LegendItem MarkerFill="#FF55AA33" MarkerStroke="Black" Title="Legend item 13" />
	                <telerik:LegendItem MarkerFill="#FFCC3399" MarkerStroke="Black" Title="Legend item 14" />
	                <telerik:LegendItem MarkerFill="#FF5511BB" MarkerStroke="Black" Title="Legend item 15" />
	            </telerik:LegendItemCollection>
	        </telerik:RadLegend.Items>
	    </telerik:RadLegend>
	</ScrollViewer>
```

Here is the end result:        

ScrollViewer height is 350  
![radlegend-scrollbar-0-H 350](images/radlegend-scrollbar-0-H350.png)

ScrollViewer height is 100  
![radlegend-scrollbar-0-H 100](images/radlegend-scrollbar-0-H100.png)