Public Class Default_Vb


' #region radtreeview-how-to-set-drag-cue-feedback-deny-drop-0
DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, True)
' #endregion

' #region radtreeview-how-to-set-drag-cue-feedback-deny-drop-1
Private Sub OnDragOverTree(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
	If options IsNot Nothing AndAlso options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside AndAlso options.DropTargetItem IsNot Nothing AndAlso TypeOf options.DropTargetItem.Item Is Division Then
		options.DropAction = DropAction.None
	End If
End Sub
' #endregion

' #region radtreeview-how-to-set-drag-cue-feedback-deny-drop-2
Private Sub OnDragOverTree(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
	If options IsNot Nothing AndAlso options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside AndAlso options.DropTargetItem IsNot Nothing AndAlso TypeOf options.DropTargetItem.Item Is Division Then
		options.DropAction = DropAction.None
		Dim dragVisual = TryCast(options.DragVisual, TreeViewDragVisual)
		If dragVisual IsNot Nothing Then
			dragVisual.IsDropPossible = False
			dragVisual.DropActionText = "Cannot drop into "
		End If
	End If
End Sub
' #endregion
End Class
