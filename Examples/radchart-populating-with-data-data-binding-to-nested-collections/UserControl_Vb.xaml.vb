Public Class Default_Vb


' #region radchart-populating-with-data-data-binding-to-nested-collections_1
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
   If code = "CSCO" Then
    tradeData = New ObservableCollection(Of TradeData)() With { _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 10), _
      .Open = 21.98, _
      .High = 22.12, _
      .Low = 21.5, _
      .Close = 21.64, _
      .Volume = 46602230 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 11), _
      .Open = 21.47, _
      .High = 21.53, _
      .Low = 21.06, _
      .Close = 21.17, _
      .Volume = 53545300 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 12), _
      .Open = 21.23, _
      .High = 21.61, _
      .Low = 21.18, _
      .Close = 21.43, _
      .Volume = 49330780 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 13), _
      .Open = 21.54, _
      .High = 21.65, _
      .Low = 21.34, _
      .Close = 21.51, _
      .Volume = 38914230 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 14), _
      .Open = 21.47, _
      .High = 21.55, _
      .Low = 21.0, _
      .Close = 21.31, _
      .Volume = 35131850 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 17), _
      .Open = 20.94, _
      .High = 20.96, _
      .Low = 20.68, _
      .Close = 20.73, _
      .Volume = 32361720 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 18), _
      .Open = 20.82, _
      .High = 21.15, _
      .Low = 20.79, _
      .Close = 21.01, _
      .Volume = 33300840 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 19), _
      .Open = 20.76, _
      .High = 21.44, _
      .Low = 20.74, _
      .Close = 21.24, _
      .Volume = 39197070 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 20), _
      .Open = 21.25, _
      .High = 21.96, _
      .Low = 21.2, _
      .Close = 21.89, _
      .Volume = 55194380 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 21), _
      .Open = 22.08, _
      .High = 22.27, _
      .Low = 21.77, _
      .Close = 22.19, _
      .Volume = 56572840 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 24), _
      .Open = 22.22, _
      .High = 22.64, _
      .Low = 21.93, _
      .Close = 22.06, _
      .Volume = 52670800 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 25), _
      .Open = 22.155, _
      .High = 22.25, _
      .Low = 21.85, _
      .Close = 22.0, _
      .Volume = 28401080 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 26), _
      .Open = 21.91, _
      .High = 22.0, _
      .Low = 21.81, _
      .Close = 21.93, _
      .Volume = 33523570 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 27), _
      .Open = 21.67, _
      .High = 21.91, _
      .Low = 21.47, _
      .Close = 21.88, _
      .Volume = 30278510 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 28), _
      .Open = 22.15, _
      .High = 22.35, _
      .Low = 21.8, _
      .Close = 22.0, _
      .Volume = 35933920 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 8, 31), _
      .Open = 21.74, _
      .High = 21.84, _
      .Low = 21.51, _
      .Close = 21.6, _
      .Volume = 31401760 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 9, 1), _
      .Open = 21.46, _
      .High = 21.87, _
      .Low = 21.08, _
      .Close = 21.17, _
      .Volume = 48741440 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 9, 2), _
      .Open = 21.09, _
      .High = 21.73, _
      .Low = 21.07, _
      .Close = 21.55, _
      .Volume = 40225600 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 9, 3), _
      .Open = 21.73, _
      .High = 21.9, _
      .Low = 21.34, _
      .Close = 21.49, _
      .Volume = 33830210 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 9, 4), _
      .Open = 21.59, _
      .High = 21.96, _
      .Low = 21.4, _
      .Close = 21.84, _
      .Volume = 28951200 _
     }, _
     New TradeData() With { _
      .Emission = "CSCO", _
      .FromDate = New DateTime(2009, 9, 8), _
      .Open = 22.0, _
      .High = 22.21, _
      .Low = 21.79, _
      .Close = 21.92, _
      .Volume = 37912164 _
     } _
    }
   Else
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
   End If
   Return tradeData
  End Function
 End Class
End Namespace
' #endregion

' #region radchart-populating-with-data-data-binding-to-nested-collections_5
Dim sampleData As New List(Of ObservableCollection(Of TradeData))()
sampleData.Add(TradeData.GetWeeklyData("CSCO"))
sampleData.Add(TradeData.GetWeeklyData("MSFT"))
Me.radChart.ItemsSource = sampleData
' #endregion

' #region radchart-populating-with-data-data-binding-to-nested-collections_7
Dim sampleData As New List(Of ObservableCollection(Of TradeData))()
sampleData.Add(TradeData.GetWeeklyData("CSCO"))
sampleData.Add(TradeData.GetWeeklyData("MSFT"))
'Series mapping for the collection with index 0
Dim seriesMapping As New SeriesMapping()
seriesMapping.CollectionIndex = 0
seriesMapping.LegendLabel = "CSCO"
seriesMapping.SeriesDefinition = New LineSeriesDefinition()
seriesMapping.SeriesDefinition.ShowItemLabels = False
Dim itemMapping As New ItemMapping()
itemMapping.DataPointMember = DataPointMember.YValue
itemMapping.FieldName = "Close"
seriesMapping.ItemMappings.Add(itemMapping)
Me.radChart.SeriesMappings.Add(seriesMapping)
'Series mapping for the collection with index 1
seriesMapping = New SeriesMapping()
seriesMapping.CollectionIndex = 1
seriesMapping.LegendLabel = "MSFT"
seriesMapping.SeriesDefinition = New LineSeriesDefinition()
seriesMapping.SeriesDefinition.ShowItemLabels = False
itemMapping = New ItemMapping()
itemMapping.DataPointMember = DataPointMember.YValue
itemMapping.FieldName = "Close"
seriesMapping.ItemMappings.Add(itemMapping)
Me.radChart.SeriesMappings.Add(seriesMapping)
Me.radChart.ItemsSource = sampleData
' #endregion
End Class
