Public Class Default_Vb


' #region common-data-binding-style-selectors_1
Public Class StyleSelector
' #endregion

' #region common-data-binding-style-selectors_2
Dim instance As StyleSelector
' #endregion

' #region common-data-binding-style-selectors_5
Public Overridable Function SelectStyle ( _
    item As Object, _
    container As DependencyObject _
) As Style
' #endregion

' #region common-data-binding-style-selectors_7
Public Class SampleStyleSelector
    Inherits StyleSelector
    Public Overloads Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
        If TypeOf item Is League Then
            Return Me.LeagueStyle
        ElseIf TypeOf item Is Division Then
            Return Me.DivisionStyle
        ElseIf TypeOf item Is Team Then
            Return Me.TeamStyle
        End If
        Return Nothing
    End Function
Private _LeagueStyle As Style
    Public Property LeagueStyle() As Style
        Get
            Return _LeagueStyle
        End Get
        Set(ByVal value As Style)
            _LeagueStyle = value
        End Set
    End Property
Private _DivisionStyle As Style
    Public Property DivisionStyle() As Style
        Get
            Return _DivisionStyle
        End Get
        Set(ByVal value As Style)
            _DivisionStyle = value
        End Set
    End Property
Private _TeamStyle As Style
    Public Property TeamStyle() As Style
        Get
            Return _TeamStyle
        End Get
        Set(ByVal value As Style)
            _TeamStyle = value
        End Set
    End Property
End Class
' #endregion
End Class
