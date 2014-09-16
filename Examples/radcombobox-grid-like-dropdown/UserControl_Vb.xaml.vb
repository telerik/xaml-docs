Public Class Default_Vb


' #region radcombobox-grid-like-dropdown_1
Public Class Dealer
    Public Sub New(ByVal name As String, ByVal description As String, ByVal phone As String)
        Me.Name = name
        Me.Description = description
        Me.Phone = phone
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
Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
End Class
' #endregion

' #region radcombobox-grid-like-dropdown_3
Public Class DealerViewModel
    Private m_dealers As ObservableCollection(Of Dealer)
    Public ReadOnly Property Dealers() As ObservableCollection(Of Dealer)
        Get
            If m_dealers Is Nothing Then
                Me.CraeteDealers()
            End If
            Return m_dealers
        End Get
    End Property
    Private Sub CraeteDealers()
        Me.m_dealers = New ObservableCollection(Of Dealer)()
        Me.m_dealers.Add(New Dealer("USA Auto-Osa Ericsson", "USA", "02-222222"))
        Me.m_dealers.Add(New Dealer("USA Auto-Osa Ericsson", "USA", "03-333333"))
        Me.m_dealers.Add(New Dealer("USA Auto-Osa Ericsson", "USA", "04-444444"))
        Me.m_dealers.Add(New Dealer("Canada Auto-Osa Ericsson", "Canada", "02-222222"))
        Me.m_dealers.Add(New Dealer("Canada Auto-Osa Ericsson", "Canada", "03-333333"))
        Me.m_dealers.Add(New Dealer("Canada Auto-Osa Ericsson", "Canada", "04-444444"))
        Me.m_dealers.Add(New Dealer("Germany Auto-Osa Ericsson", "Germany", "02-222222"))
        Me.m_dealers.Add(New Dealer("Germany Auto-Osa Ericsson", "Germany", "03-333333"))
        Me.m_dealers.Add(New Dealer("Germany Auto-Osa Ericsson", "Germany", "04-444444"))
    End Sub
End Class
' #endregion
End Class
