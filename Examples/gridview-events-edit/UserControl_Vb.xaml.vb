Public Class Default_Vb


' #region gridview-events-edit_2
AddHandler Me.radGridView.BeginningEdit, AddressOf radGridView_BeginningEdit
' #endregion

' #region gridview-events-edit_4
Private Sub radGridView_BeginningEdit(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs)
    e.Cancel = True
End Sub
' #endregion

' #region gridview-events-edit_6
Private Sub radGridView_BeginningEdit(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs)
    If e.Cell.Column.UniqueName = "CustomerID" Then
        ToolTipService.SetToolTip(e.Cell, "Editing the ID may result in inconsistency in the database")
    End If
End Sub
' #endregion

' #region gridview-events-edit_8
Private Sub clubsGrid_PreparingCellForEdit(sender As Object, e As GridViewPreparingCellForEditEventArgs)
 If DirectCast(e.Column.Header, String) = "Name" Then
  Dim tb = TryCast(e.EditingElement, TextBox)
  tb.TextWrapping = TextWrapping.Wrap
 End If
End Sub
' #endregion

' #region gridview-events-edit_10
Private Sub clubsGrid_PreparedCellForEdit(sender As Object, e As GridViewPreparingCellForEditEventArgs)
 If DirectCast(e.Column.Header, String) = "Name" Then
  Dim tb = TryCast(e.EditingElement, TextBox)
  'remove the selection of the text
  tb.SelectionLength = 0
 End If
End Sub
' #endregion

' #region gridview-events-edit_13
AddHandler Me.radGridView.CellEditEnded, AddressOf radGridView_CellEditEnded
' #endregion

' #region gridview-events-edit_15
Private Sub radGridView_CellEditEnded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewCellEditEndedEventArgs)
    Dim editedEmployee As Employee = TryCast(e.Cell.DataContext, Employee)
    Dim propertyName As String = e.Cell.Column.UniqueName
    MessageBox.Show(String.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData))
End Sub
' #endregion

' #region gridview-events-edit_18
AddHandler Me.radGridView.RowEditEnded, AddressOf radGridView_RowEditEnded
' #endregion

' #region gridview-events-edit_20
Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewRowEditEndedEventArgs)
    Dim newEmployee As Employee = TryCast(e.NewData, Employee)
    If newEmployee IsNot Nothing Then
        textBlock1.Text = "e.NewData contains: " & newEmployee
    End If
End Sub
' #endregion
End Class
