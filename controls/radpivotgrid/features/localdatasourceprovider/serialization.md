---
title: Serialization
page_title: Serialization
description: Check our &quot;Serialization&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-serialization
tags: serialization
published: True
position: 5
---

# Serialization

> The implementation demonstrated in this article can also be reviewed in the [Serialize LocalDataSourceProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/Serialization/LocalDataSourceProvider) of the [SDK Examples Browser](https://demos.telerik.com/xaml-sdkbrowser/)

In this article we will show you how to serialize and deserialize LocalDataSourceProvider and all of its settings. You can use this feature to save the current state of the provider and load it next time the application is started.      

## Serialize LocalDataSourceProvider with DataContractSerializer

We've added the DataContract attribute to all classes used by LocalDataSourceProvider. So you can easily serialize it by using DataContractSerializer. Below you will find out how to create a serializer and use it with __RadPivotGrid__.        

So lets create a simple class that we'll use to save (when serializing) and load (when deserializing) DataProviderSettings. You have to add the DataContract attribute to the new class and DataMember attribute for its properties.        



<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_1-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_1-vb' />



The next step is to implement the serializer. When serializing the provider, you have to create an instance of *DataProviderSettings* class and set all of the properties. After that you can serialize the instance to a file or a stream. When using DataContractSerializer you have to give a collection of KnownTypes to the serializer. That's why we've created a new __PivotSerializationHelper__ class which has a static member - KnownTypes. It consits of all types you'll need in order to serialize LocalDataSourceProvider. Here's an example how to implement your own serializer:        



<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_2-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_2-vb' />

So the last step is to serialize the provider and deserialize it:        



<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_3-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_3-vb' />

## Serialize custom types

If you have implemented your own custom types, for example CustomGroupDescription, and you want to serialize your data, you have to do the following:        

* Set the DataContract attribute on each of your custom classes.            

* Set the DataMember attribute on each of the properties that you want to serialize.            

* Add all custom classes to the KnownTypes collection.            

So if you have implemented a custom group description, it should be similar to this:        



<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_4-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_4-vb' />

And here's the change in *LocalDataSourceSerializer* class:        



<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_5-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-serialization-block_5-vb' />

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})