---
title: Manual vs. Auto Loading
page_title: Manual vs. Auto Loading
description: Manual vs. Auto Loading
slug: raddataservicedatasource-loading-manual-auto-loading
tags: manual,vs.,auto,loading
publish: True
position: 2
---

# Manual vs. Auto Loading



## 

You can load data manually by calling the RadDataServiceDataSource.__Load__ method or you can let the control perform an automatic load when a change affecting the query occurs. If you set the __AutoLoad__ property to __true__, an automatic load will be initiated each time one of the following happens:

* When a __filter__ descriptor is added, removed or edited in the __FilterDescriptors__ collection of the control.

* When a __sort__ descriptor is added, removed or edited in the __SortDescriptors__ collection of the control.

* When a __group__ descriptor is added, removed or edited in the __GroupDescriptors__ collection of the control.

>WCF Data Services (the OData protocol) do not support true grouping on the server. When you try to group through RadDataServiceDataSource, it will simply sort the data on the server based on the grouping criteria and when it arrives, it will group it on the client.

* When the __PageIndex__ changes.



>When the PageIndex changes, a load request will be sent to the server even if the AutoLoad property is false.



>While the control is asynchronously waiting for the server to respond, it is in a loading state (IsLoading is true and CanLoad is false). Calling the Load method or triggering an AutoLoad while the control is in this state will be ignored and will have absolutely no effect. You need to cancel a pending load with the CancelLoad method before executing a new one.


