Public Class Default_Vb


' #region radchart-features-interactivity_2
AddHandler radChart.DefaultView.ChartArea.ItemClick, AddressOf ChartArea_ItemClick
...
Private Sub ChartArea_ItemClick(ByVal sender As Object, ByVal e As ChartItemClickEventArgs)
    Dim td As TradeData = TryCast(e.DataPoint.DataItem, TradeData)
    MessageBox.Show(String.Format("Trading details for {0:d}:" & vbLf & vbLf & "Open" & vbTab & ": {1:c}" & vbLf & "High" & vbTab & ": {2:c}" & vbLf & "Low" & vbTab & ": {3:c}" & vbLf & "Close" & vbTab & ": {4:c}" & vbLf & vbLf & "Volume" & vbTab & ": {5}", td.FromDate, td.Open, td.High, td.Low, td.Close, _
     td.Volume), td.Emission, MessageBoxButton.OK)
End Sub
' #endregion

' #region radchart-features-interactivity_4
Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
 For Each dataPoint1 As DataPoint In Chart1.DefaultView.ChartArea.DataSeries(0)
  If dataPoint1.YValue = 154.0 Then
   Chart1.DefaultView.ChartArea.SelectItem(dataPoint1)
  End If
 Next
End Sub
' #endregion
End Class
