Public Class Default_Vb


' #region using-data-virtualization_1
Public Sub New()
 InitializeComponent()
 Dim context = New NorthwindEntities()
 Dim query = context.Order_Details.OrderBy(Function(o) o.OrderID)
 Dim view = New VirtualQueryableCollectionView(query) With { _
  Key .LoadSize = 10 _
 }
 DataContext = view
End Sub
' #endregion

' #region using-data-virtualization_4
Public Sub New()
 InitializeComponent()
 Dim context = New NorthwindDomainContext()
 Dim query = context.GetOrder_DetailsQuery().OrderBy(Function(o) o.OrderID)
 query.IncludeTotalCount = True
 Dim view = New VirtualQueryableCollectionView() With { _
  Key .LoadSize = 10, _
  Key .VirtualItemCount = 100 _
 }
 view.ItemsLoading += Function(s, e)
 context.Load(Of Order_Detail)(query.Skip(e.StartIndex).Take(e.ItemCount)).Completed += Function(sender, args)
 Dim lo = DirectCast(sender, LoadOperation)
 If lo.TotalEntityCount <> -1 AndAlso lo.TotalEntityCount <> view.VirtualItemCount Then
  view.VirtualItemCount = lo.TotalEntityCount
 End If
 view.Load(e.StartIndex, lo.Entities)
End Function
End Function
 DataContext = view
End Sub
' #endregion
End Class
