Public Class Default_Vb


' #region radchart-populating-with-data-binding-to-adonet-service_3
Public Class ProductDetail
Public Property UnitPrice() As Decimal?
Public Sub New(ByVal unitPrice? As Decimal)
Me.UnitPrice = unitPrice
End Sub
End Class
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_5
Dim dbContext As New DataServiceContext(New Uri("SampleAdoNetDataService.svc", UriKind.Relative))
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_7
Dim dbContext As New NorthwindEntities(New Uri("Enter your service address here"))
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_9
Private Sub BeginRequest()
    Dim query As DataServiceQuery(Of Products) = dbContext.CreateQuery(Of Products)("Products")
    query.BeginExecute(RequestCompleted, query)
End Sub
Private Sub ProductsRequestCompleted(ByVal asyncResult As IAsyncResult)
    Dim query As DataServiceQuery(Of Product) = TryCast(asyncResult.AsyncState, DataServiceQuery(Of Product))
    products = query.EndExecute(asyncResult).ToList()
    Dim result As New List(Of ProductDetail)()
   For Each p As Product In products.Take(10)
    result.Add(New ProductDetail(p.UnitPrice))
      Next p
    RadChart1.ItemsSource = result
  End Sub
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_11
Me.radChart.ItemsSource = dbContext.Products.Execute().Take(10).ToList()
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_13
Public Class NorthwindDataSource
End Class
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_15
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("SampleAdoNetDataService.svc", UriKind.Relative))
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
End Class
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_17
Dim query = (From p In northwindEntity.Products _
    Select p).Take(10)
Dim products As DataServiceQuery(Of Products) = DirectCast(query, DataServiceQuery(Of Products))
products.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, Me.Products), products)
For Each p As Products In query.ToList()
    Me.Products.Add(p)
Next
' #endregion

' #region radchart-populating-with-data-binding-to-adonet-service_19
Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
    For Each entity As T In query.EndExecute(result)
        entities.Add(entity)
    Next
End Sub
' #endregion
End Class
