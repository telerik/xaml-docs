Public Class Default_Vb


' #region radchart-howto-customize-chart-legend-add-scrollviewer_2
Public Sub New()
InitializeComponent()
Dim r As New Random()
Dim myArray(99) As Integer
For i As Integer = 0 To myArray.Length - 1
myArray(i) = r.Next(0, 100)
Next i
RadChart1.ItemsSource = myArray
RadChart1.DefaultView.ChartArea.EnableAnimations = False
RadChart1.DefaultView.ChartLegend.Width = 200
RadChart1.DefaultSeriesDefinition.LegendDisplayMode = LegendDisplayMode.DataPointLabel
RadChart1.DefaultView.ChartLegend.Style = CType(Me.Resources("ChartLegendStyle"), Style)
End Sub
' #endregion
End Class
