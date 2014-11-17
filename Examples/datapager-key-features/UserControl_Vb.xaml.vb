Public Class Default_Vb


' #region datapager-key-features_2
Dim data As IEnumerable = Enumerable.Range(0, 1000)
Dim radDataPager As New RadDataPager()
radDataPager.PageSize = 10
radDataPager.Source = data
itemsControl.ItemsSource = radDataPager.PagedSource
' #endregion
End Class
