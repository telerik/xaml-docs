Public Class Default_Vb


' #region gridview-find-control-row-details_3
Private Sub gridView_LoadingRowDetails(sender As Object, e As GridViewRowDetailsEventArgs)
  Dim countries As RadComboBox = TryCast(e.DetailsElement.FindName("rcbCountries"), RadComboBox)
  countries.ItemsSource = GetCountries()
End Sub
' #endregion
End Class
