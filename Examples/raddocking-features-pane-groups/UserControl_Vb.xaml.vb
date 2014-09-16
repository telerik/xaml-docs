Public Class Default_Vb


' #region raddocking-features-pane-groups_2
Private Sub GroupPanes()
    Dim pane3 As New Telerik.Windows.Controls.RadPane()
    pane3.Header = "Properties"
    Group1.Items.Add(pane3)
End Sub
' #endregion

' #region raddocking-features-pane-groups_4
Private Sub GroupPanes()
    Dim pane3 As New Telerik.Windows.Controls.RadPane()
    pane3.Header = "Properties"
    Group1.AddItem(pane3, Telerik.Windows.Controls.Docking.DockPosition.Center)
End Sub
' #endregion

' #region raddocking-features-pane-groups_6
Private Sub RemovePane(RadPane paneToRemove)
    Group1.Items.Remove(paneToRemove)
End Sub
' #endregion

' #region raddocking-features-pane-groups_8
Private Sub RemovePane(RadPane paneToRemove)
    paneToRemove.RemoveFromParent()
End Sub
' #endregion

' #region raddocking-features-pane-groups_10
Private Sub HideAllPanes()
    Group1.HideAllPanes()
End Sub
' #endregion

' #region raddocking-features-pane-groups_12
Private Sub ShowAllPanes()
    Group1.ShowAllPanes()
End Sub
' #endregion

' #region raddocking-features-pane-groups_14
Private Sub PinAllPanes()
    Group1.PinAllPanes()
End Sub
' #endregion

' #region raddocking-features-pane-groups_16
Private Sub UnpinAllPanes()
    Group1.UnpinAllPanes()
End Sub
' #endregion
End Class
