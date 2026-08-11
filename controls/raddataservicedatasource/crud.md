---
title: CRUD
page_title: CRUD
description: This article explains how you can perform CRUD operations in RadDataServiceDataSource.
slug: raddataservicedatasource-crud
tags: crud
published: True
position: 6
---

# CRUD

You can utilize all CRUD operations by working with the __DataView__ property of the __RadDataServiceDataSource__ control and add, edit or remove entities from the collection which is of type **DataItemCollection**. You can do that either programmatically via the API of the collection or leave the job to __RadGridView__ by binding its __ItemsSource__ to the DataView.

__Example 1: Bind the DataView collection to RadGridView's ItemsSource__
<snippet id='raddataservicedatasource-crud-example_1_bind_the_dataview_collection_to_radgridview_s_itemssource-xaml' />


Once you're ready to submit the changes you can call the __SubmitChanges__ method of the control.

__Example 2: Submit the changes in the view__
<snippet id='raddataservicedatasource-crud-example_2_submit_the_changes_in_the_view-cs' />

<snippet id='raddataservicedatasource-crud-example_2_submit_the_changes_in_the_view-vb' />


In order to reject the changes and reload the original data from the server you need to call the __RejectChanges__ method of the control.

__Example 3: Submit the changes in the view__
<snippet id='raddataservicedatasource-crud-example_3_submit_the_changes_in_the_view-cs' />

<snippet id='raddataservicedatasource-crud-example_3_submit_the_changes_in_the_view-vb' />


## See Also
* [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
* [MVVM Support]({%slug raddataservicedatasource-mvvm%})