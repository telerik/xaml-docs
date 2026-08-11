---
title: Binding to a DataSet
page_title: Binding to a DataSet
description: This article demonstrates how to bind Telerik's DataGrid to a DataSet.
slug: gridview-binding-to-dataset
tags: binding, dataset, datagrid
published: True
position: 11
---

# Binding to a DataSet

This article demonstrates how to bind a __RadGridView__ to data coming from a **DataSet**.

## Setting up the ViewModel

__Example 1__ demonstrates how you can set up a ViewModel containing a DataSet in order to bind it to the RadGridView.

__Example 1: Setting up the ViewModel__

<snippet id='radgridview-populating-with-data-binding-to-dataset-example_1_setting_up_the_viewmodel-cs' />

<snippet id='radgridview-populating-with-data-binding-to-dataset-example_1_setting_up_the_viewmodel-vb' />


>important Please note that the **DataRelation** is required for RadGridView to generate the hierarchy automatically.

__Example 2__ demonstrates how the RadGridView is set up in XAML.

__Example 2: Setting up the RadGridView__

<snippet id='radgridview-populating-with-data-binding-to-dataset-example_2_setting_up_the_radgridview-xaml' />


>If updates to the hierarchy are required during runtime, you can invoke RadGridView's **BuildHierarchyFromDataSet** method.

## See Also

* [Configure the Data Bindings]({%slug gridview-configuring-the-databindings%})
* [Adding new Entries]({%slug gridview-managing-data-add-new-entries%})
* [Binding to the DataView of a DataTable]({%slug gridview-binding-to-the-dataview-of-a-datatable%})