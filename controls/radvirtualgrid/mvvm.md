---
title: MVVM Support
page_title: MVVM Support
description: Check our &quot;MVVM Support&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-mvvm
tags: virtualgrid,mvvm
published: True
position: 1
---

# MVVM Support

This topic will go through the approach of using __RadVirtualGrid__ in MVVM scenarios. This can be achieved by benefiting from the __DataProvider__ mechanism of the control. More information on this matter can be found in the [Getting Started]({%slug virtualgrid-getting-started2%}) and [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%}) topics.

## Defining the business model

Firstly, we need an object model that will be used to populate __RadVirtualGrid__ with data. For this purpose, the following __Club__ object is defined.

__Example 1: Defining the Club object__

<snippet id='radvirtualgrid-mvvm-block_1-cs' />

## Implementing a custom DataProvider

The next step is to define a custom __DataProvider__ that handles some specific scenarios. It demonstrates how the selection of the control can be persisted when sorting or filtering. Note, that by default the selection is being cleared when processing these operations. Also, the example demonstrates how to hide a given column, define a custom editor, set a given column to be readonly and apply a custom header.

__Example 2: Implementing a Custom DataProvider__

<snippet id='radvirtualgrid-mvvm-block_2-cs' />

## Defining the View Model

The following code snippet demonstrates how the custom DataProvider can be exposed by a view model.

__Example 2: Defining the View Model__

<snippet id='radvirtualgrid-mvvm-block_3-cs' />

## Populate RadVirtualGrid

This section shows how the View Model can be set to be the DataContext of __RadVirtualGrid__ and how its __DataProvider__ property can be bound to the custom DataProvider.

__Example 3: Populating RadVirtualGrid__

<snippet id='radvirtualgrid-mvvm-block_4-xaml' />

## See Also

* [Getting Started]({%slug virtualgrid-getting-started2%})
* [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%})
* [Editing]({%slug virtualgrid-editing%})