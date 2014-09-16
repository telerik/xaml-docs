Public Class Default_Vb


' #region gridview-overview-paging_3
Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
' #endregion

' #region gridview-overview-paging_5
Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
dataPager.Source = qcv
radGridView.ItemsSource = qcv
' #endregion
End Class
