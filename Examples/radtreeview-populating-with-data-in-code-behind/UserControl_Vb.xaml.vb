Public Class Default_Vb


' #region radtreeview-populating-with-data-in-code-behind_2
Private Sub AddTreeViewItems()
    Dim category As New RadTreeViewItem()
    category.Header = "Category1"
    category.Foreground = New SolidColorBrush(Colors.Green)
    radTreeView.Items.Add(category)
    category = New RadTreeViewItem()
    category.Header = "Category2"
    category.Foreground = New SolidColorBrush(Colors.Purple)
    radTreeView.Items.Add(category)
End Sub
' #endregion

' #region radtreeview-populating-with-data-in-code-behind_4
Private Sub AddTreeViewItems()
    Dim category As New RadTreeViewItem()
    category.Header = "Category1"
    category.Foreground = New SolidColorBrush(Colors.Green)
    radTreeView.Items.Add(category)
    ' Adding child items
    Dim product As New RadTreeViewItem()
    product.Header = "Product1.1"
    category.Items.Add(product)
    product = New RadTreeViewItem()
    product.Header = "Product1.1"
    category.Items.Add(product)
    category = New RadTreeViewItem()
    category.Header = "Category2"
    category.Foreground = New SolidColorBrush(Colors.Purple)
    radTreeView.Items.Add(category)
    ' Adding child items
    product = New RadTreeViewItem()
    product.Header = "Product2.1"
    category.Items.Add(product)
    product = New RadTreeViewItem()
    product.Header = "Product2.2"
    category.Items.Add(product)
End Sub
' #endregion

' #region radtreeview-populating-with-data-in-code-behind_6
Private Sub RemoveTreeViewItem(ByVal itemToRemove As RadTreeViewItem)
    radTreeView.Items.Remove(itemToRemove)
End Sub
' #endregion
End Class
