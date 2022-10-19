---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadDataPager {{ site.framework_name }} control.
slug: datapager-overview
tags: overview
published: True
position: 0
CTAControlName: RadDataPager
---

# Overview

{% if site.site_name == 'Silverlight' %}
![](images/RadDataPager_SL.png)
{% else %}
![](images/RadDataPager_WPF.png)
{% endif %}

Telerik DataPager provides the user with a navigation interface to page through any collection of data. The control provides paged data source to any data-bound controls. RadDataPager is extremely helpful when working with large collections of data.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %} 

![](images/datapager-overview-0.png)

## Key Features

* __Binding to IEnumerable__&mdash;RadDataPager can bind to any collection that implements the `IEnumerable` interface, which means that it can page any collection. The pager wraps the collection internally in an `IPagedCollectionView` and exposes it through its `PagedSource` property. In order to page a collection you have to pass it to the `Source` property of the DataPager. 

* __Programmatic Paging__&mdash;The developer is allowed to implement the paging programmatically, thanks to the API exposed by DataPager.

* __AutoEllipsis and DisplayMode__&mdash;Controls the user interface of the pager. 

{% if site.site_name == 'Silverlight' %}
* __WCF RIA Services and DomainDataSource support__&mdash;RadDataPager can be easily integrated with the `DomainDataSource` control and consume server data through __WCF RIA Services__. Check out the online demo at [https://demos.telerik.com/silverlight/#DomainDataSource/FirstLook](https://demos.telerik.com/silverlight/#DomainDataSource/FirstLook).
{% else %}
* __WCF Data Services and DataServicesDataSource support__&mdash;RadDataPager can be easily integrated with the `DataServicesDataSource` control and consume server data through __WCF Services__.
{% endif %}

## See Also  
 * [Visual Structure]({%slug raddatapager-visual-structure%})
 * [Getting Started]({%slug raddatapager-getting-started%})
 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})
 * [Events]({%slug raddatapager-events-overview%})