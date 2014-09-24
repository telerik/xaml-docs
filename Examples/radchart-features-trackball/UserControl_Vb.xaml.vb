Public Class UserControl_Vb


' #region radchart-features-trackball_4
Private Sub ChartTrackBallBehavior_TrackInfoUpdated(ByVal sender As Object, ByVal e As TrackBallInfoEventArgs)
   For Each info As DataPointInfo In e.Context.DataPointInfos
      info.DisplayHeader = "Custom data point header"
   Next
   e.Header = "Sample header"
End Sub
' #endregion
End Class
