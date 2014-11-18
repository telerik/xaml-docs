---
title: MVVM Support
page_title: MVVM Support
description: MVVM Support
slug: raddataservicedatasource-mvvm
tags: mvvm,support
published: True
position: 0
---

# MVVM Support



## 

The assembly in which __RadDataServiceDataSource__ is located contains a class named __QueryableDataServiceCollectionView&lt;T&gt;.__ This is the collection view that the control uses internally. The only functionality that the control adds over this collection view is XAML-friendly API. In case you are strictly following the __MVVM pattern__ and you cannot embed an UI control inside you view model, you should use the __QueryableDataServiceCollectionView&lt;T&gt;__ class. Like __RadDataServiceDataSource__, the __QueryableDataServiceCollectionView&lt;T&gt;__ needs a __DataServiceContext__ and a __DataServiceQuery&lt;T&gt;__ to be constructed. Do not touch the context and the query once you have supplied them in the collection view constructor:

#### __C#__

{{region raddataservicedatasource-mvvm_0}}

	MyNorthwindEntities ordersContext = new MyNorthwindEntities();
	DataServiceQuery<Order> ordersQuery = ordersContext.Orders;
	QueryableDataServiceCollectionView<Order> ordersView = new QueryableDataServiceCollectionView<Order>(this.ordersContext, ordersQuery);
{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-mvvm_1}}

	Dim ordersContext As New MyNorthwindEntities()
	Dim ordersQuery As DataServiceQuery(Of Order) = ordersContext.Orders
	Dim ordersView As New QueryableDataServiceCollectionView(Of Order)(Me.ordersContext, ordersQuery)
{{endregion}}



The __QueryableDataServiceCollectionView&lt;T&gt;__ class has the same API as the __RadDataServiceDataSource__ control so all operations are performed in the same way as with the __RadDataServiceDataSource__ control. In fact, the public API of the __RadDataServiceDataSource__ control simply exposes the public API of its inner collection view, which is the one that really does the job.
