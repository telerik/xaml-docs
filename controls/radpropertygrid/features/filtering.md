---
title: Filtering
page_title: Filtering
description: Filtering
slug: radpropertygrid-filtering
tags: filtering
published: True
position: 18
---

# Filtering Support

RadPropertyGrid supports filtering through its built-in search TextBox. The default behavior is __'search as you type'__ meaning that each time you modify the text, property definitions will be filtered based on their DisplayName property.

![Rad Property Grid Disabled](images/RadPropertyGridSearchBox.png)

## Deferred Filtering

As of __Q3 2015__ RadPropertyGrid exposes a new property – __EnableDeferredFiltering__. Its default value is __“False”__, meaning that the filtering through the search text box will be performed dynamically. When its value is set to __“True”__, the filtering will be executed on __lost focus/enter__ or __tab key__.  

#### [XAML]Example 1: Setting EnableDeferredFiltering property to True

	<telerik:RadPropertyGrid x:Name="propertyGrid" 
	                         EnableDeferredFiltering="True">
	</telerik:RadPropertyGrid>


# See also

* [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

* [Grouping Support]({%slug radpropertygrid-grouping%})

* [Validation Support]({%slug radpropertygrid-features-validation%})