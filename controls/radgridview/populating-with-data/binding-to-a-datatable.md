---
title: Binding to the DataView of a DataTable
page_title: Binding to the DataView of a DataTable
description: This article demonstrates how to bind Telerik's {{ site.framework_name }} DataGrid to the DataView of a DataTable.
slug: gridview-binding-to-the-dataview-of-a-datatable
tags: binding, datatable, defaultview, dataview
published: True
position: 11
---

# Binding to the DataView of a DataTable

This article will demonstrate how to bind a __RadGridView__ to the DataView of a DataTable. An important thing when using a DataTable as a data source for a RadGridView is to make sure that the __ItemsSource__ property of the control is bound to the __DefaultView__ property of the DataTable, which is of type [DataView](https://docs.microsoft.com/en-us/dotnet/api/system.data.dataview?view=netframework-4.7.2).

## Binding to DataTable's DefaultView

__Example 1__ demonstrates how you can set up a ViewModel containing a DataTable in order to bind it to the RadGridView.

__Example 1: Setting up the ViewModel__

<snippet id='radgridview-populating-with-data-binding-to-a-datatable-example_1_setting_up_the_viewmodel-cs' />

<snippet id='radgridview-populating-with-data-binding-to-a-datatable-example_1_setting_up_the_viewmodel-vb' />


__Example 2__ demonstrates how the RadGridView is set up in XAML. Please, pay attention to the fact that the __ItemsSource__ is bound to the __DefaultView__ property of the DataTable.

__Example 2: Setting up the RadGridView__

<snippet id='radgridview-populating-with-data-binding-to-a-datatable-example_2_setting_up_the_radgridview-xaml' />


## See Also

* [Configure the Data Bindings]({%slug gridview-configuring-the-databindings%})
* [Adding new Entries]({%slug gridview-managing-data-add-new-entries%})
