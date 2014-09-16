Public Class Default_Vb


' #region radtreeview-populating-with-data-item-container-style-selector_5
Public Class LeagueItemContainerStyleSelector
    Inherits StyleSelector
End Class
' #endregion

' #region radtreeview-populating-with-data-item-container-style-selector_7
Public Class LeagueItemContainerStyleSelector
    Inherits StyleSelector
    Private m_leagueStyle As Style
    Private m_divisionStyle As Style
    Private m_teamStyle As Style
    Public Overloads Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
        If TypeOf item Is League Then
            Return Me.m_leagueStyle
        ElseIf TypeOf item Is Division Then
            Return Me.m_divisionStyle
        ElseIf TypeOf item Is Team Then
            Return Me.m_teamStyle
        End If
        Return Nothing
    End Function
    Public Property LeagueStyle() As Style
        Get
            Return Me.m_leagueStyle
        End Get
        Set(ByVal value As Style)
            Me.m_leagueStyle = value
        End Set
    End Property
    Public Property DivisionStyle() As Style
        Get
            Return Me.m_divisionStyle
        End Get
        Set(ByVal value As Style)
            Me.m_divisionStyle = value
        End Set
    End Property
    Public Property TeamStyle() As Style
        Get
            Return Me.m_teamStyle
        End Get
        Set(ByVal value As Style)
            Me.m_teamStyle = value
        End Set
    End Property
End Class
' #endregion
End Class
