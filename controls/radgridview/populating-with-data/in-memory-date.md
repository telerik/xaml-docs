---
title: Using in-memory Data
page_title: Using In-Memory Data
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how you can populate the grid with in-memory data.
slug: gridview-in-memory-date
tags: using,in-memory,data
published: True
position: 2
---

# Using In-Memory Data

The purpose of this tutorial is to show you how to populate a __RadGridView__ with in-memory data.

The control will be bound to an __ObservableCollection__ of __Car__ objects. Each __Car__ has a __Name__ and __Description__.

* Create a new class named __Car__ and add two properties - __Name__ and __Description__. Both of the properties are of type string. Here is the source code: 



<snippet id='radgridview-populating-with-data-in-memory-date-block_1-cs' />

<snippet id='radgridview-populating-with-data-in-memory-date-block_1-vb' />


* Create a new class named __RadGridViewSampleData__. 



<snippet id='radgridview-populating-with-data-in-memory-date-block_2-cs' />

<snippet id='radgridview-populating-with-data-in-memory-date-block_2-vb' />


* Declare the __RadGridViewSampleData__ object as a resource in your application. 



<snippet id='radgridview-populating-with-data-in-memory-date-block_3-xaml' />


* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 



<snippet id='radgridview-populating-with-data-in-memory-date-block_4-xaml' />


Run your demo, the result can be seen on the next picture:

![Telerik UI for {{ site.framework_name }} RadGridView populated with an in-memory ObservableCollection of car data](images/RadGridView_PopulatingWithDataLoadFromInMemoryData_010.PNG)

>tip If you need to define the columns manually read the topic [Defining Columns]({%slug gridview-columns-defining-columns%}).

## See Also

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%}) 
{% if site.site_name == 'Silverlight' %}

 * [Loading Data from RIA Services]({%slug gridview-loading-data-from-ria-services%})

 * [DomainDataSource Support]({%slug gridview-domaindatasource-support%})

 * [Loading Data from Web Services]({%slug gridview-loading-data-from-web-services%})
{% endif %}

 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})

 * [Loading Data from ADO.NET Services]({%slug gridview-loading-data-from-adonet-services%})

