Public Class Default_Vb


' #region radtreeview-populating-with-data-databinding-to-adonet-service_2
Public Class NorthwindDataSource
End Class
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_4
Private northwindEntity As NorthwindEntities
Public Sub New()
    Me.northwindEntity = New NorthwindEntities(New Uri("Enter your service address here"))
    Me.Categories = New ObservableCollection(Of Categories)()
End Sub
Private _Categories As ObservableCollection(Of Categories)
Public Property Categories() As ObservableCollection(Of Categories)
    Get
        Return _Categories
    End Get
    Set(ByVal value As ObservableCollection(Of Categories))
        _Categories = value
    End Set
End Property
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_7
northwindEntity.Categories.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Categories)(result, Me.Categories), northwindEntity.Categories)
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_8
For Each c As Categories In northwindEntity.Categories.Execute()
    Me.Categories.Add(c)
Next
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_10
Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
    For Each entity As T In query.EndExecute(result)
        entities.Add(entity)
    Next
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_17
Public Shared Sub BeginLoadingProducts(ByVal category As Categories)
    Dim categoryProducts As DataServiceQuery(Of Products) = northwindEntity.CreateQuery(Of Products)(String.Format("Categories({0})/Products", category.CategoryID)).Expand("Suppliers").Expand("Categories")
    categoryProducts.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, category.Products), categoryProducts)
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_18
Public Shared Sub LoadProducts(ByVal category As Categories)
    Dim categoryProducts As DataServiceQuery(Of Products) = northwindEntity.CreateQuery(Of Products)(String.Format("Categories({0})/Products", category.CategoryID)).Expand("Suppliers").Expand("Categories")
    category.Products = New ObservableCollection(Of Products)()
    For Each p As Products In categoryProducts.Execute()
        category.Products.Add(p)
    Next
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_21
Private Sub radTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
    Dim category As Categories = TryCast(item.Item, Categories)
    If category IsNot Nothing Then
        NorthwindDataSource.BeginLoadingProducts(category)
    Else
        item.IsLoadOnDemandEnabled = False
    End If
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-adonet-service_22
Private Sub radTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
    Dim category As Categories = TryCast(item.Item, Categories)
    If category IsNot Nothing Then
        NorthwindDataSource.LoadProducts(category)
    Else
        item.IsLoadOnDemandEnabled = False
    End If
End Sub
' #endregion
End Class
