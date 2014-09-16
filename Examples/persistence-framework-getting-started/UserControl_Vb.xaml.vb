Public Class Default_Vb


' #region persistence-framework-getting-started_2
Dim isoProvider As New IsolatedStorageProvider()
isoProvider.SaveToStorage()
' #endregion

' #region persistence-framework-getting-started_4
Dim isoProvider As New IsolatedStorageProvider()
isoProvider.LoadFromStorage()
' #endregion

' #region persistence-framework-getting-started_7
Private stream As Stream
Private Sub Save(sender As Object, e As RoutedEventArgs)
	Dim manager As New PersistenceManager()
	stream = manager.Save(treeView)
End Sub
' #endregion

' #region persistence-framework-getting-started_9
Private Sub Load(sender As Object, e As RoutedEventArgs)
	stream.Position = 0L
	Dim manager As New PersistenceManager()
	manager.Load(treeView, stream)
End Sub
' #endregion
End Class
