Public Class Default_Vb


' #region gridview-export_1
Public Sub New()
 InitializeComponent()
 AddHandler btnExport.Click, AddressOf btnExport_Click
End Sub
Private Sub btnExport_Click(sender As Object, e As RoutedEventArgs)
 Dim extension As String = "xls"
 Dim dialog As New SaveFileDialog() With { _
  .DefaultExt = extension, _
  .Filter = [String].Format("{1} files (*.{0})|*.{0}|All files (*.*)|*.*", extension, "Excel"), _
  .FilterIndex = 1 _
 }
If dialog.ShowDialog() = True Then
  Using stream As Stream = dialog.OpenFile()
   gridViewExport.Export(stream, New GridViewExportOptions() With { _
    .Format = ExportFormat.Html, _
    .ShowColumnHeaders = True, _
    .ShowColumnFooters = True, _
    .ShowGroupFooters = False _
   })
  End Using
 End If
End Sub
' #endregion

' #region gridview-export_3
Imports Telerik.Windows.Controls
...
Dim htmlExport As String = Me.ExportGrid.ToHtml( True )
' #endregion
End Class
