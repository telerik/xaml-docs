Public Class Default_Vb


' #region chart-save-image_1
Dim chartStream As MemoryStream = CType(RadChart1.Save(), System.IO.MemoryStream)
Dim outStream As FileStream = File.OpenWrite("C:\MyChart.png")
chartStream.WriteTo(outStream)
outStream.Close()
' #endregion

' #region chart-save-image_3
Dim chartStream As MemoryStream = CType(RadChart1.Save(120, 120), System.IO.MemoryStream)
Dim outStream As FileStream = File.OpenWrite("C:\MyChart.jpg")
chartStream.WriteTo(outStream)
outStream.Close()
' #endregion

' #region chart-save-image_5
Dim chartStream As MemoryStream = CType(RadChart1.Save(120, 120, New System.Windows.Media.Imaging.JpegBitmapEncoder()), System.IO.MemoryStream)
Dim outStream As FileStream = File.OpenWrite("C:\MyChart.jpg")
chartStream.WriteTo(outStream)
outStream.Close()
' #endregion
End Class
