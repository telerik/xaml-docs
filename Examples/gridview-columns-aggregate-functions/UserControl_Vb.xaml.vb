Public Class Default_Vb


' #region gridview-columns-aggregate-functions_3
Dim f As New CountFunction()
DirectCast(Me.radGridView.Columns("ID"), GridViewDataColumn).AggregateFunctions.Add(f)
' #endregion
End Class
