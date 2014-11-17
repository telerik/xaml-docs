Public Class Default_Vb


' #region consuming-data-domain-datasource-support_5
Private Sub DomainDataSource_LoadedData(ByVal sender As Object, ByVal e As LoadedDataEventArgs)
    For Each c As Categories In e.AllEntities
        ' Process the data
    Next
End Sub
' #endregion
End Class
