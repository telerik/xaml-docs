Public Class Default_Vb


' #region raddocking-features-split-container_3
Private Sub SetOrientationToVertical()
    radSplitContainer.Orientation = Orientation.Vertical
End Sub
' #endregion

' #region raddocking-features-split-container_5
Private Sub SetOrientationToHorizontal()
    radSplitContainer.Orientation = Orientation.Horizontal
End Sub
' #endregion

' #region raddocking-features-split-container_13
Private Sub SetInitialPositionToLeft()
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedLeft
End Sub
' #endregion

' #region raddocking-features-split-container_15
Private Sub SetInitialPositionToTop()
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedTop
End Sub
' #endregion

' #region raddocking-features-split-container_17
Private Sub SetInitialPositionToRight()
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedRight
End Sub
' #endregion

' #region raddocking-features-split-container_19
Private Sub SetInitialPositionToBottom()
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.DockedBottom
End Sub
' #endregion

' #region raddocking-features-split-container_21
Private Sub SetInitialPositionToFloatingOnly()
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.FloatingOnly
End Sub
' #endregion

' #region raddocking-features-split-container_23
Private Sub SetInitialPositionToFloatingDockable()
    radSplitContainer.InitialPosition = Telerik.Windows.Controls.Docking.DockState.FloatingDockable
End Sub
' #endregion
End Class
