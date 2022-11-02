---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadEntityFrameworkCoreDataSource {{ site.framework_name }} control.
slug: entityframeworkcore-overview
tags: overview
published: True
position: 0
CTAControlName: RadEntityFrameworkCoreDataSource
---

# Overview

__RadEntityFrameworkCoreDataSource__ is a WPF data control that provides seamless integration between an user interface and data coming from [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).  __RadEntityFrameworkCoreDataSource__ generates [LINQ to Entities](http://msdn.microsoft.com/en-us/library/bb399367.aspx) queries to retrieve data from a [DbContext](https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext). The control can also perform basic CRUD operations on the database entities. __The QueryableEntityCoreCollectionView<T>__ class, which is internally used by the control is made publicly available for use in view models part of an MVVM architecture. Thanks to the fact that all controls are part of the Telerik family, __RadEntityFrameworkCoreDataSource__ can codelessly integrate with __RadGridView__, __RadDataPager__ and __RadDataFilter__ to perform paging, filtering, sorting and grouping directly on the database server. __RadEntityFrameworkCoreDataSource__ can also be used as a standalone data source control since it provides the public API needed for loading, shaping and editing data.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

## Key Features 

* __Codeless approach__: Integration with __RadGridView__, __RadDataPager__ and __RadDataFilter__. All of the controls share the same data engine logic and when data-bound together they are able to detect each other automatically and start exchanging information. Linking __RadGridView__, __RadDataPager__ and __RadDataFilter__ to a __RadEntityFrameworkCoreDataSource__  is as easy as binding them to its __DataView__ property. All operations such as paging, filtering, sorting, and grouping will automatically happen on the server without a single line of code.
            

* __Filtering__: It can easily be performed through the __FilterDescriptors__ collection of the control. You can populate this collection or leave it to controls such as __RadGridView__ or __RadDataFilter__ which will automatically translate their filtering criteria and apply it to __RadEntityFrameworkCoreDataSource__ without a single line of code.
            

* __Sorting__: It can easily be performed through the __SortDescriptors__ collection of the control. You can populate this collection or leave it to __RadGridView__ which will automatically translate its sorting criteria and apply it to __RadEntityFrameworkCoreDataSource__ without a single line of code.
          

* __Grouping__: It can easily be performed through the __GroupDescriptors__ collection of the control. You can populate this collection or leave it to __RadGridView__ which will automatically translate its grouping criteria and apply it to __RadEntityFrameworkCoreDataSource__ without a single line of code.
         

* __Paging__: It can easily be performed through the paging API that the __DataView__ of control provides. You can use the methods from the __MoveTo*Page__ family and properties such as __PageIndex__ and __PageSize__. Alternatively it can be left to __RadDataPager__ which will automatically page on the server when bound to the __DataView__ of the control.
          

* __Editing__: It is as simple as adding, removing or editing entities in the __DataView__ of the control and then calling the __SubmitChanges__ methods. These operations can also be left to __RadGridView__ which will automatically transfer them to the __RadEntityFrameworkCoreDataSource__.
          

* __MVVM support__: Provided by the __public QueryableEntityCoreCollectionView<T>__ class, which is the view that __RadEntityFrameworkCoreDataSource__ internally uses. The __RadEntityFrameworkCoreDataSource__ control is simply a thin-wrapper over this collection view, which performs all of the heavy lifting. This allows you to use it inside your view models without losing any functionality that the control would otherwise provide.

> Get started with the control with its [Getting Started]({%slug entityframeworkcore-getting-started%}) help article that shows how to use it in a basic scenario.