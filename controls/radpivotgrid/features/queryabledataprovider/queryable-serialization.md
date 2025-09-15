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

```C#
	[DataContract]
    public class DataProviderSettings
    {
        [DataMember]
        public object[] Aggregates { get; set; }

        [DataMember]
        public object[] Filters { get; set; }

        [DataMember]
        public object[] Rows { get; set; }

        [DataMember]
        public object[] Columns { get; set; }

        [DataMember]
        public int AggregatesLevel { get; set; }

        [DataMember]
        public PivotAxis AggregatesPosition { get; set; }
    }
```

## Implementing the Serializer

The next step is to implement the serializer. When serializing the provider an instance of the __DataProviderSettings__ class has to be created with all of its properties set. After that you can serialize the instance to a file or a stream. 

__Example 2: Implementing the Serializer__

```C#
	 public abstract class DataProviderSerializer
    {
        public abstract IEnumerable<Type> KnownTypes { get; }

        public string Serialize(object context)
        {
            string serialized = string.Empty;

            IDataProvider dataProvider = context as IDataProvider;
            if (dataProvider != null)
            {
                MemoryStream stream = new MemoryStream();

                DataProviderSettings settings = new DataProviderSettings()
                {
                    Aggregates = dataProvider.Settings.AggregateDescriptions.OfType<object>().ToArray(),
                    Filters = dataProvider.Settings.FilterDescriptions.OfType<object>().ToArray(),
                    Rows = dataProvider.Settings.RowGroupDescriptions.OfType<object>().ToArray(),
                    Columns = dataProvider.Settings.ColumnGroupDescriptions.OfType<object>().ToArray(),
                    AggregatesLevel = dataProvider.Settings.AggregatesLevel,
                    AggregatesPosition = dataProvider.Settings.AggregatesPosition
                };

                DataContractSerializer serializer = new DataContractSerializer(typeof(DataProviderSettings), KnownTypes);
                serializer.WriteObject(stream, settings);

                stream.Position = 0;
                var streamReader = new StreamReader(stream);
                serialized += streamReader.ReadToEnd();
            }

            return serialized;
        }

        public void Deserialize(object context, string savedValue)
        {
            IDataProvider dataProvider = context as IDataProvider;
            if (dataProvider != null)
            {
                var stream = new MemoryStream();
                var tw = new StreamWriter(stream);
                tw.Write(savedValue);
                tw.Flush();
                stream.Position = 0;

                DataContractSerializer serializer = new DataContractSerializer(typeof(DataProviderSettings), KnownTypes);
                var result = serializer.ReadObject(stream);

                dataProvider.Settings.AggregateDescriptions.Clear();
                foreach (var aggregateDescription in (result as DataProviderSettings).Aggregates)
                {
                    dataProvider.Settings.AggregateDescriptions.Add(aggregateDescription);
                }

                dataProvider.Settings.FilterDescriptions.Clear();
                foreach (var filterDescription in (result as DataProviderSettings).Filters)
                {
                    dataProvider.Settings.FilterDescriptions.Add(filterDescription);
                }

                dataProvider.Settings.RowGroupDescriptions.Clear();
                foreach (var rowDescription in (result as DataProviderSettings).Rows)
                {
                    dataProvider.Settings.RowGroupDescriptions.Add(rowDescription);
                }

                dataProvider.Settings.ColumnGroupDescriptions.Clear();
                foreach (var columnDescription in (result as DataProviderSettings).Columns)
                {
                    dataProvider.Settings.ColumnGroupDescriptions.Add(columnDescription);
                }

                dataProvider.Settings.AggregatesPosition = (result as DataProviderSettings).AggregatesPosition;
                dataProvider.Settings.AggregatesLevel = (result as DataProviderSettings).AggregatesLevel;
            }
        }
    }
```

## Specifying the KnownTypes

In the previous example a collection of KnownTypes is passed to the __DataContractSerializer__. It consists of all types needed for serializing the QueryableDataProvider. For this purpose we created a new __QueryablePivotSerializationHelper__ class which has a static member - KnownTypes.

__Example 3: Specifying the KnownTypes__

```C#
	public class QueryableProviderSerializer: DataProviderSerializer
    {
        public override IEnumerable<Type> KnownTypes
        {
            get 
            {
                return QueryablePivotSerializationHelper.KnownTypes;
            }
        }
    }
```

## Serialize and Deserialize 

The final step is to serialize and deserialize the data provider.

__Example 4: Serialize and Deserialize the Data Provider__

```C#

	string lastSerializedProvider;

	//serialization
	QueryableProviderSerializer serializer = new QueryableProviderSerializer();
    this.lastSerializedProvider = serializer.Serialize(this.PivotGrid.DataProvider);

	//deserialization
	QueryableProviderSerializer serializer = new QueryableProviderSerializer();
    serializer.Deserialize(this.PivotGrid.DataProvider, this.lastSerializedProvider);
```

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})

 * [Persistence]({%slug radpivotgrid-features-queryable-persistence%})