---
title: View and ViewModel
page_title: View and ViewModel
description: Check our &quot;View and ViewModel&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-populating-with-data-binding-to-db-viewmodel-wpf
tags: view,and,viewmodel
published: True
position: 8
site_name: WPF
---

# View and ViewModel

This article will demonstrate how to implement the View and the ViewModel.

## Presentation tier (xaml)

When the models are defined, we need to create the __ViewModel__ (refer to __ScheduleViewViewModel__ class) and bind the ScheduleView control in the xaml:



<snippet id='radscheduleview-populating-with-data-binding-to-database-binding-to-db-viewmodel-wpf-block_1-xaml' />

>The appointments are loaded from the database when the VisibleRangeChanged command is executed.

When "Save data" button is clicked, we save the data to the server.



<snippet id='radscheduleview-populating-with-data-binding-to-database-binding-to-db-viewmodel-wpf-block_2-cs' />

## ViewModel

In the constructor we load the data for the ScheduleView control (without appointments, they are loaded later). First, we need to load the SqlResource and SqlResourceTypes. When both are loaded, we can added the resources to the ResourceTypes collection.				

Load the SqlTimeMarkers and the SqlCategories and add them to the TimeMarkers and Categories collections.

Here is the code:



<snippet id='radscheduleview-populating-with-data-binding-to-database-binding-to-db-viewmodel-wpf-block_3-cs' />

Also, we need to handle the Appointments.CollectionChanged event and in the handler we add or remove the items from the ObjectSets:



<snippet id='radscheduleview-populating-with-data-binding-to-database-binding-to-db-viewmodel-wpf-block_4-cs' />