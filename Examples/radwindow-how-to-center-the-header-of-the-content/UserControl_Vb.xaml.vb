Public Class Default_Vb


' #region radwindow-how-to-center-the-header-of-the-content_3
Dim textBlock As New TextBlock()
textBlock.Text = "My RadWindow"
textBlock.HorizontalAlignment = HorizontalAlignment.Center
Dim radWindow As New RadWindow()
radWindow.Width = 400
radWindow.Height = 300
radWindow.Style = TryCast(Me.Resources("RadWindowStyle"), Style)
radWindow.Header = textBlock
' #endregion
End Class
