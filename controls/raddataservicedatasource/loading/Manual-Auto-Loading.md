---
title: Manual vs. Auto Loading
page_title: Manual vs. Auto Loading
description: Manual vs. Auto Loading
slug: raddataservicedatasource-loading-manual-auto-loading
tags: manual,vs.,auto,loading
published: True
position: 2
---

# Manual vs. Auto Loading



## 

You can load data manually by calling the ___RadDataServiceDataSource.Load___ method or you can let the control perform an automatic load when a change affecting the query occurs. If you set the __AutoLoad__ property to ___true___, an automatic load will be initiated each time one of the following happens:

* When a __filter__ descriptor is added, removed or edited in the __FilterDescriptors__ collection of the control.

* When a __sort__ descriptor is added, removed or edited in the __SortDescriptors__ collection of the control.

* When a __group__ descriptor is added, removed or edited in the __GroupDescriptors__ collection of the control.

>__WCF Data Services__ (the __OData__ protocol) do not support true grouping on the server. When you try to group through __RadDataServiceDataSource__, it will simply sort the data on the server based on the grouping criteria and when it arrives, it will group it on the client.

* When the __PageIndex__ changes.



>When the __PageIndex__ changes, a load request will be sent to the server even if the __AutoLoad__ property is ___false___.



>While the control is asynchronously waiting for the server to respond, it is in a loading state (__IsLoading__ is ___true___ and __CanLoad__ is ___false___). Calling the __Load__ method or triggering an __AutoLoad__ while the control is in this state will be ignored and will have absolutely no effect. You need to cancel a pending load with the __CancelLoad__ method before executing a new one.


