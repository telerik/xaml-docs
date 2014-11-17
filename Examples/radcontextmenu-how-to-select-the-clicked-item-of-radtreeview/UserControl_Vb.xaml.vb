Public Class Default_Vb


' #region radcontextmenu-how-to-select-the-clicked-item-of-radtreeview_3
Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
End Sub
' #endregion

' #region radcontextmenu-how-to-select-the-clicked-item-of-radtreeview_5
Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
 Dim item As RadTreeViewItem = Me.radContextMenu.GetClickedElement(Of RadTreeViewItem)()
End Sub
' #endregion

' #region radcontextmenu-how-to-select-the-clicked-item-of-radtreeview_7
Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
 Dim item As RadTreeViewItem = Me.radContextMenu.GetClickedElement(Of RadTreeViewItem)()
 If item <> Nothing Then
  Me.radTreeView.SelectedItem = item
 End If
End Sub
' #endregion
End Class
