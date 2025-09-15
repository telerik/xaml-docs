---
title: The DataServiceQuery
page_title: The DataServiceQuery
description: Check our &quot;The DataServiceQuery&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-loading-the-dataservicequery
tags: the,dataservicequery
published: True
position: 1
---

# The DataServiceQuery

Along with the context, you need to specify the name of the query that will be executed on the server. If you examine the generated data service context class, you will notice that it has properties of type __DataServiceQuery&lt;T&gt;__. You need to specify the name of the property that you would like to load. The name of the query is specified as a string for easier XAML use. __RadDataServiceDataSource__ will use reflection to find the actual __DataServiceQuery&lt;T&gt;__ on the __DataServiceContext__ instance based on the __QueryName__ property you have assigned, which in this case is __Customers__:

#### __XAML__

```XAML

	<telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	   <telerik:RadDataServiceDataSource.DataServiceContext>
	      <local:MyNorthwindContext/>
	   </telerik:RadDataServiceDataSource.DataServiceContext>
	</telerik:RadDataServiceDataSource>
```