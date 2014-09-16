Public Class Default_Vb


' #region gridview-column-resize-event_2
AddHandler gridView.ColumnWidthChanging, AddressOf gridView_ColumnWidthChanging
AddHandler gridView.ColumnWidthChanged, AddressOf gridView_ColumnWidthChanged
' #endregion

' #region gridview-column-resize-event_4
Public Sub New()
 InitializeComponent()
 AddHandler gridView.ColumnWidthChanging, AddressOf gridView_ColumnWidthChanging
End Sub
Private Sub gridView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs)
 'if we shrink the column
 If e.HorizontalChangeWidth < 0 Then
  'cancel the event
  e.Cancel = True
 End If
End Sub
' #endregion
End Class
