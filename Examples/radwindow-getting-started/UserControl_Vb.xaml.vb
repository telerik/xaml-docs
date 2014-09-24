Public Class Default_Vb


' #region radwindow-getting-started_1
Dim radWindow As New RadWindow()
radWindow.Width = 400
radWindow.Height = 300
' #endregion

' #region radwindow-getting-started_3
radWindow.Show()
' #endregion

' #region radwindow-getting-started_5
Dim grid As New Grid()
grid.Background = New SolidColorBrush(Color.FromArgb(255, 240, 255, 255))
radWindow.Content = grid
' #endregion

' #region radwindow-getting-started_7
RadWindow.Alert( "Hello!" )
' #endregion

' #region radwindow-getting-started_9
Dim parameters As New DialogParameters()
parameters.Content = "Are you sure?"
RadWindow.Confirm(parameters)
' #endregion

' #region radwindow-getting-started_11
Dim parameters As New DialogParameters()
parameters.Content = "Enter your name:"
RadWindow.Confirm(parameters)
' #endregion
End Class
