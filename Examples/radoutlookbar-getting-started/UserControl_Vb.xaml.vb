Public Class Default_Vb
#Region "radoutlookbar-getting-started_1"
	Private Sub RadOutlookBar1_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim newSelectedItem As RadOutlookBarItem = TryCast(TryCast(sender, RadOutlookBar).SelectedItem, RadOutlookBarItem)
	End Sub
#End Region
End Class
