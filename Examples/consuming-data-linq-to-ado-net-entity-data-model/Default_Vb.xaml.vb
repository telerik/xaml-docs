Public Class Default_Vb


' #region consuming-data-linq-to-ado-net-entity-data-model_1
Dim dbContext As New NorthwindEntities()
Dim query = From p In dbContext.ProductSet _
    Where p.Categories.CategoryName = "Seafood" _
    Select p
Dim products As IEnumerable(Of Product) = query.ToList()
' #endregion

' #region consuming-data-linq-to-ado-net-entity-data-model_3
Dim dbContext As New NorthwindEntities()
Dim query = From p In dbContext.ProductSet_
            Where p.ProductName = "Aniseed Syrup" _
            Select p
product.UnitPrice = 1000
dbContext.SaveChanges()
' #endregion

' #region consuming-data-linq-to-ado-net-entity-data-model_5
Dim dbContext As New NorthwindEntities()
Dim category As New Category()
category.CategoryName = "Test Category"
Dim firstProduct As New Product()
firstProduct.ProductName = "Test Product 1"
Dim secondProduct As New Product()
secondProduct.ProductName = "Test Product 2"
category.Products.Add(firstProduct)
category.Products.Add(secondProduct)
dbContext.AddToCategorySet(category)
dbContext.SaveChanges()
' #endregion

' #region consuming-data-linq-to-ado-net-entity-data-model_7
Dim dbContext As New NorthwindEntities()
Dim query = From p In dbContext.ProductSet _
    Where p.ProductName.Contains("Test") _
    Select p
For Each p As Product In query
    dbContext.DeleteObject(p)
Next
dbContext.SaveChanges()
' #endregion

' #region consuming-data-linq-to-ado-net-entity-data-model_9
Dim dbContext As New NorthwindEntities()
Dim query = (From p In dbContext.ProductSet _
    Where p.Categories.CategoryName = "Aniseed Syrup" _
    Select p).Skip(300).Take(15)
Dim products As IEnumerable(Of Product) = query.ToList()
' #endregion
End Class
