---
title: Methods
page_title: Methods
description: The article describes the methods exposed by the RadCardView control.
slug: radcardview-methods
tags: methods,cardview
published: True
position: 3
---

# Methods

The RadCardView control exposes a number of public methods which allow you to invoke certain functionality programmatically. Here's a list of the available methods:

* **void Collapse(object item)**: Collapses the item (or group) passed as a parameter.
* **void Expand(object item)**: Expands the item passed as a parameter.
* **void ScrollIntoView(object item)**: Scrolls the card containing the data item into view.
* **IEnumerable GetDistinctValues(CardDataFieldDescriptor cardDataFieldDescriptor, bool filter, int? maximumValueCount = 1000)**: Returns distinct values for a given CardDataFieldDescriptor. Through the **filter** parameter you can determine whether to filter the distinct values based on other CardDataFieldDescriptors existing filters. The **maximumValueCount** parameter determines the maximum amount of distinct values to return (by default 1000). If you specify **null** for this parameter, then all distinct values will be returned. A good place to use this method would be in the [DistinctValuesLoading event]({%slug radcardview-events%}#filtering).

## See Also  
* [Getting Started]({%slug radcardview-getting-started%})
* [Filtering]({%slug radcardview-features-filtering%})
* [Grouping]({%slug radcardview-features-grouping%})
