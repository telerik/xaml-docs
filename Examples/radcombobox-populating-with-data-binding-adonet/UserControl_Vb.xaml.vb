Public Class Default_Vb


' #region radcombobox-populating-with-data-binding-adonet_2
Dim dbContext As New NorthwindEntities(New Uri("Enter your service address here"))
' #endregion

' #region radcombobox-populating-with-data-binding-adonet_4
Private Sub BeginRequest()
    Dim query As DataServiceQuery(Of Products) = dbContext.CreateQuery(Of Products)("Products")
    query.BeginExecute(RequestCompleted, query)
End Sub
Private Sub RequestCompleted(ByVal asyncResult As IAsyncResult)
    Dim query As DataServiceQuery(Of Products) = TryCast(asyncResult.AsyncState, DataServiceQuery(Of Products))
    Dim products = query.EndExecute(asyncResult).ToList()
    Me.radComboBox.ItemsSource = products
End Sub
' #endregion

' #region radcombobox-populating-with-data-binding-adonet_6
Me.radComboBox.ItemsSource = dbContext.Products.Execute()
' #endregion

' #region radcombobox-populating-with-data-binding-adonet_10
Public Class NorthwindDataSource
End Class
' #endregion

' #region radcombobox-populating-with-data-binding-adonet_12
Public Class NorthwindDataSource
    Private Shared northwindEntity As NorthwindEntities
    Public Sub New()
        northwindEntity = New NorthwindEntities(New Uri("Enter your service address here"))
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

' #region radcombobox-populating-with-data-binding-adonet_14
northwindEntity.Products.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, Me.Products), northwindEntity.Products)
' #endregion

' #region radcombobox-populating-with-data-binding-adonet_16
Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
    For Each entity As T In query.EndExecute(result)
        entities.Add(entity)
    Next
End Sub
' #endregion

' #region radcombobox-populating-with-data-binding-adonet_18
For Each p As Products In northwindEntity.Products.Execute()
    Me.Products.Add(p)
Next
' #endregion
End Class
