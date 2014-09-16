Public Class Default_Vb


' #region radchart-features-chart-export_1
Dim dialog As New SaveFileDialog()
dialog.DefaultExt = "*.xls"
dialog.Filter = "Files(*.xls)|*.xls"
If Not CBool(dialog.ShowDialog()) Then
    Return
End If
Dim fileStream As Stream = dialog.OpenFile()
radChart.ExportToExcelML(fileStream)
fileStream.Close()
' #endregion

' #region radchart-features-chart-export_3
Dim dialog As New SaveFileDialog()
dialog.DefaultExt = "*.xls"
dialog.Filter = "Files(*.xls)|*.xls"
If Not CBool(dialog.ShowDialog()) Then
    Return
End If
radChart.ExportToExcelML(dialog.FileName)
fileStream.Close()
' #endregion
End Class
