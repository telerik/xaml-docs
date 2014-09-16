Public Class Default_Vb


' #region radtreeview-how-to-enabled-drop-inside-only-0
DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, True)
' #endregion

' #region radtreeview-how-to-enabled-drop-inside-only-1
Private Sub OnDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
	If options IsNot Nothing AndAlso options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside Then
		options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside
		options.UpdateDragVisual()
	End If
End Sub
' #endregion
End Class
