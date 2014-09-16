Public Class UserControl_Vb


' #region radchart-features-selection_2
public MainWindow()
	   Public Sub New()
			InitializeComponent()
			Dim series = TryCast(RadChart1.Series(0), ScatterPointSeries)
			series.XValueBinding = New PropertyNameDataPointBinding("XValue")
			series.YValueBinding = New PropertyNameDataPointBinding("YValue")
			series.ItemsSource = Me.GetData()
	   End Sub

		Private Function GetData() As List(Of ChartData)
			Dim rand As New Random()
			Dim data As New List(Of ChartData)()

			For i As Integer = 1 To 29
				data.Add(New ChartData() With {.XValue = i, .YValue = rand.Next(10, 100)})
			Next i

			Return data
		End Function
	}

	Public Class ChartData
		Public Property XValue() As Double

		Public Property YValue() As Double
	End Class
' #endregion

' #region radchart-features-selection_4
Private Sub RadChart1_SelectionChanged(sender As Object, e As ChartSelectionChangedEventArgs)
    'Handle selection of the current point
    If e.AddedPoints.Count > 0 Then
        ' Get the data point.
        Dim addedPoint = e.AddedPoints(0)
        ' Get the series.
        Dim series = TryCast(addedPoint.Presenter, ScatterPointSeries)

        'Your code here...
		
    End If

    'Handle de-selection of the current point
    If e.RemovedPoints.Count > 0 Then
        ' Get the data point.
        Dim removedPoint = e.RemovedPoints(0)
        ' Get the series.

        'Your code here...
		
        Dim series = TryCast(removedPoint.Presenter, LineSeries)
    End If
End Sub
' #endregion

' #region radchart-features-selection_6
Private Sub RadChart1_SelectionChanged(sender As Object, e As ChartSelectionChangedEventArgs)   
    'Handle selection of the current point
    If e.AddedPoints.Count > 0 Then
        Dim addedPoint = e.AddedPoints(0)
        Dim series = TryCast(addedPoint.Presenter, LineSeries)
        Dim pointPresenter = series.ChildrenOfType(Of ContentPresenter)().Where(Function(cp) cp.Tag = addedPoint).FirstOrDefault()
        Dim ellipseElement = pointPresenter.ChildrenOfType(Of Ellipse)().FirstOrDefault()

        'Do whatever you want with it :)
        ellipseElement.Fill = New SolidColorBrush(Colors.Red)
    End If
	
	'Handle de-selection of the current point
    If e.RemovedPoints.Count > 0 Then
        Dim removedPoint = e.RemovedPoints(0)
        Dim series = TryCast(removedPoint.Presenter, LineSeries)
        Dim pointPresenter = series.ChildrenOfType(Of ContentPresenter)().Where(Function(cp) cp.Tag = removedPoint).FirstOrDefault()
        Dim ellipseElement = pointPresenter.ChildrenOfType(Of Ellipse)().FirstOrDefault()

        'Do whatever you want with it :)
        ellipseElement.Fill = New SolidColorBrush(Colors.Yellow)
    End If
End Sub

' #endregion

  
End Class
