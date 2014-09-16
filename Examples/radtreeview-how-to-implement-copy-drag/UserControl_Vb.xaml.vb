Public Class Default_Vb

	' #region radtreeview-how-to-implement-copy-drag-0
	DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, True)
	' #endregion
	' #region radtreeview-how-to-implement-copy-drag-3
	DragDropManager.AddDragOverHandler(radTreeView2, OnDragOver, True)
	' #endregion
	' #region radtreeview-how-to-implement-copy-drag-4
	Private Sub OnDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
		Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
		If options IsNot Nothing AndAlso TypeOf options.DropTargetItem.Items Is League Then
			options.DropAction = DropAction.Copy
		End If
	End Sub
	' #endregion

	' #region radtreeview-how-to-implement-copy-drag-1
	DragDropManager.AddDropHandler(xTreeView, OnDrop, True)
	DragDropManager.AddDragDropCompletedHandler(xTreeView, OnDragDropCompleted, True)
	' #endregion
	' #region radtreeview-how-to-implement-copy-drag-2
Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
	If options IsNot Nothing Then
		options.DropAction = DropAction.None
	End If
End Sub
	' #endregion
	' #region radtreeview-how-to-implement-copy-drag-5
Private Function CopyTeam(team As Team) As Team
	Return New Team(team.Name)
End Function

Private Function CopyDivision(division As Division) As Division
	Dim div As New Division(division.Name)
	For Each team As Team In division.Teams
		div.Teams.Add(Me.CopyTeam(team))
	Next
	Return div
End Function

Private Function CopyLeague(league As League) As League
	Dim l As New League(league.Name)
	For Each division As Division In league.Divisions
		l.Divisions.Add(Me.CopyDivision(division))
	Next
	Return l
End Function
	' #endregion
' #region radtreeview-how-to-implement-copy-drag-6
	Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
	Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
	If options IsNot Nothing Then
		Dim item = options.DraggedItems.FirstOrDefault()
		If options.DropTargetItem IsNot Nothing Then
			If TypeOf item Is Team Then
				If options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is Division Then
					TryCast(options.DropTargetItem.Item, Division).Teams.Add(CopyTeam(DirectCast(item, Team)))
				ElseIf options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is Team Then
					Dim parentDivision As Division = TryCast(options.DropTargetItem.ParentItem.Item, Division)
					Select Case options.DropPosition
						Case Telerik.Windows.Controls.DropPosition.After
							parentDivision.Teams.Insert(options.DropTargetItem.Index + 1, CopyTeam(DirectCast(item, Team)))
							Exit Select
						Case Telerik.Windows.Controls.DropPosition.Before
							parentDivision.Teams.Insert(options.DropTargetItem.Index, CopyTeam(DirectCast(item, Team)))
							Exit Select
					End Select
				End If
			ElseIf TypeOf item Is Division Then
				If options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is League Then
					TryCast(options.DropTargetItem.Item, League).Divisions.Add(CopyDivision(DirectCast(item, Division)))
				ElseIf options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is Division Then
					Dim parentLeague As League = TryCast(options.DropTargetItem.ParentItem.Item, League)
					Select Case options.DropPosition
						Case Telerik.Windows.Controls.DropPosition.After
							parentLeague.Divisions.Insert(options.DropTargetItem.Index + 1, CopyDivision(DirectCast(item, Division)))
							Exit Select
						Case Telerik.Windows.Controls.DropPosition.Before
							parentLeague.Divisions.Insert(options.DropTargetItem.Index, CopyDivision(DirectCast(item, Division)))
							Exit Select
					End Select
				End If
			ElseIf TypeOf item Is League Then
				If options.DropTargetItem Is Nothing AndAlso options.DropTargetTree IsNot Nothing Then
					TryCast(options.DropTargetTree.ItemsSource, IList).Add(CopyLeague(DirectCast(item, League)))
				ElseIf options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is League Then
					Dim source As IList = TryCast(options.DropTargetItem.ParentTreeView.ItemsSource, IList)
					Select Case options.DropPosition
						Case Telerik.Windows.Controls.DropPosition.After
							source.Insert(options.DropTargetItem.Index + 1, CopyLeague(DirectCast(item, League)))
							Exit Select
						Case Telerik.Windows.Controls.DropPosition.Before
							source.Insert(options.DropTargetItem.Index, CopyLeague(DirectCast(item, League)))
							Exit Select
					End Select
				End If

			End If
		End If
	End If
End Sub

' #endregion

End Class
