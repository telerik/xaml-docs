Public Class Default_Vb
	' #region radtreeview-howto-implement-search-filter-sort_1
	'the RadTreeView.ItemsSource collection is traversed to find an item by a provided name 
	Private Sub Search(sender As Object, e As RoutedEventArgs)
		If Not String.IsNullOrEmpty(searchTextBox.Text) Then
			searchText = searchTextBox.Text.ToLower()
			For Each category As Category In radTreeView.ItemsSource
				If category.Name.ToLower().Contains(searchText) Then
					Dim item As RadTreeViewItem = radTreeView.GetItemByPath(category.Path)
					item.BringIntoView()
					item.IsSelected = True
					Return
				End If
				For Each product As Product In category.Products
					If product.Name.ToLower().Contains(searchText) Then
						Dim item As RadTreeViewItem = radTreeView.GetItemByPath(category.Path + "\" + product.Path)
						item.BringIntoView()
						item.IsSelected = True
						Return
					End If
				Next
			Next
		End If
		isFiltered = False
	End Sub
	' #endregion

	' #region radtreeview-howto-implement-search-filter-sort_3
	'the SampleDataSource collection is dynamically filtered to display only those items matching the filter criteria   
	Private Sub filterTextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
		If Not [String].IsNullOrEmpty(filterTextBox.Text) Then
			filterText = If(filterTextBox.Text = " Enter product name", "", filterTextBox.Text)
			radTreeView.ItemsSource = FilterCollection(New SampleDataSource(), filterText)
		Else
			radTreeView.ItemsSource = New SampleDataSource()
			filterText = Nothing
		End If
		isFiltered = True
	End Sub

	'this method filters a business collection   
	Private Function FilterCollection(collection As ObservableCollection(Of Category), filterText As String) As ObservableCollection(Of Category)
		For Each category As Category In collection
			category.Products = New ObservableCollection(Of Product)(category.Products.Where(Function(p) p.Name.ToLower().Contains(filterText)))
		Next
		Return New ObservableCollection(Of Category)(collection.Where(Function(cat) (cat.Name.ToLower().Contains(filterText) AndAlso cat.Products.Count = 0) OrElse cat.Products.Count > 0))
	End Function
	' #endregion
	' #region radtreeview-howto-implement-search-filter-sort_5
	'When the Sorting ComboBox selection is changed, the SampleDataSource collection is sorted accordingly        
	Private Sub sortingComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
		If TryCast(sortingComboBox.SelectedItem, RadComboBoxItem).Content.Equals("Category name") Then
			If filterText IsNot Nothing Then
				radTreeView.ItemsSource = FilterCollection(New SampleDataSource(), filterText).OrderBy(Function(c) c.Name)
			Else
				radTreeView.ItemsSource = New SampleDataSource().OrderBy(Function(c) c.Name)
			End If
		Else
			If filterText IsNot Nothing Then
				radTreeView.ItemsSource = FilterCollection(New SampleDataSource(), filterText).OrderBy(Function(c) c.Products.Count)
			Else
				radTreeView.ItemsSource = New SampleDataSource().OrderBy(Function(c) c.Products.Count)
			End If
		End If
		isFiltered = False
	End Sub

	' #endregion

End Class
