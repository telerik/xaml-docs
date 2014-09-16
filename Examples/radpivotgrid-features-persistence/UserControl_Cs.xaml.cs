#region radpivotgrid-features-persistence_1
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
#endregion

#region radpivotgrid-features-persistence_2
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
#endregion

#region radpivotgrid-features-persistence_3
Stream stream = new MemoryStream();

ServiceProvider.RegisterPersistenceProvider<IValueProvider>(typeof(LocalDataSourceProvider), new LocalDataSourceValueProvider());
//saving
PersistenceManager manager = new PersistenceManager();
this.stream = manager.Save(this.pivotGrid.DataProvider);

//loading 
this.stream.Position = 0;
PersistenceManager manager = new PersistenceManager();
manager.Load(this.pivotGrid.DataProvider, this.stream);
#endregion

#region radpivotgrid-features-persistence_4
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
#endregion

#region radpivotgrid-features-persistence_5
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
#endregion