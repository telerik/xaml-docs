Public Class Default_Vb


' #region radtreeview-how-to-iterate-through-treeviewitems_1
AddHandler Me.Loaded, AddressOf IterateTreeViewItems_Loaded
' #endregion

' #region radtreeview-how-to-iterate-through-treeviewitems_3
Private Sub IterateTreeViewItems_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
    Me.GetContainers()
	End Sub

	Private Sub GetContainers()
		' gets all nodes from the TreeView  
		Dim allTreeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(Me.radTreeView)

		' gets all nodes (recursively) for the first node  
		Dim firstNode As RadTreeViewItem = TryCast(Me.radTreeView.ItemContainerGenerator.ContainerFromIndex(0), RadTreeViewItem)
		If firstNode IsNot Nothing Then
			Dim firstNodeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(firstNode)
		End If
	End Sub

	Private Function GetAllItemContainers(ByVal itemsControl As Telerik.Windows.Controls.ItemsControl) As Collection(Of RadTreeViewItem)

		Dim allItems As New Collection(Of RadTreeViewItem)()

		For i As Integer = 0 To itemsControl.Items.Count - 1
			' try to get the item Container  
			Dim childItemContainer As RadTreeViewItem = TryCast(itemsControl.ItemContainerGenerator.ContainerFromIndex(i), RadTreeViewItem)

			' the item container maybe null if it is still not generated from the runtime  
			If childItemContainer IsNot Nothing Then
				allItems.Add(childItemContainer)

				Dim childItems As Collection(Of RadTreeViewItem) = GetAllItemContainers(childItemContainer)
				For Each childItem As RadTreeViewItem In childItems
					allItems.Add(childItem)
				Next
			End If
		Next
		Return allItems
	End Function
	' #endregion

	' #region radtreeview-how-to-iterate-through-treeviewitems_5
	Private Sub IterateTreeViewItems_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Me.GetContainers()
	End Sub

	Private Sub GetContainers()
		' gets all nodes from the TreeView  
		Dim allTreeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(Me.radTreeView)

		' gets all nodes (recursively) for the first node  
		Dim firstNode As RadTreeViewItem = TryCast(Me.radTreeView.ItemContainerGenerator.ContainerFromIndex(0), RadTreeViewItem)
		If firstNode IsNot Nothing Then
			Dim firstNodeContainers As Collection(Of RadTreeViewItem) = GetAllItemContainers(firstNode)
		End If
	End Sub

	Private Function GetAllItemContainers(ByVal itemsControl As System.Windows.Controls.ItemsControl) As Collection(Of RadTreeViewItem)

		Dim allItems As New Collection(Of RadTreeViewItem)()

		For i As Integer = 0 To itemsControl.Items.Count - 1
			' try to get the item Container  
			Dim childItemContainer As RadTreeViewItem = TryCast(itemsControl.ItemContainerGenerator.ContainerFromIndex(i), RadTreeViewItem)

			' the item container maybe null if it is still not generated from the runtime  
			If childItemContainer IsNot Nothing Then
				allItems.Add(childItemContainer)

				Dim childItems As Collection(Of RadTreeViewItem) = GetAllItemContainers(childItemContainer)
				For Each childItem As RadTreeViewItem In childItems
					allItems.Add(childItem)
				Next
			End If
		Next
		Return allItems
	End Function
	' #endregion
End Class
