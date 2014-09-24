Public Class Default_Vb


' #region common-data-binding-data-templates_2
Me.listBox.ItemsSource = Me.CreateSampleData()
' #endregion

' #region common-data-binding-data-templates_4
Public Class MyData
    Public Sub New(ByVal color As String)
        Me.Color = color
    End Sub
Private _Color As String
    Public Property Color() As String
        Get
            Return _Color
        End Get
        Set(ByVal value As String)
            _Color = value
        End Set
    End Property
End Class
' #endregion
End Class
