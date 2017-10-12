---
title: Known Limitations
page_title: Known Limitations
description: Known Limitations
slug: domaindatasource-known-limitations
tags: known,limitations
published: True
position: 7
---

# Known Limitations



## 

1. ___"The maximum uri length of 2,083 characters was exceeded"___ exception is thrown when you filter __RadGridView__. 
Most browsers have a maximum uniform resource locator (URL) length of 2,083 characters. When you filter RadGridView and add a large number of distinct filters - they are added in the URL of the request and when the length is exceeded the exception is thrown.

	__Solution__: Set the __ShowDistinctFilter__ property of the grid column to __False__ to hide the distinct values listbox. The user will have to type in the field filter, i.e. the lower part of the filtering control with the combos.

	Another solution would be to stop the built-in filtering of RadGridView (__IsFilteringAllowed__="__False__") and use __RadDataFilter__ instead.



2. In paged __RadGridView__, ___the distinct values listbox shows the values from the current page only___.
The current version __WCF RIA Services__ do not support projections on the server, i.e. you can't make a ___Select(person=>person.Name).Distinct()___ on the server out-of-the-box. But this can easily be done with an additional query for every __Type__ of column and the help of a simple dummy class called __DistinctValue__. A demo showing the approach can be observed [here](https://demos.telerik.com/silverlight/#DomainDataSource/DistinctValues).

