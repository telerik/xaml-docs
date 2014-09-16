Public Class Default_Vb


' #region radcontextmenu-features-working-with-radcontext-menu_2
Public Sub New()
 InitializeComponent()
 Dim radContextMenu As New RadContextMenu()
 RadContextMenu.SetContextMenu(Me.textBox, radContextMenu)
End Sub
' #endregion

' #region radcontextmenu-features-working-with-radcontext-menu_5
Public Sub New()
 InitializeComponent()
 Dim radContextMenu As New RadContextMenu()
 Dim copyItem As New RadMenuItem()
 copyItem.Header = "Copy"
 radContextMenu.Items.Add(copyItem)
 Dim pasteItem As New RadMenuItem()
 pasteItem.Header = "Paste"
 radContextMenu.Items.Add(pasteItem)
 Dim cutItem As New RadMenuItem()
 cutItem.Header = "Cut"
 radContextMenu.Items.Add(cutItem)
 RadContextMenu.SetContextMenu(Me.textBox, radContextMenu)
End Sub
' #endregion

' #region radcontextmenu-features-working-with-radcontext-menu_7
Dim item As RadTreeViewItem = radContextMenu.GetClickedElement(Of RadTreeViewItem)()
' #endregion
End Class
