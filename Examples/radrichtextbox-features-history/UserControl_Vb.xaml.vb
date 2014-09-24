Public Class Default_Vb


' #region radrichtextbox-features-history_1
Me.radRichTextBox.Document.History.Enabled = False
' #endregion

' #region radrichtextbox-features-history_3
Me.radRichTextBox.Document.History.Clear()
' #endregion

' #region radrichtextbox-features-history_5
Private Sub UndoAction()
 Me.radRichTextBox.Undo()
End Sub
Private Sub RedoAction()
 Me.radRichTextBox.Redo()
End Sub
' #endregion

' #region radrichtextbox-features-history_7
Me.radRichTextBox.Document.History.Depth = 500
' #endregion
End Class
