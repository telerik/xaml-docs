Public Class Default_Vb


' #region gridview-style-selectors-overview_1
Public Class SampleStyleSelector
        Inherits StyleSelector
        Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
            If TypeOf item Is League Then
                Return Me.LeagueStyle
            ElseIf TypeOf item Is Division Then
                Return Me.DivisionStyle
            ElseIf TypeOf item Is Team Then
                Return Me.TeamStyle
            End If
            Return Nothing
        End Function

        Public Property LeagueStyle() As Style
            Get
                Return m_LeagueStyle
            End Get
            Set(value As Style)
                m_LeagueStyle = Value
            End Set
        End Property
        Private m_LeagueStyle As Style

        Public Property DivisionStyle() As Style
            Get
                Return m_DivisionStyle
            End Get
            Set(value As Style)
                m_DivisionStyle = Value
            End Set
        End Property
        Private m_DivisionStyle As Style

        Public Property TeamStyle() As Style
            Get
                Return m_TeamStyle
            End Get
            Set(value As Style)
                m_TeamStyle = Value
            End Set
        End Property
        Private m_TeamStyle As Style
    End Class
' #endregion
End Class
