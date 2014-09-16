Public Class Default_Vb


' #region radwindow-features-working-with-radwindow_1
Dim radWindow As New RadWindow()
radWindow.Width = 400
radWindow.Height = 300
' #endregion

' #region radwindow-features-working-with-radwindow_3
radWindow.Show()
' #endregion

' #region radwindow-features-working-with-radwindow_5
radWindow.ShowDialog()
' #endregion

' #region radwindow-features-working-with-radwindow_7
Dim grid As New Grid()
grid.Background = New SolidColorBrush(Color.FromArgb(255, 240, 255, 255))
radWindow.Content = grid
' #endregion

' #region radwindow-features-working-with-radwindow_10
radWindow.ContentTemplate = TryCast(Me.Resources("WindowContentTemplate"), DataTemplate)
' #endregion
End Class
