Public Class Default_Vb


' #region gridview-loading-data-from-adonet-services_3
Dim dbContext As New NorthwindEntities(New Uri("GridViewDataService.svc", UriKind.Relative))
' #endregion

' #region gridview-loading-data-from-adonet-services_4
Dim dbContext As New NorthwindEntities(New Uri("Enter your service address here"))
' #endregion

' #region gridview-loading-data-from-adonet-services_6
Private Sub BeginRequest()
    Dim query As DataServiceQuery(Of Customers) = dbContext.CreateQuery(Of Customers)("Customers")
    query.BeginExecute(RequestCompleted, query)
End Sub
Private Sub RequestCompleted(ByVal asyncResult As IAsyncResult)
    Dim query As DataServiceQuery(Of Customers) = TryCast(asyncResult.AsyncState, DataServiceQuery(Of Customers))
    Dim customers = query.EndExecute(asyncResult).ToList()
    Me.radGridView.ItemsSource = customers
End Sub
' #endregion

' #region gridview-loading-data-from-adonet-services_8
Me.radGridView.ItemsSource = dbContext.Customers.Execute().ToList()
' #endregion

' #region gridview-loading-data-from-adonet-services_10
Public Class NorthwindDataSource
End Class
' #endregion

' #region gridview-loading-data-from-adonet-services_12
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("GridViewDataService.svc", UriKind.Relative))
        Me.Customers = New ObservableCollection(Of Customers)()
    End Sub
Private _Customers As ObservableCollection(Of Customers)
    Public Property Customers() As ObservableCollection(Of Customers)
        Get
            Return _Customers
        End Get
        Set(ByVal value As ObservableCollection(Of Customers))
            _Customers = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-loading-data-from-adonet-services_14
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("Enter your service address here"))
        Me.Customers = New ObservableCollection(Of Customers)()
    End Sub
Private _Customers As ObservableCollection(Of Customers)
    Public Property Customers() As ObservableCollection(Of Customers)
        Get
            Return _Customers
        End Get
        Set(ByVal value As ObservableCollection(Of Customers))
            _Customers = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-loading-data-from-adonet-services_17
northwindEntity.Customers.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Customers)(result, Me.Customers), northwindEntity.Customers)
' #endregion

' #region gridview-loading-data-from-adonet-services_18
For Each c As Customers In northwindEntity.Customers.Execute()
    Me.Customers.Add(c)
Next
' #endregion

' #region gridview-loading-data-from-adonet-services_20
Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
    For Each entity As T In query.EndExecute(result)
        entities.Add(entity)
    Next
End Sub
' #endregion
End Class
