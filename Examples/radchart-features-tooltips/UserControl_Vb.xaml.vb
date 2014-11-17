Public Class Default_Vb


' #region radchart-features-tooltips_1
Imports System
Imports System.Collections.ObjectModel
Namespace Silverlight.Help.RadChartSamples
 Public Class TradeData
  Public Property Emission() As String
   Get
    Return m_Emission
   End Get
   Set
    m_Emission = Value
   End Set
  End Property
  Private m_Emission As String
  Public Property FromDate() As DateTime
   Get
    Return m_FromDate
   End Get
   Set
    m_FromDate = Value
   End Set
  End Property
  Private m_FromDate As DateTime
  Public Property ToDate() As DateTime
   Get
    Return m_ToDate
   End Get
   Set
    m_ToDate = Value
   End Set
  End Property
  Private m_ToDate As DateTime
  Public Property Open() As Double
   Get
    Return m_Open
   End Get
   Set
    m_Open = Value
   End Set
  End Property
  Private m_Open As Double
  Public Property High() As Double
   Get
    Return m_High
   End Get
   Set
    m_High = Value
   End Set
  End Property
  Private m_High As Double
  Public Property Low() As Double
   Get
    Return m_Low
   End Get
   Set
    m_Low = Value
   End Set
  End Property
  Private m_Low As Double
  Public Property Close() As Double
   Get
    Return m_Close
   End Get
   Set
    m_Close = Value
   End Set
  End Property
  Private m_Close As Double
  Public Property Volume() As Double
   Get
    Return m_Volume
   End Get
   Set
    m_Volume = Value
   End Set
  End Property
  Private m_Volume As Double
  Public Shared Function GetWeeklyData(code As String) As ObservableCollection(Of TradeData)
   Dim tradeData As ObservableCollection(Of TradeData)
   tradeData = New ObservableCollection(Of TradeData)() With { _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 10), _
     .Open = 23.46, _
     .High = 23.55, _
     .Low = 23.3, _
     .Close = 23.42, _
     .Volume = 35258950 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 11), _
     .Open = 23.32, _
     .High = 23.4, _
     .Low = 23.05, _
     .Close = 23.13, _
     .Volume = 33611790 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 12), _
     .Open = 23.13, _
     .High = 23.9, _
     .Low = 23.03, _
     .Close = 23.53, _
     .Volume = 61936270 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 13), _
     .Open = 23.63, _
     .High = 23.85, _
     .Low = 23.4, _
     .Close = 23.62, _
     .Volume = 38951990 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 14), _
     .Open = 23.62, _
     .High = 23.8, _
     .Low = 23.51, _
     .Close = 23.69, _
     .Volume = 46328540 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 17), _
     .Open = 23.32, _
     .High = 23.6, _
     .Low = 23.23, _
     .Close = 23.25, _
     .Volume = 42462890 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 18), _
     .Open = 23.29, _
     .High = 23.652, _
     .Low = 23.27, _
     .Close = 23.58, _
     .Volume = 38831620 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 19), _
     .Open = 23.25, _
     .High = 23.72, _
     .Low = 23.25, _
     .Close = 23.65, _
     .Volume = 41814320 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 20), _
     .Open = 23.6, _
     .High = 23.87, _
     .Low = 23.54, _
     .Close = 23.67, _
     .Volume = 39502680 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 21), _
     .Open = 23.93, _
     .High = 24.42, _
     .Low = 23.77, _
     .Close = 24.41, _
     .Volume = 68995700 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 24), _
     .Open = 24.41, _
     .High = 24.7326, _
     .Low = 24.28, _
     .Close = 24.64, _
     .Volume = 54159300 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 25), _
     .Open = 24.6, _
     .High = 24.82, _
     .Low = 24.46, _
     .Close = 24.64, _
     .Volume = 43961480 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 26), _
     .Open = 24.59, _
     .High = 24.75, _
     .Low = 24.42, _
     .Close = 24.55, _
     .Volume = 41060010 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 27), _
     .Open = 24.41, _
     .High = 24.78, _
     .Low = 24.3, _
     .Close = 24.69, _
     .Volume = 45433940 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 28), _
     .Open = 25.07, _
     .High = 25.49, _
     .Low = 24.61, _
     .Close = 24.68, _
     .Volume = 55789640 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 8, 31), _
     .Open = 24.57, _
     .High = 24.85, _
     .Low = 24.29, _
     .Close = 24.65, _
     .Volume = 49582950 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 9, 1), _
     .Open = 24.35, _
     .High = 24.74, _
     .Low = 23.9, _
     .Close = 24.0, _
     .Volume = 62571800 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 9, 2), _
     .Open = 23.82, _
     .High = 24.14, _
     .Low = 23.78, _
     .Close = 23.86, _
     .Volume = 40726040 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 9, 3), _
     .Open = 23.91, _
     .High = 24.14, _
     .Low = 23.76, _
     .Close = 24.11, _
     .Volume = 34110810 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 9, 4), _
     .Open = 24.09, _
     .High = 24.8001, _
     .Low = 24.08, _
     .Close = 24.62, _
     .Volume = 44987570 _
    }, _
    New TradeData() With { _
     .Emission = "MSFT", _
     .FromDate = New DateTime(2009, 9, 8), _
     .Open = 24.62, _
     .High = 24.84, _
     .Low = 24.41, _
     .Close = 24.82, _
     .Volume = 52243880 _
    } _
   }
   Return tradeData
  End Function
 End Class
