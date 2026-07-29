---
title: Serialize AdomdDataProvider
page_title: Serialize AdomdDataProvider
description: Check our &quot;Serialize AdomdDataProvider&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-features-serialization-adomd
tags: serialize,adomddataprovider
published: True
position: 5
site_name: WPF
---

# Serialize AdomdDataProvider

> The implementation demonstrated in this article can also be reviewed in the [Serialize AdomdDataProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/PivotGrid/Serialization/AdomdProvider) of the [SDK Examples Browser](https://demos.telerik.com/xaml-sdkbrowser/)

In this article we will show you how to serialize and deserialize AdomdDataProvider and all of its settings. You can use this feature to save the current state of the provider and load it next time the application is started.      

## Serialize AdomdDataProvider with DataContractSerializer

We've added the DataContract attribute to all classes used by AdomdDataProvider. So you can easily serialize it by using DataContractSerializer. Below you will find out how to create a serializer and use it with __RadPivotGrid__.        

So lets create a simple class that we'll use to save (when serializing) and load (when deserializing) DataProviderSettings. You have to add the DataContract attribute to the new class and DataMember attribute for its properties.        



<snippet id='radpivotgrid-features-olap-providers-serialization-adomd-block_1-cs' />
<snippet id='radpivotgrid-features-olap-providers-serialization-adomd-block_1-vb' />

The next step is to implement the serializer. When serializing the provider, you have to create an instance of *DataProviderSettings* class and set all of the properties. After that you can serialize the instance to a file or a stream. When using DataContractSerializer you have to give a collection of KnownTypes to the serializer. That's why we've created a new __AdomdPivotSerializationHelper__ class which has a static member - KnownTypes. It consits of all types you'll need in order to serialize AdomdDataProvider. Here's an example how to implement your own serializer:        



<snippet id='radpivotgrid-features-olap-providers-serialization-adomd-block_2-cs' />
<snippet id='radpivotgrid-features-olap-providers-serialization-adomd-block_2-vb' />

So the last step is to serialize the provider and deserialize it:        



<snippet id='radpivotgrid-features-olap-providers-serialization-adomd-block_3-cs' />
<snippet id='radpivotgrid-features-olap-providers-serialization-adomd-block_3-vb' />

## See Also

 * [AdomdDataProvider]({%slug radpivotgrid-data-adomd%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})