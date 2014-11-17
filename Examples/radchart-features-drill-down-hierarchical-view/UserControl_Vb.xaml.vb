Public Class Default_Vb


' #region radchart-features-drill-down-hierarchical-view_1
Public Class Company
 Public Property Name() As String
 Public Property Sales() As ModelSalesCollection
End Class
' #endregion

' #region radchart-features-drill-down-hierarchical-view_3
Public Class ModelSalesCollection
 Inherits List(Of ModelSales)
 Public ReadOnly Property TotalAmount() As Double
  Get
   Return Me.Sum(Function(modelSales) modelSales.Amount)
  End Get
 End Property
End Class
' #endregion

' #region radchart-features-drill-down-hierarchical-view_5
Public Class ModelSales
 Public Property Model() As String
 Public Property Amount() As Double
 Public Sub New(ByVal model As String, ByVal amount As Double)
  Me.Model = model
  Me.Amount = amount
 End Sub
End Class
' #endregion

' #region radchart-features-drill-down-hierarchical-view_7
Private Function GetChartData() As List(Of Company)
 Return New List(Of Company)() _
     From {New Company() With {.Name="ToyYoda", .Sales = New ModelSalesCollection()
             From { New ModelSales("Coolla", 120000), New ModelSales("Coolla", 115000), New ModelSales("Veso", 89000), New ModelSales("Veso", 79000) }}, New Company() With {.Name="Marda", .Sales = New ModelSalesCollection()
             From { New ModelSales("Tree", 145000), New ModelSales("Tree", 132000), New ModelSales("Six", 121000), New ModelSales("Six", 111000) }}}
End Function
' #endregion
End Class
