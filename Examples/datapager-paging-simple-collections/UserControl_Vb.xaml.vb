Public Class Default_Vb


' #region datapager-paging-simple-collections_1
Dim itemsSource As IEnumerable = Enumerable.Range(0, 1000)
Dim pagedSource = New PagedCollectionView(itemsSource)
Me.radDataPager.Source = pagedSource
Me.itemsControl.ItemsSource = pagedSource
' #endregion

' #region datapager-paging-simple-collections_3
Dim itemsSource As IEnumerable = Enumerable.Range(0, 1000)
Dim pagedSource = New QueryableCollectionView(itemsSource)
Me.radDataPager.Source = pagedSource
Me.itemsControl.ItemsSource = pagedSource
' #endregion
End Class
