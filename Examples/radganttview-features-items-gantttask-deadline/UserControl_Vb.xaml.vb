Public Class Default_Vb

' #region radganttview-features-items-gantttask-deadline_0
Dim task = New GanttTask() With { _
	.Start = New DateTime(2014, 6, 6), _
	.[End] = New DateTime(2014, 6, 8), _
	.Deadline = New DateTime(2014, 6, 9), _
	.Title = "Gantt Rendering" _
}
' #endregion

' #region radganttview-features-items-gantttask-deadline_1
Public Class CustomGanttTask
	Inherits GanttTask
	Protected Overrides Function CheckIsExpired() As Boolean
		Return Me.Deadline < Me.Start
	End Function
End Class
' #endregion
End Class
