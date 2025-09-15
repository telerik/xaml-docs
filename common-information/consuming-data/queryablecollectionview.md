---
title: QueryableCollectionView
page_title: QueryableCollectionView
description: 
slug: consuming-data-queryablecollectionview
tags: queryablecollectionview,queryablecollectionviewsource,filtering,sorting,grouping,linq,expression
published: True
position: 14
---

# QueryableCollectionView

`QueryableCollectionView` enables а collection to have the functionalities of sorting, filtering, grouping, and paging. 

This article descibes the features and provides examples on the QueryableCollectionView (QCV) usage.

The QCV requires an `IEnumerable` source for the data and it works with three major properties to enable sorting, filtering and grouping. The `GroupDescriptors`, `FilterDescriptors`, and `SortDescriptors`. For paging, check the [Paging]({%slug consuming-data-queryablecollectionview%}#paging) section of this article.

## Defining and Using QueryableCollectionView

The following example shows a basic QueryableCollectionView definintion without any sorting, filtering, grouping or paging applied.

__Defining a collection item model__
```C#
	public class DataInfo
    {
        public int Value { get; set; }
        public string GroupKey { get; set; }
    }
```  

__Defining QueryableCollectionView and populating it with data__
```C#
	public MainWindow()
	{	  
		InitializeComponent();
		var source = new ObservableCollection<DataInfo>();
		for (int i = 0; i < 3; i++)
		{
			for (int k = 0; k < 3; k++)
			{
				source.Add(new DataInfo() { Value = k, GroupKey = "G" + i });
			}
		}
		var qcv = new QueryableCollectionView(source);
		this.DataContext = qcv;
	}
```  

__Defining RadGridView and consuming the collection view__
```XAML
	<telerik:RadGridView ItemsSource="{Binding}"/>
```  

__RadGridView populate with QueryableCollectionView__

![{{ site.framework_name }} RadGridView populate with QueryableCollectionView](images/consuming-data-queryablecollectionview-0.png)

## Sorting

The `SortDescriptors` collection of the view allows you to define a set of [SortDescriptor](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.sortdescriptor) objects. The SortDescriptor class provides `Member` and `SortDirection` properties that are used to define the property name being used as the sorting criteria and the sort direction (ascending or descending).

__Defining a SortDescriptor__
```C#
	var qcv = new QueryableCollectionView(source);
	qcv.SortDescriptors.Add(new SortDescriptor() { Member = "Value", SortDirection = ListSortDirection.Descending });            
```  

__RadGridView sorted with QueryableCollectionView SortDescriptors__

![{{ site.framework_name }} RadGridView sorted with QueryableCollectionView SortDescriptors](images/consuming-data-queryablecollectionview-1.png)

Generic sorting is supported too, using the `SortDescriptor<TElement, TKey>` class. 

__Using generic sort descriptor__
```C#
	var qcv = new QueryableCollectionView(source);
	qcv.SortDescriptors.Add(new SortDescriptor<DataInfo, int>() 
	{
		SortingExpression = info => info.Value,
		SortDirection = ListSortDirection.Descending 
	});
```

## Filtering

The `FilterDescriptors` collection of the view allows you to define a set of [FilterDescriptor](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.filterdescriptor) objects. The FilterDescriptor class provides `Member`, `Operator`, and `Value` properties that are used to define the filtering criteria.

__Defining a FilterDescriptor__
```C#
	var qcv = new QueryableCollectionView(source);
	qcv.FilterDescriptors.Add(new FilterDescriptor()
	{
		Member = "Value",
		Operator = FilterOperator.IsLessThanOrEqualTo,
		Value = 1
	});
```  

__RadGridView filtered with QueryableCollectionView FilterDescriptors__

![{{ site.framework_name }} RadGridView filtered with QueryableCollectionView FilterDescriptors](images/consuming-data-queryablecollectionview-2.png)

Generic filtering is supported too, using the `FilterDescriptor<Element>` class. 

__Using generic filter descriptor__
```C#
	var qcv = new QueryableCollectionView(source);
	qcv.FilterDescriptors.Add(new FilterDescriptor<DataInfo>()
	{
		FilteringExpression = info => info.Value <= 1
	});
```  

## Grouping  

The `GroupDescriptors` collection of the view allows you to define a set of [GroupDescriptor](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.groupdescriptor) objects. The GroupDescriptor class provides `Member` and `SortDirection` properties that are used to define the property name being used as the grouping criteria and the sort direction of the groups (ascending or descending).

__Defining a GroupDescriptor__
```C#
	var qcv = new QueryableCollectionView(source);
	qcv.GroupDescriptors.Add(new GroupDescriptor()
	{
		Member = "GroupKey",
		SortDirection = ListSortDirection.Descending
	});
```  

__RadGridView grouped with QueryableCollectionView GroupDescriptors__

![{{ site.framework_name }} RadGridView grouped with QueryableCollectionView GroupDescriptors](images/consuming-data-queryablecollectionview-3.png)

Generic grouping is supported too, using the `GroupDescriptor<TElement, TKey, TSortingKey>` class. 

__Using generic group descriptor__
```C#
	var qcv = new QueryableCollectionView(source);
	qcv.GroupDescriptors.Add(new GroupDescriptor<DataInfo, string, string>()
	{
		GroupingExpression = info => info.GroupKey,
		SortDirection = ListSortDirection.Descending
	});
```

## Paging

The QueryableCollectionView class provides an out-of-the-box ability to apply paging.

To make full use of the paging functionality, you can utilize the following API:

* `PageSize`&mdash;Specifies the number of items to display on a page.
* `PageIndex`&mdash;This property retrieves the index of the current page.
* `IsPageChanging`&mdash;Property of type __bool_ that indicates if a page index change is in process.
* `CanChangePage`&mdash;Specifies if the PageIndex value can change.
* `IsPaged`&mdash;This property indicates whether paging is applied to the QueryableCollectionView instance.
* `ShouldRefreshOrDeferOnPageSizeChange`&mdash;Indicates whether this instance should call the `RefreshOrDefer` method when the PageSize property changes. Its default value of __true__. This is a virtual property, which means that you can override it and set it to __false__ in a new class that derives from QueryableCollectionView. Then, you can work with this new custom QueryableCollectionView collection.

The QueryableCollectionView exposes the following two events when it comes to the paging functionality:

* `PageChanging`&mdash;This event occurs when the PageIndex property is changing. The event arguments are of the type `PageChangingEventArgs`, which provides information about the new page index. PageChangingEventArgs derives from the `CancelEventArgs` class and allows you to cancel the changing of the page index. To do so, set the `Cancel` property to __true__ in the added handler for the PageChanging event.
* `PageChanged`&mdash;This event will occur when the PageIndex property is changed. The event arguments are of the type `EventArgs`.

QueryableCollectionView provides several methods for moving through the pages. These methods target the general functionality that a paging API should have, which is moving to the first/last and to the next/previous page. This is achieved by utilizing the following methods:

* `MoveToFirstPage`&mdash;Sets the first page as the current one. Returns a __bool__ value that indicates if this operation was successful or not.
* `MoveToLastPage`&mdash;Sets the last page as the current one. Returns a __bool__ value that indicates if this operation was successful or not.
* `MoveToNextPage`&mdash;Sets the next page as the current one. Returns a __bool__ value that indicates if this operation was successful or not.
* `MoveToPreviousPage`&mdash;Sets the previous page as the current one. Returns a __bool__ value that indicates if this operation was successful or not.

## Using QueryableCollectionView in XAML 

`QueryableCollectionViewSource` is an abstraction of QueryableCollectionView that internally uses it. It allows you to take advantage of QueryableCollectionView and its features in XAML.

QueryableCollectionViewSource can be defined as a resource in XAML and allows you to provide it with a collection using its `Source` property. If the Source is an object of type QueryableCollectionView, the QueryableCollectionViewSource sync its descriptors directly with it. If the Source is another collection type, it is wrapped into a QueryableCollectionView which is used by the view source internally.

QueryableCollectionViewSource provides the same descriptor collections like QueryableCollectionView&mdash;`GroupDescriptors`, `SortDescriptors`, and `FilterDescriptors`. To access the underlying QueryableCollectionView object use the `View` property of the view source.

The following example shows how to setup basic view model and use QueryableCollectionViewSource with RadGridView.

__Defining the view model__
```C#
	public class MainViewModel
    {
        public ObservableCollection<DataInfo> Items { get; set; }
        public MainViewModel()
        {
            Items = new ObservableCollection<DataInfo>();
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Items.Add(new DataInfo() { Value = k, GroupKey = "G" + i  });
                }
            }
        }
    }
```  

See the first example from the beginning of this article for the definition of the __DataInfo__ class.

__Defining QueryableCollectionViewSource in XAML__
```XAML
	<Window.Resources>
        <local:MainViewModel x:Key="viewModel" />
        <telerik:QueryableCollectionViewSource x:Key="qcvSource" Source="{Binding Source={StaticResource viewModel}, Path=Items}"/>
    </Window.Resources>
```  

__Consuming the QueryableCollectionViewSource's view in XAML__
```XAML
	<telerik:RadGridView ItemsSource="{Binding Source={StaticResource qcvSource}, Path=View}" />
```  

To use grouping, sorting, and filtering set the corresponding descriptors of the view source object.

__Adding descriptors in XAML__
```XAML
	<Window.Resources>
        <local:MainViewModel x:Key="viewModel" />
        <telerik:QueryableCollectionViewSource x:Key="qcvSource" Source="{Binding Source={StaticResource viewModel}, Path=Items}">
            <telerik:QueryableCollectionViewSource.SortDescriptors>
                <telerik:SortDescriptor Member="Value" SortDirection="Descending" />
            </telerik:QueryableCollectionViewSource.SortDescriptors>
            <telerik:QueryableCollectionViewSource.GroupDescriptors>
                <telerik:GroupDescriptor Member="GroupKey" SortDirection="Descending" />
            </telerik:QueryableCollectionViewSource.GroupDescriptors>
            <telerik:QueryableCollectionViewSource.FilterDescriptors>
                <telerik:FilterDescriptor Member="Value" Operator="IsLessThanOrEqualTo" Value="1"/>
            </telerik:QueryableCollectionViewSource.FilterDescriptors>
        </telerik:QueryableCollectionViewSource>
    </Window.Resources>
``` 

__RadGridView populated using QueryableCollectionViewSource__

![{{ site.framework_name }} RadGridView populated using QueryableCollectionViewSource](images/consuming-data-queryablecollectionview-4.png)

## See Also
* [Consuming Data Overview]({%slug consuming-data-overview%})
* [In-Memory Data]({%slug consuming-data-in-memory-data%})