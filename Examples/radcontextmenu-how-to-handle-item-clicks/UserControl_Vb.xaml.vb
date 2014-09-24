Public Class Default_Vb


' #region radcontextmenu-how-to-handle-item-clicks_2
Private Sub RadMenuItem_Click(sender As Object, e As RadRoutedEventArgs)
 Dim item As RadMenuItem = TryCast(sender, RadMenuItem)
 'implement the logic regarding the instance here.
End Sub
' #endregion

' #region radcontextmenu-how-to-handle-item-clicks_5
Private Sub radContextMenu_ItemClick(sender As Object, e As RadRoutedEventArgs)
 Dim item As RadMenuItem = TryCast(e.OriginalSource, RadMenuItem)
 'implement the logic regarding the instance here.
End Sub
' #endregion
End Class
