Public Class Default_Vb


' #region radcontextmenu-populating-with-data-binding-to-dynamic-data_1
Public Class MenuItem
	Public Sub New()
		Me.SubItems = New ObservableCollection(Of MenuItem)()
	End Sub
	Public Property Text() As String
	Public Property IconUrl() As Uri
	Public Property IsSeparator() As Boolean
	Public Property Command() As ICommand
	Public Property SubItems() As ObservableCollection(Of MenuItem)
End Class
' #endregion

' #region radcontextmenu-populating-with-data-binding-to-dynamic-data_3
Public Function GetMenuItems() As ObservableCollection(Of MenuItem)
	Dim items As New ObservableCollection(Of MenuItem)()
	Dim copyItem As New MenuItem() With {.IconUrl = New Uri("Images/copy.png", UriKind.Relative), .Text = "Copy"}
	items.Add(copyItem)
	Dim pasteItem As New MenuItem() With {.IconUrl = New Uri("Images/paste.png", UriKind.Relative), .Text = "Paste"}
	items.Add(pasteItem)
	Dim cutItem As New MenuItem() With {.IconUrl = New Uri("Images/cut.png", UriKind.Relative), .Text = "Cut"}
	items.Add(cutItem)
	Dim separatorItem As New MenuItem() With {.IsSeparator = True}
	items.Add(separatorItem)
	Dim selectAllItem As New MenuItem() With {.Text = "Select All"}
	items.Add(selectAllItem)

	Return items
End Function
' #endregion

' #region radcontextmenu-populating-with-data-binding-to-dynamic-data_5
Public Sub New()
 InitializeComponent()
 Me.radContextMenu.ItemsSource = Me.GetMenuItems()
End Sub
' #endregion
End Class
