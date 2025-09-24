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

The next step is to create a new class, which implements __Telerik.Windows.Persistence.Services.IValueProvider__. *IValueProvider* has two methods that you will have to implement - *ProvideValue* and *RestoreValue*. The first one is used when the data is saved. The second one is used when the data is restored from a previously saved state. When saving the provider, you have to create an instance of *DataProviderSettings* class and set all of the properties. After that you can save the instance to a file or a stream. When using DataContractSerializer you have to give a collection of KnownTypes to the serializer. That's why we've created a new __PivotSerializationHelper__ class which has a static member - KnownTypes. It consists of all types you'll need in order to serialize LocalDataSourceProvider. Here's an example how to implement it:        



```C#
	public abstract class DataProviderValueProvider : IValueProvider
	{
	    public abstract IEnumerable<Type> KnownTypes { get; }
	
	    public string ProvideValue(object context)
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
	
	    public void RestoreValue(object context, string savedValue)
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
	
	
	public class LocalDataSourceValueProvider : DataProviderValueProvider
	{
	    public override IEnumerable<Type> KnownTypes
	    {
	        get
	        {
	            return PivotSerializationHelper.KnownTypes;
	        }
	    }
	}
```



```VB.NET
	Public MustInherit Class DataProviderValueProvider
		Implements IValueProvider
	
		Public MustOverride ReadOnly Property KnownTypes() As IEnumerable(Of Type)
	
		Public Function ProvideValue(ByVal context As Object) As String
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
	
		Public Sub RestoreValue(ByVal context As Object, ByVal savedValue As String)
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
	
	
	Public Class LocalDataSourceValueProvider
		Inherits DataProviderValueProvider
	
		Public Overrides ReadOnly Property KnownTypes() As IEnumerable(Of Type)
			Get
				Return PivotSerializationHelper.KnownTypes
			End Get
		End Property
	End Class
```

So the last step is to register a persistence provider and implement the logic to save and load the state of LocalDataSourceProvider:        



```C#
	Stream stream = new MemoryStream();
	
	ServiceProvider.RegisterPersistenceProvider<IValueProvider>(typeof(LocalDataSourceProvider), new LocalDataSourceValueProvider());
	//saving
	PersistenceManager manager = new PersistenceManager();
	this.stream = manager.Save(this.pivotGrid.DataProvider);
	
	//loading 
	this.stream.Position = 0;
	PersistenceManager manager = new PersistenceManager();
	manager.Load(this.pivotGrid.DataProvider, this.stream);
```



```VB.NET
	Dim stream As Stream = New MemoryStream()
	
	ServiceProvider.RegisterPersistenceProvider(Of IValueProvider)(GetType(LocalDataSourceProvider), New LocalDataSourceValueProvider())
	'saving
	Dim manager As New PersistenceManager()
	Me.stream = manager.Save(Me.pivotGrid.DataProvider)
	
	'loading 
	Me.stream.Position = 0
	Dim manager As New PersistenceManager()
	manager.Load(Me.pivotGrid.DataProvider, Me.stream)
```

## Persist custom types

If you have implemented your own custom types, for example CustomGroupDescription, and you want to persist your data, you have to do the following:        

* Set the DataContract attribute on each of your custom classes.            

* Set the DataMember attribute on each of the properties that you want to serialize.            

* Add all custom classes to the KnownTypes collection.            

So if you have implemented a custom group description, it should be similar to this:        



```C#
	[DataContract]
	public class CustomGroupDescription : PropertyGroupDescriptionBase
	{
	    [DataMember]
	    public string MyCustomProperty { get; set; }
	
	    protected override void CloneOverride(Cloneable source)
	    {
	        this.MyCustomProperty = (source as CustomGroupDescription).MyCustomProperty;
	    }
	
	    protected override Cloneable CreateInstanceCore()
	    {
	        return new CustomGroupDescription();
	    }
	}
```



```VB.NET
	<DataContract> _
	Public Class CustomGroupDescription
		Inherits PropertyGroupDescriptionBase
	
		<DataMember> _
		Public Property MyCustomProperty() As String
	
		Protected Overrides Sub CloneOverride(ByVal source As Cloneable)
			Me.MyCustomProperty = (TryCast(source, CustomGroupDescription)).MyCustomProperty
		End Sub
	
		Protected Overrides Function CreateInstanceCore() As Cloneable
			Return New CustomGroupDescription()
		End Function
	End Class
```

And here's the change in *LocalDataSourceValueProvider* class:        



```C#
	public class LocalDataSourceValueProvider : DataProviderValueProvider
	{
	    private IEnumerable<Type> myKnownTypes = PivotSerializationHelper.KnownTypes.Concat<Type>(new List<Type>() { typeof(CustomGroupDescription) });
	        
	    public override IEnumerable<Type> KnownTypes
	    {
	        get
	        {
	            return myKnownTypes;
	        }
	    }
	}
```



```VB.NET
	Public Class LocalDataSourceValueProvider
		Inherits DataProviderValueProvider
	
		Private myKnownTypes As IEnumerable(Of Type) = PivotSerializationHelper.KnownTypes.Concat(New List(Of Type)() From {GetType(CustomGroupDescription)})
	
		Public Overrides ReadOnly Property KnownTypes() As IEnumerable(Of Type)
			Get
				Return myKnownTypes
			End Get
		End Property
	End Class
```

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [LocalDataSourceProvider]({%slug radpivotgrid-data-localdatasource%})

 * [Features]({%slug radpivotgrid-features%})

 * [Serialization]({%slug radpivotgrid-features-serialization%})