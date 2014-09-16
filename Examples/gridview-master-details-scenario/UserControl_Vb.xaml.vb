Public Class Default_Vb


' #region gridview-master-details-scenario_2
Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
' #endregion

' #region gridview-master-details-scenario_4
Dim qcv As New QueryableCollectionView(RadGridViewSampleData.GetEmployees())
Me.radGridView.ItemsSource = qcv
Me.dataPager.Source = qcv
Me.dataForm.ItemsSource = qcv
' #endregion
End Class
