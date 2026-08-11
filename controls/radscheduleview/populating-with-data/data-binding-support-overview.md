---
title: Data Binding Support Overview
page_title: Data Binding Support Overview
description: Check our &quot;Data Binding Support Overview&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-populating-with-data-data-binding-support-overview
tags: data,binding,support,overview
published: True
position: 0
---

# Data Binding Support Overview

Data binding allows you to establish a link between the UI and the underlying business logic and keep them synchronized. It means that when a value is changed in the business layer, that change is automatically populated to the UI and vice versa. Of course, in order to work, you have to implement the proper notification or to use objects that have already implemented it.        

Binding to __RadScheduleView__ involves the following properties:

* [AppointmentsSource](#appointmentssource)
* [ResourceTypesSource](#resourcetypessource)
* [CategoriesSource](#categoriessource)
* [TimeMarkersSource](#timemarkerssource)
* [GroupDescriptionsSource](#groupdescriptionssource)

## AppointmentsSource

__AppointmentsSource__ - gets or sets the data source (__IEnumerable__) used to generate the Appointments in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.            

>Note that the data source passed to the property __AppointmentsSource__ should contain only objects that implement the __IAppointment__ interface.

__Example 1: Defining the AppointmentsSource collection in the view model__

<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_1-cs' />

__Example 2: Binding the AppointmentsSource__

<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_2-xaml' />

## ResourceTypesSource

__ResourceTypesSource__ -  gets or sets the data source (__IEnumerable__) used to generate the ResourceTypes of the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __ResourceTypesSource__ should contain only objects of type __ResourceType__.

__Example 3: Defining the ResourceTypesSource collection in the view model__

<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_3-cs' />

__Example 4: Binding the ResourceTypesSource__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_4-xaml' />

## CategoriesSource

__CategoriesSource__ - gets or sets the data source (__IEnumerable__) used to generate the Categories in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __CategoriesSource__ should contain only objects of type __Category__.

__Example 5: Defining the Categories collection in the view model__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_5-cs' />


__Example 6: Binding the CategoriesSource__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_6-xaml' />

## TimeMarkersSource

__TimeMarkersSource__ - gets or sets the data source (__IEnumerable__) used to generate the TimeMarkers in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __TimeMarkersSource__ should contain only objects of type __TimeMarker__.

__Example 7: Defining the TimeMarkers collection in the view model__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_7-cs' />

__Example 8: Binding the TimeMarkersSource__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_8-xaml' />

## GroupDescriptionsSource

__GroupDescriptionsSource__ - gets or sets the data source (__IEnumerable\<GroupDescription\>__) used to generate the GroupDescriptions in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __GroupDescriptionsSource__ should contain only objects of type __GroupDescription__.

__Example 9: Defining the GroupDescriptions collection in the view model__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_9-cs' />

__Example 10: Binding the GroupDescriptionsSource__
<snippet id='radscheduleview-populating-with-data-data-binding-support-overview-block_10-xaml' />

## See Also

 * [Implementing View-ViewModel ]({%slug radscheduleview-populating-with-data-implementing-view-model%})