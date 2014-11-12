---
title: Programmatic Paging
page_title: Programmatic Paging
description: Programmatic Paging
slug: raddataservicedatasource-paging-programmatic-paging
tags: programmatic,paging
published: True
position: 0
---

# Programmatic Paging



## 

Programmatic paging could be done with the help of the public paging API that __RadDataServiceDataSource.DataView__ provides. The __DataView__ property implements the __IPagedCollectionView__ interface which contains all paging methods and properties. When a page change is requested, a trip to the server will be made regardless of the __AutoLoad__ setting. When filtering, sorting or grouping occurs, a trip to the server is made, the __DataView__ is re-created and always returns to the first page.  
