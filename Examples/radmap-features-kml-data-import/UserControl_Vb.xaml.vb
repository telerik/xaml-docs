Public Class Default_Vb


' #region radmap-features-kml-data-import_2
Me.informationLayer.Reader = New MapShapeReader()
Me.informationLayer.Reader.Source = New Uri("/Silverlight.Help.RadMapSamples;component/Data/bulgaria.kml", UriKind.RelativeOrAbsolute)
' #endregion

' #region radmap-features-kml-data-import_5
Private Sub LoadKMLData()
 Dim streamResource As StreamResourceInfo = Application.GetResourceStream(New Uri("/Silverlight.Help.RadMapSamples;component/Data/bulgaria.kml", UriKind.RelativeOrAbsolute))
 Dim elements As List(Of FrameworkElement) = KmlReader.Read(streamResource.Stream)
 For Each element As FrameworkElement In elements
  Me.informationLayer.Items.Add(element)
 Next element
End Sub
' #endregion
End Class
