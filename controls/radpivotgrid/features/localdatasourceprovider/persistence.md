---
title: Persistence
page_title: Persistence
description: Check our &quot;Persistence&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-persistence
tags: persistence
published: True
position: 6
---

# Persistence

> The implementation demonstrated in this article can also be reviewed in the [Persist LocalDataSourceProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/Persistence/LocalDataSourceProvider) of the [SDK Examples Browser](https://demos.telerik.com/xaml-sdkbrowser/)

In this article we will show you how to persist the current state of __LocalDataSourceProvider__ via Telerik's RadPersistenceFramework.    

## Persistence Framework

In this article we will show you how to serialize and deserialize LocalDataSourceProvider and all of its settings via __RadPersistenceFramework__. You can use this feature to save the current state of the provider and load it next time the application is started.        

## Persist LocalDataSourceProvider

We've added the DataContract attribute to all classes used by LocalDataSourceProvider. So you can easily serialize it by using DataContractSerializer.         

So lets create a simple class that we'll use to save and load DataProviderSettings. You have to add the DataContract attribute to the new class and DataMember attribute for its properties.        



<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_1-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_1-vb' />

The next step is to create a new class, which implements __Telerik.Windows.Persistence.Services.IValueProvider__. *IValueProvider* has two methods that you will have to implement - *ProvideValue* and *RestoreValue*. The first one is used when the data is saved. The second one is used when the data is restored from a previously saved state. When saving the provider, you have to create an instance of *DataProviderSettings* class and set all of the properties. After that you can save the instance to a file or a stream. When using DataContractSerializer you have to give a collection of KnownTypes to the serializer. That's why we've created a new __PivotSerializationHelper__ class which has a static member - KnownTypes. It consists of all types you'll need in order to serialize LocalDataSourceProvider. Here's an example how to implement it:        



<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_2-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_2-vb' />

So the last step is to register a persistence provider and implement the logic to save and load the state of LocalDataSourceProvider:        



<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_3-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_3-vb' />

## Persist custom types

If you have implemented your own custom types, for example CustomGroupDescription, and you want to persist your data, you have to do the following:        

* Set the DataContract attribute on each of your custom classes.            

* Set the DataMember attribute on each of the properties that you want to serialize.            

* Add all custom classes to the KnownTypes collection.            

So if you have implemented a custom group description, it should be similar to this:        



<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_4-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_4-vb' />

And here's the change in *LocalDataSourceValueProvider* class:        



<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_5-cs' />
<snippet id='radpivotgrid-features-localdatasourceprovider-persistence-block_5-vb' />

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})

 * [Serialization]({%slug radpivotgrid-features-serialization%})