Public Class Default_Vb


' #region gridview-programmatic-grouping-definition_1
Public Sub New()
  InitializeComponent()
  Dim shipCountry As New GroupDescriptor()
  shipCountry.Member = "ShipCountry"
  shipCountry.SortDirection = ListSortDirection.Ascending
  Me.GridView.GroupDescriptors.Add(shipCountry)
End Sub
' #endregion

' #region gridview-programmatic-grouping-definition_4
Dim shipCountry As New GroupDescriptor()
shipCountry.Member = "ShipCountry"
shipCountry.SortDirection = ListSortDirection.Ascending
Dim countFunction As New CountFunction()
countFunction.Caption = "Invoices count: "
shipCountry.AggregateFunctions.Add(countFunction)
Dim firstFunction As New FirstFunction()
firstFunction.Caption = "First City: "
shipCountry.AggregateFunctions.Add(firstFunction)
Me.GridView.GroupDescriptors.Add(shipCountry)
' #endregion
End Class
