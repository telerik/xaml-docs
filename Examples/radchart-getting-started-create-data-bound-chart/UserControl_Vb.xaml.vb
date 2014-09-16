Public Class Default_Vb


' #region radchart-getting-started-create-data-bound-chart_2
Public Class ProductSales
    Public Sub New(ByVal quantity As Integer, ByVal month As Integer, ByVal monthName As String)
        Me.Quantity = quantity
        Me.Month = month
        Me.MonthName = monthName
    End Sub
Private _Quantity As Integer
    Public Property Quantity() As Integer
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Integer)
            _Quantity = value
        End Set
    End Property
Private _Month As Integer
    Public Property Month() As Integer
        Get
            Return _Month
        End Get
        Set(ByVal value As Integer)
            _Month = value
        End Set
    End Property
Private _MonthName As String
    Public Property MonthName() As String
        Get
            Return _MonthName
        End Get
        Set(ByVal value As String)
            _MonthName = value
        End Set
    End Property
End Class
' #endregion

' #region radchart-getting-started-create-data-bound-chart_4
Private Function CreateData() As List(Of ProductSales)
    Dim persons As New List(Of ProductSales)()
    persons.Add(New ProductSales(154, 1, "January"))
    persons.Add(New ProductSales(138, 2, "February"))
    persons.Add(New ProductSales(143, 3, "March"))
    persons.Add(New ProductSales(120, 4, "April"))
    persons.Add(New ProductSales(135, 5, "May"))
    persons.Add(New ProductSales(125, 6, "June"))
    persons.Add(New ProductSales(179, 7, "July"))
    persons.Add(New ProductSales(170, 8, "August"))
    persons.Add(New ProductSales(198, 9, "September"))
    persons.Add(New ProductSales(187, 10, "October"))
    persons.Add(New ProductSales(193, 11, "November"))
    persons.Add(New ProductSales(212, 12, "December"))
    Return persons
End Function
' #endregion

' #region radchart-getting-started-create-data-bound-chart_7
Dim seriesMapping As New SeriesMapping()
seriesMapping.LegendLabel = "Product Sales"
seriesMapping.SeriesDefinition = New SplineSeriesDefinition()
seriesMapping.ItemMappings.Add(New ItemMapping("Month", DataPointMember.XValue))
seriesMapping.ItemMappings.Add(New ItemMapping("Quantity", DataPointMember.YValue))
radChart.SeriesMappings.Add(seriesMapping)
Me.radChart.ItemsSource = Me.CreateData()
' #endregion

' #region radchart-getting-started-create-data-bound-chart_9
Me.radChart.ItemsSource = Me.CreateData()
' #endregion

' #region radchart-getting-started-create-data-bound-chart_12
seriesMapping.ItemMappings.Add(New ItemMapping("MonthName", DataPointMember.XCategory))
' #endregion
End Class
