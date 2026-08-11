---
title: Serialization
page_title: Serialization
description: Check our &quot;Serialization&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-queryable-serialization
tags: queryable, dataprovider, serialization
published: True
position: 11
---

# Serialization

> The implementation demonstrated in this article can also be reviewed in the [Serialize QueryableDataProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/Serialization/QueryableDataProvider) of the [SDK Examples Browser](https://demos.telerik.com/xaml-sdkbrowser/)

This article will go through the process of serializing and deserializing the current state of __QueryableDataProvider__. Through it the state of the control can be persisted and loaded the next time the application is started.

* [Using the DataContract Attribute](#using-the-datacontract-attribute)

## Using the DataContract Attribute

The DataContract attribute is added to all classes used by the QueryableDataProvider. This enables easy serialization with the DataContractSerializer. Below is a sample definition of such classes. The __DataContract__ attribute is added on class level and the __DataMember__ one is added for each property.

__Example 1: Using the DataContract attribute__	

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-serialization-block_1-cs' />

## Implementing the Serializer

The next step is to implement the serializer. When serializing the provider an instance of the __DataProviderSettings__ class has to be created with all of its properties set. After that you can serialize the instance to a file or a stream. 

__Example 2: Implementing the Serializer__

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-serialization-block_2-cs' />

## Specifying the KnownTypes

In the previous example a collection of KnownTypes is passed to the __DataContractSerializer__. It consists of all types needed for serializing the QueryableDataProvider. For this purpose we created a new __QueryablePivotSerializationHelper__ class which has a static member - KnownTypes.

__Example 3: Specifying the KnownTypes__

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-serialization-block_3-cs' />

## Serialize and Deserialize 

The final step is to serialize and deserialize the data provider.

__Example 4: Serialize and Deserialize the Data Provider__

<snippet id='radpivotgrid-features-queryabledataprovider-queryable-serialization-block_4-cs' />

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})

 * [Persistence]({%slug radpivotgrid-features-queryable-persistence%})