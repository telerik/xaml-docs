---
title: Paging
page_title: Paging
description: Learn about the few simple steps you need to perform in order to connect Telerik's {{ site.framework_name }} DataGrid with a DataPager.
slug: gridview-overview-paging
tags: paging
published: True
position: 4
site_name: Silverlight
---

# Paging

__RadGridView__ offers an excellent integration with Silverlight __DataPager__.


![Telerik {{ site.framework_name }} DataGrid Features Paging 010](images/RadGridView_Features_Paging_010.png)

To connect the __RadGridView__ with a __DataPager__ you need to perform a few simple steps:

* Add __RadGridView__ and __DataPager__ declarations. 

#### __XAML__

{{region xaml-gridview-overview-paging_0}}
	<telerik:RadGridView x:Name="radGridView"/>
	<data:DataPager x:Name="dataPager"/>
{{endregion}}

>Do not forget that in order to create __DataPager__ in the XAML, you first have to declare the following namespace:

#### __XAML__

{{region xaml-gridview-overview-paging_1}}
	  xmlns:data="clr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Data"
{{endregion}}


* Initialize a new instance of the __Telerik.Windows.Data.QueryableCollectionView__ class. Set the source for the collection. 

#### __C#__

{{region cs-gridview-overview-paging_2}}
	QueryableCollectionView qcv = new QueryableCollectionView(RadGridViewSampleData.GetEmployees());
{{endregion}}


#### __VB.NET__

{{region vb-gridview-overview-paging_3}}
	Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
{{endregion}}


* Set the newly created __QueryableCollectionView__ instance as an __ItemsSource/Source__ of the __RadGridView/DataPager__. 

#### __C#__

{{region cs-gridview-overview-paging_4}}
	QueryableCollectionView qcv = new QueryableCollectionView(RadGridViewSampleData.GetEmployees());
	dataPager.Source = qcv;
	radGridView.ItemsSource = qcv;
{{endregion}}


#### __VB.NET__

{{region vb-gridview-overview-paging_5}}
	Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
	dataPager.Source = qcv
	radGridView.ItemsSource = qcv
{{endregion}}

Take a look at the following topics which are entirely dedicated to the __Paging__ functionality.

* Using Silverlight [DataPager]({%slug gridview-paging-using-silverlight-datapager%}). 


* Using [RadDataPager]({%slug radgridview-paging-using-telerik-raddatapager%}). 


Take a look at the following topics which explain in great details the various features of the __RadGridView__.

* Using [Data Binding]({%slug gridview-configuring-the-databindings%}) mechanism to display data in __RadGridView__. 


* [Managing Data]({%slug gridview-overview-managing-data%})

* Using built-in [Sorting]({%slug gridview-overview-sorting%}) functionality. 


* Using built-in [Grouping]({%slug gridview-overview-grouping%}) functionality. 


* Using built-int [Filtering]({%slug gridview-overview-filtering%}) functionality. 


* [Data Selection]({%slug gridview-overview-data-selection%}) functionality. 

## See Also

 * [Grouping]({%slug gridview-overview-grouping%})

 * [Filtering]({%slug gridview-overview-filtering%})

 * [Data Selection]({%slug gridview-overview-data-selection%})
