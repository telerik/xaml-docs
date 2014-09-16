Public Class Default_Vb


' #region radtreeview-populating-with-data-databinding-to-wcf-service_2
Public Class NorthwindDataSource
End Class
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_4
Public Class NorthwindDataSource
    Private serviceClient As SampleWcfServiceClient
    Public Sub New()
        serviceClient = New SampleWcfServiceClient()
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
End Class
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_7
AddHandler Me.serviceClient.LoadCategoriesCompleted, AddressOf serviceClient_LoadCategoriesCompleted
Me.serviceClient.LoadCategoriesAsync()
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_8
For Each c As Categories In serviceClient.LoadCategories()
    Me.Categories.Add(c)
Next
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_10
Private Sub serviceClient_LoadCategoriesCompleted(ByVal sender As Object, ByVal e As LoadCategoriesCompletedEventArgs)
    If e.[Error] Is Nothing AndAlso e.Result IsNot Nothing Then
        For Each c As Categories In e.Result
            Me.Categories.Add(c)
        Next
    End If
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_17
Public Sub BeginLoadingProducts(ByVal category As Categories)
    AddHandler serviceClient.LoadProductsByCategoryIdCompleted, AddressOf serviceClient_LoadProductsByCategoryIdCompleted
    serviceClient.LoadProductsByCategoryIdAsync(category.CategoryID, category)
End Sub
Private Sub serviceClient_LoadProductsByCategoryIdCompleted(ByVal sender As Object, ByVal e As LoadProductsByCategoryIdCompletedEventArgs)
    If e.[Error] Is Nothing AndAlso e.Result IsNot Nothing Then
        Dim currentCategory As Categories = TryCast(e.UserState, Categories)
        For Each p As Products In e.Result
            currentCategory.Products.Add(p)
        Next
    End If
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_18
Public Sub LoadProducts(ByVal category As Categories)
    category.Products = New ObservableCollection(Of Products)()
    For Each p As Products In serviceClient.LoadProductsByCategoryId(category.CategoryID)
        category.Products.Add(p)
    Next
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_21
Private Sub radTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
    Dim category As Categories = TryCast(item.Item, Categories)
    If category IsNot Nothing Then
        TryCast(Me.Resources("DataSource"), NorthwindDataSource).BeginLoadingProducts(category)
    Else
        item.IsLoadOnDemandEnabled = False
    End If
End Sub
' #endregion

' #region radtreeview-populating-with-data-databinding-to-wcf-service_22
Private Sub radTreeView_LoadOnDemand(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
    Dim category As Categories = TryCast(item.Item, Categories)
    If category IsNot Nothing Then
        TryCast(Me.Resources("DataSource"), NorthwindDataSource).LoadProducts(category)
    Else
        item.IsLoadOnDemandEnabled = False
    End If
End Sub
' #endregion
End Class
