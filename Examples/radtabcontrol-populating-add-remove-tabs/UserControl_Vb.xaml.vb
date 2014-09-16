Public Class Default_Vb


' #region radtabcontrol-populating-add-remove-tabs_1
Private Sub AddTab()
    Dim itemToAdd As New RadTabItem()
    itemToAdd.Header = "New Tab"
    radTabControl.Items.Add(itemToAdd)
End Sub
' #endregion

' #region radtabcontrol-populating-add-remove-tabs_3
Private Sub RemoveTab( ByVal tabItemToRemove As RadTabItem )
    radTabControl.Items.Remove( tabItemToRemove )
End Sub
' #endregion
End Class
