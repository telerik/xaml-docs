---
title: Source and Paged Source
page_title: Source and Paged Source
description: Source and Paged Source
slug: raddatapager-features-source-and-paged-source
tags: source,and,paged,source
published: True
position: 5
---

# Source and Paged Source

The most important property of the __RadDataPager__ is its __Source__ property. This is where you pass in your collection of data for paging.

More often your collection __will not be__ an [IPagedCollectionView](http://msdn.microsoft.com/en-us/library/system.componentmodel.ipagedcollectionview%28VS.95%29.aspx). It will either be a simple [List<T>](http://msdn.microsoft.com/en-us/library/6sh2ey19.aspx), or an [ObservableCollection<T>](http://msdn.microsoft.com/en-us/library/ms668604.aspx), or anything that is simply an [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx). Unless you had paging in mind when you designed your project, it is almost certain that your data source will not be pageable out of the box. From here on you have two options:

* [Wrap your collection in an __IPagedCollectionView__ / __QueryableCollectionView__](#Wrapping_a_collection_in_an_IPagedCollectionViewQueryableCollectionView)

* [Bind to the __PagedSource__ property of the __RadDataPager__](#Binding_to_the_PagedSource_property_of_the_RadDataPager)

## Wrapping a collection in an IPagedCollectionView / QueryableCollectionView

![](images/RadDataPager_Features_SourceAndPagedSource_01.png)

If you look at the constructors of [PagedCollectionView](http://msdn.microsoft.com/en-us/library/system.windows.data.pagedcollectionview%28VS.95%29.aspx) and {% if site.site_name == 'Silverlight' %}[QueryableCollectionView](http://www.telerik.com/help/silverlight/t_telerik_windows_data_queryablecollectionview.html){% endif %}{% if site.site_name == 'WPF' %}[QueryableCollectionView](http://www.telerik.com/help/wpf/t_telerik_windows_data_queryablecollectionview.html){% endif %} you will notice that you can pass in a simple [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) as a parameter. Those two classes will wrap it and provide paging capabilities over your original data.

Imagine that you have a simple [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) which is the source for an [ItemsControl](http://msdn.microsoft.com/en-us/library/system.windows.controls.itemscontrol.aspx). __Example 1__ shows how to wrap it in order to enable paging with __RadDataPager__.

#### __[C#]Example 1: Apply PagedCollectionView wrapper over IEnumerable collection:__
{{region raddatapager-features-source-and-paged-source_0}}

	IEnumerable itemsSource = Enumerable.Range(0, 1000);
	var pagedSource = new PagedCollectionView(itemsSource);
	this.radDataPager.Source = pagedSource;
	this.itemsControl.ItemsSource = pagedSource;
{{endregion}}

#### __[VB.NET]Example 1: Apply PagedCollectionView wrapper over IEnumerable collection:__
{{region raddatapager-features-source-and-paged-source_1}}

	Dim itemsSource As IEnumerable = Enumerable.Range(0, 1000)
	Dim pagedSource = New PagedCollectionView(itemsSource)
	Me.radDataPager.Source = pagedSource
	Me.itemsControl.ItemsSource = pagedSource
{{endregion}}

#### __[C#]Example 2: Apply QueryableCollectionView wrapper over IEnumerable collection:__
{{region raddatapager-features-source-and-paged-source_2}}

	IEnumerable itemsSource = Enumerable.Range(0, 1000);
	var pagedSource = new QueryableCollectionView(itemsSource);
	this.radDataPager.Source = pagedSource;
	this.itemsControl.ItemsSource = pagedSource;
{{endregion}}

#### __[VB.NET]Example 2: Apply QueryableCollectionView wrapper over IEnumerable collection:__
{{region raddatapager-features-source-and-paged-source_3}}

	Dim itemsSource As IEnumerable = Enumerable.Range(0, 1000)
	Dim pagedSource = New QueryableCollectionView(itemsSource)
	Me.radDataPager.Source = pagedSource
	Me.itemsControl.ItemsSource = pagedSource
{{endregion}}


>The __QueryableCollectionView__ class is defined in the __Telerik.Windows.Data__ namespace so make sure to include it in your page (via the __Using__ or __Import__ statements).

#### __[XAML]Example 3: Definition of RadDataPager__
{{region raddatapager-features-source-and-paged-source_4}}

	<ListBox Name="itemsControl"/>
	<telerikGrid:RadDataPager Name="radDataPager"
	                          PageSize="10"
	                          DisplayMode="All"/>
{{endregion}}


## Binding to the PagedSource property of RadDataPager

![](images/RadDataPager_Features_SourceAndPagedSource_02.png)

In case you do not like the first approach there is a better one. When you assign an [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) as the __Source__ of a [RadDataPager](http://www.telerik.com/help/silverlight/radgridview-paging-using-telerik-raddatapager.html) it will automatically wrap it in a {% if site.site_name == 'Silverlight' %}[QueryableCollectionView](http://www.telerik.com/help/silverlight/t_telerik_windows_data_queryablecollectionview.html){% endif %}{% if site.site_name == 'WPF' %}[QueryableCollectionView](http://www.telerik.com/help/wpf/t_telerik_windows_data_queryablecollectionview.html){% endif %} and expose it through its __PagedSource__ property. From then on, you can attach any number of __ItemsControls__ to the __PagedSource__ and they will be automatically paged. Here is how to do this entirely in XAML. 

#### __[XAML]Example 4: Binding to the PagedSource property of RadDataPager__
{{region raddatapager-features-source-and-paged-source_5}}

	<ListBox Name="itemsControl"
	         ItemsSource="{Binding PagedSource, ElementName=radDataPager}"/>
	<telerikGrid:RadDataPager Name="radDataPager"
	               Source="{Binding myItemsSource}"
	               PageSize="10"
	               DisplayMode="All"/>
{{endregion}}


# See Also

 * [Infinite Paging]({%slug raddatapager-features-infinite-paging%})

 * [Paging Essentials]({%slug raddapager-features-paging-essentials%})

 * [Unbound Mode]({%slug raddatapager-features-unbound-mode%})
