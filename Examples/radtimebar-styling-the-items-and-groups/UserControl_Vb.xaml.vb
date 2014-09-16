Public Class Default_Vb

' #region radtimebar-styling-the-items-and-groups_1
    Dim r As New Random()
	Dim data As New List(Of Integer)()
	Dim currentDate As Date = Date.Today
	Do While currentDate < Date.Today.AddDays(100)
		data.Add(r.Next(0, 60))
		currentDate = currentDate.AddDays(1)
	Loop
	sparkline.ItemsSource = data
' #endregion

End Class
