Public Class Default_Vb
#Region "radoutlookbar-selection_0"
	Private Sub RadOutlookBar1_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim newSelectedItem As RadOutlookBarItem = TryCast(TryCast(sender, RadOutlookBar).SelectedItem, RadOutlookBarItem)
	End Sub
	Private Sub RadOutlookBar1_PreviewSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
		'use the Handled property to prevent the selection           
	End Sub
#End Region
End Class
