Public Class Default_Vb


' #region carousel-data-binding_1
Me.RadCarousel1.ItemsSource = GetDataTable()
' #endregion

' #region carousel-data-binding_3
radCarousel1.DataMember = "Orders"
radCarousel1.ItemsSource = dataSet
' #endregion
End Class
