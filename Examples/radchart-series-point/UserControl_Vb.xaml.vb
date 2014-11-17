Public Class UserControl_Vb

' #region radchartview_series_point_0
Public Class ChartViewModel
	Public Property SalesData() As ObservableCollection(Of PlotInfo)
		Get
			Return m_SalesData
		End Get
		Set
			m_SalesData = Value
		End Set
	End Property
	Private m_SalesData As ObservableCollection(Of PlotInfo)

	Private Shared ReadOnly rnd As New Random(123)

	Public Sub New()
		Dim startDate As New DateTime(2013, 6, 1)

		Dim sampleData = New ObservableCollection(Of PlotInfo)()

		'Generate test data
		For i As Integer = 0 To 999
			Dim item = New PlotInfo() With { _
				.[Date] = startDate.AddDays(i), _
				.Sales = rnd.[Next](-10000, CInt(10000 * Math.Sin(i / 100))) _
			}

			sampleData.Add(item)
		Next

		Me.SalesData = sampleData
	End Sub
End Class

Public Class PlotInfo
	Public Property [Date]() As DateTime
	Public Property Sales() As Double
End Class
' #endregion

End Class