End Namespace
' #endregion

' #region radchart-features-tooltips_6
Dim radChart As New Telerik.Windows.Controls.RadChart()
Dim seriesMapping As New SeriesMapping()
seriesMapping.SeriesDefinition = New CandleStickSeriesDefinition()
seriesMapping.SeriesDefinition.ShowItemToolTips = True
seriesMapping.SeriesDefinition.ItemToolTipFormat = "Open: #OPEN{C4} / Close: #CLOSE{C4}" & vbLf & "Volume: #DATAITEM.Volume{###,###,##0}"
seriesMapping.ItemMappings.Add(New ItemMapping("Open", DataPointMember.Open))
seriesMapping.ItemMappings.Add(New ItemMapping("High", DataPointMember.High))
seriesMapping.ItemMappings.Add(New ItemMapping("Low", DataPointMember.Low))
seriesMapping.ItemMappings.Add(New ItemMapping("Close", DataPointMember.Close))radChart.SeriesMappings.Add(seriesMapping)
' #endregion

' #region radchart-features-tooltips_9
Imports System.Windows.Controls
Imports System.Windows.Media
Namespace Silverlight.Help.RadChartSamples
 Public Partial Class StockToolTipControl
  Inherits UserControl
  Public Sub New()
   InitializeComponent()
  End Sub
  Public WriteOnly Property ChangeNetPercent() As Double
   Set
    Me.changeNetPercent.Text = value.ToString("p")
    Me.arrow.Fill = New SolidColorBrush(If(value < 0.0, Colors.Red, Colors.Green))
    Me.rotateTransform.Angle = If(value < 0.0, 0, 180)
   End Set
  End Property
  Public WriteOnly Property Volume() As Double
   Set
    Me.volume.Text = value.ToString(",##0")
   End Set
  End Property
  Public WriteOnly Property OneYearTargetEst() As Double
   Set
    Me.oneYearTargetEst.Text = value.ToString("C")
   End Set
  End Property
  Public WriteOnly Property PERatio() As Double
   Set
    Me.peRatio.Text = value.ToString("00.00")
   End Set
  End Property
  Public WriteOnly Property ForwardingPE() As Double
   Set
    Me.forwardingPE.Text = value.ToString("00.00")
   End Set
  End Property
 End Class
End Namespace
' #endregion

' #region radchart-features-tooltips_12
Private Sub ChartArea_ItemToolTipOpening(ByVal tooltip As ItemToolTip2D, ByVal e As ItemToolTipEventArgs)
    Dim tradeData As TradeData = TryCast(e.DataPoint.DataItem, TradeData)
    Dim stockToolTip As New StockToolTipControl()
    stockToolTip.ChangeNetPercent = 1 - (tradeData.Close / tradeData.Open)
    stockToolTip.Volume = tradeData.Volume
    'The next three properties shows some fictional data to illustrate the idea
    stockToolTip.OneYearTargetEst = tradeData.Close * 1.1
    stockToolTip.PERatio = 16.8R
    stockToolTip.ForwardingPE = 17.93
    tooltip.Content = stockToolTip
End Sub
' #endregion
End Class
