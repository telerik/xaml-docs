Public Class Default_Vb


' #region radwindow-how-to-close-the-radwidnow-through-its-content_3
Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
 Me.Close()
End Sub
' #endregion

' #region radwindow-how-to-close-the-radwidnow-through-its-content_5
Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
 Dim window As RadWindow = Me.ParentOfType(Of RadWindow)()
 window.Close()
End Sub
' #endregion
End Class
