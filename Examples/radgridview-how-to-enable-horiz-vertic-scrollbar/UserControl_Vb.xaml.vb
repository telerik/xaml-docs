Public Class Default_Vb


' #region radgridview-how-to-enable-horiz-vertic-scrollbar_2
Private Sub EnableScrollBars()
    ScrollViewer.SetHorizontalScrollBarVisibility(Me.radGridView, ScrollBarVisibility.Visible)
    ScrollViewer.SetVerticalScrollBarVisibility(Me.radGridView, ScrollBarVisibility.Visible)
End Sub
' #endregion
End Class
