Public Class UserControl_Vb


' #region radchart-axes-datetimeaxes_2
Public Sub New()
   InitializeComponent()

   Dim lastDate As DateTime = DateTime.Now
   Dim lastVal As Double = 20

   Dim dataSource As List(Of ChartDataObject) = New List(Of ChartDataObject)
   For i As Integer = 0 To 5 Step 1
      Dim obj As ChartDataObject = New ChartDataObject
      obj.Date = lastDate.AddMonths(1)
      obj.Value = lastVal

      lastVal += 1
	  dataSouce.Add(obj)
      lastDate = obj.Date
   Next

   Dim series As LineSeries = DirectCast(Me.chart.Series(0), LineSeries)

   Dim categoryBinding As PropertyNameDataPointBinding = New PropertyNameDataPointBinding
   categoryBinding.PropertyName = "Date"

   Dim valueBinding As PropertyNameDataPointBinding = New PropertyNameDataPointBinding
   valueBinding.PropertyName = "Value"

   series.CategoryBinding = categoryBinding
   series.ValueBinding = valueBinding
   series.ItemsSource = dataSource
End Sub
' #endregion

' #region radchart-axes-datetimeaxes_4
Public Class ChartDataObject
    Dim _date As Date
    Dim _value As Double

    Public Property [Date]() As DateTime
        Get
            Return Me._date
        End Get
        Set(value As DateTime)
            Me._date = value
        End Set
    End Property

    Public Property Value() As Double
        Get
            Return Me._value
        End Get
        Set(value As Double)
            Me._value = value
        End Set
    End Property
End Class
' #endregion
End Class
