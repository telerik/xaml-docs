#region radpivotgrid-features-chartview_1
public PivotChartUserControl()
{
    InitializeComponent();
    var chartViewModel = new PivotChartViewModel();
    chartViewModel.DataProvider = this.DataProvider;
    this.DataContext = chartViewModel;
}
#endregion

#region radpivotgrid-features-chartview_2
LocalDataSourceProvider localDataProvider = new LocalDataSourceProvider();
localDataProvider.ItemsSource = MyCollection;
this.radPivotGrid1.DataProvider = localDataProvider;
this.radPivotFieldList1.DataProvider = localDataProvider;
#endregion

#region radpivotgrid-features-chartview_3
Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propertyGroupDescription.PropertyName = "Name";
DateTimeGroupDescription dateTimeGroupDescription = new DateTimeGroupDescription();
dateTimeGroupDescription.PropertyName = "Date";
dateTimeGroupDescription.Step = DateTimeStep.Month;

using (localDataProvider.DeferRefresh())
{
    localDataProvider.RowGroupDescriptions.Add(propertyGroupDescription);
    localDataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription);
};
#endregion

#region radpivotgrid-features-chartview_4
public class SeriesSourceNameToSeriesLegendSettigsConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return new SeriesLegendSettings() 
        { 
            Title = value.ToString() 
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
#endregion

#region radpivotgrid-features-chartview_5
PropertyAggregateDescription propertyAggregateDescription1 = new PropertyAggregateDescription();
propertyAggregateDescription1.PropertyName = "Price";
propertyAggregateDescription1.StringFormat = "C";
propertyAggregateDescription1.AggregateFunction = AggregateFunctions.Average;

PropertyAggregateDescription propertyAggregateDescription2 = new PropertyAggregateDescription();
propertyAggregateDescription2.PropertyName = "Quantity";

using (localDataProvider.DeferRefresh())
{
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription1);
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription2);
};
#endregion

#region radpivotgrid-features-chartview_6
TextCondition txtCondition = new TextCondition();
txtCondition.Comparison = TextComparison.BeginsWith;
txtCondition.Pattern = "N";

PropertyFilterDescription filterDescription = new PropertyFilterDescription();
filterDescription.PropertyName = "Name";
filterDescription.Condition = txtCondition;
localDataProvider.FilterDescriptions.Add(filterDescription);
#endregion