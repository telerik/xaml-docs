Public Class Default_Vb


' #region radrichtextbox-features-positioning_1
Dim currentSpanText As String = Me.radRichTextBox.Document.CaretPosition.GetCurrentSpanBox().Text
' #endregion

' #region radrichtextbox-features-positioning_3
Dim position As New DocumentPosition(Me.radRichTextBox.Document)
Dim currentSpanText As String = position.GetCurrentSpanBox().Text
' #endregion
End Class
