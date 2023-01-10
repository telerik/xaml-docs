---
title: Events
page_title: Events
description: This article describes the RadCarouselPanel events.
slug: carousel-radcarouselpanel-events
tags: events
published: True
position: 3
---

# {{ site.framework_name }} RadCarousel Events

This article lists the events specific to RadCarouselPanel. 

> The following events will be called only when the RadCarouselPanel is placed inside RadCarousel control.

* __TopContainerChanged__: Occurs when Telerik.Windows.Controls.RadCarouselPanel.TopContainer property is changed. The TopContainer property returns the container that has the largest ZIndex. This event will be called, either changing the items via mouse or keyboard left and right / up and down arrow keys.
	
* __SelectedIsTopItem__: Occurs when the selected element is the top item. This event will be called only when the selected item is changed.	

* __IsAnimatingChanged__:  Occurs when Telerik.Windows.Controls.RadCarouselPanel.IsAnimating property is changed.

## Subscribe to RadCarouselPanel Events

You can use the approach in __Example 1__ to subscrube to the RadCarouselPanel events.

#### __[XAML] Example 1: Subscribe to RadCarouselPanel Events__  
{{region -xaml-carousel-radcarouselpanel-events_0}}
	<telerik:RadCarousel x:Name="listView"  ItemsSource="{Binding Employees}"  ItemTemplate="{StaticResource customItemTemplate}">
		<telerik:RadCarousel.ItemsPanel>
			<ItemsPanelTemplate>
				<telerik:RadCarouselPanel SelectedIsTopItem="MyCarousel_SelectedIsTopItem" 
											TopContainerChanged="RadCarouselPanel_TopContainerChanged" 
											IsAnimatingChanged="RadCarouselPanel_IsAnimatingChanged"/>
			</ItemsPanelTemplate>
		</telerik:RadCarousel.ItemsPanel>            
	</telerik:RadCarousel>
{{endregion}}

#### __[C#] Example 2: Events Handlers__  
{{region csharp-carousel-radcarouselpanel-events_1}}
	private void MyCarousel_SelectedIsTopItem(object sender, RoutedEventArgs e)
	{
	}

	private void RadCarouselPanel_TopContainerChanged(object sender, RoutedEventArgs e)
	{
	}

	private void RadCarouselPanel_IsAnimatingChanged(object sender, RoutedEventArgs e)
	{
	}
{{endregion}}
	
## See Also  
 * [Getting Started]({%slug carousel-getting-started%}) 
 * [Getting Started]({%slug carousel-getting-started%}) 
