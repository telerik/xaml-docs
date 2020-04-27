---
title: Cross Thread CollectionChanged Interval
page_title: Cross Thread CollectionChanged Interval
description: The CrossThreadCollectionChangedInterval property allows you to control the time interval at which the CollectionChanged is dispatched to the UI thread
slug: radgridview-features-cross-thread-collection-changed-inverval
tags: cross,thread,async,itemssourcess
published: True
position: 22
---

# Cross Thread CollectionChanged Interval

RadGridView dispatches the ItemsSource collection changes made on a background thread back to the UI.

The __CrossThreadCollectionChangedInterval__ property allows you to control the time interval at which the CollectionChanged is dispatched to the UI thread. The default property value is `TimeSpan.Zero` and the updates happen on each CollectionChanged of the ItemsSource. 

The CrossThreadCollectionChangedInterval was introduced with version R2 2020 of Telerik UI for WPF.

#### __[XAML] Example 1: Setting CrossThreadCollectionChangedInterval to 3 seconds in XAML__
{{region radgridview-features-ui-virtualization-0}}
	<telerik:RadGridView CrossThreadCollectionChangedInterval="00:00:03.000" />
{{endregion}} 

#### __[C#] Example 2: Setting CrossThreadCollectionChangedInterval to 3 seconds in code__
{{region radgridview-features-ui-virtualization-1}}
	radGridView.CrossThreadCollectionChangedInterval = TimeSpan.FromSeconds(3);
{{endregion}} 

#### __[VB.NET] Example 2: Setting CrossThreadCollectionChangedInterval to 3 seconds in code__
{{region radgridview-features-ui-virtualization-2}}
	_radGridView.CrossThreadCollectionChangedInterval = TimeSpan.FromSeconds(3)
{{endregion}} 

>tip Setting the CrossThreadCollectionChangedInterval property to a bigger interval improves the performance in scenarios with multiple updates in the ItemsSource that happen often on a background thread. 
       
## See Also  
 * [Getting Started]({%slug gridview-getting-started2%})
 * [Performance Tips and Tricks]({%slug radgridview-performance-tips-tricks%})
 * [Populating with Data]({%slug gridview-data-overview%})
