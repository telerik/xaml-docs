Public Class Default_Vb
' #region radtimeline-features-annotations_0
Public Class RadTimelineAnnotationsViewModel
	Public Sub New()
		Me.PeriodStart = New DateTime(2011, 1, 1)
		Me.PeriodEnd = New DateTime(2012, 1, 1)

		Me.GenerateTimelineData()
		Me.GenerateTimelineAnnotationsData()
	End Sub

	Public Property PeriodStart() As DateTime
		Get
			Return m_PeriodStart
		End Get
		Set
			m_PeriodStart = Value
		End Set
	End Property
	Private m_PeriodStart As DateTime

	Public Property PeriodEnd() As DateTime
		Get
			Return m_PeriodEnd
		End Get
		Set
			m_PeriodEnd = Value
		End Set
	End Property
	Private m_PeriodEnd As DateTime

	Public Property TimelineItems() As List(Of RadTimelineDataItem)
		Get
			Return m_TimelineItems
		End Get
		Set
			m_TimelineItems = Value
		End Set
	End Property
	Private m_TimelineItems As List(Of RadTimelineDataItem)

	Public Property TimelineAnnotationItems() As List(Of RadTimelineAnnotationDataItem)
		Get
			Return m_TimelineAnnotationItems
		End Get
		Set
			m_TimelineAnnotationItems = Value
		End Set
	End Property
	Private m_TimelineAnnotationItems As List(Of RadTimelineAnnotationDataItem)

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

	Private Sub GenerateTimelineAnnotationsData()
		Dim r As New Random()
		Dim items As New List(Of RadTimelineAnnotationDataItem)()

		Dim [date] As DateTime = Me.PeriodStart
		While [date] < Me.PeriodEnd
			items.Add(New RadTimelineAnnotationDataItem() With { _
				.StartDate = [date], _
				.Duration = TimeSpan.FromDays(r.[Next](2, 5)), _
				.Content = [date].ToShortDateString(), _
				.ZIndex = r.[Next](0, 300) _
			})
			[date] = [date].AddDays(7)
		End While

		Me.TimelineAnnotationItems = items
	End Sub
End Class

Public Class RadTimelineDataItem
	Public Property StartDate() As DateTime
		Get
			Return m_StartDate
		End Get
		Set
			m_StartDate = Value
		End Set
	End Property
	Private m_StartDate As DateTime

	Public Property Duration() As TimeSpan
		Get
			Return m_Duration
		End Get
		Set
			m_Duration = Value
		End Set
	End Property
	Private m_Duration As TimeSpan
End Class

Public Class RadTimelineAnnotationDataItem
	Public Property StartDate() As DateTime
		Get
			Return m_StartDate
		End Get
		Set
			m_StartDate = Value
		End Set
	End Property
	Private m_StartDate As DateTime

	Public Property Duration() As TimeSpan
		Get
			Return m_Duration
		End Get
		Set
			m_Duration = Value
		End Set
	End Property
	Private m_Duration As TimeSpan

	Public Property Content() As String
		Get
			Return m_Content
		End Get
		Set
			m_Content = Value
		End Set
	End Property
	Private m_Content As String

	Public Property ZIndex() As Integer
		Get
			Return m_ZIndex
		End Get
		Set
			m_ZIndex = Value
		End Set
	End Property
	Private m_ZIndex As Integer
End Class
' #endregion

End Class
