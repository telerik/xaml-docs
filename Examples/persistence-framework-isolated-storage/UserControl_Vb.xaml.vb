Public Class Default_Vb


' #region persistence-framework-isolated-storage_2
Private Sub Save(sender As Object, e As RoutedEventArgs)
	Dim isoProvider As New IsolatedStorageProvider()
	isoProvider.SaveToStorage()
End Sub
Private Sub Load(sender As Object, e As RoutedEventArgs)
	Dim isoProvider As New IsolatedStorageProvider()
	isoProvider.LoadFromStorage()
End Sub
' #endregion
End Class
