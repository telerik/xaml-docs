Public Class Default_Vb
' #region radtimebar-overview_2
Dim r As New Random()
Dim LinearData As New List(Of Integer)()
Dim currentDate As Date = Date.Today
Do While currentDate < Date.Today.AddDays(365)
	LinearData.Add(r.Next(0, 60))
	currentDate = currentDate.AddDays(1)
Loop
Me.DataContext = LinearData
' #endregion
End Class
