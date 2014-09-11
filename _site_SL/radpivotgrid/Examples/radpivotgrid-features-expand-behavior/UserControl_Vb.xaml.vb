' #region radpivotgrid-features-expand-behavior_1
Dim pivot As New RadPivotGrid()
pivot.RowGroupsExpandBehavior = New GroupsExpandBehavior() With {.Expanded = False, .UpToLevel = 2}
pivot.ColumnGroupsExpandBehavior = New GroupsExpandBehavior() With {.Expanded = False}
' #endregion

' #region radpivotgrid-features-expand-behavior_2
Public Sub ExpandGroupsButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	TryCast(Me.pivot.RowGroupsExpandBehavior, GroupsExpandBehavior).Expanded = True
	TryCast(Me.pivot.ColumnGroupsExpandBehavior, GroupsExpandBehavior).Expanded = True
	Me.pivot.DataProvider.Refresh()
End Sub

Private Sub CollapseGroupsButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	TryCast(Me.pivot.RowGroupsExpandBehavior, GroupsExpandBehavior).Expanded = False
	TryCast(Me.pivot.ColumnGroupsExpandBehavior, GroupsExpandBehavior).Expanded = False
	Me.pivot.DataProvider.Refresh()
End Sub
' #endregion