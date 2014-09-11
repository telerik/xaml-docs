' #region radpivotgrid-features-chartview_1
Public Sub New()
	InitializeComponent()
	Dim chartViewModel = New PivotChartViewModel()
	chartViewModel.DataProvider = Me.DataProvider
	Me.DataContext = chartViewModel
End Sub
' #endregion

' #region radpivotgrid-features-chartview_2
Dim localDataProvider As New LocalDataSourceProvider()
localDataProvider.ItemsSource = MyCollection
Me.radPivotGrid1.DataProvider = localDataProvider
Me.radPivotFieldList1.DataProvider = localDataProvider
' #endregion

' #region radpivotgrid-features-chartview_3
Dim propertyGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propertyGroupDescription.PropertyName = "Name"
Dim dateTimeGroupDescription As New DateTimeGroupDescription()
dateTimeGroupDescription.PropertyName = "Date"
dateTimeGroupDescription.Step = DateTimeStep.Month
Using localDataProvider.DeferRefresh()
    localDataProvider.RowGroupDescriptions.Add(propertyGroupDescription)
    localDataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription)
End Using
' #endregion

' #region radpivotgrid-features-chartview_4
Public Class SeriesSourceNameToSeriesLegendSettigsConverter
	Implements IValueConverter

	Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
		Return New SeriesLegendSettings() With {.Title = value.ToString()}
	End Function

	Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
		Throw New NotImplementedException()
	End Function
End Class
' #endregion

' #region radpivotgrid-features-chartview_5
Dim propertyAggregateDescription1 As New PropertyAggregateDescription()
propertyAggregateDescription1.PropertyName = "Price"
propertyAggregateDescription1.StringFormat = "C"
propertyAggregateDescription1.AggregateFunction = AggregateFunctions.Average

Dim propertyAggregateDescription2 As New PropertyAggregateDescription()
propertyAggregateDescription2.PropertyName = "Quantity"

Using localDataProvider.DeferRefresh()
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription1)
    localDataProvider.AggregateDescriptions.Add(propertyAggregateDescription2)
End Using   
' #endregion

'#region "radpivotgrid-features-chartview_6"
Dim txtCondition As New TextCondition()
txtCondition.Comparison = TextComparison.BeginsWith
txtCondition.Pattern = "N"

Dim filterDescription As New PropertyFilterDescription()
filterDescription.PropertyName = "Name"
filterDescription.Condition = txtCondition
localDataProvider.FilterDescriptions.Add(filterDescription)
'#endregion