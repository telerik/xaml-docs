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

__RadPropertyGrid__ supports filtering through its built-in search TextBox. The default behavior is __'search as you type'__ meaning that each time you modify the text, property definitions will be filtered based on their __DisplayName__ property.

![Rad Property Grid Disabled](images/RadPropertyGridSearchBox.png)

## Deferred Filtering

As of __Q3 2015, RadPropertyGrid__ exposes a new property – __EnableDeferredFiltering__. Its default value is __“False”__, and it determines that the filtering through the search text box will be performed dynamically. 

When __EnableDeferredFiltering__ is set to __“True”__, the filtering will be executed when the editor commits its value on __lost focus/enter__ or __tab key__. 

#### __[XAML] Example 1: Enabling Deferred Filtering__

	{{region xaml-radpropertygrid-filtering_0}}
	{{endregion}}

# See also

* [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

* [Grouping Support]({%slug radpropertygrid-grouping%})

* [Validation Support]({%slug radpropertygrid-features-validation%})
