Public Class Default_Vb


' #region raddocking-how-to-implement-conditional-docking_3
Private Sub radDocking_PreviewShowCompass(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
    e.Compass.IsLeftIndicatorVisible = False
End Sub
' #endregion

' #region raddocking-how-to-implement-conditional-docking_5
Private Sub radDocking_PreviewShowCompass(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
    e.Compass.IsLeftIndicatorVisible = False
    e.Compass.IsTopIndicatorVisible = False
End Sub
' #endregion

' #region raddocking-how-to-implement-conditional-docking_7
Private Sub radDocking_PreviewShowCompass(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
    e.Compass.IsLeftIndicatorVisible = False
    e.Compass.IsTopIndicatorVisible = False
    e.Compass.IsRightIndicatorVisible = False
End Sub
' #endregion

' #region raddocking-how-to-implement-conditional-docking_9
Private Sub radDocking_PreviewShowCompass(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
    e.Compass.IsLeftIndicatorVisible = False
    e.Compass.IsTopIndicatorVisible = False
    e.Compass.IsRightIndicatorVisible = False
    e.Compass.IsBottomIndicatorVisible = False
End Sub
' #endregion

' #region raddocking-how-to-implement-conditional-docking_11
Private Sub radDocking_PreviewShowCompass(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Docking.PreviewShowCompassEventArgs)
    e.Compass.IsLeftIndicatorVisible = False
    e.Compass.IsTopIndicatorVisible = False
    e.Compass.IsRightIndicatorVisible = False
    e.Compass.IsBottomIndicatorVisible = False
    e.Compass.IsCenterIndicatorVisible = False
End Sub
' #endregion
End Class
