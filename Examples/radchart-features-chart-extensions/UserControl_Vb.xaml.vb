Public Class Default_Vb


' #region radchart-features-chart-extensions_1
Public Interface IExtension(Of T As IExtensibleObject(Of T))
    Sub Attach(ByVal owner As T)
    Sub Detach(ByVal owner As T)
End Interface
' #endregion

' #region radchart-features-chart-extensions_3
Private Sub UserControl_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Dim cameraExtension As New CameraExtension()
    radChart.DefaultView.ChartArea.Extensions.Add(cameraExtension)
End Sub
Private Sub UserControl_Unloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    radChart.DefaultView.ChartArea.Extensions.Clear()
End Sub
' #endregion
End Class
