---
title: Paging through RadDataPager
page_title: Paging through RadDataPager
description: Paging through RadDataPager
slug: raddataservicedatasource-paging-paging-through-raddatapager
tags: paging,through,raddatapager
published: True
position: 1
---

# Paging through RadDataPager



## 

If you bind RadDataPager.Source to RadDataServiceDataSource.DataView, you will get automatic server-side paging. The two controls will automatically communicate with each other thanks to the IPagedCollectionView interface which both respect:

#### __XAML__

{{region raddataservicedatasource-paging-paging-through-raddatapager_0}}
	<Grid x:Name="LayoutRoot" Background="White">
	 <Grid.RowDefinitions>
	  <RowDefinition Height="*"/>
	  <RowDefinition Height="Auto"/>
	 </Grid.RowDefinitions>
	 <telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	  <telerik:RadDataServiceDataSource.DataServiceContext>
	   <local:MyNorthwindContext/>
	  </telerik:RadDataServiceDataSource.DataServiceContext>
	 </telerik:RadDataServiceDataSource>
	 <telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}" 
	     IsBusy="{Binding IsBusy, ElementName=customersDataSource}" 
	     ShowGroupPanel="False"/>  
	 <telerik:RadDataPager Grid.Row="1" Source="{Binding DataView, ElementName=customersDataSource}" PageSize="10"/>
	</Grid>
	{{endregion}}



In this case on running the application the following will be visualized:




         
      ![](images/RadDataServiceDataSource_PagingThroughRadDataPager.png)


