Public Class Default_Vb


' #region radrichtextbox-features-selection_1
Dim startPosition As DocumentPosition = Me.radRichTextBox.Document.CaretPosition
    'new DocumentPosition(this.radRichTextBox.Document);
Dim endPosition As New DocumentPosition(startPosition)
startPosition.MoveToCurrentWordStart()
endPosition.MoveToCurrentWordEnd()
Me.radRichTextBox.Document.Selection.AddSelectionStart(startPosition)
Me.radRichTextBox.Document.Selection.AddSelectionEnd(endPosition)
' #endregion

' #region radrichtextbox-features-selection_3
Dim position As New DocumentPosition(Me.radRichTextBox.Document)
Do
 'GetCurrentSpan().Text returns the word at the position
 Dim word As String = position.GetCurrentSpanBox().Text
 If word.Contains("RadRichTextBox") Then
  Dim wordEndPosition As New DocumentPosition(position)
  wordEndPosition.MoveToCurrentWordEnd()
  Me.radRichTextBox.Document.Selection.AddSelectionStart(position)
  Me.radRichTextBox.Document.Selection.AddSelectionEnd(wordEndPosition)
 End If
Loop While position.MoveToNextWordStart()
' #endregion
End Class
