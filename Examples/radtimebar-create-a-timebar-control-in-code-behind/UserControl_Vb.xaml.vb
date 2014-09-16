Public Class Default_Vb


' #region radtimebar-create-a-timebar-control-in-code-behind_1
InitializeComponent()
Dim sparkline As New RadAreaSparkline()
Dim r As New Random()
Dim data As New List(Of Integer)()
Dim currentDate As Date = Date.Today
Do While currentDate < Date.Today.AddDays(100)
  data.Add(r.Next(0, 60))
  currentDate = currentDate.AddDays(1)
Loop
sparkline.ItemsSource = data
' #endregion

' #region radtimebar-create-a-timebar-control-in-code-behind_3
Dim timebar As New RadTimeBar()
   timebar.BeginInit()
   timebar.Width = 950
   timebar.Height = 250
   timebar.PeriodStart = New Date(2010, 1, 1)
   timebar.PeriodEnd = New Date(2012, 1, 1)
   timebar.VisiblePeriodStart = New Date(2010, 2, 14)
   timebar.VisiblePeriodEnd = New Date(2011, 6, 2)
   timebar.SelectionStart = New Date(2010, 5, 14)
   timebar.SelectionEnd = New Date(2010, 6, 14)
   timebar.Intervals.Add(New MonthInterval())
   timebar.Intervals.Add(New WeekInterval())
   timebar.Intervals.Add(New DayInterval())
   timebar.EndInit()
   timebar.Content = sparkline
   Me.Content = timebar
' #endregion
End Class
