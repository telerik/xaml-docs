Public Class Default_Vb


' #region gridview-how-to-access-child-gridview_2
Private Sub employeeRadGridView_DataLoading(sender As Object, e As GridViewDataLoadingEventArgs)
 Dim dataControl As GridViewDataControl = DirectCast(sender, GridViewDataControl)
 If dataControl.ParentRow IsNot Nothing Then
  'dataControl is the child gridview
  dataControl.ShowGroupPanel = False
  Dim column As New GridViewDataColumn()
  column.DataMemberBinding = New Binding("EmployeeID")
  dataControl.Columns.Add(column)
  column = New GridViewDataColumn()
  column.DataMemberBinding = New Binding("FirstName")
  dataControl.Columns.Add(column)
  column = New GridViewDataColumn()
  column.DataMemberBinding = New Binding("LastName")
  dataControl.Columns.Add(column)
  column = New GridViewDataColumn()
  column.DataMemberBinding = New Binding("Title")
  dataControl.Columns.Add(column)
 End If
End Sub
' #endregion
End Class
