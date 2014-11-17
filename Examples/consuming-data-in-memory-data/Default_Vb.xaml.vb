Public Class Default_Vb


' #region consuming-data-in-memory-data_1
Public categories As New List(Of Categories)()
Public Sub CreateCategories()
    Dim c As New Categories()
    c.CategoryID = 1
    c.CategoryName = "Beverages"
    c.Description = "Soft drinks, coffees, teas, beers, and ales"
    categories.Add(c)
    c = New Categories()
    c.CategoryID = 2
    c.CategoryName = "Condiments"
    c.Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
    categories.Add(c)
    c = New Categories()
    c.CategoryID = 3
    c.CategoryName = "Confections"
    c.Description = "Desserts, candies, and sweet breads"
    categories.Add(c)
End Sub
' #endregion

' #region consuming-data-in-memory-data_4
radTreeView.ItemsSource = categories
' Or
radTreeView.DataContext = categories
' #endregion
End Class
