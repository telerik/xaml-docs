Public Class Default_Vb
#Region "radgridview-columns-column-types-hyperlink-column_2"
    Public Class Employee
        Private m_teamUrl As String = "http://google.com"
        Public Property TeamUrl() As String
            Get
                Return Me.m_teamUrl
            End Get
            Set(value As String)
                If value <> Me.m_teamUrl Then
                    Me.m_teamUrl = value
                    Me.OnPropertyChanged("TeamUrl")
                End If
            End Set
        End Property
    End Class
#End Region
End Class
