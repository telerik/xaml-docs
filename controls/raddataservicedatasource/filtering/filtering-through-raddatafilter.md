---
title: Filtering through RadDataFilter
page_title: Filtering through RadDataFilter
description: Filtering through RadDataFilter
slug: raddataservicedatasource-filtering-filtering-through-raddatafilter
tags: filtering,through,raddatafilter
published: True
position: 2
---

# Filtering through RadDataFilter



## 

If you bind RadDataFilter.__Source__ to RadDataServiceDataSource.__DataView__, you will get automatic server-side filtering. When the user defines his filtering criteria through RadDataFilter’s UI, RadDataFilter will automatically transfer the resulting FilterDescriptors to RadDataServiceDataSource. If RadDataServiceDataSource.AutoLoad is true, the control will automatically go to the server and get the data that matches these FilterDescriptors. 

#### __XAML__

{{region raddataservicedatasource-filtering-filtering-through-raddatafilter_0}}
	<Grid x:Name="LayoutRoot" Background="White">
	 <Grid.RowDefinitions>
	  <RowDefinition Height="Auto"/>
	  <RowDefinition Height="*"/>
	 </Grid.RowDefinitions>
	 <telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	  <telerik:RadDataServiceDataSource.DataServiceContext>
	   <local:MyNorthwindContext/>
	  </telerik:RadDataServiceDataSource.DataServiceContext>
	 </telerik:RadDataServiceDataSource>
	 <telerik:RadDataFilter Grid.Row="0" Source="{Binding DataView, ElementName=customersDataSource}"/>
	 <telerik:RadGridView Grid.Row="1" ItemsSource="{Binding DataView, ElementName=customersDataSource}" 
	    IsBusy="{Binding IsBusy, ElementName=customersDataSource}" 
	    ShowGroupPanel="False"/> 
	</Grid>
	{{endregion}}





On running the application, you may perform the following:




         
      ![](images/RadDataServiceDataSource_FiteringThroughRadDataFilter.png)




