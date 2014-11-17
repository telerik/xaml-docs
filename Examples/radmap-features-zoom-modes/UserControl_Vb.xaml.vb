Public Class Default_Vb


' #region radmap-features-zoom-modes_1
Public Sub New()
                  InitializeComponent()
                  AddHandler radMap.InitializeCompleted, AddressOf radMap_InitializeCompleted
   End Sub
            Private Sub radMap_InitializeCompleted(ByVal sender As Object, ByVal e As EventArgs)
                  Me.SetCustomZoomLevelLabel(18, "My Level")
            End Sub
            Private Sub SetCustomZoomLevelLabel(ByVal zoomLevel As Integer, ByVal label As String)
                  Dim description As CommandDescription = (
                      From cmd In Me.radMap.MapZoomBar.Commands
                      Where CInt(Fix(cmd.CommandParameter)) = zoomLevel
                      Select cmd).FirstOrDefault()
                  If description IsNot Nothing Then
                        Dim command As RoutedUICommand = TryCast(description.Command, RoutedUICommand)
                        If command IsNot Nothing Then
                              command.Text = label
                        End If
                  End If
            End Sub
' #endregion
End Class
