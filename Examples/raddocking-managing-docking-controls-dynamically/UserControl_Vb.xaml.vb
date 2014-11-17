Public Class Default_Vb


' #region raddocking-managing-docking-controls-dynamically_2
Private Sub MakeFloatingDockable()
    radPane1.MakeFloatingDockable()
End Sub
' #endregion

' #region raddocking-managing-docking-controls-dynamically_4
Private Sub MakeFloatingOnly()
    radPane1.MakeFloatingOnly()
End Sub
' #endregion

' #region raddocking-managing-docking-controls-dynamically_8
Private Sub MakeDockable()
    radPane1.MakeDockable()
End Sub
' #endregion

' #region raddocking-managing-docking-controls-dynamically_11
Public Sub AddItem(ByVal item As RadPane, ByVal dockPosition As DockPosition)
End Sub
' #endregion

' #region raddocking-managing-docking-controls-dynamically_17
Private Sub PinPane()
    radPane1.IsPinned = True
End Sub
' #endregion

' #region raddocking-managing-docking-controls-dynamically_19
Private Sub UnpinPane()
    radPane1.IsPinned = False
End Sub
' #endregion

' #region raddocking-managing-docking-controls-dynamically_22
Private Sub ClosePane()
    radPane1.IsHidden = False
End Sub
' #endregion
End Class
