---
title: Grouping
page_title: Grouping
description: Grouping
slug: raddataservicedatasource-grouping
tags: grouping
publish: True
position: 0
---

# Grouping



## 

WCF Data Services do not support grouping. For consistency reasons, grouping criteria is simply converted to sorting criteria by RadDataServiceDataSource. 

So for example, if you group by country, you will still get a flat list of all cities, but they will be ordered according to their country. If you group a RadGridView that is bound to a RadDataServiceDataSource, RadDataServiceDataSource will order the data on the server and bring it back, but the actual grouping will be performed by RadGridView on the client. 
