Public Class Default_Vb


' #region consuming-data-web-asmx-service_1
Dim serviceClient As New WebService.SampleWebServiceSoapClient()
' #endregion

' #region consuming-data-web-asmx-service_3
AddHandler serviceClient.LoadCategoriesCompleted, AddressOf serviceClient_LoadCategoriesCompleted
serviceClient.LoadCategoriesAsync()
' #endregion

' #region consuming-data-web-asmx-service_5
For Each c As Categories In serviceClient.LoadCategories()
    Me.Categories.Add(c)
Next
' #endregion

' #region consuming-data-web-asmx-service_7
Private Sub serviceClient_LoadCategoriesCompleted(ByVal sender As Object, ByVal e As LoadCategoriesCompletedEventArgs)
    If e.[Error] Is Nothing AndAlso e.Result IsNot Nothing Then
        'Consume the result
        For Each c As Categories In e.Result
            Me.Categories.Add(c)
        Next
    End If
End Sub
' #endregion
End Class
