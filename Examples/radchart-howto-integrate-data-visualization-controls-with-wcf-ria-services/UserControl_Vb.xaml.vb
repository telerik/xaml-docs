Public Class Default_Vb


' #region radchart-howto-integrate-data-visualization-controls-with-wcf-ria-services_3
Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
Dim data As IEnumerable(Of FlightStatisticsView) = (TryCast(value, DataItemCollection)).Cast(Of FlightStatisticsView)()
Return (
From p In data
Select New FlightRecords() With {.Type = "Arrival", .TimeStamp = p.TimeStamp, .FlightCount = p.Arrivals}).Concat(
From p In data
Select New FlightRecords() With {.Type = "Departures", .TimeStamp = p.TimeStamp, .FlightCount = p.Departures})
End Function
' #endregion
End Class
