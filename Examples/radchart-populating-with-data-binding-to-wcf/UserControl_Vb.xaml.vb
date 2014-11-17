Public Class Default_Vb


' #region radchart-populating-with-data-binding-to-wcf_3
<ServiceContract(Namespace = ""), AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)>
Public Class Service2
            <OperationContract>
            Public Function LoadTop10Products() As List(Of Product)
                  Dim db As New DataClasses1DataContext()
                  Dim query = From c In db.Products
                              Select c
                  Return query.Take(10).ToList()
            End Function
End Class
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_5
Dim MyService.Service2Client As New MyService.Service2Client()
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_7
InitializeComponent()
Dim client As New MyService.Service2Client()
AddHandler client.LoadTop10ProductsCompleted, AddressOf client_LoadTop10ProductsCompleted
client.LoadTop10ProductsAsync()
void client_LoadTop10ProductsCompleted(Object sender, LoadTop10ProductsCompletedEventArgs e)　
Dim products = e.Result
Me.radChart.ItemsSource = products
Me.radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = -90
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_9
radChart.ItemsSource = serviceClient.LoadTop10Products()
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_11
Public Class NorthwindDataSource
End Class
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_13
Public Class NorthwindDataSource
    Private serviceClient As SampleWcfServiceClient
    Public Sub New()
        Me.serviceClient = New SampleWcfServiceClient()
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

' #region radchart-populating-with-data-binding-to-wcf_16
AddHandler Me.serviceClient.LoadTop10ProductsCompleted, AddressOf serviceClient_LoadTop10ProductsCompleted
Me.serviceClient.LoadTop10ProductsAsync()
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_17
For Each p As Products In serviceClient.LoadTop10Products()
    Me.Products.Add(p)
Next
' #endregion

' #region radchart-populating-with-data-binding-to-wcf_19
Private Sub serviceClient_LoadTop10ProductsCompleted(ByVal sender As Object, ByVal e As LoadTop10ProductsCompletedEventArgs)
    For Each p As Products In e.Result
        Me.Products.Add(p)
    Next
End Sub
' #endregion
End Class
