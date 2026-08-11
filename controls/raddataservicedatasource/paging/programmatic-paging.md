---
title: Programmatic Paging
page_title: Programmatic Paging
description: Check our &quot;Programmatic Paging&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-paging-programmatic-paging
tags: programmatic,paging
published: True
position: 1
---

# Programmatic Paging

Programmatic paging could be done with the help of the public paging API that __RadDataServiceDataSource.DataView__ provides. The __DataView__ property implements the __IPagedCollectionView__ interface which contains all paging methods and properties.

__Example 1: The IPagedCollectionView interface__

<snippet id='raddataservicedatasource-paging-programmatic-paging-example_1_the_ipagedcollectionview_interface-cs' />

<snippet id='raddataservicedatasource-paging-programmatic-paging-example_1_the_ipagedcollectionview_interface-vb' />


__Example 2__ shows how to use the **DataView** in order to set the last page as the current page.

__Example 2: Moving to the last page__

<snippet id='raddataservicedatasource-paging-programmatic-paging-example_2_moving_to_the_last_page-cs' />

<snippet id='raddataservicedatasource-paging-programmatic-paging-example_2_moving_to_the_last_page-vb' />


When a page change is requested, a trip to the server will be made regardless of the __AutoLoad__ setting. When filtering, sorting or grouping occurs, a trip to the server is made, the __DataView__ is re-created and always returns to the first page.  

## See Also

* [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
* [Manual vs. Auto Loading]({%slug raddataservicedatasource-loading-manual-auto-loading%})