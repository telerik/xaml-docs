Public Class Default_Vb


' #region gridview-in-memory-date_2
Public Class Car
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal description As String)
        Me.Name = name
        Me.Description = description
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
Private _Description As String
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-in-memory-date_4
Public Class RadGridViewSampleData
End Class
' #endregion

' #region gridview-in-memory-date_6
Public Class RadGridViewSampleData
    Public Sub New()
        Cars = New ObservableCollection(Of Car)()
    End Sub
Private _Cars As ObservableCollection(Of Car)
    Public Property Cars() As ObservableCollection(Of Car)
        Get
            Return _Cars
        End Get
        Set(ByVal value As ObservableCollection(Of Car))
            _Cars = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-in-memory-date_8
Cars.Add(New Car("BMW", "A german luxury car."))
Cars.Add(New Car("Porsche", "A german sports car."))
Cars.Add(New Car("Citroen", "A french luxury car."))
Cars.Add(New Car("Reno", "A french family car."))
' #endregion
End Class
