Public Class Default_Vb


' #region radtabcontrol-enable-disable-tabs_2
Dim newTabItem As New RadTabItem()
newTabItem.Header = "Disabled Item"
' Add the newly created tab item to
‘ some existing tab control “TabControl”
radTabControl.Items.Add(newTabItem)
‘ Disable the newly created tab item
newTabItem.IsEnabled = False
' #endregion
End Class
