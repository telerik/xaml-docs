---
title: Overview
page_title: Overview
description: Overview
slug: raddataservicedatasource-overview
tags: overview
published: True
position: 0
---

# Overview



{% if site.site_name == 'Silverlight' %}


             
          ![Rad Data Service Data Source SL](images/RadDataServiceDataSource_SL.png){% endif %}{% if site.site_name == 'WPF' %}


             
          ![Rad Data Service Data Source WPF](images/RadDataServiceDataSource_WPF.png){% endif %}

__RadDataServiceDataSource__provides seamless integration between an user interface and data coming from a WCF Data Service. You can retrieve, shape and edit data using declarative XAML syntax only. __RadDataServiceDataSource__provides extensive code-behind API for more advanced scenarios. The QueryableDataServiceCollectionView<T> class, which is internally used by the control, is made publicly available for use in view models part of an MVVM architecture, where the usage of UI elements is not recommended. 
__RadDataServiceDataSource__uses a DataServiceContext and a DataServiceQuery to communicate with the server. Thanks to the fact that all controls are part of the Telerik family, __RadDataServiceDataSource__can codelessly integrate with RadGridView, RadDataPager and RadDataFilter and perform paging, filtering and sorting directly on the server. __RadDataServiceDataSource__can also be used as a standalone data source control since it provides the public API needed for loading, shaping and editing data.






         
      ![](images/RadDataServiceDataSource_Overview.gif)





## Features

* __Codeless__ integration with RadGridView, RadDataPager and RadDataFilter - Since all of the controls share the same data engine logic, when data-bound together they are able to detect each other automatically and start exchanging information. Linking RadGridView, RadDataPager and RadDataFilter to a __RadDataServiceDataSource__ is as easy as binding them to its DataView property. All operations such as paging, filtering and sorting will automatically happen on the server without a single line of code.

* __Filtering__ - it can easily be performed through the FilterDescriptors collection of the control. This can either be done manually by the developer through editing the collection in code-behind or it can be left to controls such as RadGridView or RadDataFilter which will automatically translate their filtering criteria and apply it to __RadDataServiceDataSource__ without a single line of code.

* __Sorting__ - it can easily be performed through the SortDescriptors collection of the control. This can either be done manually by the developer through editing the collection in code-behind or it can be left to RadGridView which will automatically translate its sorting criteria and apply it to RadDataServiceDataSource without a single line of code.

* __Paging__- it can easily be performed through the paging API that the control provides. It can be done manually by the developer through methods from the MoveTo*Page family and properties such as PageIndex and PageSize. Or it can be left entirely to RadDataPager which will automatically page on the server when bound to RadDataServiceDataSource.

* __Editing__ - it is as simple as adding, removing or editing entities in the DataView of the control and then calling the SubmitChanges/RejectChanges methods. These operations can also be left to RadGridView which will automatically transfer them to the RadDataServiceDataSource.

* __MVVM support__ - is provided by the public QueryableDataServiceCollectionView<T> class, which is the view that RadDataServiceDataSource internally uses. The RadDataServiceDataSource control is simply a thin-wrapper over this collection view, which performs all of the heavy lifting. This allows you to use it inside your view models without losing any functionality that the control would otherwise provide.



## Prerequisites

__RadDataServiceDataSource__ is built on top of the {% if site.site_name == 'Silverlight' %}WCF Data Services Client Library for Silverlight{% endif %}{% if site.site_name == 'WPF' %}WCF Data Services Client Library for WPF{% endif %}. Basic WCF Data Services experience is required for working with RadDataServiceDataSource. RadDataServiceDataSource is a client-side technology and does not encompass the server-side branch of WCF Data Services.
If you are using .NET 3.5, you will need to install [ADO.NET Data Services Update for .NET Framework 3.5 SP1](http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=2343)
