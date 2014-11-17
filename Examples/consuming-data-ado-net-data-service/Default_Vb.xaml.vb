Public Class Default_Vb


' #region consuming-data-ado-net-data-service_1
Dim northwindEntity As New NorthwindEntities(New Uri("http://localhost:54248/Services/SampleAdoNetDataService.svc/"))
' #endregion

' #region consuming-data-ado-net-data-service_3
Public Shared Sub BeginLoadingProducts(ByVal category As Categories)
    Dim categoryProducts As DataServiceQuery(Of Products) = northwindEntity.CreateQuery(Of Products)(String.Format("Categories({0})/Products", category.CategoryID)).Expand("Suppliers").Expand("Categories")
    categoryProducts.BeginExecute(Function(ByVal result As IAsyncResult) EntitiesLoaded(Of Products)(result, category.Products), categoryProducts)
End Sub
Private Shared Sub EntitiesLoaded(Of T)(ByVal result As IAsyncResult, ByVal entities As Collection(Of T))
    Dim query As DataServiceQuery(Of T) = TryCast(result.AsyncState, DataServiceQuery(Of T))
    For Each entity As T In query.EndExecute(result)
        entities.Add(entity)
    Next
End Sub
' #endregion

' #region consuming-data-ado-net-data-service_5
For Each c As Categories In northwindEntity.Categories.Execute()
    Me.Categories.Add(c)
Next
' #endregion
End Class
