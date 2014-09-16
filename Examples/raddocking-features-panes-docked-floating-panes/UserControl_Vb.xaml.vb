Public Class Default_Vb


' #region raddocking-features-panes-docked-floating-panes_2
radPane.RemoveFromParent()
radPaneGroup.Items.Add(radPane)
' #endregion

' #region raddocking-features-panes-docked-floating-panes_4
radPane.RemoveFromParent()
radPaneGroup.AddItem( radPane, DockPosition.Center )
' #endregion

' #region raddocking-features-panes-docked-floating-panes_7
radPane.MakeFloatingDockable()
' #endregion

' #region raddocking-features-panes-docked-floating-panes_10
radPane.CanFloat = False
' #endregion
End Class
