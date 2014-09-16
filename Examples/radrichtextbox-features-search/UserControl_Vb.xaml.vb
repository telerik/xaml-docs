Public Class Default_Vb


' #region radrichtextbox-features-search_1
Private Sub SelectAllMatches(ByVal toSearch As String)
 Me.radRichTextBox.Document.Selection.Clear() ' this clears the selection before processing
 Dim search As New DocumentTextSearch(Me.radRichTextBox.Document)
 For Each textRange In search.FindAll(toSearch)
  Me.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition)
  Me.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition)
 Next textRange
End Sub
' #endregion

' #region radrichtextbox-features-search_3
toSearch = Regex.Escape(toSearch)
' #endregion

' #region radrichtextbox-features-search_5
Me.radRichTextBox.ChangeTextHighlightColor(Colors.LightGray) ' will highlight all selected words in LightGray
Me.radRichTextBox.ChangeFontSize(Unit.PointToDip(32)) ' will increase the font size of the words to 30 DIP
Me.radRichTextBox.ChangeFontFamily(New FontFamily("Comic Sans MS")) ' will change the font family of the spans, containing these words.
' #endregion

' #region radrichtextbox-features-search_7
Me.radRichTextBox.Document.Selection.Clear()
' #endregion

' #region radrichtextbox-features-search_9
Private Sub ReplaceAllMatches(ByVal toSearch As String, ByVal toReplaceWith As String)
 Me.radRichTextBox.Document.Selection.Clear() ' this clears the selection before processing
 Dim search As New DocumentTextSearch(Me.radRichTextBox.Document)
 Dim rangesTrackingDocumentChanges As New List(Of TextRange)()
 For Each textRange In search.FindAll(toSearch)
  Dim newRange As New TextRange(New DocumentPosition(textRange.StartPosition, True), New DocumentPosition(textRange.EndPosition, True))
  rangesTrackingDocumentChanges.Add(newRange)
 Next textRange
 For Each textRange In rangesTrackingDocumentChanges
  Me.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition)
  Me.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition)
  Me.radRichTextBox.Insert(toReplaceWith)
  textRange.StartPosition.Dispose()
  textRange.EndPosition.Dispose()
 Next textRange
End Sub
' #endregion
End Class
