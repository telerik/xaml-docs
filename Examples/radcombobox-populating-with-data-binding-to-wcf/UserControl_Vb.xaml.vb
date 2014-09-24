Public Class Default_Vb


' #region radcombobox-populating-with-data-binding-to-wcf_2
Dim serviceClient As New ComboBoxWcfServiceClient()
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_4
Private Sub BeginRequest()
    AddHandler serviceClient.GetProductsCompleted, AddressOf serviceClient_GetProductsCompleted
    serviceClient.GetProductsAsync()
End Sub
Private Sub serviceClient_GetProductsCompleted(ByVal sender As Object, ByVal e As GetProductsCompletedEventArgs)
    radComboBox.ItemsSource = e.Result
End Sub
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_6
Private Sub BeginRequest()
    Me.radComboBox.ItemsSource = serviceClient.GetProducts()
End Sub
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_10
Public Class NorthwindDataSource
End Class
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_12
Public Class NorthwindDataSource
    Private serviceClient As ComboBoxWcfServiceClient
    Public Sub New()
        Me.Products = New ObservableCollection(Of Products)()
        Me.serviceClient = New ComboBoxWcfServiceClient()
    End Sub
Private _Products As ObservableCollection(Of Products)
    Public Property Products() As ObservableCollection(Of Products)
        Get
            Return _Products
        End Get
        Protected Set(ByVal value As ObservableCollection(Of Products))
            _Products = value
        End Set
    End Property
End Class
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_14
AddHandler Me.serviceClient.GetProductsCompleted, AddressOf serviceClient_GetProductsCompleted
Me.serviceClient.GetProductsAsync()
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_16
Private Sub serviceClient_GetProductsCompleted(ByVal sender As Object, ByVal e As GetProductsCompletedEventArgs)
    For Each p As Products In e.Result
        Me.Products.Add(p)
    Next
End Sub
' #endregion

' #region radcombobox-populating-with-data-binding-to-wcf_18
For Each p As Products In serviceClient.GetProducts()
    Me.Products.Add(p)
Next
' #endregion
End Class
