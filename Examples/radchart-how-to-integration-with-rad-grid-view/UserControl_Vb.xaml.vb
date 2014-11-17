Public Class Default_Vb


' #region radchart-how-to-integration-with-rad-grid-view_3
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("http://localhost:52981/Services/SampleAdoNetDataService.svc/"))
        Me.Products = New ObservableCollection(Of Products)()
        Dim query = From p In northwindEntity.Products _
            Select p
        Dim products As DataServiceQuery(Of Products) = DirectCast(query, DataServiceQuery(Of Products))
        products.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, Me.Products), products)
    End Sub
Private _Products As ObservableCollection(Of Products)
    Public Property Products() As ObservableCollection(Of Products)
        Get
            Return _Products
        End Get
        Set(ByVal value As ObservableCollection(Of Products))
            _Products = value
        End Set
    End Property
    Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
        Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
        For Each entity As T In query.EndExecute(result)
            entities.Add(entity)
        Next
    End Sub
End Class
' #endregion

' #region radchart-how-to-integration-with-rad-grid-view_4
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("http://localhost:52981/Services/SampleAdoNetDataService.svc/"))
        Me.Products = New ObservableCollection(Of Products)()
                For Each p As Products In northwindEntity.Products.Execute()
            Me.Products.Add(p)
        Next
    End Sub
Private _Products As ObservableCollection(Of Products)
    Public Property Products() As ObservableCollection(Of Products)
        Get
            Return _Products
        End Get
        Set(ByVal value As ObservableCollection(Of Products))
            _Products = value
        End Set
    End Property
End Class
' #endregion

' #region radchart-how-to-integration-with-rad-grid-view_9
Private Sub radGridView_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangeEventArgs)
    Dim selectedList As New Collection(Of Products)()
    ' Get all selected Items
    For Each product As Products In radGridView.SelectedItems
        selectedList.Add(DirectCast(item, Products))
    Next
    CreateSeriesMappings(selectedList)
    SetChartItemsSource(selectedList)
End Sub
' #endregion

' #region radchart-how-to-integration-with-rad-grid-view_11
Private Sub CreateSeriesMappings(ByVal invoicesList As Collection(Of Products))
    radChart.SeriesMappings.Clear()
    Dim seriesMapping As New SeriesMapping()
    seriesMapping.SeriesDefinition = If(invoicesList.Count < 2, DirectCast(New BarSeriesDefinition(), ISeriesDefinition), DirectCast(New LineSeriesDefinition(), ISeriesDefinition))
    seriesMapping.LegendLabel = "Product In Stock"
    Dim itemMapping As New ItemMapping()
    itemMapping.DataPointMember = DataPointMember.YValue
    itemMapping.FieldName = "UnitsInStock"
    seriesMapping.ItemMappings.Add(itemMapping)
    Dim seriesMapping1 As New SeriesMapping()
    seriesMapping1.SeriesDefinition = If(invoicesList.Count < 2, DirectCast(New BarSeriesDefinition(), ISeriesDefinition), DirectCast(New LineSeriesDefinition(), ISeriesDefinition))
    seriesMapping1.LegendLabel = "Product Price"
    Dim itemMapping1 As New ItemMapping()
    itemMapping1.DataPointMember = DataPointMember.YValue
    itemMapping1.FieldName = "UnitPrice"
    seriesMapping1.ItemMappings.Add(itemMapping1)
    radChart.SeriesMappings.Add(seriesMapping)
    radChart.SeriesMappings.Add(seriesMapping1)
End Sub
' #endregion

' #region radchart-how-to-integration-with-rad-grid-view_13
Private Sub SetChartItemsSource(ByVal invoicesList As Collection(Of Products))
    radChart.ItemsSource = invoicesList
End Sub
' #endregion
End Class
