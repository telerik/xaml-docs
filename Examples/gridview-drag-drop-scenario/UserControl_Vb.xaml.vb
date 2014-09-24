Public Class Default_Vb


' #region gridview-drag-drop-scenario_3
Private Sub EnableDropBehavior()
    RadDragAndDropManager.SetAllowDrop(radGridView, True)
End Sub
' #endregion

' #region gridview-drag-drop-scenario_8
Type your example code here. It will be automatically colorized when you switch to Private Sub radTreeView_PreviewDragEnded(ByVal sender As Object, ByVal e As RadTreeViewDragEndedEventArgs)
    e.Handled = True
End Sub
' #endregion

' #region gridview-drag-drop-scenario_10
RadDragAndDropManager.AddDropQueryHandler(radGridView, New EventHandler(Of DragDropQueryEventArgs)(Me.RadGridView_OnDropQuery))
RadDragAndDropManager.AddDropInfoHandler(radGridView, New EventHandler(Of DragDropEventArgs)(Me.RadGridView_OnDropInfo))
' #endregion

' #region gridview-drag-drop-scenario_12
Private Sub RadGridView_OnDropQuery(ByVal sender As Object, ByVal e As DragDropQueryEventArgs)
    e.QueryResult = TypeOf TryCast(e.Options.Source, RadTreeViewItem).Item Is Team
End Sub
Private Sub RadGridView_OnDropInfo(ByVal sender As Object, ByVal e As DragDropEventArgs)
    If e.Options.Status = DragStatus.DropComplete Then
        TryCast(radGridView.ItemsSource, IList(Of Team)).Add(TryCast(TryCast(e.Options.Payload, Collection(Of [Object]))(0), Team))
    End If
End Sub
' #endregion
End Class
