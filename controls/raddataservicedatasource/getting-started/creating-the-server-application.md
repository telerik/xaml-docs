---
title: Creating the Server Application
page_title: Creating the Server Application
description: Creating the Server Application
slug: raddataservicedatasource-getting-started-creating-the-server-application
tags: creating,the,server,application
publish: True
position: 0
---

# Creating the Server Application



The "Getting Started" section will walk you through the creation of a sample application that contains RadGridView and RadDataPager bound to a RadDataServiceDataSource.

## Creating the Server Application{% if site.site_name == 'WPF' %}

__RadDataServiceDataSource__can consume any WCF Data Service. This can be any publicly available [Live OData Service](http://www.odata.org/producers) or a WCF Data Service that your company has already set-up. In case you don’t have a WCF Data Service running, you can follow this [tutorial](http://msdn.microsoft.com/en-us/library/ms731758.aspx) in order to quickly set-up a self-hosted WCF Service. If you prefer your service to be hosted in a Web Application you can follow this [tutorial](http://msdn.microsoft.com/en-us/library/dd465161.aspx).
Creating and configuring WCF Data Services is the beyond the scope of the current tutorial. You can find more information regarding WCF Data Services [here](http://msdn.microsoft.com/en-us/data/bb931106). The [Open Data Protocol](http://www.odata.org/) Home is another great learning resource. This tutorial will use the publicly available OData feed of the popular Northwind database found at [http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc).{% endif %}{% if site.site_name == 'Silverlight' %}

RadDataServiceDataSource can consume any WCF Data Service. This can be any publicly available [Live OData Service](http://www.odata.org/producers) or a WCF Data Service that your company has already set-up. In case you don’t have a WCF Data Service running, you can follow this [tutorial](http://msdn.microsoft.com/en-us/library/cc668184.aspx) in order to quickly set-up one. In case you would like to set up a local service that exposes the Northwind sample database, please follow this [tutorial](http://msdn.microsoft.com/en-us/library/cc838239(v=VS.96).aspx).
Creating and configuring WCF Data Services is the beyond the scope of the current tutorial. You can find more information regarding WCF Data Services [here](http://msdn.microsoft.com/en-us/data/bb931106). The [Open Data Protocol](http://www.odata.org/) Home is another great learning resource. This tutorial will use the publicly available OData feed of the popular Northwind database found at [http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc).{% endif %}

See Also

[Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%})

[Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
