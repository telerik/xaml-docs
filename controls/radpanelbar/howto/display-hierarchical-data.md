---
title: How to Display Hierarchical Data
page_title: How to Display Hierarchical Data
description: Check our &quot;How to Display Hierarchical Data&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
slug: howto-display-hierarchical-data
tags: how,to,display,hierarchical,data
published: True
position: 2
---

# How to Display Hierarchical Data

__RadPanelBarItem__ inherits from __HeaderedItemsControl__ therefore it can display hierarchical data, e.g. collections that contain other collections.

The __HierarchicalDataTemplate__ class is designed to be used with __HeaderedItemsControl__ types to display such data. There should be virtually no differences between the usage of __HierarchicalDataTemplate__ in __RadPanelBar__ and other controls.				

The following example demonstrates how to create a hierarchical data source and bind a __RadPanelBar__ to it, using a __HierarchicalDataTemplate__. The __ItemsSource__ property of the __HierarchicalDataTemplate__ specifies the __binding__ that has to be applied to the __ItemsSource__ property of each item. The __DataTemplate__ property specifies the template that has to be applied on each item, while the __ItemTemplate__ is the template applied on its child items.				

1. Create a new class and name it __MyViewModel__:					  

	<snippet id='radpanelbar-howto-display-hierarchical-data-block_1-cs' />
	<snippet id='radpanelbar-howto-display-hierarchical-data-block_1-vb' />

	The class has four properties:							  

	* Property __Price__ which is of type double.

	* Property __CreatedOn__ which is of type DateTime.

	* Property __Title__ which is of type string.

	* Property __RelatedItems__ which is a collection of objects. These are the child items. Add a static method to the class which aims to create some mock-up data:
		
		<snippet id='radpanelbar-howto-display-hierarchical-data-block_2-cs' />
		<snippet id='radpanelbar-howto-display-hierarchical-data-block_2-vb' />
		
1. Declare a __HierarchicalDataTemplate__ 
	
	<snippet id='radpanelbar-howto-display-hierarchical-data-block_3-xaml' />

1. Define the __RadPanelBar__ and set its __ItemTemplate__ property					  

	<snippet id='radpanelbar-howto-display-hierarchical-data-block_4-xaml' />

1. Set the __ItemsSource__ property of the __RadPanelBar__

	<snippet id='radpanelbar-howto-display-hierarchical-data-block_5-cs' />
	<snippet id='radpanelbar-howto-display-hierarchical-data-block_5-vb' />

	![{{ site.framework_name }} RadPanelBar Hierarchical Data](images/PanelBar_HierarchicalData.png)