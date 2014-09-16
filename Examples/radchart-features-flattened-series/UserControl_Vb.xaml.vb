Public Class Default_Vb


' #region radchart-features-flattened-series_3
Public Sub New()
 InitializeComponent()
 Me.radChart.SeriesMappings(0).GroupingSettings.ShouldFlattenSeries = True
End Sub
' #endregion

' #region radchart-features-flattened-series_6
Private Sub CheckBox_Click(sender As Object, e As RoutedEventArgs)
 Dim isChecked As System.Nullable(Of Boolean) = TryCast(sender, CheckBox).IsChecked
 If isChecked Is Nothing Then
  Return
 End If
 Me.radChart.SeriesMappings(0).GroupingSettings.ShouldFlattenSeries = CBool(isChecked)
 Me.radChart.Rebind()
End Sub
' #endregion
End Class
