---
title: Custom Aggregate Functions
page_title: Custom Aggregate Functions
description: This article shows how to create custom EnumerableSelectorAggregateFunction and EnumerableAggregateFunction that can be used with the Telerik's data APIs.
slug: radgridview-columns-custom-aggregate-functions
tags: aggregatefunction,customfunctions
published: True
position: 2
---

# Custom Aggregate Functions

The Telerik UI for WPF suite comes with its own data engine that is used in the `RadGridView` control. The engine provides a set of predefined aggregate functions that can be applied over the data - count, sum, max, average, etc.

This article describes how to implement custom aggregate functions by inheriting the `EnumerableAggregateFunction` `EnumerableSelectorAggregateFunction` classes, and also the generic `AggregateFunction<TElement, TResult>` class.

## Implementing Custom EnumerableAggregateFunction

The `EnumerableAggregateFunction` represents a function that uses aggregate extension methods to return a specific result. Examples of Telerik built-in functions using this class are - `CountFunction`, `FirstFunction` and `LastFunction`.

To implement your own aggregate with custom behavior, inherit the `EnumerableAggregateFunction` and override its `AggregateMethodName` and `ExtensionMethodsType` members. 

The `ExtensionMethodsType` tells the type of the static class that holds the methods used for aggregation.

The `AggregateMethodName` returns the name of the aggregation method from the static class.

__Implementing a static class that holds the aggregation functions__
<snippet id='radgridview-columns-custom-aggregate-functions-implementing_a_static_class_that_holds_the_aggregation_functions-cs' />


__Implementing a custom function that calculates the median of the items__
<snippet id='radgridview-columns-custom-aggregate-functions-implementing_a_custom_function_that_calculates_the_median_of_the_items-cs' />


__The Club model used to populate the ItemsSource of RadGridView__
<snippet id='radgridview-columns-custom-aggregate-functions-the_club_model_used_to_populate_the_itemssource_of_radgridview-cs' />


__Adding the function in the AggregateFunctions collection of RadGridView's columns__
<snippet id='radgridview-columns-custom-aggregate-functions-adding_the_function_in_the_aggregatefunctions_collection_of_radgridview_s_columns-xaml' />


Find a runnable project showing this approach in the [following SDK sample](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomAggregateFunctionEnumerableProperty).

## Implementing Custom EnumerableSelectorAggregateFunction

The `EnumerableSelectorAggregateFunction` represents a function that uses a specific field from the data items in order to apply calculations over the data set. Examples of Telerik built-in functions using this class are - `AverageFunction`, `MaxFunction`, `MinFunction`, `SumFunction`.

To implement your own aggregate with custom behavior, inherit the `EnumerableSelectorAggregateFunction` and override its `AggregateMethodName` and `ExtensionMethodsType` members. 

The `ExtensionMethodsType` tells the type of the static class that holds the methods used for aggregation.

The `AggregateMethodName` returns the name of the aggregation method from the static class.

__Implementing a static class that holds the aggregation functions__
<snippet id='radgridview-columns-custom-aggregate-functions-implementing_a_static_class_that_holds_the_aggregation_functions-cs' />


__Implementing a custom function that calculates the median of the items__
<snippet id='radgridview-columns-custom-aggregate-functions-implementing_a_custom_function_that_calculates_the_median_of_the_items-cs' />


__Adding the function in the AggregateFunctions collection of RadGridView's columns__
<snippet id='radgridview-columns-custom-aggregate-functions-adding_the_function_in_the_aggregatefunctions_collection_of_radgridview_s_columns-xaml' />


## Using Generic Aggregate Function

To implement a generic aggregate function, you can use the `AggregateFunction<TElement, TResult>` class and set its `AggregationExpression` property.

__Defining custom aggregate function__
<snippet id='radgridview-columns-custom-aggregate-functions-defining_custom_aggregate_function-cs' />

