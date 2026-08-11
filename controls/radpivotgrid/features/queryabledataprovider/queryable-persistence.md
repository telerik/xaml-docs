---
title: Persistence
page_title: Persistence
description: Check our &quot;Persistence&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-queryable-persistence
tags: queryable, dataprovider, persistence
published: True
position: 10
---

# Persistence

> The implementation demonstrated in this article can also be reviewed in the [Persist QueryableDataProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/Persistence/QueryableDataProvider) of the [SDK Examples Browser](https://demos.telerik.com/xaml-sdkbrowser/)

This article will go through the process of persisting the current state of __QueryableDataProvider__ via __RadPersistenceFramework__. Through it the state of the control can be persisted and loaded the next time the application is started.

* [Using the DataContract Attribute](#using-the-datacontract-attribute)
* [Defining the IValueProvider](#defining-the-ivalueprovider)
* [Specifying the KnownTypes](#specifying-the-knowntypes)
* [Registering the PersistenceProvider](#registering-the-persistenceprovider)


## Using the DataContract Attribute

The DataContract attribute is added to all classes used by the QueryableDataProvider. This enables easy serialization with the DataContractSerializer. Below is a sample definition of such classes. The __DataContract__ attribute is added on class level and the __DataMember__ one is added for each property.

__Example 1: Using the DataContract attribute__	

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-persistence-block_1-cs' />

## Defining the IValueProvider

The next step is to create a new class, which implements the __Telerik.Windows.Persistence.Services.IValueProvider__ interface. It provides two methods that need to be implemented - __ProvideValue__ and __RestoreValue__. The first one is used when the data is saved. The second one is used when the data is restored from a previously saved state. When saving the provider, an instance of the *DataProviderSettings* class has to be created with all of its properties set. Then, the instance can be saved to a file or a stream. Below is a sample implementation of the interface.

__Example 2: Implementing the IValueProvider interface__

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-persistence-block_2-cs' />

## Specifying the KnownTypes

In the previous example a collection of KnownTypes is passed to the __DataContractSerializer__. It consists of all types needed for serializing the QueryableDataProvider. For this purpose we created a new __QueryablePivotSerializationHelper__ class which has a static member - KnownTypes. 

__Example 3: Specifying the KnownTypes__

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-persistence-block_3-cs' />

## Registering the PersistenceProvider

The final step is to register a persistence provider and implement the logic needed for saving and loading the state of the QueryableDataProvider.

__Example 4: Registering the PersistenceProvider__
<snippet id='radpivotgrid-features-queryabledataprovider-queryable-persistence-block_4-cs' />

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})

 * [Serialization]({%slug radpivotgrid-features-serialization%})