Public Class Default_Vb


' #region persistence-framework-save-stream_2
Private stream As Stream
Private Sub Save(sender As Object, e As RoutedEventArgs)
	Dim manager As New PersistenceManager()
	stream = manager.Save(treeView)
End Sub
' #endregion

' #region persistence-framework-save-stream_4
Private Sub Load(sender As Object, e As RoutedEventArgs)
	Dim manager As New PersistenceManager()
        stream.Position = 0L
	manager.Load(treeView, stream)
End Sub
' #endregion
End Class
