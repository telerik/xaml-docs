---
title: Filtering through RadGridView
page_title: Filtering through RadGridView
description: Check our &quot;Filtering through RadGridView&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-filtering-filtering-through-radgridview
tags: filtering,through,radgridview
published: True
position: 1
---

# Filtering through RadGridView



## 

If you bind __RadGridView.ItemsSource__ to __RadDataServiceDataSource.DataView__, you will get automatic server-side filtering. When the user defines his filtering criteria through __RadGridView’s__ UI, __RadGridView__ will automatically transfer the resulting __FilterDescriptors__ to __RadDataServiceDataSource__. If __RadDataServiceDataSource.AutoLoad__ is ___true___, the control will automatically go to the server and get the data that matches these __FilterDescriptors__:



```XAML

	<Grid x:Name="LayoutRoot" Background="White">
	 <telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	  <telerik:RadDataServiceDataSource.DataServiceContext>
	   <local:MyNorthwindContext/>
	  </telerik:RadDataServiceDataSource.DataServiceContext>
	 </telerik:RadDataServiceDataSource>
	 <telerik:RadGridView Grid.Row="0" ItemsSource="{Binding DataView, ElementName=customersDataSource}" 
	      IsBusy="{Binding IsBusy, ElementName=customersDataSource}" 
	    ShowGroupPanel="False"/>  
	</Grid>
```



Performing the filtering operation from the UI of the __RadGridView__ should be as follows:

![{{ site.framework_name }} RadDataServiceDataSource Filtering via RadGridView](images/RadDataServiceDataSource_FiteringThroughRadGridView.png)



>caution If __AutoLoad__ is ___false___, the descriptors will be transferred to __RadDataServiceDataSource__, but no trip to the server will be made until the __Load__ method is called.


