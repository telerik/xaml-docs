Public Class Default_Vb


' #region gridview-columns-data-formatting_2
DirectCast(Me.radGridView.Columns("OrderDate"), GridViewDataColumn).DataFormatString = "{0:dd, MMM, yyyy}"
    ' or
DirectCast(Me.radGridView.Columns("OrderDate"), GridViewDataColumn).DataFormatString = "dd, MMM, yyyy"
' #endregion
End Class
