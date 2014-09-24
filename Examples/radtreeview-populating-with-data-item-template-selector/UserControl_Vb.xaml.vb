Public Class Default_Vb


' #region radtreeview-populating-with-data-item-template-selector_1
Public Class LeagueDataTemplateSelector
    Inherits DataTemplateSelector
End Class
' #endregion

' #region radtreeview-populating-with-data-item-template-selector_3
	Private leagueTemplate As HierarchicalDataTemplate
	Private divisionTemplate As HierarchicalDataTemplate
Private teamTemplate As DataTemplate
Public Sub New()
End Sub
Public Overloads Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
    If TypeOf item Is League Then
        Return Me.leagueTemplate
    ElseIf TypeOf item Is Division Then
        Return Me.divisionTemplate
    ElseIf TypeOf item Is Team Then
        Return Me.teamTemplate
		End If

    Return Nothing
End Function
	Public Property LeagueTemplate() As HierarchicalDataTemplate
		Get
			Return Me.leagueTemplate
		End Get
		Set(ByVal value As HierarchicalDataTemplate)
			Me.leagueTemplate = value
		End Set
	End Property
	Public Property DivisionTemplate() As HierarchicalDataTemplate
		Get
			Return Me.divisionTemplate
		End Get
		Set(ByVal value As HierarchicalDataTemplate)
			Me.divisionTemplate = value
		End Set
	End Property
Public Property TeamTemplate() As DataTemplate
    Get
        Return teamTemplate
    End Get
    Set(ByVal value As DataTemplate)
        Me.teamTemplate = value
    End Set
End Property
' #endregion
End Class
