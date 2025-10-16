---
title: Using RadCarouselPanel with Items Controls
page_title: Using RadCarouselPanel with Items Controls
description: Check our &quot;Using RadCarouselPanel with Items Controls&quot; documentation article for the RadCarousel {{ site.framework_name }} control.
slug: carousel-radcarouselpanel-items-controls
tags: using,radcarouselpanel,with,items,controls
published: True
position: 1
---

# Using RadCarouselPanel with Items Controls


## Panels in WPF

The Windows Presentation Foundation architecture mandates that all layout should be performed by classes inheriting from Panel. Panels are responsible for arranging their children on the screen and controls that need special layouts delegate that responsibility to a companion panel class.

The most common occasion where we can see that in action are the WPF ItemsControl classes. They display various objects by wrapping them in the respective UI containers. Apart from that, the UI representation of the data items is laid out on the screen using a panel.

## Changing an ItemsControl's template

All ItemsControl-derived classes expose a public property, ItemsPanel, that allows you to plug a panel different than the default one. In the example below we replace a ListBox's default vertically-oriented panel with a horizontally-oriented one:



```XAML
	<ListBox x:Name="HorizontalListBox">
	  <ListBox.ItemsPanel>
	    <ItemsPanelTemplate>
	      <StackPanel Orientation="Horizontal"></StackPanel>
	    </ItemsPanelTemplate>
	  </ListBox.ItemsPanel>
	</ListBox>
```



## Using RadCarouselPanel as an Items Panel

RadCarouselPanel, being a normal Panel can be used in a similar fashion thus allowing designers and developers to completely change the appearance of a control while preserving its functionality. Here is how to change a WPF ListView and make it look like a carousel control:



```XAML
	<ListView x:Name="ListView">
	  <ListView.ItemsPanel>
	    <ItemsPanelTemplate>
	      <telerik:RadCarouselPanel/>
	    </ItemsPanelTemplate>
	  </ListView.ItemsPanel>
	</ListView>
```



The end result is displayed below:

 ![{{ site.framework_name }} RadCarousel RadCarouselPanel with Items Controls](images/RadCarouselPanel_ItemsPanel.png)

>Notice the scrollbars above __RadCarouselPanel__ implements the WPF standard __IScrollInfo__ interface that allows you to place the panel inside a ScrollViewer control, and navigate the items using the scrollbars. The ListView default control template contains a ScrollViewer that automatically scrolls the carousel items.
