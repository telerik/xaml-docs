Public Class Default_Vb


' #region consuming-data-net-ria-service_1
Dim riaContext As New SampleRiaContext()
' #endregion

' #region consuming-data-net-ria-service_3
Dim loadOperation As LoadOperation(Of Categories) = riaContext.Load(Of Categories)(riaContext.GetCategoriesQuery())
AddHandler loadOperation.Completed, AddressOf loadOperation_Completed
' #endregion

' #region consuming-data-net-ria-service_5
Private Sub loadOperation_Completed(ByVal sender As Object, ByVal e As EventArgs)
    'Consume the result
    Dim result As List(Of Categories) = riaContext.Categories.ToList()
End Sub
' #endregion
End Class
