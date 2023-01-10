---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadEntityFrameworkDataSource {{ site.framework_name }} control.
slug: entityframework-overview
tags: overview
published: True
position: 0
CTAControlName: RadEntityFrameworkDataSource
---

# {{ site.framework_name }} RadEntityFrameworkDataSource Overview

__RadEntityFrameworkDataSource__ is a WPF data control that provides seamless integration between an user interface and data coming from an [Entity Framework](http://msdn.microsoft.com/en-us/library/bb399572.aspx)  Container.  __RadEntityFrameworkDataSource__ generates [LINQ to Entities](http://msdn.microsoft.com/en-us/library/bb399367.aspx) queries to retrieve data from an [ObjectContext](http://msdn.microsoft.com/en-us/library/system.data.objects.objectcontext.aspx) based on an [ObjectQuery<T>](http://msdn.microsoft.com/en-us/library/bb345303.aspx). The control can also perform basic CRUD operations on entities located in the container. You can retrieve, shape and edit data using declarative XAML syntax only. __RadEntityFrameworkDataSource__ provides extensive code-behind API for more advanced scenarios.  __The QueryableEntityCollectionView<T>__ class, which is internally used by the control, is made publicly available for use in view models part of an MVVM architecture, where the usage of UI elements is not recommended. Thanks to the fact that all controls are part of the Telerik family, __RadEntityFrameworkDataSource__ can codelessly integrate with __RadGridView__, __RadDataPager__ and __RadDataFilter__ and perform paging, filtering, sorting, and grouping directly on the database server. __RadEntityFrameworkDataSource__ can also be used as a standalone data source control since it provides the public API needed for loading, shaping and editing data.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

 ![REFDS](images/RadEntityFramework_REFDS.jpg)

## Features 

* __Codeless approach__ integration with __RadGridView__, __RadDataPager__ and __RadDataFilter__ - Since all of the controls share the same data engine logic, when data-bound together they are able to detect each other automatically and start exchanging information. Linking __RadGridView__, __RadDataPager__ and __RadDataFilter__ to a __RadEntityFrameworkDataSource__  is as easy as binding them to its __DataView__ property. All operations such as paging, filtering, sorting, and grouping will automatically happen on the server without a single line of code.
            

* __Filtering__ - it can easily be performed through the __FilterDescriptors__ collection of the control. This can either be done manually by the developer through editing the collection in code-behind or it can be left to controls such as __RadGridView__ or __RadDataFilter__ which will automatically translate their filtering criteria and apply it to __RadEntityFrameworkDataSource__ without a single line of code.
            

* __Sorting__ - it can easily be performed through the __SortDescriptors__ collection of the control. This can either be done manually by the developer through editing the collection in code-behind or it can be left to __RadGridView__ which will automatically translate its sorting criteria and apply it to __RadEntityFrameworkDataSource__ without a single line of code.
          

* __Grouping__ - it can easily be performed through the __GroupDescriptors__ collection of the control. This can either be done manually by the developer through editing the collection in code-behind or it can be left to __RadGridView__ which will automatically translate its grouping criteria and apply it to __RadEntityFrameworkDataSource__ without a single line of code.
         

* __Paging__ - it can easily be performed through the paging API that the __DataView__ of control provides. It can be done manually by the developer through methods from the __MoveTo*Page__ family and properties such as __PageIndex__ and __PageSize__. Or it can be left entirely to __RadDataPager__ which will automatically page on the server when bound to the __DataView__ of the control.
          

* __Editing__ - it is as simple as adding, removing or editing entities in the __DataView__ of the control and then calling the __SubmitChanges__ methods These operations can also be left to __RadGridView__ which will automatically transfer them to the __RadEntityFrameworkDataSource__.
          

* __MVVM support__ - is provided by the __public QueryableEntityCollectionView<T>__ class, which is the view that __RadEntityFrameworkDataSource__ internally uses. The __RadEntityFrameworkDataSource__ control is simply a thin-wrapper over this collection view, which performs all of the heavy lifting. This allows you to use it inside your view models without losing any functionality that the control would otherwise provide.
          
