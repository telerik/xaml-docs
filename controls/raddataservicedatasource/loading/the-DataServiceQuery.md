---
title: The DataServiceQuery
page_title: The DataServiceQuery
description: The DataServiceQuery
slug: raddataservicedatasource-loading-the-dataservicequery
tags: the,dataservicequery
published: True
position: 1
---

# The DataServiceQuery



## 

Along with the context, you need to specify the name of the query that will be executed on the server. If you examine the generated data service context class, you will notice that it has properties of type DataServiceQuery<T>. You need to specify the name of the property that you would like to load. The name of the query is specified as a string for easier XAML use. RadDataServiceDataSource will use reflection to find the actual DataServiceQuery<T> on the DataServiceContext instance based on the __QueryName__ property you have assigned, which in this case is __Customers__:

#### __XAML__

{{region raddataservicedatasource-loading-the-DataServiceQuery_0}}
	<telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	   <telerik:RadDataServiceDataSource.DataServiceContext>
	      <local:MyNorthwindContext/>
	   </telerik:RadDataServiceDataSource.DataServiceContext>
	</telerik:RadDataServiceDataSource>
	{{endregion}}


