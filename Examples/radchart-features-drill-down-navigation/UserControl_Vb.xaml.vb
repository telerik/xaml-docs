Public Class Default_Vb


' #region radchart-features-drill-down-navigation_2
Private Sub BackButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
 Me.radChart.HierarchyManager.Back()
End Sub
Private Sub ForwardButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
 Me.radChart.HierarchyManager.Forward()
End Sub
' #endregion
End Class
