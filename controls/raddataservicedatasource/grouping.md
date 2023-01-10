---
title: Grouping
page_title: Grouping
description: Check our &quot;Grouping&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-grouping
tags: grouping
published: True
position: 5
---

# {{ site.framework_name }} RadDataServiceDataSource Grouping

__WCF Data Services__ do not support grouping. For consistency reasons, grouping criteria is simply converted to sorting criteria by __RadDataServiceDataSource__. 

So for example, if you group by country, you will still get a flat list of all cities, but they will be ordered according to their country. If you group a __RadGridView__ that is bound to a __RadDataServiceDataSource__, __RadDataServiceDataSource__ will order the data on the server and bring it back, but the actual grouping will be performed by __RadGridView__ on the client. 
