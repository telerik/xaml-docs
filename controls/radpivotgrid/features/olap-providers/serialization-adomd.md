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



```VB.NET
	<DataContract> _
	Public Class DataProviderSettings
		<DataMember> _
		Public Property Aggregates() As Object()
	
		<DataMember> _
		Public Property Filters() As Object()
	
		<DataMember> _
		Public Property Rows() As Object()
	
		<DataMember> _
		Public Property Columns() As Object()
	
		<DataMember> _
		Public Property AggregatesLevel() As Integer
	
		<DataMember> _
		Public Property AggregatesPosition() As PivotAxis
	End Class
```

The next step is to implement the serializer. When serializing the provider, you have to create an instance of *DataProviderSettings* class and set all of the properties. After that you can serialize the instance to a file or a stream. When using DataContractSerializer you have to give a collection of KnownTypes to the serializer. That's why we've created a new __AdomdPivotSerializationHelper__ class which has a static member - KnownTypes. It consits of all types you'll need in order to serialize AdomdDataProvider. Here's an example how to implement your own serializer:        



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
	
	public class AdomdProviderSerializer : DataProviderSerializer
	{
	    public override IEnumerable<Type> KnownTypes
	    {
	        get
	        {
	            return AdomdPivotSerializationHelper.KnownTypes;
	        }
	    }
	}
```



```VB.NET
	Public MustInherit Class DataProviderSerializer
		Public MustOverride ReadOnly Property KnownTypes() As IEnumerable(Of Type)
	
		Public Function Serialize(ByVal context As Object) As String
			Dim serialized As String = String.Empty
	
			Dim dataProvider As IDataProvider = TryCast(context, IDataProvider)
			If dataProvider IsNot Nothing Then
				Dim stream As New MemoryStream()
	
				Dim settings As New DataProviderSettings() With {.Aggregates = dataProvider.Settings.AggregateDescriptions.OfType(Of Object)().ToArray(), .Filters = dataProvider.Settings.FilterDescriptions.OfType(Of Object)().ToArray(), .Rows = dataProvider.Settings.RowGroupDescriptions.OfType(Of Object)().ToArray(), .Columns = dataProvider.Settings.ColumnGroupDescriptions.OfType(Of Object)().ToArray(), .AggregatesLevel = dataProvider.Settings.AggregatesLevel, .AggregatesPosition = dataProvider.Settings.AggregatesPosition}
	
				Dim serializer As New DataContractSerializer(GetType(DataProviderSettings), KnownTypes)
				serializer.WriteObject(stream, settings)
	
				stream.Position = 0
				Dim streamReader = New StreamReader(stream)
				serialized &= streamReader.ReadToEnd()
			End If
	
			Return serialized
		End Function
	
		Public Sub Deserialize(ByVal context As Object, ByVal savedValue As String)
			Dim dataProvider As IDataProvider = TryCast(context, IDataProvider)
			If dataProvider IsNot Nothing Then
				Dim stream = New MemoryStream()
				Dim tw = New StreamWriter(stream)
				tw.Write(savedValue)
				tw.Flush()
				stream.Position = 0
	
				Dim serializer As New DataContractSerializer(GetType(DataProviderSettings), KnownTypes)
				Dim result = serializer.ReadObject(stream)
	
				dataProvider.Settings.AggregateDescriptions.Clear()
				For Each aggregateDescription In (TryCast(result, DataProviderSettings)).Aggregates
					dataProvider.Settings.AggregateDescriptions.Add(aggregateDescription)
				Next aggregateDescription
	
				dataProvider.Settings.FilterDescriptions.Clear()
				For Each filterDescription In (TryCast(result, DataProviderSettings)).Filters
					dataProvider.Settings.FilterDescriptions.Add(filterDescription)
				Next filterDescription
	
				dataProvider.Settings.RowGroupDescriptions.Clear()
				For Each rowDescription In (TryCast(result, DataProviderSettings)).Rows
					dataProvider.Settings.RowGroupDescriptions.Add(rowDescription)
				Next rowDescription
	
				dataProvider.Settings.ColumnGroupDescriptions.Clear()
				For Each columnDescription In (TryCast(result, DataProviderSettings)).Columns
					dataProvider.Settings.ColumnGroupDescriptions.Add(columnDescription)
				Next columnDescription
	
				dataProvider.Settings.AggregatesPosition = (TryCast(result, DataProviderSettings)).AggregatesPosition
				dataProvider.Settings.AggregatesLevel = (TryCast(result, DataProviderSettings)).AggregatesLevel
			End If
		End Sub
	End Class	
	
	Public Class AdomdProviderSerializer
		Inherits DataProviderSerializer
	
		Public Overrides ReadOnly Property KnownTypes() As IEnumerable(Of Type)
			Get
				Return AdomdPivotSerializationHelper.KnownTypes
			End Get
		End Property
	End Class
```

So the last step is to serialize the provider and deserialize it:        



```C#
	string lastSerializadProvider;
	
	//serializiation
	AdomdProviderSerializer provider = new AdomdProviderSerializer();
	this.lastSerializedProvider = provider.Serialize(this.pivot.DataProvider);
	
	//deserialization
	AdomdProviderSerializer provider = new AdomdProviderSerializer();
	provider.Deserialize(this.pivot.DataProvider, this.lastSerializedProvider);
```



```VB.NET
	Dim lastSerializadProvider As String
	
	'serializiation'
	Dim provider As New AdomdProviderSerializer()
	Me.lastSerializedProvider = provider.Serialize(Me.pivot.DataProvider)
	
	'deserialization'
	Dim provider As New AdomdProviderSerializer()
	provider.Deserialize(Me.pivot.DataProvider, Me.lastSerializedProvider)
```

## See Also

 * [AdomdDataProvider]({%slug radpivotgrid-data-adomd%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})
