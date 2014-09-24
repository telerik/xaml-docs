Public Class Default_Vb
' #region radtimeline_features_vertical_scrolling_0
Public Class RadTimelineDataItem
	Public Property StartDate() As DateTime
	Public Property Duration() As TimeSpan
End Class

Public Class TimelineVerticalScrollBarVisibilityViewModel
	Public Sub New()
		Me.PeriodStart = New DateTime(2011, 1, 1)
		Me.PeriodEnd = New DateTime(2012, 1, 1)

		Me.GenerateTimelineData()
	End Sub

	Public Property PeriodStart() As DateTime

	Public Property PeriodEnd() As DateTime

	Public Property TimelineItems() As List(Of RadTimelineDataItem)

	Private Sub GenerateTimelineData()
		Dim r As New Random()
		Dim items As New List(Of RadTimelineDataItem)()

		Dim [date] As DateTime = Me.PeriodStart
		While [date] < Me.PeriodEnd
			items.Add(New RadTimelineDataItem() With { _
				.StartDate = [date], _
				.Duration = TimeSpan.FromDays(r.[Next](5, 10)) _
			})
			[date] = [date].AddDays(1)
		End While

		Me.TimelineItems = items
	End Sub
End Class
' #endregion

End Class
