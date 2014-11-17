Public Class Default_Vb


' #region gridview-events-validation_2
AddHandler Me.radGridView.CellValidating, AddressOf radGridView_CellValidating
' #endregion

' #region gridview-events-validation_4
Private Sub radGridView_CellValidating(ByVal sender As Object, ByVal e As GridViewCellValidatingEventArgs)
    If e.Cell.Column.UniqueName = "CountryId" Then
        Dim newValue As Integer = Int32.Parse(e.NewValue.ToString())
        If newValue < 0 OrElse newValue > 12 Then
            e.IsValid = False
            e.ErrorMessage = "The entered value must be between 0 and 12"
        End If
    End If
End Sub
' #endregion

' #region gridview-events-validation_7
AddHandler Me.radGridView.CellValidated, AddressOf radGridView_CellValidated
' #endregion

' #region gridview-events-validation_10
AddHandler Me.radGridView.RowValidating, AddressOf radGridView_RowValidating
' #endregion

' #region gridview-events-validation_13
AddHandler Me.radGridView.RowValidated, AddressOf radGridView_RowValidated
' #endregion
End Class

' #region gridview-events-validation_16
Private Sub radGridView_RowValidating(ByVal sender As Object, ByVal e As GridViewRowValidatingEventArgs)
    e.IsValid = False
End Sub
' #endregion
