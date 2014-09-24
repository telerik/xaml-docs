Public Class Default_Vb


' #region radchart-populating-with-data-data-binding-with-automatic-series-binding_1
Dim dataArray As Integer() = New Integer() {12, 56, 23, 89, 12, 56, 34, 78, 32, 56}
' #endregion

' #region radchart-populating-with-data-data-binding-with-automatic-series-binding_3
radChart.ItemsSource = dataArray
' #endregion

' #region radchart-populating-with-data-data-binding-with-automatic-series-binding_5
Dim data As New List(Of Manufacturer)()
data.Add(New Manufacturer("Toyota", 215, 462))
data.Add(New Manufacturer("General Motors", 192, 345))
data.Add(New Manufacturer("Volkswagen", 151, 310))
data.Add(New Manufacturer("Ford", 125, 340))
data.Add(New Manufacturer("Honda", 91, 201))
data.Add(New Manufacturer("Nissan", 79, 145))
data.Add(New Manufacturer("PSA", 79, 175))
data.Add(New Manufacturer("Hyundai", 64, 133))
Me.telerkChart.ItemsSource = data
' #endregion

' #region radchart-populating-with-data-data-binding-with-automatic-series-binding_7
Public Class Manufacturer
    Public Sub New(ByVal name As String, ByVal sales As Integer, ByVal turnover As Integer)
        Me.Name = name
        Me.Sales = sales
        Me.Turnover = turnover
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Sales As Integer
    Public Property Sales() As Integer
        Get
            Return _Sales
        End Get
        Set(ByVal value As Integer)
            _Sales = value
        End Set
    End Property
Private _Turnover As Integer
    Public Property Turnover() As Integer
        Get
            Return _Turnover
        End Get
        Set(ByVal value As Integer)
            _Turnover = value
        End Set
    End Property
End Class
' #endregion
End Class
