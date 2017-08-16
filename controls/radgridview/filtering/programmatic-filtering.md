---
title: Programmatic Filtering
page_title: Programmatic Filtering
description: Programmatic Filtering
slug: gridview-programmatic-filtering
tags: programmatic,filtering
published: False
position: 1
---

# Programmatic Filtering

Besides the built-in filtering functionality you are able to use a programmatic approach to filter the data in the __RadGridView__. This is achieved via the __FilterDescriptors__ property of the __RadGridView__. This collection stores filter descriptors that implement the __IFilterDescriptor__ interface. The most important classes that implement this interface directly or not are:

* __FilterDescriptor__ - implements filtering property(field) name, filtering operator and value. Used to define simple filtering expressions like __Country = "Germany"__. [Read more]({%slug radgridview-filtering-simple-filter-descriptors%})

* __CompositeFilterDescriptor__ - a collection of multiple filter descriptors with logical operator. Used to define complex filtering expressions like __(Country = "Germany" AND (City = "Berlin" OR City = "Aachen"))__. [Read more]({%slug radgridview-filtering-composite-filter-descriptors%})

* __IColumnFilterDescriptor__ - represents a column filter descriptor associated with a specific column. [Read more]({%slug radgridview-filtering-icolumn-filter-descriptors%})

## See Also

 * [Basic Filtering]({%slug gridview-basic-filtering%})

 * [Cascading Distinct Values]({%slug gridview-filtering-cascading-distinct-values%})

 * [Useful Links]({%slug gridview-filtering-useful-links%})
