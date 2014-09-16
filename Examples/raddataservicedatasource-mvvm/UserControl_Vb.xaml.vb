Public Class Default_Vb


' #region raddataservicedatasource-mvvm_1
Dim ordersContext As New MyNorthwindEntities()
Dim ordersQuery As DataServiceQuery(Of Order) = ordersContext.Orders
Dim ordersView As New QueryableDataServiceCollectionView(Of Order)(Me.ordersContext, ordersQuery)
' #endregion
End Class
