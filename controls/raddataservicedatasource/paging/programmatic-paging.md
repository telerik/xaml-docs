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

Programmatic paging could be done with the help of the public paging API that RadDataServiceDataSource.DataView provides. The DataView property implements the IPagedCollectionView interface which contains all paging methods and properties. When a page change is requested, a trip to the server will be made regardless of the AutoLoad setting. When filtering, sorting or grouping occurs, a trip to the server is made, the DataView is re-created and always returns to the first page.  
