Public Class Default_Vb


' #region radchart-features-format-expressions_1
Public Class TradeData
    Private _Emission As String
    Public Property Emission() As String
        Get
            Return _Emission
        End Get
        Set(ByVal value As String)
            _Emission = value
        End Set
    End Property
    Private _FromDate As DateTime
    Public Property FromDate() As DateTime
        Get
            Return _FromDate
        End Get
        Set(ByVal value As DateTime)
            _FromDate = value
        End Set
    End Property
    Private _ToDate As DateTime
    Public Property ToDate() As DateTime
        Get
            Return _ToDate
        End Get
        Set(ByVal value As DateTime)
            _ToDate = value
        End Set
    End Property
    Private _Open As Double
    Public Property Open() As Double
        Get
            Return _Open
        End Get
        Set(ByVal value As Double)
            _Open = value
        End Set
    End Property
    Private _High As Double
    Public Property High() As Double
        Get
            Return _High
        End Get
        Set(ByVal value As Double)
            _High = value
        End Set
    End Property
    Private _Low As Double
    Public Property Low() As Double
        Get
            Return _Low
        End Get
        Set(ByVal value As Double)
            _Low = value
        End Set
    End Property
    Private _Close As Double
    Public Property Close() As Double
        Get
            Return _Close
        End Get
        Set(ByVal value As Double)
            _Close = value
        End Set
    End Property
    Private _Volume As Double
    Public Property Volume() As Double
        Get
            Return _Volume
        End Get
        Set(ByVal value As Double)
            _Volume = value
        End Set
    End Property
    Private _Comment As String
    Public Property Comment() As String
        Get
            Return _Comment
        End Get
        Set(ByVal value As String)
            _Comment = value
        End Set
    End Property
End Class
' #endregion

' #region radchart-features-format-expressions_4
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "#VAL{C2}"
Dim seriesMapping As New SeriesMapping()
seriesMapping.SeriesDefinition = New LineSeriesDefinition()
seriesMapping.SeriesDefinition.ShowItemToolTips = True
seriesMapping.SeriesDefinition.ItemLabelFormat = "#Y{C2}"
seriesMapping.SeriesDefinition.ItemToolTipFormat = 
    "High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}" & vbLf & "Volume: #DATAITEM.Volume{#,###,###,##0}"
seriesMapping.ItemMappings.Add(New ItemMapping("Close", DataPointMember.YValue))
seriesMapping.ItemMappings.Add(New ItemMapping("FromDate", DataPointMember.XValue))
radChart.SeriesMappings.Add(seriesMapping)
' #endregion
End Class
