Public Class Default_Vb


' #region gridview-loading-data-from-ria-services_2
Public Class NorthwindDataSource
End Class
' #endregion

' #region gridview-loading-data-from-ria-services_4
Public Class NorthwindDataSource
    Private riaContext As SampleRiaContext
    Public Sub New()
        riaContext = New SampleRiaContext()
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

' #region gridview-loading-data-from-ria-services_6
Dim loadOperation As LoadOperation(Of Customers) = riaContext.Load(Of Customers)(riaContext.GetCustomersQuery())
AddHandler loadOperation.Completed, AddressOf loadOperation_Completed
' #endregion

' #region gridview-loading-data-from-ria-services_8
Private Sub loadOperation_Completed(ByVal sender As Object, ByVal e As EventArgs)
    'Consume the result
    For Each c As Customers In riaContext.Customers
        Me.Customers.Add(c)
    Next
End Sub
' #endregion
End Class
