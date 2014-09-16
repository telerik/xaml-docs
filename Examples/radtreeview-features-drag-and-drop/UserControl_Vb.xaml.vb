Public Class Default_Vb


' #region radtreeview-features-drag-and-drop_3
Private Sub EnableDragAndDrop()
    radTreeView.IsDragDropEnabled = True
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_6
Private Sub EnableDragOfMultipleNodes()
    radTreeView.SelectionMode = Telerik.Windows.Controls.SelectionMode.Multiple
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_9
Private Sub DisableDropOnSpecificItem()
    radTreeViewItemTennis.IsDropAllowed = False
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_12
Private Sub DisableDragPreview()
    radTreeView.IsDragPreviewEnabled = False
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_15
Private Sub DisableDragTooltip()
    radTreeView.IsDragTooltipEnabled = False
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_18
Private Sub DisableDropPreviewLine()
    radTreeView.IsDropPreviewLineEnabled = False
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_21
Private Sub radTreeView_PreviewDragEnded(ByVal sender As Object, ByVal e As RadTreeViewDragEndedEventArgs)
    e.Handled = True
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_23
Private Sub radTreeView_DragStarted(ByVal sender As Object, ByVal e As RadTreeViewDragEventArgs)
    Dim draggedItems As Collection(Of [Object]) = e.DraggedItems
End Sub
' #endregion

' #region radtreeview-features-drag-and-drop_25
Private Sub radTreeView_DragEnded(ByVal sender As Object, ByVal e As RadTreeViewDragEndedEventArgs)
    ' Get the dragged items.
    Dim draggedItems As Collection(Of [Object]) = e.DraggedItems

    ' Get the drop position.
    Dim dropPosition__1 As DropPosition = e.DropPosition
    Select Case dropPosition__1
        Case DropPosition.After
            MessageBox.Show("After")
            Exit Select
        Case DropPosition.Before
            MessageBox.Show("Before")
            Exit Select
        Case DropPosition.Inside
            MessageBox.Show("Inside")
            Exit Select
    End Select

    ' Get is canceled
    Dim isCanceled As Boolean = e.IsCanceled

    ' Target drop item
    Dim targetDropItem As RadTreeViewItem = e.TargetDropItem
    If targetDropItem.Header.ToString() = "Tennis" Then
        ' Do something
    End If
End Sub
' #endregion
' #region radtreeview-features-drag-and-drop_1
Private Sub EnableDragAndDrop()
	radTreeView.IsDragDropEnabled = True
	TreeViewSettings.SetDragDropExecutionMode(radTreeView, TreeViewDragDropExecutionMode.New)
	DragDropManager.AddDragInitializeHandler(radTreeView, AddressOf OnDragInitialized, True)
End Sub

Private Sub OnDragInitialized(sender As Object, e As DragInitializeEventArgs)
	Dim options As TreeViewDragDropOptions = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
End Sub
' #endregion
	' #region radtreeview-features-drag-and-drop_3
Private Sub EnableDragAndDrop()
	radTreeView.IsDragDropEnabled = True
	TreeViewSettings.SetDragDropExecutionMode(radTreeView, TreeViewDragDropExecutionMode.New)
	DragDropManager.AddDragOverHandler(radTreeView2, AddressOf OnTreeItemDragOver, True)
End Sub

Private Sub OnTreeItemDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
	options.DropAction = DropAction.Copy
End Sub
' #endregion
End Class
