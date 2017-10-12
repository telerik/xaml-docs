---
title: Overview
page_title: Overview
description: Overview
slug: dds-overview
tags: overview
published: True
position: 0
---

# Overview


![](images/RadDomainDataSource.png)


Telerik provides __RadDomainDataSource__ similar to the Microsoft __DomainDataSource__ control to simplify the interaction between the user interface and data from a domain context. With the __DomainDataSource__, you can retrieve, shape, and edit data using only declarative syntax. You specify the domain context to use with the __DomainDataSource__, and then call the operations that are available through that domain context. __RadDomainDataSource__ tightly integrates with __RadGridView__, __RadDataFilter__, __RadDataPager__, etc and performs filtering, paging and sorting on the server.

## Features 

* __Codeless approach__ to data-binding that supports most common data operations without the need for any custom code. Without RadDomainDataSource you would have to write hundreds of lines of code in order to support server side filtering. Yes sorting and paging were happening on the server automatically, but who needs them without the power of the built-in Excel like filtering of __RadGridView__. __RadDomainDataSource__ gives you a seamless integration between your data and our data oriented components like: __RadDataFilter__, __RadDataPager__ or __RadGridView__

* __Filtering__ - The __RadDomainDataSource__ control provides the __FilterDescriptors__ collection to enable you to filter the data that is returned by the query. By adding filters, you can specify that only entities which meet the condition in the filter are loaded from the domain context. Unlike the __MS DomainDataSource__, __RadDomainDataSource__ supports __nesting of filter descriptors__ to unlimited depth allowing you to compose complex filter conditions. Adding a filter on the client (clicking some distinct value in the __RadGridView__ filtering control UI) will automatically transfer this filter on the server, i.e. add it to the __FilterDescriptors__ collection of the __RadDomainDataSource__. This is possible due to the fact that the two underlying views of the two controls detect each other and start synchronizing with each other, i.e. when you add a __FilterDescriptors__ to the grid it is automatically added to the domain data source.

* Fine grained __query parameter control__ – We expose a __PreparedParameterValue__ event which provides a way for you to change each parameter or handle a possible exception before the entity query is sent to the server. This opens the door for handling any custom query scenario that you might have. 

* __MVVM friendly__ - We are exposing the heart of the control named – __QueryableDomainServiceCollectionView__ as public class that you can start using in your ViewModels right away. You can learn the details [here](http://blogs.telerik.com/blogs/posts/10-12-31/an_mvvm_approach_to_telerik_domain_services_for_silverlight.aspx)

* __Sorting__ - The __RadDomainDataSource__ provides the __SortDescriptors__ collection to facilitate sorting on the data. In the __SortDescriptors__ collection, you add __SortDescriptor__ instances that describe the values to use for sorting the collection. You can add as many __SortDescriptor__ instances as you want to provide layers of sorting. You can specify if the data is sorted in ascending or descending order.

* __Paging__ - When displaying a large number of entities, you may wish to provide paging in your user interface. The __RadDomainDataSource__ control enables you to specify the number of entities to load and the number of entities to display on a page. New records are loaded only when the user navigates to a page that contains entities which have not been loaded. You set the __PageSize__ and __LoadSize__ properties to specify the parameters for paging. Then, you bind a __RadDataPager__ instance to the __RadDomainDataSource__ to implement the interface for paging.

* __Editing__ - To persist data modifications, call the __SubmitChanges__ method on the __RadDomainDataSource__ object. To cancel changes, call the __RejectChanges__ method.


## Before you begin

* [Introduction to RadDomainDataSource for Silverlight](http://blogs.telerik.com/rossenhristov/posts/10-12-24/introducing_raddomaindatasource_for_silverlight.aspx)

* [Loading data with RadDomainDataSource for Silverlight](http://blogs.telerik.com/rossenhristov/posts/10-12-27/loading_data_with_raddomaindatasource_for_silverlight.aspx)

* [An MVVM Approach to Telerik Domain Services for Silverlight](http://blogs.telerik.com/rossenhristov/posts/10-12-31/an_mvvm_approach_to_telerik_domain_services_for_silverlight.aspx)

* [Creating CRUD application with RadDomainDataSource for Silverlight](http://blogs.telerik.com/silverlightteam/posts/10-12-28/creating-crud-application-with-raddomaindatasource-for-silverlight.aspx)

* [Why we have built RadDomainDataSource for Silverlight?](http://blogs.telerik.com/stefandobrev/posts/11-01-03/why_we_have_built_raddomaindatasource_for_silverlight.aspx)



## See Also
[First Look](https://demos.telerik.com/silverlight/#DomainDataSource/FirstLook)

[Master Detail](https://demos.telerik.com/silverlight/#DomainDataSource/MasterDetail)

[MVVM](https://demos.telerik.com/silverlight/#DomainDataSource/MVVM)

[Query Parameters](https://demos.telerik.com/silverlight/#DomainDataSource/QueryParameters)

[Row Details](https://demos.telerik.com/silverlight/#DomainDataSource/RowDetails)

[Distinct Values](https://demos.telerik.com/silverlight/#DomainDataSource/DistinctValues)

[RadDataFilter Integration](https://demos.telerik.com/silverlight/#DomainDataSource/RadDataFilterIntegration)

[Load Delay](https://demos.telerik.com/silverlight/#DomainDataSource/LoadDelay)
