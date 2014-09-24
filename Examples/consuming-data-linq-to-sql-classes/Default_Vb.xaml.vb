Public Class Default_Vb


' #region consuming-data-linq-to-sql-classes_1
Dim dbContext As New NortwindDataContext()
Dim query = From p In dbContext.Products _
    Where p.Category.CategoryName = "Seafood" _
    Select p
Dim products As IEnumerable(Of Product) = query.ToList()
' #endregion

' #region consuming-data-linq-to-sql-classes_3
Dim dbContext As New NortwindDataContext()
Dim query = From p In dbContext.Products _
            Where p.ProductName = "Aniseed Syrup" _
            Select p
product.UnitPrice = 1000
dbContext.SubmitChanges()
' #endregion

' #region consuming-data-linq-to-sql-classes_5
Dim dbContext As New NortwindDataContext()
Dim category As New Category()
category.CategoryName = "Test Category"
Dim firstProduct As New Product()
firstProduct.ProductName = "Test Product 1"
Dim secondProduct As New Product()
secondProduct.ProductName = "Test Product 2"
category.Products.Add(firstProduct)
category.Products.Add(secondProduct)
dbContext.Categories.InsertOnSubmit(category)
dbContext.SubmitChanges()
' #endregion

' #region consuming-data-linq-to-sql-classes_7
Dim dbContext As New NortwindDataContext()
Dim query = From p In dbContext.Products _
    Where p.ProductName.Contains("Test") _
    Select p
dbContext.Products.DeleteAllOnSubmit(query)
dbContext.SubmitChanges()
' #endregion

' #region consuming-data-linq-to-sql-classes_9
NortwindDataContext dbContext = new NortwindDataContext();
Dim query = (From p In dbContext.Products _
            Where p.ProductName == "Aniseed Syrup" _
            Select p).Skip(300).Take(15)
Dim products As IEnumerable(Of Product) = query.ToList()
' #endregion
End Class
