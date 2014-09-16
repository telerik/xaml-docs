Public Class Default_Vb


' #region radtreeview-how-to-add-context-menu_3
Me.radTreeView.[AddHandler](RadMenuItem.ClickEvent, New RoutedEventHandler(AddressOf OnContextMenuClick))
' #endregion

' #region radtreeview-how-to-add-context-menu_5
Private Sub OnContextMenuClick(sender As Object, args As RoutedEventArgs)
		' Get the clicked context menu item
		Dim menuItem As RadMenuItem = TryCast(DirectCast(args, RadRoutedEventArgs).OriginalSource, RadMenuItem)

		Dim league As League = TryCast(clickedElement.Item, League)
		Dim parentItemsControl As ItemsControl = If(DirectCast(clickedElement.ParentItem, ItemsControl), clickedElement.ParentTreeView)
		Dim header As String = TryCast(menuItem.Header, String)
		Select Case header
			Case "New Child"
				league.Divisions.Add(New Division("New Division"))
				Exit Select
			Case "New Sibling"
				TryCast(parentItemsControl.ItemsSource, ObservableCollection(Of League)).Add(New League("New League"))
				Exit Select
			Case "Delete"
				TryCast(parentItemsControl.ItemsSource, ObservableCollection(Of League)).Remove(league)
				Exit Select
		End Select
	End Sub
' #endregion

' #region radtreeview-how-to-add-context-menu_7
Private clickedElement As RadTreeViewItem
	Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
		' Find the tree item that is associated with the clicked context menu item
		clickedElement = TryCast(sender, RadContextMenu).GetClickedElement(Of RadTreeViewItem)()
	End Sub
' #endregion
End Class
