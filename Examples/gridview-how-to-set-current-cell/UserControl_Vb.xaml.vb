Public Class Default_Vb


' #region gridview-how-to-set-current-cell_1
Public Sub New()
 InitializeComponent()
 AddHandler gridView.DataLoaded, AddressOf gridView_DataLoaded
End Sub
Private Sub gridView_DataLoaded(sender As Object, e As EventArgs)
 Dispatcher.BeginInvoke(New Action(Function() Do
   gridView.CurrentCellInfo = New GridViewCellInfo(gridView.Items(5), gridView.Columns("Text"))
   gridView.Focus()
 End Function))
End Sub
' #endregion
End Class
