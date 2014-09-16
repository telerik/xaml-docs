Public Class Default_Vb


' #region radrichtextbox-features-styles_0
Me.radRichTextBox.Document.History.Enabled = False
' #endregion

' #region radrichtextbox-features-styles_1
Me.radRichTextBox.Document.History.Clear()
' #endregion

' #region radrichtextbox-features-styles_2
Private Sub UndoAction()
 Me.radRichTextBox.Undo()
End Sub
Private Sub RedoAction()
 Me.radRichTextBox.Redo()
End Sub
' #endregion

' #region radrichtextbox-features-styles_3
Me.radRichTextBox.Document.History.Depth = 500
' #endregion
End Class
