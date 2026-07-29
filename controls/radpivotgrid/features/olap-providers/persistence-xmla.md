---
title: Persist XmlaDataProvider
page_title: Persist XmlaDataProvider
description: Check our &quot;Persist XmlaDataProvider&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-persistence-xmla
tags: persist,xmladataprovider
published: True
position: 4
---

# Persist XmlaDataProvider

> The implementation demonstrated in this article can also be reviewed in the [Persist XmlaDataProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/Persistence/XmlaPersistence) of the [SDK Examples Browser](https://demos.telerik.com/xaml-sdkbrowser/)

In this article we will show you how to persist the current state of __XmlaDataProvider__ via Telerik's RadPersistenceFramework.      

## Persistence Framework

In this article we will show you how to serialize and deserialize XmlaDataProvider and all of its settings via __RadPersistenceFramework__. You can use this feature to save the current state of the provider and load it next time the application is started.        

## Persist XmlaDataProvider

We've added the DataContract attribute to all classes used by XmlaDataProvider. So you can easily serialize it by using DataContractSerializer.        

So lets create a simple class that we'll use to save and load DataProviderSettings. You have to add the DataContract attribute to the new class and DataMember attribute for its properties.        



<snippet id='radpivotgrid-features-olap-providers-persistence-xmla-block_1-cs' />
<snippet id='radpivotgrid-features-olap-providers-persistence-xmla-block_1-vb' />

The next step is to create a new class, which implements __Telerik.Windows.Persistence.Services.IValueProvider__. *IValueProvider* has two methods that you will have to implement - *ProvideValue* and *RestoreValue*. The first one is used when the data is saved. The second one is used when the data is restored from a previously saved state. When saving the provider, you have to create an instance of *DataProviderSettings* class and set all of the properties. After that you can save the instance to a file or a stream. When using DataContractSerializer you have to give a collection of KnownTypes to the serializer. That's why we've created a new __PivotSerializationHelper__ class which has a static member - KnownTypes. It consits of all types you'll need in order to serialize XmlaDataProvider. Here's an example how to implement it:       



<snippet id='radpivotgrid-features-olap-providers-persistence-xmla-block_2-cs' />
<snippet id='radpivotgrid-features-olap-providers-persistence-xmla-block_2-vb' />

So the last step is to register a persistence provider and implement the logic to save and load the state of XmlaDataProvider:        



<snippet id='radpivotgrid-features-olap-providers-persistence-xmla-block_3-cs' />
<snippet id='radpivotgrid-features-olap-providers-persistence-xmla-block_3-vb' />



## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [XmlaDataProvider]({%slug radpivotgrid-data-xmla%})

 * [Features]({%slug radpivotgrid-features%})

 * [Xmla Serialization]({%slug radpivotgrid-features-serialization-xmla%})