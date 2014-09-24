Public Class Default_Vb
#Region "gridview-troubleshooting-cannot-insert-new-row_1"
    Private Sub ordersGrid_AddingNewDataItem(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs)
        e.NewObject = New Order() With { _
 .CustomerID = myCustomerID _
}
    End Sub
#End Region
End Class
