Public Class Default_Vb


' #region radrichtextbox-features-wire-up-ui-using-radribbonbar_3
Public Sub New()
 InitializeComponent()
 Me.radRichTextBox.Document.PageLayoutSettings.Width = 200
 Me.radRichTextBox.Document.PageLayoutSettings.Height = 300
End Sub
' #endregion

' #region radrichtextbox-features-wire-up-ui-using-radribbonbar_5
Private Sub Bold_Click(sender As Object, e As RoutedEventArgs)
 Me.radRichTextBox.ToggleBold()
End Sub
Private Sub Italic_Click(sender As Object, e As RoutedEventArgs)
 Me.radRichTextBox.ToggleItalic()
End Sub
Private Sub Underline_Click(sender As Object, e As RoutedEventArgs)
 Me.radRichTextBox.ToggleUnderline()
End Sub
' #endregion

' #region radrichtextbox-features-wire-up-ui-using-radribbonbar_7
Private Sub radRtb_CurrentSpanStyleChanged(sender As Object, e As EventArgs)
 Dim currRtbStyle As var = Me.radRtb.CurrentSpanStyle
 Me.Bold.IsChecked = currRtbStyle.FontWeight = FontWeights.Bold
 Me.Italic.IsChecked = currRtbStyle.FontStyle = FontStyles.Italic
 Me.Underline.IsChecked = currRtbStyle.Underline
End Sub
' #endregion
End Class
