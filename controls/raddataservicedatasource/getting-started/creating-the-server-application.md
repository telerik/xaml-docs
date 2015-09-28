---
title: Creating the Server Application
page_title: Creating the Server Application
description: Creating the Server Application
slug: raddataservicedatasource-getting-started-creating-the-server-application
tags: creating,the,server,application
published: True
position: 1
---

# Creating the Server Application



The _"Getting Started"_ section will walk you through the creation of a sample application that contains __RadGridView__ and __RadDataPager__ bound to a __RadDataServiceDataSource__.

## Creating the Server Application{% if site.site_name == 'WPF' %}

__RadDataServiceDataSource__ can consume any __WCF Data Service__. This can be any publicly available [Live OData Service](http://www.odata.org/producers) or a __WCF Data Service__ that your company has already set-up. In case you don’t have a __WCF Data Service__ running, you can follow this [tutorial](http://msdn.microsoft.com/en-us/library/ms731758.aspx) in order to quickly set-up a self-hosted __WCF Service__. If you prefer your service to be hosted in a ___Web Application___ you can follow this [tutorial](http://msdn.microsoft.com/en-us/library/dd465161.aspx).
Creating and configuring __WCF Data Services__ is the beyond the scope of the current tutorial. You can find more information regarding __WCF Data Services__ [here](http://msdn.microsoft.com/en-us/data/bb931106). The [Open Data Protocol](http://www.odata.org/) Home is another great learning resource. This tutorial will use the publicly available __OData feed__ of the popular __Northwind__ database found at [http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc).{% endif %}{% if site.site_name == 'Silverlight' %}

__RadDataServiceDataSource__ can consume any __WCF Data Service__. This can be any publicly available [Live OData Service](http://www.odata.org/producers) or a __WCF Data Service__ that your company has already set-up. In case you don’t have a __WCF Data Service__ running, you can follow this [tutorial](http://msdn.microsoft.com/en-us/library/cc668184.aspx) in order to quickly set-up one. In case you would like to set up a local service that exposes the __Northwind__ sample database, please follow this [tutorial](http://msdn.microsoft.com/en-us/library/cc838239(v=VS.96).aspx).
Creating and configuring __WCF Data Services__ is the beyond the scope of the current tutorial. You can find more information regarding __WCF Data Services__ [here](http://msdn.microsoft.com/en-us/data/bb931106). The [Open Data Protocol](http://www.odata.org/) Home is another great learning resource. This tutorial will use the publicly available __OData feed__ of the popular __Northwind__ database found at [http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc).{% endif %}

#See Also

[Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%})

[Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
