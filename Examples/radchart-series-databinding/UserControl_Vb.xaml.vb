Public Class UserControl_Vb

#region radchart-series-databinding_1
Dim cartChart As New RadCartesianChart()
cartChart.HorizontalAxis = New CategoricalAxis()
cartChart.VerticalAxis = New LinearAxis()
Dim barSeries As New BarSeries() With {.ShowLabels = True}
cartChart.Series.Add(barSeries)
barSeries.ItemsSource = New Double() { 20, 30, 50, 10, 60, 40, 20, 80 }
Me.LayoutRoot.Children.Add(cartChart)
#endregion

#region radchart-series-databinding_3
Public Class Product
    Private _name As String
    Private _quantitySold As Double

    Public Property Name As String
        Get
            Return Me._name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property
    Public Property QuantitySold As Double
        Get
            Return Me._quantitySold
        End Get
        Set(value As Double)
            Me._quantitySold = value
        End Set
    End Property
End Class
#endregion

#region radchart-series-databinding_5
Dim nameBinding As PropertyNameDataPointBinding = New PropertyNameDataPointBinding
nameBinding.PropertyName = "Name"
Dim genericBinding As GenericDataPointBinding(Of Product, Double) = New GenericDataPointBinding(Of Product, Double)
genericBinding.ValueSelector = Function(product) product.QuantitySold
barSeries.CategoryBinding = nameBinding
barSeries.ValueBinding = genericBinding
barSeries.ItemsSource = dataSource
#endregion

#region radchart-series-databinding_7
Dim products As ObservableCollection(Of Product) = New ObservableCollection(Of Product)
' fill collection
Dim nameBinding As PropertyNameDataPointBinding = New PropertyNameDataPointBinding
nameBinding.PropertyName = "Name"
Dim genericBinding As GenericDataPointBinding(Of Product, Double) = New GenericDataPointBinding(Of Product, Double)
genericBinding.ValueSelector = Function(product) product.QuantitySold
barSeries.CategoryBinding = nameBinding
barSeries.ValueBinding = genericBinding
barSeries.ItemsSource = dataSource
#endregion

#region radchart-series-databinding_9
Dim dataSource(8) As Double
dataSource(0) = 20
dataSource(1) = 30
dataSource(2) = 50
dataSource(3) = 10
dataSource(4) = 60
dataSource(5) = 40
dataSource(6) = 20
dataSource(7) = 80
Dim barSeries As ChartSeries = Me.chart.Series(0)
barSeries.DataContext = dataSource
#endregion

End Class
