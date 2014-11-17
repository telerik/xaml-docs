Public Class Default_Vb
' #region radtimeline_formatter_provider_0
Imports Telerik.Windows.Controls.TimeBar

Public Class HourFormatterProvider
Implements IIntervalFormatterProvider
    Private Shared formatters As Func(Of DateTime, String)()
    Private intervalSpanFormatters As Func(Of DateTime, String)()

    Shared Sub New()
        formatters = New Func(Of DateTime, String)() {Function([date]) [date].ToString("H:mm"), Function([date]) [date].ToString("HH")}
    End Sub

    Public Function GetFormatters(interval As IntervalBase) As Func(Of DateTime, String)() Implements IIntervalFormatterProvider.GetFormatters
        Return formatters
    End Function

    Public Function GetIntervalSpanFormatters(interval As IntervalBase) As Func(Of DateTime, String)() Implements IIntervalFormatterProvider.GetIntervalSpanFormatters
        If Me.intervalSpanFormatters Is Nothing Then
            Me.intervalSpanFormatters = New Func(Of DateTime, String)() _
            {Function([date]) [String].Format("{0} - {1}", [date].ToString("dddd H:mm"), interval.IncrementByCurrentInterval([date]).ToString("H:mm"))}
        End If

        Return Me.intervalSpanFormatters
    End Function
End Class
' #endregion

' #region radtimeline_formatter_provider_1
' #endregion
End Class
