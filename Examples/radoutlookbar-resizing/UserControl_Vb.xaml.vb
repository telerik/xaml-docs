Public Class Default_Vb
#Region "radoutlookbar-resizing_0"
	Private Sub RadOutlookBar1_ItemPositionChanged(ByVal sender As Object, ByVal e As PositionChangedEventArgs)
		Dim outlookBarItem As RadOutlookBarItem = TryCast(e.OriginalSource, RadOutlookBarItem)
		Dim oldPosition As OutlookBarItemPosition = e.OldPosition
		Dim newPosition As OutlookBarItemPosition = e.NewPosition
	End Sub
#End Region
End Class
