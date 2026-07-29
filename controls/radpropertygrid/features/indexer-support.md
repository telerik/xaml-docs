---
title: Indexer Support
page_title: Indexer Support
description: Check our &quot;Indexer Support&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-features-indexer-support
tags: indexer,support
published: True
position: 19
---

# Indexer Support

In **R2 2016**, Telerik introduced **Indexer Support** for RadPropertyGrid's **PropertyDefinition** bindings. It covers the following scenarios:

* [Binding to an Item of a Collection Through Indexer](#binding-to-an-item-of-a-collection-through-indexer)

* [Binding of NestedProperties](#binding-of-nestedproperties)

* [Binding to a collection property with a string key](#binding-to-a-collection-property-with-a-string-key)

* [Binding to an Item which Implements an Indexer](#binding-to-an-item-which-implements-an-indexer)

* [Using Unbound Mode](#using-unbound-mode)

For the purposes of this article, we will assume the following class hierarchy is present:

__Example 1: The class hierarchy__

<snippet id='radpropertygrid-features-indexer-support-block_1-cs' />
<snippet id='radpropertygrid-features-indexer-support-block_1-vb' />

## Binding to an Item of a Collection Through Indexer

A common scenario when using RadPropertyGrid is when we have a collection member of our business object. **Example 2** shows how to bind to an item at a specified index in the collection:

__Example 2: Binding to a collection__

<snippet id='radpropertygrid-features-indexer-support-block_2-xaml' />

## Binding of NestedProperties

You can also use indexing in **NestedProperties**, as shown in **Example 3**:

__Example 3: Binding of NestedProperties__

<snippet id='radpropertygrid-features-indexer-support-block_3-xaml' />

## Binding to a Collection Property with a String Key

As our **League** class has a **Dictionary** of clubs, we can access any club by its name, as demonstrated in **Example 4**.

__Example 4: Binding to item in Dictionary__

<snippet id='radpropertygrid-features-indexer-support-block_4-xaml' />

## Binding to an Item which Implements an Indexer

Since our **Club** class implements an indexer, we can also bind to the **Player**, whose number is 25, for example:

__Example 5: Indexing a class that implements indexer__

<snippet id='radpropertygrid-features-indexer-support-block_5-xaml' />

## Using Unbound Mode

Indexer support also works when **AutoGenerateBindingPaths** is set to **False**.

__Example 6: Indexing when AutoGenerateBindingPaths is set to False__

<snippet id='radpropertygrid-features-indexer-support-block_6-xaml' />

## See Also

* [Nested Properties]({%slug radpropertygrid-nested-properties%})

* [Unbound Mode]({%slug radpropertygrid-unbound-mode%})