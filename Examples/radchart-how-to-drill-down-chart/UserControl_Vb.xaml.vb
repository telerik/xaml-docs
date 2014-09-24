Public Class Default_Vb


' #region radchart-how-to-drill-down-chart_5
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("http://localhost:52981/Services/SampleAdoNetDataService.svc/"))
        Me.Products = New ObservableCollection(Of Products)()
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
Private _OrderDetails As ObservableCollection(Of Order_Details)
    Public Property OrderDetails() As ObservableCollection(Of Order_Details)
        Get
            Return _OrderDetails
        End Get
        Set(ByVal value As ObservableCollection(Of Order_Details))
            _OrderDetails = value
        End Set
    End Property
End Class
' #endregion

' #region radchart-how-to-drill-down-chart_8
Public Sub New()
    northwindEntity = New NorthwindEntities(New Uri("http://localhost:52981/Services/SampleAdoNetDataService.svc/"))
    Me.Products = New ObservableCollection(Of Products)()
    Dim query = (From p In northwindEntity.Products _
        Select p).Take(8)
    Dim products As DataServiceQuery(Of Products) = DirectCast(query, DataServiceQuery(Of Products))
    products.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, Me.Products), products)
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_9
Public Sub New()
    northwindEntity = New NorthwindEntities(New Uri("http://localhost:52981/Services/SampleAdoNetDataService.svc/"))
    Me.Products = New ObservableCollection(Of Products)()
    For Each p As Products In northwindEntity.Products.Execute().Take(8)
        Me.Products.Add(p)
    Next
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_11
Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
    For Each entity As T In query.EndExecute(result)
        entities.Add(entity)
    Next
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_14
Public Shared Sub BeginLoadingOrderDetails(ByVal p As Products, ByVal rowCount As Integer)
    Dim query = (From od In northwindEntity.Order_Details.Expand("Orders") _
        Where od.ProductID = p.ProductID _
        Select od)
    If rowCount > -1 Then
        query = query.Take(rowCount)
    End If
    Dim orderDetails As DataServiceQuery(Of Order_Details) = DirectCast(query, DataServiceQuery(Of Order_Details))
    orderDetails.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Order_Details)(result, p.Order_Details), orderDetails)
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_15
Public Shared Sub LoadOrderDetails(ByVal p As Products, ByVal rowCount As Integer)
    Dim query = (From od In northwindEntity.Order_Details.Expand("Orders") _
        Where od.ProductID = p.ProductID _
        Select od)
    If rowCount > -1 Then
        query = query.Take(rowCount)
    End If
    For Each orderDetail As Order_Details In query.ToList()
        p.Order_Details.Add(orderDetail)
    Next
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_20
Private Sub ChartArea_ItemToolTipOpening(ByVal tooltip As ItemToolTip2D, ByVal e As ItemToolTipEventArgs)
    Dim p As Products = TryCast(e.DataPoint.DataItem, Products)
    p.Order_Details = New ObservableCollection(Of Order_Details)()
    NorthwindDataSource.BeginLoadingOrderDetails(p, 6)
    Dim toolTipControl As New DrillDownChartToolTip()
    toolTipControl.DataContext = p.Order_Details
    tooltip.Content = toolTipControl
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_21
Private Sub ChartArea_ItemToolTipOpening(ByVal tooltip As ItemToolTip2D, ByVal e As ItemToolTipEventArgs)
    Dim p As Products = TryCast(e.DataPoint.DataItem, Products)
    p.Order_Details = New ObservableCollection(Of Order_Details)()
    NorthwindDataSource.LoadOrderDetails( p, 6 )
    Dim toolTipControl As New DrillDownChartToolTip()
    toolTipControl.DataContext = p.Order_Details
    tooltip.Content = toolTipControl
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_23
Dim p As Products = TryCast(e.DataPoint.DataItem, Products)
' #endregion

' #region radchart-how-to-drill-down-chart_28
Private Sub ChartArea_ItemClick(ByVal sender As Object, ByVal e As ChartItemClickEventArgs)
    ' Get the product and load all order details
    Dim selectedItem As Products = TryCast(e.DataPoint.DataItem, Products)
    selectedItem.Order_Details = New ObservableCollection(Of Order_Details)()
    radChart.ItemsSource = selectedItem.Order_Details
    NorthwindDataSource.BeginLoadingOrderDetails(selectedItem, -1)
    ' Change the chart title
    radChart.DefaultView.ChartTitle.Content = "Financial Report"
    radChart.SeriesMappings.Clear()
    ' Change the Item mapping
    Dim newSeriesMapping As New SeriesMapping()
    newSeriesMapping.LegendLabel = "Quantity"
    Dim newItemMapping As New ItemMapping()
    newItemMapping.FieldName = "Quantity"
    newItemMapping.DataPointMember = DataPointMember.YValue
    newSeriesMapping.ItemMappings.Add(newItemMapping)
    radChart.SeriesMappings.Add(newSeriesMapping)
End Sub
' #endregion

' #region radchart-how-to-drill-down-chart_29
Private Sub ChartArea_ItemClick(ByVal sender As Object, ByVal e As ChartItemClickEventArgs)
    ' Get the product and load all order details
    Dim selectedItem As Products = TryCast(e.DataPoint.DataItem, Products)
    selectedItem.Order_Details = New ObservableCollection(Of Order_Details)()
    radChart.ItemsSource = selectedItem.Order_Details
    NorthwindDataSource.LoadOrderDetails( selectedItem, -1 )
    ' Change the chart title
    radChart.DefaultView.ChartTitle.Content = "Financial Report"
    radChart.SeriesMappings.Clear()
    ' Change the Item mapping
    Dim newSeriesMapping As New SeriesMapping()
    newSeriesMapping.LegendLabel = "Quantity"
    Dim newItemMapping As New ItemMapping()
    newItemMapping.FieldName = "Quantity"
    newItemMapping.DataPointMember = DataPointMember.YValue
    newSeriesMapping.ItemMappings.Add(newItemMapping)
    radChart.SeriesMappings.Add(newSeriesMapping)
End Sub
' #endregion
End Class
