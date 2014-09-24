Public Class Default_Vb


' #region raddatapager-features-source-and-paged-source_1
Dim itemsSource As IEnumerable = Enumerable.Range(0, 1000)
Dim pagedSource = New PagedCollectionView(itemsSource)
Me.radDataPager.Source = pagedSource
Me.itemsControl.ItemsSource = pagedSource
' #endregion

' #region raddatapager-features-source-and-paged-source_3
Dim itemsSource As IEnumerable = Enumerable.Range(0, 1000)
Dim pagedSource = New QueryableCollectionView(itemsSource)
Me.radDataPager.Source = pagedSource
Me.itemsControl.ItemsSource = pagedSource
' #endregion
End Class
