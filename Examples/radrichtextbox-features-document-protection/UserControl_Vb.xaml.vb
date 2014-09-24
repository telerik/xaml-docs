Public Class Default_Vb


' #region radrichtextbox-features-data-providers_3
Private Sub XamlDataProvider_SetupDocument(sender As Object, e As Telerik.Windows.Documents.FormatProviders.SetupDocumentEventArgs)
 e.Document.LayoutMode = Telerik.Windows.Documents.Model.DocumentLayoutMode.Paged
End Sub
' #endregion
End Class
