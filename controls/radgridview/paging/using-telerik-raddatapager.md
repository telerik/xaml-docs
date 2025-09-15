---
title: Using Telerik RadDataPager
page_title: Using Telerik RadDataPager
description: Learn how you can page the data of Telerik's {{ site.framework_name }} DataGrid through the integration with RadDataPager that provides plenty of features.
slug: radgridview-paging-using-telerik-raddatapager
tags: using,telerik,raddatapager
published: True
position: 0
---

# Using Telerik RadDataPager

>__RadDataPager is NOT dependent on the RadGridView, so it can be freely used together with any other ItemsControl.__

You can page the data of your __RadGridView__ via the Telerik __RadDataPager__. It provides a lot of features, so you can easily configure and manage the paging of the data. This topic will make you familiar with the following:

* [RadDataPager's Features](#raddatapagers-features)

* [Integrating RadDataPager with RadGridView](#integrating-raddatapager-with-radgridview)

* [Using RadDataPager together with DomainDataSource](#using-raddatapager-together-with-domaindatasource)

## RadDataPager's Features

Here is a list of the most important features of the __RadDataPager__:

* __Binding to IEnumerable__ - the __RadDataPager__ can bind to any collection that implements the __IEnumerable__ interface, which means that it can page any collection. The __RadDataPager__ wraps the collection internally in an __IPagedCollectionView__ and exposes it through its __PagedSource__ property. In order to page a collection you have to pass it to the __Source__ property of the __RadDataPager__.

#### __XAML__

```XAML
	<telerik:RadDataPager Source="{Binding MyCollection}" />
```

#### __C#__

```C#
	IEnumerable data = new List<int>() { 1, 2, 3 };
	RadDataPager radDataPager = new RadDataPager();
	radDataPager.Source = data;
```

#### __VB.NET__

```VB.NET
	Dim data As IEnumerable = New List(Of Integer)()
	Dim radDataPager As New RadDataPager()
	radDataPager.Source = data
```

* __WCF RIA Services and DomainDataSource Support__ - the __RadDataPager__ can be easily integrated with the __DomainDataSource__ control and consume server data through the __.NET RIA Services__.

* __Telerik LINQ-based Data Engine__ - the __RadDataPager__ uses the engine in order to achieve a server-side paging, when using web services.

* __Programmatic Paging__ - the developer is allowed to implement the paging programmatically, thanks to the API exposed by the __RadDataPager__.

* __MoveToFirstPage()__ - sets the __RadDataPager__ to its first page.

* __MoveToLastPage()__ - sets the __RadDataPager__ to its last page.

* __MoveToNextPage()__ - sets the __RadDataPager__ to the next page.

* __MoveToPage( int pageIndex )__ - sets the __RadDataPager__ to a specific page.

* __MoveToPreviousPage()__ - sets the __RadDataPager__ to the previous page.

* __CanChangePage__ - indicates whether paging is enabled.

* __CanMoveToFirstPage__ - indicates whether the user can move to the first page.

* __CanMoveToLasPage__ - indicates whether the user can move to the last page.

* __CanMoveToNextPage__ - indicates whether the user can move to the next page.

* __CanMoveToPreviousPage__ - indicates whether the user can move to the previous page.

* __Fixed Page Count__- you are able to specify whether the count of the pages is fixed or not by setting the __IsTotalItemCountFixed__ property. Its default value is __False__, which makes the paging endless. This means that the __NextPage__ button will not be disabled when the pager goes to its last page. This is useful when having a dynamic collection of items and their count changes. If you know that items won't be added or removed from the collection, you can set the __IsTotalItemCountFixed__ to __True__ and have a fixed page count.

* __AutoEllipsis Modes__ - The AutoEllipsis appears when the __PageCount__ is greater than the __NumericButtonCount__. You can specify where the AutoEllipsis is allowed to appear by setting the __AutoEllipsisMode__ to one of the following values:

* __After__ - displays AutoEllipsis only after the Numeric Buttons.

* __Before__ - displays AutoEllipsis only before the Numeric Buttons.

* __Both__ - displays AutoEllipsis before and after the Numeric Buttons.

* __None__ - doesn't display AutoEllipsis.

* __Display Modes__ - by setting the __DisplayMode__ property you can specify which of the Pager Buttons and Visuals to be visible.

## Integrating RadDataPager with RadGridView

See this [article]({%slug raddatapager-getting-started%}) for more information.

## Using RadDataPager together with DomainDataSource

__RadDataPager__ can be used together with __DomainDataSource__ provided by the __WCF RIA Services__. Here is an example of __RadGridView__ and __RadDataPager__ bound to __DomainDataSource__.

#### __XAML__

```XAML
	<StackPanel>
	    <riaControls:DomainDataSource x:Name="domainDataSource"
	          AutoLoad="True"
	          QueryName="GetCustomers"
	          PageSize="10">
	        <riaControls:DomainDataSource.DomainContext>
	            <local:NorthwindDomainContext />
	        </riaControls:DomainDataSource.DomainContext>
	    </riaControls:DomainDataSource>
	    <telerik:RadGridView x:Name="radGridView"
	 ItemsSource="{Binding Data, ElementName=domainDataSource}"
	 IsBusy="{Binding IsBusy, ElementName=DomainDataSource1}" />
	    <telerik:RadDataPager x:Name="radDataPager"
	  Source="{Binding Data, ElementName=domainDataSource}"
	  DisplayMode="FirstLastPreviousNextNumeric, Text"
	  IsTotalItemCountFixed="True" />
	</StackPanel>
```

## See Also

 * [Basic Sorting]({%slug gridview-sorting-basics%})

 * [Basic Grouping]({%slug gridview-grouping-basics%})

 * [Basic Filtering]({%slug gridview-filtering-basic%})

 * [Basic Selection]({%slug gridview-selection-basics%})
{% if site.site_name == 'Silverlight' %}
 * [Using Silverlight DataPager]({%slug gridview-paging-using-silverlight-datapager%})
{% endif %}
