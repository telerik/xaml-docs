Public Class Default_Vb


' #region gridview-loading-data-from-wcf-services_2
Dim serviceClient As New WcfServiceClient()
' #endregion

' #region gridview-loading-data-from-wcf-services_4
Private Sub BeginRequest()
    AddHandler serviceClient.LoadCustomersCompleted, AddressOf serviceClient_LoadCustomersCompleted
    serviceClient.LoadCustomersAsync()
End Sub
Private Sub serviceClient_LoadCustomersCompleted(ByVal sender As Object, ByVal e As RadGridViewServices.GridViewWcfService.LoadCustomersCompletedEventArgs)
    Dim customers = e.Result
    Me.radGridView.ItemsSource = customers
End Sub
' #endregion

' #region gridview-loading-data-from-wcf-services_6
Dim serviceClient As New WcfServiceClient()
Me.radGridView.ItemsSource = serviceClient.LoadCustomers()
' #endregion

' #region gridview-loading-data-from-wcf-services_8
Public Class NorthwindDataSource
End Class
' #endregion

' #region gridview-loading-data-from-wcf-services_10
Public Class NorthwindDataSource
    Private serviceClient As SampleWcfServiceClient
    Public Sub New()
        serviceClient = New SampleWcfServiceClient()
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

' #region gridview-loading-data-from-wcf-services_13
AddHandler serviceClient.LoadCustomersCompleted, AddressOf serviceClient_LoadCustomersCompleted
serviceClient.LoadCustomersAsync()
' #endregion

' #region gridview-loading-data-from-wcf-services_14
For Each c As Customers In serviceClient.LoadCustomers()
    Me.Customers.Add(c)
Next
' #endregion

' #region gridview-loading-data-from-wcf-services_16
Private Sub serviceClient_LoadCustomersCompleted(ByVal sender As Object, ByVal e As LoadCustomersCompletedEventArgs)
    If e.[Error] Is Nothing AndAlso e.Result IsNot Nothing Then
        For Each c As Customers In e.Result
            Me.Customers.Add(c)
        Next
    End If
End Sub
' #endregion
End Class
