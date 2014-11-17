Public Class Default_Vb


' #region radmap-how-to-put-a-mark-on-the-clicked-location_2
Private Sub radMap_MapMouseClick(ByVal sender As Object, ByVal eventArgs As MapMouseRoutedEventArgs)
 Me.informationLayer.Items.Clear()
 Me.informationLayer.Items.Add(eventArgs.Location)
End Sub
' #endregion
End Class
