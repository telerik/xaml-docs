Public Class Default_Vb


' #region gridview-paging-using-silverlight-datapager_3
Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
' #endregion

' #region gridview-paging-using-silverlight-datapager_5
Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
dataPager.Source = qcv
radGridView.ItemsSource = qcv
' #endregion
End Class
