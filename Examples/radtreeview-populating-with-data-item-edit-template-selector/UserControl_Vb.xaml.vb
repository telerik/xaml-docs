Public Class Default_Vb


' #region radtreeview-populating-with-data-item-edit-template-selector_5
Public Class LeagueDataTemplateSelector
    Inherits DataTemplateSelector
End Class
' #endregion

' #region radtreeview-populating-with-data-item-edit-template-selector_7
Public Class LeagueItemEditTemplateSelector
    Inherits DataTemplateSelector
    Private m_leagueTemplate As DataTemplate
    Private m_divisionTemplate As DataTemplate
    Private m_teamTemplate As DataTemplate
    Public Overloads Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
        If TypeOf item Is League Then
            Return Me.m_leagueTemplate
        ElseIf TypeOf item Is Division Then
            Return Me.m_divisionTemplate
        ElseIf TypeOf item Is Team Then
            Return Me.m_teamTemplate
        End If
        Return Nothing
    End Function
    Public Property LeagueTemplate() As DataTemplate
        Get
            Return m_leagueTemplate
        End Get
        Set(ByVal value As DataTemplate)
            m_leagueTemplate = value
        End Set
    End Property
    Public Property DivisionTemplate() As DataTemplate
        Get
            Return m_divisionTemplate
        End Get
        Set(ByVal value As DataTemplate)
            m_divisionTemplate = value
        End Set
    End Property
    Public Property TeamTemplate() As DataTemplate
        Get
            Return m_teamTemplate
        End Get
        Set(ByVal value As DataTemplate)
            m_teamTemplate = value
        End Set
    End Property
End Class
' #endregion
End Class
