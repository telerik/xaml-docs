Public Class Default_Vb


' #region radmap-howto-custom-zoom-levels_2
Private Const ImagePathFormat As String = "/Map;component/Silverlight/CustomCommands/Images/{0}.png"
Private VEKey As String
Private provider As BingMapProvider
Public Sub New()
 Me.provider = New BingMapProvider(MapMode.Aerial, True, Me.VEKey)
 Me.RadMap1.Provider = provider
 Me.RadMap1.InitializeCompleted += New EventHandler(RadMap1_InitializeCompleted)
End Sub
Private Sub RadMap1_InitializeCompleted(sender As Object, e As EventArgs)
 ' remove the default zoom levels
 RadMap1.MapZoomBar.Commands.Clear()
 Me.AddCustomZoomAction(15, "Downtown")
 Me.AddCustomZoomAction(18, "Neighborhood")
 Me.AddCustomZoomAction(20, "Block")
End Sub
Private Sub AddCustomZoomAction(zoomLevel As Integer, label As String)
 Dim imagePath As String = String.Format(ImagePathFormat, label)
 Me.RadMap1.MapZoomBar.RegisterSetZoomLevelCommand(zoomLevel, label, TryCast(Me.LayoutRoot.Resources("CustomCommandDataTemplate"), DataTemplate), New Uri(imagePath, UriKind.RelativeOrAbsolute))
End Sub
' #endregion
End Class
